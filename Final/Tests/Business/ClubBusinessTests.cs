using Business;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class ClubBusinessTests
	{
		public ClubBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		public void GetAllTest()
		{
			var actual = ClubBusiness.GetAll().Count;

			Assert.AreEqual(20, actual);
		}
	}
}