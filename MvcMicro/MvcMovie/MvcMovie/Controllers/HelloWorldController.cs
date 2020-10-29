using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        /*
        public string Index()
        {
            return "This is my <b>default</b> action";
        }
        */

        /* CASE 1 : 預設 方法
        public string Welcome()
        {
            return "This is the Welcome method";
        }
        */

        // CASE 2 :  傳遞網址參數
        /*
        public string Welcome(string name , int numTimes=1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ",NumTimes is: " + numTimes);
        }
        */

        // CASE 3 : 傳遞網址參數
        /*
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ",ID:" + ID);
        }
        */

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }



    }
}