namespace Business.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Business;
	using NUnit.Framework;

	[TestFixture()]
	public class StudentBusinessTests
	{
		public StudentBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test()]
		public void GetAllTest()
		{
			var actual = StudentBusiness.GetAll();
			const int expected = 12;
			Assert.AreEqual(expected, actual.Count);
		}
	}
}