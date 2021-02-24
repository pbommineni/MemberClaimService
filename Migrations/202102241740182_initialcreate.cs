namespace MemberClaimsService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        ClaimID = c.Int(nullable: false, identity: true),
                        MemberID = c.Int(nullable: false),
                        ClaimDate = c.DateTime(nullable: false),
                        ClaimAmount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ClaimID)
                .ForeignKey("dbo.Members", t => t.MemberID, cascadeDelete: true)
                .Index(t => t.MemberID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        EnrollmentDate = c.DateTime(nullable: false),
                        FirstName = c.Int(nullable: false),
                        LastName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MemberID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Claims", "MemberID", "dbo.Members");
            DropIndex("dbo.Claims", new[] { "MemberID" });
            DropTable("dbo.Members");
            DropTable("dbo.Claims");
        }
    }
}
