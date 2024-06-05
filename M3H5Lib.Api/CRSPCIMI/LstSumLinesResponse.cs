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

namespace M3H5Lib.Api.CRSPCIMI
{
	public partial class LstSumLinesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3_ATID => GetString("ATID");

		/// <summary>
		/// Description: Attribute name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Attribute type
		/// FieldName: ATVC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute type")]
		public string M3_ATVC => GetString("ATVC");

		/// <summary>
		/// Description: Target value
		/// FieldName: ATAV
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Target value")]
		public string M3_ATAV => GetString("ATAV");

		/// <summary>
		/// Description: Target value
		/// FieldName: ATAN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Target value")]
		public decimal? M3_ATAN => GetNullableDecimal("ATAN");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public string M3_SAPR => GetString("SAPR");

		/// <summary>
		/// Description: Cost price
		/// FieldName: UCOS
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price")]
		public string M3_UCOS => GetString("UCOS");

		/// <summary>
		/// Description: Option description
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option description")]
		public string M3_TX30 => GetString("TX30");

		/// <summary>
		/// Description: Sales price
		/// FieldName: LOSP
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public string M3_LOSP => GetString("LOSP");

		/// <summary>
		/// Description: Local currency code
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency code")]
		public string M3_LOCD => GetString("LOCD");

		/// <summary>
		/// Description: Attribute value sequence number
		/// FieldName: AVSQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value sequence number")]
		public int? M3_AVSQ => GetNullableInt("AVSQ");

		/// <summary>
		/// Description: Display group
		/// FieldName: DSPG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Display group")]
		public string M3_DSPG => GetString("DSPG");

		/// <summary>
		/// Description: Attachment indicator
		/// FieldName: ATCI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attachment indicator")]
		public int? M3_ATCI => GetNullableInt("ATCI");

		/// <summary>
		/// Description: Shipless indicator
		/// FieldName: SHIP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipless indicator")]
		public int? M3_SHIP => GetNullableInt("SHIP");

		/// <summary>
		/// Description: Item attribute
		/// FieldName: IATT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item attribute")]
		public int? M3_IATT => GetNullableInt("IATT");
	}
}
// EOF
