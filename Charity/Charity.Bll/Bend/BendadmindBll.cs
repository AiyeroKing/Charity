using Charity.Dal.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;

namespace Charity.Bll.Bend
{
    public class BendadmindBll
    {
        /// <summary>
        /// bll 业务逻辑层
        /// </summary>
        BendadmindDal _bendadmindDal = new BendadmindDal();

        #region  --以列表查询显示 Bendadmin
        public IList<Tadmin> Scan_Bendadmind()
        {
            return _bendadmindDal.Scan_Bendadmind();
        }
        #endregion

        #region  --对数据库进行 Bendadmin 增加的操作--
        public bool AddBendadmindMSG(Tadmin model)
        {
            var NowTime = DateTime.Now;
            model.AdSetTime = NowTime;
            return _bendadmindDal.AddBendadmindMSG(model);
        }

        #endregion

        #region  --对数据库进行 Bendadmin 单个查找的操作--
        public Tadmin Query_Bendadmind(int Id)
        {
            return _bendadmindDal.Query_Bendadmind(Id);
        }

        #endregion

        #region  --对数据库进行 Bendadmin 更新的操作--
        public bool UpdateBendadmindMSG(Tadmin model)
        {
            return _bendadmindDal.UpdateBendadmindMSG(model);
        }

        #endregion

        #region  --对数据库进行 Bendadmin 删除的操作--
        public bool DelectResult(int Id)
        {
            return _bendadmindDal.DelectResult(Id);
        }

        #endregion
    }
}
