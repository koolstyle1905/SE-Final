using System.Data.Entity;
using DataAccess.Core;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public interface IRoomRepository : IRepository<Room>
	{
	}

	public class RoomRepository : Repository<Room>, IRoomRepository
	{
		public RoomRepository(DbContext context) : base(context)
		{
		}
	}
}