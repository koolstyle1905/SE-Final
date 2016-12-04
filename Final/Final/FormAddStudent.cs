using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business;
using DataTransfer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Final
{
	public partial class FormAddStudent : Form
	{
		public FormAddStudent()
		{
			InitializeComponent();
		}

		private void btnComfirm_Click(object sender, EventArgs e)
		{
			StudentDto newStudentDto;
			if (Utilities.StringIsNullOrEmpty(txtStudentId.Text, txtName.Text, txtAddress.Text, txtNation.Text, txtReligion.Text,
				txtPhone.Text, txtSsn.Text))
			{
				XtraMessageBox.Show(@"Please fill in all fields", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				newStudentDto = CreateStudent();
			}
			catch (Exception)
			{
				XtraMessageBox.Show(@"Thông tin không hợp lệ", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				StudentBusiness.AddStudent(newStudentDto);
			}
			catch (Exception)
			{
				XtraMessageBox.Show(@"Sinh viên đã có trong kí túc xá", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Close();
		}

		private StudentDto CreateStudent()
		{
			return new StudentDto
			{
				StudentId = txtStudentId.Text,
				ClubId = ((ClubDto) lookUpEditClub.GetSelectedDataRow()).ClubId,
				Name = txtName.Text,
				RoomId = lockUpEditRoom.Text,
				DateOfBirth = dateTimePicker1.Value,
				Course = int.Parse(cbbCourse.Text),
				Address = txtAddress.Text,
				Gender = cbbGender.Text,
				Nation = txtNation.Text,
				Religion = txtReligion.Text,
				Phone = decimal.Parse(txtPhone.Text),
				PlaceOfBirth = txtPlaceOfBirth.Text,
				Ssn = txtSsn.Text
			};
		}

		private void FormAddStudent_Load(object sender, EventArgs e)
		{
			InitLookUpEdit(lookUpEditClub, ClubBusiness.GetAll(), "ClubId", "Name");
			InitLookUpEdit(lookUpEditBuilding, BuildingBusiness.GetAll(), "BuildingId", "BuildingId");
			InitLookUpEdit(lookUpEditFaculty, FacultyBusiness.GetAll(), "FacultyId", "Name");

			cbbGender.Properties.Items.AddRange(new object[] {"Male", "Female"});
			cbbGender.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			cbbGender.SelectedIndex = 0;
			cbbCourse.Properties.Items.AddRange(new object[] {2016, 2015, 2013, 2014});
			cbbCourse.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			cbbCourse.SelectedIndex = 0;
		}

		private static void InitLookUpEdit<T>(LookUpEdit lookUpEdit, List<T> dataSource, string valueMember,
			string displayMember) where T : class
		{
			var properties = lookUpEdit.Properties;
			properties.DataSource = dataSource;
			properties.ValueMember = valueMember;
			properties.DisplayMember = displayMember;
			properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			properties.AutoSearchColumnIndex = 1;
			properties.PopulateColumns();
			lookUpEdit.EditValue = lookUpEdit.Properties.GetDataSourceValue(lookUpEdit.Properties.ValueMember, 0);
		}

		private void lookUpEditBuilding_EditValueChanged(object sender, EventArgs e)
		{
			InitLookUpEdit(lookUpEditFloor, FloorBusiness.GetFloorByBuildingId(lookUpEditBuilding.Text), "FloorId", "FloorId");
			lookUpEditFloor.Properties.Columns["BuildingId"].Visible = false;
		}

		private void lookUpEditFloor_EditValueChanged(object sender, EventArgs e)
		{
			InitLookUpEdit(lockUpEditRoom, RoomBusiness.GetRoomsByFloorId(lookUpEditFloor.Text), "RoomId", "RoomId");
			lockUpEditRoom.Properties.Columns["FloorId"].Visible = false;
		}

		private void lookUpEditFaculty_EditValueChanged(object sender, EventArgs e)
		{
			InitLookUpEdit(lookUpEditClass,
				ClassBusiness.GetClassByFacultyId(((FacultyDto) lookUpEditFaculty.GetSelectedDataRow()).FacultyId), "ClassId",
				"ClassId");
			lookUpEditClass.Properties.Columns["FacultyId"].Visible = false;
			lookUpEditClass.Properties.Columns["Faculty"].Visible = false;
		}
	}
}