using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mindwave.Controller
{
    public static class Connector
    {
        static int _connectionId;
        static bool _connected;
        static bool _canRead;

        public static bool Connected { get { return _connected; } }

        public static bool CanRead { get { return _canRead; } }

        static Connector()
        {
            _connectionId = NativeThinkgear.TG_GetNewConnectionId();
        }

        public static int Connect(string comPort, int? baudRate = null)
        {
            int statusId = -1;
            var defaultBaudrate = NativeThinkgear.Baudrate.TG_BAUD_9600;
            if (baudRate.HasValue && baudRate.Value > 0)
            {
                defaultBaudrate = (NativeThinkgear.Baudrate)baudRate.Value;
            }

            try
            {
                statusId = NativeThinkgear.TG_Connect(_connectionId,
                comPort,
                defaultBaudrate,
                NativeThinkgear.SerialDataFormat.TG_STREAM_PACKETS);
            }
            catch (Exception) { }

            if (statusId == 0) _connected = true;
            return statusId;
        }

        public static void Disconnect()
        {
            if (_connected)
            {
                NativeThinkgear.TG_Disconnect(_connectionId);

                _connected = false;
                _canRead = false;
            }
        }

        public static float Signal()
        {
            return NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_POOR_SIGNAL);
        }

        public static int Attention()
        {
            return Convert.ToInt32(NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_ATTENTION));
        }

        public static int Meditation()
        {
            return Convert.ToInt32(NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_MEDITATION));
        }

        public static void SetAutoRead()
        {
            var status = NativeThinkgear.TG_EnableAutoRead(_connectionId, 1);
            if (status == 0) _canRead = true;
        }

        public static BrainWaves ReadWaves()
        {
            return new BrainWaves
            {
                Alpha1 = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_ALPHA1),
                Alpha2 = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_ALPHA2),
                Delta = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_DELTA),
                Theta = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_THETA),
                Beta1 = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_BETA1),
                Beta2 = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_BETA2),
                Gamma1 = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_GAMMA1),
                Gamma2 = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_GAMMA2),
                Raw = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_RAW),
                Attention = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_ATTENTION),
                Meditation = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_MEDITATION),
                Signal = NativeThinkgear.TG_GetValue(_connectionId, NativeThinkgear.DataType.TG_DATA_POOR_SIGNAL)
            };
        }
    }
}
