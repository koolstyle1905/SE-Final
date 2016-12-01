using System.Configuration;

namespace DataAccess
{
	public class Connection
	{
		public static string ConnectionString => ConfigurationManager.ConnectionStrings["DormitoryContext"].ConnectionString;
	}
}