namespace DataAccess.Migrations
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using DataTransfer;
	using Domain;

	internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.DormitoryContext>
	{
		public Configuration()
		{
			this.AutomaticMigrationsEnabled = true;
			this.AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(DataAccess.DormitoryContext context)
		{
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
