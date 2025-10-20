namespace katharsis_code.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ComponentType = c.Int(nullable: false),
                        Computer_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Computers", t => t.Computer_Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .Index(t => t.Computer_Id)
                .Index(t => t.Manufacturer_Id);
            
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Inventory_Number = c.String(),
                        ComputerStatus = c.Int(nullable: false),
                        WriteOffReportId = c.Int(),
                        CPU_Id = c.Int(),
                        Employee_Id = c.Int(),
                        HDD_Id = c.Int(),
                        MotherBoard_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Components", t => t.CPU_Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .ForeignKey("dbo.Components", t => t.HDD_Id)
                .ForeignKey("dbo.Components", t => t.MotherBoard_Id)
                .ForeignKey("dbo.WriteOffReports", t => t.WriteOffReportId)
                .Index(t => t.WriteOffReportId)
                .Index(t => t.CPU_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.HDD_Id)
                .Index(t => t.MotherBoard_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Full_name = c.String(),
                        EmployeePosition = c.Int(nullable: false),
                        EmployeeStatus = c.Int(nullable: false),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PeripheralDevices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Inventory_Number = c.String(),
                        PeripheralType = c.Int(nullable: false),
                        PeripheralStatus = c.Int(nullable: false),
                        WriteOffReportId = c.Int(),
                        Employee_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.WriteOffReports", t => t.WriteOffReportId)
                .Index(t => t.WriteOffReportId)
                .Index(t => t.Employee_Id)
                .Index(t => t.Manufacturer_Id);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WriteOffReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        TechType = c.Int(nullable: false),
                        Inventory_number = c.String(),
                        ResponsiblePersons = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Components", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.Components", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.Computers", "WriteOffReportId", "dbo.WriteOffReports");
            DropForeignKey("dbo.Computers", "MotherBoard_Id", "dbo.Components");
            DropForeignKey("dbo.Computers", "HDD_Id", "dbo.Components");
            DropForeignKey("dbo.PeripheralDevices", "WriteOffReportId", "dbo.WriteOffReports");
            DropForeignKey("dbo.PeripheralDevices", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.PeripheralDevices", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Computers", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Computers", "CPU_Id", "dbo.Components");
            DropIndex("dbo.PeripheralDevices", new[] { "Manufacturer_Id" });
            DropIndex("dbo.PeripheralDevices", new[] { "Employee_Id" });
            DropIndex("dbo.PeripheralDevices", new[] { "WriteOffReportId" });
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropIndex("dbo.Computers", new[] { "MotherBoard_Id" });
            DropIndex("dbo.Computers", new[] { "HDD_Id" });
            DropIndex("dbo.Computers", new[] { "Employee_Id" });
            DropIndex("dbo.Computers", new[] { "CPU_Id" });
            DropIndex("dbo.Computers", new[] { "WriteOffReportId" });
            DropIndex("dbo.Components", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Components", new[] { "Computer_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.WriteOffReports");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.PeripheralDevices");
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
            DropTable("dbo.Computers");
            DropTable("dbo.Components");
        }
    }
}
