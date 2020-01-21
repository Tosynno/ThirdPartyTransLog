namespace TransactionLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransactionLog",
                c => new
                    {
                        RecID = c.Int(nullable: false, identity: true),
                        ClientID = c.String(),
                        ResponseCode = c.String(),
                        TranDate = c.DateTime(nullable: false),
                        SmartcardNo = c.String(),
                        Name = c.String(),
                        Phone = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DSTV_Mode = c.String(),
                        TraceRef = c.String(),
                        STAN = c.String(),
                        Hash = c.String(),
                        User_Id = c.String(),
                        Branch = c.String(),
                        Reverser_Flag = c.String(),
                        PAN = c.String(),
                        TerminalId = c.String(),
                        Status = c.String(),
                        ResponseDescription = c.String(),
                    })
                .PrimaryKey(t => t.RecID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TransactionLog");
        }
    }
}
