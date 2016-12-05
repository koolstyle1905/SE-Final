using Business;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class ClassBusinessTests
	{
		public ClassBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		public void GetClassByFacultyIdTest()
		{
			var actual = ClassBusiness.GetClassByFacultyId("5");

			Assert.AreEqual("14050301", actual[0].ClassId);
			Assert.AreEqual("14050302", actual[1].ClassId);
			Assert.AreEqual("14050303", actual[2].ClassId);
		}
	}
}