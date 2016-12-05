using Business;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class UtilitiesTests
	{
		[Test]
		[TestCase("", "S00001")]
		[TestCase("S00001", "S00002")]
		[TestCase("S00001", "S00002")]
		[TestCase("S00002", "S00003")]
		[TestCase("S00003", "S00004")]
		[TestCase("S00004", "S00005")]
		public void NextIdTest(string lastId, string expected)
		{
			var actual = Utilities.NextId(lastId, "S");

			Assert.AreEqual(expected, actual);
		}
	}
}