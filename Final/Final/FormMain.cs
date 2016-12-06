using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Business;
using DataTransfer;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace Final
{
	public partial class FormMain : RibbonForm
	{
		private readonly EmployeeDto employee;
		private readonly FormLogin formLogin;

		public FormMain(EmployeeDto employee, FormLogin formLogin)
		{
			this.employee = employee;
			this.formLogin = formLogin;
			InitializeComponent();

			//studentDtoBindingSource.DataSource = StudentBusiness.GetAll();
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

			barBtnRefesh_ItemClick(sender, e);
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
				var formRoom = new FormRoom {MdiParent = this};
				formRoom.Show();
			}
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) => formLogin.Dispose();

		private void barBtnExit_ItemClick(object sender, ItemClickEventArgs e)
		{
			FormMain_FormClosed(sender, new FormClosedEventArgs(CloseReason.ApplicationExitCall));
		}

		private void barBtnRefesh_ItemClick(object sender, ItemClickEventArgs e)
		{
			var form = CheckExist(typeof(FormStudent));
			if (form != null)
			{
				form.Close();
				var formStudent = new FormStudent {MdiParent = this};
				formStudent.Show();
			}

			form = CheckExist(typeof(FormRoom));
			if (form != null)
			{
				form.Close();
				var formRoom = new FormRoom {MdiParent = this};
				formRoom.Show();
			}
		}

		private void barBtnExcel_ItemClick(object sender, ItemClickEventArgs e)
		{
		}

		private void barBtnFromPermission_ItemClick(object sender, ItemClickEventArgs e)
		{
			var formPermission = new FormPermission(employee);
			formPermission.ShowDialog();
		}

		private void barBtnFormViolationRecord_ItemClick(object sender, ItemClickEventArgs e)
		{
			var formViolationRecord = new FormViolationRecord();
			formViolationRecord.ShowDialog();
		}

		private void barBtnReportAbsence_ItemClick(object sender, ItemClickEventArgs e)
		{
			var form = CheckExist(typeof(FormReportAbsence));
			if (form != null)
			{
				form.Activate();
			}
			else
			{
				var formReportAbsence = new FormReportAbsence {MdiParent = this};
				formReportAbsence.Show();
			}
		}

		private void barBtnLogout_ItemClick(object sender, ItemClickEventArgs e)
		{
			Hide();
			formLogin.Show();
		}

		private void barBtnSetting_ItemClick(object sender, ItemClickEventArgs e)
		{
			new FormConfig().ShowDialog();
		}

		private void barBtnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
		{
		}


		private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			var form = CheckExist(typeof(FormStudent));
			if (form != null)
			{
				form.Activate();
			}
			else
			{
				var formStudent = new FormStudent { MdiParent = this };
				formStudent.Show();
			}
		}

		private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			new FormAddStudent().ShowDialog();
		}

		private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
		{

		}


		private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			var form = CheckExist(typeof(FormRoom));
			if (form != null)
			{
				form.Activate();
			}
			else
			{
				var formStudent = new FormRoom { MdiParent = this };
				formStudent.Show();
			}
		}

		private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
		{
			new FormPermission(employee).ShowDialog();
		}
	}
}