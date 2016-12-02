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
		public void GetRoomsByFloorIdTest(string floorId)
		{
			var actual = RoomBusiness.GetRoomsByFloorId(floorId).Count;

			Assert.AreEqual(16, actual);
		}
	}
}