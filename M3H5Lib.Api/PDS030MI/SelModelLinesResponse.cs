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

namespace M3H5Lib.Api.PDS030MI
{
	public partial class SelModelLinesResponse : M3BaseRecord 
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
		/// Description: Shift model
		/// FieldName: SHFM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shift model")]
		public string M3_SHFM => GetString("SHFM");

		/// <summary>
		/// Description: Start day
		/// FieldName: SDAY
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start day")]
		public string M3_SDAY => GetString("SDAY");

		/// <summary>
		/// Description: Start time
		/// FieldName: STIM
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time")]
		public string M3_STIM => GetString("STIM");

		/// <summary>
		/// Description: End day
		/// FieldName: EDAY
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End day")]
		public string M3_EDAY => GetString("EDAY");

		/// <summary>
		/// Description: End time
		/// FieldName: ETIM
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End time")]
		public string M3_ETIM => GetString("ETIM");

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
		/// Description: APP shift reference
		/// FieldName: PMSR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP shift reference")]
		public int? M3_PMSR => GetNullableInt("PMSR");

		/// <summary>
		/// Description: Gross capacity
		/// FieldName: GHRS
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross capacity")]
		public int? M3_GHRS => GetNullableInt("GHRS");

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
		/// Description: Shift Model description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shift Model description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Shift Model name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shift Model name")]
		public string M3_TX15 => GetString("TX15");
	}
}
// EOF
