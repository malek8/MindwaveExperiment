using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindwave.Controller;

namespace Mindwave.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionId = NativeThinkgear.TG_GetNewConnectionId();
            NativeThinkgear.TG_Connect(connectionId, "COM3", NativeThinkgear.Baudrate.TG_BAUD_57600, NativeThinkgear.SerialDataFormat.TG_STREAM_PACKETS);
            System.Threading.Thread.Sleep(200);

            NativeThinkgear.TG_EnableAutoRead(connectionId, 1);
            System.Threading.Thread.Sleep(100);

            while(true)
            {
                var signal = NativeThinkgear.TG_GetValue(connectionId, NativeThinkgear.DataType.TG_DATA_POOR_SIGNAL);
                System.Console.WriteLine(signal);
            }
            System.Console.ReadLine();
        }
    }
}
