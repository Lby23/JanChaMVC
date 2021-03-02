using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Controllers
{
    public class HomeController1 : Controller                       
    {
        [HttpGet]
        public IActionResult Login()//登录
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()//注册
        {
            return View();
        }
    }
}
