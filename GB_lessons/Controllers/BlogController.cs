﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GB_lessons.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index() => View();
    }
}
