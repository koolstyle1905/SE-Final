using System.Collections;
using System.Collections.Generic;
using Business;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;
using Moq;
using NUnit.Framework;

namespace Tests.Business
{
	[TestFixture]
	public class EmployeeBusinessTests
	{
		[SetUp]
		public void SetUp()
		{
			mockContext = new Mock<DormitoryContext>();
		}

		private Mock<DormitoryContext> mockContext;

		public EmployeeBusinessTests()
		{
			AutoMapperConfiguration.Configure();
		}

		private static IEnumerable TestData()
		{
			var testData = new TestCaseData(new List<Employee>
			{
				new Employee
				{
					EmployeeId = "1",
					Username = "2",
					Password = "3"
				}
			});
			yield return testData;
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void IsValidTest_ShouldReturnTrue(List<Employee> testData)
		{
			mockContext.Setup(m => m.Employees).Returns(new FakeDbSet<Employee>(testData));

			var employeeBusiness = new EmployeeBusiness(mockContext.Object);
			var actual = employeeBusiness.IsValid("2", "3");

			Assert.IsTrue(actual);
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void GetEmployeeTest(List<Employee> testData)
		{
			var expected = new EmployeeDto()
			{
				EmployeeId = "1",
				Username = "2",
				Password = "3"
			};

			mockContext.Setup(m => m.Employees).Returns(new FakeDbSet<Employee>(testData));

			var employeeBusiness = new EmployeeBusiness(mockContext.Object);
			var actual = employeeBusiness.GetEmployee(expected.EmployeeId);

			Assert.AreEqual(expected.EmployeeId, actual.EmployeeId);
			Assert.AreEqual(expected.Username, actual.Username);
			Assert.AreEqual(expected.Password, actual.Password);
		}
	}
}