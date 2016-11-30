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
				TreeNode parent;
				var buildings = unitOfWork.Buildings.GetAll();
				foreach (var building in buildings)
				{
					parent = new TreeNode(building.BuildingID);
					foreach (var floor in building.Floors.OrderBy(f => f.FloorID.Length).ThenBy(f => f.FloorID))
					{
						parent.Nodes.Add(floor.FloorID);
					}
					treeView.Nodes.Add(parent);
				}
			}
		}

		public static List<RoomDto> GetRoomsByFloorID(string floorID)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var roomList = unitOfWork.Rooms.FindBy(r => r.FloorID == floorID).ToList();
				return Mapper.Map<List<Room>, List<RoomDto>>(roomList);
			}
		}
	}
}
