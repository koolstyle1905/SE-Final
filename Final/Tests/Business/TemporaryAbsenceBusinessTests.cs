using Business;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class TemporaryAbsenceBusinessTests
	{
		[Test]
		public void NextIdTest()
		{
			var actual = TemporaryAbsenceBusiness.NextId();

			Assert.AreEqual("T00001", actual);
		}
	}
}