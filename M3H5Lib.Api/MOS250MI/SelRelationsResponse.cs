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

namespace M3H5Lib.Api.MOS250MI
{
	public partial class SelRelationsResponse : M3BaseRecord 
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
		/// Description: APP work center
		/// FieldName: PLG1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP work center")]
		public string M3PLG1 => GetString("PLG1");

		/// <summary>
		/// Description: Resource
		/// FieldName: PLG6
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Resource")]
		public string M3PLG6 => GetString("PLG6");

		/// <summary>
		/// Description: Priority
		/// FieldName: PRIR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public string M3PRIR => GetString("PRIR");

		/// <summary>
		/// Description: Description
		/// FieldName: DSCR
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3DSCR => GetString("DSCR");

		/// <summary>
		/// Description: Replacement code
		/// FieldName: RPLF
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Replacement code")]
		public string M3RPLF => GetString("RPLF");

		/// <summary>
		/// Description: Effectivity factor
		/// FieldName: EFFA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effectivity factor")]
		public string M3EFFA => GetString("EFFA");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");

		/// <summary>
		/// Description: Forced resource
		/// FieldName: PLGF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forced resource")]
		public string M3PLGF => GetString("PLGF");

		/// <summary>
		/// Description: Norm resource
		/// FieldName: PLGN
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Norm resource")]
		public string M3PLGN => GetString("PLGN");

		/// <summary>
		/// Description: Preferred resource
		/// FieldName: SECR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preferred resource")]
		public string M3SECR => GetString("SECR");

		/// <summary>
		/// Description: Forced resource used (y/n)
		/// FieldName: CHKF
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forced resource used (y/n)")]
		public string M3CHKF => GetString("CHKF");
	}
}
// EOF
