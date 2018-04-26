namespace Login.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        PassWord = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.UId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
