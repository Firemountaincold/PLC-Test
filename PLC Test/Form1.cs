using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.Sockets;
using System.Xml;
using System.Diagnostics;
using Modbus_Client;

namespace PLC_Test
{
    public partial class Form1 : Form
    {
        //声明类
        BindingSource bindingPLC = new BindingSource();
        BindingSource bindingTest = new BindingSource();
        ModbusTCPClient tcpClient = new ModbusTCPClient();
        //标志
        public bool isConnectTCP = false;
        //线程
        public Thread receThread;
        public Thread testThread;
        //全局量
        public int timer = 0;
        public Form1()
        {
            InitializeComponent();
            dataGridPLC.DataSource = bindingPLC;
            dataGridPLC.AutoGenerateColumns = false;
            dataGridtest.DataSource = bindingTest;
            dataGridtest.AutoGenerateColumns = false;
        }

        public void AddInfo(string info, int type)
        {
            //创建运行日志，1表示测试信息+换行，2表示警告信息+换行，3表示信息本身
            if (type == 1)
            {
                textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.AppendText("["); }));
                AddColorInfo("测试", Color.Green);
                textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.AppendText("]" + DateTime.Now + " " + info + "\r\n");})); 
            }
            else if (type == 2)
            {
                textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.AppendText("["); }));
                AddColorInfo("警告", Color.Red);
                textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.AppendText("]" + DateTime.Now + " " + info + "\r\n"); }));
            }
            else if (type == 3)
            {
                textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.AppendText(info); }));
            }
        }

        public void AddColorInfo(string info, Color color)
        {
            //用于输出带颜色的信息
            textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.SelectionStart = textBoxinfo.TextLength; }));
            textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.SelectionLength = 0; }));
            textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.SelectionColor = color; }));
            textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.AppendText(info); }));
            textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.SelectionColor = textBoxinfo.ForeColor; }));
            textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.ScrollToCaret(); }));
        }

        private void bloadconfig_Click(object sender, EventArgs e)
        {
            //加载配置文件
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (!Directory.Exists(Application.StartupPath + "\\设备配置"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\设备配置");
                }
                openFileDialog.InitialDirectory = Application.StartupPath + "\\设备配置";
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "XML文件(*.xml;*.xaml)|*.xml;*.xaml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string xmlstr = File.ReadAllText(path);
                    bindingPLC.DataSource = null;
                    DataTable loadxml = XmlToDataTable(xmlstr);
                    bindingPLC.DataSource = loadxml;
                    AddInfo("已加载配置文件：" + path, 1);
                    bindingPLC.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                AddInfo(ex.Message, 2);
            }
        }

        private void bsaveconfig_Click(object sender, EventArgs e)
        {
            //保存配置文件
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML文件(*.xml;*.xaml)|*.xml;*.xaml";
                if (!Directory.Exists(Application.StartupPath + "\\设备配置"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\设备配置");
                }
                saveFileDialog.InitialDirectory = Application.StartupPath + "\\设备配置";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    DataTable dt = DataGridViewToTable(dataGridPLC);
                    dt.TableName = "PLC";
                    dt.WriteXml(path);
                    AddInfo("已保存配置文件：" + path, 1);
                }
            }
            catch (Exception ex)
            {
                AddInfo(ex.Message, 2);
            }
        }

        private void buttonloadtest_Click(object sender, EventArgs e)
        {
            //加载测试流程
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (!Directory.Exists(Application.StartupPath + "\\测试流程"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\测试流程");
                }
                openFileDialog.InitialDirectory = Application.StartupPath+"\\测试流程";
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "Excel文件(*.xlsx)|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    bindingTest.DataSource = null;
                    DataTable dtexcel = UseExcel.ReadDataFromExcel(path, "Sheet1");
                    bindingTest.DataSource = dtexcel;
                    bindingTest.ResetBindings(false);
                    AddInfo("已加载测试流程：" + path, 1);
                }
            }
            catch (Exception ex)
            {
                AddInfo(ex.Message, 2);
            }
        }

        private void buttonstarttest_Click(object sender, EventArgs e)
        {
            try
            {
                TestModel[] testModels = Readtest();
                PLCModel[] plcModels = ReadPLC();
                ThreadClass tc = new ThreadClass(testModels, plcModels, Convert.ToInt32(textBoxepoch.Text));
                testThread = new Thread(new ParameterizedThreadStart(Test));
                testThread.Start(tc);
            }
            catch(Exception ex)
            {
                AddInfo(ex.Message, 2);
            }
        }

        private void buttonendtest_Click(object sender, EventArgs e)
        {
            try
            {
                testThread.Abort();
                tcpClient.Disconnect();
                this.Invoke(new Action(() => { timerTest.Stop(); }));
                timer = 0;
                AddColorInfo("测试已主动结束。\r\n", Color.Red);
            }
            catch(Exception ex)
            {
                AddInfo(ex.Message, 2);
            }
        }

        public DataTable DataGridViewToTable(DataGridView dgv)
        {
            //将datagridview里的数据转化为datatable
            DataTable dt = new DataTable();

            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count - 1; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public DataTable XmlToDataTable(string xmlStr)
        {
            //读取xml配置文件
            if (!string.IsNullOrEmpty(xmlStr))
            {
                StringReader StrStream = null;
                XmlTextReader Xmlrdr = null;
                try
                {
                    DataSet ds = new DataSet();
                    //读取字符串中的信息  
                    StrStream = new StringReader(xmlStr);
                    //获取StrStream中的数据  
                    Xmlrdr = new XmlTextReader(StrStream);
                    //ds获取Xmlrdr中的数据                 
                    ds.ReadXml(Xmlrdr);
                    return ds.Tables[0];
                }
                catch (Exception e)
                {
                    AddInfo(e.Message, 2);
                }
                finally
                {
                    //释放资源  
                    if (Xmlrdr != null)
                    {
                        Xmlrdr.Close();
                        StrStream.Close();
                        StrStream.Dispose();
                    }
                }
            }
            return null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭窗口
            if (MessageBox.Show("是否退出？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void checkBoxsavelog_CheckedChanged(object sender, EventArgs e)
        {
            //选择是否保存日志
            if (!Directory.Exists(Application.StartupPath + "\\运行日志"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\运行日志");
            }
            if (checkBoxsavelog.Checked)
            {
                timersavelog.Start();
            }
            else
            {
                timersavelog.Stop();
            }
        }

        private void timersavelog_Tick(object sender, EventArgs e)
        {
            //开启后每5秒自动保存日志
            timersavelog.Interval = 5000;
            string path = Application.StartupPath + "\\运行日志\\" + DateTime.Today.ToString("yyyy-MM-dd") + ".txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Flush();
            sw.Write(textBoxinfo.Text);
            sw.Close();
        }

        public TestModel[] Readtest()
        {
            //把测试datagridview里的数据读到testmodel类的列表里
            TestModel[] testModels = new TestModel[dataGridtest.Rows.Count - 1];
            TestModel.testi = 0;
            for (int i = 0; i < dataGridtest.Rows.Count - 1; i++)
            {
                testModels[TestModel.testi] = new TestModel();
                testModels[TestModel.testi].settime = Convert.ToInt32(dataGridtest.Rows[i].Cells[0].Value);
                testModels[TestModel.testi].PLCindex = Convert.ToInt32(dataGridtest.Rows[i].Cells[1].Value);
                testModels[TestModel.testi].objectindex = Convert.ToInt32(dataGridtest.Rows[i].Cells[2].Value);
                testModels[TestModel.testi].function = Convert.ToString(dataGridtest.Rows[i].Cells[3].Value);
                testModels[TestModel.testi].funcadd = Convert.ToInt32(dataGridtest.Rows[i].Cells[4].Value);
                testModels[TestModel.testi].funcvalue = Convert.ToInt32(dataGridtest.Rows[i].Cells[5].Value);
                TestModel.testi++;
            }
            return testModels;
        }

        public PLCModel[] ReadPLC()
        {
            //把PLCdatagridview里的数据读到plcmodel类的列表里
            PLCModel[] plcModels = new PLCModel[dataGridPLC.Rows.Count - 1];
            PLCModel.plci = 0;
            for (int i = 0; i < dataGridPLC.Rows.Count - 1; i++)
            {
                plcModels[PLCModel.plci] = new PLCModel();
                plcModels[PLCModel.plci].PLCid = Convert.ToInt32(dataGridPLC.Rows[i].Cells[0].Value);
                plcModels[PLCModel.plci].PLCname = Convert.ToString(dataGridPLC.Rows[i].Cells[1].Value);
                plcModels[PLCModel.plci].PLCip = Convert.ToString(dataGridPLC.Rows[i].Cells[2].Value);
                plcModels[PLCModel.plci].PLCport = Convert.ToString(dataGridPLC.Rows[i].Cells[3].Value);
                PLCModel.plci++;
            }
            return plcModels;
        }

        public void ConnectTCP(string sip, string sport)
        {
            //创建TCP连接
            string ipaddress = sip.Trim();
            int port = Convert.ToInt32(sport.Trim());//读取ip和端口号

            //检测IP格式是否正确
            IPAddress ipa;
            if (!System.Net.IPAddress.TryParse(ipaddress, out ipa))
            {
                AddInfo("未提供有效的IP地址。", 2);
            }
            //创建套接字
            else
            {
                IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ipaddress), port);
                //连接服务器
                try
                {
                    tcpClient.Connect(ie);
                    isConnectTCP = true;
                }
                catch (SocketException e)
                {
                    AddInfo("未能连接到PLC。" + e.Message, 2);
                    return;
                }
            }
        }

        public int ReciMsg()
        {
            //接受回复,一次两个
            byte[] data = new byte[1024];
            byte[] data2 = new byte[1024];//定义数据接收数组
            try
            {
                data = tcpClient.ReceiveMessage();//接收数据到data数组
                data2 = tcpClient.ReceiveMessage();

                int length = data2[5];//读取数据长度
                Byte[] datashow = new byte[length + 6];//定义所要显示的接收的数据的长度
                for (int i = 0; i <= length + 5; i++)//将要显示的数据存放到数组datashow中
                {
                    datashow[i] = data2[i];
                }
                int value = datashow[9] | datashow[10];//把数组转换成16进制字符串
                return value;
            }
            catch (Exception e)
            {
                AddInfo("连接出现了错误。" + e.Message, 2);
            }
            return -1;
        }
        public void Test(object tc)
        {
            this.Invoke(new Action(() => { timerTest.Start(); }));
            int num = 1;
            foreach (TestModel tm in (tc as ThreadClass).tms)
            {
                //读取每一个测试的数据
                int time = tm.settime;
                int PLCid = tm.PLCindex;
                int objectid = tm.objectindex;
                string method = tm.function;
                string ip;
                string port;
                short add = Convert.ToInt16(tm.funcadd.ToString(), 16);
                short value = Convert.ToInt16(tm.funcvalue.ToString(), 16);
                foreach (PLCModel pm in (tc as ThreadClass).pms)
                {
                    if (pm.PLCid == PLCid)
                    {
                        ip = pm.PLCip;
                        port = pm.PLCport;
                        ConnectTCP(ip, port);
                        AddInfo("已连接到" + tm.PLCindex + "号PLC: " + pm.PLCname, 1);
                    }
                }
                //发送数据，收到回复，比较
                try
                {
                    Thread.Sleep((tm.settime - timer) * 1000);
                    AddInfo("第" + timer + "秒，开始第" + num.ToString() + "项测试：", 1);
                    for (int i = 0; i < (tc as ThreadClass).epoch; i++)
                    {
                        //发送写的功能码
                        tcpClient.Send(0x06, add, value);
                        //发送读的功能码
                        tcpClient.Send(0x03, add, Convert.ToInt16(1));
                        //接收数据
                        int returnvalue = ReciMsg();
                        AddInfo("第" + (i + 1).ToString() + "轮测试：\r\n    将" + add.ToString() +
                            "寄存器的数据写为" + value.ToString() + ".\r\n    再次读取到的数据为" + returnvalue.ToString() + "。", 1);
                        if (value == returnvalue)
                        {
                            AddColorInfo("第" + (i + 1).ToString() + "轮测试通过。\r\n", Color.Green);
                        }
                        else
                        {
                            AddColorInfo("第" + (i + 1).ToString() + "轮测试未能通过。\r\n", Color.Red);
                        }
                        Thread.Sleep(1);
                    }
                }
                catch (Exception ex)
                {
                    AddInfo(ex.Message, 2);
                }
                num++;
            }
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            //记录测试时间
            timerTest.Interval = 1000;
            timer++;
        }
    }
}
