using System;
using System.Linq;

namespace Business
{
	public class Utilities
	{
		public static bool StringIsNullOrEmpty(params string[] paramStrings)
		{
			return paramStrings.Any(string.IsNullOrEmpty);
		}

		/// <summary>
		///     Find next ID
		/// </summary>
		/// <param name="lastId">Mã cuối cùng</param>
		/// <param name="prefixId">Tiền tố mã</param>
		/// <returns></returns>
		public static string NextId(string lastId, string prefixId)
		{
			if (lastId == string.Empty)
			{
				return prefixId + "00001"; // fix width default
			}
			var nextId = int.Parse(lastId.Remove(0, prefixId.Length)) + 1;
			var lengthNumerId = lastId.Length - prefixId.Length;
			var zeroNumber = string.Empty;
			for (var i = 1; i <= lengthNumerId; i++)
			{
				if (!(nextId < Math.Pow(10, i)))
				{
					continue;
				}
				for (var j = 1; j <= lengthNumerId - i; i++)
				{
					zeroNumber += "0";
				}
				return prefixId + zeroNumber + nextId;
			}
			return prefixId + nextId;
		}
	}
}