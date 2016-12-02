//using System.Collections;
//using System.Collections.Generic;
//using Business;
//using DataAccess;
//using DataAccess.Domain;
//using DataTransfer;
//using Moq;
//using NUnit.Framework;

//namespace Tests.Business
//{
//	[TestFixture]
//	public class ClubBusinessTests
//	{
//		[SetUp]
//		public void SetUp()
//		{
//			mockContext = new Mock<DormitoryContext>();
//		}

//		private Mock<DormitoryContext> mockContext;

//		public ClubBusinessTests()
//		{
//			AutoMapperConfiguration.Configure();
//		}

//		private static IEnumerable TestData()
//		{
//			var testData = new TestCaseData(new List<Club>
//			{
//				new Club
//				{
//					ClubId = "1",
//					Name = "Pro"
//				},
//				new Club
//				{
//					ClubId = "2",
//					Name = "Gosu"
//				},
//				new Club
//				{
//					ClubId = "3",
//					Name = "Noob"
//				}
//			});
//			yield return testData;
//		}

//		[Test]
//		[TestCaseSource(nameof(TestData))]
//		public void GetAllClubTest_ShouldReturnThreeClubs(List<Club> testData)
//		{
//			var expected = new List<ClubDto>
//			{
//				new ClubDto
//				{
//					ClubId = "1",
//					Name = "Pro"
//				},
//				new ClubDto
//				{
//					ClubId = "2",
//					Name = "Gosu"
//				},
//				new ClubDto
//				{
//					ClubId = "3",
//					Name = "Noob"
//				}
//			};

//			mockContext.Setup(m => m.Clubs).Returns(new FakeRepository<Club>(testData));

//			var clubBusiness = new ClubBusiness(mockContext.Object);
//			var actual = clubBusiness.GetAll();

//			for (var i = 0; i < expected.Count; i++)
//			{
//				Assert.AreEqual(expected[i].ClubId, actual[i].ClubId);
//				Assert.AreEqual(expected[i].Name, actual[i].Name);
//			}
//		}
//	}
//}