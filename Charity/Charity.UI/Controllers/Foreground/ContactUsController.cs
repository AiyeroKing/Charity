using Charity.Bll.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    /// <summary>
    /// 联系我们--前台控制器
    /// </summary>
    public class ContactUsController : Controller
    {  
        // GET: Capital

        #region -- 返回页面
        /// <summary>
        /// 联系我们
        /// </summary>
        public ActionResult ContactUsIndex()
        {
            return View();
        }
        /// <summary>
        /// 留言板
        /// </summary>
        /// <returns></returns>
        public ActionResult ContactBoardIndex()
        {
            return View();
        }
        #endregion

        #region --添加功能
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddGuestbookMSG(TGuestbook model)
        {
            BendGuestbookBll _bendguestbookBll = new BendGuestbookBll();
            var result = false;
            result = _bendguestbookBll.AddGuestbookMSG(model);
            return RedirectToAction("HomeIndex", "Home");
        }
        #endregion
    }
}