using System.Windows.Forms;

namespace CanViewer
{
    partial class CanChannelsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_channels = new System.Windows.Forms.ListView();
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_filter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_channels
            // 
            this.listView_channels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_name,
            this.columnHeader_value});
            this.listView_channels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_channels.Location = new System.Drawing.Point(3, 40);
            this.listView_channels.Name = "listView_channels";
            this.listView_channels.Size = new System.Drawing.Size(942, 550);
            this.listView_channels.TabIndex = 0;
            this.listView_channels.UseCompatibleStateImageBehavior = false;
            this.listView_channels.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "Channel Name";
            this.columnHeader_name.Width = 167;
            // 
            // columnHeader_value
            // 
            this.columnHeader_value.Text = "Channel Value";
            this.columnHeader_value.Width = 336;
            // 
            // textBox_filter
            // 
            this.textBox_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_filter.Location = new System.Drawing.Point(3, 3);
            this.textBox_filter.Name = "textBox_filter";
            this.textBox_filter.Size = new System.Drawing.Size(942, 31);
            this.textBox_filter.TabIndex = 1;
            this.textBox_filter.TextChanged += new System.EventHandler(this.textBox_filter_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_filter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView_channels, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 593);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CanChannelsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CanChannelsControl";
            this.Size = new System.Drawing.Size(948, 593);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView_channels;
        private ColumnHeader columnHeader_name;
        private ColumnHeader columnHeader_value;
        private TextBox textBox_filter;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
