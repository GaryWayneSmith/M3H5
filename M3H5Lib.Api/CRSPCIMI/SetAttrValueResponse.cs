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
	public partial class SetAttrValueResponse : M3BaseRecord 
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
		public string M3ATID => GetString("ATID");

		/// <summary>
		/// Description: Attribute value
		/// FieldName: ATVA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value")]
		public string M3ATVA => GetString("ATVA");

		/// <summary>
		/// Description: Target value
		/// FieldName: ATAN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Target value")]
		public decimal? M3ATAN => GetNullableDecimal("ATAN");

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
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Entry date
		/// FieldName: DATE
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3DATE => GetNullableDateTime("DATE");

		/// <summary>
		/// Description: Attribute type
		/// FieldName: ATVC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute type")]
		public string M3ATVC => GetString("ATVC");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Text
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TX30 => GetString("TX30");

		/// <summary>
		/// Description: Main attribute
		/// FieldName: MAAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute")]
		public int? M3MAAT => GetNullableInt("MAAT");

		/// <summary>
		/// Description: Error
		/// FieldName: ATER
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error")]
		public string M3ATER => GetString("ATER");

		/// <summary>
		/// Description: Text
		/// FieldName: TX60
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TX60 => GetString("TX60");

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
		/// Description: Sales price
		/// FieldName: SAPT
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public string M3SAPT => GetString("SAPT");

		/// <summary>
		/// Description: Cost price
		/// FieldName: UCOT
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price")]
		public string M3UCOT => GetString("UCOT");

		/// <summary>
		/// Description: Text identity attribute line
		/// FieldName: TXI1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity attribute line")]
		public decimal? M3TXI1 => GetNullableDecimal("TXI1");

		/// <summary>
		/// Description: Margin amount
		/// FieldName: MARG
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin amount")]
		public string M3MARG => GetString("MARG");

		/// <summary>
		/// Description: Margin percentage
		/// FieldName: MAPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin percentage")]
		public int? M3MAPC => GetNullableInt("MAPC");

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
		/// FieldName: LOST
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public string M3LOST => GetString("LOST");

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
		/// Description: Attribute value sequence number
		/// FieldName: AVSQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value sequence number")]
		public int? M3AVSQ => GetNullableInt("AVSQ");

		/// <summary>
		/// Description: Attachment indicator
		/// FieldName: ATCI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attachment indicator")]
		public int? M3ATCI => GetNullableInt("ATCI");

		/// <summary>
		/// Description: Shipless indicator
		/// FieldName: SHIP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipless indicator")]
		public int? M3SHIP => GetNullableInt("SHIP");

		/// <summary>
		/// Description: Multiple attribute values
		/// FieldName: MUAV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple attribute values")]
		public int? M3MUAV => GetNullableInt("MUAV");

		/// <summary>
		/// Description: Allow blank
		/// FieldName: ALBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow blank")]
		public int? M3ALBA => GetNullableInt("ALBA");
	}
}
// EOF
