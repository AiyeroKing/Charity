using Charity.Bll.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    public class ItemsCollectionController : Controller
    {
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
        public ActionResult AddShopMSG(Tshop model)
        {
            BendShopBll _bendshopBll = new BendShopBll();
            var result = false;
            result = _bendshopBll.AddShopMSG(model);
            return RedirectToAction("MarketIndex", "Market");
        }
        #endregion
    }
}