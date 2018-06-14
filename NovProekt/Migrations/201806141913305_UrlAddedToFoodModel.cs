namespace NovProekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UrlAddedToFoodModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "Url");
        }
    }
}
