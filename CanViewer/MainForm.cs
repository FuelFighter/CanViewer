﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //timer_dataUpdate.Start();
            timer_formUpdate.Start();
        }

        private void connectionToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            connectToToolStripMenuItem.DropDownItems.Clear();
            foreach (string portName in CanInterface.GetAvailablePortNames())
            {
                ToolStripButton item = new ToolStripButton(portName);
                item.Click += toolStripItemComPortClick;
                connectToToolStripMenuItem.DropDownItems.Add(item);
            }

            if (connectToToolStripMenuItem.DropDownItems.Count == 0)
            {
                connectToToolStripMenuItem.DropDownItems.Add("No UM detected");
                connectToToolStripMenuItem.DropDownItems[0].Enabled = false;
            }
        }

        private void toolStripItemComPortClick(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            bool success = CanInterface.ConnectToPort(button.Text);
            while (!success)
            {
                DialogResult result = MessageBox.Show("COM port unavailable! Is putty open?", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    success = CanInterface.ConnectToPort(button.Text);
                }
                else break;
            }

            updateGraphics();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanInterface.Disconnect();

            updateGraphics();
        }

        private void timer_dataUpdate_Tick(object sender, EventArgs e)
        {
            //CanInterface.ProcessReceivedData();
        }

        private void timer_formUpdate_Tick(object sender, EventArgs e)
        {
            canTraceControl.UpdateMessages();
            canReceiveControl.UpdateMessages();
            if (canReceiveControl.IsActive)
            {
                canChannelsControl1.UpdateMessages();
                canChannelsControl2.UpdateMessages();
            }
            CanInterface.ClearBuffer();
        }

        private void traceToggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (canTraceControl.IsActive) canTraceControl.StopTracer();
            else canTraceControl.StartTracer();

            updateGraphics();
        }

        private void traceClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canTraceControl.ClearMessages();
        }

        private void receiveToggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (canReceiveControl.IsActive) canReceiveControl.StopReceiver();
            else canReceiveControl.StartReceiver();

            updateGraphics();
        }

        private void receiveClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canReceiveControl.ClearMessages();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CanInterface.Disconnect();
        }

        private void updateGraphics()
        {
            if (CanInterface.IsConnected)
            {
                disconnectToolStripMenuItem.Enabled = true;
                toolStripStatusLabel_connectionStatus.ForeColor = Color.ForestGreen;
            }
            else
            {
                disconnectToolStripMenuItem.Enabled = false;
                toolStripStatusLabel_connectionStatus.ForeColor = Color.Red;
            }
            toolStripStatusLabel_connectionStatus.Text = CanInterface.ConnectionStatus;

            if (canReceiveControl.IsActive)
            {
                receiveToggleToolStripMenuItem.Text = "Stop";
                toolStripStatusLabel_receiveActive.Text = "Receive active";
            }
            else
            {
                receiveToggleToolStripMenuItem.Text = "Start";
                toolStripStatusLabel_receiveActive.Text = "";
            }

            if (canTraceControl.IsActive)
            {
                traceToggleToolStripMenuItem.Text = "Stop";
                toolStripStatusLabel_traceActive.Text = "Trace active";
            }
            else
            {
                traceToggleToolStripMenuItem.Text = "Start";
                toolStripStatusLabel_traceActive.Text = "";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Can Viewer was made by Sondre Andersen for DNV GL Fuel Fighter 2017.\nIt is made to receive can messages using an Universal Module (UM) programmed with the accompanying .bin file.",
                "About Can Viewer version 0.4 Beta");
        }

        private void addNewMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canSendControl.AddNewMessage();
        }

        private void reinitParseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanChannelsControl.InitializeChannels();
            MessageBox.Show($"Added these channels from the file:\n{string.Join("\n", CanChannelsControl.Channels.Select(l => $"From 0x{l.Key:X03}:\n\t{string.Join("\n\t", l.Value.Select(c => c.Name).ToArray())}").ToArray())}");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CanChannelsControl.InitializeChannels();
        }

        private void clearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            canChannelsControl1.Clear();
            canChannelsControl2.Clear();
        }
    }
}
