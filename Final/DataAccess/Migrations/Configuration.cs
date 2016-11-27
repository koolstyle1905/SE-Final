namespace DataAccess.Migrations
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using DataTransfer;
	using Domain;

	public static class DbClear
	{
		private static void Exec<T>(this DbSet<T> dbSet) where T : class
		{
			dbSet.RemoveRange(dbSet);
		}

		public static void ClearAllData()
		{
			using (var context = new DormitoryContext())
			{
				DbClear.Exec(context.Rooms);
				DbClear.Exec(context.Floors);
				DbClear.Exec(context.Buildings);
				DbClear.Exec(context.Students);
				DbClear.Exec(context.Classes);
				DbClear.Exec(context.Faculties);
				DbClear.Exec(context.Clubs);
				DbClear.Exec(context.Employees);
				context.SaveChanges();
			}
		}
	}

	internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.DormitoryContext>
	{
		public Configuration()
		{
			this.AutomaticMigrationsEnabled = true;
			this.AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(DataAccess.DormitoryContext context)
		{
			//DbClear.ClearAllData();
			//System.Diagnostics.Debugger.Launch();
			#region Add Buildings, Floors, Rooms
			var buildings = new List<Building>();
			buildings.Add(new Building() { BuildingID = BuildingName.H.ToString() });
			buildings.Add(new Building() { BuildingID = BuildingName.I.ToString() });

			var floors = new List<Floor>();
			var rooms = new List<Room>();
			var roomId = string.Empty;
			var temp = string.Empty;

			for (int k = 0; k < 2; k++)
			{
				for (int i = 1; i <= 10; i++)
				{
					floors.Add(new Floor()
					{
						FloorID = buildings[k].BuildingID + i.ToString(),
					});
					for (int j = 1; j <= 16; j++)
					{
						temp = j.ToString();
						if (j < 10)
						{
							temp = "0" + j.ToString();
						}
						roomId = floors[i - 1].FloorID.ToString() + temp;
						rooms.Add(new Room() { RoomID = roomId });
					}
					floors[i - 1].Rooms = rooms;
					rooms = new List<Room>();
				}
				buildings[k].Floors = floors;
				floors = new List<Floor>();
			}
			context.Buildings.AddOrUpdate(x => x.BuildingID, buildings[(int)BuildingName.H]);
			context.Buildings.AddOrUpdate(x => x.BuildingID, buildings[(int)BuildingName.I]);
			#endregion

			#region Clubs
			var clubs = new List<Club>();
			clubs.Add(new Club() { ClubID = "01", Name = "Bơi lội" });
			clubs.Add(new Club() { ClubID = "02", Name = "Bóng rổ" });
			clubs.Add(new Club() { ClubID = "03", Name = "Bóng đá" });
			clubs.Add(new Club() { ClubID = "04", Name = "Bóng chuyền" });
			clubs.Add(new Club() { ClubID = "05", Name = "Tennis" });
			clubs.Add(new Club() { ClubID = "06", Name = "Cầu lông" });
			clubs.Add(new Club() { ClubID = "07", Name = "Bóng bàn" });
			clubs.Add(new Club() { ClubID = "08", Name = "Taekwondo" });
			clubs.Add(new Club() { ClubID = "09", Name = "Karatedo" });
			clubs.Add(new Club() { ClubID = "10", Name = "Judo" });
			clubs.Add(new Club() { ClubID = "11", Name = "Muay Thái" });
			clubs.Add(new Club() { ClubID = "12", Name = "Vovinam" });
			clubs.Add(new Club() { ClubID = "13", Name = "Boxing" });
			clubs.Add(new Club() { ClubID = "14", Name = "Võ cổ truyền" });
			clubs.Add(new Club() { ClubID = "15", Name = "Bida" });
			clubs.Add(new Club() { ClubID = "16", Name = "Chạy bộ" });
			clubs.Add(new Club() { ClubID = "17", Name = "Yoga" });
			clubs.Add(new Club() { ClubID = "18", Name = "Street workout" });
			clubs.Add(new Club() { ClubID = "19", Name = "Cheerleading" });
			clubs.Add(new Club() { ClubID = "20", Name = "GYM" });
			clubs.ForEach(c => context.Clubs.AddOrUpdate(x => x.ClubID, c));
			#endregion

			var students1 = new List<Student>();
			students1.Add(new Student()
			{
				StudentID = "51403001",
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
				Address = "TDT",
			});
			students1.Add(new Student()
			{
				StudentID = "51403002",
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
			});
			students1.Add(new Student()
			{
				StudentID = "51403003",
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
			});
			students1.Add(new Student()
			{
				StudentID = "51403004",
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
			});
			////////////////////////////////////////////////////////////////////
			var students2 = new List<Student>();
			students2.Add(new Student()
			{
				StudentID = "51403101",
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
				Address = "TDT",
			});
			students2.Add(new Student()
			{
				StudentID = "51403102",
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
			});
			students2.Add(new Student()
			{
				StudentID = "51403103",
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
			});
			students2.Add(new Student()
			{
				StudentID = "51403104",
				Name = "Neptune",
				Gender = Gender.Female.ToString(),
			});
			////////////////////////////////
			var students3 = new List<Student>();
			students1.Add(new Student()
			{
				StudentID = "51403201",
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
				Address = "TDT",
			});
			students3.Add(new Student()
			{
				StudentID = "51403202",
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
			});
			students3.Add(new Student()
			{
				StudentID = "51403203",
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
			});
			students3.Add(new Student()
			{
				StudentID = "51403204",
				Name = "Neptune",
				Gender = Gender.Female.ToString(),
			});

			var classes = new List<Class>();
			classes.Add(new Class()
			{
				ClassID = "14050301",
				Students = students1
			});
			classes.Add(new Class()
			{
				ClassID = "14050302",
				Students = students2
			});
			classes.Add(new Class()
			{
				ClassID = "14050303",
				Students = students3
			});

			var faculties = new List<Faculty>();
			faculties.Add(new Faculty()
			{
				FacultyID = "5",
				Name = "Công nghệ thông tin",
				Classes = classes
			});
			faculties.Add(new Faculty()
			{
				FacultyID = "4",
				Name = "Điện"
			});
			faculties.ForEach(f => context.Faculties.AddOrUpdate(x => x.FacultyID, f));

			var employee = new Employee()
			{
				EmployeeID = "1",
				Username = "1",
				Password = "1",
				DateOfBirth = new DateTime(2016, 1, 1),
				Phone = 123
			};
			context.Employees.AddOrUpdate(x => x.EmployeeID, employee);
		}
	}
}
