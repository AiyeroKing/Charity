using Charity.Bll;
using Charity.Dal;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground.User
{
    public class UserController : Controller
    {


        public ActionResult UserIndex()
        {
            return View();
        }

        #region --对数据库进行增加的操作--


        //UserBll _userBll = new UserBll();
        //[HttpPost]
        //public ActionResult AddUserMSG(UserInfo model)
        //{
        //    string message = string.Empty;
        //    try
        //    {
        //        var result = _userBll.AddUserMSG(model);
        //        if (result)
        //        {
        //            return base.Json(new { Result = 1, Message = "增加成功！！" });
        //        }
        //        else
        //            return base.Json(new { Result = -1, Message = "增加失败！" });
        //    }
        //    catch (Exception exception)
        //    {
        //        message = exception.Message;
        //    }
        //    return base.Json(new { Result = -1, Message = message });
        //}

        #endregion


    }
}