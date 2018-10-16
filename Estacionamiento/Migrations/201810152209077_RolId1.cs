namespace Estacionamiento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolId1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RolId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RolId");
        }
    }
}
