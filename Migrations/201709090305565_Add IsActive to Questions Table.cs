namespace LanSiDai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsActivetoQuestionsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        PersonId = c.String(),
                        AnsId = c.String(),
                        QuestionCategory = c.String(),
                        CreatTime = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Questions");
        }
    }
}
