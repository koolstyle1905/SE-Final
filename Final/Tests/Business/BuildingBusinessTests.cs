using Business;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class BuildingBusinessTests
	{
		public BuildingBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		public void GetAllTest()
		{
			var actual = BuildingBusiness.GetAll().Count;

			Assert.AreEqual(2, actual);
		}
	}
}