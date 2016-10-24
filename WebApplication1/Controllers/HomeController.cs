using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult list()
        {
            string[] data = new string[]
            {
                "新闻1xxxxxxxxxxxxxxxxxxxxxxx",
                "新闻2xxxxxxxxxxxxxxxxxxxxxxx",
                "新闻3xxxxxxxxxxxxxxxxxxxxxxx",
                "新闻4xxxxxxxxxxxxxxxxxxxxxxx",
                "新闻5xxxxxxxxxxxxxxxxxxxxxxx",
                "新闻6xxxxxxxxxxxxxxxxxxxxxxx",
                "新闻7xxxxxxxxxxxxxxxxxxxxxxx",
                "新闻8xxxxxxxxxxxxxxxxxxxxxxx",
                "新闻9xxxxxxxxxxxxxxxxxxxxxxx",
                "新闻10xxxxxxxxxxxxxxxxxxxxxxx"
        };


            ViewBag.data = data;
            return View();
        }
        public ActionResult add()
        {
           
            return View();
        }
        ///<summary>
        ///保存新闻内容
        ///</summary>
        ///<returns></returns>
        public ActionResult Save(string title,string content)
        {
            ViewBag.Title = title;
            ViewBag.Conten = content;
            return View();
        }
    }
}