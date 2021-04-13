using System;
using System.Windows.Forms;

namespace PLC_Test
{
    public partial class SQLLog : System.Windows.Forms.Form
    {
        public bool isdefaultDB = false;
        public SQLClass login = new SQLClass();
        
        public SQLLog()
        {
            InitializeComponent();
        }

        private void checkBoxdefaultDB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxdefaultDB.Checked)
            {
                isdefaultDB = true;
            }
            else
            {
                isdefaultDB = false;
            }
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            if (textBoxserver.Text == "" | textBoxdatabase.Text == "" | textBoxusername.Text == "" | textBoxpassword.Text == "")
            {
                MessageBox.Show("文本框为空。", "警告");
                return;
            }
            login = new SQLClass(textBoxserver.Text, textBoxdatabase.Text, textBoxusername.Text, textBoxpassword.Text);
            DialogResult = DialogResult.OK;
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
