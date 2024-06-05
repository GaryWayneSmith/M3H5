using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3H5Lib
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class M3NameAttribute : Attribute
	{
		public string Name { get; private set; } = string.Empty;

		public M3NameAttribute(string name)
		{
			Name = name;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return $"Name:{Name}";
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

				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				return hashCode;
			}
		}
	}
}
