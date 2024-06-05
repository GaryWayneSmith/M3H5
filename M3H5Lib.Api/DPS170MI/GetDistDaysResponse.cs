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

namespace M3H5Lib.Api.DPS170MI
{
	public partial class GetDistDaysResponse : M3BaseRecord 
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
		/// Description: Division (for from whs)
		/// FieldName: DIVF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division (for from whs)")]
		public string M3_DIVF => GetString("DIVF");

		/// <summary>
		/// Description: Facility (for from whs)
		/// FieldName: FACF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility (for from whs)")]
		public string M3_FACF => GetString("FACF");

		/// <summary>
		/// Description: From warehouse
		/// FieldName: FWLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From warehouse")]
		public string M3_FWLO => GetString("FWLO");

		/// <summary>
		/// Description: Division (for to whs)
		/// FieldName: DIVT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division (for to whs)")]
		public string M3_DIVT => GetString("DIVT");

		/// <summary>
		/// Description: Facility (for to whs)
		/// FieldName: FACT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility (for to whs)")]
		public string M3_FACT => GetString("FACT");

		/// <summary>
		/// Description: To warehouse
		/// FieldName: TWLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To warehouse")]
		public string M3_TWLO => GetString("TWLO");

		/// <summary>
		/// Description: Valid from (i.e start interval)
		/// FieldName: STD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from (i.e start interval)")]
		public DateTime? M3_STD1 => GetNullableDateTime("STD1");

		/// <summary>
		/// Description: Valid to (i.e end interval)
		/// FieldName: TODA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to (i.e end interval)")]
		public DateTime? M3_TODA => GetNullableDateTime("TODA");

		/// <summary>
		/// Description: Record from MPDRED (1=yes)
		/// FieldName: MPD1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Record from MPDRED (1=yes)")]
		public string M3_MPD1 => GetString("MPD1");
	}
}
// EOF
