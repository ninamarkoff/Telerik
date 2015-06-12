namespace TicketSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using TicketSystem.Models;
    using TicketSystem.Common;
    using System.Collections.Generic;

    public sealed class Configuration : DbMigrationsConfiguration<TicketSystemDbContext>
    {
        private UserManager<User> userManager;

        private IRandomGenerator random;

       
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.random = new RandomGenerator();
        }

        protected override void Seed(TicketSystem.Data.TicketSystemDbContext context)
        {
            this.userManager = new UserManager<User>(new UserStore<User>(context));
            this.SeedRoles(context);
            this.SeedUsers(context);
            this.SeedCategoriesWithTicketsWithComments(context);
        }

        private void SeedUsers(TicketSystemDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                var user = new User
                {
                    Email = string.Format("{0}@{1}.com",
                    this.random.RandomString(6, 16), this.random.RandomString(6, 16)),
                    UserName = this.random.RandomString(6,16)
                    };

                this.userManager.Create(user, "123456");               
            }

            var adminUser = new User
            {
                Email = "admin@mysite.com",
                UserName = "Administrator"
            };

            this.userManager.Create(adminUser, "123456");
            this.userManager.AddToRole(adminUser.Id, GlobalConstants.AdminRole);

        }

        private void SeedRoles(TicketSystemDbContext context)
        {
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole(GlobalConstants.AdminRole));
            context.SaveChanges();
        }
        private void SeedCategoriesWithTicketsWithComments(TicketSystemDbContext context)
        {

        }
    }
}
