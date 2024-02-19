namespace Webmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db_mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article_Table",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        PublishedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.Category_Table", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.User_Table", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Category_Table",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.User_Table",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PasswordHash = c.String(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Article_Table", "UserId", "dbo.User_Table");
            DropForeignKey("dbo.Article_Table", "CategoryId", "dbo.Category_Table");
            DropIndex("dbo.Article_Table", new[] { "CategoryId" });
            DropIndex("dbo.Article_Table", new[] { "UserId" });
            DropTable("dbo.User_Table");
            DropTable("dbo.Category_Table");
            DropTable("dbo.Article_Table");
        }
    }
}
