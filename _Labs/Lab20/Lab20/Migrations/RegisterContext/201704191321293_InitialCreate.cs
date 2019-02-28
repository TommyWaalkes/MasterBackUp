namespace Lab20.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        FirstName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.FirstName);
        }
        
        public override void Down()
        {
            DropTable("dbo.Registers");
        }
    }
}
