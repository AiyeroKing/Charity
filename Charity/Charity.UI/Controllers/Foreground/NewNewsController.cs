using Charity.Bll.Bend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    public class NewNewsController : Controller
    {
        BendInfoBll _bendinfoBll = new BendInfoBll();
        // GET: NewNews
        public ActionResult NewNewsIndex()
        {
            var queryResult = _bendinfoBll.Query_scanbendinfo();
            ViewBag.List = queryResult;
            return View();
        }

        public ActionResult NewNewsAritailIndex(int Id = 0)
        {
            var queryResult = _bendinfoBll.Query_bendinfoaritial(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
    }
}