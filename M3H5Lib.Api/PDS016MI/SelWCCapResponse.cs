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

namespace M3H5Lib.Api.PDS016MI
{
	public partial class SelWCCapResponse : M3BaseRecord 
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
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Work center
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3PLGR => GetString("PLGR");

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
		/// Description: Start time
		/// FieldName: STIM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time")]
		public int? M3STIM => GetNullableInt("STIM");

		/// <summary>
		/// Description: Shift
		/// FieldName: SHFC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shift")]
		public string M3SHFC => GetString("SHFC");

		/// <summary>
		/// Description: End time
		/// FieldName: ETIM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End time")]
		public int? M3ETIM => GetNullableInt("ETIM");

		/// <summary>
		/// Description: Utilization rate
		/// FieldName: AVEF
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Utilization rate")]
		public int? M3AVEF => GetNullableInt("AVEF");

		/// <summary>
		/// Description: Nominal number of hours
		/// FieldName: GHRS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Nominal number of hours")]
		public int? M3GHRS => GetNullableInt("GHRS");

		/// <summary>
		/// Description: Capacity type
		/// FieldName: PCAP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity type")]
		public string M3PCAP => GetString("PCAP");

		/// <summary>
		/// Description: Number of machines
		/// FieldName: WCNM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of machines")]
		public int? M3WCNM => GetNullableInt("WCNM");

		/// <summary>
		/// Description: Capacity
		/// FieldName: CPTY
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity")]
		public decimal? M3CPTY => GetNullableDecimal("CPTY");

		/// <summary>
		/// Description: Alternate capacity
		/// FieldName: ACAP
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate capacity")]
		public decimal? M3ACAP => GetNullableDecimal("ACAP");

		/// <summary>
		/// Description: Alternate capacity U/M
		/// FieldName: RCUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate capacity U/M")]
		public string M3RCUN => GetString("RCUN");
	}
}
// EOF
