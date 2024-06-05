/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 3/9/2024 12:26:01 AM
/// **********************************************************************
///
/// All property types here are derived from existing A, N, or D from M3
/// with minimal logic for verification.  Generally if it's N under 10
/// digits it was treated as an int, 10 digits long, and more than 10 as
/// as a decimal.  This means some smaller decimals might be missed, and
/// in this case, will throw a conversion error.  If there is specific
/// conversions that were missed, please correct and notify for mainline
/// inclusion.
///
/// All fields are prefixed with M3_ as C# doesn not handle numeric leading
/// digits and some return values fall into this category.  So it was decided
/// that we standardize on a leading prefix

using M3H5Lib.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace M3H5Lib.Api.OPS600MI
{
	public partial class LstCusResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Transaction type
		/// FieldName: TRTP
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type")]
		public string M3_TRTP => GetString("TRTP");

		/// <summary>
		/// Description: Action code
		/// FieldName: ACCT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action code")]
		public string M3_ACCT => GetString("ACCT");

		/// <summary>
		/// Description: Data
		/// FieldName: RDDA
		/// FieldType: A
		/// Length: 900
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data")]
		public string M3_RDDA => GetString("RDDA");

		/// <summary>
		/// Description: Distribution key 2 - resource driver
		/// FieldName: RDD2
		/// FieldType: A
		/// Length: 62
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution key 2 - resource driver")]
		public string M3_RDD2 => GetString("RDD2");
	}
}
// EOF
