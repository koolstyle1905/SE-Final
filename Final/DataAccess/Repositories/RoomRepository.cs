using System.Collections.Generic;
using System.Linq;
using DataAccess.Core;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public interface IRoomRepository : IRepository<Room>
	{
	}

	public class RoomRepository : Repository<Room>, IRoomRepository
	{
		public RoomRepository(DormitoryContext context) : base(context)
		{
		}

		public IEnumerable<Room> GetRoomsByFloorId(string floorId)
		{
			return DbSet.Where(x => x.FloorId == floorId).OrderBy(x => x.FloorId.Length).ThenBy(x => x.FloorId);
		}
	}
}