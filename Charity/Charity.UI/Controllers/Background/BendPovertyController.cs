using Charity.Bll.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendPovertyController : Controller
    {
        BendPovertyBll _bendpovertyBll = new BendPovertyBll();

        #region --返回页面
        /// <summary>
        /// 贫困管理首页
        /// </summary>
        /// <returns></returns>
        // GET: BendPoverty
        public ActionResult BendPovertyIndex()
        {
            var queryResult = _bendpovertyBll.Scan_Poverty();
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 贫困详情
        /// </summary>
        /// <returns></returns>
        public ActionResult BendPovertyArtialIndex(int Id = 0)
        {
             var queryResult = _bendpovertyBll.Query_Poverty(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }

        /// <summary>
        /// 贫困编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult BendPovertyEditorIndex(int Id = 0)
        {
            var queryResult = _bendpovertyBll.Query_Poverty(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        /// <summary>
        /// 贫困添加
        /// </summary>
        /// <returns></returns>
        public ActionResult BendPovertyAddIndex()
        {
            return View();
        }
        #endregion

        #region --添加功能
        [HttpPost]
        public ActionResult AddPovertyMSG(Tpoverty model)
        {
            var result = false;
            result = _bendpovertyBll.AddPovertyMSG(model);
            return RedirectToAction("BendPovertyIndex", "BendPoverty");
        }
        #endregion

        #region --编辑功能
        public ActionResult Update_PovertyMSG(Tpoverty model)
        {
            var result = false;
            result = _bendpovertyBll.Update_PovertyMSG(model);
            return RedirectToAction("BendPovertyIndex", "BendPoverty");
        }
        #endregion

        #region --删除功能
        public ActionResult Poverty_Delected(int Id = 0)
        {
            var delectResult = _bendpovertyBll.Poverty_Delected(Id);
            return RedirectToAction("BendPovertyIndex", "BendPoverty");
        }
        #endregion

    }
}