namespace Business
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

	public static class RoomBusiness
	{
		public static void CreateTreeRoom(TreeView treeView)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var buildings = unitOfWork.Buildings.GetAll();
				foreach (var building in buildings)
				{
					var parent = new TreeNode(building.BuildingId);
					foreach (var floor in building.Floors.OrderBy(f => f.FloorId.Length).ThenBy(f => f.FloorId))
					{
						parent.Nodes.Add(floor.FloorId);
					}
					treeView.Nodes.Add(parent);
				}
			}
		}

		public static List<RoomDto> GetRoomsByFloorId(string floorId)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var roomList = unitOfWork.Rooms.FindBy(r => r.FloorId == floorId).ToList();
				return Mapper.Map<List<Room>, List<RoomDto>>(roomList);
			}
		}
	}
}
