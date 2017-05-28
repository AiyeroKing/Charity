using Charity.Bll.Bend;
using Charity.Bll.TAllmoneyl;
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

        TAllmoneylBll TAllmoneylBll = new TAllmoneylBll();
        /// <summary>
        /// 前台商品募捐
        /// </summary>
        /// <returns></returns>

        #region --返回页面
        // GET: ItemsCollection
        public ActionResult ItemsCollectionIndex(int sd = 0)
        {
            if (sd == 0)
            {
                return RedirectToAction("LoginIndex", "LoginSignUp");
            }
            else
            {
                BendAccountBll _bendaccountBll = new BendAccountBll();
                var queryResult = _bendaccountBll.Query_Account(sd);
                ViewData.Model = queryResult;
                return View(ViewData.Model);
            }





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
                return View("ItemsCollectionIndex");
            }
            else
            {
                //if (hfc.Count > 0)
                //{
                    imgPath = "/DataImg/shop/" + hfc[0].FileName;
                    string PhysicalPath = Server.MapPath(imgPath);
                    hfc[0].SaveAs(PhysicalPath);
                //}

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

                if (tshopMolde.ShopName == "")
                {
                    return RedirectToAction("ItemsCollectionIndex", "ItemsCollection");
                }
                else
                {
                    var result = false;
                    result = _bendshopBll.AddShopMSG(tshopMolde);


                    var result1 = TAllmoneylBll.Add_shopvule(tshopMolde);///商品进行添加时对总物品价值进行添加
                    var result2 = TAllmoneylBll.all_buyshop();///商品进行添加时对总价值资金发生改变


                    return RedirectToAction("MarketIndex", "Market");
                }

            }
        }
        #endregion
    }
}