using Business;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture()]
	public class FacultyBusinessTests
	{
		public FacultyBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}
		[Test()]
		public void GetAllTest()
		{
			var actual = FacultyBusiness.GetAll();

			Assert.AreEqual("4", actual[0].FacultyId);
			Assert.AreEqual("5", actual[1].FacultyId);
		}
	}
}