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

namespace M3H5Lib.Api.ECS422MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3_CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: ECO number
		/// FieldName: ECON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ECO number")]
		public string M3_ECON => GetString("ECON");

		/// <summary>
		/// Description: Change text
		/// FieldName: ECT1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change text")]
		public string M3_ECT1 => GetString("ECT1");

		/// <summary>
		/// Description: ECO type
		/// FieldName: ECAC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ECO type")]
		public string M3_ECAC => GetString("ECAC");

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
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3_PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Change type
		/// FieldName: ECEX
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change type")]
		public string M3_ECEX => GetString("ECEX");

		/// <summary>
		/// Description: Change ID
		/// FieldName: ECID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change ID")]
		public string M3_ECID => GetString("ECID");

		/// <summary>
		/// Description: Status
		/// FieldName: ECST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_ECST => GetString("ECST");

		/// <summary>
		/// Description: New revision
		/// FieldName: NECV
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New revision")]
		public string M3_NECV => GetString("NECV");

		/// <summary>
		/// Description: Revision number
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3_ECVE => GetString("ECVE");

		/// <summary>
		/// Description: Structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type")]
		public string M3_STRT => GetString("STRT");

		/// <summary>
		/// Description: Old subidentity
		/// FieldName: OLSI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old subidentity")]
		public string M3_OLSI => GetString("OLSI");

		/// <summary>
		/// Description: Old serial number
		/// FieldName: OSEQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old serial number")]
		public int? M3_OSEQ => GetNullableInt("OSEQ");

		/// <summary>
		/// Description: Old operationnumber
		/// FieldName: OOPN
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old operationnumber")]
		public int? M3_OOPN => GetNullableInt("OOPN");

		/// <summary>
		/// Description: New subidentity
		/// FieldName: NWSI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New subidentity")]
		public string M3_NWSI => GetString("NWSI");

		/// <summary>
		/// Description: New sequence number
		/// FieldName: NSEQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New sequence number")]
		public int? M3_NSEQ => GetNullableInt("NSEQ");

		/// <summary>
		/// Description: New operation number
		/// FieldName: NOPN
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New operation number")]
		public int? M3_NOPN => GetNullableInt("NOPN");

		/// <summary>
		/// Description: New qty
		/// FieldName: NCNQ
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New qty")]
		public string M3_NCNQ => GetString("NCNQ");

		/// <summary>
		/// Description: New prod engineering UM
		/// FieldName: NPEU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New prod engineering UM")]
		public string M3_NPEU => GetString("NPEU");

		/// <summary>
		/// Description: Neq qty drawing
		/// FieldName: NCCQ
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Neq qty drawing")]
		public decimal? M3_NCCQ => GetNullableDecimal("NCCQ");

		/// <summary>
		/// Description: New drawing pos
		/// FieldName: NDWP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New drawing pos")]
		public string M3_NDWP => GetString("NDWP");

		/// <summary>
		/// Description: New waste pct
		/// FieldName: NWAP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New waste pct")]
		public int? M3_NWAP => GetNullableInt("NWAP");

		/// <summary>
		/// Description: Selection id - comp
		/// FieldName: SIDI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection id - comp")]
		public string M3_SIDI => GetString("SIDI");

		/// <summary>
		/// Description: Selection type - comp
		/// FieldName: SITI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection type - comp")]
		public int? M3_SITI => GetNullableInt("SITI");

		/// <summary>
		/// Description: Selection id - quantity
		/// FieldName: SIDQ
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection id - quantity")]
		public string M3_SIDQ => GetString("SIDQ");

		/// <summary>
		/// Description: Selection type - quantity
		/// FieldName: SITQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection type - quantity")]
		public int? M3_SITQ => GetNullableInt("SITQ");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FORI
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3_FORI => GetString("FORI");

		/// <summary>
		/// Description: Length
		/// FieldName: LGTH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length")]
		public int? M3_LGTH => GetNullableInt("LGTH");

		/// <summary>
		/// Description: Width
		/// FieldName: WDTH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Width")]
		public int? M3_WDTH => GetNullableInt("WDTH");

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
		/// Description: Qty
		/// FieldName: LWF1
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Qty")]
		public int? M3_LWF1 => GetNullableInt("LWF1");

		/// <summary>
		/// Description: Factor
		/// FieldName: LWF2
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Factor")]
		public int? M3_LWF2 => GetNullableInt("LWF2");

		/// <summary>
		/// Description: From project
		/// FieldName: FPRJ
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From project")]
		public string M3_FPRJ => GetString("FPRJ");

		/// <summary>
		/// Description: From serial number
		/// FieldName: FSNO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From serial number")]
		public string M3_FSNO => GetString("FSNO");

		/// <summary>
		/// Description: From on-hand balance
		/// FieldName: FSQT
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From on-hand balance")]
		public decimal? M3_FSQT => GetNullableDecimal("FSQT");
	}
}
// EOF
