namespace TransactionLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbleintial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransactionLog", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TransactionLog", "TranDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TransactionLog", "TranDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.TransactionLog", "CreatedDate");
        }
    }
}
