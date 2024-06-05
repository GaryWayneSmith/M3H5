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

namespace M3H5Lib.Api.CRS096MI
{
	public partial class GetMilestoneLnResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Milestone chain
		/// FieldName: MSTN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Milestone chain")]
		public long? M3_MSTN => GetNullableLong("MSTN");

		/// <summary>
		/// Description: Milestone template
		/// FieldName: MICI
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Milestone template")]
		public string M3_MICI => GetString("MICI");

		/// <summary>
		/// Description: Project number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number")]
		public string M3_PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3_ELNO => GetString("ELNO");

		/// <summary>
		/// Description: Line number
		/// FieldName: LINO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3_LINO => GetNullableInt("LINO");

		/// <summary>
		/// Description: Element type
		/// FieldName: MIC1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Element type")]
		public string M3_MIC1 => GetString("MIC1");

		/// <summary>
		/// Description: Milestone identity
		/// FieldName: MIID
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Milestone identity")]
		public string M3_MIID => GetString("MIID");

		/// <summary>
		/// Description: Milestone type
		/// FieldName: MITP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Milestone type")]
		public string M3_MITP => GetString("MITP");

		/// <summary>
		/// Description: Milestone category
		/// FieldName: MICA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Milestone category")]
		public string M3_MICA => GetString("MICA");

		/// <summary>
		/// Description: Planning date
		/// FieldName: PLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning date")]
		public DateTime? M3_PLDT => GetNullableDateTime("PLDT");

		/// <summary>
		/// Description: Forecast date-First
		/// FieldName: MIF1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast date-First")]
		public DateTime? M3_MIF1 => GetNullableDateTime("MIF1");

		/// <summary>
		/// Description: Forecast date-Last
		/// FieldName: MIFL
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast date-Last")]
		public DateTime? M3_MIFL => GetNullableDateTime("MIFL");

		/// <summary>
		/// Description: Float days - First (Forecast date)
		/// FieldName: FACF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Float days - First (Forecast date)")]
		public decimal? M3_FACF => GetNullableDecimal("FACF");

		/// <summary>
		/// Description: PO no (Forecast - First)
		/// FieldName: PUN1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PO no (Forecast - First)")]
		public string M3_PUN1 => GetString("PUN1");

		/// <summary>
		/// Description: PO line (Forecast - First)
		/// FieldName: PNL1
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PO line (Forecast - First)")]
		public int? M3_PNL1 => GetNullableInt("PNL1");

		/// <summary>
		/// Description: Float days - Last (Forecast date)
		/// FieldName: FAC1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Float days - Last (Forecast date)")]
		public decimal? M3_FAC1 => GetNullableDecimal("FAC1");

		/// <summary>
		/// Description: PO no (Forecast-Last)
		/// FieldName: PUN2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PO no (Forecast-Last)")]
		public string M3_PUN2 => GetString("PUN2");

		/// <summary>
		/// Description: PO line (Forecast-Last)
		/// FieldName: PNL2
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PO line (Forecast-Last)")]
		public int? M3_PNL2 => GetNullableInt("PNL2");

		/// <summary>
		/// Description: Actual date-First
		/// FieldName: MIA1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual date-First")]
		public DateTime? M3_MIA1 => GetNullableDateTime("MIA1");

		/// <summary>
		/// Description: Actual date-Last
		/// FieldName: MIAD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual date-Last")]
		public DateTime? M3_MIAD => GetNullableDateTime("MIAD");

		/// <summary>
		/// Description: Float days-First (Actual date)
		/// FieldName: MID1
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Float days-First (Actual date)")]
		public int? M3_MID1 => GetNullableInt("MID1");

		/// <summary>
		/// Description: PO no (Actual - First)
		/// FieldName: PUN3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PO no (Actual - First)")]
		public string M3_PUN3 => GetString("PUN3");

		/// <summary>
		/// Description: PO line (Actual - First)
		/// FieldName: PNL3
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PO line (Actual - First)")]
		public int? M3_PNL3 => GetNullableInt("PNL3");

		/// <summary>
		/// Description: Float days-Last (Actual date)
		/// FieldName: MIDT
		/// FieldType: D
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Float days-Last (Actual date)")]
		public DateTime? M3_MIDT => GetNullableDateTime("MIDT");

		/// <summary>
		/// Description: PO no (Actual - Last)
		/// FieldName: PUN4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PO no (Actual - Last)")]
		public string M3_PUN4 => GetString("PUN4");

		/// <summary>
		/// Description: PO line (Actual-Line)
		/// FieldName: PNL4
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PO line (Actual-Line)")]
		public int? M3_PNL4 => GetNullableInt("PNL4");

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
		/// Description: Send application message
		/// FieldName: SNDM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Send application message")]
		public int? M3_SNDM => GetNullableInt("SNDM");
	}
}
// EOF
