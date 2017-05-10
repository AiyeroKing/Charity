using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendShopController : Controller
    {
        /// <summary>
        /// 商品主页面
        /// </summary>
        /// <returns></returns>
        // GET: BendShop
        public ActionResult BendShopIndex()
        {
            return View();
        }
        /// <summary>
        /// 商品详细
        /// </summary>
        /// <returns></returns>
        public ActionResult BendShopArtialIndex()
        {
            return View();
        }
        /// <summary>
        /// 商品编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult BendShopEidtorIndex()
        {
            return View();
        }
        /// <summary>
        /// 商品添加
        /// </summary>
        public ActionResult BendShopAddIndex()
        {
            return View();
        }
       

    }
}