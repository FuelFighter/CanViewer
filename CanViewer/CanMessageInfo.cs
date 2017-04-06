using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CanViewer
{
    class CanMessageInfo
    {
        static System.Diagnostics.Stopwatch TimeStamper = new System.Diagnostics.Stopwatch();

        static public void ResetTimeStamper()
        {
            TimeStamper.Restart();
        }
        
        public ushort CanId;
        public byte[] Data;

        static public long GetCurrentTimestamp()
        {
            return TimeStamper.ElapsedMilliseconds;
        }

        public int Length;
        public long TimeStamp;

        static public CanMessageInfo CreateFromString(ref string message)
        {
            CanMessageInfo messageInfo = new CanMessageInfo();

            Regex parse_regex = new Regex("^(\\n)?\\[(?<id>...):(?<length>.):(?<data>.*)\\]");
            Match match = parse_regex.Match(message);

            if (!match.Success) return null;

            message = message.Substring(match.Length);

            messageInfo.CanId = ushort.Parse(match.Groups["id"].Value, System.Globalization.NumberStyles.HexNumber);
            messageInfo.Length = int.Parse(match.Groups["length"].Value);
            messageInfo.Data = new byte[messageInfo.Length];

            for (int i = 0; i < messageInfo.Length; i++)
            {
                messageInfo.Data[i] = byte.Parse(match.Groups["data"].Value.Substring(2 * i, 2), System.Globalization.NumberStyles.HexNumber);
            }

            messageInfo.TimeStamp = TimeStamper.ElapsedMilliseconds;

            return messageInfo;
        }

        public override string ToString()
        {
            return $"{TimeStamp,6}: {CanId:X3} - {Length} - {string.Join(" ", Data.Select(x => $"{x:X2}"))}";
        }
    }
}
