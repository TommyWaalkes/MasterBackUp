using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureTest.Models
{
    public class Fish
    {
        public string name { get; set; }

        public class FishDbContext : IdentityDbContext<ApplicationUser>
        {
            public FishDbContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }
        }
    }
}