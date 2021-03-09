using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Areas.Admin.Controllers
{
    public class ComplaintController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult realName()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult noName()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult blackList()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult hotService()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult real_name_Complain()
        {
            return View();
        }
    }
}
