﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HrPortal.Models;
using HrPortal.Data;
using HrPortal.Services;

namespace HrPortal.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Resume> resumeRepository;
        private IRepository<Message> messageRepository;
        public HomeController(IRepository<Resume> resumeRepository, IRepository<Message> messageRepository)
        {
            this.resumeRepository = resumeRepository;
            this.messageRepository = messageRepository;
        }
        public IActionResult Index()
        {
            ViewBag.ResumeCount = resumeRepository.Count();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Message message)
        {
            if (ModelState.IsValid) { 
            messageRepository.Insert(message);
            }
            return View(message);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
