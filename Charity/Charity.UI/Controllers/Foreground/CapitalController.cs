using Charity.Bll.Bend;
using Charity.Bll.TAllmoneyl;
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
        TAllmoneylBll TAllmoneylBll = new TAllmoneylBll();
        #region -- 返回页面

        /// <summary>
        /// 资金捐助
        /// </summary>
        // GET: Capital

        public ActionResult CapitalIndex(int sd = 0)
        {
            if (sd == 0)
            {
                return RedirectToAction("LoginIndex", "LoginSignUp");
            }
            else
            {
                BendAccountBll _bendaccountBll = new BendAccountBll();
                var queryResult = _bendaccountBll.Query_Account(sd);
                ViewData.Model = queryResult;
                return View(ViewData.Model);
            }
        }
        #endregion

        
        #region --添加功能
        [HttpPost]
        public ActionResult AddMoneyMSG(Tmoney model)
        {
            var result = false;
            result = _bendmoneyBll.AddMoneyMSG(model);

            var result1 = TAllmoneylBll.AddMoneyMSG(model);
            var result2 = TAllmoneylBll.all_buyshop();


            return RedirectToAction("FundsReleasedtwoIndex", "FundsReleased");
        }
        #endregion
    }
}