using Charity.Dal.Common;
using Charity.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Charity.Dal.Bend
{
    public class BendAccountDal : BaseDal
    {
        #region --以列表查询显示
        public IList<Tuseraccount> Scan_Account()
        {
            const string Scan_Accountsql = @"select ID,
                                                    UsAccount,
                                                    UsPassword,
                                                    UsName,
                                                    UsNiname,
                                                    UsPhone,
                                                    Usmail,
                                                    UsIdcard,
                                                    UsSettime,
                                                    UsRemark
                                            from dbo.Tuseraccount
                                           ";
            //using (DbConnection conn = DbFactory.CreateConnection())
            //{
            //    return conn.Query<Tinfo>(Query_MesgBendInfo).ToList();
            //}
            return base.Query<Tuseraccount>(Scan_Accountsql).ToList();
        }
        #endregion

        #region  --对数据库进行 BendAccount 增加的操作--
        public bool AddAccountMSG(Tuseraccount model)
        {
            var result = false;
            const string AddAccountMSGsql = @"
                               INSERT INTO dbo.Tuseraccount
                                        ( UsAccount,UsPassword,UsName,UsNiname,UsPhone,Usmail,UsIdcard,UsSettime,UsRemark) 
                                VALUES  ( @UsAccount, 
                                          @UsPassword,
                                          @UsName,
                                          @UsNiname,
                                          @UsPhone,
                                          @Usmail,
                                          @UsIdcard,
                                          @UsSettime,
                                          @UsRemark
                                         )";

            try
            {
                using (DbConnection conn = DbFactory.CreateConnection())
                {
                    result = conn.Execute(AddAccountMSGsql, model) > 0;
                    return result;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region  --对数据库进行 BendAccount 单个查找的操作--
        public Tuseraccount Query_Account(int Id)
        {
            const string Query_Accountsql = @"select    ID,
                                                        UsAccount,
                                                        UsPassword,
                                                        UsName,
                                                        UsNiname,
                                                        UsPhone,
                                                        Usmail,
                                                        UsIdcard,
                                                        UsSettime,
                                                        UsRemark
                                            from dbo.Tuseraccount
                                            where ID = @Id
                                           ";
            return base.QueryFirst<Tuseraccount>(Query_Accountsql, new { Id = Id });
        }

        #endregion

        #region  --对数据库进行 BendAccount 更新的操作--
        public bool Update_AccountMSG(Tuseraccount model)
        {
            const string Update_AccountMSGsql = @"
				UPDATE dbo.Tuseraccount
                SET	    UsAccount = @UsAccount, 
                        UsPassword = @UsPassword,
                        UsName = @UsName,
                        UsNiname = @UsNiname,
                        UsPhone = @UsPhone,
                        Usmail = @Usmail,
                        UsIdcard = @UsIdcard,
                        UsSettime = @UsSettime,
                        UsRemark = @UsRemark
				WHERE ID=@ID";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                var result = conn.Execute(Update_AccountMSGsql, model) > 0;
                return result;
            }
        }

        #endregion

        #region  --对数据库进行 BendAccount 删除的操作--
        public bool Account_Delected(int Id)
        {
            const string Account_Delectedsql = @"
				DELETE FROM dbo.Tuseraccount 
				WHERE ID=@ID
                        ";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("ID", Id);
                var result = conn.Execute(Account_Delectedsql, dp) > 0;
                return result;
            }
        }
        #endregion

    }
}
