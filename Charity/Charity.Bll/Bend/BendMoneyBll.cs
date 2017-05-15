using Charity.Dal.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Bll.Bend
{
    public class BendMoneyBll
    {
        BendMoneyDal bendmoneyDal = new BendMoneyDal();

        #region  --对数据库进行 BendMoney 遍历的操作--
        public IList<Tmoney> Scan_Money()
        {
            return bendmoneyDal.Scan_Money();
        }

        #endregion

        #region  --对数据库进行 BendMoney 增加的操作--
        public bool AddMoneyMSG(Tmoney model)
        {
            var NowTime = DateTime.Now;
            model.ChritySetTime = NowTime;
            return bendmoneyDal.AddMoneyMSG(model);
        }

        #endregion

        #region  --对数据库进行 BendMoney 单个查找的操作--
        public Tmoney Query_Money(int Id)
        {
            return bendmoneyDal.Query_Money(Id);
        }

        #endregion

        #region  --对数据库进行 BendMoney 更新的操作--
        public bool Update_MoneyMSG(Tmoney model)
        {
            return bendmoneyDal.Update_MoneyMSG(model);
        }

        #endregion

        #region  --对数据库进行 BendMoney 删除的操作--
        public bool Money_Delected(int Id)
        {
            return bendmoneyDal.Money_Delected(Id);
        }

        #endregion
    }
}
