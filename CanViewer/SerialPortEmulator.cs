using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CanViewer
{
    class SerialPortEmulator
    {
        private Random RandomRng;
        private Random PsudoRng;
        private Thread DataReceiveThread;

        public bool IsOpen { get { return DataReceiveThread.IsAlive; } }
        public string PortName { get; private set; }
        public event SerialDataReceivedEventHandler DataReceived;

        private ushort CanId;
        private int Period;
        private int DataLength;

        public SerialPortEmulator(string port, int baud, Parity parity, int dataBits, StopBits stopBits)
        {
            PortName = port;
            RandomRng = new Random();
            PsudoRng = new Random(PortName.GetHashCode());
            DataReceiveThread = new Thread(GenerateEvents);

            CanId = (ushort)(PsudoRng.Next(0xFFE));
            Period = PsudoRng.Next(10, 30);
            DataLength = PsudoRng.Next(1, 9);
        }

        static public string[] GetPortNames()
        {
            return new string[] { "Fake-COM1", "Fake-COM2", "Fake-COM3" };
        }

        public string ReadExisting()
        {
            byte[] Data = new byte[DataLength];
            RandomRng.NextBytes(Data);

            return $"[{(CanId):X3}:{Data.Length}:{string.Join("", Data.Select(x => $"{x:X2}"))}]\n";
        }

        public void Open()
        {
            DataReceiveThread.Start();
        }

        public void Close()
        {
            DataReceiveThread.Abort();
        }

        private void GenerateEvents()
        {
            while (true)
            {
                Thread.Sleep(Period);// + RandomRng.Next(-5, 5));
                DataReceived(null, null);
            }
        }
    }
}
