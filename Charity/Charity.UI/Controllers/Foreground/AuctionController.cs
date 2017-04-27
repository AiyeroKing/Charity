using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult AuctionIndex()
        {
            return View();
        }
    }
}