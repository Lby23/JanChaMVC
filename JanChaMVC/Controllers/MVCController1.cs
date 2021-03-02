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
        //投诉管理Complain
        public IActionResult Complain()
        {
            return View();
        }
        //招聘管理Recruit 
        public IActionResult Recruit()
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
    }
}
