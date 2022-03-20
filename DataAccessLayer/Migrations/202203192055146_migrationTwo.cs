namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationTwo : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SubscribeMails");
            AlterColumn("dbo.SubscribeMails", "MailID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.SubscribeMails", "MailID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SubscribeMails");
            AlterColumn("dbo.SubscribeMails", "MailID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.SubscribeMails", "MailID");
        }
    }
}
