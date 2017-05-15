using Charity.Dal.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Bll.Bend
{
    public class BendInfoBll
    {
        BendInfoDal bendinfoDal = new BendInfoDal();

        #region  --对数据库进行BendInfo遍历的操作--
        public IList<Tinfo> Query_scanbendinfo()
        {
            return bendinfoDal.QueryMesgBendInfo();
        }

        #endregion

        #region  --对数据库进行BendInfo增加的操作--
        public bool AddMesgBendInfo(Tinfo model)
        {
            var NowTime = DateTime.Now;
            model.InfoSetTime = NowTime;
            return bendinfoDal.AddMesgBendInfo(model);
        }

        #endregion
        
        #region  --对数据库进行BendInfo单个查找的操作--
        public Tinfo Query_bendinfoaritial(int Id)
        {
            return bendinfoDal.QueryOnesMesgBendInfo(Id);
        }

        #endregion

        #region  --对数据库进行BendInfo更新的操作--
        public bool UpdateMesgBendInfo(Tinfo model)
        {
            return bendinfoDal.UpdateMesgBendInfo(model);
        }

        #endregion
        
        #region  --对数据库进行BendInfo删除的操作--
        public bool delectResult(int Id)
        {
            return bendinfoDal.delectResult(Id);
        }

        #endregion
        
    }
}
