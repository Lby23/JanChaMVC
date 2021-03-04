using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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

        //文章列表
        public IActionResult Article()
        {
            return View();
        }

        //个人信息
        public IActionResult Personal()
        {
            return View();
        }

        public IActionResult Link()//相关链接视图
        {
            return View();
        }

        //上传图片
        [HttpPost]
        public object Upload([FromForm] IFormCollection formData)
        {
            IFormFile uploadfile = formData.Files[0];
            //判断是否上传了文件
            if (uploadfile != null)
            {
                //文件后缀
                var fileExtension = Path.GetExtension(uploadfile.FileName);
                var strDateTime = DateTime.Now.ToString("yyMMddhhmmssfff"); //取得时间字符串
                var strRan = Convert.ToString(new Random().Next(100, 999)); //生成三位随机数
                //新名字
                var saveName = strDateTime + strRan + fileExtension;
                //数据库存储路径
                var di = ("/Img/" + saveName);
                //获取文件存储的路径
                var bi = Path.Combine("wwwroot", "Img");
                //判断是否存在该文件夹
                if (!Directory.Exists(bi))
                {
                    Directory.CreateDirectory(bi);
                }
                //文件写入
                using (FileStream fs = System.IO.File.Create(Path.Combine(bi, saveName)))
                {
                    uploadfile.CopyTo(fs);
                    fs.Flush();
                }
                //返回路径，返回的状态码
                return new { code = 0, path = di };
            }
            //失败的状态码
            return new { code = 1 };
        }
    }
}
