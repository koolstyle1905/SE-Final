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
				DbClear.Exec(context.Priorities);
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
			DbClear.ClearAllData();
			//System.Diagnostics.Debugger.Launch();
			#region Add Buildings, Floors, Rooms
			var buildingList = new List<Building>();
			buildingList.Add(new Building() { BuildingID = BuildingName.H.ToString() });
			buildingList.Add(new Building() { BuildingID = BuildingName.I.ToString() });

			var floorList = new List<Floor>();
			var roomList = new List<Room>();
			var roomId = string.Empty;
			var temp = string.Empty;

			for (int k = 0; k < 2; k++)
			{
				for (int i = 1; i <= 10; i++)
				{
					floorList.Add(new Floor()
					{
						FloorID = buildingList[k].BuildingID + i.ToString(),
					});
					for (int j = 1; j <= 16; j++)
					{
						temp = j.ToString();
						if (j < 10)
						{
							temp = "0" + j.ToString();
						}
						roomId = floorList[i - 1].FloorID.ToString() + temp;
						roomList.Add(new Room() { RoomID = roomId });
					}
					floorList[i - 1].Rooms = roomList;
					roomList = new List<Room>();
				}
				buildingList[k].Floors = floorList;
				floorList = new List<Floor>();
			}
			context.Buildings.AddOrUpdate(x => x.BuildingID, buildingList[(int)BuildingName.H]);
			context.Buildings.AddOrUpdate(x => x.BuildingID, buildingList[(int)BuildingName.I]);
			#endregion

			#region Clubs
			var clubList = new List<Club>();
			clubList.Add(new Club() { ClubID = "01", Name = "Bơi lội" });
			clubList.Add(new Club() { ClubID = "02", Name = "Bóng rổ" });
			clubList.Add(new Club() { ClubID = "03", Name = "Bóng đá" });
			clubList.Add(new Club() { ClubID = "04", Name = "Bóng chuyền" });
			clubList.Add(new Club() { ClubID = "05", Name = "Tennis" });
			clubList.Add(new Club() { ClubID = "06", Name = "Cầu lông" });
			clubList.Add(new Club() { ClubID = "07", Name = "Bóng bàn" });
			clubList.Add(new Club() { ClubID = "08", Name = "Taekwondo" });
			clubList.Add(new Club() { ClubID = "09", Name = "Karatedo" });
			clubList.Add(new Club() { ClubID = "10", Name = "Judo" });
			clubList.Add(new Club() { ClubID = "11", Name = "Muay Thái" });
			clubList.Add(new Club() { ClubID = "12", Name = "Vovinam" });
			clubList.Add(new Club() { ClubID = "13", Name = "Boxing" });
			clubList.Add(new Club() { ClubID = "14", Name = "Võ cổ truyền" });
			clubList.Add(new Club() { ClubID = "15", Name = "Bida" });
			clubList.Add(new Club() { ClubID = "16", Name = "Chạy bộ" });
			clubList.Add(new Club() { ClubID = "17", Name = "Yoga" });
			clubList.Add(new Club() { ClubID = "18", Name = "Street workout" });
			clubList.Add(new Club() { ClubID = "19", Name = "Cheerleading" });
			clubList.Add(new Club() { ClubID = "20", Name = "GYM" });
			clubList.ForEach(c => context.Clubs.AddOrUpdate(x => x.ClubID, c));
			#endregion

			var priorityList = new List<Priority>();
			priorityList.Add(new Priority()
			{
				PriorityID = "P1",
				Content = "Bản thân là anh hùng lực lượng vũ trang, anh hùng lao động, thương binh, bệnh binh",
			});
			priorityList.Add(new Priority()
			{
				PriorityID = "P2",
				Content = "Là con của Anh hùng lực lượng vũ trang, Anh hùng lao động",
			});
			priorityList.Add(new Priority()
			{
				PriorityID = "P3",
				Content = "Con liệt sĩ, con thương binh, bệnh binh",
			});
			priorityList.Add(new Priority()
			{
				PriorityID = "P4",
				Content = "Con đẻ của những người hoạt động kháng chiến bị nhiễm chất độc hoá học"
			});
			priorityList.Add(new Priority()
			{
				PriorityID = "P5",
				Content = "Là người dân tộc thiểu số, có bố hoặc mẹ là người dân tộc thiểu số",
			});
			priorityList.ForEach(p => context.Priorities.AddOrUpdate(p));
			//priorities.ForEach(p => context.Priorities.Attach(p));

			#region Add Faculties, Classes, Students
			var students1 = new List<Student>();
			students1.Add(new Student()
			{
				StudentID = "51403001",
				ClubID = clubList[0].ClubID,
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
				Address = "TDT",
				Priorities = priorityList
			});
			students1.Add(new Student()
			{
				StudentID = "51403002",
				ClubID = clubList[0].ClubID,
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
				Priorities = priorityList
			});
			students1.Add(new Student()
			{
				StudentID = "51403003",
				ClubID = clubList[0].ClubID,
				Name = "Neptune",
				Gender = Gender.Female.ToString(),
				Priorities = priorityList
			});
			students1.Add(new Student()
			{
				StudentID = "51403004",
				ClubID = clubList[0].ClubID,
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
				Priorities = priorityList
			});
			////////////////////////////////////////////////////////////////////
			var students2 = new List<Student>();
			students2.Add(new Student()
			{
				StudentID = "51403101",
				ClubID = clubList[1].ClubID,
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
				Address = "TDT",
			});
			students2.Add(new Student()
			{
				StudentID = "51403102",
				ClubID = clubList[1].ClubID,
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
				Priorities = priorityList
			});
			students2.Add(new Student()
			{
				StudentID = "51403103",
				ClubID = clubList[1].ClubID,
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
			});
			students2.Add(new Student()
			{
				StudentID = "51403104",
				ClubID = clubList[2].ClubID,
				Name = "Neptune",
				Gender = Gender.Female.ToString(),
			});
			////////////////////////////////
			var students3 = new List<Student>();
			students1.Add(new Student()
			{
				StudentID = "51403201",
				ClubID = clubList[3].ClubID,
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
				Address = "TDT",
			});
			students3.Add(new Student()
			{
				StudentID = "51403202",
				ClubID = clubList[3].ClubID,
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
				Priorities = priorityList
			});
			students3.Add(new Student()
			{
				StudentID = "51403203",
				ClubID = clubList[3].ClubID,
				Name = "Neptune",
				Gender = Gender.Male.ToString(),
			});
			students3.Add(new Student()
			{
				StudentID = "51403204",
				ClubID = clubList[3].ClubID,
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

			var facultyList = new List<Faculty>();
			facultyList.Add(new Faculty()
			{
				FacultyID = "5",
				Name = "Công nghệ thông tin",
				Classes = classes
			});
			facultyList.Add(new Faculty()
			{
				FacultyID = "4",
				Name = "Điện"
			});
			facultyList.ForEach(f => context.Faculties.AddOrUpdate(x => x.FacultyID, f));
			#endregion




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
