﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Controllers
{
    public class BlogDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
