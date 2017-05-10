using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendPovertyController : Controller
    {
        /// <summary>
        /// 贫困管理首页
        /// </summary>
        /// <returns></returns>
        // GET: BendPoverty
        public ActionResult BendPovertyIndex()
        {
            return View();
        }
        /// <summary>
        /// 贫困详情
        /// </summary>
        /// <returns></returns>
        public ActionResult BendPovertyArtialIndex()
        {
            return View();
        }

        /// <summary>
        /// 贫困编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult BendPovertyEditorIndex()
        {
            return View();
        }
        /// <summary>
        /// 贫困添加
        /// </summary>
        /// <returns></returns>
        public ActionResult BendPovertyAddIndex()
        {
            return View();
        }
      
    }
}