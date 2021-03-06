using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        //首页
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        //要闻资讯
        [Area("Admin")]
        public IActionResult Information()
        {
            return View();
        }

        //研究洞察
        [Area("Admin")]
        public IActionResult Insight()
        {
            return View();
        }
    }
}
