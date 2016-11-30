﻿namespace DataAccess.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Domain;
	using System.Collections;

	public class FloorRepository : Repository<Floor>
	{
		public FloorRepository(DbContext context) : base(context)
		{
		}

		public IEnumerable<Floor> GetFloorByBuildingId(string buildingId)
		{
			return DbSet.Where(x => x.BuildingId == buildingId).OrderBy(f => f.FloorId.Length).ThenBy(f => f.FloorId);
		}

		public IEnumerable<Floor> OrderById()
		{
			return DbSet.OrderBy(x => x.FloorId.Length).ThenBy(f => f.FloorId);
		}
	}
}
