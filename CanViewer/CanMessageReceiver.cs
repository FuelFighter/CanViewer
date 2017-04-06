using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanViewer
{
    class CanMessageReceiver
    {
        static public bool IsActive { get; private set; } = true;

        static Dictionary<ushort, long> PreviousTimeStamps = new Dictionary<ushort, long>();

        static public void Start(ListView.ListViewItemCollection items)
        {
            IsActive = true;
        }

        static public void Stop()
        {
            IsActive = false;
        }

        static public void Clear(ListView.ListViewItemCollection items)
        {
            items.Clear();
            PreviousTimeStamps.Clear();
        }

        static public void Update(ListView.ListViewItemCollection items)
        {
            if (!IsActive) return;

            CanMessageInfo[] newMessages = CanInterface.GetMessages;

            foreach(CanMessageInfo message in newMessages)
            {
                bool found = false;
                foreach(ListViewItem item in items)
                {
                    if (item.SubItems[0].Text == message.CanId.ToString("X3"))
                    {
                        long lastTimestamp = PreviousTimeStamps[message.CanId];
                        PreviousTimeStamps[message.CanId] = message.TimeStamp;
                        int lastCount = int.Parse(item.SubItems[4].Text);

                        item.SubItems[1].Text = message.Length.ToString();
                        item.SubItems[2].Text = string.Join(" ", message.Data.Select(x => $"{x:X2}"));
                        item.SubItems[3].Text = (message.TimeStamp - lastTimestamp).ToString();
                        item.SubItems[4].Text = (lastCount + 1).ToString();

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    PreviousTimeStamps.Add(message.CanId, message.TimeStamp);
                    items.Add(new ListViewItem(new string[] {
                        message.CanId.ToString("X3"),
                        message.Length.ToString(),
                        string.Join(" ", message.Data.Select(x => $"{x:X2}")),
                        "-", "1" }));
                }
            }
        }
    }
}
