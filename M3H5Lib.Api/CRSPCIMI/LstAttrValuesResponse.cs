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

namespace M3H5Lib.Api.CRSPCIMI
{
	public partial class LstAttrValuesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: From attribute value
		/// FieldName: AALF
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From attribute value")]
		public string M3AALF => GetString("AALF");

		/// <summary>
		/// Description: From attribute value
		/// FieldName: ANUF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From attribute value")]
		public decimal? M3ANUF => GetNullableDecimal("ANUF");

		/// <summary>
		/// Description: To attribute value
		/// FieldName: ANUT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To attribute value")]
		public decimal? M3ANUT => GetNullableDecimal("ANUT");

		/// <summary>
		/// Description: From attribute value
		/// FieldName: TGNM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From attribute value")]
		public decimal? M3TGNM => GetNullableDecimal("TGNM");

		/// <summary>
		/// Description: Numeric range multiple
		/// FieldName: NRMU
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric range multiple")]
		public decimal? M3NRMU => GetNullableDecimal("NRMU");

		/// <summary>
		/// Description: Default value
		/// FieldName: DEFV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default value")]
		public int? M3DEFV => GetNullableInt("DEFV");

		/// <summary>
		/// Description: Option description
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option description")]
		public string M3TX30 => GetString("TX30");

		/// <summary>
		/// Description: Default code
		/// FieldName: DFCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default code")]
		public int? M3DFCD => GetNullableInt("DFCD");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public string M3SAPR => GetString("SAPR");

		/// <summary>
		/// Description: Cost price
		/// FieldName: UCOS
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price")]
		public string M3UCOS => GetString("UCOS");

		/// <summary>
		/// Description: Valid value
		/// FieldName: VALI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid value")]
		public int? M3VALI => GetNullableInt("VALI");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Sales price
		/// FieldName: LOSP
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public string M3LOSP => GetString("LOSP");

		/// <summary>
		/// Description: Currency
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3LOCD => GetString("LOCD");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: LODC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3LODC => GetNullableInt("LODC");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SPLP
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public string M3SPLP => GetString("SPLP");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");
	}
}
// EOF
