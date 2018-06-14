
namespace NovProekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImprovedModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Foods", "Url", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "Url", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurants", "Url", c => c.String());
            AlterColumn("dbo.Foods", "Url", c => c.String());
        }
    }
}
