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

namespace M3H5Lib.Api.PDS016MI
{
	public partial class GetDailyCapResponse : M3BaseRecord 
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
		/// Description: Workcenter
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Workcenter")]
		public string M3_PLGR => GetString("PLGR");

		/// <summary>
		/// Description: Entrydate
		/// FieldName: DATE
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entrydate")]
		public DateTime? M3_DATE => GetNullableDateTime("DATE");

		/// <summary>
		/// Description: Starttime
		/// FieldName: STIM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Starttime")]
		public int? M3_STIM => GetNullableInt("STIM");

		/// <summary>
		/// Description: Shift
		/// FieldName: SHFC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shift")]
		public string M3_SHFC => GetString("SHFC");

		/// <summary>
		/// Description: Endtime
		/// FieldName: ETIM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Endtime")]
		public int? M3_ETIM => GetNullableInt("ETIM");

		/// <summary>
		/// Description: Utilizationrate
		/// FieldName: AVEF
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Utilizationrate")]
		public int? M3_AVEF => GetNullableInt("AVEF");

		/// <summary>
		/// Description: Nominalnumberofhours
		/// FieldName: GHRS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Nominalnumberofhours")]
		public int? M3_GHRS => GetNullableInt("GHRS");

		/// <summary>
		/// Description: Capacitytype
		/// FieldName: PCAP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacitytype")]
		public string M3_PCAP => GetString("PCAP");

		/// <summary>
		/// Description: Numberofmachines
		/// FieldName: WCNM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numberofmachines")]
		public int? M3_WCNM => GetNullableInt("WCNM");

		/// <summary>
		/// Description: Capacity
		/// FieldName: CPTY
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity")]
		public decimal? M3_CPTY => GetNullableDecimal("CPTY");

		/// <summary>
		/// Description: Alternatecapacity
		/// FieldName: ACAP
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternatecapacity")]
		public decimal? M3_ACAP => GetNullableDecimal("ACAP");

		/// <summary>
		/// Description: AlternatecapacityU/M
		/// FieldName: RCUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("AlternatecapacityU/M")]
		public string M3_RCUN => GetString("RCUN");
	}
}
// EOF
