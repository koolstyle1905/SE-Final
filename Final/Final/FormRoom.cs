using System;
using System.Windows.Forms;
using Business;

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
			RoomBusiness.CreateTreeRoom(treeView1);
		}

		private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			gridControl1.DataSource = RoomBusiness.GetRoomsByFloorId(e.Node.Text);
		}
	}
}