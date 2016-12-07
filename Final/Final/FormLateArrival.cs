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
	public partial class FormLateArrival : Form
	{
		public FormLateArrival()
		{
			InitializeComponent();
			gridControl1.DataSource = Utilities.LateArrival();
		}
	}
}
