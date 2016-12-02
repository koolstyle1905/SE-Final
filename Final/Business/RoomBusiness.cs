using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using DataAccess;
using DataAccess.Core;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public class RoomBusiness
	{
		private readonly IUnitOfWork unitOfWork;

		public RoomBusiness() : this(new UnitOfWork())
		{
		}

		public RoomBusiness(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public void CreateTreeRoom(TreeView treeView)
		{
			var buildingList = unitOfWork.Buildings.ToList();
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
			var roomList = unitOfWork.Rooms.FindBy(r => r.FloorId == floorId).ToList();
			return Mapper.Map<List<Room>, List<RoomDto>>(roomList);
		}
	}
}