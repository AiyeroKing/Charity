using Charity.Dal.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Bll.Bend
{
    public class BendGuestbookBll
    {
        BendGuestbookDal _bendguestbookDal = new BendGuestbookDal();

        #region  --对数据库进行Guestbook遍历的操作--
        public IList<TGuestbook> Scan_Guestbook()
        {
            return _bendguestbookDal.Scan_Guestbook();
        }
        #endregion

        #region  --对数据库进行Guestbook增加的操作--
        public bool AddGuestbookMSG(TGuestbook model)
        {
            var NowTime = DateTime.Now;
            model.BoredSetTime = NowTime;
            return _bendguestbookDal.AddGuestbookMSG(model);
        }

        #endregion

        #region  --对数据库进行Guestbook单个查找的操作--
        public TGuestbook Query_Guestbook(int Id)
        {
            return _bendguestbookDal.Query_Guestbook(Id);
        }

        #endregion

        #region  --对数据库进行Guestbook更新的操作--
        public bool UpdateGuestbookMSG(TGuestbook model)
        {
            return _bendguestbookDal.UpdateGuestbookMSG(model);
        }

        #endregion

        #region  --对数据库进行Guestbook删除的操作--
        public bool DelectResult(int Id)
        {
            return _bendguestbookDal.DelectResult(Id);
        }

        #endregion
    }
}
