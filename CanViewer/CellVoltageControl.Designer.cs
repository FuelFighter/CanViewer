namespace CanViewer
{
    partial class CellVoltageControl
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
            this.components = new System.ComponentModel.Container();
            this.timer_staleData = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_staleData
            // 
            this.timer_staleData.Interval = 1000;
            this.timer_staleData.Tick += new System.EventHandler(this.timer_staleData_Tick);
            // 
            // CellVoltageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CellVoltageControl";
            this.Size = new System.Drawing.Size(222, 202);
            this.Load += new System.EventHandler(this.CellVoltageControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CellVoltageControl_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_staleData;
    }
}
