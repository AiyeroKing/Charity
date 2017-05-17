using Charity.Bll.Bend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    public class FundsReleasedController : Controller
    {
        #region --返回页面
        /// <summary>
        /// 需求善款
        /// </summary>
        /// <returns></returns>
        // GET: FundsReleased
        public ActionResult FundsReleasedIndex()
        {
            BendPovertyBll _bendpovertyBll = new BendPovertyBll();
            var queryResult = _bendpovertyBll.Scan_Poverty();
            ViewBag.List = queryResult;
            return View();
        }

        /// <summary>
        /// 筹集善款
        /// </summary>
        /// <returns></returns>
        public ActionResult FundsReleasedtwoIndex()
        {
            BendMoneyBll _bendmoneyBll = new BendMoneyBll();
            var queryResult = _bendmoneyBll.Scan_Money();
            ViewBag.List = queryResult;
            return View();
        }
        #endregion

        #region --查询详细
        /// <summary>
        /// 需求善款详情
        /// </summary>
        /// <returns></returns>
        public ActionResult FundsReleaseAritaildIndex(int Id = 0)
        {
            return View();
        }
        #endregion
    }
}