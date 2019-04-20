namespace SbmsWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deltel_Required_From_CategoryName_In_Product : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "CategoryName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "CategoryName", c => c.String(nullable: false));
        }
    }
}
