namespace BudgetHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTransactionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Product = c.String(maxLength: 30),
                        PaidAmount = c.Double(nullable: false),
                        UserId = c.String(maxLength: 128),
                        PaymentModeId = c.Int(nullable: false),
                        BankName = c.String(maxLength: 50),
                        TransactionType = c.String(maxLength: 6),
                        TransactionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentModes", t => t.PaymentModeId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.PaymentModeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Transactions", "PaymentModeId", "dbo.PaymentModes");
            DropIndex("dbo.Transactions", new[] { "PaymentModeId" });
            DropIndex("dbo.Transactions", new[] { "UserId" });
            DropTable("dbo.Transactions");
        }
    }
}
