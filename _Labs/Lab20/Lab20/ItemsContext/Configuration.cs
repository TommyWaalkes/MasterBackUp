namespace Lab20.ItemsContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Lab20.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Lab20.Models.DBItemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"ItemsContext";
        }

        protected override void Seed(Lab20.Models.DBItemContext context)
        {
            context.Items.AddOrUpdate(p => p.Id,
                new Item
                {
                    Id = 1,
                    Product ="Coca Cola",
                    Description="The classic cola!",
                    Quantity = 120,
                    Price =1.5
                }
                );

            context.SaveChanges();

        }
    }
}
