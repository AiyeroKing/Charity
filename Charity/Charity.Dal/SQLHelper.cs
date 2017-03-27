using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Charity.Dal
{
    public class SQLHelper
    {
        #region--连接数据库--  

        public SqlConnection Conn()
        {
            string connstr = "Server=AIYERO-WORK\\SQL2014;DataBase=CharityOs;uid=sa;pwd=123";
            SqlConnection myConn = new SqlConnection(connstr);
            return myConn;
        }

        #endregion

        #region--连接SqlConnection,执行SQL 功能:增加、删除、更新--  
        public void ExecData(string sqlstr,SqlParameter[] para)
        {
            SqlConnection sqlcon = this.Conn();
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sqlstr, sqlcon);

            foreach (var item in para)
            {
                sqlcom.Parameters.Add(item);
            }
            
            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            sqlcon.Close();
            sqlcon.Dispose();
        }

        #endregion

        #region--创建SqlDataReader对象  功能:查询--  
        public SqlDataReader ReadData(string sqlstr, SqlParameter[] para)
        {
            SqlConnection sqlcon = this.Conn();
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sqlstr, sqlcon);
            foreach (var item in para)
            {
                sqlcom.Parameters.Add(item);
            }
            SqlDataReader sqlread = sqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            return sqlread;
        }

        #endregion

    }
}











