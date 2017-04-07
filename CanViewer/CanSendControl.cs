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
    public class CanSendMessage
    {
        public ushort CanID { get; set; } = 0x000;
        public uint DataLength { get; set; } = 1;
        public byte[] Data { get; set; } = new byte[1];

        public uint CycleTime { get; set; } = 100;
        public bool AutoSendEnabled { get; set; } = false;

        public string TransmissionString
        {
            get
            {
                return $"[{CanID:03X}:{DataLength}:{string.Join("", Data.Select(b => $"{b:02X}"))}]";
            }
        }
    }

    public partial class CanSendControl : UserControl
    {
        public CanSendControl()
        {
            InitializeComponent();
        }

        private void numericUpDown_CanId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
