using Charity.Dal.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Bll.Bend
{
    public class BendAccountBll
    {
        BendAccountDal bendaccountDal = new BendAccountDal();

        #region  --对数据库进行 BendAccount 遍历的操作--
        public IList<Tuseraccount> Scan_Account()
        {
            return bendaccountDal.Scan_Account();
        }

        #endregion

        #region  --对数据库进行 BendAccount 增加的操作--
        public bool AddAccountMSG(Tuseraccount model)
        {
            var NowTime = DateTime.Now;
            model.UsSettime = NowTime;
            return bendaccountDal.AddAccountMSG(model);
        }

        #endregion

        #region  --对数据库进行 BendAccount 单个查找的操作--
        public Tuseraccount Query_Account(int Id)
        {
            return bendaccountDal.Query_Account(Id);
        }

        #endregion

        #region  --对数据库进行 BendAccount 更新的操作--
        public bool Update_AccountMSG(Tuseraccount model)
        {
            return bendaccountDal.Update_AccountMSG(model);
        }

        #endregion

        #region  --对数据库进行 BendAccount 删除的操作--
        public bool Account_Delected(int Id)
        {
            return bendaccountDal.Account_Delected(Id);
        }

        #endregion
    }
}
