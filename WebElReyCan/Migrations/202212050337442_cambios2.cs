﻿namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambios2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Turno", "FechaIngreso", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Turno", "FechaIngreso", c => c.DateTime(nullable: false));
        }
    }
}
