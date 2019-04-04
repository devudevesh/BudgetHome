namespace BudgetHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable_Transaction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "TransactionDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "TransactionDate", c => c.DateTime(nullable: false));
        }
    }
}
