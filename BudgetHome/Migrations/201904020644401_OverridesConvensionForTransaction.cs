namespace BudgetHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverridesConvensionForTransaction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Transactions", new[] { "UserId" });
            AlterColumn("dbo.PaymentModes", "ModeName", c => c.String(maxLength: 20));
            AlterColumn("dbo.Transactions", "Product", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Transactions", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Transactions", "TransactionType", c => c.String(nullable: false, maxLength: 6));
            CreateIndex("dbo.Transactions", "UserId");
            AddForeignKey("dbo.Transactions", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Transactions", new[] { "UserId" });
            AlterColumn("dbo.Transactions", "TransactionType", c => c.String(maxLength: 6));
            AlterColumn("dbo.Transactions", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Transactions", "Product", c => c.String(maxLength: 30));
            AlterColumn("dbo.PaymentModes", "ModeName", c => c.String());
            CreateIndex("dbo.Transactions", "UserId");
            AddForeignKey("dbo.Transactions", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
