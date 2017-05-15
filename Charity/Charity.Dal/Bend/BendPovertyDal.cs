using Charity.Dal.Common;
using Charity.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Charity.Dal.Bend
{
    public class BendPovertyDal : BaseDal
    {
        #region --以列表查询显示
        public IList<Tpoverty> Scan_Poverty()
        {
            const string Scan_Povertysql = @"select ID,
                                            ApplyArea, 
                                            ApplyName,
                                            ApplyPhone,
                                            ApplyInfo,
                                            ApplyValue,
                                            ApplySetTime
                                            from dbo.Tpoverty
                                           ";
            //using (DbConnection conn = DbFactory.CreateConnection())
            //{
            //    return conn.Query<Tinfo>(Query_MesgBendInfo).ToList();
            //}
            return base.Query<Tpoverty>(Scan_Povertysql).ToList();
        }
        #endregion

        #region  --对数据库进行 Poverty 增加的操作--
        public bool AddPovertyMSG(Tpoverty model)
        {
            var result = false;
            const string AddPovertyMSGsql = @"
                               INSERT INTO dbo.Tpoverty
                                        ( ApplyArea, ApplyName,ApplyPhone,ApplyInfo,ApplyValue,ApplySetTime) 
                                VALUES  ( @ApplyArea, 
                                          @ApplyName,
                                          @ApplyPhone,
                                          @ApplyInfo,
                                          @ApplyValue,
                                          @ApplySetTime
                                         )";

            try
            {
                using (DbConnection conn = DbFactory.CreateConnection())
                {
                    result = conn.Execute(AddPovertyMSGsql, model) > 0;
                    return result;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region  --对数据库进行 Poverty 单个查找的操作--
        public Tpoverty Query_Poverty(int Id)
        {
            const string Query_Povertysql = @"select ID,
                                            ApplyArea, 
                                            ApplyName,
                                            ApplyPhone,
                                            ApplyInfo,
                                            ApplyValue,
                                            ApplySetTime
                                            from dbo.Tpoverty
                                            where ID = @Id
                                           ";
            return base.QueryFirst<Tpoverty>(Query_Povertysql, new { Id = Id });
        }

        #endregion

        #region  --对数据库进行 Poverty 更新的操作--
        public bool Update_PovertyMSG(Tpoverty model)
        {
            const string Update_PovertyMSGsql = @"
				UPDATE dbo.Tpoverty
				SET	  ApplyArea =@ApplyArea, 
                      ApplyName =@ApplyName,
                      ApplyPhone =@ApplyPhone,
                      ApplyInfo =@ApplyInfo,
                      ApplyValue =@ApplyValue,
                      ApplySetTime =@ApplySetTime
				WHERE ID=@ID";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                var result = conn.Execute(Update_PovertyMSGsql, model) > 0;
                return result;
            }
        }

        #endregion

        #region  --对数据库进行 Poverty 删除的操作--
        public bool Poverty_Delected(int Id)
        {
            const string Poverty_Delectedsql = @"
				DELETE FROM dbo.Tpoverty 
				WHERE ID=@ID
                        ";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("ID", Id);
                var result = conn.Execute(Poverty_Delectedsql, dp) > 0;
                return result;
            }
        }
        #endregion
    }
}
