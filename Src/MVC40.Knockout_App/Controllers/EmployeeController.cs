﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC40.Knockout_App.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

      

        public ActionResult Create()
        {
            return View("Create");
        }
    }
}
