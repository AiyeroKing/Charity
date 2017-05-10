using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendMoneyController : Controller
    {
        /// <summary>
        /// 资金管理首页
        /// </summary>
        /// <returns></returns>
        // GET: BendMoney

        public ActionResult BendMoneyIndex()
        {
            return View();
        }
        /// <summary>
        /// 资金管理明细
        /// </summary>
        /// <returns></returns>
        public ActionResult BendMoneyArtialIndex()
        {
            return View();
        }
        /// <summary>
        /// 资金管理编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult BendMoneyEidtorIndex()
        {
            return View();
        }
        /// <summary>
        /// 资金管理增加
        /// </summary>
        /// <returns></returns>
        public ActionResult BendMoneyAddIndex()
        {
            return View();
        }
    }
}