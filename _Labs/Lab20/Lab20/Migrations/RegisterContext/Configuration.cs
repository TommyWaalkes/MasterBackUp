namespace Lab20.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Lab20.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Lab20.Models.DBRegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Lab20.Models.DBRegisterContext";
        }

        protected override void Seed(Lab20.Models.DBRegisterContext context)
        {

        }
    }


}
