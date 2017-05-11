using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Dal.Common
{
    public static class CommonSqlStrings
    {
        static readonly string _scopeIdentity = " SELECT SCOPE_IDENTITY() AS ID ;";

        public static string ScopeIdentity
        {
            get { return CommonSqlStrings._scopeIdentity; }
        }


        static readonly string _identity = " SELECT @@IDENTITY AS ID ;";

        public static string Identity
        {
            get { return CommonSqlStrings._identity; }
        } 


        static readonly string _identityCurrentFomart = " SELECT IDENT_CURRENT('{0}') AS ID ";

        public static string IdentityCurrent(string tableName)
        {
            return string.Format(_identityCurrentFomart, tableName);
        }

        static readonly string _sqlPagingFomart = @"WITH t AS ({0}) SELECT * FROM t WHERE Row BETWEEN @Start AND @End ";

        public static string SqlPagingFomart
        {
            get { return CommonSqlStrings._sqlPagingFomart; }
        }

        public static string CreatePagingSql(string querySql)
        {
            return string.Format(_sqlPagingFomart, querySql);
        }
    }
}
