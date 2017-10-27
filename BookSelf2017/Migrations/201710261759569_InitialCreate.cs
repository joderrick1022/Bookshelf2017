namespace BookSelf2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        PublishedDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        ISBN = c.String(),
                        CatagoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Catagories", t => t.CatagoryID, cascadeDelete: true)
                .Index(t => t.CatagoryID);
            
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "CatagoryID", "dbo.Catagories");
            DropIndex("dbo.Books", new[] { "CatagoryID" });
            DropTable("dbo.Catagories");
            DropTable("dbo.Books");
        }
    }
}
