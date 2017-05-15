using Charity.Dal.Common;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Dal.Bend
{
    public class BendGuestbookDal:BaseDal
    {
        public IList<TGuestbook> Query_scanbendguestbook()
        {
            const string Query_scanbendguestbooksql = @"select ID,
                                            BoredTital,
                                            BoredName,
                                            BoredBody,
                                            BoredSetTime,
                                            BoredTelphone,
                                            BoredEmail,
                                            BoredIndex 
                                            from dbo.TGuestbook
                                           ";
            //using (DbConnection conn = DbFactory.CreateConnection())
            //{
            //    return conn.Query<Tinfo>(Query_MesgBendInfo).ToList();
            //}
            return base.Query<TGuestbook>(Query_scanbendguestbooksql).ToList();
        }
    }
}
