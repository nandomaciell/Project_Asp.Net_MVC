﻿using Microsoft.AspNetCore.Mvc;
using SiteMVC.Models;
using System.Diagnostics;

namespace SiteMVC.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            HomeModel home  = new HomeModel();
            home.nome = "Fernando Maciel";
            home.email = "Fernandoalves.m@hotmail.com";
            
            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}