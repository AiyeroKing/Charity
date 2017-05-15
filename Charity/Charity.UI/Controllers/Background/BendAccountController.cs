using Charity.Bll.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    
    public class BendAccountController : Controller
    {
        BendAccountBll _bendaccountBll = new BendAccountBll();

        #region --返回页面
        /// <summary>
        /// 普通用户管理页面
        /// </summary>
        /// <returns></returns>
        // GET: BendAccount
        public ActionResult BendAccountIndex()
        {
            var queryResult = _bendaccountBll.Scan_Account();
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 普通用户管理页面详情
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAccountArtialIndex(int Id = 0)
        {
            var queryResult = _bendaccountBll.Query_Account(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        /// <summary>
        /// 普通用户管理页面编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAccountEditorIndex(int Id = 0)
        {
            var queryResult = _bendaccountBll.Query_Account(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        /// <summary>
        /// 普通用户管理页面增加
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAccountAddIndex()
        {
            return View();
        }
        #endregion

        #region --添加功能
        [HttpPost]
        public ActionResult AddAccountMSG(Tuseraccount model)
        {
            var result = false;
            result = _bendaccountBll.AddAccountMSG(model);
            return RedirectToAction("BendAccountIndex", "BendAccount");
        }
        #endregion

        #region --编辑功能
        public ActionResult Update_AccountMSG(Tuseraccount model)
        {
            var result = false;
            result = _bendaccountBll.Update_AccountMSG(model);
            return RedirectToAction("BendAccountIndex", "BendAccount");
        }
        #endregion

        #region --删除功能
        public ActionResult Account_Delected(int Id = 0)
        {
            var delectResult = _bendaccountBll.Account_Delected(Id);
            return RedirectToAction("BendAccountIndex", "BendAccount");
        }
        #endregion
    }
}