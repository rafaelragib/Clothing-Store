namespace Clothing_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        c_id = c.Int(nullable: false, identity: true),
                        c_name = c.Int(nullable: false),
                        address_id = c.Int(nullable: false),
                        phone = c.String(),
                    })
                .PrimaryKey(t => t.c_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.customers");
        }
    }
}
