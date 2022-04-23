using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using _2B.Models;
using Microsoft.AspNet.Identity.Owin;

namespace _2B.Controllers
{
    public class ManageController : Controller
    {
        public int UserAge { get; private set; }

        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }
        public async Task<ActionResult> Index()
        {
            ApplicationUser user = await UserManager.FindByEmailAsync(User.Identity.Name);

            if (user != null)
            {
                ManageModel model = new ManageModel
                    {Login = user.UserName, Age = user.UserAge, Email = user.Email, Balance = user.Balance};

                return View(model);
            }

            return RedirectToAction("Login", "Account");

        }
    }
}