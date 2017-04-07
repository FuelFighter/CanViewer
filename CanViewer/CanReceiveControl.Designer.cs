using System;
using System.Windows.Forms;

namespace CanViewer
{
    partial class CanReceiveControl
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
            this.listView = new System.Windows.Forms.ListView();
            this.coulumnHeader_CANID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CycleTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coulumnHeader_CANID,
            this.columnHeader_Length,
            this.columnHeader_Data,
            this.columnHeader_CycleTime,
            this.columnHeader_Count});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(964, 595);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // coulumnHeader_CANID
            // 
            this.coulumnHeader_CANID.Text = "CAN ID";
            this.coulumnHeader_CANID.Width = 87;
            // 
            // columnHeader_Length
            // 
            this.columnHeader_Length.Text = "Length";
            this.columnHeader_Length.Width = 85;
            // 
            // columnHeader_Data
            // 
            this.columnHeader_Data.Text = "Data";
            this.columnHeader_Data.Width = 420;
            // 
            // columnHeader_CycleTime
            // 
            this.columnHeader_CycleTime.Text = "Cycle Time";
            this.columnHeader_CycleTime.Width = 130;
            // 
            // columnHeader_Count
            // 
            this.columnHeader_Count.Text = "Count";
            this.columnHeader_Count.Width = 83;
            // 
            // CanReceiveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Name = "CanReceiveControl";
            this.Size = new System.Drawing.Size(964, 595);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView;
        private ColumnHeader coulumnHeader_CANID;
        private ColumnHeader columnHeader_Length;
        private ColumnHeader columnHeader_Data;
        private ColumnHeader columnHeader_CycleTime;
        private ColumnHeader columnHeader_Count;
    }
}
