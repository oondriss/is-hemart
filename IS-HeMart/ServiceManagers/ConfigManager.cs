using System.Configuration;

namespace IS_HeMart.ServiceManagers
{
	public class ConfigManager
	{
		public static string GetDbServer()
		{
			var connString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
			var connStringProps = connString.Split(';');
			foreach (var item in connStringProps)
			{
				var parts = item.Split('=');
				if (parts[0] == "Data Source")
				{
					return parts[1];
				}
			}

			return "";
		}
		public static string GetDbName()
		{
			var connString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
			var connStringProps = connString.Split(';');
			foreach (var item in connStringProps)
			{
				var parts = item.Split('=');
				if (parts[0] == "Initial Catalog")
				{
					return parts[1];
				}
			}

			return "";
		}
	}
}
