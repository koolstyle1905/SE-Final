using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Business;
using DataTransfer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Final
{
	public partial class FormPermission : Form
	{
		private readonly EmployeeDto employee;

		public FormPermission(EmployeeDto employee)
		{
			this.employee = employee;
			InitializeComponent();
		}

		private static void InitGridLookUpEdit<T>(GridLookUpEdit gridLookUpEdit, List<T> dataSource, string valueMember,
			string displayMember) where T : class
		{
			var properties = gridLookUpEdit.Properties;
			properties.DataSource = dataSource;
			properties.ValueMember = valueMember;
			properties.DisplayMember = displayMember;
			properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			properties.AutoComplete = true;
			properties.View.PopulateColumns(dataSource);
		}

		private void InitGridLookUpEditStudent()
		{
			InitGridLookUpEdit(gridLookUpEditStudent, StudentBusiness.GetAll(), "StudentId", "StudentId");
			var column = gridLookUpEditStudent.Properties.View.Columns;
			column["Religion"].Visible = false;
			column["Nation"].Visible = false;
			column["Phone"].Visible = false;
			column["Ssn"].Visible = false;
			column["PlaceOfBirth"].Visible = false;
			column["Address"].Visible = false;
			column["DateOfBirth"].Visible = false;
			column["Course"].Visible = false;
			column["ClubId"].Visible = false;
			column["Gender"].Visible = false;
			column["Class"].FieldName = "Class.ClassId";
		}

		private void FormPermission_Load(object sender, EventArgs e)
		{
			InitGridLookUpEditStudent();
			cbbReason.SelectedIndex = 0;
		}

		private void gridLookUpEditStudent_EditValueChanged(object sender, EventArgs e)
		{
			var student = (StudentDto) gridLookUpEditStudent.GetSelectedDataRow();
			txtName.Text = student.Name;
			txtClassId.Text = student.Class.ClassId;
			txtFaculty.Text = student.Class.Faculty.Name;
			txtPhone.Text = student.Phone.ToString(CultureInfo.InvariantCulture);
			txtRoomId.Text = student.RoomId;
		}

		private void cbbReason_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbReason.SelectedIndex == 0)
			{
				groupTemporaryAbsence.Enabled = true;
				groupArrivalLate.Enabled = false;
				txtVehicleType.Enabled = false;
				txtEngineNumber.Enabled = false;
				txtOwnerAddress.Enabled = false;
				txtOwnerName.Enabled = false;
				txtLicensePlate.Enabled = false;
				txtPaintColor.Enabled = false;
				txtViNumber.Enabled = false;
			}
			if (cbbReason.SelectedIndex == 1)
			{
				groupTemporaryAbsence.Enabled = false;
				groupArrivalLate.Enabled = true;
				txtVehicleType.Enabled = false;
				txtEngineNumber.Enabled = false;
				txtOwnerAddress.Enabled = false;
				txtOwnerName.Enabled = false;
				txtLicensePlate.Enabled = false;
				txtPaintColor.Enabled = false;
				txtViNumber.Enabled = false;
			}
			if (cbbReason.SelectedIndex == 2)
			{
				groupTemporaryAbsence.Enabled = false;
				groupArrivalLate.Enabled = false;
				txtVehicleType.Enabled = true;
				txtEngineNumber.Enabled = true;
				txtOwnerAddress.Enabled = true;
				txtOwnerName.Enabled = true;
				txtLicensePlate.Enabled = true;
				txtPaintColor.Enabled = true;
				txtViNumber.Enabled = true;
			}
		}

		private void btnComfirm_Click(object sender, EventArgs e)
		{
			if (cbbReason.SelectedIndex == 0)
			{
				var temporary = new TemporaryAbsenceDto
				{
					Student = (StudentDto) gridLookUpEditStudent.GetSelectedDataRow(),
					StartDate = dateTimePickerStart.Value,
					NumOfAbsence = int.Parse(numericUpDown1.Value.ToString(CultureInfo.InvariantCulture)),
					Employee = employee,
					Description = txtDescription.Text
				};
				TemporaryAbsenceBusiness.Add(temporary);
			}
			Close();
		}
	}
}