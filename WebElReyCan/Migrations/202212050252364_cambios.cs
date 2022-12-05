namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambios : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Turno", "Edad", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Turno", "Edad", c => c.Int(nullable: false));
        }
    }
}
