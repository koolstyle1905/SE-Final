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
using DevExpress.XtraEditors;

namespace Final
{
	public partial class FormStudent : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private List<StudentDto> studentList;
		public FormStudent()
		{
			this.InitializeComponent();
			this.studentList = StudentBusiness.GetAll();
			this.studentDtoBindingSource.DataSource = studentList;
			this.gridViewStudent.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace;
		}

		private void FormStudent_Load(object sender, EventArgs e)
		{
			this.InitLookUpClub();
			this.InitComboBoxCourse();
			this.InitComboBoxGender();
		}

		private void InitLookUpClub()
		{
			var clubs = ClubBusiness.GetAll();
			RepositoryItemLookUpEdit riLookUpClub = new RepositoryItemLookUpEdit();
			riLookUpClub.DataSource = clubs;
			riLookUpClub.ValueMember = "ClubID";
			riLookUpClub.DisplayMember = "Name";
			riLookUpClub.DropDownRows = clubs.Count;
			riLookUpClub.BestFitMode = BestFitMode.BestFit;
			riLookUpClub.SearchMode = SearchMode.AutoComplete;
			riLookUpClub.AutoSearchColumnIndex = 1;
			gridViewStudent.Columns["ClubID"].ColumnEdit = riLookUpClub;
		}

		private void InitComboBoxGender()
		{
			RepositoryItemComboBox riComboBoxGender = new RepositoryItemComboBox();
			riComboBoxGender.Items.AddRange(new string[] { "Male", "Female" });
			riComboBoxGender.TextEditStyle = TextEditStyles.DisableTextEditor;
			gridViewStudent.Columns["Gender"].ColumnEdit = riComboBoxGender;
		}

		private void InitComboBoxCourse()
		{
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
			gridViewStudent.Columns["Course"].ColumnEdit = riComboBoxCourse;
		}

		private void gridViewStudent_RowUpdated(object sender, RowObjectEventArgs e)
		{
			
			var index = gridViewStudent.GetDataSourceRowIndex(e.RowHandle);
			if (index < 0)
			{
				index = studentList.Count - 1;
				var student = studentList[index];
				StudentBusiness.AddStudent(student);
			}
			else
			{
				var student = studentList[index];
				StudentBusiness.EditStudent(student);
			}
			this.gridControl1.RefreshDataSource();
		}

		private void gridViewStudent_InitNewRow(object sender, InitNewRowEventArgs e)
		{
			gridViewStudent.SetRowCellValue(e.RowHandle, "Gender", "Male");
			gridViewStudent.SetRowCellValue(e.RowHandle, "ClubID", "01");
			gridViewStudent.SetRowCellValue(e.RowHandle, "Course", 2016);
			gridViewStudent.SetRowCellValue(e.RowHandle, "DateOfBirth", new DateTime(2000, 1, 1));
		}
	}
}
