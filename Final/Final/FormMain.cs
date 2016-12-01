using AutoMapper;
using Business;
using DataTransfer;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
	public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private Form CheckExist(Type formType)
		{
			return MdiChildren.FirstOrDefault(item => item.GetType() == formType);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void barBtnStudentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var form = CheckExist(typeof(FormStudent));
			if (form != null)
			{
				form.Activate();
			}
			else
			{
				var formStudent = new FormStudent {MdiParent = this};
				formStudent.Show();
			}
		}

	}
}
