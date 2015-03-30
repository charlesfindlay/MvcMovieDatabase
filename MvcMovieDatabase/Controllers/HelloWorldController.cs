using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovieDatabase.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is my <strong>default</strong> action...";
        }

        // GET: Helloworld/welcome
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello, " + name + ", ID: " + ID);
        }
    }
}