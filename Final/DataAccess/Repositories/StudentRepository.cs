using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class StudentRepository : Repository<Student>
	{
		public StudentRepository(DormitoryContext context) : base(context)
		{
		}
	}
}