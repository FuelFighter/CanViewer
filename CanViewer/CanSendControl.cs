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
        CanSendMessage SelectedMessage;
        TextBox[] DataTextBoxes;

        public CanSendControl()
        {
            InitializeComponent();
            Messages = new List<CanSendMessage>();
            DataTextBoxes = new TextBox[]
            {
                textBox_data0, textBox_data1, textBox_data2, textBox_data3,
                textBox_data4, textBox_data5, textBox_data6, textBox_data7
            };
        }

        public void AddNewMessage()
        {
            CanSendMessage msg = new CanSendMessage();
            Messages.Add(msg);
            UpdateListView();
        }

        private void UpdatePropertiesPanel()
        {
            if (listView.SelectedItems.Count == 0)
            {
                textBox_CanID.Enabled = false;
                numericUpDown_DataLength.Enabled = false;
                foreach (TextBox txt in DataTextBoxes) txt.Enabled = false;
                button_sendOnce.Enabled = false;
                textBox_CycleTime.Enabled = false;
                checkBox_enableAutoSend.Enabled = false;
                SelectedMessage = null;
            }
            else
            {
                int index = listView.SelectedIndices[0];
                SelectedMessage = Messages[index];
                textBox_CanID.Enabled = true;
                textBox_CanID.Text = $"{SelectedMessage.CanID:X03}";
                numericUpDown_DataLength.Enabled = true;
                numericUpDown_DataLength.Value = SelectedMessage.DataLength;
                for (int i = 0; i < DataTextBoxes.Length; i++)
                {
                    if (i < SelectedMessage.DataLength)
                    {
                        DataTextBoxes[i].Enabled = true;
                        DataTextBoxes[i].Text = $"{SelectedMessage.Data[i]:X02}";
                    }
                    else
                    {
                        DataTextBoxes[i].Enabled = false;
                    }
                }
                button_sendOnce.Enabled = true;
                textBox_CycleTime.Enabled = true;
                textBox_CycleTime.Text = SelectedMessage.CycleTime.ToString();
                checkBox_enableAutoSend.Enabled = true;
            }
        }

        private void UpdateListView()
        {
            listView.Items.Clear();
            listView.Items.AddRange(Messages.Select(m => new ListViewItem(m.ListViewItems)).ToArray());
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePropertiesPanel();
        }

        private void textBox_CanID_TextChanged(object sender, EventArgs e)
        {
            ushort parsedValue;
            if (ushort.TryParse(textBox_CanID.Text, 
                System.Globalization.NumberStyles.HexNumber, 
                System.Globalization.CultureInfo.CurrentCulture, 
                out parsedValue) && 
                parsedValue < (2 << 11))
            {
                SelectedMessage.CanID = parsedValue;
            }
            else
            {
                textBox_CanID.Text = $"{SelectedMessage.CanID:X03}";
            }

            UpdateListView();
        }

        private void listView_Leave(object sender, EventArgs e)
        {

        }
    }

    public class CanSendMessage
    {
        public ushort CanID { get; set; } = 0x000;
        public uint DataLength { get; set; } = 1;
        public byte[] Data { get; set; } = new byte[1];

        public uint CycleTime { get; set; } = 100;
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
