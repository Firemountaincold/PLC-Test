using System;
using System.Net;
using Modbus_Client;

namespace PLC_Test
{
    class ModbusUDPClientForFSU : ModbusUDPClient
    {
        private const short BaseVDadd = 3916;      // VD区对应的Modbus寄存器地址

        private short GetVDadd(short vd)
        {
            //转换为VD区地址
            return Convert.ToInt16(vd + BaseVDadd);
        }

        public byte[] SendToFSU(int type, short add, short value, IPEndPoint ie, bool VD, int device = 1, bool CRCopen = false)
        {
            if (VD)
            {
                add = GetVDadd(add);
            }
            byte[] data = Send(type, add, value, ie, device, CRCopen);
            return data;
        }

        public byte[] SendToFSU(int type, short add, ushort value, IPEndPoint ie, bool VD, int device = 1, bool CRCopen = false)
        {
            if (VD)
            {
                add = GetVDadd(add);
            }
            byte[] data = Send(type, add, value, ie, device, CRCopen);
            return data;
        }

        public byte[] SendToFSU(int type, short add, float value, IPEndPoint ie, bool VD, int device = 1, bool CRCopen = false)
        {
            if (VD)
            {
                add = GetVDadd(add);
            }
            byte[] data = Send(type, add, value, ie, device, CRCopen);
            return data;
        }
    }
}
