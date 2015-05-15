namespace Strona.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PostCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "PostCode");
        }
    }
}
