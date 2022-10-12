﻿namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Doctors", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Spacial = c.String(),
                        Phone = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        gender = c.Int(nullable: false),
                        DepartmentManageId = c.Int(),
                        DepartmentWorkId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.DepartmentWorkId, cascadeDelete: true)
                .Index(t => t.DepartmentWorkId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Case = c.String(),
                        gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DrageTimes",
                c => new
                    {
                        PatientId = c.Int(nullable: false),
                        NurseId = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                        DrageName = c.String(),
                    })
                .PrimaryKey(t => new { t.PatientId, t.NurseId })
                .ForeignKey("dbo.Nurses", t => t.NurseId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.NurseId);
            
            CreateTable(
                "dbo.Nurses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        RoomManageId = c.Int(nullable: false),
                        gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                        NumberOfBeds = c.Int(nullable: false),
                        Type = c.String(),
                        Department_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_ID)
                .ForeignKey("dbo.Nurses", t => t.ID)
                .Index(t => t.ID)
                .Index(t => t.Department_ID);
            
            CreateTable(
                "dbo.PatientVisitors",
                c => new
                    {
                        PatientId = c.Int(nullable: false),
                        VisitorId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.PatientId, t.VisitorId })
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.Visits", t => t.VisitorId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.VisitorId);
            
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PatientDoctors",
                c => new
                    {
                        Patient_ID = c.Int(nullable: false),
                        Doctor_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Patient_ID, t.Doctor_ID })
                .ForeignKey("dbo.Patients", t => t.Patient_ID, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.Doctor_ID, cascadeDelete: true)
                .Index(t => t.Patient_ID)
                .Index(t => t.Doctor_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "ID", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "DepartmentWorkId", "dbo.Departments");
            DropForeignKey("dbo.PatientVisitors", "VisitorId", "dbo.Visits");
            DropForeignKey("dbo.PatientVisitors", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.DrageTimes", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.DrageTimes", "NurseId", "dbo.Nurses");
            DropForeignKey("dbo.Nurses", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "ID", "dbo.Nurses");
            DropForeignKey("dbo.Rooms", "Department_ID", "dbo.Departments");
            DropForeignKey("dbo.PatientDoctors", "Doctor_ID", "dbo.Doctors");
            DropForeignKey("dbo.PatientDoctors", "Patient_ID", "dbo.Patients");
            DropIndex("dbo.PatientDoctors", new[] { "Doctor_ID" });
            DropIndex("dbo.PatientDoctors", new[] { "Patient_ID" });
            DropIndex("dbo.PatientVisitors", new[] { "VisitorId" });
            DropIndex("dbo.PatientVisitors", new[] { "PatientId" });
            DropIndex("dbo.Rooms", new[] { "Department_ID" });
            DropIndex("dbo.Rooms", new[] { "ID" });
            DropIndex("dbo.Nurses", new[] { "RoomId" });
            DropIndex("dbo.DrageTimes", new[] { "NurseId" });
            DropIndex("dbo.DrageTimes", new[] { "PatientId" });
            DropIndex("dbo.Doctors", new[] { "DepartmentWorkId" });
            DropIndex("dbo.Departments", new[] { "ID" });
            DropTable("dbo.PatientDoctors");
            DropTable("dbo.Visits");
            DropTable("dbo.PatientVisitors");
            DropTable("dbo.Rooms");
            DropTable("dbo.Nurses");
            DropTable("dbo.DrageTimes");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
            DropTable("dbo.Departments");
        }
    }
}
