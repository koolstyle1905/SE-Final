namespace DataAccess.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Domain;

	public class RoomRepository : Repository<Room>
	{
		public RoomRepository(DbContext context) : base(context)
		{
		}
	}
}
