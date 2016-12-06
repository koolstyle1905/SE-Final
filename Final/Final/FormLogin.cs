using System;
using System.Windows.Forms;
using Business;
using DataTransfer;

namespace Final
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
			FormClosed += FormLogin_FormClosed;
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			FormBorderStyle = FormBorderStyle.FixedSingle;
			txtId.Text = "1";
			txtPassword.Text = "1";
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtId.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
			{
				MessageBox.Show(@"Vui lòng kiểm tra lại thông tin đăng nhập và mật khẩu.", @"Lỗi", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}
			var employee = new EmployeeDto
			{
				EmployeeId = "1",
				Username = txtId.Text,
				Password = txtPassword.Text
			};
			try
			{
				if (!EmployeeBusiness.IsValid(employee.Username, employee.Password))
				{
					MessageBox.Show(@"Thông tin đăng nhập hoặc mật khẩu không hợp lệ.", @"Lỗi", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}
			}
			catch (Exception)
			{
				MessageBox.Show(@"Không thể kết nối cơ sở dữ liệu.", @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Dispose();
				return;
			}
			new FormMain(employee, this).Show();
			Hide();
		}

		private void Enter_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(sender, e);
			}
		}

		private void FormLogin_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

		private void btnConfig_Click(object sender, EventArgs e)
		{
			new FormConfig().ShowDialog();
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{

		}
	}
}