using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    public class LoveactivityController : Controller
    {
        /// <summary>
        /// 爱心活动首页--之爱心教育
        /// </summary>
        /// <returns></returns>
        // GET: Loveactivity
        public ActionResult LoveactivityIndex()
        {
            return View();
        }
        /// <summary>
        /// 爱心活动之爱心帮扶
        /// </summary>
        /// <returns></returns>
        public ActionResult LovehelpIndex()
        {
            return View();
        }
        /// <summary>
        /// 爱心活动之特殊帮助
        /// </summary>
        /// <returns></returns>
        public ActionResult LovemeatIndex()
        {
            return View();
        }
    }
}