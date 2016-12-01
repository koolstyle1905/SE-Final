using DataAccess.Domain;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Business;
using Business.Business;
using DataAccess;
using Moq;

namespace Tests.Business
{
	[TestFixture()]
	public class ClubBusinessTests
	{
		private readonly Mock<IDormitoryContext> mockContext;

		public ClubBusinessTests()
		{
			AutoMapperConfiguration.Configure();
			mockContext = new Mock<IDormitoryContext>();
		}

		[SetUp()]
		public void SetUp()
		{
			
		}

		[Test()]
		public void GetAllTest_ShouldReturnTwoClubs()
		{
			var data = new List<Club>()
			{
				new Club()
				{
					ClubId = "1",
					Name = "Neptune"
				},
				new Club()
				{
					ClubId = "2",
					Name = "Oil"
				}
			};

			mockContext.SetupProperty(m => m.Clubs, new FakeDbSet<Club>(data));

			var clubBusiness = new ClubBusiness(mockContext.Object);
			var actual = clubBusiness.GetAll();

			Assert.AreEqual("1", actual[0].ClubId);
			Assert.AreEqual("Neptune", actual[0].Name);
			Assert.AreEqual("2", actual[1].ClubId);
			Assert.AreEqual("Oil", actual[1].Name);
			Assert.AreEqual(2, actual.Count);
		}
	}
}