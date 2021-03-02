using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Controllers
{
    public class MVCController1 : Controller
    {
        //首页
        public IActionResult Index()
        {
            return View();
        }
        //黑名单Blacklist
        public IActionResult BlackList()
        {
            return View();   
        }
        public IActionResult BlackListData()
        {
            return View();
        }

        public IActionResult Questionnaire()//问卷调查视图
        {
            return View();
        }

        public IActionResult Article()
        {
            return View();
        }

        public IActionResult Personal()
        {
            return View();
        }

        public IActionResult Link()//相关链接视图
        {
            return View();
        }
    }
}
