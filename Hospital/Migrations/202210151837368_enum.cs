namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _enum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DrageTimes", "Shift", c => c.Int(nullable: false));
            AddColumn("dbo.Nurses", "shift", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Nurses", "shift");
            DropColumn("dbo.DrageTimes", "Shift");
        }
    }
}
