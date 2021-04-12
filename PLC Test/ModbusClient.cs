using System;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;

namespace Modbus_Client
{
    public class ModbusClient
    {
        //Modbus协议的基础类
        public byte[] GetPDU(int type, short add, short value)
        {
            //生成PDU，其他形式的继续重载就行
            //可用于功能码0x01,0x02,0x03,0x04,0x05,0x06
            bool isbigendian = false;//windows是小字节序
            byte[] byteadd = BitConverter.GetBytes(Convert.ToInt16(add + 1));//地址从零开始不用+1
            byte[] bytevalue = BitConverter.GetBytes(value);
            if (!isbigendian)//如果是小字节序，需要调换一下位置
            {
                byte temp = byteadd[0];
                byteadd[0] = byteadd[1];
                byteadd[1] = temp;
                temp = bytevalue[0];
                bytevalue[0] = bytevalue[1];
                bytevalue[1] = temp;
            }
            byte[] pdu = new byte[byteadd.Length + bytevalue.Length + 1];
            pdu[0] = Convert.ToByte(type);
            Buffer.BlockCopy(byteadd, 0, pdu, 1, byteadd.Length);
            Buffer.BlockCopy(bytevalue, 0, pdu, byteadd.Length + 1, bytevalue.Length);
            return pdu;
        }

        public byte[] GetPDU(int type, short add, ushort value)
        {
            //生成PDU，其他形式的继续重载就行
            //可用于功能码0x01,0x02,0x03,0x04,0x05,0x06
            bool isbigendian = false;//windows是小字节序
            byte[] byteadd = BitConverter.GetBytes(Convert.ToInt16(add + 1));//地址从零开始不用+1
            byte[] bytevalue = BitConverter.GetBytes(value);
            if (!isbigendian)//如果是小字节序，需要调换一下位置
            {
                byte temp = byteadd[0];
                byteadd[0] = byteadd[1];
                byteadd[1] = temp;
                temp = bytevalue[0];
                bytevalue[0] = bytevalue[1];
                bytevalue[1] = temp;
            }
            byte[] pdu = new byte[byteadd.Length + bytevalue.Length + 1];
            pdu[0] = Convert.ToByte(type);
            Buffer.BlockCopy(byteadd, 0, pdu, 1, byteadd.Length);
            Buffer.BlockCopy(bytevalue, 0, pdu, byteadd.Length + 1, bytevalue.Length);
            return pdu;
        }

        public byte[] GetPDU(int type, short add, float value)
        {
            //生成PDU，其他形式的继续重载就行
            //可用于功能码0x10
            bool isbigendian = false;//windows是小字节序
            byte[] byteadd = BitConverter.GetBytes(Convert.ToInt16(add + 1));//地址从零开始不用+1
            byte[] bytevalue = BitConverter.GetBytes(value);
            byte[] mid = { 0x00, 0x02, 0x04 };
            if (!isbigendian)//如果是小字节序，需要调换一下位置
            {
                byte temp = byteadd[0];
                byteadd[0] = byteadd[1];
                byteadd[1] = temp;
            }
            byte[] pdu = new byte[byteadd.Length + mid.Length + bytevalue.Length + 1];
            pdu[0] = Convert.ToByte(type);
            Buffer.BlockCopy(byteadd, 0, pdu, 1, byteadd.Length);
            Buffer.BlockCopy(mid, 0, pdu, byteadd.Length + 1, mid.Length);
            Buffer.BlockCopy(bytevalue, 0, pdu, byteadd.Length + mid.Length + 1, bytevalue.Length);
            return pdu;
        }
    }

    public class ModbusTCPClient : ModbusClient
    {
        //用于ModbusTCP的类
        public Socket newclient;

        public void Connect(IPEndPoint ie)
        {
            //建立TCP连接
            newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newclient.Connect(ie);
        }

        public void Disconnect()
        {
            //关闭TCP连接
            newclient.Close();
        }

        public byte[] GetTCPFrame(int type, short add, short value)
        {
            //组装TCP帧
            byte[] pdu = this.GetPDU(type, add, value);
            byte pdulength = Convert.ToByte(pdu.Length + 1);
            byte[] tcphead = { 0x00, 0x01, 0x00, 0x00, 0x00, pdulength, 0x01 };
            byte[] tcpframe = new byte[pdu.Length + tcphead.Length];
            Buffer.BlockCopy(tcphead, 0, tcpframe, 0, tcphead.Length);
            Buffer.BlockCopy(pdu, 0, tcpframe, tcphead.Length, pdu.Length);
            return tcpframe;
        }

