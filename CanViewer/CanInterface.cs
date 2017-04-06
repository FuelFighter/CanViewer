using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

// Comment this line to disable emulation
// using SerialPort = CanViewer.SerialPortEmulator;

namespace CanViewer
{
    class CanInterface
    {
        const int DefaultBaudRate = 500000;
        const Parity DefaultParity = Parity.None;
        const int DefaultDataBits = 8;
        const StopBits DefaultStopBits = StopBits.One;

        static private SerialPort ActiveSerialPort = null;
        static private string UnprocessedIncomingData = "";
        static private List<CanMessageInfo> BufferedMessages = new List<CanMessageInfo>();

        static public string ConnectionStatus
        {
            get
            {
                if (ActiveSerialPort == null || !ActiveSerialPort.IsOpen) return "Not connected";
                else return $"Connected to {ActiveSerialPort.PortName}";
            }
        }

        static public bool IsConnected { get { return (ActiveSerialPort != null && ActiveSerialPort.IsOpen); } }

        static public CanMessageInfo[] GetMessages { get { return BufferedMessages.ToArray(); } }

        static public string[] GetAvailablePortNames()
        {
            return SerialPort.GetPortNames();
        }

        static public bool ConnectToPort(string text)
        {
            if (ActiveSerialPort != null && ActiveSerialPort.IsOpen)
            {
                ActiveSerialPort.Close();
            }

            ActiveSerialPort = new SerialPort(text, DefaultBaudRate, DefaultParity, DefaultDataBits, DefaultStopBits);
            ActiveSerialPort.DataReceived += ActiveSerialPort_DataReceived;

            try
            {
                ActiveSerialPort.Open();
            }
            catch (Exception)
            {
                return false;
            }

            CanMessageInfo.ResetTimeStamper();
            return true;
        }

        static public void Disconnect()
        {
            if (ActiveSerialPort != null) ActiveSerialPort.Close();
        }

        static public void ClearBuffer()
        {
            BufferedMessages.Clear();
        }

        private static void ActiveSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            UnprocessedIncomingData += ActiveSerialPort.ReadExisting();

            while (UnprocessedIncomingData.Length > 0 && UnprocessedIncomingData[0] != '[')
            {
                // Discard any uncomplete messages at the beginning
                UnprocessedIncomingData = UnprocessedIncomingData.Substring(1);
            }

            CanMessageInfo info;

            info = CanMessageInfo.CreateFromString(ref UnprocessedIncomingData);
            while (info != null)
            {
                BufferedMessages.Add(info);
                info = CanMessageInfo.CreateFromString(ref UnprocessedIncomingData);
            }
        }
    }
}
