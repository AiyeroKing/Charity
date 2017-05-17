using Charity.Bll.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendMoneyController : Controller
    {

        BendMoneyBll _bendmoneyBll = new BendMoneyBll();

        #region --返回页面
        /// <summary>
        /// 资金管理首页
        /// </summary>
        /// <returns></returns>
        // GET: BendMoney
        public ActionResult BendMoneyIndex()
        {
            var queryResult = _bendmoneyBll.Scan_Money();
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 资金管理明细
        /// </summary>
        /// <returns></returns>
        public ActionResult BendMoneyArtialIndex(int Id = 0)
        {
            var queryResult = _bendmoneyBll.Query_Money(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        /// <summary>
        /// 资金管理编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult BendMoneyEidtorIndex(int Id = 0)
        {
            var queryResult = _bendmoneyBll.Query_Money(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        /// <summary>
        /// 资金管理增加
        /// </summary>
        /// <returns></returns>
        public ActionResult BendMoneyAddIndex()
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
            return RedirectToAction("BendMoneyIndex", "BendMoney");
        }
        #endregion

        #region --编辑功能
        public ActionResult Update_MoneyMSG(Tmoney model)
        {
            var result = false;
            result = _bendmoneyBll.Update_MoneyMSG(model);
            return RedirectToAction("BendMoneyIndex", "BendMoney");
        }
        #endregion

        #region --删除功能
        public ActionResult Money_Delected(int Id = 0)
        {
            var delectResult = _bendmoneyBll.Money_Delected(Id);
            return RedirectToAction("BendMoneyIndex", "BendMoney");
        }
        #endregion
    }
}