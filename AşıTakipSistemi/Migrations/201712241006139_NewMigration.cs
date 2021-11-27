namespace AşıTakipSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.cocukTables", "TC", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.cocukTables", "Şifre", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.doktorTables", "TC", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.doktorTables", "Şifre", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.sekreterTables", "TC", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.sekreterTables", "Şifre", c => c.String(nullable: false, maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.sekreterTables", "Şifre", c => c.String(nullable: false));
            AlterColumn("dbo.sekreterTables", "TC", c => c.String(nullable: false));
            AlterColumn("dbo.doktorTables", "Şifre", c => c.String(nullable: false));
            AlterColumn("dbo.doktorTables", "TC", c => c.String(nullable: false));
            AlterColumn("dbo.cocukTables", "Şifre", c => c.String(nullable: false));
            AlterColumn("dbo.cocukTables", "TC", c => c.String(nullable: false));
        }
    }
}
