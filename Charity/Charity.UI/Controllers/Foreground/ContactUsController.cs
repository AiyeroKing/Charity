﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Foreground
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult ContactUsIndex()
        {
            return View();
        }

        public ActionResult ContactBoardIndex()
        {
            return View();
        }
    }
}