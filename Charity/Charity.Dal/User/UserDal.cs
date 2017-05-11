using System.Data.Common;
using Charity.Model;
using System.Data.SqlClient;
using Charity.Dal.Common;
using Dapper;

namespace Charity.Dal
{
    public class UserDal
    {
        #region --对数据进行增加操作的Dal语句--
        SQLHelper sqlh = new SQLHelper();
        public bool AddUserMSG(UserInfo model)
        {
            var result = false;
            const string adduserMSGSql = @"
                                INSERT INTO dbo.UserInfo
                                        ( UserName, PassWord) 
                                VALUES  ( @UserName, 
                                          @PassWord 
                                    ) ";


            try
            {
                using (DbConnection conn = DbFactory.CreateConnection())
                {
                    result = conn.Execute(adduserMSGSql, model) > 0;

                    return result;
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }

            //SqlParameter[] para = new SqlParameter[]
            //{
            //    new SqlParameter("UserName",model.UserName),
            //    new SqlParameter("PassWord", model.PassWord)
            //    };
            //sqlh.ExecData(adduserMSGSql, para);

            //return result;

        }

        
        #endregion
    }
}

