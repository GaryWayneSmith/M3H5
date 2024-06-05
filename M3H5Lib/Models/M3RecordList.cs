using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace M3H5Lib.Models
{
	public class M3RecordList<T> : List<T>, IEquatable<T>, IValidatableObject where T : M3BaseRecord
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="OrderList" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		public M3RecordList() : base()
		{
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj)
		{
			return Equals(obj as T);
		}

		/// <summary>
		/// Returns true if M3RecordList instances are equal
		/// </summary>
		/// <param name="other">Instance of M3RecordList to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(T other)
		{
			if (other == null)
				return false;

			return base.Equals(other);
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			return base.ToString();
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = base.GetHashCode();
				return hashCode;
			}
		}

		/// <summary>
		/// To validate all properties of the instance
		/// </summary>
		/// <param name="validationContext">Validation context</param>
		/// <returns>Validation Result</returns>
		IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
		{
			yield break;
		}
	}
}
