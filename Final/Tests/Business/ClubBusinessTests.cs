using Business;
using DataAccess;
using DataAccess.Domain;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Tests.Business{
	[TestFixture()]
	public class ClubBusinessTests
	{
		private Mock<IDormitoryContext> mockContext;

		public ClubBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[SetUp()]
		public void SetUp()
		{
			mockContext = new Mock<IDormitoryContext>();
		}

		[Test()]
		public void GetAllClubTest_ShouldReturnTwoClubs()
		{
			var data = new List<Club>()
			{
				new Club()
				{
					ClubId = "1",
					Name = "Pro"
				},
				new Club()
				{
					ClubId = "2",
					Name = "Gosu"
				},
				new Club()
				{
					ClubId = "2",
					Name = "Noob"
				}
			};

			mockContext.SetupProperty(m => m.Clubs, new FakeDbSet<Club>(data));

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