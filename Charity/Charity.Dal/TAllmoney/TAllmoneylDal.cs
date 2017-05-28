using Charity.Dal.Common;
using Charity.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Dal.TAllmoneyl
{
  public  class TAllmoneylDal:BaseDal
    {
        /// <summary>
        /// 更新 --TAllmoney表 ID与AllMoney在BLL层定义
        /// </summary>
        /// <param name="shopmaney"></param>
        /// <returns></returns>
        public bool Add_buyshop(TAllmoney shopmaney)
        {
            const string Add_buyshopsql = @"
				UPDATE dbo.TAllmoney
				SET	  AllMoney =@AllMoney
				WHERE ID=@ID";

            using (DbConnection conn = DbFactory.CreateConnection())
            {
                var result = conn.Execute(Add_buyshopsql, shopmaney) > 0;
                return result;
            }
        }
    }
}
