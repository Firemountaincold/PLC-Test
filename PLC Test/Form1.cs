﻿using Modbus_Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace PLC_Test
{
    public partial class Form1 : Form
    {
        //声明类
        BindingSource bindingPLC = new BindingSource();
        BindingSource bindingTest = new BindingSource();
        BindingSource bindingobject = new BindingSource();
        ModbusTCPClient tcpClient = new ModbusTCPClient();
        ModbusTCPClient objClient = new ModbusTCPClient();
        //标志
        public bool isConnectTCP = false;
        public bool isSingleTest = true;
        public bool isPassTest = false;
        //线程
        public Thread receThread;
        public Thread testThread;
        //全局量
        public int timer = 0;
        public int pass = 0;
        public int nopass = 0;
        //默认配置
        string defualtPLC = ConfigurationManager.AppSettings["DefaultPLC"];
        string defualtObject = ConfigurationManager.AppSettings["DefaultObject"];
        string defualtTest = ConfigurationManager.AppSettings["DefaultTest"];
        public Form1()
        {
            InitializeComponent();
            dataGridPLC.DataSource = bindingPLC;
            dataGridPLC.AutoGenerateColumns = false;
            dataGridtest.DataSource = bindingTest;
            dataGridtest.AutoGenerateColumns = false;
            dataGridObject.DataSource = bindingobject;
            dataGridObject.AutoGenerateColumns = false;
            //加载配置文件
            textBoxPLCip.Text = ConfigurationManager.AppSettings["TestIP"];
            textBoxtestport.Text = ConfigurationManager.AppSettings["TestPort"];
            textBoxPLCid.Text = ConfigurationManager.AppSettings["TestID"];
            textBoxepoch.Text = ConfigurationManager.AppSettings["Testepoch"];
            //加载本地IP
            List<string> PCIPArray = Function.GetLocalIp();
            foreach (String ip in PCIPArray)
            {
                comboBoxlocalIP.Items.Add(ip);
            }

        }

        public void LoadDefualtConfig(string testpath, string plcpath, string objpath)
        {
            //加载默认配置
            try
            {
                bindingTest.DataSource = null;
                DataTable dtexcel = Function.ReadDataFromExcel(testpath, "Sheet1");
                bindingTest.DataSource = dtexcel;
                bindingTest.ResetBindings(false);
                AddInfo("已加载默认测试流程。", 1);

                string xmlstr = File.ReadAllText(plcpath);
                bindingPLC.DataSource = null;
                DataTable loadxml = XmlToDataTable(xmlstr);
                bindingPLC.DataSource = loadxml;
                AddInfo("已加载默认PLC配置文件。", 1);
                bindingPLC.ResetBindings(false);

                string xmlstr2 = File.ReadAllText(objpath);
                bindingobject.DataSource = null;
                DataTable loadxml2 = XmlToDataTable(xmlstr2);
                bindingobject.DataSource = loadxml2;
                AddInfo("已加载Object配置文件。", 1);
                bindingobject.ResetBindings(false);
            }
            catch(Exception ex)
            {
                AddInfo(ex.Message, 2);
            }
        }

        public void AddInfo(string info, int type)
        {
            //创建运行日志，1表示测试信息+换行，2表示警告信息+换行，3表示信息本身
            if (type == 1)
            {
                textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.AppendText("["); }));
                AddColorInfo("测试", Color.Green);
                textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.AppendText("]" + DateTime.Now + " " + info + "\r\n"); }));
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
            textBoxinfo.BeginInvoke(new Action(() => { textBoxinfo.ScrollToCaret(); }));
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
            //加载PLC配置文件
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
                    AddInfo("已加载PLC配置文件：" + path, 1);
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
            //保存PLC配置文件
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
                    AddInfo("已保存PLC配置文件：" + path, 1);
                }
            }
            catch (Exception ex)
            {
                AddInfo(ex.Message, 2);
            }
        }

        private void bsaveconfigo_Click(object sender, EventArgs e)
        {
            //保存object配置文件
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
                    DataTable dt = DataGridViewToTable(dataGridObject);
                    dt.TableName = "Object";
                    dt.WriteXml(path);
                    AddInfo("已保存Object配置文件：" + path, 1);
                }
            }
            catch (Exception ex)
            {
                AddInfo(ex.Message, 2);
            }
        }

        private void bloadconfigo_Click(object sender, EventArgs e)
        {
            //加载object配置文件
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
                    bindingobject.DataSource = null;
                    DataTable loadxml = XmlToDataTable(xmlstr);
                    bindingobject.DataSource = loadxml;
                    AddInfo("已加载Object配置文件：" + path, 1);
                    bindingobject.ResetBindings(false);
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
                openFileDialog.InitialDirectory = Application.StartupPath + "\\测试流程";
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "Excel文件(*.xlsx)|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    bindingTest.DataSource = null;
                    DataTable dtexcel = Function.ReadDataFromExcel(path, "Sheet1");
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
            if (textBoxepoch.Text == "")
            {
                MessageBox.Show("请输入测试次数。");
                return;
            }
            try
            {
                TestModel[] testModels = Readtest();
                PLCModel[] plcModels = ReadPLC();
                ObjectModel[] objectModels = ReadObject();
                AddInfo("已载入测试，本次测试共有" + testModels.Length.ToString() + "项，每项重复" + textBoxepoch.Text + "轮。", 1);
                ThreadClass tc = new ThreadClass(testModels, plcModels, objectModels, Convert.ToInt32(textBoxepoch.Text));
                if (!isSingleTest)
                {
                    testThread = new Thread(new ParameterizedThreadStart(CircleTest));
                    testThread.Start(tc);
                }
                else
                {
                    testThread = new Thread(new ParameterizedThreadStart(SingleTest));
                    testThread.Start(tc);
                }
            }
            catch (Exception ex)
            {
                AddInfo(ex.Source + "发生错误。" + ex.Message, 2);
            }
        }

        private void buttonendtest_Click(object sender, EventArgs e)
        {
            try
            {
                isConnectTCP = false;
                testThread.Abort();
                tcpClient.Disconnect();
                this.Invoke(new Action(() => { timerTest.Stop(); }));
                timer = 0;
                AddColorInfo("测试已主动结束。\r\n", Color.Red);
            }
            catch (Exception ex)
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
                testModels[TestModel.testi].memadd = Convert.ToInt32(dataGridtest.Rows[i].Cells[3].Value);
                testModels[TestModel.testi].memtype = Convert.ToString(dataGridtest.Rows[i].Cells[4].Value);
                testModels[TestModel.testi].valuetype = Convert.ToString(dataGridtest.Rows[i].Cells[5].Value);
                if (testModels[TestModel.testi].memtype == "寄存器")
                {
                    if (testModels[TestModel.testi].valuetype == "整数")
                    {
                        testModels[TestModel.testi].value = BitConverter.GetBytes(Convert.ToInt32(dataGridtest.Rows[i].Cells[6].Value));
                    }
                    else if (testModels[TestModel.testi].valuetype == "浮点数")
                    {
                        testModels[TestModel.testi].value = BitConverter.GetBytes(Convert.ToSingle(dataGridtest.Rows[i].Cells[6].Value));
                    }
                    else if (testModels[TestModel.testi].valuetype == "1位定点小数")
                    {
                        testModels[TestModel.testi].value = BitConverter.GetBytes(Convert.ToInt32(Convert.ToSingle(dataGridtest.Rows[i].Cells[6].Value)*10));
                    }
                    else if (testModels[TestModel.testi].valuetype == "2位定点小数")
                    {
                        testModels[TestModel.testi].value = BitConverter.GetBytes(Convert.ToInt32(Convert.ToSingle(dataGridtest.Rows[i].Cells[6].Value)*100));
                    }
                }
                else if (testModels[TestModel.testi].memtype == "线圈")
                {
                    testModels[TestModel.testi].value = BitConverter.GetBytes(Convert.ToInt32(dataGridtest.Rows[i].Cells[6].Value));
                }
    
                testModels[TestModel.testi].testtype = Convert.ToString(dataGridtest.Rows[i].Cells[7].Value);
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

        public ObjectModel[] ReadObject()
        {
            //把objectdatagridview里的数据读到objectmodel类的列表里
            ObjectModel[] objectModels = new ObjectModel[dataGridObject.Rows.Count - 1];
            ObjectModel.obji = 0;
            for (int i = 0; i < dataGridObject.Rows.Count - 1; i++)
            {
                objectModels[ObjectModel.obji] = new ObjectModel();
                objectModels[ObjectModel.obji].objectid = Convert.ToInt32(dataGridObject.Rows[i].Cells[0].Value);
                objectModels[ObjectModel.obji].objectip = Convert.ToString(dataGridObject.Rows[i].Cells[1].Value);
                objectModels[ObjectModel.obji].objectport = Convert.ToString(dataGridObject.Rows[i].Cells[2].Value);
                objectModels[ObjectModel.obji].objecttype = Convert.ToString(dataGridObject.Rows[i].Cells[3].Value);
                ObjectModel.obji++;
            }
            return objectModels;
        }

        public void ConnectTCP(ModbusTCPClient tcpclient, string sip, string sport)
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
                    tcpclient.Connect(ie);
                    isConnectTCP = true;
                }
                catch (SocketException e)
                {
                    AddInfo("未能连接到目标。" + e.Message, 2);
                    return;
                }
            }
        }

        public int ReciMsg(ModbusTCPClient client, int num)
        {
            byte[] data = new byte[1024];//定义数据接收数组
            try
            {
                data = client.ReceiveMessage();//接收数据到data数组

                int length = data[5];//读取数据长度
                Byte[] datashow = new byte[length + 6];//定义所要显示的接收的数据的长度
                for (int i = 0; i <= length + 5; i++)//将要显示的数据存放到数组datashow中
                {
                    datashow[i] = data[i];
                }
                if (datashow.Length <= 10)
                {
                    int value = datashow[datashow.Length - 1];
                    return value;
                }
                else
                {
                    int value = datashow[datashow.Length - 2] | datashow[datashow.Length - 1];
                    return value;
                }//把数组转换成16进制字符串
            }
            catch (Exception e)
            {
                AddInfo("连接出现了错误。" + e.Message, 2);
            }
            return -1;
        }

        public bool ReciMsg(ModbusTCPClient client, bool i)
        {
            byte[] data = new byte[1024];//定义数据接收数组
            try
            {
                data = client.ReceiveMessage();//接收数据到data数组

                int error = data[7];//定义所要显示的接收的数据的长度
                if (error <= 128)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                AddInfo("连接出现了错误。" + e.Message, 2);
            }
            return false;
        }

        public float ReciMsg(ModbusTCPClient client)
        {
            byte[] data = new byte[1024];//定义数据接收数组
            try
            {
                data = client.ReceiveMessage();//接收数据到data数组

                int length = data[5];//读取数据长度
                Byte[] datashow = new byte[4];//定义所要显示的接收的数据的长度
                for (int i = 0; i < 4; i++)//将要显示的数据存放到数组datashow中
                {
                    datashow[i] = data[i + 2 + length];
                }
                float value = BitConverter.ToSingle(datashow, 0);//把数组转换成16进制字符串
                return value;
            }
            catch (Exception e)
            {
                AddInfo("连接出现了错误。"  + e.Message, 2);
            }
            return -1;
        }

        public void SingleTest(object tc)
        {
            Thread.Sleep(500);
            AddInfo("测试开始！", 1);
            this.Invoke(new Action(() => { timerTest.Start(); }));
            int num = 0;
            pass = 0;
            nopass = 0;
            foreach (TestModel tm in (tc as ThreadClass).tms)
            { 

                //进行测试
                try
                {
                    num++;
                    Thread.Sleep((tm.settime - timer) * 1000);
                    AddInfo("第" + timer + "秒，开始第" + num.ToString() + "项" + tm.testtype + "测试：", 1);
                    for (int i = 0; i < (tc as ThreadClass).epoch; i++)
                    {
                        ObjectModel obj = Function.GetObjectModel((tc as ThreadClass).oms, tm);
                        PLCModel plc = Function.GetPLCModel((tc as ThreadClass).pms, tm);
                        ConnectTCP(tcpClient, plc.PLCip, plc.PLCport);
                        Test_Single(plc, obj, tm, i, num);
                    }
                }
                catch (Exception ex)
                {
                    AddInfo(ex.Message, 2);
                }
            }
            AddInfo("共进行" + num.ToString() + "项测试，每项测试" + textBoxepoch.Text + "次，共测试" +
                (num * Convert.ToInt32(textBoxepoch.Text)).ToString() + "次。\r\n其中有" + pass.ToString() + "次测试通过，有" +
                nopass.ToString() + "次测试未能通过。", 1);
        }
        public void CircleTest(object tc)
        {
            Thread.Sleep(500);
            AddInfo("测试开始！", 1);
            this.Invoke(new Action(() => { timerTest.Start(); }));
            int num = 0;
            pass = 0;
            nopass = 0;
            foreach (TestModel tm in (tc as ThreadClass).tms)
            {
                //读取每一个测试的数据
                int time = tm.settime;
                int PLCid = tm.PLCindex;
                int objectid = tm.objectindex;
                string method = tm.testtype;
                short add = Convert.ToInt16(tm.memadd.ToString(), 16);
                short value = Convert.ToInt16(tm.value[1]|tm.value[0]);
                
                //进行测试
                try
                {
                    num++;
                    Thread.Sleep((tm.settime - timer) * 1000);
                    AddInfo("第" + timer + "秒，开始第" + num.ToString() + "项" + tm.testtype + "测试：", 1);
                    for (int i = 0; i < (tc as ThreadClass).epoch; i++)
                    {
                        ObjectModel obj = Function.GetObjectModel((tc as ThreadClass).oms, tm);
                        PLCModel plc = Function.GetPLCModel((tc as ThreadClass).pms, tm);
                        if (tm.testtype == "正循环")
                        {
                            Test_Clockwise(plc, obj, tm, i, num);
                        }
                        else if (tm.testtype == "负循环")
                        {
                            Test_AntiClockwise(plc, obj, tm, i, num);
                        }
                    }
                }
                catch (Exception ex)
                {
                    AddInfo(ex.Message, 2);
                } 
            }
            AddInfo("共进行" + num.ToString() + "项测试，每项测试" + textBoxepoch.Text + "次，共测试" + 
                (num * Convert.ToInt32(textBoxepoch.Text)).ToString() + "次。\r\n其中有" + pass.ToString() + "次测试通过，有" +
                nopass.ToString() + "次测试未能通过。", 1);
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            //记录测试时间
            timerTest.Interval = 1000;
            timer++;
        }

        private void buttonconn_Click(object sender, EventArgs e)
        {
            //手动连接PLC测试
            if (!Function.IPCheck(textBoxPLCip.Text))
            {
                MessageBox.Show("请输入正确的IP地址！");
                return;
            }
            if (!Function.PortCheck(textBoxtestport.Text))
            {
                MessageBox.Show("请输入正确的端口！");
                return;
            }
            ConnectTCP(tcpClient, textBoxPLCip.Text, textBoxtestport.Text);
            if (isConnectTCP)
            {
                AddInfo("已连接到PLC：" + textBoxPLCip.Text + "/" + textBoxtestport.Text, 1);
                textBoxconn.Text = "已连接";
                textBoxconn.ForeColor = Color.Green;
            }
            else
            {
                textBoxconn.Text = "连接失败";
                textBoxconn.ForeColor = Color.Red;
            }
        }

        private void buttondisconn_Click(object sender, EventArgs e)
        {
            //关闭手动连接
            try
            {
                tcpClient.Disconnect();
                isConnectTCP = false;
                textBoxconn.Text = "未连接";
                textBoxconn.ForeColor = Color.Black;
                AddInfo("已停止到PLC：" + textBoxPLCip.Text + "/" + textBoxtestport.Text + "的连接。", 1);
            }
            catch (Exception ex)
            {
                AddInfo(ex.Message, 2);
                textBoxconn.Text = "未连接";
                textBoxconn.ForeColor = Color.Black;
            }
        }

        public void Test_Single(PLCModel plc, ObjectModel obj, TestModel tm, int i, int num)
        {
            //单向连接：
            isPassTest = false;
            string memtype = tm.memtype;
            string valuetype = tm.valuetype;
            string testtype = tm.testtype;
            short add = Convert.ToInt16(tm.memadd.ToString(), 16);
            if (testtype == "写")
            {
                //发送写的功能码
                if (tm.memtype == "线圈")
                {
                    short value = Convert.ToInt16(tm.value[1] | tm.value[0]);
                    //发送写的功能码
                    ushort valueon = 65280;
                    short valueoff = 0;
                    if (value == 1)
                    {
                        tcpClient.Send(0x05, add, valueon);
                    }
                    else if (value == 0)
                    {
                        tcpClient.Send(0x05, add, valueoff);
                    }
                    ConnectTCP(objClient, obj.objectip, obj.objectport);
                    AddInfo("第" + (i + 1).ToString() + "轮测试：将地址 " + add.ToString() + " 的寄存器写为" + value.ToString() +
                        "。\r\n", 3);
                }
                else if (tm.valuetype != "浮点数")
                {
                    short value = Convert.ToInt16(tm.value[1] | tm.value[0]);
                    //发送写的功能码
                    tcpClient.Send(0x06, add, value);
                    if (tm.valuetype == "整数")
                    {
                        AddInfo("第" + (i + 1).ToString() + "轮测试：将地址 " + add.ToString() + " 的寄存器写为" + value.ToString() +
                            "。\r\n", 3);
                    }
                    else if (tm.valuetype == "1位定点小数")
                    {
                        float value2 = (float)value / 10;
                        AddInfo("第" + (i + 1).ToString() + "轮测试：将地址 " + add.ToString() + " 的寄存器写为" + value2.ToString() +
                            "。\r\n", 3);
                    }
                    else if (tm.valuetype == "2位定点小数")
                    {
                        float value2 = (float)value / 100;
                        AddInfo("第" + (i + 1).ToString() + "轮测试：将地址 " + add.ToString() + " 的寄存器写为" + value2.ToString() +
                            "。\r\n", 3);
                    }
                }
                else if (tm.valuetype == "浮点数")
                {
                    float value = BitConverter.ToSingle(tm.value, 0);
                    //发送写的功能码
                    tcpClient.Send(0x10, add, value);
                    AddInfo("第" + (i + 1).ToString() + "轮测试：将地址 " + add.ToString() + " 的寄存器写为" + value.ToString() +
                        "。\r\n", 3);
                }
                isPassTest = ReciMsg(tcpClient, true);
            }
            else if (testtype == "读")
            {
                if (tm.memtype == "线圈")
                {
                    short value = Convert.ToInt16(tm.value[1] | tm.value[0]);
                    tcpClient.Send(0x01, add, Convert.ToInt16(1));
                    Thread.Sleep(1);
                    int returnvalue = ReciMsg(tcpClient, 1);
                    if (returnvalue == -1)
                    {
                        AddInfo("接受数据失败。", 2);
                    }

                    AddInfo("第" + (i + 1).ToString() + "轮测试：期望读取的数据为 " + value.ToString() + 
                        " 。读取到的数据为" + returnvalue.ToString() + "。\r\n", 3);
                    if (value == returnvalue)
                    {
                        isPassTest = true;
                    }
                }
                else if (tm.valuetype != "浮点数")
                {
                    short value = Convert.ToInt16(tm.value[1] | tm.value[0]);
                    //发送读的功能码
                    tcpClient.Send(0x03, add, Convert.ToInt16(1));
                    Thread.Sleep(1);
                    int returnvalue = ReciMsg(tcpClient, 1);
                    if (returnvalue == -1)
                    {
                        AddInfo("接受数据失败。", 2);
                    }
                    if (tm.valuetype == "整数")
                    {

                        AddInfo("第" + (i + 1).ToString() + "轮测试：期望读取的数据为 " + value.ToString() +
                            " 。读取到的数据为" + returnvalue.ToString() + "。\r\n", 3);
                    }
                    else if (tm.valuetype == "1位定点小数")
                    {
                        float returnvalue2 = (float)returnvalue / 10;
                        float value2 = (float)value / 10;
                        AddInfo("第" + (i + 1).ToString() + "轮测试：期望读取的数据为 " + value2.ToString() +
                            " 。读取到的数据为" + returnvalue2.ToString() + "。\r\n", 3);
                    }
                    else if (tm.valuetype == "2位定点小数")
                    {
                        float returnvalue2 = (float)returnvalue / 100;
                        float value2 = (float)value / 100;
                        AddInfo("第" + (i + 1).ToString() + "轮测试：期望读取的数据为 " + value2.ToString() +
                            " 。读取到的数据为" + returnvalue2.ToString() + "。\r\n", 3);
                    }
                    if (value == returnvalue)
                    {
                        isPassTest = true;
                    }
                }
                else if (tm.valuetype == "浮点数")
                {
                    float value = BitConverter.ToSingle(tm.value, 0);
                    //发送读的功能码
                    tcpClient.Send(0x03, add, Convert.ToInt16(2));
                    Thread.Sleep(1);
                    float returnvalue = ReciMsg(tcpClient);
                    if (returnvalue == -1)
                    {
                        AddInfo("接受数据失败。", 2);
                    }
                    AddInfo("第" + (i + 1).ToString() + "轮测试：期望读取的数据为 " + value.ToString() +
                           " 。读取到的数据为" + returnvalue.ToString() + "。\r\n", 3);
                    if (value == returnvalue)
                    {
                        isPassTest = true;
                    }
                }
            }
            if (isPassTest)
            {
                AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试通过。\r\n", Color.Green);
                pass++;
            }
            else
            {
                AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试未能通过。\r\n", Color.Red);
                nopass++;
            }
            try
            {
                objClient.Disconnect();
                tcpClient.Disconnect();
            }
            catch { }
            Thread.Sleep(1);
        }

        public void Test_Clockwise(PLCModel plc, ObjectModel obj, TestModel tm, int i, int num)
        {
            //顺时针正循环：
            //先向对象发信息，修改数据；
            //再给PLC发信息，读取对象数据，两相比较。
            short add = Convert.ToInt16(tm.memadd.ToString(), 16);
            if (tm.memtype == "线圈")
            {
                short value = Convert.ToInt16(tm.value[1] | tm.value[0]);
                ConnectTCP(objClient, obj.objectip, obj.objectport);
                ushort valueon = 65280;
                short valueoff = 0;
                if (value == 1)
                {
                    objClient.Send(0x05, add, valueon);
                }
                else if (value == 0)
                {
                    objClient.Send(0x05, add, valueoff);
                }
                
                //发送读的功能码
                ConnectTCP(tcpClient, plc.PLCip, plc.PLCport);
                tcpClient.Send(0x01, add, Convert.ToInt16(1));
                Thread.Sleep(1);
                int returnvalue = ReciMsg(tcpClient, 1);
                if (returnvalue == -1)
                {
                    AddInfo("接受数据失败。", 2);
                }

                AddInfo("第" + (i + 1).ToString() + "轮测试：将 " + obj.objecttype + " 对象的数据写为" + value.ToString() +
                "。从 " + plc.PLCname + " PLC读取到的数据为" + returnvalue.ToString() + "。\r\n", 3);

                if (value == returnvalue)
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试通过。\r\n", Color.Green);
                    pass++;
                }
                else
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试未能通过。\r\n", Color.Red);
                    nopass++;
                }
            }
            else if (tm.valuetype != "浮点数")
            {
                short value = Convert.ToInt16(tm.value[1] | tm.value[0]);
                ConnectTCP(objClient, obj.objectip, obj.objectport);
                //发送写的功能码
                objClient.Send(0x06, add, value);
                ConnectTCP(tcpClient, plc.PLCip, plc.PLCport);
                //发送读的功能码
                tcpClient.Send(0x03, add, Convert.ToInt16(1));
                Thread.Sleep(1);
                int returnvalue = ReciMsg(tcpClient, 1);
                if (returnvalue == -1)
                {
                    AddInfo("接受数据失败。", 2);
                }
                if (tm.valuetype == "整数")
                {
                    AddInfo("第" + (i + 1).ToString() + "轮测试：将 " + obj.objecttype + " 对象的数据写为" + value.ToString() +
                    "。从 " + plc.PLCname + " PLC读取到的数据为" + returnvalue.ToString() + "。\r\n", 3);
                }          
                else if (tm.valuetype == "1位定点小数")
                {
                    float value2 = (float)value / 10;
                    float returnvalue2 = (float)returnvalue / 10;
                    AddInfo("第" + (i + 1).ToString() + "轮测试：将 " + obj.objecttype + " 对象的数据写为" + value2.ToString() +
                    "。从 " + plc.PLCname + " PLC读取到的数据为" + returnvalue2.ToString() + "。\r\n", 3);
                }
                else if (tm.valuetype == "2位定点小数")
                {
                    float value2 = (float)value / 100;
                    float returnvalue2 = (float)returnvalue / 100;
                    AddInfo("第" + (i + 1).ToString() + "轮测试：将 " + obj.objecttype + " 对象的数据写为" + value2.ToString() +
                    "。从 " + plc.PLCname + " PLC读取到的数据为" + returnvalue2.ToString() + "。\r\n", 3);
                }
                
                if (value == returnvalue)
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试通过。\r\n", Color.Green);
                    pass++;
                }
                else
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试未能通过。\r\n", Color.Red);
                    nopass++;
                }
            }
            else if (tm.valuetype == "浮点数")
            {
                float value = BitConverter.ToSingle(tm.value, 0);
                ConnectTCP(objClient, obj.objectip, obj.objectport);
                //发送写的功能码
                objClient.Send(0x10, add, value);
                ConnectTCP(tcpClient, plc.PLCip, plc.PLCport);
                //发送读的功能码
                tcpClient.Send(0x03, add, Convert.ToInt16(2));
                Thread.Sleep(1);
                float returnvalue = ReciMsg(tcpClient);
                if (returnvalue == -1)
                {
                    AddInfo("接受数据失败。", 2);
                }
                AddInfo("第" + (i + 1).ToString() + "轮测试：将 " + obj.objecttype + " 对象的数据写为" + value.ToString() +
                    "。从 " + plc.PLCname + " PLC读取到的数据为" + returnvalue.ToString() + "。\r\n", 3);
                if (value == returnvalue)
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试通过。\r\n", Color.Green);
                    pass++;
                }
                else
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试未能通过。\r\n", Color.Red);
                    nopass++;
                }
            }
            try
            {
                objClient.Disconnect();
                tcpClient.Disconnect();
            }
            catch { }
            Thread.Sleep(1);
        }

        public void Test_AntiClockwise(PLCModel plc, ObjectModel obj, TestModel tm, int i, int num)
        {
            //逆时针循环：
            //先向PLC发信息，修改数据；
            //再给对象发信息，读取对象数据，两相比较。
            short add = Convert.ToInt16(tm.memadd.ToString(), 16);
            if (tm.memtype == "线圈")
            {
                short value = Convert.ToInt16(tm.value[1] | tm.value[0]);
                ConnectTCP(tcpClient, plc.PLCip, plc.PLCport);
                //发送写的功能码
                ushort valueon = 65280;
                short valueoff = 0;
                if (value == 1)
                {
                    tcpClient.Send(0x05, add, valueon);
                    AddInfo(BitConverter.ToString(tcpClient.GetTCPFrame(0x05, add, valueon)), 1);
                }
                else if (value == 0)
                {
                    tcpClient.Send(0x05, add, valueoff);
                    AddInfo(BitConverter.ToString(tcpClient.GetTCPFrame(0x05, add, valueoff)), 1);
                }
                ConnectTCP(objClient, obj.objectip, obj.objectport);
                //发送读的功能码
                objClient.Send(0x01, add, Convert.ToInt16(1));
                Thread.Sleep(1);
                int returnvalue = ReciMsg(objClient, 1);
                if (returnvalue == -1)
                {
                    AddInfo("接受数据失败。", 2);
                }

                AddInfo("第" + (i + 1).ToString() + "轮测试：将 " + plc.PLCname + " PLC的数据写为" + value.ToString() +
                    "。从对象 " + obj.objecttype + " 读取到的数据为" + returnvalue.ToString() + "。\r\n", 3);

                if (value == returnvalue)
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试通过。\r\n", Color.Green);
                    pass++;
                }
                else
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试未能通过。\r\n", Color.Red);
                    nopass++;
                }
            }
            else if (tm.valuetype != "浮点数")
            {
                short value = Convert.ToInt16(tm.value[1] | tm.value[0]);
                ConnectTCP(tcpClient, plc.PLCip, plc.PLCport);
                //发送写的功能码
                tcpClient.Send(0x06, add, value);
                ConnectTCP(objClient, obj.objectip, obj.objectport);
                //发送读的功能码
                objClient.Send(0x03, add, Convert.ToInt16(1));
                Thread.Sleep(1);
                int returnvalue = ReciMsg(objClient, 1);
                if (returnvalue == -1)
                {
                    AddInfo("接受数据失败。", 2);
                }
                if (tm.valuetype == "整数")
                {
                    AddInfo("第" + (i + 1).ToString() + "轮测试：将 " + plc.PLCname + " PLC的数据写为" + value.ToString() +
                    "。从对象 " + obj.objecttype + " 读取到的数据为" + returnvalue.ToString() + "。\r\n", 3);
                }
                else if (tm.valuetype == "1位定点小数")
                {
                    float value2 = (float)value / 10;
                    float returnvalue2 = (float)returnvalue / 10;
                    AddInfo("第" + (i + 1).ToString() + "轮测试：将 " + plc.PLCname + " PLC的数据写为" + value2.ToString() +
                    "。从对象 " + obj.objecttype + " 读取到的数据为" + returnvalue2.ToString() + "。\r\n", 3);
                }
                else if (tm.valuetype == "2位定点小数")
                {
                    float value2 = (float)value / 100;
                    float returnvalue2 = (float)returnvalue / 100;
                    AddInfo("第" + (i + 1).ToString() + "轮测试：将 " + plc.PLCname + " PLC的数据写为" + value2.ToString() +
                    "。从对象 " + obj.objecttype + " 读取到的数据为" + returnvalue2.ToString() + "。\r\n", 3);
                }
                if (value == returnvalue)
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试通过。\r\n", Color.Green);
                    pass++;
                }
                else
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试未能通过。\r\n", Color.Red);
                    nopass++;
                }
            }
            else if (tm.valuetype == "浮点数")
            {
                float value = BitConverter.ToSingle(tm.value, 0);
                ConnectTCP(tcpClient, plc.PLCip, plc.PLCport);
                //发送写的功能码
                tcpClient.Send(0x10, add, value);
                ConnectTCP(objClient, obj.objectip, obj.objectport);
                //发送读的功能码
                objClient.Send(0x03, add, Convert.ToInt16(2));
                Thread.Sleep(1);
                float returnvalue = ReciMsg(objClient);
                if (returnvalue == -1)
                {
                    AddInfo("接受数据失败。", 2);
                }
                AddInfo("第" + (i + 1).ToString() + "轮测试：将 " + plc.PLCname + " PLC的数据写为" + value.ToString() +
                    "。从对象 " + obj.objecttype + " 读取到的数据为" + returnvalue.ToString() + "。\r\n", 3);
                if (value == returnvalue)
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试通过。\r\n", Color.Green);
                    pass++;
                }
                else
                {
                    AddColorInfo("第" + num.ToString() + "项测试第" + (i + 1).ToString() + "轮测试未能通过。\r\n", Color.Red);
                    nopass++;
                }
            }
            try
            {
                objClient.Disconnect();
                tcpClient.Disconnect();
            }
            catch { }
            Thread.Sleep(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗口载入后载入默认配置
            LoadDefualtConfig(defualtTest, defualtPLC, defualtObject);
        }

        private void rBsingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rBsingle.Checked)
            {
                isSingleTest = true;
                dataGridtest.Columns[7].HeaderText = "读写类型";
                dataGridtest.Columns[7].DataPropertyName = "读写类型";
            }
        }

        private void rBcircle_CheckedChanged(object sender, EventArgs e)
        {
            if (rBcircle.Checked)
            {
                isSingleTest = false;
                dataGridtest.Columns[7].HeaderText = "测试类型";
                dataGridtest.Columns[7].DataPropertyName = "测试类型";
            }
        }
    }
}