        public byte[] GetTCPFrame(int type, short add, ushort value)
        {
            //组装TCP帧
            byte[] pdu = this.GetPDU(type, add, value);
            byte pdulength = Convert.ToByte(pdu.Length + 1);
            byte[] tcphead = { 0x00, 0x01, 0x00, 0x00, 0x00, pdulength, 0x01 };
            byte[] tcpframe = new byte[pdu.Length + tcphead.Length];
            Buffer.BlockCopy(tcphead, 0, tcpframe, 0, tcphead.Length);
            Buffer.BlockCopy(pdu, 0, tcpframe, tcphead.Length, pdu.Length);
            return tcpframe;
        }

        public byte[] GetTCPFrame(int type, short add, float value)
        {
            //组装TCP帧
            byte[] pdu = this.GetPDU(type, add, value);
            byte pdulength = Convert.ToByte(pdu.Length + 1);
            byte[] tcphead = { 0x00, 0x01, 0x00, 0x00, 0x00, pdulength, 0x01 };
            byte[] tcpframe = new byte[pdu.Length + tcphead.Length];
            Buffer.BlockCopy(tcphead, 0, tcpframe, 0, tcphead.Length);
            Buffer.BlockCopy(pdu, 0, tcpframe, tcphead.Length, pdu.Length);
            return tcpframe;
        }

        public byte[] Send(int type, short add, short value)
        {
            //发送功能码，并返回生成的功能码
            byte[] data = GetTCPFrame(type, add, value);
            newclient.Send(data);
            return (data);
        }

        public byte[] Send(int type, short add, ushort value)
        {
            //发送功能码，并返回生成的功能码
            byte[] data = GetTCPFrame(type, add, value);
            newclient.Send(data);
            return (data);
        }

        public byte[] Send(int type, short add, float value)
        {
            //发送功能码，并返回生成的功能码
            byte[] data = GetTCPFrame(type, add, value);
            newclient.Send(data);
            return (data);
        }

        public void Send(byte[] data)
        {
            //重载一个可以发送任何数组的方法
            newclient.Send(data);
        }

        public byte[] ReceiveMessage()
        {
            //接受信息
            byte[] data = new byte[1024];
            newclient.Receive(data);
            return data;
        }
    }

    public class ModbusRTUClient : ModbusClient
    {
        //用于ModbusRTU的类
        public SerialPort comm = new SerialPort();
        public SerialPort _comm = new SerialPort();

        public void Connect(string com)
        {
            //建立RTU连接
            comm.PortName = com;
            comm.BaudRate = 9600;
            comm.Parity = Parity.None;
            comm.StopBits = StopBits.One;
            comm.DataBits = 8;
            comm.ReadBufferSize = 1024;

            comm.Open();
        }

        public void SetReceiveEvent(Action<object, SerialDataReceivedEventArgs> ReceMes)
        {
            //传入用于接收数据的方法
            comm.DataReceived += new SerialDataReceivedEventHandler(ReceMes);
        }

        public void Disconnect()
        {
            //关闭RTU连接
            comm.Close();
        }

