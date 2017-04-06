using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanViewer
{
    class CanMessageTracer
    {
        static public bool IsActive { get; private set; } = false;

        static public void Start(ListBox.ObjectCollection items)
        {
            IsActive = true;
        }

        static public void Stop()
        {
            IsActive = false;
        }

        static public void Clear(ListBox.ObjectCollection items)
        {
            items.Clear();
        }

        static public void Update(ListBox.ObjectCollection items)
        {
            if (!IsActive) return;
            items.AddRange(CanInterface.GetMessages);
        }
    }
}
