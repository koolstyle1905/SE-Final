using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using Business;
using DataTransfer;
using DevExpress.XtraTreeList.Nodes;

namespace Final
{
	public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public FormMain()
		{
			this.InitializeComponent();
			
		}

		private Form CheckExist(Type formType)
		{
			foreach (var item in this.MdiChildren)
			{
				if (item.GetType() == formType)
				{
					return item;
				}
			}
			return null;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void barBtnStudentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Form form = this.CheckExist(typeof(FormStudent));
			if (form != null)
			{
				form.Activate();
			}
			else
			{
				FormStudent formStudent = new FormStudent();
				formStudent.MdiParent = this;
				formStudent.Show();
			}
		}
	}
}
