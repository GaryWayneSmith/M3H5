using M3H5Lib.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace M3H5Lib.Models
{
	public class M3Metadata
	{
		[JsonProperty("Field")]
		[JsonConverter(typeof(SingleOrArrayConverter<M3FieldProperty>))]
#pragma warning disable CA1002 // Do not expose generic lists
#pragma warning disable CA2227 // Collection properties should be read only
        public List<M3FieldProperty> FieldProperties { get; set; } = new List<M3FieldProperty>();
#pragma warning restore CA2227 // Collection properties should be read only
#pragma warning restore CA1002 // Do not expose generic lists

        /// <summary>
        /// Return string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
		{
			return $"FieldProperties:[{string.Join(";", FieldProperties.Select(fv => fv.ToString()))}]";
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

				foreach (M3FieldProperty field in FieldProperties)
					hashCode = hashCode * 59 + field.GetHashCode();
				return hashCode;
			}
		}

	}
}
