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
		public static string ConnectionString
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["DormitoryContext"].ConnectionString;
			}
		}
	}
}
