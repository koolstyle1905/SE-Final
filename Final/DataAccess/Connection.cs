﻿namespace DataAccess
{
	using System;
	using System.Collections.Generic;
	using System.Configuration;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Connection
	{
		public static string ConnectionString => ConfigurationManager.ConnectionStrings["DormitoryContext"].ConnectionString;
	}
}
