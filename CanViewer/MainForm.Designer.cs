using System;
using System.Windows.Forms;

namespace CanViewer
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_receiveActive = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_traceActive = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.receiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveToggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traceToggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_receive = new System.Windows.Forms.TabPage();
            this.listView_receive = new System.Windows.Forms.ListView();
            this.coulumnHeader_CANID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CycleTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_trace = new System.Windows.Forms.TabPage();
            this.listBox_trace = new System.Windows.Forms.ListBox();
            this.timer_dataUpdate = new System.Windows.Forms.Timer(this.components);
            this.timer_formUpdate = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_receive.SuspendLayout();
            this.tabPage_trace.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_connectionStatus,
            this.toolStripStatusLabel_receiveActive,
            this.toolStripStatusLabel_traceActive});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(861, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_connectionStatus
            // 
            this.toolStripStatusLabel_connectionStatus.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel_connectionStatus.Name = "toolStripStatusLabel_connectionStatus";
            this.toolStripStatusLabel_connectionStatus.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel_connectionStatus.Text = "Not connected";
            // 
            // toolStripStatusLabel_receiveActive
            // 
            this.toolStripStatusLabel_receiveActive.Name = "toolStripStatusLabel_receiveActive";
            this.toolStripStatusLabel_receiveActive.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel_receiveActive.Text = "Receive active";
            // 
            // toolStripStatusLabel_traceActive
            // 
            this.toolStripStatusLabel_traceActive.Name = "toolStripStatusLabel_traceActive";
            this.toolStripStatusLabel_traceActive.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.receiveToolStripMenuItem,
            this.traceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator1});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.DropDownOpened += new System.EventHandler(this.connectionToolStripMenuItem_DropDownOpened);
            // 
            // connectToToolStripMenuItem
            // 
            this.connectToToolStripMenuItem.Name = "connectToToolStripMenuItem";
            this.connectToToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToToolStripMenuItem.Text = "Connect to";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // receiveToolStripMenuItem
            // 
            this.receiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiveToggleToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.receiveToolStripMenuItem.Name = "receiveToolStripMenuItem";
            this.receiveToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.receiveToolStripMenuItem.Text = "Receive";
            // 
            // receiveToggleToolStripMenuItem
            // 
            this.receiveToggleToolStripMenuItem.Name = "receiveToggleToolStripMenuItem";
            this.receiveToggleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.receiveToggleToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.receiveToggleToolStripMenuItem.Text = "Stop";
            this.receiveToggleToolStripMenuItem.Click += new System.EventHandler(this.receiveToggleToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.receiveClearToolStripMenuItem_Click);
            // 
            // traceToolStripMenuItem
            // 
            this.traceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traceToggleToolStripMenuItem,
            this.clearToolStripMenuItem1});
            this.traceToolStripMenuItem.Name = "traceToolStripMenuItem";
            this.traceToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.traceToolStripMenuItem.Text = "Trace";
            // 
            // traceToggleToolStripMenuItem
            // 
            this.traceToggleToolStripMenuItem.Name = "traceToggleToolStripMenuItem";
            this.traceToggleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.traceToggleToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.traceToggleToolStripMenuItem.Text = "Start";
            this.traceToggleToolStripMenuItem.Click += new System.EventHandler(this.traceToggleToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.traceClearToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutToolStripMenuItem.Text = "About Can Viewer";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_receive);
            this.tabControl1.Controls.Add(this.tabPage_trace);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(861, 512);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_receive
            // 
            this.tabPage_receive.Controls.Add(this.listView_receive);
            this.tabPage_receive.Location = new System.Drawing.Point(4, 22);
            this.tabPage_receive.Name = "tabPage_receive";
            this.tabPage_receive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_receive.Size = new System.Drawing.Size(853, 486);
            this.tabPage_receive.TabIndex = 0;
            this.tabPage_receive.Text = "Receive";
            this.tabPage_receive.UseVisualStyleBackColor = true;
            // 
            // listView_receive
            // 
            this.listView_receive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coulumnHeader_CANID,
            this.columnHeader_Length,
            this.columnHeader_Data,
            this.columnHeader_CycleTime,
            this.columnHeader_Count});
            this.listView_receive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_receive.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_receive.Location = new System.Drawing.Point(3, 3);
            this.listView_receive.Name = "listView_receive";
            this.listView_receive.Size = new System.Drawing.Size(847, 480);
            this.listView_receive.TabIndex = 0;
            this.listView_receive.UseCompatibleStateImageBehavior = false;
            this.listView_receive.View = System.Windows.Forms.View.Details;
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
            // tabPage_trace
            // 
            this.tabPage_trace.Controls.Add(this.listBox_trace);
            this.tabPage_trace.Location = new System.Drawing.Point(4, 22);
            this.tabPage_trace.Name = "tabPage_trace";
            this.tabPage_trace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_trace.Size = new System.Drawing.Size(853, 455);
            this.tabPage_trace.TabIndex = 1;
            this.tabPage_trace.Text = "Trace";
            this.tabPage_trace.UseVisualStyleBackColor = true;
            // 
            // listBox_trace
            // 
            this.listBox_trace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_trace.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_trace.FormattingEnabled = true;
            this.listBox_trace.Location = new System.Drawing.Point(3, 3);
            this.listBox_trace.Name = "listBox_trace";
            this.listBox_trace.ScrollAlwaysVisible = true;
            this.listBox_trace.Size = new System.Drawing.Size(847, 449);
            this.listBox_trace.TabIndex = 0;
            // 
            // timer_dataUpdate
            // 
            this.timer_dataUpdate.Interval = 1;
            this.timer_dataUpdate.Tick += new System.EventHandler(this.timer_dataUpdate_Tick);
            // 
            // timer_formUpdate
            // 
            this.timer_formUpdate.Tick += new System.EventHandler(this.timer_formUpdate_Tick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(861, 558);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Can Viewer - v0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_receive.ResumeLayout(false);
            this.tabPage_trace.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem connectToToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage_receive;
        private TabPage tabPage_trace;
        private ListBox listBox_trace;
        private ListView listView_receive;
        private ColumnHeader coulumnHeader_CANID;
        private ColumnHeader columnHeader_Length;
        private ColumnHeader columnHeader_Data;
        private ColumnHeader columnHeader_CycleTime;
        private ColumnHeader columnHeader_Count;
        private ToolStripStatusLabel toolStripStatusLabel_connectionStatus;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem receiveToolStripMenuItem;
        private ToolStripMenuItem receiveToggleToolStripMenuItem;
        private ToolStripMenuItem traceToolStripMenuItem;
        private Timer timer_dataUpdate;
        private ToolStripMenuItem traceToggleToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripStatusLabel toolStripStatusLabel_receiveActive;
        private ToolStripStatusLabel toolStripStatusLabel_traceActive;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Timer timer_formUpdate;
    }
}

