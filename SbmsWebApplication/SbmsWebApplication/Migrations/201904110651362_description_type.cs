namespace SbmsWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class description_type : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Description", c => c.Int(nullable: false));
        }
    }
}
