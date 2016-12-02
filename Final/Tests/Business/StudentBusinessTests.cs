using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using Business;
using DataAccess;
using DataAccess.Core;
using DataAccess.Domain;
using DataAccess.Repositories;
using DataTransfer;
using Moq;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class StudentBusinessTests
	{
		[SetUp]
		public void SetUp()
		{
			testDataStudents = new List<Student>
			{
				new Student
				{
					StudentId = "1"
				},
				new Student
				{
					StudentId = "2"
				}
			};
			mockUnitOfWork = new Mock<IUnitOfWork>();
			mockUnitOfWork.Setup(m => m.Students).Returns(new FakeStudentRepository(testDataStudents));
		}

		private Mock<IUnitOfWork> mockUnitOfWork;
		private List<Student> testDataStudents;

		public StudentBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[Test]
		public void AddStudentTest()
		{
			var studentBusiness = new StudentBusiness(mockUnitOfWork.Object);
			studentBusiness.AddStudent(new StudentDto { StudentId = "1" });

			mockUnitOfWork.Verify(m => m.SaveChanges(), Times.Once());
		}

		[Test]
		public void EditStudentTest()
		{
			var studentBusiness = new StudentBusiness(mockUnitOfWork.Object);
			studentBusiness.EditStudent(new StudentDto {StudentId = "1"});

			mockUnitOfWork.Verify(m => m.SaveChanges(), Times.Once());
		}

		[Test]
		public void GetAllStudentTest_ShouldReturnTwoStudents()
		{
			var expected = new List<StudentDto>
			{
				new StudentDto
				{
					StudentId = "1"
				},
				new StudentDto
				{
					StudentId = "2"
				}
			};

			var studentBusiness = new StudentBusiness(mockUnitOfWork.Object);
			var actual = studentBusiness.GetAll();

			for (var i = 0; i < expected.Count; i++)
			{
				Assert.AreEqual(expected[i].StudentId, actual[i].StudentId);
			}
			Assert.AreEqual(expected.Count, actual.Count);
		}
	}
}