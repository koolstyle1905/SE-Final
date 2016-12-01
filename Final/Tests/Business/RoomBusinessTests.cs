using System.Collections;
using System.Collections.Generic;
using Business;
using DataAccess;
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
			mockContext = new Mock<DormitoryContext>();
		}

		private Mock<DormitoryContext> mockContext;

		public RoomBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		private static IEnumerable TestData()
		{
			var testData = new TestCaseData(new List<Room>
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
			});
			yield return testData;
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void GetRoomsByFloorIdTest_ShouldReturnTwoRooms(List<Room> testData)
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

			mockContext.Setup(m => m.Rooms).Returns(new FakeDbSet<Room>(testData));

			var roomBusiness = new RoomBusiness(mockContext.Object);
			var actual = roomBusiness.GetRoomsByFloorId("H1");

			for (var i = 0; i < expected.Count; i++)
			{
				Assert.AreEqual(expected[i].RoomId, actual[i].RoomId);
			}
			Assert.AreEqual(expected.Count, actual.Count);
		}
	}
}