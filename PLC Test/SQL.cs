using System.Data;
using System.Data.SqlClient;

namespace PLC_Test
{
    public class SQL
    {
        string sqlconn;
        SqlConnection mysql;
        public bool isconnect = false;
        public SQL()
        {

        }

        public SQL(string sqlconn)
        {
            this.sqlconn = sqlconn;
        }

        public void ConnectDatabase()
        {
            //连接数据库
            mysql = new SqlConnection(sqlconn);
            mysql.Open();
            isconnect = true;
        }

        public void Disconnect()
        {
            //关闭数据库连接
            if (mysql.State != System.Data.ConnectionState.Closed)
            {
                mysql.Close();
                isconnect = false;
            }
        }

        public void SaveDatatable(DataTable dt, string tablename)
        {
            //把Datatable保存到数据库
            string CreateT = "CREATE TABLE [" + tablename + "](";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                CreateT += dt.Columns[i].Caption.ToString() + " varchar(100),";
            }
            CreateT += ")";
            SqlCommand comm = new SqlCommand(CreateT, mysql);
            comm.ExecuteNonQuery();
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(mysql))
            {
                bulkCopy.DestinationTableName = "[" + tablename + "]";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    bulkCopy.ColumnMappings.Add(dt.Columns[i].Caption.ToString(), dt.Columns[i].Caption.ToString());
                }
                bulkCopy.WriteToServer(dt);
            }
        }

        public void DeleteTable(string tablename)
        {
            string DeleteT = "DROP TABLE [" + tablename + "]";
            SqlCommand comm = new SqlCommand(DeleteT, mysql);
            comm.ExecuteNonQuery();
        }

        public string GetName()
        {
            if (mysql.State != ConnectionState.Closed)
            {
                return mysql.Database;
            }
            else
            {
                return "";
            }
        }
    }
}
