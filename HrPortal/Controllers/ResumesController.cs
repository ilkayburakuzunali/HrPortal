﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HrPortal.Controllers
{
    public class ResumesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string id)
        {

            return View();
        }

        public IActionResult Create()
        {
            return View();
           
        }

        public IActionResult Edit()
        {
            return View();
        }
    }

}