using Business;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class RoomBusinessTests
	{
		public RoomBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		[TestCase("H1")]
		[TestCase("H2")]
		[TestCase("H3")]
		[TestCase("H4")]
		[TestCase("H5")]
		[TestCase("H6")]
		[TestCase("H7")]
		[TestCase("H8")]
		[TestCase("H9")]
		[TestCase("H10")]
		[TestCase("I1")]
		[TestCase("I2")]
		[TestCase("I3")]
		[TestCase("I4")]
		[TestCase("I5")]
		[TestCase("I6")]
		[TestCase("I7")]
		[TestCase("I8")]
		[TestCase("I9")]
		[TestCase("I10")]
		public void GetRoomsByFloorIdTest(string floorId)
		{
			var actual = RoomBusiness.GetRoomsByFloorId(floorId).Count;

			Assert.AreEqual(16, actual);
		}
	}
}