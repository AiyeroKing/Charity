using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    /// <summary>
    /// 前台合作伙伴 --前台控制器
    /// </summary>
    public class loveBIZController : Controller
    {
        /// <summary>
        /// 前台合作伙伴
        /// </summary>
        /// <returns></returns>
        // GET: loveBIZ
        public ActionResult loveBIZIndex()
        {
            return View();
        }
    }
}