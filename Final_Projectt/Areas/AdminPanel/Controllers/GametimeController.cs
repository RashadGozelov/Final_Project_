﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Projectt.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Final_Projectt.Areas.AdminPanel.Controllers
{
    [Authorize(Roles = Utility.AdminRole)]
    public class GametimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}