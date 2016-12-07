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
	public partial class FormViolationRecord : Form
	{
		public FormViolationRecord()
		{
			InitializeComponent();
			violationRecordDtoBindingSource.DataSource = Utilities.Violation();
		}
	}
}
