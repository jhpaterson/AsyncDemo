using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsyncDemo.SlowServiceReference;

namespace AsyncDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();

        }

        public ActionResult List()
        {
            UserListServiceClient client = new UserListServiceClient();
            User[] users = client.GetUserList();

            return View(users);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
