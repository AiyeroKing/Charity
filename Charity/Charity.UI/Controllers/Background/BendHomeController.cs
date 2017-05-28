using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    /// <summary>
    /// 后台首页 -- 后台控制器
    /// </summary>
    public class BendHomeController : Controller
    {
        // GET: BendHome
        public ActionResult BendHomeIndex()
        {
            return View();
        }
    }
}