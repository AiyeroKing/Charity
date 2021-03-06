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
    /// 物品管理 -- 后台控制器
    /// </summary>
    public class BendShopController : Controller
    {
        BendShopBll _bendshopBll = new BendShopBll();

        TAllmoneylBll TAllmoneylBll = new TAllmoneylBll();

        #region --返回页面
        /// <summary>
        /// 商品主页面
        /// </summary>
        /// <returns></returns>
        // GET: BendShop
        public ActionResult BendShopIndex()
        {
            var queryResult = _bendshopBll.Scan_Shop();
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 商品详细
        /// </summary>
        /// <returns></returns>
        public ActionResult BendShopArtialIndex(int Id = 0)
        {
            var queryResult = _bendshopBll.Query_Shop(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        /// <summary>
        /// 商品编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult BendShopEidtorIndex(int Id = 0)
        {
            var queryResult = _bendshopBll.Query_Shop(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        /// <summary>
        /// 商品添加
        /// </summary>
        public ActionResult BendShopAddIndex()
        {
            return View();
        }
        #endregion

        #region --编辑功能
        public ActionResult Update_ShopMSG(Tshop model)
        {
            var result = false;
            int Id = model.ID;
            var result1 = TAllmoneylBll.delet_buyshop(Id);//先减去原来的价值
            result = _bendshopBll.Update_ShopMSG(model);
            var result2 = TAllmoneylBll.Add_shopvule(model);//添加更新后的价值
            var result3 = TAllmoneylBll.all_buyshop();
            return RedirectToAction("BendShopIndex", "BendShop");
        }
        #endregion

        #region --删除功能
        public ActionResult Shop_Delected(int Id = 0)
        {
            var result1 = TAllmoneylBll.delet_buyshop(Id);//先减去原来的价值
            var delectResult = _bendshopBll.Shop_Delected(Id);
            var result2 = TAllmoneylBll.all_buyshop();
            return RedirectToAction("BendShopIndex", "BendShop");
        }
        #endregion

        #region --添加功能
        [HttpPost]
        public ActionResult AddShopMSG()
        {

            Tshop tshopMolde = new Tshop();
            NameValueCollection nvc = System.Web.HttpContext.Current.Request.Form;
            HttpFileCollection hfc = System.Web.HttpContext.Current.Request.Files;
            string imgPath = "";
            if (hfc[0].FileName == "")
            {
                return Redirect("/BendShop/BendShopAddIndex");
            }
            else
            {
                if (hfc.Count > 0)
                {
                    imgPath = "/DataImg/shop/" + hfc[0].FileName;
                    string PhysicalPath = Server.MapPath(imgPath);
                    hfc[0].SaveAs(PhysicalPath);
                }
            }
            tshopMolde.Scrimg = imgPath;
            tshopMolde.ShopArea = nvc.Get("ShopArea");
            tshopMolde.ShopCharityIdcard = nvc.Get("ShopCharityIdcard");
            tshopMolde.ShopCharityName = nvc.Get("ShopCharityName");
            tshopMolde.ShopCharityPhone = nvc.Get("ShopCharityPhone");
            tshopMolde.ShopCharityWay = nvc.Get("ShopCharityWay");
            tshopMolde.ShopName = nvc.Get("ShopName");
            tshopMolde.ShopRemark = nvc.Get("ShopRemark");
            tshopMolde.ShopSale = nvc.Get("ShopSale");
            tshopMolde.ShopValue = nvc.Get("ShopValue");

            var result = false;
            result = _bendshopBll.AddShopMSG(tshopMolde);

            var result1 = TAllmoneylBll.Add_shopvule(tshopMolde);
            var result2 = TAllmoneylBll.all_buyshop();


            return Redirect("/BendShop/BendShopIndex");
        }
        #endregion
    }
}