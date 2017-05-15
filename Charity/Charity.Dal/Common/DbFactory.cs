using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;

namespace Charity.Dal.Common
{
    public static class DbFactory
    {
        static readonly string ConnectString = ConfigurationManager.AppSettings["ConnectionString"];
        public static DbConnection CreateConnection()
         {
            return new SqlConnection(ConnectString);
        }

        //public readonly DbFactory aaa =  new DbFactory();


        // static readonly string ConnectString = ConfigurationManager.AppSettings["ConnectionString"];

        //static readonly DbFactory _instance = new DbFactory();

        //public static DbFactory Instance
        //{
        //    get { return _instance; }
        //}

        //public DbConnection CreateConnection()
        //{
        //    return new SqlConnection(ConnectString);
        //}

        //public DbConnection CreateConnection(DbConnStrType connStrType)
        //{
        //    return new SqlConnection(DbConnStrCollection.GetConnectString(connStrType));
        //}



    }
}
