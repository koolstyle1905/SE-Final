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

			var buildings = new List<Building>();
			buildings.Add(new Building()
			{
				BuildingID = BuildingName.G.ToString()
			});
			buildings.Add(new Building()
			{
				BuildingID = BuildingName.H.ToString()
			});
			var floors = new List<Floor>();
			var rooms = new List<Room>();
			var roomId = string.Empty;
			var temp = string.Empty;
			for (int i = 0; i < 2; i++)
			{
				for (int j = 1; j <= 10; j++)
				{
					floors.Add(new Floor()
					{
						FloorID = buildings[i].BuildingID + j.ToString(),
						Building = buildings[i]
					});
					for (int k = 1; k <= 16; k++)
					{
						if (k < 10)
						{
							temp = "0" + k.ToString();
						}
						else
						{
							temp = k.ToString();
						}
						roomId = floors[i * 10 + j - 1].FloorID.ToString() + temp;
						rooms.Add(new Room() { RoomID = roomId, Floor = floors[i * 10 + j - 1] });
					}
				}
			}
			rooms.ForEach(r => context.Rooms.AddOrUpdate(x => x.RoomID, r));

			var clubs = new List<Club>();
			clubs.Add(new Club() { ClubID = "1", Name = "Bơi lội" });
			clubs.Add(new Club() { ClubID = "2", Name = "Bóng rổ" });
			clubs.Add(new Club() { ClubID = "3", Name = "Bóng đá" });
			clubs.Add(new Club() { ClubID = "4", Name = "Bóng chuyền" });
			clubs.Add(new Club() { ClubID = "5", Name = "Tennis" });
			clubs.Add(new Club() { ClubID = "6", Name = "Cầu lông" });
			clubs.Add(new Club() { ClubID = "7", Name = "Bóng bàn" });
			clubs.Add(new Club() { ClubID = "8", Name = "Taekwondo" });
			clubs.Add(new Club() { ClubID = "9", Name = "Karatedo" });
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
