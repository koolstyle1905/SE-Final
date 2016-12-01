namespace DataAccess
{
	using System.Configuration;

	public class Connection
	{
		public static string ConnectionString => ConfigurationManager.ConnectionStrings["DormitoryContext"].ConnectionString;
	}
}
