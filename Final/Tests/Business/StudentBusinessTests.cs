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
			mockContext = new Mock<DormitoryContext>();
			mockUnitOfWork = new Mock<IUnitOfWork>();
			mockContext.Setup(m => m.Students).Returns(new FakeDbSet<Student>());
			//mockUnitOfWork.Setup(m => m.Students).Returns(new StudentRepository(mockContext.Object));
			mockRepo = new Mock<IStudentRepository>();
			mockUnitOfWork.Setup(m => m.Students).Returns(mockRepo.Object);
		}

		private Mock<DormitoryContext> mockContext;
		private Mock<IUnitOfWork> mockUnitOfWork;
		private Mock<IStudentRepository> mockRepo;

		public StudentBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		private static IEnumerable TestData()
		{
			var testData = new TestCaseData(new List<Student>
			{
				new Student
				{
					StudentId = "1"
				},
				new Student
				{
					StudentId = "2"
				}
			});
			yield return testData;
		}

		[Test]
		public void AddStudentTest()
		{
			var studentBusiness = new StudentBusiness(mockUnitOfWork.Object);
			studentBusiness.AddStudent(new StudentDto { StudentId = "1" });

			mockRepo.Verify(m => m.Add(It.IsAny<Student>()), Times.Once);
			mockUnitOfWork.Verify(m => m.SaveChanges(), Times.Once());
		}

		[Test]
		public void EditStudentTest()
		{
			var studentBusiness = new StudentBusiness(mockUnitOfWork.Object);
			studentBusiness.EditStudent(new StudentDto {StudentId = "1"});

			mockRepo.Verify(m => m.Edit(It.IsAny<Student>()), Times.Once());
			mockUnitOfWork.Verify(m => m.SaveChanges(), Times.Once());
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void GetAllStudentTest_ShouldReturnTwoStudents(List<Student> testData)
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