using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        [Area("Admin")]//显示
        public IActionResult Index()
        {
            return View();
        }
        [Area("Admin")]//行业类型
        public IActionResult Vocation()
        {
            return View();
        }
        [Area("Admin")]//服务类型
        public IActionResult service()//审计
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult a()
        {
            return View();
        }

    }
}
