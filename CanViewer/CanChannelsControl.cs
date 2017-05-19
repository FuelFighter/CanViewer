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
    public partial class CanChannelsControl : UserControl
    {
        static public Dictionary<ushort, List<CanChannel>> Channels;

        public CanChannelsControl()
        {
            InitializeComponent();
            ListViewHelper.EnableDoubleBuffer(listView_channels);
        }

        static public void InitializeChannels()
        {
            Channels = new Dictionary<ushort, List<CanChannel>>();
            foreach (string line in System.IO.File.ReadAllLines("channel_definitions.txt"))
            {
                if (line.Length == 0 || line[0] == ';') continue;
                CanChannel c = new CanChannel(line);
                if (Channels.ContainsKey(c.CanID)) Channels[c.CanID].Add(c);
                else Channels.Add(c.CanID, new List<CanChannel>() { c });
            }
        }

        bool MatchesFilter(string text)
        {
            if (textBox_filter.Text == "") return true;

            if (textBox_filter.Text.Length >= 3 && textBox_filter.Text.First() == '/' && textBox_filter.Text.Last() == '/')
            {
                try
                {
                    var r = new System.Text.RegularExpressions.Regex(textBox_filter.Text.Substring(1, textBox_filter.Text.Length - 2));
                    return r.IsMatch(text);
                }
                catch (Exception ex) { return false; }
            }
            else
            {
                return text.Contains(textBox_filter.Text);
            }
        }

        public void UpdateMessages()
        {
            CanMessageInfo[] msg = CanInterface.GetMessages;

            foreach (CanMessageInfo message in msg)
            {
                if (Channels.ContainsKey(message.CanId))
                {
                    foreach (CanChannel c in Channels[message.CanId])
                    {
                        bool found = false;
                        foreach (ListViewItem item in listView_channels.Items)
                        {
                            if (item.SubItems[0].Text == c.Name)
                            {
                                item.SubItems[1].Text = c.FormatMessage(message);
                                found = true;
                            }
                        }

                        if (!found)
                        {
                            if (MatchesFilter(c.Name))
                                listView_channels.Items.Add(new ListViewItem(new string[] {
                                c.Name,
                                c.FormatMessage(message)
                            }));

                            listView_channels.Sort();
                        }
                    }
                }
            }
        }

        private void textBox_filter_TextChanged(object sender, EventArgs e)
        {
            if (textBox_filter.Text == "") return;

            List<ListViewItem> items = new List<ListViewItem>();

            foreach(ListViewItem i in listView_channels.Items)
            {
                if (MatchesFilter(i.Text))
                {
                    items.Add(i);
                }
            }

            //ListViewItem[] items = listView_channels.Items.Find(textBox_filter.Text, true);
            listView_channels.Items.Clear();
            listView_channels.Items.AddRange(items.ToArray());
            listView_channels.Sort();
        }

        public void Clear()
        {
            listView_channels.Items.Clear();
        }
    }

    public class CanChannel
    {
        public ushort CanID { get; private set; }
        public string Name { get; private set; }
        public int Offset { get; private set; }
        public string Datatype { get; private set; }
        public double Scaling { get; private set; } = 1;
        public int Decimals { get; private set; } = 0;

        public CanChannel(string definition)
        {
            string[] parts = definition.Trim().Split(',');
            Name = parts[0].Trim();
            CanID = ushort.Parse(parts[1].Trim(), System.Globalization.NumberStyles.HexNumber);
            Offset = int.Parse(parts[2].Trim());
            Datatype = parts[3].Trim();
            if (parts.Length > 4) Scaling = double.Parse(parts[4].Trim());
            if (parts.Length > 5) Decimals = int.Parse(parts[5].Trim());
        }

        public string FormatMessage(CanMessageInfo msg)
        {
            if (Datatype[0] == '[')
            {
                int index = msg.Data[Offset];
                string[] items = Datatype.Trim('[', ']').Split('|');
                if (index < items.Length) return items[index];
                else return $"Unlabeled ({index})";
            }

            switch (Datatype)
            {
                case "U8":
                    return Math.Round(Scaling * ((byte)msg.Data[Offset]), Decimals).ToString();
                case "S8":
                    return Math.Round(Scaling * ((sbyte)msg.Data[Offset]), Decimals).ToString();
                case "U16":
                    return Math.Round(Scaling * BitConverter.ToUInt16(msg.Data, Offset), Decimals).ToString();
                case "S16":
                    return Math.Round(Scaling * BitConverter.ToInt16(msg.Data, Offset), Decimals).ToString();
                case "U32":
                    return Math.Round(Scaling * BitConverter.ToUInt32(msg.Data, Offset), Decimals).ToString();
                case "S32":
                    return Math.Round(Scaling * BitConverter.ToInt32(msg.Data, Offset), Decimals).ToString();
                case "U64":
                    return Math.Round(Scaling * BitConverter.ToUInt64(msg.Data, Offset), Decimals).ToString();
                case "S64":
                    return Math.Round(Scaling * BitConverter.ToInt64(msg.Data, Offset), Decimals).ToString();
                case "F32":
                    return Math.Round(Scaling * BitConverter.ToSingle(msg.Data, Offset), Decimals).ToString();
                case "F64":
                    return Math.Round(Scaling * BitConverter.ToDouble(msg.Data, Offset), Decimals).ToString();

                case "b0": return ((msg.Data[Offset] & (1 << 0)) != 0).ToString();
                case "b1": return ((msg.Data[Offset] & (1 << 1)) != 0).ToString();
                case "b2": return ((msg.Data[Offset] & (1 << 2)) != 0).ToString();
                case "b3": return ((msg.Data[Offset] & (1 << 3)) != 0).ToString();
                case "b4": return ((msg.Data[Offset] & (1 << 4)) != 0).ToString();
                case "b5": return ((msg.Data[Offset] & (1 << 5)) != 0).ToString();
                case "b6": return ((msg.Data[Offset] & (1 << 6)) != 0).ToString();
                case "b7": return ((msg.Data[Offset] & (1 << 7)) != 0).ToString();
                default: throw new Exception($"Unknown datatype format specifier {Datatype}!");
            }
        }
    }
}
