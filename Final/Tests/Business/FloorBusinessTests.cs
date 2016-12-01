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
	public class FloorBusinessTests
	{
		[SetUp]
		public void SetUp()
		{
			mockContext = new Mock<DormitoryContext>();
		}

		private Mock<DormitoryContext> mockContext;

		public FloorBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		private static IEnumerable TestData()
		{
			var testData = new TestCaseData(new List<Floor>
			{
				new Floor
				{
					FloorId = "H2",
					BuildingId = "H"
				},
				new Floor
				{
					FloorId = "H1",
					BuildingId = "H"
				},
				new Floor
				{
					FloorId = "H4",
					BuildingId = "H"
				},
				new Floor
				{
					FloorId = "H3",
					BuildingId = "H"
				},
				new Floor
				{
					FloorId = "I1",
					BuildingId = "I"
				}
			});
			yield return testData;
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void GetAllOrderByIdTest_ShouldReturnOrderedList(List<Floor> testData)
		{
			var expected = new List<FloorDto>
			{
				new FloorDto
				{
					FloorId = "H1"
				},
				new FloorDto
				{
					FloorId = "H2"
				},
				new FloorDto
				{
					FloorId = "H3"
				},
				new FloorDto
				{
					FloorId = "H4"
				},
				new FloorDto
				{
					FloorId = "I1"
				}
			};

			mockContext.Setup(m => m.Floors).Returns(new FakeDbSet<Floor>(testData));

			var floorBusiness = new FloorBusiness(mockContext.Object);
			var actual = floorBusiness.GetAllOrderByFloorId();

			for (var i = 0; i < expected.Count; i++)
			{
				Assert.AreEqual(expected[i].FloorId, actual[i].FloorId);
			}
			Assert.AreEqual(expected.Count, actual.Count);
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void GetFloorByBuildingIdTest_ShouldReturnFourFloorsOrderedList(List<Floor> testData)
		{
			var expected = new List<FloorDto>
			{
				new FloorDto
				{
					FloorId = "H1",
					BuildingId = "H"
				},
				new FloorDto
				{
					FloorId = "H2",
					BuildingId = "H"
				},
				new FloorDto
				{
					FloorId = "H3",
					BuildingId = "H"
				},
				new FloorDto
				{
					FloorId = "H4",
					BuildingId = "H"
				}
			};

			mockContext.Setup(m => m.Floors).Returns(new FakeDbSet<Floor>(testData));

			var floorBusiness = new FloorBusiness(mockContext.Object);
			var actual = floorBusiness.GetFloorByBuildingIdOrderByFloorId("H");

			for (var i = 0; i < expected.Count; i++)
			{
				Assert.AreEqual(expected[i].FloorId, actual[i].FloorId);
			}
			Assert.AreEqual(expected.Count, actual.Count);
		}
	}
}