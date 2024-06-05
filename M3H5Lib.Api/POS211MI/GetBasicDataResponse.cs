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

namespace M3H5Lib.Api.POS211MI
{
	public partial class GetBasicDataResponse : M3BaseRecord 
	{

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
		/// Description: Original start date
		/// FieldName: ORSD
		/// FieldType: D
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original start date")]
		public DateTime? M3_ORSD => GetNullableDateTime("ORSD");

		/// <summary>
		/// Description: Planned start date
		/// FieldName: PLSD
		/// FieldType: D
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date")]
		public DateTime? M3_PLSD => GetNullableDateTime("PLSD");

		/// <summary>
		/// Description: Original finish date
		/// FieldName: ORFD
		/// FieldType: D
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original finish date")]
		public DateTime? M3_ORFD => GetNullableDateTime("ORFD");

		/// <summary>
		/// Description: Planned finish date
		/// FieldName: PLFD
		/// FieldType: D
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date")]
		public DateTime? M3_PLFD => GetNullableDateTime("PLFD");

		/// <summary>
		/// Description: Relative days start
		/// FieldName: RELS
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Relative days start")]
		public int? M3_RELS => GetNullableInt("RELS");

		/// <summary>
		/// Description: Relative days finish
		/// FieldName: RELF
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Relative days finish")]
		public int? M3_RELF => GetNullableInt("RELF");

		/// <summary>
		/// Description: Fixed date
		/// FieldName: FIXD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed date")]
		public int? M3_FIXD => GetNullableInt("FIXD");

		/// <summary>
		/// Description: Planned days
		/// FieldName: PLDA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned days")]
		public int? M3_PLDA => GetNullableInt("PLDA");

		/// <summary>
		/// Description: Planned hours
		/// FieldName: PLHO
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned hours")]
		public long? M3_PLHO => GetNullableLong("PLHO");

		/// <summary>
		/// Description: Priority
		/// FieldName: OPRI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3_OPRI => GetNullableInt("OPRI");

		/// <summary>
		/// Description: Milestone
		/// FieldName: MILS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Milestone")]
		public int? M3_MILS => GetNullableInt("MILS");

		/// <summary>
		/// Description: Relative time setting
		/// FieldName: RLTS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Relative time setting")]
		public int? M3_RLTS => GetNullableInt("RLTS");

		/// <summary>
		/// Description: Actual start date
		/// FieldName: RSDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start date")]
		public DateTime? M3_RSDT => GetNullableDateTime("RSDT");

		/// <summary>
		/// Description: Expected start date
		/// FieldName: EXPS
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected start date")]
		public DateTime? M3_EXPS => GetNullableDateTime("EXPS");

		/// <summary>
		/// Description: Actual finish date
		/// FieldName: REFD
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual finish date")]
		public DateTime? M3_REFD => GetNullableDateTime("REFD");

		/// <summary>
		/// Description: Expected finish date
		/// FieldName: EXPF
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected finish date")]
		public DateTime? M3_EXPF => GetNullableDateTime("EXPF");

		/// <summary>
		/// Description: Lowest expected start date nxt lower lvl
		/// FieldName: BPLS
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest expected start date nxt lower lvl")]
		public DateTime? M3_BPLS => GetNullableDateTime("BPLS");

		/// <summary>
		/// Description: Highest expected finish dt nxt lower lvl
		/// FieldName: BPLF
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest expected finish dt nxt lower lvl")]
		public DateTime? M3_BPLF => GetNullableDateTime("BPLF");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 8
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
	}
}
// EOF
