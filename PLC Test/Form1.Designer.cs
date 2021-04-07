
namespace PLC_Test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bloadconfigo = new System.Windows.Forms.Button();
            this.bsaveconfigo = new System.Windows.Forms.Button();
            this.buttondisconn = new System.Windows.Forms.Button();
            this.textBoxconn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonconn = new System.Windows.Forms.Button();
            this.textBoxtestport = new System.Windows.Forms.TextBox();
            this.comboBoxlocalIP = new System.Windows.Forms.ComboBox();
            this.textBoxPLCid = new System.Windows.Forms.TextBox();
            this.textBoxPLCip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bsaveconfig = new System.Windows.Forms.Button();
            this.bloadconfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonrestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObject)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtest)).BeginInit();
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
            this.dataGridPLC.Location = new System.Drawing.Point(22, 496);
            this.dataGridPLC.Name = "dataGridPLC";
            this.dataGridPLC.RowHeadersVisible = false;
            this.dataGridPLC.RowHeadersWidth = 51;
            this.dataGridPLC.RowTemplate.Height = 27;
            this.dataGridPLC.Size = new System.Drawing.Size(629, 104);
            this.dataGridPLC.TabIndex = 0;
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
            this.dataGridObject.Location = new System.Drawing.Point(22, 638);
            this.dataGridObject.Name = "dataGridObject";
            this.dataGridObject.RowHeadersVisible = false;
            this.dataGridObject.RowHeadersWidth = 51;
            this.dataGridObject.RowTemplate.Height = 27;
            this.dataGridObject.Size = new System.Drawing.Size(629, 99);
            this.dataGridObject.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bloadconfigo);
            this.groupBox1.Controls.Add(this.bsaveconfigo);
            this.groupBox1.Controls.Add(this.buttondisconn);
            this.groupBox1.Controls.Add(this.textBoxconn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buttonconn);
            this.groupBox1.Controls.Add(this.textBoxtestport);
            this.groupBox1.Controls.Add(this.comboBoxlocalIP);
            this.groupBox1.Controls.Add(this.textBoxPLCid);
            this.groupBox1.Controls.Add(this.textBoxPLCip);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bsaveconfig);
            this.groupBox1.Controls.Add(this.bloadconfig);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接";
            // 
            // bloadconfigo
            // 
            this.bloadconfigo.Location = new System.Drawing.Point(486, 127);
            this.bloadconfigo.Name = "bloadconfigo";
            this.bloadconfigo.Size = new System.Drawing.Size(124, 25);
            this.bloadconfigo.TabIndex = 15;
            this.bloadconfigo.Text = "加载对象配置";
            this.bloadconfigo.UseVisualStyleBackColor = true;
            this.bloadconfigo.Click += new System.EventHandler(this.bloadconfigo_Click);
            // 
            // bsaveconfigo
            // 
            this.bsaveconfigo.Location = new System.Drawing.Point(486, 96);
            this.bsaveconfigo.Name = "bsaveconfigo";
            this.bsaveconfigo.Size = new System.Drawing.Size(124, 25);
            this.bsaveconfigo.TabIndex = 14;
            this.bsaveconfigo.Text = "保存对象配置";
            this.bsaveconfigo.UseVisualStyleBackColor = true;
            this.bsaveconfigo.Click += new System.EventHandler(this.bsaveconfigo_Click);
            // 
            // buttondisconn
            // 
            this.buttondisconn.Location = new System.Drawing.Point(149, 96);
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
            this.textBoxconn.Location = new System.Drawing.Point(135, 136);
            this.textBoxconn.Name = "textBoxconn";
            this.textBoxconn.ReadOnly = true;
            this.textBoxconn.Size = new System.Drawing.Size(86, 18);
            this.textBoxconn.TabIndex = 12;
            this.textBoxconn.Text = "未连接";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "手动连接状态：";
            // 
            // buttonconn
            // 
            this.buttonconn.Location = new System.Drawing.Point(15, 96);
            this.buttonconn.Name = "buttonconn";
            this.buttonconn.Size = new System.Drawing.Size(104, 25);
            this.buttonconn.TabIndex = 10;
            this.buttonconn.Text = "手动连接";
            this.buttonconn.UseVisualStyleBackColor = true;
            this.buttonconn.Click += new System.EventHandler(this.buttonconn_Click);
            // 
            // textBoxtestport
            // 
            this.textBoxtestport.Location = new System.Drawing.Point(400, 50);
            this.textBoxtestport.Name = "textBoxtestport";
            this.textBoxtestport.Size = new System.Drawing.Size(67, 25);
            this.textBoxtestport.TabIndex = 9;
            // 
            // comboBoxlocalIP
            // 
            this.comboBoxlocalIP.Font = new System.Drawing.Font("宋体", 9F);
            this.comboBoxlocalIP.FormattingEnabled = true;
            this.comboBoxlocalIP.Location = new System.Drawing.Point(109, 52);
            this.comboBoxlocalIP.Name = "comboBoxlocalIP";
            this.comboBoxlocalIP.Size = new System.Drawing.Size(158, 23);
            this.comboBoxlocalIP.TabIndex = 8;
            // 
            // textBoxPLCid
            // 
            this.textBoxPLCid.Location = new System.Drawing.Point(400, 20);
            this.textBoxPLCid.Name = "textBoxPLCid";
            this.textBoxPLCid.Size = new System.Drawing.Size(67, 25);
            this.textBoxPLCid.TabIndex = 7;
            // 
            // textBoxPLCip
            // 
            this.textBoxPLCip.Font = new System.Drawing.Font("宋体", 9F);
            this.textBoxPLCip.Location = new System.Drawing.Point(109, 21);
            this.textBoxPLCip.Name = "textBoxPLCip";
            this.textBoxPLCip.Size = new System.Drawing.Size(158, 25);
            this.textBoxPLCip.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "检测端口：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "本机IP：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "测试PLC ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "测试PLC IP：";
            // 
            // bsaveconfig
            // 
            this.bsaveconfig.Location = new System.Drawing.Point(486, 18);
            this.bsaveconfig.Name = "bsaveconfig";
            this.bsaveconfig.Size = new System.Drawing.Size(124, 25);
            this.bsaveconfig.TabIndex = 1;
            this.bsaveconfig.Text = "保存PLC配置";
            this.bsaveconfig.UseVisualStyleBackColor = true;
            this.bsaveconfig.Click += new System.EventHandler(this.bsaveconfig_Click);
            // 
            // bloadconfig
            // 
            this.bloadconfig.Location = new System.Drawing.Point(486, 49);
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
            this.label1.Location = new System.Drawing.Point(19, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "PLC列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "对象列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonrestart);
            this.groupBox2.Controls.Add(this.buttonexit);
            this.groupBox2.Controls.Add(this.rBcircle);
            this.groupBox2.Controls.Add(this.rBsingle);
            this.groupBox2.Controls.Add(this.buttonendtest);
            this.groupBox2.Controls.Add(this.buttonstarttest);
            this.groupBox2.Controls.Add(this.textBoxepoch);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonloadtest);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox2.Location = new System.Drawing.Point(673, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 175);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自动测试";
            // 
            // rBcircle
            // 
            this.rBcircle.AutoSize = true;
            this.rBcircle.Location = new System.Drawing.Point(150, 127);
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
            this.rBsingle.Location = new System.Drawing.Point(30, 127);
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
            this.buttonendtest.Location = new System.Drawing.Point(478, 34);
            this.buttonendtest.Name = "buttonendtest";
            this.buttonendtest.Size = new System.Drawing.Size(124, 25);
            this.buttonendtest.TabIndex = 12;
            this.buttonendtest.Text = "结束测试";
            this.buttonendtest.UseVisualStyleBackColor = true;
            this.buttonendtest.Click += new System.EventHandler(this.buttonendtest_Click);
            // 
            // buttonstarttest
            // 
            this.buttonstarttest.Location = new System.Drawing.Point(322, 34);
            this.buttonstarttest.Name = "buttonstarttest";
            this.buttonstarttest.Size = new System.Drawing.Size(124, 25);
            this.buttonstarttest.TabIndex = 11;
            this.buttonstarttest.Text = "开始测试";
            this.buttonstarttest.UseVisualStyleBackColor = true;
            this.buttonstarttest.Click += new System.EventHandler(this.buttonstarttest_Click);
            // 
            // textBoxepoch
            // 
            this.textBoxepoch.Location = new System.Drawing.Point(125, 81);
            this.textBoxepoch.Name = "textBoxepoch";
            this.textBoxepoch.Size = new System.Drawing.Size(67, 25);
            this.textBoxepoch.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "测试次数：";
            // 
            // buttonloadtest
            // 
            this.buttonloadtest.Location = new System.Drawing.Point(30, 34);
            this.buttonloadtest.Name = "buttonloadtest";
            this.buttonloadtest.Size = new System.Drawing.Size(125, 25);
            this.buttonloadtest.TabIndex = 0;
            this.buttonloadtest.Text = "加载测试流程";
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
            this.dataGridtest.Location = new System.Drawing.Point(22, 222);
            this.dataGridtest.Name = "dataGridtest";
            this.dataGridtest.RowHeadersVisible = false;
            this.dataGridtest.RowHeadersWidth = 51;
            this.dataGridtest.RowTemplate.Height = 27;
            this.dataGridtest.Size = new System.Drawing.Size(1280, 238);
            this.dataGridtest.TabIndex = 7;
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
            this.label8.Location = new System.Drawing.Point(19, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "测试流程";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(670, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "运行日志";
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxinfo.Location = new System.Drawing.Point(673, 496);
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.ReadOnly = true;
            this.textBoxinfo.Size = new System.Drawing.Size(629, 241);
            this.textBoxinfo.TabIndex = 10;
            this.textBoxinfo.Text = "";
            // 
            // checkBoxsavelog
            // 
            this.checkBoxsavelog.AutoSize = true;
            this.checkBoxsavelog.Location = new System.Drawing.Point(1179, 472);
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
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(478, 117);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(124, 25);
            this.buttonexit.TabIndex = 16;
            this.buttonexit.Text = "退出软件";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonrestart
            // 
            this.buttonrestart.Location = new System.Drawing.Point(322, 117);
            this.buttonrestart.Name = "buttonrestart";
            this.buttonrestart.Size = new System.Drawing.Size(124, 25);
            this.buttonrestart.TabIndex = 16;
            this.buttonrestart.Text = "重新启动软件";
            this.buttonrestart.UseVisualStyleBackColor = true;
            this.buttonrestart.Click += new System.EventHandler(this.buttonrestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1324, 750);
            this.Controls.Add(this.checkBoxsavelog);
            this.Controls.Add(this.textBoxinfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridtest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridObject);
            this.Controls.Add(this.dataGridPLC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PLC测试工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObject)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPLC;
        private System.Windows.Forms.DataGridView dataGridObject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bsaveconfig;
        private System.Windows.Forms.Button bloadconfig;
        private System.Windows.Forms.TextBox textBoxtestport;
        private System.Windows.Forms.ComboBox comboBoxlocalIP;
        private System.Windows.Forms.TextBox textBoxPLCid;
        private System.Windows.Forms.TextBox textBoxPLCip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
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
    }
}

