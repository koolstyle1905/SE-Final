namespace Business
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Utilities
	{

		/// <summary>
		/// Find next ID
		/// </summary>
		/// <param name="lastID">Mã cuối cùng</param>
		/// <param name="prefixID">Tiền tố mã</param>
		/// <returns></returns>
		public static string NextID(string lastID, string prefixID)
		{
			if (lastID == string.Empty)
			{
				return prefixID + "0001";  // fix width default
			}
			int nextId = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
			int lengthNumerID = lastID.Length - prefixID.Length;
			string zeroNumber = string.Empty;
			for (int i = 1; i <= lengthNumerID; i++)
			{
				if (nextId < Math.Pow(10, i))
				{
					for (int j = 1; j <= lengthNumerID - i; i++)
					{
						zeroNumber += "0";
					}
					return prefixID + zeroNumber + nextId.ToString();
				}
			}
			return prefixID + nextId;
		}
	}
}
