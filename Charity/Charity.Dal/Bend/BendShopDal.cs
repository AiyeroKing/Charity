using Charity.Dal.Common;
using Charity.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Charity.Dal.Bend
{
    public class BendShopDal : BaseDal
    {
        #region --以列表查询显示
        public IList<Tshop> Scan_Shop()
        {
            const string Scan_Shopsql = @"select ID,
                                                 ShopName,
                                                 ShopValue,
                                                 ShopSale,
                                                 ShopArea,
                                                 ShopCharityName,
                                                 ShopCharityPhone,
                                                 ShopCharityWay,
                                                 ShopCharityIdcard,
                                                 ShopSetTime,
                                                 ShopRemark
                                            from dbo.Tshop
                                           ";
            //using (DbConnection conn = DbFactory.CreateConnection())
            //{
            //    return conn.Query<Tinfo>(Query_MesgBendInfo).ToList();
            //}
            return base.Query<Tshop>(Scan_Shopsql).ToList();
        }
        #endregion

        #region  --对数据库进行 Shop 增加的操作--
        public bool AddShopMSG(Tshop model)
        {
            var result = false;
            const string AddShopMSGsql = @"
                               INSERT INTO dbo.Tshop
                                        (   ShopName,
                                            ShopValue,
                                            ShopSale,
                                            ShopArea,
                                            ShopCharityName,
                                            ShopCharityPhone,
                                            ShopCharityWay,
                                            ShopCharityIdcard,
                                            ShopSetTime,
                                            ShopRemark
                                         ) 
                                VALUES  ( 
                                                 @ShopName,
                                                 @ShopValue,
                                                 @ShopSale,
                                                 @ShopArea,
                                                 @ShopCharityName,
                                                 @ShopCharityPhone,
                                                 @ShopCharityWay,
                                                 @ShopCharityIdcard,
                                                 @ShopSetTime,
                                                 @ShopRemark
                                         )";

            try
            {
                using (DbConnection conn = DbFactory.CreateConnection())
                {
                    result = conn.Execute(AddShopMSGsql, model) > 0;
                    return result;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region  --对数据库进行 Shop 单个查找的操作--
        public Tshop Query_Shop(int Id)
        {
            const string Query_Shopsql = @"select   ID,
                                                    ShopName,
                                                    ShopValue,
                                                    ShopSale,
                                                    ShopArea,
                                                    ShopCharityName,
                                                    ShopCharityPhone,
                                                    ShopCharityWay,
                                                    ShopCharityIdcard,
                                                    ShopSetTime,
                                                    ShopRemark
                                            from dbo.Tshop
                                            where ID = @Id
                                           ";
            return base.QueryFirst<Tshop>(Query_Shopsql, new { Id = Id });
        }

        #endregion

        #region  --对数据库进行 Shop 更新的操作--
        public bool Update_ShopMSG(Tshop model)
        {
            const string Update_ShopMSGsql = @"
				UPDATE dbo.Tshop
            	SET	ShopName =@ShopName,
                    ShopValue =@ShopValue,
                    ShopSale =@ShopSale,
                    ShopArea =@ShopArea,
                    ShopCharityName =@ShopCharityName,
                    ShopCharityPhone =@ShopCharityPhone,
                    ShopCharityWay =@ShopCharityWay,
                    ShopCharityIdcard =@ShopCharityIdcard,
                    ShopSetTime =@ShopSetTime,
                    ShopRemark =@ShopRemark
				WHERE ID=@ID";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                var result = conn.Execute(Update_ShopMSGsql, model) > 0;
                return result;
            }
        }

        #endregion

        #region  --对数据库进行 Shop 删除的操作--
        public bool Shop_Delected(int Id)
        {
            const string Shop_Delectedsql = @"
				DELETE FROM dbo.Tshop 
				WHERE ID=@ID
                        ";
            using (DbConnection conn = DbFactory.CreateConnection())
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("ID", Id);
                var result = conn.Execute(Shop_Delectedsql, dp) > 0;
                return result;
            }
        }
        #endregion
    }
}
