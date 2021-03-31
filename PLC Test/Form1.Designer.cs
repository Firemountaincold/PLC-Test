
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
            this.dataGridPLC = new System.Windows.Forms.DataGridView();
            this.PLCid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLCname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLCip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLCport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridObject = new System.Windows.Forms.DataGridView();
            this.objectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectporttype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.objectport = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.objecttype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.objectprotocol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.buttonendtest = new System.Windows.Forms.Button();
            this.buttonstarttest = new System.Windows.Forms.Button();
            this.textBoxepoch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonloadtest = new System.Windows.Forms.Button();
            this.dataGridtest = new System.Windows.Forms.DataGridView();
            this.settime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLCindex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectindex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxinfo = new System.Windows.Forms.RichTextBox();
            this.checkBoxsavelog = new System.Windows.Forms.CheckBox();
            this.timersavelog = new System.Windows.Forms.Timer(this.components);
            this.timerTest = new System.Windows.Forms.Timer(this.components);
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
            this.dataGridPLC.Location = new System.Drawing.Point(22, 222);
            this.dataGridPLC.Name = "dataGridPLC";
            this.dataGridPLC.RowHeadersVisible = false;
            this.dataGridPLC.RowHeadersWidth = 51;
            this.dataGridPLC.RowTemplate.Height = 27;
            this.dataGridPLC.Size = new System.Drawing.Size(629, 238);
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
            this.objectporttype,
            this.objectport,
            this.objecttype,
            this.objectprotocol});
            this.dataGridObject.Location = new System.Drawing.Point(22, 496);
            this.dataGridObject.Name = "dataGridObject";
            this.dataGridObject.RowHeadersVisible = false;
            this.dataGridObject.RowHeadersWidth = 51;
            this.dataGridObject.RowTemplate.Height = 27;
            this.dataGridObject.Size = new System.Drawing.Size(629, 241);
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
            // objectporttype
            // 
            this.objectporttype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objectporttype.DataPropertyName = "objectporttype";
            this.objectporttype.HeaderText = "端口类型";
            this.objectporttype.MinimumWidth = 6;
            this.objectporttype.Name = "objectporttype";
            // 
            // objectport
            // 
            this.objectport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objectport.DataPropertyName = "objectport";
            this.objectport.HeaderText = "端口号";
            this.objectport.MinimumWidth = 6;
            this.objectport.Name = "objectport";
            // 
            // objecttype
            // 
            this.objecttype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objecttype.DataPropertyName = "objecttype";
            this.objecttype.HeaderText = "设备类型";
            this.objecttype.MinimumWidth = 6;
            this.objecttype.Name = "objecttype";
            // 
            // objectprotocol
            // 
            this.objectprotocol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objectprotocol.DataPropertyName = "objectprotocol";
            this.objectprotocol.HeaderText = "设备协议";
            this.objectprotocol.MinimumWidth = 6;
            this.objectprotocol.Name = "objectprotocol";
            // 
            // groupBox1
            // 
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
            // textBoxtestport
            // 
            this.textBoxtestport.Location = new System.Drawing.Point(342, 50);
            this.textBoxtestport.Name = "textBoxtestport";
            this.textBoxtestport.Size = new System.Drawing.Size(67, 25);
            this.textBoxtestport.TabIndex = 9;
            // 
            // comboBoxlocalIP
            // 
            this.comboBoxlocalIP.FormattingEnabled = true;
            this.comboBoxlocalIP.Location = new System.Drawing.Point(109, 52);
            this.comboBoxlocalIP.Name = "comboBoxlocalIP";
            this.comboBoxlocalIP.Size = new System.Drawing.Size(119, 23);
            this.comboBoxlocalIP.TabIndex = 8;
            // 
            // textBoxPLCid
            // 
            this.textBoxPLCid.Location = new System.Drawing.Point(342, 20);
            this.textBoxPLCid.Name = "textBoxPLCid";
            this.textBoxPLCid.Size = new System.Drawing.Size(67, 25);
            this.textBoxPLCid.TabIndex = 7;
            // 
            // textBoxPLCip
            // 
            this.textBoxPLCip.Location = new System.Drawing.Point(109, 21);
            this.textBoxPLCip.Name = "textBoxPLCip";
            this.textBoxPLCip.Size = new System.Drawing.Size(119, 25);
            this.textBoxPLCip.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 55);
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
            this.label4.Location = new System.Drawing.Point(245, 28);
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
            this.bsaveconfig.Location = new System.Drawing.Point(452, 18);
            this.bsaveconfig.Name = "bsaveconfig";
            this.bsaveconfig.Size = new System.Drawing.Size(100, 25);
            this.bsaveconfig.TabIndex = 1;
            this.bsaveconfig.Text = "保存配置";
            this.bsaveconfig.UseVisualStyleBackColor = true;
            this.bsaveconfig.Click += new System.EventHandler(this.bsaveconfig_Click);
            // 
            // bloadconfig
            // 
            this.bloadconfig.Location = new System.Drawing.Point(452, 49);
            this.bloadconfig.Name = "bloadconfig";
            this.bloadconfig.Size = new System.Drawing.Size(100, 25);
            this.bloadconfig.TabIndex = 0;
            this.bloadconfig.Text = "加载配置";
            this.bloadconfig.UseVisualStyleBackColor = true;
            this.bloadconfig.Click += new System.EventHandler(this.bloadconfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "PLC列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "对象列表";
            // 
            // groupBox2
            // 
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
            // buttonendtest
            // 
            this.buttonendtest.Location = new System.Drawing.Point(507, 23);
            this.buttonendtest.Name = "buttonendtest";
            this.buttonendtest.Size = new System.Drawing.Size(100, 25);
            this.buttonendtest.TabIndex = 12;
            this.buttonendtest.Text = "结束测试";
            this.buttonendtest.UseVisualStyleBackColor = true;
            this.buttonendtest.Click += new System.EventHandler(this.buttonendtest_Click);
            // 
            // buttonstarttest
            // 
            this.buttonstarttest.Location = new System.Drawing.Point(379, 23);
            this.buttonstarttest.Name = "buttonstarttest";
            this.buttonstarttest.Size = new System.Drawing.Size(100, 25);
            this.buttonstarttest.TabIndex = 11;
            this.buttonstarttest.Text = "开始测试";
            this.buttonstarttest.UseVisualStyleBackColor = true;
            this.buttonstarttest.Click += new System.EventHandler(this.buttonstarttest_Click);
            // 
            // textBoxepoch
            // 
            this.textBoxepoch.Location = new System.Drawing.Point(252, 22);
            this.textBoxepoch.Name = "textBoxepoch";
            this.textBoxepoch.Size = new System.Drawing.Size(67, 25);
            this.textBoxepoch.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "测试次数：";
            // 
            // buttonloadtest
            // 
            this.buttonloadtest.Location = new System.Drawing.Point(24, 23);
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
            this.function,
            this.funcadd,
            this.funcvalue});
            this.dataGridtest.Location = new System.Drawing.Point(673, 222);
            this.dataGridtest.Name = "dataGridtest";
            this.dataGridtest.RowHeadersVisible = false;
            this.dataGridtest.RowHeadersWidth = 51;
            this.dataGridtest.RowTemplate.Height = 27;
            this.dataGridtest.Size = new System.Drawing.Size(629, 238);
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
            // function
            // 
            this.function.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.function.DataPropertyName = "操作名称";
            this.function.HeaderText = "操作名称";
            this.function.MinimumWidth = 6;
            this.function.Name = "function";
            // 
            // funcadd
            // 
            this.funcadd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.funcadd.DataPropertyName = "操作地址";
            this.funcadd.HeaderText = "操作地址";
            this.funcadd.MinimumWidth = 6;
            this.funcadd.Name = "funcadd";
            // 
            // funcvalue
            // 
            this.funcvalue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.funcvalue.DataPropertyName = "操作值";
            this.funcvalue.HeaderText = "操作值";
            this.funcvalue.MinimumWidth = 6;
            this.funcvalue.Name = "funcvalue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(670, 197);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PLC测试工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn objectid;
        private System.Windows.Forms.DataGridViewComboBoxColumn objectporttype;
        private System.Windows.Forms.DataGridViewComboBoxColumn objectport;
        private System.Windows.Forms.DataGridViewComboBoxColumn objecttype;
        private System.Windows.Forms.DataGridViewComboBoxColumn objectprotocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn settime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLCindex;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectindex;
        private System.Windows.Forms.DataGridViewTextBoxColumn function;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcvalue;
        private System.Windows.Forms.CheckBox checkBoxsavelog;
        private System.Windows.Forms.Timer timersavelog;
        private System.Windows.Forms.Timer timerTest;
    }
}

