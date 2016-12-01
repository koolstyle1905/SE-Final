using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Business;
using Business.Business;
using DataAccess;
using DataAccess.Domain;
using Moq;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture()]
	public class RoomBusinessTests
	{
		private readonly Mock<IDormitoryContext> mockContext;

		public RoomBusinessTests()
		{
			AutoMapperConfiguration.Configure();
			mockContext = new Mock<IDormitoryContext>();
		}
		
		[SetUp()]
		public void SetUp()
		{
			
		}

		[Test()]
		public void GetRoomsByFloorIdTest_ShouldReturnTwoRooms()
		{
			var data = new List<Room>()
			{
				new Room()
				{
					RoomId = "H101",
					FloorId = "H1"
				},
				new Room()
				{
					RoomId = "H102",
					FloorId = "H1"
				},
				new Room()
				{
					RoomId = "H201",
					FloorId = "H2"
				}
			};
			mockContext.SetupProperty(m => m.Rooms, new FakeDbSet<Room>(data));

			var roomBusiness = new RoomBusiness(mockContext.Object);
			var actual = roomBusiness.GetRoomsByFloorId("H1");

			Assert.AreEqual("H101", actual[0].RoomId);
			Assert.AreEqual("H102", actual[1].RoomId);
			Assert.AreEqual(2, actual.Count);
		}
	}
}