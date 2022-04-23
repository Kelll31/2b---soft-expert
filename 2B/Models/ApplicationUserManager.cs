//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
namespace _2B.Models
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        
        public ApplicationUserManager(IUserStore<ApplicationUser> strore) : base(strore) { }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> option, IOwinContext context)
        {
            
            ApplicationContext db = context.Get<ApplicationContext>();

            
            ApplicationUserManager manager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
            return manager;
        }
    }
}