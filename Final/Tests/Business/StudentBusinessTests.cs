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
		public void GetAllTest()
		{
			var actual = StudentBusiness.GetAll().Count;

			Assert.AreEqual(12, actual);
		}
	}
}