        public byte[] GetRTUFrame(int type, short add, short value)
        {
            //组装RTU帧
            byte[] pdu = this.GetPDU(type, add, value);
            byte[] frame = new byte[pdu.Length + 1];
            frame[0] = 1;
            Buffer.BlockCopy(pdu, 0, frame, 1, pdu.Length);
            byte[] rtuframe = new byte[frame.Length + 2];
            string crcs = getCrc16Code(frame);
            frame.CopyTo(rtuframe, 0);
            rtuframe[frame.Length] = byte.Parse(crcs.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            rtuframe[frame.Length + 1] = byte.Parse(crcs.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);

            return rtuframe;
        }

        public byte[] Send(int type, short add, short value)
        {
            //发送功能码，并返回生成的功能码
            byte[] data = GetRTUFrame(type, add, value);
            comm.Write(data, 0, data.Length);
            return data;
        }

        public void Send(byte[] data)
        {
            //重载一个可以发送任何数组的方法
            byte[] rtudata = new byte[data.Length + 2];
            string crcs = getCrc16Code(data);
            data.CopyTo(rtudata, 0);
            rtudata[data.Length] = byte.Parse(crcs.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            rtudata[data.Length + 1] = byte.Parse(crcs.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            comm.Write(rtudata, 0, data.Length);
        }

        public byte[] ReceiveMessage(SerialPort com)
        {
            byte[] data = new byte[1024];//定义数据接收数组
            int length = comm.BytesToRead;
            com.Read(data, 0, comm.BytesToRead);  //注意，read方法运行后bytestoread会归0，所以length定义要在前面。
            byte[] datashow = new byte[length];//定义所要显示的接收的数据的长度
            for (int i = 0; i < length; i++)//将要显示的数据存放到数组datashow中
            {
                datashow[i] = data[i];
            }
            return datashow;
        }

        public String getCrc16Code(byte[] crcbyte)
        {
            // 生成CRC校验码
            // 转换成字节数组  
            // 开始crc16校验码计算  
            CRC16Util crc16 = new CRC16Util();
            crc16.update(crcbyte);
            uint crc = crc16.getCrcValue();//使用uint是因为使用int时最高位为1会变为负数。
            // 16进制的CRC码  
            String crcCode = Convert.ToString(crc, 16).ToUpper();
            // 补足到4位  
            if (crcCode.Length < 4)
            {
                crcCode = crcCode.PadLeft(4, '0');
            }
            return crcCode;
        }
    }

    public class ModbusUDPClient : ModbusClient
    {
        //用于ModbusUDP的类
        public Socket udpclient;
        public const int Local_Port = 8081; //本地Socket绑定端口
        public const int RecTimeOut = 1500; //超时时间

        public void Connect(int Port = Local_Port)
        {
            //建立UDP Socket
            IPEndPoint localiep = new IPEndPoint(IPAddress.Any, Port);
            udpclient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpclient.Bind(localiep);
        }

        public void Disconnect()
        {
            //关闭UDP连接
            udpclient.Dispose();
            udpclient.Close();
        }

        public byte[] GetUDPFrame(int type, short add, short value,int device=1)
        {
            //组装UDP帧
            byte[] pdu = this.GetPDU(type, add, value);
            byte pdulength = Convert.ToByte(pdu.Length + 1);
            byte deviceb = Convert.ToByte(device);
            byte[] udphead = { 0x00, 0x01, 0x00, 0x00, 0x00, pdulength, deviceb };
            byte[] udpframe = new byte[pdu.Length + udphead.Length];
            Buffer.BlockCopy(udphead, 0, udpframe, 0, udphead.Length);
            Buffer.BlockCopy(pdu, 0, udpframe, udphead.Length, pdu.Length);
            return udpframe;
        }

        public byte[] GetUDPFrame(int type, short add, ushort value, int device = 1)
        {
            //组装UDP帧
            byte[] pdu = this.GetPDU(type, add, value);
            byte pdulength = Convert.ToByte(pdu.Length + 1);
            byte deviceb = Convert.ToByte(device);
            byte[] udphead = { 0x00, 0x01, 0x00, 0x00, 0x00, pdulength, deviceb };
            byte[] udpframe = new byte[pdu.Length + udphead.Length];
            Buffer.BlockCopy(udphead, 0, udpframe, 0, udphead.Length);
            Buffer.BlockCopy(pdu, 0, udpframe, udphead.Length, pdu.Length);
            return udpframe;
        }

        public byte[] GetUDPFrame(int type, short add, float value, int device = 1)
        {
            //组装UDP帧
            byte[] pdu = this.GetPDU(type, add, value);
            byte pdulength = Convert.ToByte(pdu.Length + 1);
            byte deviceb = Convert.ToByte(device);
            byte[] udphead = { 0x00, 0x01, 0x00, 0x00, 0x00, pdulength, deviceb };
            byte[] udpframe = new byte[pdu.Length + udphead.Length];
            Buffer.BlockCopy(udphead, 0, udpframe, 0, udphead.Length);
            Buffer.BlockCopy(pdu, 0, udpframe, udphead.Length, pdu.Length);
            return udpframe;
        }

        public byte[] Send(int type, short add, short value, IPEndPoint ie, int device=1, bool CRCopen=false)
        {
            //发送功能码，并返回生成的功能码
            if (CRCopen)
            {
                byte[] data = GetUDPFrame(type, add, value, device);
                byte[] crcdata = new byte[data.Length + 2];
                string crcs = getCrc16Code(data);
                data.CopyTo(crcdata, 0);
                crcdata[data.Length] = byte.Parse(crcs.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                crcdata[data.Length + 1] = byte.Parse(crcs.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                udpclient.SendTo(crcdata, ie);
                return data;
            }
            else
            {
                byte[] data = GetUDPFrame(type, add, value, device);
                udpclient.SendTo(data, ie);
                return data;
            }
        }

        public byte[] Send(int type, short add, ushort value, IPEndPoint ie, int device = 1, bool CRCopen = false)
        {
            //发送功能码，并返回生成的功能码
            if (CRCopen)
            {
                byte[] data = GetUDPFrame(type, add, value, device);
                byte[] crcdata = new byte[data.Length + 2];
                string crcs = getCrc16Code(data);
                data.CopyTo(crcdata, 0);
                crcdata[data.Length] = byte.Parse(crcs.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                crcdata[data.Length + 1] = byte.Parse(crcs.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                udpclient.SendTo(crcdata, ie);
                return data;
            }
            else
            {
                byte[] data = GetUDPFrame(type, add, value, device);
                udpclient.SendTo(data, ie);
                return data;
            }
        }

        public byte[] Send(int type, short add, float value, IPEndPoint ie, int device = 1, bool CRCopen = false)
        {
            //发送功能码，并返回生成的功能码
            if (CRCopen)
            {
                byte[] data = GetUDPFrame(type, add, value, device);
                byte[] crcdata = new byte[data.Length + 2];
                string crcs = getCrc16Code(data);
                data.CopyTo(crcdata, 0);
                crcdata[data.Length] = byte.Parse(crcs.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                crcdata[data.Length + 1] = byte.Parse(crcs.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                udpclient.SendTo(crcdata, ie);
                return data;
            }
            else
            {
                byte[] data = GetUDPFrame(type, add, value, device);
                udpclient.SendTo(data, ie);
                return data;
            }
        }

        public void Send(byte[] data, IPEndPoint ie)
        {
            //重载一个可以发送任何数组的方法
            udpclient.SendTo(data, ie);
        }

        public byte[] ReceiveMessage(IPEndPoint remote)
        {
            //接受信息
            UdpClient udpreceive = new UdpClient(remote);
            EndPoint remoteEP = (EndPoint)remote;
            byte[] data = udpreceive.Receive(ref remote);
            int length = data[5];//读取数据长度
            Byte[] datashow = new byte[length + 6];//定义所要显示的接收的数据的长度
            for (int i = 0; i < length + 6; i++)//将要显示的数据存放到数组datashow中
            {
                if (i == data.Length)
                {
                    break;
                }
                datashow[i] = data[i];
            }
            udpreceive.Close();
            return data;
        }

        public String getCrc16Code(byte[] crcbyte)
        {
            // 生成CRC校验码
            // 转换成字节数组  
            // 开始crc16校验码计算  
            CRC16Util crc16 = new CRC16Util();
            crc16.update(crcbyte);
            uint crc = crc16.getCrcValue();//使用uint是因为使用int时最高位为1会变为负数。
            // 16进制的CRC码  
            String crcCode = Convert.ToString(crc, 16).ToUpper();
            // 补足到4位  
            if (crcCode.Length < 4)
            {
                crcCode = crcCode.PadLeft(4, '0');
            }
            return crcCode;
        }
    }

    public class CRC16Util
    {
        //一个用于获取CRC校验码的类
        private uint value = 0x0000;

        static byte[] ArrayCRCHigh =
         {
         0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
         0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
         0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
         0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
         0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
         0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
         0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
         0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
         0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
         0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40,
         0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
         0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
         0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
         0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40,
         0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
         0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
         0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
         0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
         0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
         0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
         0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
         0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40,
         0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
         0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
         0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
         0x80, 0x41, 0x00, 0xC1, 0x81, 0x40
         };

        static byte[] checkCRCLow =
        {
         0x00, 0xC0, 0xC1, 0x01, 0xC3, 0x03, 0x02, 0xC2, 0xC6, 0x06,
         0x07, 0xC7, 0x05, 0xC5, 0xC4, 0x04, 0xCC, 0x0C, 0x0D, 0xCD,
         0x0F, 0xCF, 0xCE, 0x0E, 0x0A, 0xCA, 0xCB, 0x0B, 0xC9, 0x09,
         0x08, 0xC8, 0xD8, 0x18, 0x19, 0xD9, 0x1B, 0xDB, 0xDA, 0x1A,
         0x1E, 0xDE, 0xDF, 0x1F, 0xDD, 0x1D, 0x1C, 0xDC, 0x14, 0xD4,
         0xD5, 0x15, 0xD7, 0x17, 0x16, 0xD6, 0xD2, 0x12, 0x13, 0xD3,
         0x11, 0xD1, 0xD0, 0x10, 0xF0, 0x30, 0x31, 0xF1, 0x33, 0xF3,
         0xF2, 0x32, 0x36, 0xF6, 0xF7, 0x37, 0xF5, 0x35, 0x34, 0xF4,
         0x3C, 0xFC, 0xFD, 0x3D, 0xFF, 0x3F, 0x3E, 0xFE, 0xFA, 0x3A,
         0x3B, 0xFB, 0x39, 0xF9, 0xF8, 0x38, 0x28, 0xE8, 0xE9, 0x29,
         0xEB, 0x2B, 0x2A, 0xEA, 0xEE, 0x2E, 0x2F, 0xEF, 0x2D, 0xED,
         0xEC, 0x2C, 0xE4, 0x24, 0x25, 0xE5, 0x27, 0xE7, 0xE6, 0x26,
         0x22, 0xE2, 0xE3, 0x23, 0xE1, 0x21, 0x20, 0xE0, 0xA0, 0x60,
         0x61, 0xA1, 0x63, 0xA3, 0xA2, 0x62, 0x66, 0xA6, 0xA7, 0x67,
         0xA5, 0x65, 0x64, 0xA4, 0x6C, 0xAC, 0xAD, 0x6D, 0xAF, 0x6F,
         0x6E, 0xAE, 0xAA, 0x6A, 0x6B, 0xAB, 0x69, 0xA9, 0xA8, 0x68,
         0x78, 0xB8, 0xB9, 0x79, 0xBB, 0x7B, 0x7A, 0xBA, 0xBE, 0x7E,
         0x7F, 0xBF, 0x7D, 0xBD, 0xBC, 0x7C, 0xB4, 0x74, 0x75, 0xB5,
         0x77, 0xB7, 0xB6, 0x76, 0x72, 0xB2, 0xB3, 0x73, 0xB1, 0x71,
         0x70, 0xB0, 0x50, 0x90, 0x91, 0x51, 0x93, 0x53, 0x52, 0x92,
         0x96, 0x56, 0x57, 0x97, 0x55, 0x95, 0x94, 0x54, 0x9C, 0x5C,
         0x5D, 0x9D, 0x5F, 0x9F, 0x9E, 0x5E, 0x5A, 0x9A, 0x9B, 0x5B,
         0x99, 0x59, 0x58, 0x98, 0x88, 0x48, 0x49, 0x89, 0x4B, 0x8B,
         0x8A, 0x4A, 0x4E, 0x8E, 0x8F, 0x4F, 0x8D, 0x4D, 0x4C, 0x8C,
         0x44, 0x84, 0x85, 0x45, 0x87, 0x47, 0x46, 0x86, 0x82, 0x42,
         0x43, 0x83, 0x41, 0x81, 0x80, 0x40
         };
        //计算一个字节数组的CRC值 
        public void update(byte[] data)
        {
            byte CRCHigh = 0xFF;
            byte CRCLow = 0xFF;
            byte index;
            int i = 0;
            int al = data.Length;
            while (al-- > 0)
            {
                index = (Byte)(CRCHigh ^ data[i++]);
                CRCHigh = (Byte)(CRCLow ^ ArrayCRCHigh[index]);
                CRCLow = checkCRCLow[index];
            }
            value = (UInt16)(CRCHigh << 8 | CRCLow);
        }

        public uint getCrcValue()
        {
            return value;
        }
    }
}
