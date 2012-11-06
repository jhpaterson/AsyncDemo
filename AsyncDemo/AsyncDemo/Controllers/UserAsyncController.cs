using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsyncDemo.SlowServiceReference;

namespace AsyncDemo.Controllers
{
    public class UserAsyncController : AsyncController
    {
        //
        // GET: /UserAsync/

        public ActionResult Index()
        {
            return View();
        }

        public void ListAsync()
        {
            AsyncManager.OutstandingOperations.Increment();
            UserListServiceClient client = new UserListServiceClient();
            client.GetUserListCompleted += (sender, e) =>
            {
                AsyncManager.Parameters["users"] = e.Result;
                AsyncManager.OutstandingOperations.Decrement();
            };
            client.GetUserListAsync();
        }

        public ActionResult ListCompleted(User[] users)
        {
            return View("List",users);
        }


    }
}
