using Business;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class FloorBusinessTests
	{
		public FloorBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		[TestCase("H")]
		[TestCase("I")]
		public void GetFloorByBuildingIdTest(string buildingId)
		{
			var actual = FloorBusiness.GetFloorByBuildingId(buildingId).Count;

			Assert.AreEqual(10, actual);
		}
	}
}