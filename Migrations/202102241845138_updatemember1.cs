namespace MemberClaimsService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemember1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Claims", "MemberID", "dbo.Members");
            DropPrimaryKey("dbo.Members");
            AlterColumn("dbo.Members", "MemberID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Members", "MemberID");
            AddForeignKey("dbo.Claims", "MemberID", "dbo.Members", "MemberID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Claims", "MemberID", "dbo.Members");
            DropPrimaryKey("dbo.Members");
            AlterColumn("dbo.Members", "MemberID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Members", "MemberID");
            AddForeignKey("dbo.Claims", "MemberID", "dbo.Members", "MemberID", cascadeDelete: true);
        }
    }
}
