using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PLC_Test
{
    public class SQL
    {
        string sqlconn;
        SqlConnection mysql;

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
        }

        public void Disconnect()
        {
            //关闭数据库连接
            if (mysql.State != System.Data.ConnectionState.Closed)
            {
                mysql.Close();
            }
        }

        public void SaveDatatable(DataTable dt, string tablename)
        {
            //把Datatable保存到数据库
            string CreateT = "CREATE TABLE [" + tablename + "](";
            for(int i = 0; i < dt.Columns.Count; i++)
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
            return mysql.Database;
        }
    }
}
