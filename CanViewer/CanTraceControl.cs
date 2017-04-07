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
    public partial class CanTraceControl : UserControl
    {
        public bool IsActive { get; private set; } = false;

        public CanTraceControl()
        {
            InitializeComponent();
        }

        public void StartTracer()
        {
            IsActive = true;
        }

        public void StopTracer()
        {
            IsActive = false;
        }

        public void ClearMessages()
        {
            listBox.Items.Clear();
        }

        public void UpdateMessages()
        {
            if (!IsActive) return;
            listBox.Items.AddRange(CanInterface.GetMessages);
        }
    }
}
