namespace BudgetHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePaymentModeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentModes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PaymentModes");
        }
    }
}
