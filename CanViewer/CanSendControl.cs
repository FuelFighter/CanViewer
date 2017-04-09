using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanViewer
{
    public partial class CanSendControl : UserControl
    {
        List<CanSendMessage> Messages;

        public CanSendControl()
        {
            InitializeComponent();
            Messages = new List<CanSendMessage>();
        }

        public void AddNewMessage()
        {
            CanSendMessage msg = new CanSendMessage();
            if (Messages.Count > 0)
            {
                msg.CanID = (ushort)((Messages.Last().CanID + 1) % 0x7FF);
                msg.DataLength = Messages.Last().DataLength;
                msg.CycleTime = Messages.Last().CycleTime;
            }

            Messages.Add(msg);
            UpdateListView();
        }

        private void UpdateListView()
        {
            listView.Items.Clear();
            listView.Items.AddRange(Messages.Select(m => new ListViewItem(m.ListViewItems)).ToArray());
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count > 0)
            {
                CanSendMessage msg = Messages[listView.SelectedIndices[0]];

                FormCanSendMessageProperties f = new FormCanSendMessageProperties(msg);
                f.ShowDialog();

                if (f.Result == DialogResult.OK)
                {
                    try
                    {
                        ushort canid = f.CanID;
                        if (canid >= (1 << 11)) throw new ArgumentOutOfRangeException();
                        msg.CanID = canid;
                        msg.DataLength = f.DataLength;
                        msg.Data = f.Data;
                        msg.CycleTime = f.CycleTime;
                        msg.AutoSendEnabled = f.AutoSend;
                    }
                    catch (ArgumentOutOfRangeException ex) { MessageBox.Show("Value out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    catch (Exception ex) { MessageBox.Show("Invalid format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    UpdateListView();
                }
            }
        }

        private void listView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listView.SelectedIndices.Count > 0)
                {
                    Messages.RemoveAt(listView.SelectedIndices[0]);
                }

                UpdateListView();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (listView.SelectedIndices.Count > 0)
                {
                    CanInterface.SendMessage(Messages[listView.SelectedIndices[0]].TransmissionString);
                }

                UpdateListView();
            }
        }
    }

    public class CanSendMessage
    {
        public ushort CanID { get; set; } = 0x000;
        public int DataLength { get; set; } = 1;
        public byte[] Data { get; set; } = new byte[1];

        public int CycleTime { get; set; } = 100;
        public bool AutoSendEnabled { get; set; } = false;

        public uint SendCount { get; set; } = 0;

        public string TransmissionString
        {
            get
            {
                return $"[{CanID:X03}:{DataLength}:{string.Join("", Data.Select(b => $"{b:X02}"))}]";
            }
        }

        public string[] ListViewItems
        {
            get
            {
                return new string[] { $"{CanID:X03}", $"{DataLength}", $"{string.Join(" ", Data.Select(b => $"{b:X02}"))}", $"{CycleTime}", $"{SendCount}" };
            }
        }
    }
}
