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

		public FormMain()
		{
			//this.employee = employee;
			InitializeComponent();
			barBtnAddStudent.Enabled = false;
		}

		private Form CheckExist(Type formType)
		{
			return MdiChildren.FirstOrDefault(item => item.GetType() == formType);
		}

		private void Form_Load(object sender, EventArgs e)
		{
			barBtnAddStudent.Enabled = false;
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

		private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
		{
			var form = CheckExist(typeof(FormRoom));
			if (form != null)
			{
				form.Activate();
			}
			else
			{
				var formRoom = new FormRoom {MdiParent = this};
				formRoom.Show();
			}
		}

		private void barButtonAddStudent_ItemClick(object sender, ItemClickEventArgs e)
		{
			var formAddStudent = new FormAddStudent();
			formAddStudent.ShowDialog();
		}

		private void barBtnLogin_ItemClick(object sender, ItemClickEventArgs e)
		{
			new FormLogin().ShowDialog();
		}
	}
}