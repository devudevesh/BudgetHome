namespace BudgetHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePaymentModes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into PaymentModes (ModeName) Values ('CASH')");
            Sql("Insert into PaymentModes (ModeName) Values ('NET BANKING')");
            Sql("Insert into PaymentModes (ModeName) Values ('CREDIT CARD')");
            Sql("Insert into PaymentModes (ModeName) Values ('DEBIT CARD')");
            Sql("Insert into PaymentModes (ModeName) Values ('WALLET')");
            Sql("Insert into PaymentModes (ModeName) Values ('UPI')");
        }
        
        public override void Down()
        {
            Sql("Delete from PaymentModes Where Id in (1,2,3,4,5,6)");
        }
    }
}
