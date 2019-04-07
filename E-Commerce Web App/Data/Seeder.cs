using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Models;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce_Web_App.Data
{
    public class Seeder
    {
        WebStoreContext context;
        RoleManager<Role> roleManager;
        UserManager<User> userManager;

        public Seeder(WebStoreContext context, RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            this.context = context;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public void Seed()
        {
            this.AddRoles();
            this.AddAdmin();
        }

        public void AddRoles()
        {
            if (!context.Roles.Any())
            {
                Role newRole = new Role { Name = "Administrator" };
                roleManager.CreateAsync(newRole).Wait();
                newRole = new Role { Name = "Non-privileged user" };
                roleManager.CreateAsync(newRole).Wait();
            }
        }

        public void AddAdmin()
        {
            if (!context.Users.Any())
            {
                DateTime dateofbirth = new DateTime(1997, 8, 17);
                User newUser = new User { FirstName = "Predrag", LastName = "Jovicic", Email = "predragjovicic33@hotmail.com", UserName = "adminpeksi", DateOfBirth = dateofbirth };
                userManager.UpdateSecurityStampAsync(newUser).Wait();
                userManager.CreateAsync(newUser, "P@ssWord3!").Wait();
                userManager.AddToRoleAsync(newUser, "Non-privileged user").Wait();
            }
        }

    }
}
