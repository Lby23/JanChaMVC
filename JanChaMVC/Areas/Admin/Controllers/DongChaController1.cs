using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Areas.Admin.Controllers
{
    public class DongChaController1 : Controller
    {
        [Area("Admin")]
        public IActionResult Index()//要闻简讯
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult Index1()//文章详情
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult Index2()//调查问卷
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult Index4()//联系我们
        {
            return View();
        }
    }
}
