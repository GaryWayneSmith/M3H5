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

namespace M3H5Lib.Api.CRS022MI
{
	public partial class LstSortOrderResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Program name
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3_PGNM => GetString("PGNM");

		/// <summary>
		/// Description: Inquiry type
		/// FieldName: QTTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inquiry type")]
		public int? M3_QTTP => GetNullableInt("QTTP");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Table
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Table")]
		public string M3_FILE => GetString("FILE");

		/// <summary>
		/// Description: Sorting option
		/// FieldName: SOPT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting option")]
		public string M3_SOPT => GetString("SOPT");

		/// <summary>
		/// Description: Number of filters
		/// FieldName: NFTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of filters")]
		public int? M3_NFTR => GetNullableInt("NFTR");

		/// <summary>
		/// Description: View
		/// FieldName: PAV1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("View")]
		public string M3_PAV1 => GetString("PAV1");

		/// <summary>
		/// Description: View
		/// FieldName: PAV2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("View")]
		public string M3_PAV2 => GetString("PAV2");

		/// <summary>
		/// Description: View
		/// FieldName: PAV3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("View")]
		public string M3_PAV3 => GetString("PAV3");

		/// <summary>
		/// Description: View
		/// FieldName: PAV4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("View")]
		public string M3_PAV4 => GetString("PAV4");

		/// <summary>
		/// Description: View
		/// FieldName: PAV5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("View")]
		public string M3_PAV5 => GetString("PAV5");

		/// <summary>
		/// Description: View
		/// FieldName: PAV6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("View")]
		public string M3_PAV6 => GetString("PAV6");

		/// <summary>
		/// Description: Panel sequence
		/// FieldName: PSEQ
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel sequence")]
		public string M3_PSEQ => GetString("PSEQ");

		/// <summary>
		/// Description: Selection table
		/// FieldName: TABL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection table")]
		public string M3_TABL => GetString("TABL");

		/// <summary>
		/// Description: Aggregation
		/// FieldName: AGGR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aggregation")]
		public int? M3_AGGR => GetNullableInt("AGGR");

		/// <summary>
		/// Description: Key value
		/// FieldName: OBK1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value")]
		public string M3_OBK1 => GetString("OBK1");

		/// <summary>
		/// Description: Key value
		/// FieldName: OBK2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value")]
		public string M3_OBK2 => GetString("OBK2");

		/// <summary>
		/// Description: Key value
		/// FieldName: OBK3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value")]
		public string M3_OBK3 => GetString("OBK3");

		/// <summary>
		/// Description: Key value
		/// FieldName: OBK4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value")]
		public string M3_OBK4 => GetString("OBK4");

		/// <summary>
		/// Description: Key value
		/// FieldName: OBK5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value")]
		public string M3_OBK5 => GetString("OBK5");

		/// <summary>
		/// Description: Key value
		/// FieldName: OBK6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value")]
		public string M3_OBK6 => GetString("OBK6");

		/// <summary>
		/// Description: Key value
		/// FieldName: OBK7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value")]
		public string M3_OBK7 => GetString("OBK7");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");

		/// <summary>
		/// Description: Sorting order zoom
		/// FieldName: SOZ1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting order zoom")]
		public int? M3_SOZ1 => GetNullableInt("SOZ1");

		/// <summary>
		/// Description: Sorting order zoom
		/// FieldName: SOZ2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting order zoom")]
		public int? M3_SOZ2 => GetNullableInt("SOZ2");

		/// <summary>
		/// Description: Sorting order zoom
		/// FieldName: SOZ3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting order zoom")]
		public int? M3_SOZ3 => GetNullableInt("SOZ3");

		/// <summary>
		/// Description: Sorting order zoom
		/// FieldName: SOZ4
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting order zoom")]
		public int? M3_SOZ4 => GetNullableInt("SOZ4");

		/// <summary>
		/// Description: Sorting order zoom
		/// FieldName: SOZ5
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting order zoom")]
		public int? M3_SOZ5 => GetNullableInt("SOZ5");

		/// <summary>
		/// Description: Sorting order zoom
		/// FieldName: SOZ6
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting order zoom")]
		public int? M3_SOZ6 => GetNullableInt("SOZ6");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: Panel sequence
		/// FieldName: USEQ
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel sequence")]
		public string M3_USEQ => GetString("USEQ");

		/// <summary>
		/// Description: User panel version
		/// FieldName: UPV1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User panel version")]
		public string M3_UPV1 => GetString("UPV1");

		/// <summary>
		/// Description: User panel version
		/// FieldName: UPV2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User panel version")]
		public string M3_UPV2 => GetString("UPV2");

		/// <summary>
		/// Description: User panel version
		/// FieldName: UPV3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User panel version")]
		public string M3_UPV3 => GetString("UPV3");

		/// <summary>
		/// Description: User panel version
		/// FieldName: UPV4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User panel version")]
		public string M3_UPV4 => GetString("UPV4");

		/// <summary>
		/// Description: User panel version
		/// FieldName: UPV5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User panel version")]
		public string M3_UPV5 => GetString("UPV5");

		/// <summary>
		/// Description: User panel version
		/// FieldName: UPV6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User panel version")]
		public string M3_UPV6 => GetString("UPV6");

		/// <summary>
		/// Description: Information browser category
		/// FieldName: IBCA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information browser category")]
		public string M3_IBCA => GetString("IBCA");
	}
}
// EOF
