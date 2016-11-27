using NUnit.Framework;
using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
	[TestFixture()]
	public class RoomBusinessTests
	{
		public RoomBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[TestCase("H1")]
		[TestCase("H2")]
		[TestCase("H3")]
		[TestCase("H4")]
		[TestCase("H5")]
		[TestCase("I1")]
		[TestCase("I2")]
		[TestCase("I3")]
		[TestCase("I4")]
		[TestCase("I5")]
		public void GetRoomsByFloorIDTest(string floorID)
		{
			var actual = RoomBusiness.GetRoomsByFloorID(floorID);
			Assert.AreEqual(16, actual.Count);
		}
	}
}