using Microsoft.AspNet.Identity.EntityFramework;
using MVCNick.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNick.Data
{
   

        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public DbSet<Songs> Songs  { get; set; }


            public ApplicationDbContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }

            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }
        }
    }
