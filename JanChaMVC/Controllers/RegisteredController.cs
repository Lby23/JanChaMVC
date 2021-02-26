using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Controllers
{
    public class RegisteredController : Controller
    {
        public IActionResult Index()//注册用户
        {
            return View();
        }
    }
}
