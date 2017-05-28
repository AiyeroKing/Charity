using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers
{
    /// <summary>
    /// 前台首页--前台控制器
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult HomeIndex()
        {
            return View();
            //return RedirectToAction("UserIndex", "User");
        }

        public ActionResult HometwoIndex()
        {
            return View();
            //return RedirectToAction("UserIndex", "User");
        }

        public ActionResult Fuxieyi()
        {
            return View();
        }



        #region --图片上传
        public ActionResult Upload()
        {
            NameValueCollection nvc = System.Web.HttpContext.Current.Request.Form;

            HttpFileCollection hfc = System.Web.HttpContext.Current.Request.Files;
            string imgPath = "";
            if (hfc.Count > 0)
            {
                imgPath = "/DataBase" + hfc[0].FileName;
                string PhysicalPath = Server.MapPath(imgPath);
                hfc[0].SaveAs(PhysicalPath);
            }
            //注意要写好后面的第二第三个参数
            return Json(new { Id = nvc.Get("Id"), name = nvc.Get("name"), imgPath1 = imgPath }, "text/html", JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}