
namespace PLC_Test
{
    partial class Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.dataGridPLC = new System.Windows.Forms.DataGridView();
            this.PLCid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLCname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLCip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLCport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridObject = new System.Windows.Forms.DataGridView();
            this.objectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objecttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonopenconfig = new System.Windows.Forms.Button();
            this.textBoxreceivebytes = new System.Windows.Forms.TextBox();
            this.textBoxsendbytes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttondisconn = new System.Windows.Forms.Button();
            this.textBoxconn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonconn = new System.Windows.Forms.Button();
            this.textBoxtestport = new System.Windows.Forms.TextBox();
            this.comboBoxlocalIP = new System.Windows.Forms.ComboBox();
            this.textBoxPLCip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bloadconfigo = new System.Windows.Forms.Button();
            this.bsaveconfigo = new System.Windows.Forms.Button();
            this.bsaveconfig = new System.Windows.Forms.Button();
            this.bloadconfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxsingleconn = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxresult = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonrestart = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.rBcircle = new System.Windows.Forms.RadioButton();
            this.rBsingle = new System.Windows.Forms.RadioButton();
            this.buttonendtest = new System.Windows.Forms.Button();
            this.buttonstarttest = new System.Windows.Forms.Button();
            this.textBoxepoch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonloadtest = new System.Windows.Forms.Button();
            this.dataGridtest = new System.Windows.Forms.DataGridView();
            this.settime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLCindex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectindex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxinfo = new System.Windows.Forms.RichTextBox();
            this.checkBoxsavelog = new System.Windows.Forms.CheckBox();
            this.timersavelog = new System.Windows.Forms.Timer(this.components);
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.timerBytes = new System.Windows.Forms.Timer(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPageexcel = new System.Windows.Forms.TabPage();
            this.buttonopenExcelF = new System.Windows.Forms.Button();
            this.tabPagedatabase = new System.Windows.Forms.TabPage();
            this.buttondeleteDB = new System.Windows.Forms.Button();
            this.buttonopenDB = new System.Windows.Forms.Button();
            this.textBoxDBstatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rBUDPFSU = new System.Windows.Forms.RadioButton();
            this.rBTCPPLC = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtest)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPageexcel.SuspendLayout();
            this.tabPagedatabase.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPLC
            // 
            this.dataGridPLC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPLC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PLCid,
            this.PLCname,
            this.PLCip,
            this.PLCport});
            this.dataGridPLC.Location = new System.Drawing.Point(19, 527);
            this.dataGridPLC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridPLC.Name = "dataGridPLC";
            this.dataGridPLC.RowHeadersVisible = false;
            this.dataGridPLC.RowHeadersWidth = 51;
            this.dataGridPLC.RowTemplate.Height = 27;
            this.dataGridPLC.Size = new System.Drawing.Size(648, 100);
            this.dataGridPLC.TabIndex = 0;
            this.dataGridPLC.TabStop = false;
            // 
            // PLCid
            // 
            this.PLCid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PLCid.DataPropertyName = "PLCid";
            this.PLCid.HeaderText = "PLC序号";
            this.PLCid.MinimumWidth = 6;
            this.PLCid.Name = "PLCid";
            // 
            // PLCname
            // 
            this.PLCname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PLCname.DataPropertyName = "PLCname";
            this.PLCname.HeaderText = "PLC名称";
            this.PLCname.MinimumWidth = 6;
            this.PLCname.Name = "PLCname";
            // 
            // PLCip
            // 
            this.PLCip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PLCip.DataPropertyName = "PLCip";
            this.PLCip.HeaderText = "PLC IP";
            this.PLCip.MinimumWidth = 6;
            this.PLCip.Name = "PLCip";
            // 
            // PLCport
            // 
            this.PLCport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PLCport.DataPropertyName = "PLCport";
            this.PLCport.HeaderText = "PLC端口";
            this.PLCport.MinimumWidth = 6;
            this.PLCport.Name = "PLCport";
            // 
            // dataGridObject
            // 
            this.dataGridObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridObject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectid,
            this.objectip,
            this.objectport,
            this.objecttype});
            this.dataGridObject.Location = new System.Drawing.Point(19, 668);
            this.dataGridObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridObject.Name = "dataGridObject";
            this.dataGridObject.RowHeadersVisible = false;
            this.dataGridObject.RowHeadersWidth = 51;
            this.dataGridObject.RowTemplate.Height = 27;
            this.dataGridObject.Size = new System.Drawing.Size(648, 100);
            this.dataGridObject.TabIndex = 1;
            this.dataGridObject.TabStop = false;
            // 
            // objectid
            // 
            this.objectid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objectid.DataPropertyName = "objectid";
            this.objectid.HeaderText = "对象序号";
            this.objectid.MinimumWidth = 6;
            this.objectid.Name = "objectid";
            // 
            // objectip
            // 
            this.objectip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objectip.DataPropertyName = "objectip";
            this.objectip.HeaderText = "对象ip";
            this.objectip.MinimumWidth = 6;
            this.objectip.Name = "objectip";
            this.objectip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.objectip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // objectport
            // 
            this.objectport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objectport.DataPropertyName = "objectport";
            this.objectport.HeaderText = "端口号";
            this.objectport.MinimumWidth = 6;
            this.objectport.Name = "objectport";
            this.objectport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.objectport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // objecttype
            // 
            this.objecttype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objecttype.DataPropertyName = "objecttype";
            this.objecttype.HeaderText = "设备类型";
            this.objecttype.MinimumWidth = 6;
            this.objecttype.Name = "objecttype";
            this.objecttype.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.objecttype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonopenconfig
            // 
            this.buttonopenconfig.Location = new System.Drawing.Point(25, 43);
            this.buttonopenconfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonopenconfig.Name = "buttonopenconfig";
            this.buttonopenconfig.Size = new System.Drawing.Size(125, 33);
            this.buttonopenconfig.TabIndex = 18;
            this.buttonopenconfig.Text = "编辑默认配置";
            this.buttonopenconfig.UseVisualStyleBackColor = true;
            this.buttonopenconfig.Click += new System.EventHandler(this.buttonopenconfig_Click);
            // 
            // textBoxreceivebytes
            // 
            this.textBoxreceivebytes.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxreceivebytes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxreceivebytes.Location = new System.Drawing.Point(71, 149);
            this.textBoxreceivebytes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxreceivebytes.Name = "textBoxreceivebytes";
            this.textBoxreceivebytes.ReadOnly = true;
            this.textBoxreceivebytes.Size = new System.Drawing.Size(51, 18);
            this.textBoxreceivebytes.TabIndex = 17;
            this.textBoxreceivebytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxsendbytes
            // 
            this.textBoxsendbytes.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxsendbytes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxsendbytes.Location = new System.Drawing.Point(71, 114);
            this.textBoxsendbytes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxsendbytes.Name = "textBoxsendbytes";
            this.textBoxsendbytes.ReadOnly = true;
            this.textBoxsendbytes.Size = new System.Drawing.Size(51, 18);
            this.textBoxsendbytes.TabIndex = 17;
            this.textBoxsendbytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(120, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "字节";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(120, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 16;
            this.label15.Text = "字节";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "已接收";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "已发送";
            // 
            // buttondisconn
            // 
            this.buttondisconn.Location = new System.Drawing.Point(35, 97);
            this.buttondisconn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttondisconn.Name = "buttondisconn";
            this.buttondisconn.Size = new System.Drawing.Size(104, 25);
            this.buttondisconn.TabIndex = 13;
            this.buttondisconn.Text = "停止连接";
            this.buttondisconn.UseVisualStyleBackColor = true;
            this.buttondisconn.Click += new System.EventHandler(this.buttondisconn_Click);
            // 
            // textBoxconn
            // 
            this.textBoxconn.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxconn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxconn.Location = new System.Drawing.Point(291, 100);
            this.textBoxconn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxconn.Name = "textBoxconn";
            this.textBoxconn.ReadOnly = true;
            this.textBoxconn.Size = new System.Drawing.Size(85, 18);
            this.textBoxconn.TabIndex = 12;
            this.textBoxconn.Text = "未连接";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "手动连接状态：";
            // 
            // buttonconn
            // 
            this.buttonconn.Location = new System.Drawing.Point(35, 60);
            this.buttonconn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonconn.Name = "buttonconn";
            this.buttonconn.Size = new System.Drawing.Size(104, 25);
            this.buttonconn.TabIndex = 10;
            this.buttonconn.Text = "手动连接";
            this.buttonconn.UseVisualStyleBackColor = true;
            this.buttonconn.Click += new System.EventHandler(this.buttonconn_Click);
            // 
            // textBoxtestport
            // 
            this.textBoxtestport.Location = new System.Drawing.Point(383, 22);
            this.textBoxtestport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxtestport.Name = "textBoxtestport";
            this.textBoxtestport.Size = new System.Drawing.Size(67, 25);
            this.textBoxtestport.TabIndex = 9;
            // 
            // comboBoxlocalIP
            // 
            this.comboBoxlocalIP.Font = new System.Drawing.Font("宋体", 9F);
            this.comboBoxlocalIP.FormattingEnabled = true;
            this.comboBoxlocalIP.Location = new System.Drawing.Point(247, 61);
            this.comboBoxlocalIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxlocalIP.Name = "comboBoxlocalIP";
            this.comboBoxlocalIP.Size = new System.Drawing.Size(159, 23);
            this.comboBoxlocalIP.TabIndex = 8;
            // 
            // textBoxPLCip
            // 
            this.textBoxPLCip.Font = new System.Drawing.Font("宋体", 9F);
            this.textBoxPLCip.Location = new System.Drawing.Point(120, 23);
            this.textBoxPLCip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPLCip.Name = "textBoxPLCip";
            this.textBoxPLCip.Size = new System.Drawing.Size(159, 25);
            this.textBoxPLCip.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "检测端口：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "本机IP：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "测试PLC IP：";
            // 
            // bloadconfigo
            // 
            this.bloadconfigo.Location = new System.Drawing.Point(409, 635);
            this.bloadconfigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bloadconfigo.Name = "bloadconfigo";
            this.bloadconfigo.Size = new System.Drawing.Size(124, 25);
            this.bloadconfigo.TabIndex = 15;
            this.bloadconfigo.Text = "加载对象配置";
            this.bloadconfigo.UseVisualStyleBackColor = true;
            this.bloadconfigo.Click += new System.EventHandler(this.bloadconfigo_Click);
            // 
            // bsaveconfigo
            // 
            this.bsaveconfigo.Location = new System.Drawing.Point(543, 635);
            this.bsaveconfigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bsaveconfigo.Name = "bsaveconfigo";
            this.bsaveconfigo.Size = new System.Drawing.Size(124, 25);
            this.bsaveconfigo.TabIndex = 14;
            this.bsaveconfigo.Text = "保存对象配置";
            this.bsaveconfigo.UseVisualStyleBackColor = true;
            this.bsaveconfigo.Click += new System.EventHandler(this.bsaveconfigo_Click);
            // 
            // bsaveconfig
            // 
            this.bsaveconfig.Location = new System.Drawing.Point(543, 497);
            this.bsaveconfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bsaveconfig.Name = "bsaveconfig";
            this.bsaveconfig.Size = new System.Drawing.Size(124, 25);
            this.bsaveconfig.TabIndex = 1;
            this.bsaveconfig.Text = "保存PLC配置";
            this.bsaveconfig.UseVisualStyleBackColor = true;
            this.bsaveconfig.Click += new System.EventHandler(this.bsaveconfig_Click);
            // 
            // bloadconfig
            // 
            this.bloadconfig.Location = new System.Drawing.Point(409, 497);
            this.bloadconfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bloadconfig.Name = "bloadconfig";
            this.bloadconfig.Size = new System.Drawing.Size(124, 25);
            this.bloadconfig.TabIndex = 0;
            this.bloadconfig.Text = "加载PLC配置";
            this.bloadconfig.UseVisualStyleBackColor = true;
            this.bloadconfig.Click += new System.EventHandler(this.bloadconfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "PLC列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 640);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "对象列表";
            // 
            // checkBoxsingleconn
            // 
            this.checkBoxsingleconn.AutoSize = true;
            this.checkBoxsingleconn.Checked = true;
            this.checkBoxsingleconn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxsingleconn.Location = new System.Drawing.Point(224, 33);
            this.checkBoxsingleconn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxsingleconn.Name = "checkBoxsingleconn";
            this.checkBoxsingleconn.Size = new System.Drawing.Size(89, 19);
            this.checkBoxsingleconn.TabIndex = 20;
            this.checkBoxsingleconn.Text = "单一连接";
            this.checkBoxsingleconn.UseVisualStyleBackColor = true;
            this.checkBoxsingleconn.CheckedChanged += new System.EventHandler(this.checkBoxsingleconn_CheckedChanged);
            this.checkBoxsingleconn.MouseHover += new System.EventHandler(this.checkBoxsingleconn_MouseHover);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = ".xlsx";
            // 
            // textBoxresult
            // 
            this.textBoxresult.Location = new System.Drawing.Point(154, 11);
            this.textBoxresult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxresult.Name = "textBoxresult";
            this.textBoxresult.Size = new System.Drawing.Size(87, 25);
            this.textBoxresult.TabIndex = 18;
            this.textBoxresult.Text = "test";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "测试结果文件名：";
            // 
            // buttonrestart
            // 
            this.buttonrestart.Location = new System.Drawing.Point(355, 73);
            this.buttonrestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonrestart.Name = "buttonrestart";
            this.buttonrestart.Size = new System.Drawing.Size(124, 25);
            this.buttonrestart.TabIndex = 16;
            this.buttonrestart.Text = "重新启动软件";
            this.buttonrestart.UseVisualStyleBackColor = true;
            this.buttonrestart.Click += new System.EventHandler(this.buttonrestart_Click);
            this.buttonrestart.MouseHover += new System.EventHandler(this.buttonrestart_MouseHover);
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(511, 73);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(124, 25);
            this.buttonexit.TabIndex = 16;
            this.buttonexit.Text = "退出软件";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // rBcircle
            // 
            this.rBcircle.AutoSize = true;
            this.rBcircle.Location = new System.Drawing.Point(141, 76);
            this.rBcircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBcircle.Name = "rBcircle";
            this.rBcircle.Size = new System.Drawing.Size(88, 19);
            this.rBcircle.TabIndex = 14;
            this.rBcircle.Text = "循环测试";
            this.rBcircle.UseVisualStyleBackColor = true;
            this.rBcircle.CheckedChanged += new System.EventHandler(this.rBcircle_CheckedChanged);
            // 
            // rBsingle
            // 
            this.rBsingle.AutoSize = true;
            this.rBsingle.Checked = true;
            this.rBsingle.Location = new System.Drawing.Point(21, 76);
            this.rBsingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBsingle.Name = "rBsingle";
            this.rBsingle.Size = new System.Drawing.Size(88, 19);
            this.rBsingle.TabIndex = 14;
            this.rBsingle.TabStop = true;
            this.rBsingle.Text = "单向测试";
            this.rBsingle.UseVisualStyleBackColor = true;
            this.rBsingle.CheckedChanged += new System.EventHandler(this.rBsingle_CheckedChanged);
            // 
            // buttonendtest
            // 
            this.buttonendtest.Location = new System.Drawing.Point(511, 27);
            this.buttonendtest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonendtest.Name = "buttonendtest";
            this.buttonendtest.Size = new System.Drawing.Size(124, 25);
            this.buttonendtest.TabIndex = 12;
            this.buttonendtest.Text = "结束测试";
            this.buttonendtest.UseVisualStyleBackColor = true;
            this.buttonendtest.Click += new System.EventHandler(this.buttonendtest_Click);
            // 
            // buttonstarttest
            // 
            this.buttonstarttest.Location = new System.Drawing.Point(355, 27);
            this.buttonstarttest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonstarttest.Name = "buttonstarttest";
            this.buttonstarttest.Size = new System.Drawing.Size(124, 25);
            this.buttonstarttest.TabIndex = 11;
            this.buttonstarttest.Text = "开始测试";
            this.buttonstarttest.UseVisualStyleBackColor = true;
            this.buttonstarttest.Click += new System.EventHandler(this.buttonstarttest_Click);
            // 
            // textBoxepoch
            // 
            this.textBoxepoch.Location = new System.Drawing.Point(118, 27);
            this.textBoxepoch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxepoch.Name = "textBoxepoch";
            this.textBoxepoch.Size = new System.Drawing.Size(67, 25);
            this.textBoxepoch.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "测试次数：";
            // 
            // buttonloadtest
            // 
            this.buttonloadtest.Location = new System.Drawing.Point(1158, 224);
            this.buttonloadtest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonloadtest.Name = "buttonloadtest";
            this.buttonloadtest.Size = new System.Drawing.Size(171, 25);
            this.buttonloadtest.TabIndex = 0;
            this.buttonloadtest.Text = "加载测试脚本";
            this.buttonloadtest.UseVisualStyleBackColor = true;
            this.buttonloadtest.Click += new System.EventHandler(this.buttonloadtest_Click);
            // 
            // dataGridtest
            // 
            this.dataGridtest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.settime,
            this.PLCindex,
            this.objectindex,
            this.memadd,
            this.memtype,
            this.valuetype,
            this.value,
            this.testtype});
            this.dataGridtest.Location = new System.Drawing.Point(19, 254);
            this.dataGridtest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridtest.Name = "dataGridtest";
            this.dataGridtest.RowHeadersVisible = false;
            this.dataGridtest.RowHeadersWidth = 51;
            this.dataGridtest.RowTemplate.Height = 27;
            this.dataGridtest.Size = new System.Drawing.Size(1310, 238);
            this.dataGridtest.TabIndex = 7;
            this.dataGridtest.TabStop = false;
            // 
            // settime
            // 
            this.settime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.settime.DataPropertyName = "设置时刻";
            this.settime.HeaderText = "设置时刻";
            this.settime.MinimumWidth = 6;
            this.settime.Name = "settime";
            // 
            // PLCindex
            // 
            this.PLCindex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PLCindex.DataPropertyName = "PLC序号";
            this.PLCindex.HeaderText = "PLC序号";
            this.PLCindex.MinimumWidth = 6;
            this.PLCindex.Name = "PLCindex";
            // 
            // objectindex
            // 
            this.objectindex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objectindex.DataPropertyName = "对象编号";
            this.objectindex.HeaderText = "对象编号";
            this.objectindex.MinimumWidth = 6;
            this.objectindex.Name = "objectindex";
            // 
            // memadd
            // 
            this.memadd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memadd.DataPropertyName = "寄存器地址";
            this.memadd.HeaderText = "寄存器地址";
            this.memadd.MinimumWidth = 6;
            this.memadd.Name = "memadd";
            // 
            // memtype
            // 
            this.memtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memtype.DataPropertyName = "寄存器类型";
            this.memtype.HeaderText = "寄存器类型";
            this.memtype.MinimumWidth = 6;
            this.memtype.Name = "memtype";
            // 
            // valuetype
            // 
            this.valuetype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valuetype.DataPropertyName = "值类型";
            this.valuetype.HeaderText = "值类型";
            this.valuetype.MinimumWidth = 6;
            this.valuetype.Name = "valuetype";
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value.DataPropertyName = "值";
            this.value.HeaderText = "值";
            this.value.MinimumWidth = 6;
            this.value.Name = "value";
            // 
            // testtype
            // 
            this.testtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.testtype.DataPropertyName = "读写类型";
            this.testtype.HeaderText = "读写类型";
            this.testtype.MinimumWidth = 6;
            this.testtype.Name = "testtype";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "测试流程";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(681, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "运行日志";
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxinfo.Location = new System.Drawing.Point(681, 527);
            this.textBoxinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.ReadOnly = true;
            this.textBoxinfo.Size = new System.Drawing.Size(648, 242);
            this.textBoxinfo.TabIndex = 10;
            this.textBoxinfo.Text = "";
            // 
            // checkBoxsavelog
            // 
            this.checkBoxsavelog.AutoSize = true;
            this.checkBoxsavelog.Location = new System.Drawing.Point(1210, 501);
            this.checkBoxsavelog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxsavelog.Name = "checkBoxsavelog";
            this.checkBoxsavelog.Size = new System.Drawing.Size(119, 19);
            this.checkBoxsavelog.TabIndex = 11;
            this.checkBoxsavelog.Text = "自动保存日志";
            this.checkBoxsavelog.UseVisualStyleBackColor = true;
            this.checkBoxsavelog.CheckedChanged += new System.EventHandler(this.checkBoxsavelog_CheckedChanged);
            // 
            // timersavelog
            // 
            this.timersavelog.Tick += new System.EventHandler(this.timersavelog_Tick);
            // 
            // timerTest
            // 
            this.timerTest.Interval = 1000;
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // timerBytes
            // 
            this.timerBytes.Tick += new System.EventHandler(this.timerBytes_Tick);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPageexcel);
            this.tabControl2.Controls.Add(this.tabPagedatabase);
            this.tabControl2.Location = new System.Drawing.Point(681, 18);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(648, 73);
            this.tabControl2.TabIndex = 17;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPageexcel
            // 
            this.tabPageexcel.Controls.Add(this.buttonopenExcelF);
            this.tabPageexcel.Controls.Add(this.label12);
            this.tabPageexcel.Controls.Add(this.textBoxresult);
            this.tabPageexcel.Controls.Add(this.label11);
            this.tabPageexcel.Location = new System.Drawing.Point(4, 25);
            this.tabPageexcel.Name = "tabPageexcel";
            this.tabPageexcel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageexcel.Size = new System.Drawing.Size(640, 44);
            this.tabPageexcel.TabIndex = 0;
            this.tabPageexcel.Text = "保存到Excel";
            this.tabPageexcel.UseVisualStyleBackColor = true;
            // 
            // buttonopenExcelF
            // 
            this.buttonopenExcelF.Location = new System.Drawing.Point(402, 9);
            this.buttonopenExcelF.Name = "buttonopenExcelF";
            this.buttonopenExcelF.Size = new System.Drawing.Size(214, 25);
            this.buttonopenExcelF.TabIndex = 20;
            this.buttonopenExcelF.Text = "打开测试结果文件夹";
            this.buttonopenExcelF.UseVisualStyleBackColor = true;
            this.buttonopenExcelF.Click += new System.EventHandler(this.buttonopenExcelF_Click);
            // 
            // tabPagedatabase
            // 
            this.tabPagedatabase.Controls.Add(this.buttondeleteDB);
            this.tabPagedatabase.Controls.Add(this.buttonopenDB);
            this.tabPagedatabase.Controls.Add(this.textBoxDBstatus);
            this.tabPagedatabase.Controls.Add(this.label4);
            this.tabPagedatabase.Location = new System.Drawing.Point(4, 25);
            this.tabPagedatabase.Name = "tabPagedatabase";
            this.tabPagedatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagedatabase.Size = new System.Drawing.Size(640, 44);
            this.tabPagedatabase.TabIndex = 1;
            this.tabPagedatabase.Text = "保存到数据库";
            this.tabPagedatabase.UseVisualStyleBackColor = true;
            // 
            // buttondeleteDB
            // 
            this.buttondeleteDB.Location = new System.Drawing.Point(507, 9);
            this.buttondeleteDB.Name = "buttondeleteDB";
            this.buttondeleteDB.Size = new System.Drawing.Size(124, 25);
            this.buttondeleteDB.TabIndex = 2;
            this.buttondeleteDB.Text = "删除上次结果";
            this.buttondeleteDB.UseVisualStyleBackColor = true;
            this.buttondeleteDB.Click += new System.EventHandler(this.buttondeleteDB_Click);
            // 
            // buttonopenDB
            // 
            this.buttonopenDB.Location = new System.Drawing.Point(351, 9);
            this.buttonopenDB.Name = "buttonopenDB";
            this.buttonopenDB.Size = new System.Drawing.Size(124, 25);
            this.buttonopenDB.TabIndex = 2;
            this.buttonopenDB.Text = "连接数据库";
            this.buttonopenDB.UseVisualStyleBackColor = true;
            this.buttonopenDB.Click += new System.EventHandler(this.buttonopenDB_Click);
            // 
            // textBoxDBstatus
            // 
            this.textBoxDBstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDBstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDBstatus.Location = new System.Drawing.Point(127, 16);
            this.textBoxDBstatus.Name = "textBoxDBstatus";
            this.textBoxDBstatus.ReadOnly = true;
            this.textBoxDBstatus.Size = new System.Drawing.Size(218, 18);
            this.textBoxDBstatus.TabIndex = 1;
            this.textBoxDBstatus.Text = "未连接";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "数据库状态：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBoxsingleconn);
            this.groupBox1.Controls.Add(this.textBoxepoch);
            this.groupBox1.Controls.Add(this.rBcircle);
            this.groupBox1.Controls.Add(this.rBsingle);
            this.groupBox1.Controls.Add(this.buttonexit);
            this.groupBox1.Controls.Add(this.buttonendtest);
            this.groupBox1.Controls.Add(this.buttonrestart);
            this.groupBox1.Controls.Add(this.buttonstarttest);
            this.groupBox1.Location = new System.Drawing.Point(681, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 112);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自动测试";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonopenconfig);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxreceivebytes);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBoxsendbytes);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(498, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 203);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配置";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxPLCip);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxconn);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.buttondisconn);
            this.groupBox3.Controls.Add(this.comboBoxlocalIP);
            this.groupBox3.Controls.Add(this.buttonconn);
            this.groupBox3.Controls.Add(this.textBoxtestport);
            this.groupBox3.Location = new System.Drawing.Point(19, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 136);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "手动连接";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rBUDPFSU);
            this.groupBox4.Controls.Add(this.rBTCPPLC);
            this.groupBox4.Location = new System.Drawing.Point(19, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 56);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "模式切换";
            // 
            // rBUDPFSU
            // 
            this.rBUDPFSU.AutoSize = true;
            this.rBUDPFSU.Location = new System.Drawing.Point(260, 25);
            this.rBUDPFSU.Name = "rBUDPFSU";
            this.rBUDPFSU.Size = new System.Drawing.Size(108, 19);
            this.rBUDPFSU.TabIndex = 1;
            this.rBUDPFSU.Text = "Modbus/UDP";
            this.rBUDPFSU.UseVisualStyleBackColor = true;
            this.rBUDPFSU.CheckedChanged += new System.EventHandler(this.rBUDPFSU_CheckedChanged);
            // 
            // rBTCPPLC
            // 
            this.rBTCPPLC.AutoSize = true;
            this.rBTCPPLC.Checked = true;
            this.rBTCPPLC.Location = new System.Drawing.Point(45, 25);
            this.rBTCPPLC.Name = "rBTCPPLC";
            this.rBTCPPLC.Size = new System.Drawing.Size(108, 19);
            this.rBTCPPLC.TabIndex = 0;
            this.rBTCPPLC.TabStop = true;
            this.rBTCPPLC.Text = "Modbus/TCP";
            this.rBTCPPLC.UseVisualStyleBackColor = true;
            this.rBTCPPLC.CheckedChanged += new System.EventHandler(this.rBTCPPLC_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1347, 787);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.buttonloadtest);
            this.Controls.Add(this.checkBoxsavelog);
            this.Controls.Add(this.textBoxinfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridtest);
            this.Controls.Add(this.bsaveconfigo);
            this.Controls.Add(this.bloadconfigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridObject);
            this.Controls.Add(this.dataGridPLC);
            this.Controls.Add(this.bsaveconfig);
            this.Controls.Add(this.bloadconfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLC组态文件交互测试工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtest)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPageexcel.ResumeLayout(false);
            this.tabPageexcel.PerformLayout();
            this.tabPagedatabase.ResumeLayout(false);
            this.tabPagedatabase.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPLC;
        private System.Windows.Forms.DataGridView dataGridObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bsaveconfig;
        private System.Windows.Forms.Button bloadconfig;
        private System.Windows.Forms.TextBox textBoxtestport;
        private System.Windows.Forms.ComboBox comboBoxlocalIP;
        private System.Windows.Forms.TextBox textBoxPLCip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonloadtest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonendtest;
        private System.Windows.Forms.Button buttonstarttest;
        private System.Windows.Forms.TextBox textBoxepoch;
        private System.Windows.Forms.DataGridView dataGridtest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox textBoxinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLCid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLCname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLCip;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLCport;
        private System.Windows.Forms.CheckBox checkBoxsavelog;
        private System.Windows.Forms.Timer timersavelog;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.TextBox textBoxconn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonconn;
        private System.Windows.Forms.Button buttondisconn;
        private System.Windows.Forms.Button bloadconfigo;
        private System.Windows.Forms.Button bsaveconfigo;
        private System.Windows.Forms.RadioButton rBcircle;
        private System.Windows.Forms.RadioButton rBsingle;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectid;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectip;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectport;
        private System.Windows.Forms.DataGridViewTextBoxColumn objecttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn settime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLCindex;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectindex;
        private System.Windows.Forms.DataGridViewTextBoxColumn memadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn memtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn testtype;
        private System.Windows.Forms.Button buttonrestart;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxresult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxreceivebytes;
        private System.Windows.Forms.TextBox textBoxsendbytes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timerBytes;
        private System.Windows.Forms.CheckBox checkBoxsingleconn;
        private System.Windows.Forms.Button buttonopenconfig;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPageexcel;
        private System.Windows.Forms.TabPage tabPagedatabase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttondeleteDB;
        private System.Windows.Forms.Button buttonopenDB;
        private System.Windows.Forms.TextBox textBoxDBstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonopenExcelF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rBUDPFSU;
        private System.Windows.Forms.RadioButton rBTCPPLC;
    }
}

