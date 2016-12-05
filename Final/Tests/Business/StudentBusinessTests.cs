using Business;
using DataTransfer;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class StudentBusinessTests
	{
		public StudentBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		public void AddStudentTest()
		{
			var studentDto = new StudentDto
			{
				StudentId = "1"
			};
			StudentBusiness.AddStudent(studentDto);
			Assert.IsTrue(true);
		}

		[Test]
		public void EditStudentTest()
		{
			var studentDto = new StudentDto
			{
				StudentId = "1",
				Name = "Neptune"
			};
			StudentBusiness.EditStudent(studentDto);
			Assert.IsTrue(true);
		}

		[Test]
		public void GetAllTest_ShouldEqualTwelve()
		{
			var actual = StudentBusiness.GetAll().Count;

			Assert.AreEqual(12, actual);
		}

		[Test]
		[TestCase("S00001", "S00001")]
		[TestCase("S00002", "S00002")]
		public void GetStudentTest_TC1(string expected, string studentId)
		{
			var actual = StudentBusiness.GetStudent(studentId).StudentId;

			Assert.AreEqual(expected, actual);
		}

		[Test]
		[TestCase("69")]
		public void GetStudentTest_TC2(string studentId)
		{
			var actual = StudentBusiness.GetStudent(studentId);

			Assert.IsNull(actual);
		}
	}
}