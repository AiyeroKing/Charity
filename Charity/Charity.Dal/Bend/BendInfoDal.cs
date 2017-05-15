using Charity.Dal.Common;
using Charity.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Charity.Dal.Bend
{
    public class BendInfoDal : BaseDal
    {
        #region --对BendInfo数据进行增加操作的Dal语句--
        public bool AddMesgBendInfo(Tinfo model)
        {
            var result = false;
            const string AddMesgBendInfosql = @"
                               INSERT INTO dbo.Tinfo
                                        ( InfoTital, InfoName,InfoBody,InfoSetTime) 
                                VALUES  ( @InfoTital, 
                                          @InfoName,
                                          @InfoBody,
                                          @InfoSetTime
                                    ) ";


            try
            {
                using (DbConnection conn = DbFactory.CreateConnection())
                {
                    result = conn.Execute(AddMesgBendInfosql, model) > 0;
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
            //base.Excute();
            //return result;
        }


        #endregion
        
        #region --对BendInfo数据进行遍历操作的Dal语句--
        public IList<Tinfo> QueryMesgBendInfo()
        {
            const string Query_MesgBendInfosql = @"select ID,
                                            InfoTital,
                                            InfoName,
                                            InfoBody,
                                            InfoSetTime 
                                            from dbo.Tinfo
                                           ";
            //using (DbConnection conn = DbFactory.CreateConnection())
            //{
            //    return conn.Query<Tinfo>(Query_MesgBendInfo).ToList();
            //}
            return base.Query<Tinfo>(Query_MesgBendInfosql).ToList();
        }
        #endregion
        
        #region --对BendInfo数据进行遍历操作的Dal语句--
        public Tinfo QueryOnesMesgBendInfo(int Id)
        {
            const string Query_OnesMesgBendInfosql = @"select ID,
                                            InfoTital,
                                            InfoName,
                                            InfoBody,
                                            InfoSetTime 
                                            from dbo.Tinfo
                                            where ID = @Id
                                           ";
            //using (DbConnection conn = DbFactory.CreateConnection())
            //{
            //    return conn.Query<Tinfo>(Query_MesgBendInfo).ToList();
            //}

            var Model = base.QueryFirst<Tinfo>(Query_OnesMesgBendInfosql, new { Id = Id });
            return Model;
        }
        #endregion

        #region --对BendInfo数据进行更新操作的Dal语句--
        public bool UpdateMesgBendInfo(Tinfo model)
        {
            const string update_MesgBendInfoSql = @"
				UPDATE dbo.Tinfo
				SET	InfoTital=@InfoTital,
					InfoName=@InfoName,
					InfoBody=@InfoBody,
                    InfoSetTime=@InfoSetTime
				WHERE ID=@ID";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                var result = conn.Execute(update_MesgBendInfoSql, model) > 0;
                return result;
            }
        }
        #endregion

        #region --对BendInfo数据进行删除操作的Dal语句--
        public bool delectResult(int Id)
        {
            const string delectResultsql = @"
				DELETE FROM dbo.TInfo 
				WHERE ID=@ID
                        ";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("ID", Id);
                var result = conn.Execute(delectResultsql, dp) > 0;
                return result;
            }

        }
        #endregion
    }
}
