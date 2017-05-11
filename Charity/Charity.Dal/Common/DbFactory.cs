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



    }
}
