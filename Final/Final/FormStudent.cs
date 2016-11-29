using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using DataTransfer;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace Final
{
	public partial class FormStudent : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private List<StudentDto> students;
		public FormStudent()
		{
			this.InitializeComponent();
			this.gridView1.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace;
		}

		private void FormStudent_Load(object sender, EventArgs e)
		{
			this.students = StudentBusiness.GetAll();
			this.studentDtoBindingSource.DataSource = students;
			var clubs = ClubBusiness.GetAll();
			RepositoryItemLookUpEdit riLookUp = new RepositoryItemLookUpEdit();
			riLookUp.BestFitMode = BestFitMode.BestFit;
			riLookUp.DataSource = clubs;
			riLookUp.ValueMember = "ClubID";
			riLookUp.DisplayMember = "Name";
			riLookUp.DropDownRows = clubs.Count;
			riLookUp.SearchMode = SearchMode.AutoComplete;
			riLookUp.AutoSearchColumnIndex = 1;
			gridView1.Columns["ClubID"].ColumnEdit = riLookUp;
			gridView1.BestFitColumns();

			RepositoryItemLookUpEdit riLookUp2 = new RepositoryItemLookUpEdit();
			riLookUp.DataSource = clubs;
			riLookUp.ValueMember = "ClubID";
			riLookUp.DisplayMember = "Name";
		}

		private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
		{
			var index = gridView1.GetDataSourceRowIndex(e.RowHandle);
			var student = students[index];
			StudentBusiness.EditStudent(student);
			this.FormStudent_Load(sender, e);
		}
	}
}
