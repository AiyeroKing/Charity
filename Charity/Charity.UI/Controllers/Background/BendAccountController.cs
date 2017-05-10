using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    
    public class BendAccountController : Controller
    {
        /// <summary>
        /// 普通用户管理页面
        /// </summary>
        /// <returns></returns>
        // GET: BendAccount
        public ActionResult BendAccountIndex()
        {
            return View();
        }
        /// <summary>
        /// 普通用户管理页面详情
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAccountArtialIndex()
        {
            return View();
        }
        /// <summary>
        /// 普通用户管理页面编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAccountEditorIndex()
        {
            return View();
        }
        /// <summary>
        /// 普通用户管理页面增加
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAccountAddIndex()
        {
            return View();
        }
    }
}