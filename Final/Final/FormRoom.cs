using System;
using System.Windows.Forms;
using Business;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace Final
{
	public partial class FormRoom : Form
	{
		public FormRoom()
		{
			InitializeComponent();
		}

		private void FormRoom_Load(object sender, EventArgs e)
		{
			RoomBusiness.CreateTreeRoom(treeViewFloor);
			//InitLookUpEditClub();
		}

		private void treeViewFloor_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			gridControl1.DataSource = RoomBusiness.GetRoomsByFloorId(e.Node.Text);
			InitLookUpEditClub();
		}

		private void InitLookUpEditClub()
		{
			var clubList = ClubBusiness.GetAll();
			var riLookUpClub = new RepositoryItemLookUpEdit
			{
				DataSource = clubList,
				ValueMember = "ClubId",
				DisplayMember = "Name",
				DropDownRows = clubList.Count,
				BestFitMode = BestFitMode.BestFit,
				SearchMode = SearchMode.AutoComplete,
				AutoSearchColumnIndex = 1
			};
			gridView2.Columns["ClubId"].ColumnEdit = riLookUpClub;
		}
	}
}