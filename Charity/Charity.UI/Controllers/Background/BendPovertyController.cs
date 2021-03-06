﻿using Charity.Bll.Bend;
using Charity.Bll.TAllmoneyl;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    /// <summary>
    /// 贫困管理 -- 后台控制器
    /// </summary>
    public class BendPovertyController : Controller
    {
        BendPovertyBll _bendpovertyBll = new BendPovertyBll();
        TAllmoneylBll TAllmoneylBll = new TAllmoneylBll();

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
        public ActionResult AddPovertyMSG()
        {

            Tpoverty  tpovertyMolde = new Tpoverty();
            NameValueCollection nvc = System.Web.HttpContext.Current.Request.Form;
            HttpFileCollection hfc = System.Web.HttpContext.Current.Request.Files;
            string imgPath = "";
            if (hfc.Count > 0)
            {
                imgPath = "/DataImg/proverty/" + hfc[0].FileName;
                string PhysicalPath = Server.MapPath(imgPath);
                hfc[0].SaveAs(PhysicalPath);
            }
            tpovertyMolde.ApplyArea = nvc.Get("ApplyArea");
            tpovertyMolde.ApplyInfo = nvc.Get("ApplyInfo");
            tpovertyMolde.ApplyName = nvc.Get("ApplyName");
            tpovertyMolde.ApplyPhone = nvc.Get("ApplyPhone");
            tpovertyMolde.ApplyValue = nvc.Get("ApplyValue");
            //tpovertyMolde.ApplyValue = int.Parse(abc); 
            tpovertyMolde.Srcimg = imgPath;


            //TAllmoney  tallmoney = new TAllmoney();

            //tallmoney.AllMoney=Convert.ToInt32(tpovertyMolde.ApplyValue);
            //tallmoney.ID = 5;

            //var booluer = false;
            //booluer = _bendpovertyBll.UpdateFivemaneyMSG(tallmoney);

            var result = false;
             result = _bendpovertyBll.AddPovertyMSG(tpovertyMolde);

            var result1 = TAllmoneylBll.AddProvertyMoneyMSG(tpovertyMolde);
            var result0 = TAllmoneylBll.all_buyshop();

            return Redirect("/BendPoverty/BendPovertyIndex");
        }
        #endregion

        #region --图片上传
        public ActionResult Upload()
        {
            NameValueCollection nvc = System.Web.HttpContext.Current.Request.Form;

            HttpFileCollection hfc = System.Web.HttpContext.Current.Request.Files;
            string imgPath = "";
            if (hfc.Count > 0)
            {
                imgPath = "//DataImg//proverty//" + hfc[0].FileName;
                string PhysicalPath = Server.MapPath(imgPath);
                hfc[0].SaveAs(PhysicalPath);
            }
            //注意要写好后面的第二第三个参数
            return Json(new {imgPath1 = imgPath }, "text/html", JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region --编辑功能
        public ActionResult Update_PovertyMSG(Tpoverty model)
        {
            var result = false;
            int Id = model.ID;
            var result1 = TAllmoneylBll.Delect_ProvertyMoneyMSG(Id);
            result = _bendpovertyBll.Update_PovertyMSG(model);
            var result2 = TAllmoneylBll.AddProvertyMoneyMSG(model);
                var result0 = TAllmoneylBll.all_buyshop();
            return RedirectToAction("BendPovertyIndex", "BendPoverty");
        }
        #endregion

        #region --删除功能
        public ActionResult Poverty_Delected(int Id = 0)
        {
            var result1 = TAllmoneylBll.Delect_ProvertyMoneyMSG(Id);
            var delectResult = _bendpovertyBll.Poverty_Delected(Id);
            var result0 = TAllmoneylBll.all_buyshop();
            return RedirectToAction("BendPovertyIndex", "BendPoverty");
        }
        #endregion

    }
}