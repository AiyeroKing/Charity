using Charity.Bll.Bend;
using Charity.Model;
using Charity.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    public class LoginSignUpController : Controller
    {

        #region --返回页面
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
        public ActionResult LoginIndex(Vusersign user)
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
        public ActionResult UserLoginIndex(Vusersign user)
        {
            return View();
        }
        #endregion

        #region --后台管理系统密码验证登录
        [HttpPost]
        public ActionResult CheckUserLogin(Vusersign user)
        {
            BendadmindBll _bendadmindBll = new BendadmindBll();
            var queryResult = _bendadmindBll.Scan_Bendadmind();
            ViewBag.List = queryResult;
            string checktrue = "true";
            if (user.Checknumber == checktrue)
            {
                foreach (var usermodel in queryResult)
                {
                    if (usermodel.AdAccount == user.UserAccount && usermodel.AdPassWord == user.UserPassword)
                    {
                        ViewData.Model = usermodel;
                        Session["UserAccount"] = usermodel;//将值存在一个
                        return RedirectToAction("BendHomeIndex", "BendHome");
                    }
                }
            }
            return RedirectToAction("UserLoginIndex", "LoginSignUp");
        }
        #endregion

        #region --前台管理系统密码验证登录
        [HttpPost]
        public ActionResult CheckadminLogin(Vusersign admin)
        {
            BendAccountBll _bendaccountBll = new BendAccountBll();

            var queryResult = _bendaccountBll.Scan_Account();
            ViewBag.List = queryResult;
            string checktrue = "true";
            if (admin.Checknumber == checktrue)
            {
                foreach (var adminmodel in queryResult)
                {
                    if (adminmodel.UsAccount == admin.UserAccount && adminmodel.UsPassword == admin.UserPassword)
                    {
                        ViewData.Model = adminmodel;
                        Session["AdminAccount"] = adminmodel;//将值存在一个
                        return RedirectToAction("HomeIndex", "Home");
                    }
                }
            }
            return RedirectToAction("LoginIndex", "LoginSignUp");
        }
        #endregion

        #region --用户注销登录
        public ActionResult LoginSignOut()
        {
            Tuseraccount loginsignoutModel = new Tuseraccount();
            //loginsignoutModel.ID = 0;
            //loginsignoutModel.UsAccount = "无";
            //loginsignoutModel.UsIdcard = "无";
            //loginsignoutModel.Usmail = "无";
            //loginsignoutModel.UsName = "无";
            //loginsignoutModel.UsPassword = "无";
            //loginsignoutModel.UsPhone = "无";
            //loginsignoutModel.UsRemark = "无";
            //loginsignoutModel.UsSettime = DateTime.Now;
            loginsignoutModel = null;
            Session["AdminAccount"] = loginsignoutModel;//将值存在一个
            return RedirectToAction("HomeIndex", "Home");
        }
        #endregion

        #region --添加功能
        [HttpPost]
        public ActionResult AddAccountMSG(Tuseraccount model)
        {
            BendAccountBll _bendaccountBll = new BendAccountBll();
            var result = false;
            result = _bendaccountBll.AddAccountMSG(model);
            return RedirectToAction("LoginIndex", "LoginSignUp");
        }
        #endregion
    }
}