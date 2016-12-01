using System.Data.Entity.Migrations;

namespace DataAccess.Migrations
{
	public partial class Init : DbMigration
	{
		public override void Up()
		{
			CreateTable(
					"dbo.Attendance",
					c => new
					{
						AttendanceId = c.String(false, 10),
						EmployeeId = c.String(maxLength: 10),
						CreatedDate = c.DateTime(false)
					})
				.PrimaryKey(t => t.AttendanceId)
				.ForeignKey("dbo.Employees", t => t.EmployeeId)
				.Index(t => t.EmployeeId);

			CreateTable(
					"dbo.Employees",
					c => new
					{
						EmployeeId = c.String(false, 10),
						Name = c.String(maxLength: 50),
						Gender = c.String(maxLength: 20),
						DateOfBirth = c.DateTime(false),
						SSN = c.String(maxLength: 20),
						Address = c.String(storeType: "ntext"),
						Phone = c.Decimal(false, 12, 0, storeType: "numeric"),
						Username = c.String(maxLength: 20),
						Password = c.String(maxLength: 20),
						Position = c.String(maxLength: 20)
					})
				.PrimaryKey(t => t.EmployeeId);

			CreateTable(
					"dbo.LeaseDetails",
					c => new
					{
						EmployeeId = c.String(false, 10),
						ContractId = c.String(false, 10),
						StartDate = c.DateTime(false),
						EndDate = c.DateTime(false),
						Amount = c.Decimal(storeType: "money")
					})
				.PrimaryKey(t => new {t.EmployeeId, t.ContractId})
				.ForeignKey("dbo.LeaseContracts", t => t.ContractId)
				.ForeignKey("dbo.Employees", t => t.EmployeeId)
				.Index(t => t.EmployeeId)
				.Index(t => t.ContractId);

			CreateTable(
					"dbo.LeaseContracts",
					c => new
					{
						ContractId = c.String(false, 10),
						StudentId = c.String(maxLength: 10),
						CreatedDate = c.DateTime(false)
					})
				.PrimaryKey(t => t.ContractId)
				.ForeignKey("dbo.Students", t => t.StudentId)
				.Index(t => t.StudentId);

			CreateTable(
					"dbo.Students",
					c => new
					{
						StudentId = c.String(false, 10),
						ClubId = c.String(maxLength: 10),
						ClassId = c.String(maxLength: 10),
						RoomId = c.String(maxLength: 10),
						Name = c.String(maxLength: 50),
						Gender = c.String(maxLength: 20),
						DateOfBirth = c.DateTime(false),
						SSN = c.String(maxLength: 20),
						Address = c.String(storeType: "ntext"),
						Phone = c.Decimal(false, 12, 0, storeType: "numeric"),
						PlaceOfBirth = c.String(maxLength: 200),
						Nation = c.String(maxLength: 50),
						Religion = c.String(maxLength: 50),
						Course = c.Int(false),
						Position = c.String(maxLength: 20)
					})
				.PrimaryKey(t => t.StudentId)
				.ForeignKey("dbo.Classes", t => t.ClassId)
				.ForeignKey("dbo.Clubs", t => t.ClubId)
				.ForeignKey("dbo.Rooms", t => t.RoomId)
				.Index(t => t.ClubId)
				.Index(t => t.ClassId)
				.Index(t => t.RoomId);

			CreateTable(
					"dbo.Carer",
					c => new
					{
						CarerId = c.String(false, 10),
						StudentId = c.String(maxLength: 10),
						Name = c.String(maxLength: 50),
						Gender = c.String(maxLength: 20),
						DateOfBirth = c.DateTime(false),
						SSN = c.String(maxLength: 20),
						Address = c.String(storeType: "ntext"),
						Phone = c.Decimal(false, 12, 0, storeType: "numeric"),
						Job = c.String(maxLength: 50)
					})
				.PrimaryKey(t => t.CarerId)
				.ForeignKey("dbo.Students", t => t.StudentId)
				.Index(t => t.StudentId);

			CreateTable(
					"dbo.Classes",
					c => new
					{
						ClassId = c.String(false, 10),
						FacultyId = c.String(maxLength: 10)
					})
				.PrimaryKey(t => t.ClassId)
				.ForeignKey("dbo.Faculties", t => t.FacultyId)
				.Index(t => t.FacultyId);

			CreateTable(
					"dbo.Faculties",
					c => new
					{
						FacultyId = c.String(false, 10),
						Name = c.String(maxLength: 50)
					})
				.PrimaryKey(t => t.FacultyId);

			CreateTable(
					"dbo.Clubs",
					c => new
					{
						ClubId = c.String(false, 10),
						Name = c.String(maxLength: 50)
					})
				.PrimaryKey(t => t.ClubId);

			CreateTable(
					"dbo.LateArrivalInfo",
					c => new
					{
						LateId = c.String(false, 10),
						StudentId = c.String(maxLength: 10),
						WorkingAddress = c.String(storeType: "ntext"),
						ArrivalTime = c.DateTime(false),
						CreatedDate = c.DateTime(false),
						Description = c.String(storeType: "ntext")
					})
				.PrimaryKey(t => t.LateId)
				.ForeignKey("dbo.Students", t => t.StudentId)
				.Index(t => t.StudentId);

			CreateTable(
					"dbo.ParkingTickets",
					c => new
					{
						TicketId = c.String(false, 10),
						StudentId = c.String(maxLength: 10),
						OwnerName = c.String(maxLength: 50),
						OwnerAddress = c.String(storeType: "ntext"),
						VehicleType = c.String(maxLength: 50),
						Color = c.String(maxLength: 50),
						LicensePlates = c.String(maxLength: 20),
						EngineModel = c.String(maxLength: 20),
						VINNumber = c.String(maxLength: 20)
					})
				.PrimaryKey(t => t.TicketId)
				.ForeignKey("dbo.Students", t => t.StudentId)
				.Index(t => t.StudentId);

			CreateTable(
					"dbo.ParkingDetails",
					c => new
					{
						TicketId = c.String(false, 10),
						EmployeeId = c.String(false, 10),
						StartDate = c.DateTime(false),
						EndDate = c.DateTime(false),
						Amount = c.Decimal(false, storeType: "money")
					})
				.PrimaryKey(t => new {t.TicketId, t.EmployeeId})
				.ForeignKey("dbo.ParkingTickets", t => t.TicketId)
				.ForeignKey("dbo.Employees", t => t.EmployeeId)
				.Index(t => t.TicketId)
				.Index(t => t.EmployeeId);

			CreateTable(
					"dbo.Priorities",
					c => new
					{
						PriorityId = c.String(false, 10),
						Content = c.String(storeType: "ntext")
					})
				.PrimaryKey(t => t.PriorityId);

			CreateTable(
					"dbo.Rooms",
					c => new
					{
						RoomId = c.String(false, 10),
						FloorId = c.String(maxLength: 10)
					})
				.PrimaryKey(t => t.RoomId)
				.ForeignKey("dbo.Floors", t => t.FloorId)
				.Index(t => t.FloorId);

			CreateTable(
					"dbo.Floors",
					c => new
					{
						FloorId = c.String(false, 10),
						BuildingId = c.String(maxLength: 10)
					})
				.PrimaryKey(t => t.FloorId)
				.ForeignKey("dbo.Buildings", t => t.BuildingId)
				.Index(t => t.BuildingId);

			CreateTable(
					"dbo.Buildings",
					c => new
					{
						BuildingId = c.String(false, 10)
					})
				.PrimaryKey(t => t.BuildingId);

			CreateTable(
					"dbo.TemporaryAbsences",
					c => new
					{
						AbsenceId = c.String(false, 10),
						EmployeeId = c.String(maxLength: 10),
						StudentId = c.String(maxLength: 10),
						StartDate = c.DateTime(false),
						NumOfAbsence = c.Int(false),
						CreatedDate = c.DateTime(false),
						Description = c.String(storeType: "ntext")
					})
				.PrimaryKey(t => t.AbsenceId)
				.ForeignKey("dbo.Employees", t => t.EmployeeId)
				.ForeignKey("dbo.Students", t => t.StudentId)
				.Index(t => t.EmployeeId)
				.Index(t => t.StudentId);

			CreateTable(
					"dbo.ViolationRecord",
					c => new
					{
						ViolationId = c.String(false, 10),
						EmployeeId = c.String(maxLength: 10),
						StudentId = c.String(maxLength: 10),
						Description = c.String(storeType: "ntext"),
						CreatedDate = c.DateTime(false)
					})
				.PrimaryKey(t => t.ViolationId)
				.ForeignKey("dbo.Employees", t => t.EmployeeId)
				.ForeignKey("dbo.Students", t => t.StudentId)
				.Index(t => t.EmployeeId)
				.Index(t => t.StudentId);

			CreateTable(
					"dbo.PriorityTarget",
					c => new
					{
						PriorityId = c.String(false, 10),
						StudentId = c.String(false, 10)
					})
				.PrimaryKey(t => new {t.PriorityId, t.StudentId})
				.ForeignKey("dbo.Priorities", t => t.PriorityId, true)
				.ForeignKey("dbo.Students", t => t.StudentId, true)
				.Index(t => t.PriorityId)
				.Index(t => t.StudentId);

			CreateTable(
					"dbo.AttendanceDetail",
					c => new
					{
						AttendanceId = c.String(false, 10),
						StudentId = c.String(false, 10)
					})
				.PrimaryKey(t => new {t.AttendanceId, t.StudentId})
				.ForeignKey("dbo.Attendance", t => t.AttendanceId, true)
				.ForeignKey("dbo.Students", t => t.StudentId, true)
				.Index(t => t.AttendanceId)
				.Index(t => t.StudentId);
		}

