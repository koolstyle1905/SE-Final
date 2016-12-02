using System.Data.Entity;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class ClubRepository : Repository<Club>
	{
		public ClubRepository(DbContext context) : base(context)
		{
		}
	}
}