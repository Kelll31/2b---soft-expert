using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
namespace _2B.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int UserAge { get; set; } 
        public int Balance { get; set; } 

        public ApplicationUser() { } 
    }
}