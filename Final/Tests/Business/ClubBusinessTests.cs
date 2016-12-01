using System.Collections.Generic;
using Business;
using DataAccess;
using DataAccess.Domain;
using Moq;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class ClubBusinessTests
	{
		[SetUp]
		public void SetUp()
		{
			mockContext = new Mock<DormitoryContext>();
		}

		private Mock<DormitoryContext> mockContext;

		public ClubBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		public void GetAllClubTest_ShouldReturnTwoClubs()
		{
			var data = new List<Club>
			{
				new Club
				{
					ClubId = "1",
					Name = "Pro"
				},
				new Club
				{
					ClubId = "2",
					Name = "Gosu"
				},
				new Club
				{
					ClubId = "2",
					Name = "Noob"
				}
			};

			mockContext.Setup(m => m.Clubs).Returns(new FakeDbSet<Club>(data));

			var clubBusiness = new ClubBusiness(mockContext.Object);
			var actual = clubBusiness.GetAll();

			for (var i = 0; i < data.Count; i++)
			{
				Assert.AreEqual(data[i].ClubId, actual[i].ClubId);
				Assert.AreEqual(data[i].Name, actual[i].Name);
			}
		}
	}
}