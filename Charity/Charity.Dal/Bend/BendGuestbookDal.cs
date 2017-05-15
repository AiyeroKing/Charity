using Charity.Dal.Common;
using Charity.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Charity.Dal.Bend
{
    public class BendGuestbookDal : BaseDal
    {
        #region --以列表查询显示
        public IList<TGuestbook> Scan_Guestbook()
        {
            const string Scan_Guestbooksql = @"select ID,
                                            BoredTital,
                                            BoredName,
                                            BoredBody,
                                            BoredSetTime,
                                            BoredTelphone,
                                            BoredEmail,
                                            BoredIndex 
                                            from dbo.TGuestbook
                                           ";
            //using (DbConnection conn = DbFactory.CreateConnection())
            //{
            //    return conn.Query<Tinfo>(Query_MesgBendInfo).ToList();
            //}
            return base.Query<TGuestbook>(Scan_Guestbooksql).ToList();
        }
        #endregion

        #region  --对数据库进行Guestbook增加的操作--
        public bool AddGuestbookMSG(TGuestbook model)
        {
            var result = false;
            const string AddGuestbookMSGsql = @"
                               INSERT INTO dbo.TGuestbook
                                        ( BoredTital, BoredName,BoredBody,BoredSetTime,BoredTelphone,BoredEmail,BoredIndex) 
                                VALUES  ( @BoredTital, 
                                          @BoredName,
                                          @BoredBody,
                                          @BoredSetTime,
                                          @BoredTelphone,
                                          @BoredEmail,
                                          @BoredIndex
                                         )";

            try
            {
                using (DbConnection conn = DbFactory.CreateConnection())
                {
                    result = conn.Execute(AddGuestbookMSGsql, model) > 0;
                    return result;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region  --对数据库进行Guestbook单个查找的操作--
        public TGuestbook Query_Guestbook(int Id)
        {
            const string Query_Guestbooksql = @"select ID,
                                            BoredTital,
                                            BoredName,
                                            BoredBody,
                                            BoredSetTime,
                                            BoredTelphone,
                                            BoredEmail,
                                            BoredIndex
                                            from dbo.TGuestbook
                                            where ID = @Id
                                           ";
            return base.QueryFirst<TGuestbook>(Query_Guestbooksql, new { Id = Id });
        }

        #endregion

        #region  --对数据库进行Guestbook更新的操作--
        public bool UpdateGuestbookMSG(TGuestbook model)
        {
            const string UpdateGuestbookMSGsql = @"
				UPDATE dbo.TGuestbook
				SET	BoredTital = @BoredTital,
                    BoredName = @BoredName,
                    BoredBody = @BoredBody,
                    BoredSetTime = @BoredSetTime,
                    BoredTelphone = @BoredTelphone,
                    BoredEmail = @BoredEmail,
                    BoredIndex = @BoredIndex
				WHERE ID=@ID";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                var result = conn.Execute(UpdateGuestbookMSGsql, model) > 0;
                return result;
            }
        }

        #endregion

        #region  --对数据库进行Guestbook删除的操作--
        public bool DelectResult(int Id)
        {
            const string DelectResultsql = @"
				DELETE FROM dbo.TGuestbook 
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
