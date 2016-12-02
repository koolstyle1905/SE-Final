using System;
using System.Collections.Generic;
using Business;
using DataTransfer;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Final
{
	public partial class FormStudent : RibbonForm
	{
		private readonly List<StudentDto> studentList;

		public FormStudent()
		{
			InitializeComponent();
			studentList = StudentBusiness.GetAll();
			studentDtoBindingSource.DataSource = studentList;
			gridViewStudent.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace;
			gridViewPriorities.Columns["Content"].BestFit();
		}

		private void FormStudent_Load(object sender, EventArgs e)
		{
			InitLookUpClub();
			InitComboBoxCourse();
			InitComboBoxGender();
		}

		private void InitLookUpClub()
		{
			var clubList = new ClubBusiness().GetAll();
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
			gridViewStudent.Columns["ClubId"].ColumnEdit = riLookUpClub;
		}

		private void InitComboBoxGender()
		{
			var riComboBoxGender = new RepositoryItemComboBox();
			riComboBoxGender.Items.AddRange(new object[] {"Male", "Female"});
			riComboBoxGender.TextEditStyle = TextEditStyles.DisableTextEditor;
			gridViewStudent.Columns["Gender"].ColumnEdit = riComboBoxGender;
		}

		private void InitComboBoxCourse()
		{
			var riComboBoxCourse = new RepositoryItemComboBox();
			var currentYear = DateTime.Now.Year;
			var courses = new List<int>
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
			gridControl1.RefreshDataSource();
		}

		private void gridViewStudent_InitNewRow(object sender, InitNewRowEventArgs e)
		{
			gridViewStudent.SetRowCellValue(e.RowHandle, "Gender", "Male");
			//gridViewStudent.SetRowCellValue(e.RowHandle, "ClubId", "01");
			gridViewStudent.SetRowCellValue(e.RowHandle, "Course", 2016);
			gridViewStudent.SetRowCellValue(e.RowHandle, "DateOfBirth", new DateTime(2000, 1, 1));
		}
	}
}