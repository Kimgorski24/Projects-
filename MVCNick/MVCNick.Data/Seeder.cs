using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNick.Data
{
    class Seeder
    {
        public static void Seed(ApplicationDbContext db) 
        
        { 
            RoleStore<Role>roleStore = new RoleStore<Role>dv
                RoleManager<Role>RoleManager = new RoleManager<Role>(roleStore);

            UserStore <ApplicationDbContext>userStore = new UswerStore<Applicati0onUser >(db);
            userManager<Applicatiopnuser> userManager = new userManager<Applicatiopnuser>(db);

            if (!RoleManager.RoleExists("Admin"))
            {
                roleManasger.Create(new Role
                {
                    Name="Admin"
                }};
            }

      if (!RoleManager.RoleExists("General"))
            {
                roleManasger.Create(new Role
                {
                    Name="General"
                });
    }


Application nick = userManager.FindByEmail("Nick@codercamops.com") //let me see if user exsists
of (nick ==null)
{
nick = new ApplicationUser
}
{
Email = "nick@codercamps.com", //if not create them
UserName = nick@codercasmps.com",
FirstName = "Nick",
LastName = "Brittain"
};
userManager.Create(nick, "123456");
userManager.AddToRole(nick.Id,"Admin");
  //if role exists the will add to role
nick= userManager.FindByEmail ("nick@codercamps.com");  //check again
}
else
}
if (!userManager.IsInRole(nick.Id, "Admin"))  //update part here   if nick is not in admin role

}
userManager.AddToRole(nick.Id, "Admin");
}

//seed songs here
