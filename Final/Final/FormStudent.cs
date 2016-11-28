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

namespace Final
{
	public partial class FormStudent : Form
	{
		public FormStudent()
		{
			InitializeComponent();
		}

		private void FormStudent_Load(object sender, EventArgs e)
		{
			studentDtoBindingSource.DataSource = StudentBusiness.GetAll();
		}
	}
}
