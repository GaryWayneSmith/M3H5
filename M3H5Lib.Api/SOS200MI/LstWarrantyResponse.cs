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

namespace M3H5Lib.Api.SOS200MI
{
	public partial class LstWarrantyResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Brand
		/// FieldName: BRAN
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Brand")]
		public string M3_BRAN => GetString("BRAN");

		/// <summary>
		/// Description: ID type 1
		/// FieldName: MWTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ID type 1")]
		public int? M3_MWTP => GetNullableInt("MWTP");

		/// <summary>
		/// Description: Identity 1
		/// FieldName: IDE1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Identity 1")]
		public string M3_IDE1 => GetString("IDE1");

		/// <summary>
		/// Description: Description 1
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 1")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Excluded
		/// FieldName: EXCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Excluded")]
		public int? M3_EXCL => GetNullableInt("EXCL");

		/// <summary>
		/// Description: ID type 2
		/// FieldName: LWTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ID type 2")]
		public int? M3_LWTP => GetNullableInt("LWTP");

		/// <summary>
		/// Description: Identity 2
		/// FieldName: IDE2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Identity 2")]
		public string M3_IDE2 => GetString("IDE2");

		/// <summary>
		/// Description: Description 2
		/// FieldName: MODE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 2")]
		public string M3_MODE => GetString("MODE");

		/// <summary>
		/// Description: Warranty range 1 in years
		/// FieldName: YEA1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty range 1 in years")]
		public string M3_YEA1 => GetString("YEA1");

		/// <summary>
		/// Description: Warranty range 1 in months
		/// FieldName: MON1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty range 1 in months")]
		public string M3_MON1 => GetString("MON1");

		/// <summary>
		/// Description: Payer warranty range 1
		/// FieldName: PYN1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer warranty range 1")]
		public string M3_PYN1 => GetString("PYN1");

		/// <summary>
		/// Description: Warranty range 2 in years
		/// FieldName: YEA2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty range 2 in years")]
		public string M3_YEA2 => GetString("YEA2");

		/// <summary>
		/// Description: Warranty range 2 in months
		/// FieldName: MON2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty range 2 in months")]
		public string M3_MON2 => GetString("MON2");

		/// <summary>
		/// Description: Payer warranty range 2
		/// FieldName: PYN2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer warranty range 2")]
		public string M3_PYN2 => GetString("PYN2");
	}
}
// EOF
