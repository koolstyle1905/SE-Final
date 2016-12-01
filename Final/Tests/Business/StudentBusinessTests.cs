using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Business;
using Business.Business;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;
using Moq;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture()]
	public class StudentBusinessTests
	{
		private readonly Mock<IDormitoryContext> mockContext;

		public StudentBusinessTests()
		{
			AutoMapperConfiguration.Configure();
			mockContext = new Mock<IDormitoryContext>();
		}

		[SetUp()]
		public void SetUp()
		{
			
		}

		[Test()]
		public void GetAllStudentTest_ShouldReturnTwoStudents()
		{
			var data = new List<Student>()
			{
				new Student()
				{
					StudentId = "1",
				},
				new Student()
				{
					StudentId = "2"
				}
			};

			mockContext.SetupProperty(m => m.Students, new FakeDbSet<Student>(data));

			var studentBusiness = new StudentBusiness(mockContext.Object);
			var actual = studentBusiness.GetAll();

			Assert.AreEqual("1", actual[0].StudentId);
			Assert.AreEqual("2", actual[1].StudentId);
			Assert.AreEqual(2, actual.Count);
		}

		[Test()]
		public void AddStudentTest_ShouldNotThrowExeption()
		{
			mockContext.SetupProperty(m => m.Students, new FakeDbSet<Student>());

			var studentBusiness = new StudentBusiness(mockContext.Object);
			studentBusiness.AddStudent(new StudentDto() { StudentId = "1" });

			mockContext.Verify(m => m.SaveChanges(), Times.Once());
		}

		[Test()]
		public void EditStudentTest_ShouldNotThrowExeption()
		{
			mockContext.SetupProperty(m => m.Students, new FakeDbSet<Student>());

			var studentBusiness = new StudentBusiness(mockContext.Object);
			studentBusiness.EditStudent(new StudentDto() { StudentId = "1" });

			mockContext.Verify(m => m.SetModified(It.IsAny<Student>()), Times.Once());
			mockContext.Verify(m => m.SaveChanges(), Times.Once());
		}
	}
}