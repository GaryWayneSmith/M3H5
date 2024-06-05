using Newtonsoft.Json;

namespace M3H5Lib.Models
{
	public class M3Field
	{
		[JsonProperty("Name")]
		public string Key { get; set; }

		public string Value { get; set; }

		/// <summary>
		/// Cleans trailing M3 space data
		/// </summary>
		internal void CleanValue()
		{
			Value = Value?.Trim();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return $"{Key}:{Value}";
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
				if (Key != null)
					hashCode = hashCode * 59 + Key.GetHashCode();
				if (Value != null)
					hashCode = hashCode * 59 + Value.GetHashCode();
				return hashCode;
			}
		}
	}
}