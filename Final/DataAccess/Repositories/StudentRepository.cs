using System.Data.Entity;
using DataAccess.Core;
using DataAccess.Domain;
using Microsoft.SqlServer.Server;

namespace DataAccess.Repositories
{
	public interface IStudentRepository : IRepository<Student>
	{
	}

	public class StudentRepository : Repository<Student>, IStudentRepository
	{
		public StudentRepository(DbContext context) : base(context)
		{
		}
	}
}