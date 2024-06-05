using Newtonsoft.Json;

namespace M3H5Lib.Models
{
	public class M3FieldProperty
	{
		[JsonProperty("@name")]
		public string Name { get; set; }

		[JsonProperty("@type")]
		public string Type { get; set; }

		[JsonProperty("@length")]
		public int Length { get; set; }

		[JsonProperty("@description")]
		public string Description { get; set; }

		/// <summary>
		/// Return string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return $"Name:{Name},Type:{Type},Length:{Length},Description:{Description}";
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

				hashCode = hashCode * 59 + Length.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Type != null)
					hashCode = hashCode * 59 + Type.GetHashCode();
				if (Description != null)
					hashCode = hashCode * 59 + Description.GetHashCode();
				return hashCode;
			}
		}
	}
}
