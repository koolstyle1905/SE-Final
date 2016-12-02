using System.Data.Entity;
using DataAccess.Core;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public interface IClubRepository : IRepository<Club>
	{
	}

	public class ClubRepository : Repository<Club>, IClubRepository
	{
		public ClubRepository(DbContext context) : base(context)
		{
		}
	}
}