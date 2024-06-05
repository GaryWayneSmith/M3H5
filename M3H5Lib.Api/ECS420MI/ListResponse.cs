/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 7:41:31 PM
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
/// All fields are prefixed with M3 as C# doesn't not handle numeric leading
/// digits and some return values fall into this category.  So it was decided
/// that we standardize on a leading prefix

using M3H5Lib.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace M3H5Lib.Api.ECS420MI
{
	public partial class ListResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: ECO number
		/// FieldName: ECON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ECO number")]
		public string M3ECON => GetString("ECON");

		/// <summary>
		/// Description: ECO type
		/// FieldName: ECAC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ECO type")]
		public string M3ECAC => GetString("ECAC");

		/// <summary>
		/// Description: From date
		/// FieldName: FDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public DateTime? M3FDAT => GetNullableDateTime("FDAT");

		/// <summary>
		/// Description: Status
		/// FieldName: ECST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3ECST => GetString("ECST");

		/// <summary>
		/// Description: Issuer
		/// FieldName: ISBY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issuer")]
		public string M3ISBY => GetString("ISBY");

		/// <summary>
		/// Description: Change text 1
		/// FieldName: ECT1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change text 1")]
		public string M3ECT1 => GetString("ECT1");
	}
}
// EOF
