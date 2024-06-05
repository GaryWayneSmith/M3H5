/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.SOS500MI
{
	public partial class GetFixedPrAssigResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Service order job number
		/// FieldName: JOBN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service order job number")]
		public int? M3JOBN => GetNullableInt("JOBN");

		/// <summary>
		/// Description: Assignment suffix
		/// FieldName: JBSX
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assignment suffix")]
		public int? M3JBSX => GetNullableInt("JBSX");

		/// <summary>
		/// Description: Total price
		/// FieldName: TOPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total price")]
		public decimal? M3TOPR => GetNullableDecimal("TOPR");

		/// <summary>
		/// Description: Price labor done
		/// FieldName: TOPL
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price labor done")]
		public decimal? M3TOPL => GetNullableDecimal("TOPL");

		/// <summary>
		/// Description: Price for all parts
		/// FieldName: TOPP
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price for all parts")]
		public decimal? M3TOPP => GetNullableDecimal("TOPP");

		/// <summary>
		/// Description: Serv expense cat 1
		/// FieldName: SCO1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv expense cat 1")]
		public int? M3SCO1 => GetNullableInt("SCO1");

		/// <summary>
		/// Description: Serv expense cat 2
		/// FieldName: SCO2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv expense cat 2")]
		public int? M3SCO2 => GetNullableInt("SCO2");

		/// <summary>
		/// Description: Serv expense cat 3
		/// FieldName: SCO3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv expense cat 3")]
		public int? M3SCO3 => GetNullableInt("SCO3");

		/// <summary>
		/// Description: Serv expense cat 4
		/// FieldName: SCO4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv expense cat 4")]
		public int? M3SCO4 => GetNullableInt("SCO4");

		/// <summary>
		/// Description: Serv expense cat 5
		/// FieldName: SCO5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv expense cat 5")]
		public int? M3SCO5 => GetNullableInt("SCO5");

		/// <summary>
		/// Description: Serv expense cat 6
		/// FieldName: SCO6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv expense cat 6")]
		public int? M3SCO6 => GetNullableInt("SCO6");

		/// <summary>
		/// Description: Serv expense cat 7
		/// FieldName: SCO7
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv expense cat 7")]
		public int? M3SCO7 => GetNullableInt("SCO7");

		/// <summary>
		/// Description: Serv expense cat 8
		/// FieldName: SCO8
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv expense cat 8")]
		public int? M3SCO8 => GetNullableInt("SCO8");

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
		/// Description: Pre-text
		/// FieldName: PRTX
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pre-text")]
		public decimal? M3PRTX => GetNullableDecimal("PRTX");

		/// <summary>
		/// Description: Post-text
		/// FieldName: POTX
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-text")]
		public decimal? M3POTX => GetNullableDecimal("POTX");

		/// <summary>
		/// Description: Received date
		/// FieldName: RDTE
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Received date")]
		public DateTime? M3RDTE => GetNullableDateTime("RDTE");

		/// <summary>
		/// Description: Received time
		/// FieldName: RTIM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Received time")]
		public int? M3RTIM => GetNullableInt("RTIM");

		/// <summary>
		/// Description: Additional equipment
		/// FieldName: ADEQ
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional equipment")]
		public string M3ADEQ => GetString("ADEQ");

		/// <summary>
		/// Description: Individual item condition
		/// FieldName: CNDI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item condition")]
		public string M3CNDI => GetString("CNDI");
	}
}
// EOF
