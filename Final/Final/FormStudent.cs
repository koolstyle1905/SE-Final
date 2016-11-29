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
			RepositoryItemLookUpEdit riLookUpClub = new RepositoryItemLookUpEdit();
			riLookUpClub.DataSource = clubs;
			riLookUpClub.ValueMember = "ClubID";
			riLookUpClub.DisplayMember = "Name";
			riLookUpClub.DropDownRows = clubs.Count;
			riLookUpClub.BestFitMode = BestFitMode.BestFit;
			riLookUpClub.SearchMode = SearchMode.AutoComplete;
			riLookUpClub.AutoSearchColumnIndex = 1;
			gridView1.Columns["ClubID"].ColumnEdit = riLookUpClub;
			gridView1.BestFitColumns();

			RepositoryItemComboBox riComboBoxCourse = new RepositoryItemComboBox();
			int currentYear = DateTime.Now.Year;
			List<int> courses = new List<int>()
			{
				currentYear--,
				currentYear--,
				currentYear--,
				currentYear
			};
			riComboBoxCourse.Items.AddRange(courses);
			riComboBoxCourse.TextEditStyle = TextEditStyles.DisableTextEditor;
			gridView1.Columns["Course"].ColumnEdit = riComboBoxCourse;
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
