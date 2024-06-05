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

namespace M3H5Lib.Api.FCS330MI
{
	public partial class SelResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Distribution table
		/// FieldName: DITI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution table")]
		public string M3DITI => GetString("DITI");

		/// <summary>
		/// Description: From week
		/// FieldName: FRWE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From week")]
		public int? M3FRWE => GetNullableInt("FRWE");

		/// <summary>
		/// Description: To week
		/// FieldName: TOWE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To week")]
		public int? M3TOWE => GetNullableInt("TOWE");

		/// <summary>
		/// Description: Day percentage
		/// FieldName: D1PC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day percentage")]
		public int? M3D1PC => GetNullableInt("D1PC");

		/// <summary>
		/// Description: Day percentage
		/// FieldName: D2PC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day percentage")]
		public int? M3D2PC => GetNullableInt("D2PC");

		/// <summary>
		/// Description: Day percentage
		/// FieldName: D3PC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day percentage")]
		public int? M3D3PC => GetNullableInt("D3PC");

		/// <summary>
		/// Description: Day percentage
		/// FieldName: D4PC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day percentage")]
		public int? M3D4PC => GetNullableInt("D4PC");

		/// <summary>
		/// Description: Day percentage
		/// FieldName: D5PC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day percentage")]
		public int? M3D5PC => GetNullableInt("D5PC");

		/// <summary>
		/// Description: Day percentage
		/// FieldName: D6PC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day percentage")]
		public int? M3D6PC => GetNullableInt("D6PC");

		/// <summary>
		/// Description: Day percentage
		/// FieldName: D7PC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day percentage")]
		public int? M3D7PC => GetNullableInt("D7PC");

		/// <summary>
		/// Description: Day 1 quantity
		/// FieldName: DAQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day 1 quantity")]
		public decimal? M3DAQ1 => GetNullableDecimal("DAQ1");

		/// <summary>
		/// Description: Day 2 quantity
		/// FieldName: DAQ2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day 2 quantity")]
		public decimal? M3DAQ2 => GetNullableDecimal("DAQ2");

		/// <summary>
		/// Description: Day 3 quantity
		/// FieldName: DAQ3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day 3 quantity")]
		public decimal? M3DAQ3 => GetNullableDecimal("DAQ3");

		/// <summary>
		/// Description: Day 4 quantity
		/// FieldName: DAQ4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day 4 quantity")]
		public decimal? M3DAQ4 => GetNullableDecimal("DAQ4");

		/// <summary>
		/// Description: Day 5 quantity
		/// FieldName: DAQ5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day 5 quantity")]
		public decimal? M3DAQ5 => GetNullableDecimal("DAQ5");

		/// <summary>
		/// Description: Day 6 quantity
		/// FieldName: DAQ6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day 6 quantity")]
		public decimal? M3DAQ6 => GetNullableDecimal("DAQ6");

		/// <summary>
		/// Description: Day 7 quantity
		/// FieldName: DAQ7
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day 7 quantity")]
		public decimal? M3DAQ7 => GetNullableDecimal("DAQ7");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3LMTS => GetNullableDecimal("LMTS");
	}
}
// EOF
