using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3H5Lib.Extensions
{
	public static class DateTimeExtension
	{
		private const string M3DATEFORMAT = "yyyyMMdd";

		public static string ToM3String(this DateTime date)
		{
			return date.ToString(M3DATEFORMAT);
		}

	}
}
