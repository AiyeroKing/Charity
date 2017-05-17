using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    public class CapitalController : Controller
    {
        #region -- 返回页面

        /// <summary>
        /// 资金捐助
        /// </summary>
        // GET: Capital

        public ActionResult CapitalIndex()
        {
            return View();
        }
        #endregion
    }
}