using System.Data.Entity;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class RoomRepository : Repository<Room>
	{
		public RoomRepository(DbContext context) : base(context)
		{
		}
	}
}