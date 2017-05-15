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
        public IList<TGuestbook> Query_scanbendguestbook()
        {
            return _bendguestbookDal.Query_scanbendguestbook();
        }

    }
}
