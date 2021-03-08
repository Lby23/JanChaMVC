using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Areas.Admin.Controllers
{
    public class GuanyvController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Area("Admin")]
        //招聘信息 详情页面
        public IActionResult recruit()
        {
            return View();
        }
        [Area("Admin")]
        //行为准则 详情页面
        public IActionResult criterion()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult abc()
        {
            return View();
        }
    }
}
