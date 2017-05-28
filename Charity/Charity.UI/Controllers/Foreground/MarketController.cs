using Charity.Bll.Bend;
using Charity.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    /// <summary>
    /// 商品义卖界面--前台控制器
    /// </summary>
    public class MarketController : Controller
    {
        BendShopBll _bendshopBll = new BendShopBll();

        #region --返回页面
        /// <summary>
        /// 商品主页面--显示全部商品
        /// </summary>
        /// <returns></returns>
        // GET: BendShop
        public ActionResult MarketIndex()
        {
            var queryResult = _bendshopBll.Scan_Shop();
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 商品主页面--显示衣物商品
        /// </summary>
        /// <returns></returns>
        public ActionResult YiwuMarketIndex()
        {
            String ShopSale = "衣";
            var queryResult = _bendshopBll.Scan_onesShop(ShopSale);
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 商品主页面--显示书籍商品
        /// </summary>
        /// <returns></returns>
        public ActionResult BookMarketIndex()
        {
            String ShopSale = "书";
            var queryResult = _bendshopBll.Scan_onesShop(ShopSale);
            ViewBag.List = queryResult;
            return View();
     
        }
        /// <summary>
        /// 商品主页面--显示电子商品
        /// </summary>
        /// <returns></returns>
        public ActionResult DianziMarketIndex()
        {

            String ShopSale = "电";
            var queryResult = _bendshopBll.Scan_onesShop(ShopSale);
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 商品主页面--显示家具商品
        /// </summary>
        /// <returns></returns>
        public ActionResult JiajuMarketIndex()
        {
            String ShopSale = "家";
            var queryResult = _bendshopBll.Scan_onesShop(ShopSale);
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 商品主页面--显示收藏商品
        /// </summary>
        /// <returns></returns>
        public ActionResult ShoucangMarketIndex()
        {
            String ShopSale = "藏";
            var queryResult = _bendshopBll.Scan_onesShop(ShopSale);
            ViewBag.List = queryResult;
            return View();
        }
        /// <summary>
        /// 商品主页面--显示其他商品
        /// </summary>
        /// <returns></returns>
        public ActionResult OtherMarketIndex()
        {
            String ShopSale = "其";
            var queryResult = _bendshopBll.Scan_onesShop(ShopSale);
            ViewBag.List = queryResult;
            return View();
        }
        #endregion

        #region --功能方法
        /// <summary>
        /// 商品详情页面--显示选择商品信息
        /// </summary>
        /// <returns></returns>
        public ActionResult SeeMarketShopMSG(int Id = 0)
        {
            var queryResult = _bendshopBll.Query_Shop(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }

        /// <summary>
        /// 付钱购买页面
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ActionResult BuyMarketShop(int Id = 0, int sd = 0)
        {
            if (sd == 0)
            {
                return RedirectToAction("LoginIndex", "LoginSignUp");
            }
            else
            {
                VBuyShop vbuyshopModel = new VBuyShop();

                BendAccountBll _bendaccountBll = new BendAccountBll();
                var accout = _bendaccountBll.Query_Account(sd);
                var shop = _bendshopBll.Query_Shop(Id);

                vbuyshopModel.shopID = shop.ID;
                vbuyshopModel.UsName = accout.UsName;
                vbuyshopModel.UsNiname = accout.UsNiname;
                vbuyshopModel.ShopName = shop.ShopName;
                vbuyshopModel.ShopValue = shop.ShopValue;

                ViewData.Model = vbuyshopModel;
                return View(ViewData.Model);
            }

        }
        #endregion

        #region --删除功能
        /// <summary>
        /// 购买删除物品
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult delectMarketMSG(VBuyShop model)
        {
            int Id = model.shopID;
            var delectResult = _bendshopBll.Shop_Delected(Id);
            return RedirectToAction("MarketIndex", "Market");
        }
        #endregion
    }
}