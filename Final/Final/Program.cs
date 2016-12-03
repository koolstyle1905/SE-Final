using System;
using System.Windows.Forms;
using Business;

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
			Application.Run(new FormLogin());
		}
	}
}