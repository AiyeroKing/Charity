using Charity.Bll.Bend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    /// <summary>
    /// 贫困申请首页
    /// </summary>
    public class SubsidizationController : Controller
    {
        BendPovertyBll _bendpovertyBll = new BendPovertyBll();
        #region --返回页面
        /// <summary>
        /// 贫困首页
        /// </summary>
        // GET: Subsidization
        public ActionResult SubsidizationIndex()
        {
            var queryResult = _bendpovertyBll.Scan_Poverty();
            ViewBag.List = queryResult;
            return View();
        }

        /// <summary>
        /// 贫困详情
        /// </summary>
        // GET: Subsidization
        public ActionResult AritialSubsidizationIndex(int Id = 0)
        {
            var queryResult = _bendpovertyBll.Query_Poverty(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        #endregion
    }
}