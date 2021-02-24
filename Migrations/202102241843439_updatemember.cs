namespace MemberClaimsService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemember : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "FirstName", c => c.String());
            AlterColumn("dbo.Members", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "LastName", c => c.Int(nullable: false));
            AlterColumn("dbo.Members", "FirstName", c => c.Int(nullable: false));
        }
    }
}
