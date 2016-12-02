using Business;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class EmployeeBusinessTests
	{
		public EmployeeBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		public void GetEmployeeTest()
		{
			var actual = EmployeeBusiness.GetEmployee("1");

			Assert.AreEqual("1", actual.EmployeeId);
		}

		[Test]
		public void IsValidTest()
		{
			var actual = EmployeeBusiness.IsValid("1", "1");

			Assert.IsTrue(actual);
		}
	}
}