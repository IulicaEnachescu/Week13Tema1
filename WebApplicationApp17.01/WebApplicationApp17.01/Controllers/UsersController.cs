using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationApp17._01.Models;


namespace WebApplicationApp17._01.Controllers
{
    public class UsersController: Controller
    {
        private readonly UserData userData;
        public UsersController()
        {
            this.userData = new UserData();
        }

        public ActionResult Index()
        { //users/index
            var users = this.userData.GetUsers();
            return View(users);
        }
        public ActionResult ById(int id)
        {
            var u = this.userData.GetUser(id);

            return this.View(u);
        }

    }
}
