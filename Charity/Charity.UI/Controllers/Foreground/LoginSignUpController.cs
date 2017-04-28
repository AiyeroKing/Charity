using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    public class LoginSignUpController : Controller
    {
        #region --登录注册页面显示返回值
        // GET: LoginSignUp
        //public ActionResult LoginSignUpIndex()
        //{
        //    return RedirectToAction("LoginIndex", "LoginSignUp");
        //    //return View();
        //}
        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        public ActionResult LoginIndex()
        {
            return View();
        }
        /// <summary>
        /// 注册页面
        /// </summary>
        /// <returns></returns>
        public ActionResult SignUpIndex()
        {
            return View();
        }
        /// <summary>
        /// 后台登录页面
        /// </summary>
        /// <returns></returns>
        public ActionResult UserLoginIndex()
        {
            return View();
        }
        #endregion

    }
}