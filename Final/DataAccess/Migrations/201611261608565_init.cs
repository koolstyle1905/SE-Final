namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        AttendanceId = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceId)
                .ForeignKey("dbo.Employees", t => t.StudentID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        Username = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        Position = c.String(maxLength: 20),
                        Name = c.String(maxLength: 50),
                        Gender = c.String(maxLength: 20),
                        DateOfBirth = c.DateTime(nullable: false),
                        SSN = c.String(maxLength: 20),
                        Address = c.String(storeType: "ntext"),
                        Phone = c.Decimal(nullable: false, precision: 12, scale: 0, storeType: "numeric"),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.DamageClaim",
                c => new
                    {
                        ClaimID = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(maxLength: 128),
                        EmployeeID = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.ClaimID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.StudentID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        ClubID = c.String(maxLength: 128),
                        ClassID = c.String(maxLength: 128),
                        RoomID = c.String(maxLength: 128),
                        Name = c.String(maxLength: 50),
                        Gender = c.String(maxLength: 20),
                        DateOfBirth = c.DateTime(nullable: false),
                        SSN = c.String(maxLength: 20),
                        Address = c.String(storeType: "ntext"),
                        Phone = c.Decimal(nullable: false, precision: 12, scale: 0, storeType: "numeric"),
                        PlaceOfBirth = c.String(maxLength: 200),
                        Nation = c.String(maxLength: 50),
                        Religion = c.String(maxLength: 50),
                        Position = c.String(maxLength: 20),
                        Course = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Classes", t => t.ClassID)
                .ForeignKey("dbo.Clubs", t => t.ClubID)
                .ForeignKey("dbo.Rooms", t => t.RoomID)
                .Index(t => t.ClubID)
                .Index(t => t.ClassID)
                .Index(t => t.RoomID);
            
            CreateTable(
                "dbo.Carer",
                c => new
                    {
                        CareID = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(maxLength: 128),
                        Job = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        Gender = c.String(maxLength: 20),
                        DateOfBirth = c.DateTime(nullable: false),
                        SSN = c.String(maxLength: 20),
                        Address = c.String(storeType: "ntext"),
                        Phone = c.Decimal(nullable: false, precision: 12, scale: 0, storeType: "numeric"),
                    })
                .PrimaryKey(t => t.CareID)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassID = c.String(nullable: false, maxLength: 128),
                        FacultyID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ClassID)
                .ForeignKey("dbo.Faculties", t => t.FacultyID)
                .Index(t => t.FacultyID);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        FacultyID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.FacultyID);
            
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        ClubID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ClubID);
            
            CreateTable(
                "dbo.Discipline",
                c => new
                    {
                        DisciplineId = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(maxLength: 128),
                        EmployeeID = c.String(maxLength: 128),
                        Description = c.String(storeType: "ntext"),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DisciplineId)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.StudentID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.LateArrivalInfo",
                c => new
                    {
                        LateID = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(maxLength: 128),
                        WorkingAddress = c.String(storeType: "ntext"),
                        ArrivalTime = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Reason = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.LateID)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.LeaseContracts",
                c => new
                    {
                        ContractID = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContractID)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.LeaseReceipts",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        ContractID = c.String(nullable: false, maxLength: 128),
                        EndDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => new { t.StudentID, t.ContractID })
                .ForeignKey("dbo.LeaseContracts", t => t.ContractID)
                .ForeignKey("dbo.Employees", t => t.StudentID)
                .Index(t => t.StudentID)
                .Index(t => t.ContractID);
            
            CreateTable(
                "dbo.ParkingTickets",
                c => new
                    {
                        TicketID = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(maxLength: 128),
                        OwnerName = c.String(maxLength: 50),
                        OwnerAddress = c.String(storeType: "ntext"),
                        VehicleType = c.String(maxLength: 50),
                        Color = c.String(maxLength: 50),
                        LicensePlates = c.String(maxLength: 20),
                        EngineModel = c.String(maxLength: 20),
                        VINNumber = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.TicketID)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.ParkingReceipts",
                c => new
                    {
                        TicketID = c.String(nullable: false, maxLength: 128),
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        TotalPrice = c.Decimal(nullable: false, storeType: "money"),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.TicketID, t.EmployeeID })
                .ForeignKey("dbo.ParkingTickets", t => t.TicketID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.TicketID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Priorities",
                c => new
                    {
                        PriorityID = c.String(nullable: false, maxLength: 128),
                        Content = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.PriorityID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.String(nullable: false, maxLength: 128),
                        FloorID = c.String(maxLength: 128),
                        NumOfStudent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.Floors", t => t.FloorID)
                .Index(t => t.FloorID);
            
            CreateTable(
                "dbo.Floors",
                c => new
                    {
                        FloorID = c.String(nullable: false, maxLength: 128),
                        BuildingID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.FloorID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID)
                .Index(t => t.BuildingID);
            
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        BuildingID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.BuildingID);
            
            CreateTable(
                "dbo.ServiceBills",
                c => new
                    {
                        BillID = c.String(nullable: false, maxLength: 128),
                        RoomID = c.String(maxLength: 128),
                        StudentID = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.BillID)
                .ForeignKey("dbo.Rooms", t => t.RoomID)
                .ForeignKey("dbo.Employees", t => t.StudentID)
                .Index(t => t.RoomID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.TemporaryAbsences",
                c => new
                    {
                        AbsenceID = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(maxLength: 128),
                        EmployeeID = c.String(maxLength: 128),
                        StartDate = c.DateTime(nullable: false),
                        NumOfAbsence = c.Int(nullable: false),
                        Reason = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.AbsenceID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.StudentID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.PriorityTarget",
                c => new
                    {
                        PriorityID = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.PriorityID, t.StudentID })
                .ForeignKey("dbo.Priorities", t => t.PriorityID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.PriorityID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.AttendanceDetail",
                c => new
                    {
                        AttendanceId = c.String(nullable: false, maxLength: 128),
                        PersonID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.AttendanceId, t.PersonID })
                .ForeignKey("dbo.Attendance", t => t.AttendanceId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.AttendanceId)
                .Index(t => t.PersonID);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AttendanceDetail", "PersonID", "dbo.Students");
            DropForeignKey("dbo.AttendanceDetail", "AttendanceId", "dbo.Attendance");
            DropForeignKey("dbo.ServiceBills", "StudentID", "dbo.Employees");
            DropForeignKey("dbo.ParkingReceipts", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.LeaseReceipts", "StudentID", "dbo.Employees");
            DropForeignKey("dbo.TemporaryAbsences", "StudentID", "dbo.Students");
            DropForeignKey("dbo.TemporaryAbsences", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Students", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.ServiceBills", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "FloorID", "dbo.Floors");
            DropForeignKey("dbo.Floors", "BuildingID", "dbo.Buildings");
            DropForeignKey("dbo.PriorityTarget", "StudentID", "dbo.Students");
            DropForeignKey("dbo.PriorityTarget", "PriorityID", "dbo.Priorities");
            DropForeignKey("dbo.ParkingTickets", "StudentID", "dbo.Students");
            DropForeignKey("dbo.ParkingReceipts", "TicketID", "dbo.ParkingTickets");
            DropForeignKey("dbo.LeaseContracts", "StudentID", "dbo.Students");
            DropForeignKey("dbo.LeaseReceipts", "ContractID", "dbo.LeaseContracts");
            DropForeignKey("dbo.LateArrivalInfo", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Discipline", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Discipline", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.DamageClaim", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "ClubID", "dbo.Clubs");
            DropForeignKey("dbo.Students", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.Classes", "FacultyID", "dbo.Faculties");
            DropForeignKey("dbo.Carer", "StudentID", "dbo.Students");
            DropForeignKey("dbo.DamageClaim", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Attendance", "StudentID", "dbo.Employees");
            DropIndex("dbo.AttendanceDetail", new[] { "PersonID" });
            DropIndex("dbo.AttendanceDetail", new[] { "AttendanceId" });
            DropIndex("dbo.PriorityTarget", new[] { "StudentID" });
            DropIndex("dbo.PriorityTarget", new[] { "PriorityID" });
            DropIndex("dbo.TemporaryAbsences", new[] { "EmployeeID" });
            DropIndex("dbo.TemporaryAbsences", new[] { "StudentID" });
            DropIndex("dbo.ServiceBills", new[] { "StudentID" });
            DropIndex("dbo.ServiceBills", new[] { "RoomID" });
            DropIndex("dbo.Floors", new[] { "BuildingID" });
            DropIndex("dbo.Rooms", new[] { "FloorID" });
            DropIndex("dbo.ParkingReceipts", new[] { "EmployeeID" });
            DropIndex("dbo.ParkingReceipts", new[] { "TicketID" });
            DropIndex("dbo.ParkingTickets", new[] { "StudentID" });
            DropIndex("dbo.LeaseReceipts", new[] { "ContractID" });
            DropIndex("dbo.LeaseReceipts", new[] { "StudentID" });
            DropIndex("dbo.LeaseContracts", new[] { "StudentID" });
            DropIndex("dbo.LateArrivalInfo", new[] { "StudentID" });
            DropIndex("dbo.Discipline", new[] { "EmployeeID" });
            DropIndex("dbo.Discipline", new[] { "StudentID" });
            DropIndex("dbo.Classes", new[] { "FacultyID" });
            DropIndex("dbo.Carer", new[] { "StudentID" });
            DropIndex("dbo.Students", new[] { "RoomID" });
            DropIndex("dbo.Students", new[] { "ClassID" });
            DropIndex("dbo.Students", new[] { "ClubID" });
            DropIndex("dbo.DamageClaim", new[] { "EmployeeID" });
            DropIndex("dbo.DamageClaim", new[] { "StudentID" });
            DropIndex("dbo.Attendance", new[] { "StudentID" });
            DropTable("dbo.AttendanceDetail");
            DropTable("dbo.PriorityTarget");
            DropTable("dbo.TemporaryAbsences");
            DropTable("dbo.ServiceBills");
            DropTable("dbo.Buildings");
            DropTable("dbo.Floors");
            DropTable("dbo.Rooms");
            DropTable("dbo.Priorities");
            DropTable("dbo.ParkingReceipts");
            DropTable("dbo.ParkingTickets");
            DropTable("dbo.LeaseReceipts");
            DropTable("dbo.LeaseContracts");
            DropTable("dbo.LateArrivalInfo");
            DropTable("dbo.Discipline");
            DropTable("dbo.Clubs");
            DropTable("dbo.Faculties");
            DropTable("dbo.Classes");
            DropTable("dbo.Carer");
            DropTable("dbo.Students");
            DropTable("dbo.DamageClaim");
            DropTable("dbo.Employees");
            DropTable("dbo.Attendance");
        }
    }
}