		public override void Down()
		{
			DropForeignKey("dbo.AttendanceDetail", "StudentId", "dbo.Students");
			DropForeignKey("dbo.AttendanceDetail", "AttendanceId", "dbo.Attendance");
			DropForeignKey("dbo.ParkingDetails", "EmployeeId", "dbo.Employees");
			DropForeignKey("dbo.LeaseDetails", "EmployeeId", "dbo.Employees");
			DropForeignKey("dbo.ViolationRecord", "StudentId", "dbo.Students");
			DropForeignKey("dbo.ViolationRecord", "EmployeeId", "dbo.Employees");
			DropForeignKey("dbo.TemporaryAbsences", "StudentId", "dbo.Students");
			DropForeignKey("dbo.TemporaryAbsences", "EmployeeId", "dbo.Employees");
			DropForeignKey("dbo.Students", "RoomId", "dbo.Rooms");
			DropForeignKey("dbo.Rooms", "FloorId", "dbo.Floors");
			DropForeignKey("dbo.Floors", "BuildingId", "dbo.Buildings");
			DropForeignKey("dbo.PriorityTarget", "StudentId", "dbo.Students");
			DropForeignKey("dbo.PriorityTarget", "PriorityId", "dbo.Priorities");
			DropForeignKey("dbo.ParkingTickets", "StudentId", "dbo.Students");
			DropForeignKey("dbo.ParkingDetails", "TicketId", "dbo.ParkingTickets");
			DropForeignKey("dbo.LeaseContracts", "StudentId", "dbo.Students");
			DropForeignKey("dbo.LateArrivalInfo", "StudentId", "dbo.Students");
			DropForeignKey("dbo.Students", "ClubId", "dbo.Clubs");
			DropForeignKey("dbo.Students", "ClassId", "dbo.Classes");
			DropForeignKey("dbo.Classes", "FacultyId", "dbo.Faculties");
			DropForeignKey("dbo.Carer", "StudentId", "dbo.Students");
			DropForeignKey("dbo.LeaseDetails", "ContractId", "dbo.LeaseContracts");
			DropForeignKey("dbo.Attendance", "EmployeeId", "dbo.Employees");
			DropIndex("dbo.AttendanceDetail", new[] {"StudentId"});
			DropIndex("dbo.AttendanceDetail", new[] {"AttendanceId"});
			DropIndex("dbo.PriorityTarget", new[] {"StudentId"});
			DropIndex("dbo.PriorityTarget", new[] {"PriorityId"});
			DropIndex("dbo.ViolationRecord", new[] {"StudentId"});
			DropIndex("dbo.ViolationRecord", new[] {"EmployeeId"});
			DropIndex("dbo.TemporaryAbsences", new[] {"StudentId"});
			DropIndex("dbo.TemporaryAbsences", new[] {"EmployeeId"});
			DropIndex("dbo.Floors", new[] {"BuildingId"});
			DropIndex("dbo.Rooms", new[] {"FloorId"});
			DropIndex("dbo.ParkingDetails", new[] {"EmployeeId"});
			DropIndex("dbo.ParkingDetails", new[] {"TicketId"});
			DropIndex("dbo.ParkingTickets", new[] {"StudentId"});
			DropIndex("dbo.LateArrivalInfo", new[] {"StudentId"});
			DropIndex("dbo.Classes", new[] {"FacultyId"});
			DropIndex("dbo.Carer", new[] {"StudentId"});
			DropIndex("dbo.Students", new[] {"RoomId"});
			DropIndex("dbo.Students", new[] {"ClassId"});
			DropIndex("dbo.Students", new[] {"ClubId"});
			DropIndex("dbo.LeaseContracts", new[] {"StudentId"});
			DropIndex("dbo.LeaseDetails", new[] {"ContractId"});
			DropIndex("dbo.LeaseDetails", new[] {"EmployeeId"});
			DropIndex("dbo.Attendance", new[] {"EmployeeId"});
			DropTable("dbo.AttendanceDetail");
			DropTable("dbo.PriorityTarget");
			DropTable("dbo.ViolationRecord");
			DropTable("dbo.TemporaryAbsences");
			DropTable("dbo.Buildings");
			DropTable("dbo.Floors");
			DropTable("dbo.Rooms");
			DropTable("dbo.Priorities");
			DropTable("dbo.ParkingDetails");
			DropTable("dbo.ParkingTickets");
			DropTable("dbo.LateArrivalInfo");
			DropTable("dbo.Clubs");
			DropTable("dbo.Faculties");
			DropTable("dbo.Classes");
			DropTable("dbo.Carer");
			DropTable("dbo.Students");
			DropTable("dbo.LeaseContracts");
			DropTable("dbo.LeaseDetails");
			DropTable("dbo.Employees");
			DropTable("dbo.Attendance");
		}
	}
}