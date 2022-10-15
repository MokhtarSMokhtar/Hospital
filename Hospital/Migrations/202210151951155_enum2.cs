namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enum2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Nurses", "RoomId", "dbo.Rooms");
            DropIndex("dbo.Nurses", new[] { "RoomId" });
            AlterColumn("dbo.Nurses", "RoomId", c => c.Int());
            AlterColumn("dbo.Nurses", "RoomManageId", c => c.Int());
            CreateIndex("dbo.Nurses", "RoomId");
            AddForeignKey("dbo.Nurses", "RoomId", "dbo.Rooms", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nurses", "RoomId", "dbo.Rooms");
            DropIndex("dbo.Nurses", new[] { "RoomId" });
            AlterColumn("dbo.Nurses", "RoomManageId", c => c.Int(nullable: false));
            AlterColumn("dbo.Nurses", "RoomId", c => c.Int(nullable: false));
            CreateIndex("dbo.Nurses", "RoomId");
            AddForeignKey("dbo.Nurses", "RoomId", "dbo.Rooms", "ID", cascadeDelete: true);
        }
    }
}
