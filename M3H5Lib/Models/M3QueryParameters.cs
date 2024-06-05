using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3H5Lib.Models
{
	public class M3QueryParameters : Dictionary<string, string>
	{
		public M3QueryParameters() { }

		public M3QueryParameters(IDictionary<string, string> source)
		{
			foreach (KeyValuePair<string, string> kvp in source)
			{
				Add(kvp.Key, kvp.Value);
			}
		}

		public M3QueryParameters(IDictionary<string, IEnumerable<string>> source)
		{
			foreach (KeyValuePair<string, IEnumerable<string>> kvp in source)
			{
				Add(kvp.Key, string.Join(",", kvp.Value));
			}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Join(";", this.Select(x => $"{x.Key}:{x.Value}"));
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;

				foreach (var item in this)
				{
					hashCode = hashCode * 59 + item.Key.GetHashCode();
					if (item.Value != null)
						hashCode = hashCode * 59 + item.Value.GetHashCode();
				}
				return hashCode;
			}
		}
	}
}
