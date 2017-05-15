using Charity.Bll.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendShopController : Controller
    {
        BendShopBll _bendshopBll = new BendShopBll();

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

        #region --添加功能
        [HttpPost]
        public ActionResult AddShopMSG(Tshop model)
        {
            var result = false;
            result = _bendshopBll.AddShopMSG(model);
            return RedirectToAction("BendShopIndex", "BendShop");
        }
        #endregion

        #region --编辑功能
        public ActionResult Update_ShopMSG(Tshop model)
        {
            var result = false;
            result = _bendshopBll.Update_ShopMSG(model);
            return RedirectToAction("BendShopIndex", "BendShop");
        }
        #endregion

        #region --删除功能
        public ActionResult Shop_Delected(int Id = 0)
        {
            var delectResult = _bendshopBll.Shop_Delected(Id);
            return RedirectToAction("BendShopIndex", "BendShop");
        }
        #endregion

    }
}