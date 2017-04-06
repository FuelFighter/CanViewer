using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanViewer
{
    public partial class TraceControl : ListBox
    {
        public bool IsActive { get; private set; } = false;

        public TraceControl()
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
            Items.Clear();
        }

        public void UpdateMessages()
        {
            if (!IsActive) return;
            Items.AddRange(CanInterface.GetMessages);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
