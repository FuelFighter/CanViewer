using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace CanViewer
{
    public partial class FormCanSendMessageProperties : Form
    {
        private TextBox[] DataTextBoxes;

        public DialogResult Result { get; private set; } = DialogResult.None;

        public ushort CanID { get { return ushort.Parse(textBox_CanID.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture); } }
        public int DataLength { get { return (int)numericUpDown_DataLength.Value; } }
        public byte[] Data { get { return DataTextBoxes.Take(DataLength).Select(t => byte.Parse(t.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture)).ToArray(); } }
        public int CycleTime { get { return int.Parse(textBox_CycleTime.Text); } }
        public bool AutoSend { get { return checkBox_enableAutoSend.Checked; } }

        public FormCanSendMessageProperties(CanSendMessage initialValues)
        {
            InitializeComponent();

            DataTextBoxes = new TextBox[]
            {
                textBox_data0, textBox_data1, textBox_data2, textBox_data3,
                textBox_data4, textBox_data5, textBox_data6, textBox_data7
            };

            textBox_CanID.Text = $"{initialValues.CanID:X03}";
            numericUpDown_DataLength.Value = initialValues.DataLength;
            for (int i = 0; i < initialValues.DataLength; i++) DataTextBoxes[i].Text = $"{initialValues.Data[i]:X02}";
            numericUpDown_DataLength_ValueChanged(null, null);
            textBox_CycleTime.Text = $"{initialValues.CycleTime}";
            checkBox_enableAutoSend.Checked = initialValues.AutoSendEnabled;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Result = DialogResult.OK;
            Close();
        }

        private void numericUpDown_DataLength_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataTextBoxes.Length; i++)
            {
                DataTextBoxes[i].Enabled = (i < numericUpDown_DataLength.Value);
            }
        }

        private void FormCanSendMessageProperties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Result = DialogResult.OK;
                Close();
            }
        }
    }
}
