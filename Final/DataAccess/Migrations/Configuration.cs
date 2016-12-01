using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using DataAccess.Domain;
using DataTransfer;

namespace DataAccess.Migrations
{
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
				Exec(context.Rooms);
				Exec(context.Floors);
				Exec(context.Buildings);
				Exec(context.Priorities);
				Exec(context.Students);
				Exec(context.Classes);
				Exec(context.Faculties);
				Exec(context.Clubs);
				Exec(context.Employees);
				context.SaveChanges();
			}
		}
	}

	internal sealed class Configuration : DbMigrationsConfiguration<DormitoryContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(DormitoryContext context)
		{
			DbClear.ClearAllData();
			//System.Diagnostics.Debugger.Launch();

			#region Add Buildings, Floors, Rooms

			var buildingList = new List<Building>
			{
				new Building {BuildingId = BuildingName.H.ToString()},
				new Building {BuildingId = BuildingName.I.ToString()}
			};

			var floorList = new List<Floor>();
			var roomList = new List<Room>();

			for (var k = 0; k < 2; k++)
			{
				for (var i = 1; i <= 10; i++)
				{
					floorList.Add(new Floor
					{
						FloorId = buildingList[k].BuildingId + i
					});
					for (var j = 1; j <= 16; j++)
					{
						var temp = j.ToString();
						if (j < 10)
						{
							temp = "0" + j;
						}
						var roomId = floorList[i - 1].FloorId + temp;
						roomList.Add(new Room {RoomId = roomId});
					}
					floorList[i - 1].Rooms = roomList;
					roomList = new List<Room>();
				}
				buildingList[k].Floors = floorList;
				floorList = new List<Floor>();
			}
			context.Buildings.AddOrUpdate(x => x.BuildingId, buildingList[(int) BuildingName.H]);
			context.Buildings.AddOrUpdate(x => x.BuildingId, buildingList[(int) BuildingName.I]);

			#endregion

			#region Clubs

			var clubList = new List<Club>
			{
				new Club {ClubId = "01", Name = "Bơi lội"},
				new Club {ClubId = "02", Name = "Bóng rổ"},
				new Club {ClubId = "03", Name = "Bóng đá"},
				new Club {ClubId = "04", Name = "Bóng chuyền"},
				new Club {ClubId = "05", Name = "Tennis"},
				new Club {ClubId = "06", Name = "Cầu lông"},
				new Club {ClubId = "07", Name = "Bóng bàn"},
				new Club {ClubId = "08", Name = "Taekwondo"},
				new Club {ClubId = "09", Name = "Karatedo"},
				new Club {ClubId = "10", Name = "Judo"},
				new Club {ClubId = "11", Name = "Muay Thái"},
				new Club {ClubId = "12", Name = "Vovinam"},
				new Club {ClubId = "13", Name = "Boxing"},
				new Club {ClubId = "14", Name = "Võ cổ truyền"},
				new Club {ClubId = "15", Name = "Bida"},
				new Club {ClubId = "16", Name = "Chạy bộ"},
				new Club {ClubId = "17", Name = "Yoga"},
				new Club {ClubId = "18", Name = "Street workout"},
				new Club {ClubId = "19", Name = "Cheerleading"},
				new Club {ClubId = "20", Name = "GYM"}
			};
			clubList.ForEach(c => context.Clubs.AddOrUpdate(x => x.ClubId, c));

			#endregion

			var priorityList = new List<Priority>
			{
				new Priority
				{
					PriorityId = "P1",
					Content = "Bản thân là anh hùng lực lượng vũ trang, anh hùng lao động, thương binh, bệnh binh"
				},
				new Priority
				{
					PriorityId = "P2",
					Content = "Là con của Anh hùng lực lượng vũ trang, Anh hùng lao động"
				},
				new Priority
				{
					PriorityId = "P3",
					Content = "Con liệt sĩ, con thương binh, bệnh binh"
				},
				new Priority
				{
					PriorityId = "P4",
					Content = "Con đẻ của những người hoạt động kháng chiến bị nhiễm chất độc hoá học"
				},
				new Priority
				{
					PriorityId = "P5",
					Content = "Là người dân tộc thiểu số, có bố hoặc mẹ là người dân tộc thiểu số"
				}
			};
			//priorityList.ForEach(p => context.Priorities.AddOrUpdate(p));
			priorityList.ForEach(p => context.Priorities.Attach(p));

			#region Add Faculties, Classes, Students

			var students1 = new List<Student>
			{
				new Student
				{
					StudentId = "51403001",
					ClubId = clubList[0].ClubId,
					Name = "Neptune",
					Gender = Gender.Male.ToString(),
					Address = "TDT",
					Priorities = priorityList
				},
				new Student
				{
					StudentId = "51403002",
					ClubId = clubList[0].ClubId,
					Name = "Neptune",
					Gender = Gender.Male.ToString(),
					Priorities = priorityList
				},
				new Student
				{
					StudentId = "51403003",
					ClubId = clubList[0].ClubId,
					Name = "Neptune",
					Gender = Gender.Female.ToString(),
					Priorities = priorityList
				},
				new Student
				{
					StudentId = "51403004",
					ClubId = clubList[0].ClubId,
					Name = "Neptune",
					Gender = Gender.Male.ToString(),
					Priorities = priorityList
				}
			};
			////////////////////////////////////////////////////////////////////
			var students2 = new List<Student>
			{
				new Student
				{
					StudentId = "51403101",
					ClubId = clubList[1].ClubId,
					Name = "Neptune",
					Gender = Gender.Male.ToString(),
					Address = "TDT"
				},
				new Student
				{
					StudentId = "51403102",
					ClubId = clubList[1].ClubId,
					Name = "Neptune",
					Gender = Gender.Male.ToString(),
					Priorities = priorityList
				},
				new Student
				{
					StudentId = "51403103",
					ClubId = clubList[1].ClubId,
					Name = "Neptune",
					Gender = Gender.Male.ToString()
				},
				new Student
				{
					StudentId = "51403104",
					ClubId = clubList[2].ClubId,
					Name = "Neptune",
					Gender = Gender.Female.ToString()
				}
			};
			////////////////////////////////
			var students3 = new List<Student>
			{
				new Student
				{
					StudentId = "51403201",
					ClubId = clubList[3].ClubId,
					Name = "Neptune",
					Gender = Gender.Male.ToString(),
					Address = "TDT"
				},
				new Student
				{
					StudentId = "51403202",
					ClubId = clubList[3].ClubId,
					Name = "Neptune",
					Gender = Gender.Male.ToString(),
					Priorities = priorityList
				},
				new Student
				{
					StudentId = "51403203",
					ClubId = clubList[3].ClubId,
					Name = "Neptune",
					Gender = Gender.Male.ToString()
				},
				new Student
				{
					StudentId = "51403204",
					ClubId = clubList[3].ClubId,
					Name = "Neptune",
					Gender = Gender.Female.ToString()
				}
			};

			var classes = new List<Class>
			{
				new Class
				{
					ClassId = "14050301",
					Students = students1
				},
				new Class
				{
					ClassId = "14050302",
					Students = students2
				},
				new Class
				{
					ClassId = "14050303",
					Students = students3
				}
			};

			var facultyList = new List<Faculty>
			{
				new Faculty
				{
					FacultyId = "5",
					Name = "Công nghệ thông tin",
					Classes = classes
				},
				new Faculty
				{
					FacultyId = "4",
					Name = "Điện"
				}
			};
			facultyList.ForEach(f => context.Faculties.AddOrUpdate(x => x.FacultyId, f));

			#endregion

			var employee = new Employee
			{
				EmployeeId = "1",
				Username = "1",
				Password = "1",
				DateOfBirth = new DateTime(2016, 1, 1),
				Phone = 123
			};
			context.Employees.AddOrUpdate(x => x.EmployeeId, employee);
		}
	}
}