using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendGuestbookController : Controller
    {
        /// <summary>
        /// 留言板主页面
        /// </summary>
        /// <returns></returns>
        // GET: BendGuestbook
        public ActionResult BendGuestbookIndex()
        {
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

    }
}