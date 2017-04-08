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
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveToggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traceToggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_dataUpdate = new System.Windows.Forms.Timer(this.components);
            this.timer_formUpdate = new System.Windows.Forms.Timer(this.components);
            this.tabPage_trace = new System.Windows.Forms.TabPage();
            this.tabPage_send_receive = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.canReceiveControl = new CanViewer.CanReceiveControl();
            this.canSendControl = new CanViewer.CanSendControl();
            this.canTraceControl = new CanViewer.CanTraceControl();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage_trace.SuspendLayout();
            this.tabPage_send_receive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_connectionStatus,
            this.toolStripStatusLabel_receiveActive,
            this.toolStripStatusLabel_traceActive});
            this.statusStrip1.Location = new System.Drawing.Point(0, 831);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1229, 37);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_connectionStatus
            // 
            this.toolStripStatusLabel_connectionStatus.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel_connectionStatus.Name = "toolStripStatusLabel_connectionStatus";
            this.toolStripStatusLabel_connectionStatus.Size = new System.Drawing.Size(174, 32);
            this.toolStripStatusLabel_connectionStatus.Text = "Not connected";
            // 
            // toolStripStatusLabel_receiveActive
            // 
            this.toolStripStatusLabel_receiveActive.Name = "toolStripStatusLabel_receiveActive";
            this.toolStripStatusLabel_receiveActive.Size = new System.Drawing.Size(165, 32);
            this.toolStripStatusLabel_receiveActive.Text = "Receive active";
            // 
            // toolStripStatusLabel_traceActive
            // 
            this.toolStripStatusLabel_traceActive.Name = "toolStripStatusLabel_traceActive";
            this.toolStripStatusLabel_traceActive.Size = new System.Drawing.Size(0, 32);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.sendToolStripMenuItem,
            this.receiveToolStripMenuItem,
            this.traceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 42);
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
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(150, 38);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.DropDownOpened += new System.EventHandler(this.connectionToolStripMenuItem_DropDownOpened);
            // 
            // connectToToolStripMenuItem
            // 
            this.connectToToolStripMenuItem.Name = "connectToToolStripMenuItem";
            this.connectToToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.connectToToolStripMenuItem.Text = "Connect to";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMessageToolStripMenuItem});
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(81, 38);
            this.sendToolStripMenuItem.Text = "Send";
            // 
            // addNewMessageToolStripMenuItem
            // 
            this.addNewMessageToolStripMenuItem.Name = "addNewMessageToolStripMenuItem";
            this.addNewMessageToolStripMenuItem.Size = new System.Drawing.Size(314, 38);
            this.addNewMessageToolStripMenuItem.Text = "Add New Message";
            this.addNewMessageToolStripMenuItem.Click += new System.EventHandler(this.addNewMessageToolStripMenuItem_Click);
            // 
            // receiveToolStripMenuItem
            // 
            this.receiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiveToggleToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.receiveToolStripMenuItem.Name = "receiveToolStripMenuItem";
            this.receiveToolStripMenuItem.Size = new System.Drawing.Size(108, 38);
            this.receiveToolStripMenuItem.Text = "Receive";
            // 
            // receiveToggleToolStripMenuItem
            // 
            this.receiveToggleToolStripMenuItem.Name = "receiveToggleToolStripMenuItem";
            this.receiveToggleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.receiveToggleToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.receiveToggleToolStripMenuItem.Text = "Stop";
            this.receiveToggleToolStripMenuItem.Click += new System.EventHandler(this.receiveToggleToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.receiveClearToolStripMenuItem_Click);
            // 
            // traceToolStripMenuItem
            // 
            this.traceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traceToggleToolStripMenuItem,
            this.clearToolStripMenuItem1});
            this.traceToolStripMenuItem.Name = "traceToolStripMenuItem";
            this.traceToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.traceToolStripMenuItem.Text = "Trace";
            // 
            // traceToggleToolStripMenuItem
            // 
            this.traceToggleToolStripMenuItem.Name = "traceToggleToolStripMenuItem";
            this.traceToggleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.traceToggleToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.traceToggleToolStripMenuItem.Text = "Start";
            this.traceToggleToolStripMenuItem.Click += new System.EventHandler(this.traceToggleToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(203, 38);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.traceClearToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(307, 38);
            this.aboutToolStripMenuItem.Text = "About Can Viewer";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // tabPage_trace
            // 
            this.tabPage_trace.Controls.Add(this.canTraceControl);
            this.tabPage_trace.Location = new System.Drawing.Point(8, 39);
            this.tabPage_trace.Name = "tabPage_trace";
            this.tabPage_trace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_trace.Size = new System.Drawing.Size(1213, 744);
            this.tabPage_trace.TabIndex = 1;
            this.tabPage_trace.Text = "Trace";
            this.tabPage_trace.UseVisualStyleBackColor = true;
            // 
            // tabPage_send_receive
            // 
            this.tabPage_send_receive.Controls.Add(this.splitContainer1);
            this.tabPage_send_receive.Location = new System.Drawing.Point(8, 39);
            this.tabPage_send_receive.Name = "tabPage_send_receive";
            this.tabPage_send_receive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_send_receive.Size = new System.Drawing.Size(1213, 742);
            this.tabPage_send_receive.TabIndex = 0;
            this.tabPage_send_receive.Text = "Send / Receive";
            this.tabPage_send_receive.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.canReceiveControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.canSendControl);
            this.splitContainer1.Size = new System.Drawing.Size(1207, 736);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_send_receive);
            this.tabControl1.Controls.Add(this.tabPage_trace);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1229, 789);
            this.tabControl1.TabIndex = 2;
            // 
            // canReceiveControl
            // 
            this.canReceiveControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canReceiveControl.Location = new System.Drawing.Point(0, 0);
            this.canReceiveControl.Name = "canReceiveControl";
            this.canReceiveControl.Size = new System.Drawing.Size(1207, 232);
            this.canReceiveControl.TabIndex = 0;
            // 
            // canSendControl
            // 
            this.canSendControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canSendControl.Location = new System.Drawing.Point(0, 0);
            this.canSendControl.MinimumSize = new System.Drawing.Size(936, 420);
            this.canSendControl.Name = "canSendControl";
            this.canSendControl.Size = new System.Drawing.Size(1207, 500);
            this.canSendControl.TabIndex = 1;
            // 
            // canTraceControl
            // 
            this.canTraceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canTraceControl.Location = new System.Drawing.Point(3, 3);
            this.canTraceControl.Name = "canTraceControl";
            this.canTraceControl.Size = new System.Drawing.Size(1207, 738);
            this.canTraceControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1229, 868);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Can Viewer - v0.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage_trace.ResumeLayout(false);
            this.tabPage_send_receive.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem connectToToolStripMenuItem;
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
        private TabPage tabPage_trace;
        private TabPage tabPage_send_receive;
        private TabControl tabControl1;
        private CanReceiveControl canReceiveControl;
        private CanTraceControl canTraceControl;
        private SplitContainer splitContainer1;
        private CanSendControl canSendControl;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripMenuItem addNewMessageToolStripMenuItem;
    }
}

