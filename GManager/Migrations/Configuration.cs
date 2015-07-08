namespace GManager.Migrations
{
    using GManager.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GManager.DAL.GManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GManager.DAL.GManagerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if (context.Products.Count() == 0)
            {
                List<Product> products = new List<Product>()
                {
                    new Product() { Name = "MacBook Air", AvailableQuantity = 10, BuyingPrice = 1200.00M, SellingPrice = 1400.00M },
                    new Product() { Name = "iPad Air 2", AvailableQuantity = 10, BuyingPrice = 399.00M, SellingPrice = 499.00M },
                    new Product() { Name = "MacBook", AvailableQuantity = 10, BuyingPrice = 1200.00M, SellingPrice = 1400.00M },
                };
                products.ForEach(m => context.Products.AddOrUpdate(m));
                context.SaveChanges();
            }
        }
    }
}
