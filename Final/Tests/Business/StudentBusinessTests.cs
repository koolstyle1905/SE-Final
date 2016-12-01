using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using Business;
using DataAccess;
using DataAccess.Domain;
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
		}

		private Mock<DormitoryContext> mockContext;

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
			var mockDbset = new Mock<DbSet<Student>>();
			mockContext.Setup(m => m.Students).Returns(mockDbset.Object);

			var studentBusiness = new StudentBusiness(mockContext.Object);
			studentBusiness.AddStudent(new StudentDto {StudentId = "1"});

			mockDbset.Verify(m => m.Add(It.IsAny<Student>()), Times.Once);
			mockContext.Verify(m => m.SaveChanges(), Times.Once());
		}

		[Test]
		public void EditStudentTest()
		{
			mockContext.Setup(m => m.Students).Returns(new FakeDbSet<Student>());

			var studentBusiness = new StudentBusiness(mockContext.Object);
			studentBusiness.EditStudent(new StudentDto {StudentId = "1"});

			mockContext.Verify(m => m.SetModified(It.IsAny<Student>()), Times.Once());
			mockContext.Verify(m => m.SaveChanges(), Times.Once());
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

			mockContext.Setup(m => m.Students).Returns(new FakeDbSet<Student>(testData));

			var studentBusiness = new StudentBusiness(mockContext.Object);
			var actual = studentBusiness.GetAll();

			for (var i = 0; i < expected.Count; i++)
			{
				Assert.AreEqual(expected[i].StudentId, actual[i].StudentId);
			}
			Assert.AreEqual(expected.Count, actual.Count);
		}
	}
}