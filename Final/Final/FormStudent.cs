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

namespace Final
{
	public partial class FormStudent : Form
	{
		private List<StudentDto> students;
		public FormStudent()
		{
			this.InitializeComponent();
			
		}

		private void FormStudent_Load(object sender, EventArgs e)
		{
			students = StudentBusiness.GetAll();
			this.studentDtoBindingSource.DataSource = students;
		}

		private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
		{
			var index = gridView1.GetDataSourceRowIndex(e.RowHandle);
			var student = students[index];
			StudentBusiness.EditStudent(student);
			FormStudent_Load(sender, e);
			//students = StudentBusiness.GetAll();
			//this.studentDtoBindingSource.DataSource = students;
		}
	}
}
