using System.Collections.Generic;

namespace M3H5Lib.Models
{
	public class M3HttpStatus
	{
		public string StatusCode { get; internal set; }
		public string ReasonPhrase { get; internal set; }
		public string RequestUri { get; internal set; }

		/// <summary>
		/// Return string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return $"StatusCode:{StatusCode},ReasonPhrase:{ReasonPhrase},RequestUri:{RequestUri}";
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

				if (StatusCode != null)
					hashCode = hashCode * 59 + StatusCode.GetHashCode();
				if (ReasonPhrase != null)
					hashCode = hashCode * 59 + ReasonPhrase.GetHashCode();
				if (RequestUri != null)
					hashCode = hashCode * 59 + RequestUri.GetHashCode();
				return hashCode;
			}
		}
	}
}
