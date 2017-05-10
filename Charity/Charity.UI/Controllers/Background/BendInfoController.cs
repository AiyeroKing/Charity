using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendInfoController : Controller
    {
        /// <summary>
        /// 资讯主页面
        /// </summary>
        /// <returns></returns>
        // GET: BendInfo
        public ActionResult BendInfoIndex()
        {
            return View();
        }
        /// <summary>
        /// 资讯明细
        /// </summary>
        /// <returns></returns>
        public ActionResult BendInfoAritialIndex()
        {
            return View();
        }
        /// <summary>
        /// 资讯编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult BendInfoEditorIndex()
        {
            return View();
        }
        /// <summary>
        /// 资讯添加
        /// </summary>
        /// <returns></returns>
        public ActionResult BendInfoAddIndex()
        {
            return View();
        }
    }
}