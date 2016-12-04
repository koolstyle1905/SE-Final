using System;
using System.Windows.Forms;
using Business;
using DataTransfer;

namespace Final
{
	public partial class FormConfig : Form
	{
		public FormConfig()
		{
			InitializeComponent();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			var config = new Config
			{
				ServerName = txtServerName.Text,
				DatabaseName = txtDatabaseName.Text,
				UserName = txtUserName.Text,
				Password = txtPassword.Text
			};
			if (checkBoxWindows.Checked)
			{
				ConfigBusiness.WindowsAuthentication(config);
			}
			else
			{
				ConfigBusiness.SqlSeverAuthentication(config);
			}
			Dispose();
		}

		private void chkWAuthentication_CheckedChanged(object sender, EventArgs e)
		{
			txtUserName.Enabled = txtUserName.Enabled ^ true;
			txtPassword.Enabled = txtPassword.Enabled ^ true;
		}

		private void FormConfig_Load(object sender, EventArgs e)
		{
			FormBorderStyle = FormBorderStyle.FixedSingle;
		}
	}
}