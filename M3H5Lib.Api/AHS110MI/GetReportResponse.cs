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

namespace M3H5Lib.Api.AHS110MI
{
	public partial class GetReportResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Ad-hoc report
		/// FieldName: REPO
		/// FieldType: A
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ad-hoc report")]
		public string M3REPO => GetString("REPO");

		/// <summary>
		/// Description: Ad-hoc report version
		/// FieldName: REPV
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ad-hoc report version")]
		public string M3REPV => GetString("REPV");

		/// <summary>
		/// Description: Report text
		/// FieldName: LITX
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Report text")]
		public string M3LITX => GetString("LITX");

		/// <summary>
		/// Description: Locked report
		/// FieldName: LCKR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Locked report")]
		public int? M3LCKR => GetNullableInt("LCKR");

		/// <summary>
		/// Description: View
		/// FieldName: PAVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("View")]
		public string M3PAVR => GetString("PAVR");

		/// <summary>
		/// Description: Personal view
		/// FieldName: UPVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Personal view")]
		public string M3UPVR => GetString("UPVR");

		/// <summary>
		/// Description: Object control parameter
		/// FieldName: OBK1
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Object control parameter")]
		public string M3OBK1 => GetString("OBK1");

		/// <summary>
		/// Description: Object control parameter
		/// FieldName: OBK2
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Object control parameter")]
		public string M3OBK2 => GetString("OBK2");

		/// <summary>
		/// Description: Object control parameter
		/// FieldName: OBK3
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Object control parameter")]
		public string M3OBK3 => GetString("OBK3");

		/// <summary>
		/// Description: Object control parameter
		/// FieldName: OBK4
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Object control parameter")]
		public string M3OBK4 => GetString("OBK4");

		/// <summary>
		/// Description: Number of filters
		/// FieldName: NFTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of filters")]
		public int? M3NFTR => GetNullableInt("NFTR");

		/// <summary>
		/// Description: Sorting order
		/// FieldName: QTTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting order")]
		public int? M3QTTP => GetNullableInt("QTTP");

		/// <summary>
		/// Description: Aggregation
		/// FieldName: AGGR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aggregation")]
		public int? M3AGGR => GetNullableInt("AGGR");

		/// <summary>
		/// Description: Subtotal 1
		/// FieldName: SUB1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subtotal 1")]
		public int? M3SUB1 => GetNullableInt("SUB1");

		/// <summary>
		/// Description: Subtotal 2
		/// FieldName: SUB2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subtotal 2")]
		public int? M3SUB2 => GetNullableInt("SUB2");

		/// <summary>
		/// Description: Subtotal 3
		/// FieldName: SUB3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subtotal 3")]
		public int? M3SUB3 => GetNullableInt("SUB3");

		/// <summary>
		/// Description: Selection field 1
		/// FieldName: SLF1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection field 1")]
		public string M3SLF1 => GetString("SLF1");

		/// <summary>
		/// Description: Selection field 2
		/// FieldName: SLF2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection field 2")]
		public string M3SLF2 => GetString("SLF2");

		/// <summary>
		/// Description: Selection field 3
		/// FieldName: SLF3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection field 3")]
		public string M3SLF3 => GetString("SLF3");

		/// <summary>
		/// Description: Selection value 1
		/// FieldName: FSLT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection value 1")]
		public string M3FSLT => GetString("FSLT");

		/// <summary>
		/// Description: Selection value 1
		/// FieldName: TSLT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection value 1")]
		public string M3TSLT => GetString("TSLT");

		/// <summary>
		/// Description: Selection value 2
		/// FieldName: FSL2
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection value 2")]
		public string M3FSL2 => GetString("FSL2");

		/// <summary>
		/// Description: Selection value 2
		/// FieldName: TSL2
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection value 2")]
		public string M3TSL2 => GetString("TSL2");

		/// <summary>
		/// Description: Selection value 3
		/// FieldName: FSL3
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection value 3")]
		public string M3FSL3 => GetString("FSL3");

		/// <summary>
		/// Description: Selection value 3
		/// FieldName: TSL3
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection value 3")]
		public string M3TSL3 => GetString("TSL3");

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
		/// Description: Ad-hoc report e-mail
		/// FieldName: REEM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ad-hoc report e-mail")]
		public int? M3REEM => GetNullableInt("REEM");

		/// <summary>
		/// Description: E-mail type
		/// FieldName: EMTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("E-mail type")]
		public string M3EMTP => GetString("EMTP");

		/// <summary>
		/// Description: E-mail key value
		/// FieldName: EMKY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("E-mail key value")]
		public string M3EMKY => GetString("EMKY");

		/// <summary>
		/// Description: Subject
		/// FieldName: SUBJ
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subject")]
		public string M3SUBJ => GetString("SUBJ");

		/// <summary>
		/// Description: E-mail text
		/// FieldName: EMTX
		/// FieldType: A
		/// Length: 150
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("E-mail text")]
		public string M3EMTX => GetString("EMTX");

		/// <summary>
		/// Description: Ad-hoc report location
		/// FieldName: RLCT
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ad-hoc report location")]
		public string M3RLCT => GetString("RLCT");

		/// <summary>
		/// Description: Period type
		/// FieldName: PETP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type")]
		public int? M3PETP => GetNullableInt("PETP");

		/// <summary>
		/// Description: Job schedule allowed
		/// FieldName: XSAL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job schedule allowed")]
		public int? M3XSAL => GetNullableInt("XSAL");

		/// <summary>
		/// Description: Job schedule category
		/// FieldName: XCAT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job schedule category")]
		public string M3XCAT => GetString("XCAT");

		/// <summary>
		/// Description: Document location
		/// FieldName: DOLO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document location")]
		public string M3DOLO => GetString("DOLO");

		/// <summary>
		/// Description: Sender e-mail address
		/// FieldName: SEEA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sender e-mail address")]
		public string M3SEEA => GetString("SEEA");

		/// <summary>
		/// Description: Save report run
		/// FieldName: RSRR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Save report run")]
		public int? M3RSRR => GetNullableInt("RSRR");

		/// <summary>
		/// Description: Number of days to save report run
		/// FieldName: RNRR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of days to save report run")]
		public int? M3RNRR => GetNullableInt("RNRR");

		/// <summary>
		/// Description: Save report lines
		/// FieldName: RSRL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Save report lines")]
		public int? M3RSRL => GetNullableInt("RSRL");

		/// <summary>
		/// Description: Number of days to save report lines
		/// FieldName: RNRL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of days to save report lines")]
		public int? M3RNRL => GetNullableInt("RNRL");
	}
}
// EOF
