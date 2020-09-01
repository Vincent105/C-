using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMicro.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld

        /*
        public string Index()
        {
            return "This is my <b>default</b> page...";
        }
        */
        public ActionResult Index()
        {
            return View();
        }
        public string Welcome(string name, int ID = 1)
        {
            // https://localhost:44334/HelloWorld/Welcome/1?name=vin
            return HttpUtility.HtmlEncode("Hello " + name + "NumTimes is: " + ID);
        }
    }
}