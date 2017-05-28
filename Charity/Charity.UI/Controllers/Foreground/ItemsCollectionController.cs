using Charity.Bll.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    /// <summary>
    /// 前台商品募捐--前台控制器
    /// </summary>
    public class ItemsCollectionController : Controller
    {
        BendShopBll _bendshopBll = new BendShopBll();
        /// <summary>
        /// 前台商品募捐
        /// </summary>
        /// <returns></returns>

        #region --返回页面
        // GET: ItemsCollection
        public ActionResult ItemsCollectionIndex()
        {
            return View();
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
            if (hfc.Count > 0)
            {
                imgPath = "/DataImg/shop/" + hfc[0].FileName;
                string PhysicalPath = Server.MapPath(imgPath);
                hfc[0].SaveAs(PhysicalPath);
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

            return RedirectToAction("MarketIndex", "Market");
        }
        #endregion
    }
}