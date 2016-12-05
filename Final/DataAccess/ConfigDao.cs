using System.Configuration;

namespace DataAccess
{
	public class ConfigDao
	{
		public static void ChangeConnectionString(string connectionString)
		{
			var conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			conf.ConnectionStrings.ConnectionStrings["DormitoryContext"].ConnectionString = connectionString;
			conf.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection(conf.ConnectionStrings.SectionInformation.Name);
		}
	}
}