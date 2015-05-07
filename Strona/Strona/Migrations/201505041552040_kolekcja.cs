namespace Strona.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kolekcja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Users_UserId", c => c.Int());
            CreateIndex("dbo.Users", "Users_UserId");
            AddForeignKey("dbo.Users", "Users_UserId", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Users_UserId", "dbo.Users");
            DropIndex("dbo.Users", new[] { "Users_UserId" });
            DropColumn("dbo.Users", "Users_UserId");
        }
    }
}
