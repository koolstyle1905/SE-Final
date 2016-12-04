using System;
using System.Linq;
using System.Windows.Forms;
using DataTransfer;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace Final
{
	public partial class FormMain : RibbonForm
	{
		private EmployeeDto employee;

		public FormMain(EmployeeDto employee)
		{
			this.employee = employee;
			InitializeComponent();
		}

		private Form CheckExist(Type formType)
		{
			return MdiChildren.FirstOrDefault(item => item.GetType() == formType);
		}

		private void Form_Load(object sender, EventArgs e)
		{
		}

		private void barBtnStudentList_ItemClick(object sender, ItemClickEventArgs e)
		{
			var form = CheckExist(typeof(FormStudent));
			if (form != null)
			{
				form.Activate();
			}
			else
			{
				var formStudent = new FormStudent {MdiParent = this};
				formStudent.Show();
			}
		}

		private void barButtonAddStudent_ItemClick(object sender, ItemClickEventArgs e)
		{
			var formAddStudent = new FormAddStudent();
			formAddStudent.ShowDialog();
		}

		private void barBtnRoomList_ItemClick(object sender, ItemClickEventArgs e)
		{
			var form = CheckExist(typeof(FormRoom));
			if (form != null)
			{
				form.Activate();
			}
			else
			{
				var formRoom = new FormRoom { MdiParent = this };
				formRoom.Show();
			}
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

		private void barBtnExit_ItemClick(object sender, ItemClickEventArgs e)
		{
			FormMain_FormClosed(sender,new FormClosedEventArgs(CloseReason.ApplicationExitCall));
		}
	}
}