namespace CanViewer
{
    partial class CanSendControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.coulumnHeader_CANID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CycleTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_CycleTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_data7 = new System.Windows.Forms.TextBox();
            this.textBox_data6 = new System.Windows.Forms.TextBox();
            this.textBox_data5 = new System.Windows.Forms.TextBox();
            this.textBox_data4 = new System.Windows.Forms.TextBox();
            this.textBox_data3 = new System.Windows.Forms.TextBox();
            this.textBox_data2 = new System.Windows.Forms.TextBox();
            this.textBox_data1 = new System.Windows.Forms.TextBox();
            this.textBox_data0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CanID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_DataLength = new System.Windows.Forms.NumericUpDown();
            this.checkBox_enableAutoSend = new System.Windows.Forms.CheckBox();
            this.button_sendOnce = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DataLength)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.Controls.Add(this.listView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 523);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(698, 517);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.Leave += new System.EventHandler(this.listView_Leave);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_sendOnce);
            this.groupBox1.Controls.Add(this.checkBox_enableAutoSend);
            this.groupBox1.Controls.Add(this.textBox_CycleTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_data7);
            this.groupBox1.Controls.Add(this.textBox_data6);
            this.groupBox1.Controls.Add(this.textBox_data5);
            this.groupBox1.Controls.Add(this.textBox_data4);
            this.groupBox1.Controls.Add(this.textBox_data3);
            this.groupBox1.Controls.Add(this.textBox_data2);
            this.groupBox1.Controls.Add(this.textBox_data1);
            this.groupBox1.Controls.Add(this.textBox_data0);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_CanID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_DataLength);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(707, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // textBox_CycleTime
            // 
            this.textBox_CycleTime.Enabled = false;
            this.textBox_CycleTime.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CycleTime.Location = new System.Drawing.Point(27, 410);
            this.textBox_CycleTime.Name = "textBox_CycleTime";
            this.textBox_CycleTime.Size = new System.Drawing.Size(100, 28);
            this.textBox_CycleTime.TabIndex = 15;
            this.textBox_CycleTime.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(22, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cycle Time";
            // 
            // textBox_data7
            // 
            this.textBox_data7.Enabled = false;
            this.textBox_data7.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data7.Location = new System.Drawing.Point(162, 272);
            this.textBox_data7.Name = "textBox_data7";
            this.textBox_data7.Size = new System.Drawing.Size(39, 28);
            this.textBox_data7.TabIndex = 13;
            this.textBox_data7.Text = "00";
            // 
            // textBox_data6
            // 
            this.textBox_data6.Enabled = false;
            this.textBox_data6.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data6.Location = new System.Drawing.Point(117, 272);
            this.textBox_data6.Name = "textBox_data6";
            this.textBox_data6.Size = new System.Drawing.Size(39, 28);
            this.textBox_data6.TabIndex = 12;
            this.textBox_data6.Text = "00";
            // 
            // textBox_data5
            // 
            this.textBox_data5.Enabled = false;
            this.textBox_data5.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data5.Location = new System.Drawing.Point(72, 272);
            this.textBox_data5.Name = "textBox_data5";
            this.textBox_data5.Size = new System.Drawing.Size(39, 28);
            this.textBox_data5.TabIndex = 11;
            this.textBox_data5.Text = "00";
            // 
            // textBox_data4
            // 
            this.textBox_data4.Enabled = false;
            this.textBox_data4.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data4.Location = new System.Drawing.Point(27, 272);
            this.textBox_data4.Name = "textBox_data4";
            this.textBox_data4.Size = new System.Drawing.Size(39, 28);
            this.textBox_data4.TabIndex = 10;
            this.textBox_data4.Text = "00";
            // 
            // textBox_data3
            // 
            this.textBox_data3.Enabled = false;
            this.textBox_data3.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data3.Location = new System.Drawing.Point(162, 238);
            this.textBox_data3.Name = "textBox_data3";
            this.textBox_data3.Size = new System.Drawing.Size(39, 28);
            this.textBox_data3.TabIndex = 9;
            this.textBox_data3.Text = "00";
            // 
            // textBox_data2
            // 
            this.textBox_data2.Enabled = false;
            this.textBox_data2.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data2.Location = new System.Drawing.Point(117, 238);
            this.textBox_data2.Name = "textBox_data2";
            this.textBox_data2.Size = new System.Drawing.Size(39, 28);
            this.textBox_data2.TabIndex = 8;
            this.textBox_data2.Text = "00";
            // 
            // textBox_data1
            // 
            this.textBox_data1.Enabled = false;
            this.textBox_data1.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data1.Location = new System.Drawing.Point(72, 238);
            this.textBox_data1.Name = "textBox_data1";
            this.textBox_data1.Size = new System.Drawing.Size(39, 28);
            this.textBox_data1.TabIndex = 7;
            this.textBox_data1.Text = "00";
            // 
            // textBox_data0
            // 
            this.textBox_data0.Enabled = false;
            this.textBox_data0.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data0.Location = new System.Drawing.Point(27, 238);
            this.textBox_data0.Name = "textBox_data0";
            this.textBox_data0.Size = new System.Drawing.Size(39, 28);
            this.textBox_data0.TabIndex = 6;
            this.textBox_data0.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(22, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // textBox_CanID
            // 
            this.textBox_CanID.Enabled = false;
            this.textBox_CanID.Font = new System.Drawing.Font("Lucida Console", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CanID.Location = new System.Drawing.Point(27, 76);
            this.textBox_CanID.Name = "textBox_CanID";
            this.textBox_CanID.Size = new System.Drawing.Size(100, 28);
            this.textBox_CanID.TabIndex = 4;
            this.textBox_CanID.Text = "000";
            this.textBox_CanID.TextChanged += new System.EventHandler(this.textBox_CanID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Can ID";
            // 
            // numericUpDown_DataLength
            // 
            this.numericUpDown_DataLength.Enabled = false;
            this.numericUpDown_DataLength.Location = new System.Drawing.Point(27, 154);
            this.numericUpDown_DataLength.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_DataLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_DataLength.Name = "numericUpDown_DataLength";
            this.numericUpDown_DataLength.Size = new System.Drawing.Size(96, 31);
            this.numericUpDown_DataLength.TabIndex = 1;
            this.numericUpDown_DataLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // checkBox_enableAutoSend
            // 
            this.checkBox_enableAutoSend.AutoSize = true;
            this.checkBox_enableAutoSend.Enabled = false;
            this.checkBox_enableAutoSend.Location = new System.Drawing.Point(27, 444);
            this.checkBox_enableAutoSend.Name = "checkBox_enableAutoSend";
            this.checkBox_enableAutoSend.Size = new System.Drawing.Size(144, 29);
            this.checkBox_enableAutoSend.TabIndex = 16;
            this.checkBox_enableAutoSend.Text = "Auto Send";
            this.checkBox_enableAutoSend.UseVisualStyleBackColor = true;
            // 
            // button_sendOnce
            // 
            this.button_sendOnce.Enabled = false;
            this.button_sendOnce.Location = new System.Drawing.Point(27, 316);
            this.button_sendOnce.Name = "button_sendOnce";
            this.button_sendOnce.Size = new System.Drawing.Size(142, 44);
            this.button_sendOnce.TabIndex = 17;
            this.button_sendOnce.Text = "Send Once";
            this.button_sendOnce.UseVisualStyleBackColor = true;
            // 
            // CanSendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(936, 523);
            this.Name = "CanSendControl";
            this.Size = new System.Drawing.Size(936, 523);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DataLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_DataLength;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader coulumnHeader_CANID;
        private System.Windows.Forms.ColumnHeader columnHeader_Length;
        private System.Windows.Forms.ColumnHeader columnHeader_Data;
        private System.Windows.Forms.ColumnHeader columnHeader_CycleTime;
        private System.Windows.Forms.ColumnHeader columnHeader_Count;
        private System.Windows.Forms.TextBox textBox_data0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CanID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CycleTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_data7;
        private System.Windows.Forms.TextBox textBox_data6;
        private System.Windows.Forms.TextBox textBox_data5;
        private System.Windows.Forms.TextBox textBox_data4;
        private System.Windows.Forms.TextBox textBox_data3;
        private System.Windows.Forms.TextBox textBox_data2;
        private System.Windows.Forms.TextBox textBox_data1;
        private System.Windows.Forms.Button button_sendOnce;
        private System.Windows.Forms.CheckBox checkBox_enableAutoSend;
    }
}
