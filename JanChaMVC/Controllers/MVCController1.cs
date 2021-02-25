using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Controllers
{
    public class MVCController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Questionnaire()//问卷调查视图
        {
            return View();
        }
    }
}
