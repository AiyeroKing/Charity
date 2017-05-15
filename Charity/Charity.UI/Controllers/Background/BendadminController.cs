using Charity.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendadminController : Controller
    {
        #region --返回页面
        /// <summary>
        /// 管理员主页面
        /// </summary>
        /// <returns></returns>
        // GET: Bendadmin
        public ActionResult BendadminIndex()
        {
            return View();
        }

        /// <summary>
        /// 管理员增加页面一
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAddadminoneIndex()
        {
            return View();
        }
        /// <summary>
        /// 管理员增加页面二
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAddadmintwoIndex()
        {
            return View();
        }
        /// <summary>
        /// 管理员编辑页面
        /// </summary>
        /// <returns></returns>

        public ActionResult BendEditIndex()
        {
            return View();
        }
        #endregion

        #region --序列号验证
        public ActionResult CheckXuliehao(string xuliehao)
        {
            string xuliehao1 = "123456";
            if(xuliehao == xuliehao1)
            {
                return RedirectToAction("BendAddadmintwoIndex", "Bendadmin");
            }
            else
            {
                return RedirectToAction("BendAddadminoneIndex", "Bendadmin");
            }
        }

        #endregion
    }
}