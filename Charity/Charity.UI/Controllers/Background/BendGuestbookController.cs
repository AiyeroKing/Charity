using Charity.Bll.Bend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendGuestbookController : Controller
    {

        BendGuestbookBll _bendguestbookBll = new BendGuestbookBll();
        #region --留言板返回页面
        /// <summary>
        /// 留言板主页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BendGuestbookIndex()
        {
            var queryResult = _bendguestbookBll.Query_scanbendguestbook();
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 留言板明细页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BendGuestbookarticleIndex()
        {
            return View();
        }
        /// <summary>
        /// 留言板编辑页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BendEditerGuestbookIndex()
        {
            return View();
        }

        /// <summary>
        /// 留言板增加页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAddGuestbookIndex()
        {
            return View();
        }
        #endregion


    }
}