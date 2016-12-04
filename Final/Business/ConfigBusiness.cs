using DataAccess;
using DataTransfer;

namespace Business
{
	public class ConfigBusiness
	{
		private const string ConnectionStrWindows =
			@"Data Source={0}; Initial Catalog={1}; Integrated Security=True; MultipleActiveResultSets=True; App=EntityFramework";

		private const string ConnectionStrSqlServer =
			@"Data Source = {0}; Initial Catalog = {1}; User ID = {2}; Password = {3}; MultipleActiveResultSets=True; App=EntityFramework";

		/// <summary>
		///     Hàm sửa cấu hình quyền Windows
		/// </summary>
		/// <param name="config"></param>
		public static void WindowsAuthentication(Config config)
		{
			ConfigDao.ChangeConnectionString(string.Format(ConnectionStrWindows, config.ServerName, config.DatabaseName));
		}

		/// <summary>
		///     Hàm sửa cấu hình quyền Sql Server
		/// </summary>
		/// <param name="config"></param>
		public static void SqlSeverAuthentication(Config config)
		{
			ConfigDao.ChangeConnectionString(string.Format(ConnectionStrSqlServer, config.ServerName, config.DatabaseName,
				config.UserName, config.Password));
		}
	}
}