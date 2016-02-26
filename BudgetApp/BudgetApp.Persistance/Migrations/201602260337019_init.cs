namespace BudgetApp.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BudgetGoals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cost = c.Double(nullable: false),
                        Note = c.String(),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LedgerItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Amount = c.Double(nullable: false),
                        Note = c.String(),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LedgerItems", "User_Id", "dbo.Users");
            DropForeignKey("dbo.BudgetGoals", "User_Id", "dbo.Users");
            DropIndex("dbo.LedgerItems", new[] { "User_Id" });
            DropIndex("dbo.BudgetGoals", new[] { "User_Id" });
            DropTable("dbo.LedgerItems");
            DropTable("dbo.Users");
            DropTable("dbo.BudgetGoals");
        }
    }
}
