namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCommentTextLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "CommentText", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "CommentText", c => c.String(maxLength: 200));
        }
    }
}
