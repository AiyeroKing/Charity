using Charity.Dal.Common;
using Charity.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Charity.Dal.Bend
{
    public class BendMoneyDal :BaseDal
    {
        #region --以列表查询显示
        public IList<Tmoney> Scan_Money()
        {
            const string Scan_Moneysql = @"    select ID,
                                                      ChrityMoney,
                                                      ChrityName,
                                                      ChrityPhone,
                                                      ChrityIdcard,
                                                      ChritySetTime,
                                                      ChrityRemark
                                               from dbo.Tmoney
                                           ";
            //using (DbConnection conn = DbFactory.CreateConnection())
            //{
            //    return conn.Query<Tinfo>(Query_MesgBendInfo).ToList();
            //}
            return base.Query<Tmoney>(Scan_Moneysql).ToList();
        }
        #endregion

        #region  --对数据库进行 Money 增加的操作--
        public bool AddMoneyMSG(Tmoney model)
        {
            var result = false;
            const string AddMoneyMSGsql = @"
                               INSERT INTO dbo.Tmoney
                                        ( ChrityMoney, ChrityName,ChrityPhone,ChrityIdcard,ChritySetTime,ChrityRemark) 
                                VALUES  ( @ChrityMoney,
                                          @ChrityName,
                                          @ChrityPhone,
                                          @ChrityIdcard,
                                          @ChritySetTime,
                                          @ChrityRemark
                                         )";

            try
            {
                using (DbConnection conn = DbFactory.CreateConnection())
                {
                    result = conn.Execute(AddMoneyMSGsql, model) > 0;
                    return result;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region  --对数据库进行 Money 单个查找的操作--
        public Tmoney Query_Money(int Id)
        {
            const string Query_Moneysql = @"select ID,
                                                     ChrityMoney,
                                                     ChrityName,
                                                     ChrityPhone,
                                                     ChrityIdcard,
                                                     ChritySetTime,
                                                     ChrityRemark
                                            from dbo.Tmoney
                                            where ID = @Id
                                           ";
            return base.QueryFirst<Tmoney>(Query_Moneysql, new { Id = Id });
        }

        #endregion

        #region  --对数据库进行 Money 更新的操作--
        public bool Update_MoneyMSG(Tmoney model)
        {
            const string Update_MoneyMSGsql = @"
				UPDATE dbo.Tmoney
				SET	  ChrityMoney =@ChrityMoney, 
                      ChrityName =@ChrityName,
                      ChrityPhone =@ChrityPhone,
                      ChrityIdcard =@ChrityIdcard,
                      ChritySetTime =@ChritySetTime,
                      ChrityRemark =@ChrityRemark
				WHERE ID=@ID";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                var result = conn.Execute(Update_MoneyMSGsql, model) > 0;
                return result;
            }
        }

        #endregion

        #region  --对数据库进行 Money 删除的操作--
        public bool Money_Delected(int Id)
        {
            const string Money_Delectedsql = @"
				DELETE FROM dbo.Tmoney 
				WHERE ID=@ID
                        ";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("ID", Id);
                var result = conn.Execute(Money_Delectedsql, dp) > 0;
                return result;
            }
        }
        #endregion
    }
}
