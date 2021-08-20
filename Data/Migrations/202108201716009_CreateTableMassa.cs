namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableMassa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Massas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                        Molho = c.String(),
                        Queijos = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Massas");
        }
    }
}
