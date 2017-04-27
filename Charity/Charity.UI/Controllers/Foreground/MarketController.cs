using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    public class MarketController : Controller
    {
        // GET: Market
        public ActionResult MarketIndex()
        {
            return View();
        }
    }
}