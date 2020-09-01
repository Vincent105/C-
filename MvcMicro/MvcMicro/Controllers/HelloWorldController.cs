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
        public string Index()
        {
            return "This is my <b>default</b> page...";
        }
        public string Welcome(string name, int numTimes = 1)
        {
            return "This is <b>welcome</b> method...";
            return HttpUtility.HtmlEncode("Hello",);
        }
    }
}