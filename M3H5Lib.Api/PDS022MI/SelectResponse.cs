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

namespace M3H5Lib.Api.PDS022MI
{
	public partial class SelectResponse : M3BaseRecord 
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
		/// Description: Current MO key type
		/// FieldName: CKTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Current MO key type")]
		public int? M3CKTP => GetNullableInt("CKTP");

		/// <summary>
		/// Description: Current MO key
		/// FieldName: CMKY
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Current MO key")]
		public string M3CMKY => GetString("CMKY");

		/// <summary>
		/// Description: Previous MO key type
		/// FieldName: PKTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous MO key type")]
		public int? M3PKTP => GetNullableInt("PKTP");

		/// <summary>
		/// Description: Previous MO key
		/// FieldName: PMKY
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous MO key")]
		public string M3PMKY => GetString("PMKY");

		/// <summary>
		/// Description: From date
		/// FieldName: FDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public DateTime? M3FDAT => GetNullableDateTime("FDAT");

		/// <summary>
		/// Description: Setup time
		/// FieldName: SETI
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time")]
		public int? M3SETI => GetNullableInt("SETI");

		/// <summary>
		/// Description: Setup time type
		/// FieldName: SETT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time type")]
		public int? M3SETT => GetNullableInt("SETT");

		/// <summary>
		/// Description: Selection matrix
		/// FieldName: MXID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection matrix")]
		public string M3MXID => GetString("MXID");

		/// <summary>
		/// Description: To date
		/// FieldName: TDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3TDAT => GetNullableDateTime("TDAT");

		/// <summary>
		/// Description: Current warehouse               (M9REWH)
		/// FieldName: CWHL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Current warehouse               (M9REWH)")]
		public string M3CWHL => GetString("CWHL");

		/// <summary>
		/// Description: Previous warehouse              (M9REWH)
		/// FieldName: PWHL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous warehouse              (M9REWH)")]
		public string M3PWHL => GetString("PWHL");

		/// <summary>
		/// Description: Setuptime expressed in hours
		/// FieldName: SET2
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setuptime expressed in hours")]
		public int? M3SET2 => GetNullableInt("SET2");
	}
}
// EOF
