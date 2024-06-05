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

namespace M3H5Lib.Api.PDS028MI
{
	public partial class GetVersionResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

		/// <summary>
		/// Description: Product
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product")]
		public string M3_PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3_STRT => GetString("STRT");

		/// <summary>
		/// Description: Version
		/// FieldName: VRSN
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Version")]
		public int? M3_VRSN => GetNullableInt("VRSN");

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
		/// Description: From date
		/// FieldName: FDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public DateTime? M3_FDAT => GetNullableDateTime("FDAT");

		/// <summary>
		/// Description: To date
		/// FieldName: TDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3_TDAT => GetNullableDateTime("TDAT");

		/// <summary>
		/// Description: Lead time 5 production time all levels
		/// FieldName: LEAA
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time 5 production time all levels")]
		public int? M3_LEAA => GetNullableInt("LEAA");

		/// <summary>
		/// Description: Lead time this level
		/// FieldName: LEAL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time this level")]
		public int? M3_LEAL => GetNullableInt("LEAL");

		/// <summary>
		/// Description: Batch recalculation
		/// FieldName: BACO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Batch recalculation")]
		public int? M3_BACO => GetNullableInt("BACO");

		/// <summary>
		/// Description: Yield quantity
		/// FieldName: BAQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield quantity")]
		public decimal? M3_BAQT => GetNullableDecimal("BAQT");

		/// <summary>
		/// Description: Yield percentage
		/// FieldName: EXPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield percentage")]
		public int? M3_EXPC => GetNullableInt("EXPC");

		/// <summary>
		/// Description: Batch quantity
		/// FieldName: TEXQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Batch quantity")]
		public decimal? M3_TEXQ => GetNullableDecimal("TEXQ");

		/// <summary>
		/// Description: Infinite/finite
		/// FieldName: WLDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Infinite/finite")]
		public int? M3_WLDE => GetNullableInt("WLDE");

		/// <summary>
		/// Description: Number of components
		/// FieldName: NUMA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of components")]
		public int? M3_NUMA => GetNullableInt("NUMA");

		/// <summary>
		/// Description: Number of operations
		/// FieldName: NUOP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of operations")]
		public int? M3_NUOP => GetNullableInt("NUOP");

		/// <summary>
		/// Description: Number of subcontract operations
		/// FieldName: NUSC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of subcontract operations")]
		public int? M3_NUSC => GetNullableInt("NUSC");

		/// <summary>
		/// Description: Number of phantom items
		/// FieldName: NUPH
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of phantom items")]
		public int? M3_NUPH => GetNullableInt("NUPH");

		/// <summary>
		/// Description: Number of yield components
		/// FieldName: NUEX
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of yield components")]
		public int? M3_NUEX => GetNullableInt("NUEX");

		/// <summary>
		/// Description: Number of lot controlling components
		/// FieldName: NUCM
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of lot controlling components")]
		public int? M3_NUCM => GetNullableInt("NUCM");

		/// <summary>
		/// Description: Accumulated queue time
		/// FieldName: ASLA
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accumulated queue time")]
		public int? M3_ASLA => GetNullableInt("ASLA");

		/// <summary>
		/// Description: Cumulative scrap percentage
		/// FieldName: ASPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative scrap percentage")]
		public int? M3_ASPC => GetNullableInt("ASPC");

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
		/// Description: Number of explosion items
		/// FieldName: NUBD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of explosion items")]
		public int? M3_NUBD => GetNullableInt("NUBD");
	}
}
// EOF
