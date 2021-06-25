using Data.Context;
using Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            List<User> users = new List<User>
                {
                    new User{FirstName = "f1",LastName="l1",Email="f1@gmail.com"},
                    new User{FirstName = "f2",LastName="l2",Email="f2@gmail.com"},
                    new User{FirstName = "f3",LastName="l3",Email="f3@gmail.com"}
                };

            foreach (var user in users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();

            List<Role> roles = new List<Role>
                {
                    new Role{Title = "Administrator"},
                    new Role{Title="User"}
                };
            foreach (var role in roles)
            {
                context.Roles.Add(role);
            }
            context.SaveChanges();
        }
    }
}
