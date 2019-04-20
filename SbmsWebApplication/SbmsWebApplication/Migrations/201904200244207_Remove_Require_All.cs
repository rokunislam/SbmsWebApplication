namespace SbmsWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remove_Require_All : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Code", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Code", c => c.String(nullable: false));
        }
    }
}
