namespace Business.Business
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Forms;
	using AutoMapper;
	using DataAccess;
	using DataAccess.Domain;
	using DataTransfer;

	public class RoomBusiness
	{
		private readonly IDormitoryContext dormitoryContext;

		public RoomBusiness()
		{
		}
		public RoomBusiness(IDormitoryContext dormitoryContext)
		{
			this.dormitoryContext = dormitoryContext;
		}

		public void CreateTreeRoom(TreeView treeView)
		{
			var buildingList = dormitoryContext.Buildings.ToList();
			foreach (var building in buildingList)
			{
				var parent = new TreeNode(building.BuildingId);
				foreach (var floor in building.Floors.OrderBy(f => f.FloorId.Length).ThenBy(f => f.FloorId))
				{
					parent.Nodes.Add(floor.FloorId);
				}
				treeView.Nodes.Add(parent);
			}
		}

		public List<RoomDto> GetRoomsByFloorId(string floorId)
		{
			var roomList = dormitoryContext.Rooms.Where(r => r.FloorId == floorId).ToList();
			return Mapper.Map<List<Room>, List<RoomDto>>(roomList);
		}
	}
}
