using Charity.Bll.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendInfoController : Controller
    {
        BendInfoBll _bendinfoBll = new BendInfoBll();

        #region --返回视图
        /// <summary>
        /// 资讯主页面
        /// </summary>
        /// <returns></returns>
        // GET: BendInfo
        public ActionResult BendInfoIndex()
        {
            var queryResult = _bendinfoBll.Query_scanbendinfo();
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 资讯明细
        /// </summary>
        /// <returns></returns>
        public ActionResult BendInfoAritialIndex(int Id = 0)
        {
            var queryResult = _bendinfoBll.Query_bendinfoaritial(Id);
            ViewData.Model = queryResult;
            //ViewBag.Model = queryResult;
            //ViewBag.List = queryResult;
            return View(ViewData.Model);

        }
        /// <summary>
        /// 资讯编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult BendInfoEditorIndex(int Id = 0)
        {
            var queryResult = _bendinfoBll.Query_bendinfoaritial(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        /// <summary>
        /// 资讯添加
        /// </summary>
        /// <returns></returns>
        public ActionResult BendInfoAddIndex()
        {
            return View();
        }
        #endregion

        #region --添加功能
        

        [HttpPost]
        public ActionResult AddBendInfoMSG(Tinfo model)
        {
            var result = false;
            result = _bendinfoBll.AddMesgBendInfo(model);
            return RedirectToAction("BendInfoIndex", "BendInfo");
        }
        #endregion

        #region --编辑功能
        public ActionResult EditorBendInfoMSG(Tinfo model)
        {
            var result = false;
            result = _bendinfoBll.UpdateMesgBendInfo(model);
            return RedirectToAction("BendInfoIndex", "BendInfo");
        }
        #endregion
        
        #region --删除功能
        public ActionResult BendInfoDelected(int Id = 0)
        {
            var delectResult = _bendinfoBll.delectResult(Id);
            return RedirectToAction("BendInfoIndex", "BendInfo");
        }
        #endregion

    }
}