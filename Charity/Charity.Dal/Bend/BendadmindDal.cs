using Charity.Dal.Common;
using Charity.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Dal.Bend
{
    public class BendadmindDal : BaseDal
    {
        #region --以列表查询显示
        public IList<Tadmin> Scan_Bendadmind()
        {
            const string Scan_Bendadmindsql = @"select ID,
                                                       AdAccount,
                                                       AdPassWord,
                                                       AdName,
                                                       AdPhone,
                                                       AdSection,
                                                       AdIdCard,
                                                       AdSetTime,
                                                       AdRemark
                                            from dbo.Tadmin
                                           ";
            //using (DbConnection conn = DbFactory.CreateConnection())
            //{
            //    return conn.Query<Tinfo>(Query_MesgBendInfo).ToList();
            //}
            return base.Query<Tadmin>(Scan_Bendadmindsql).ToList();
        }
        #endregion

        #region  --对数据库进行Bendadmin增加的操作--
        public bool AddBendadmindMSG(Tadmin model)
        {
            var result = false;
            const string AddBendadmindMSGsql = @"
                               INSERT INTO dbo.Tadmin
                                        ( AdAccount,AdPassWord,AdName,AdPhone,AdSection, AdIdCard,AdSetTime,AdRemark) 
                                VALUES  (
                                        @AdAccount,
                                        @AdPassWord,
                                        @AdName,
                                        @AdPhone,
                                        @AdSection,
                                        @AdIdCard,
                                        @AdSetTime,
                                        @AdRemark
                                         )";

            try
            {
                using (DbConnection conn = DbFactory.CreateConnection())
                {
                    result = conn.Execute(AddBendadmindMSGsql, model) > 0;
                    return result;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region  --对数据库进行Bendadmin单个查找的操作--
        public Tadmin Query_Bendadmind(int Id)
        {
            const string Query_Bendadmindsql = @"select ID,
                                                       AdAccount,
                                                       AdPassWord,
                                                       AdName,
                                                       AdPhone,
                                                       AdSection,
                                                       AdIdCard,
                                                       AdSetTime,
                                                       AdRemark
                                            from dbo.Tadmin
                                            where ID = @Id
                                           ";
            return base.QueryFirst<Tadmin>(Query_Bendadmindsql, new { Id = Id });
        }

        #endregion

        #region  --对数据库进行Bendadmin更新的操作--
        public bool UpdateBendadmindMSG(Tadmin model)
        {
            const string UpdateGuestbookMSGsql = @"
				UPDATE dbo.Tadmin
				SET	
                    AdAccount  = @AdAccount,
                    AdPassWord = @AdPassWord,
                    AdName     = @AdName,
                    AdPhone    = @AdPhone,
                    AdSection  = @AdSection,
                    AdIdCard   = @AdIdCard,
                    AdSetTime  = @AdSetTime,
                    AdRemark   = @AdRemark
				WHERE ID=@ID";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                var result = conn.Execute(UpdateGuestbookMSGsql, model) > 0;
                return result;
            }
        }

        #endregion

        #region  --对数据库进行Bendadmin删除的操作--
        public bool DelectResult(int Id)
        {
            const string DelectResultsql = @"
				DELETE FROM dbo.Tadmin 
				WHERE ID=@ID
                        ";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("ID", Id);
                var result = conn.Execute(DelectResultsql, dp) > 0;
                return result;
            }
        }
        #endregion
    }
}
