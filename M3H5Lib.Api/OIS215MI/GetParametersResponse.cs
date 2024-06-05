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

namespace M3H5Lib.Api.OIS215MI
{
	public partial class GetParametersResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Permit on-account payments
		/// FieldName: ACCA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Permit on-account payments")]
		public int? M3ACCA => GetNullableInt("ACCA");

		/// <summary>
		/// Description: Permit creation of checks
		/// FieldName: CHKA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Permit creation of checks")]
		public int? M3CHKA => GetNullableInt("CHKA");

		/// <summary>
		/// Description: Allow petty cash
		/// FieldName: ALPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow petty cash")]
		public int? M3ALPC => GetNullableInt("ALPC");

		/// <summary>
		/// Description: Allow cash movement
		/// FieldName: ALCT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow cash movement")]
		public int? M3ALCT => GetNullableInt("ALCT");

		/// <summary>
		/// Description: Allow validation
		/// FieldName: ALVA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow validation")]
		public int? M3ALVA => GetNullableInt("ALVA");

		/// <summary>
		/// Description: Print receipt
		/// FieldName: PRCT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print receipt")]
		public int? M3PRCT => GetNullableInt("PRCT");

		/// <summary>
		/// Description: Externally managed credit card payments
		/// FieldName: CRCI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Externally managed credit card payments")]
		public int? M3CRCI => GetNullableInt("CRCI");
	}
}
// EOF
