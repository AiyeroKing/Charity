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
    /// 资金捐助-前台控制器
    /// </summary>
    public class CapitalController : Controller
    {
        BendMoneyBll _bendmoneyBll = new BendMoneyBll();
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

        #region --添加功能
        [HttpPost]
        public ActionResult AddMoneyMSG(Tmoney model)
        {
            var result = false;
            result = _bendmoneyBll.AddMoneyMSG(model);
            return RedirectToAction("FundsReleasedtwoIndex", "FundsReleased");
        }
        #endregion
    }
}