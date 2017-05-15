using Charity.Dal.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Bll.Bend
{
    public  class BendPovertyBll
    {
        BendPovertyDal povertyDal = new BendPovertyDal();

        #region  --对数据库进行 BendPoverty 遍历的操作--
        public IList<Tpoverty> Scan_Poverty()
        {
            return povertyDal.Scan_Poverty();
        }

        #endregion

        #region  --对数据库进行 BendPoverty 增加的操作--
        public bool AddPovertyMSG(Tpoverty model)
        {
            var NowTime = DateTime.Now;
            model.ApplySetTime = NowTime;
            return povertyDal.AddPovertyMSG(model);
        }

        #endregion

        #region  --对数据库进行 BendPoverty 单个查找的操作--
        public Tpoverty Query_Poverty(int Id)
        {
            return povertyDal.Query_Poverty(Id);
        }

        #endregion

        #region  --对数据库进行 BendPoverty 更新的操作--
        public bool Update_PovertyMSG(Tpoverty model)
        {
            return povertyDal.Update_PovertyMSG(model);
        }

        #endregion

        #region  --对数据库进行 BendPoverty 删除的操作--
        public bool Poverty_Delected(int Id)
        {
            return povertyDal.Poverty_Delected(Id);
        }

        #endregion
    }
}
