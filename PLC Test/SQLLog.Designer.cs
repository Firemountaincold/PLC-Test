
namespace PLC_Test
{
    partial class SQLLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxserver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxdatabase = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.buttonlog = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.checkBoxdefaultDB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器：";
            // 
            // textBoxserver
            // 
            this.textBoxserver.Location = new System.Drawing.Point(116, 21);
            this.textBoxserver.Name = "textBoxserver";
            this.textBoxserver.Size = new System.Drawing.Size(203, 25);
            this.textBoxserver.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据库：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "密码：";
            // 
            // textBoxdatabase
            // 
            this.textBoxdatabase.Location = new System.Drawing.Point(116, 60);
            this.textBoxdatabase.Name = "textBoxdatabase";
            this.textBoxdatabase.Size = new System.Drawing.Size(203, 25);
            this.textBoxdatabase.TabIndex = 5;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(116, 102);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(203, 25);
            this.textBoxusername.TabIndex = 6;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(116, 141);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(203, 25);
            this.textBoxpassword.TabIndex = 7;
            // 
            // buttonlog
            // 
            this.buttonlog.Location = new System.Drawing.Point(28, 221);
            this.buttonlog.Name = "buttonlog";
            this.buttonlog.Size = new System.Drawing.Size(124, 25);
            this.buttonlog.TabIndex = 8;
            this.buttonlog.Text = "登录";
            this.buttonlog.UseVisualStyleBackColor = true;
            this.buttonlog.Click += new System.EventHandler(this.buttonlog_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(209, 221);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(124, 25);
            this.buttoncancel.TabIndex = 9;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // checkBoxdefaultDB
            // 
            this.checkBoxdefaultDB.AutoSize = true;
            this.checkBoxdefaultDB.Location = new System.Drawing.Point(85, 185);
            this.checkBoxdefaultDB.Name = "checkBoxdefaultDB";
            this.checkBoxdefaultDB.Size = new System.Drawing.Size(209, 19);
            this.checkBoxdefaultDB.TabIndex = 10;
            this.checkBoxdefaultDB.Text = "将此数据库设为默认数据库";
            this.checkBoxdefaultDB.UseVisualStyleBackColor = true;
            this.checkBoxdefaultDB.CheckedChanged += new System.EventHandler(this.checkBoxdefaultDB_CheckedChanged);
            // 
            // SQLLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(355, 266);
            this.Controls.Add(this.checkBoxdefaultDB);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonlog);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.textBoxdatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxserver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SQLLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录SQL数据库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxserver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxdatabase;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Button buttonlog;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.CheckBox checkBoxdefaultDB;
    }
}