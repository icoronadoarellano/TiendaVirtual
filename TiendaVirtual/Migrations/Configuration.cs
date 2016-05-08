namespace TiendaVirtual.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    internal sealed class Configuration : DbMigrationsConfiguration<TiendaVirtual.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TiendaVirtual.Models.ApplicationDbContext context)
        {
            AddRole(context, "Admin");
            AddRole(context, "Cliente");
        }

        private void AddRole(ApplicationDbContext context, string role)
        {
            if (!context.Roles.Any(x => x.Name == role))
                context.Roles.Add(new IdentityRole(role));
        }
    }
}
