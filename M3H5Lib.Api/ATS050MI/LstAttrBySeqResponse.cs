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

namespace M3H5Lib.Api.ATS050MI
{
	public partial class LstAttrBySeqResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Attribute model
		/// FieldName: ATMO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute model")]
		public string M3_ATMO => GetString("ATMO");

		/// <summary>
		/// Description: Attribute sequence number
		/// FieldName: ANSQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute sequence number")]
		public int? M3_ANSQ => GetNullableInt("ANSQ");

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
		/// Description: Default value
		/// FieldName: DEVA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default value")]
		public string M3_DEVA => GetString("DEVA");

		/// <summary>
		/// Description: Default value
		/// FieldName: DEVN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default value")]
		public decimal? M3_DEVN => GetNullableDecimal("DEVN");

		/// <summary>
		/// Description: Incl Ln  in CO
		/// FieldName: ORIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl Ln  in CO")]
		public int? M3_ORIN => GetNullableInt("ORIN");

		/// <summary>
		/// Description: Incl Ln  in PO
		/// FieldName: ORIP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl Ln  in PO")]
		public int? M3_ORIP => GetNullableInt("ORIP");

		/// <summary>
		/// Description: Incl Ln  in MO
		/// FieldName: ORIM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl Ln  in MO")]
		public int? M3_ORIM => GetNullableInt("ORIM");

		/// <summary>
		/// Description: Incl Ln  in DO
		/// FieldName: ORIR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl Ln  in DO")]
		public int? M3_ORIR => GetNullableInt("ORIR");

		/// <summary>
		/// Description: Incl Ln  in WO
		/// FieldName: ORIS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl Ln  in WO")]
		public int? M3_ORIS => GetNullableInt("ORIS");

		/// <summary>
		/// Description: Incl Ln  in MCO
		/// FieldName: ORIT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl Ln  in MCO")]
		public int? M3_ORIT => GetNullableInt("ORIT");

		/// <summary>
		/// Description: Main attribute
		/// FieldName: MAAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute")]
		public int? M3_MAAT => GetNullableInt("MAAT");

		/// <summary>
		/// Description: Allocation attribute
		/// FieldName: AATT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocation attribute")]
		public int? M3_AATT => GetNullableInt("AATT");

		/// <summary>
		/// Description: Stats key
		/// FieldName: OSAK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stats key")]
		public int? M3_OSAK => GetNullableInt("OSAK");

		/// <summary>
		/// Description: Stats accumulator
		/// FieldName: OSAA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stats accumulator")]
		public int? M3_OSAA => GetNullableInt("OSAA");

		/// <summary>
		/// Description: Planning attribute
		/// FieldName: PLAT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning attribute")]
		public int? M3_PLAT => GetNullableInt("PLAT");

		/// <summary>
		/// Description: Cost attribute
		/// FieldName: CATR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost attribute")]
		public int? M3_CATR => GetNullableInt("CATR");

		/// <summary>
		/// Description: Prt attr value
		/// FieldName: PRII
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prt attr value")]
		public int? M3_PRII => GetNullableInt("PRII");

		/// <summary>
		/// Description: Prt attr info
		/// FieldName: PRFI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prt attr info")]
		public int? M3_PRFI => GetNullableInt("PRFI");

		/// <summary>
		/// Description: Prt on new line
		/// FieldName: PRNL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prt on new line")]
		public int? M3_PRNL => GetNullableInt("PRNL");

		/// <summary>
		/// Description: Prt separator
		/// FieldName: PSEP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prt separator")]
		public string M3_PSEP => GetString("PSEP");

		/// <summary>
		/// Description: Prt sep prefix
		/// FieldName: PSPR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prt sep prefix")]
		public string M3_PSPR => GetString("PSPR");

		/// <summary>
		/// Description: Prt sep suffix
		/// FieldName: PSES
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prt sep suffix")]
		public string M3_PSES => GetString("PSES");

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
		/// Description: Default search attribute
		/// FieldName: SEAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default search attribute")]
		public int? M3_SEAT => GetNullableInt("SEAT");
	}
}
// EOF
