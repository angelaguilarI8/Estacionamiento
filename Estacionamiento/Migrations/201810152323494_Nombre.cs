namespace Estacionamiento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nombre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nombre", c => c.String(nullable: false, maxLength: 15));
            AddColumn("dbo.AspNetUsers", "Apellido", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Apellido");
            DropColumn("dbo.AspNetUsers", "Nombre");
        }
    }
}
