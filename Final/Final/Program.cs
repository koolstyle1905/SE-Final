using System;
using System.Windows.Forms;
using Business;
using DataTransfer;

namespace Final
{
	public static class Program
	{
		/// <summary>
		///     The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
		{
			AutoMapperConfiguration.Configure();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormPermission(new EmployeeDto()));
		}
	}
}