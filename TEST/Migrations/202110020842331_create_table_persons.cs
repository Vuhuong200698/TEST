namespace TEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_persons : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        PsName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persons");
        }
    }
}
