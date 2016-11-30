using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Domain;
using DataAccess.Repositories;
using NUnit.Framework;
using System.Data.Entity;
using Moq;

namespace DataAccess.Repositories.Tests
{
	[TestFixture()]
	public class StudentRepositoryTests
	{
		[Test()]
		public void StudentRepositoryTest()
		{


			var mockSet = new Mock<DbSet<Student>>();

			var mockContext = new Mock<DormitoryContext>();
			mockContext.Setup(m => m.Students).Returns(mockSet.Object);

			var repo = new StudentRepository(mockContext.Object);
			repo.Add(new Student { StudentId = "1", Name = "Sample Student" });
		
			// Assert fails, nothing is added to the mocked DbSet.
			mockSet.Verify(m => m.Add(It.IsAny<Student>()), Times.Once());
			mockContext.Verify(m => m.SaveChanges(), Times.Once());

		}
	}
}