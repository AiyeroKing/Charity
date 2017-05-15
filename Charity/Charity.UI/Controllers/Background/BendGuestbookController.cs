using Charity.Bll.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendGuestbookController : Controller
    {

        BendGuestbookBll _bendguestbookBll = new BendGuestbookBll();

        #region --返回页面
        /// <summary>
        /// 留言板主页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BendGuestbookIndex()
        {
            var queryResult = _bendguestbookBll.Scan_Guestbook();
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 留言板明细页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BendGuestbookarticleIndex(int Id)
        {
            var queryResult = _bendguestbookBll.Query_Guestbook(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        /// <summary>
        /// 留言板编辑页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BendEditerGuestbookIndex(int Id)
        {
            var queryResult = _bendguestbookBll.Query_Guestbook(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        /// <summary>
        /// 留言板增加页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAddGuestbookIndex()
        {
            return View();
        }
        #endregion

        #region --添加功能
        [HttpPost]
        public ActionResult AddGuestbookMSG(TGuestbook model)
        {
            var result = false;
            result = _bendguestbookBll.AddGuestbookMSG(model);
            return RedirectToAction("BendGuestbookIndex", "BendGuestbook");
        }
        #endregion

        #region --编辑功能
        public ActionResult EditorBendInfoMSG(TGuestbook model)
        {
            var result = false;
            result = _bendguestbookBll.UpdateGuestbookMSG(model);
            return RedirectToAction("BendGuestbookIndex", "BendGuestbook");
        }
        #endregion

        #region --删除功能
        public ActionResult BendInfoDelected(int Id = 0)
        {
            var delectResult = _bendguestbookBll.DelectResult(Id);
            return RedirectToAction("BendGuestbookIndex", "BendGuestbook");
        }
        #endregion


    }
}