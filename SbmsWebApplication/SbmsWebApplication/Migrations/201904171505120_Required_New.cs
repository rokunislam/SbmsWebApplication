namespace SbmsWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Required_New : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Code", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Products", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Products", "Code", c => c.String());
            DropColumn("dbo.Products", "CategoryId");
        }
    }
}
