namespace TEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_table_person : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "NamSinh", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "NamSinh");
        }
    }
}
