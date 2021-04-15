using Customers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customers.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //make a list of users

            //usually this would come from a database source
            //in this demo we will hard code the values into this class

            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel("John wick", "doglover@gmail.com", "(123)-456-7890"));
            users.Add(new UserModel("Ethen hunt", "agent@gmail.com", "(132)-456-7890"));
            users.Add(new UserModel("Christopher Nolan", "tenet@gmail.com", "(123)-654-7890"));
            users.Add(new UserModel("Stephen King", "horror@gmail.com", "(123)-456-0789"));


            return View("Test",users);
        }
    }
}