using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
namespace _2B.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("2Bdb") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}