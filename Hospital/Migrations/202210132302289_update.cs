namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Room_ID", c => c.Int());
            CreateIndex("dbo.Patients", "Room_ID");
            AddForeignKey("dbo.Patients", "Room_ID", "dbo.Rooms", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "Room_ID", "dbo.Rooms");
            DropIndex("dbo.Patients", new[] { "Room_ID" });
            DropColumn("dbo.Patients", "Room_ID");
        }
    }
}
