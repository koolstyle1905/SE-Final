using System.Collections;
using System.Collections.Generic;
using Business;
using DataAccess;
using DataAccess.Core;
using DataAccess.Domain;
using DataTransfer;
using Moq;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class RoomBusinessTests
	{
		[SetUp]
		public void SetUp()
		{
			testDataRooms = new List<Room>
			{
				new Room
				{
					RoomId = "H101",
					FloorId = "H1"
				},
				new Room
				{
					RoomId = "H102",
					FloorId = "H1"
				},
				new Room
				{
					RoomId = "H201",
					FloorId = "H2"
				}
			};

			mockUnitOfWork = new Mock<IUnitOfWork>();
			mockUnitOfWork.Setup(m => m.Rooms).Returns(new FakeRoomRepository(testDataRooms));
		}

		private Mock<IUnitOfWork> mockUnitOfWork;
		private List<Room> testDataRooms;
		public RoomBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		public void GetRoomsByFloorIdTest_ShouldReturnTwoRooms()
		{
			var expected = new List<RoomDto>
			{
				new RoomDto
				{
					RoomId = "H101",
					FloorId = "H1"
				},
				new RoomDto
				{
					RoomId = "H102",
					FloorId = "H1"
				}
			};

			var roomBusiness = new RoomBusiness(mockUnitOfWork.Object);
			var actual = roomBusiness.GetRoomsByFloorId("H1");

			for (var i = 0; i < expected.Count; i++)
			{
				Assert.AreEqual(expected[i].RoomId, actual[i].RoomId);
			}
			Assert.AreEqual(expected.Count, actual.Count);
		}
	}
}