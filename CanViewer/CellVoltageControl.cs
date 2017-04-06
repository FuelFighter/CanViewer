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
    public partial class CellVoltageControl : UserControl
    {
        const int NumberOfCells = 4;

        private ushort[] CellVoltageValue;
        private bool StaleData;

        public CellVoltageControl()
        {
            InitializeComponent();
        }

        public void UpdateCellVoltages(ushort[] values)
        {
            if (values.Length != NumberOfCells) throw new ArgumentException($"Expected {NumberOfCells} values, got {values.Length}!");

            for (int i = 0; i < NumberOfCells; i++)
            {
                CellVoltageValue[i] = values[i];
            }

            StaleData = false;
            timer_staleData.Stop();
            timer_staleData.Start();
            Invalidate();
        }

        private void CellVoltageControl_Load(object sender, EventArgs e)
        {
            CellVoltageValue = new ushort[NumberOfCells];
            StaleData = true;
        }

        private void timer_staleData_Tick(object sender, EventArgs e)
        {
            StaleData = true;
            timer_staleData.Stop();
            Invalidate();
        }

        private void CellVoltageControl_Paint(object sender, PaintEventArgs e)
        {
            for (int c = 0; c < NumberOfCells; c++)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, 5, 5 + (5 + 20) * c, 100, 20);
                e.Graphics.FillRectangle(StaleData ? Brushes.Gray : Brushes.Green, 5, 5 + (5 + 20) * c, 100 * (float)CellVoltageValue[c] / 43000, 20);
            }
        }
    }
}
