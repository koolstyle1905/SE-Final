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
	public class ClubBusinessTests
	{
		[SetUp]
		public void SetUp()
		{
			testDataCLubs = new List<Club>
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
					ClubId = "3",
					Name = "Noob"
				}
			};
			mockUnitOfWork = new Mock<IUnitOfWork>();
			mockUnitOfWork.Setup(m => m.Clubs).Returns(new FakeClubRepository(testDataCLubs));
		}

		private Mock<IUnitOfWork> mockUnitOfWork;
		private List<Club> testDataCLubs;

		public ClubBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		public void GetAllClubTest_ShouldReturnThreeClubs()
		{
			var expected = new List<ClubDto>
			{
				new ClubDto
				{
					ClubId = "1",
					Name = "Pro"
				},
				new ClubDto
				{
					ClubId = "2",
					Name = "Gosu"
				},
				new ClubDto
				{
					ClubId = "3",
					Name = "Noob"
				}
			};

			var clubBusiness = new ClubBusiness(mockUnitOfWork.Object);
			var actual = clubBusiness.GetAll();

			for (var i = 0; i < expected.Count; i++)
			{
				Assert.AreEqual(expected[i].ClubId, actual[i].ClubId);
				Assert.AreEqual(expected[i].Name, actual[i].Name);
			}
		}
	}
}