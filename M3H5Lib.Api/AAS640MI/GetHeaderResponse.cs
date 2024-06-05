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

namespace M3H5Lib.Api.AAS640MI
{
	public partial class GetHeaderResponse : M3BaseRecord 
	{

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
		/// Description: Job number
		/// FieldName: JBNO
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job number")]
		public int? M3_JBNO => GetNullableInt("JBNO");

		/// <summary>
		/// Description: Job date
		/// FieldName: JBDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job date")]
		public DateTime? M3_JBDT => GetNullableDateTime("JBDT");

		/// <summary>
		/// Description: Job time
		/// FieldName: JBTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job time")]
		public int? M3_JBTM => GetNullableInt("JBTM");

		/// <summary>
		/// Description: Output file format
		/// FieldName: OFFM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Output file format")]
		public string M3_OFFM => GetString("OFFM");

		/// <summary>
		/// Description: Report type
		/// FieldName: RPTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Report type")]
		public int? M3_RPTP => GetNullableInt("RPTP");

		/// <summary>
		/// Description: Reporting date
		/// FieldName: RPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting date")]
		public DateTime? M3_RPDT => GetNullableDateTime("RPDT");

		/// <summary>
		/// Description: Accounting dimension from
		/// FieldName: ADFR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension from")]
		public int? M3_ADFR => GetNullableInt("ADFR");

		/// <summary>
		/// Description: Accounting dimension to
		/// FieldName: ADTO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension to")]
		public int? M3_ADTO => GetNullableInt("ADTO");

		/// <summary>
		/// Description: Accounting ID from
		/// FieldName: FRAI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting ID from")]
		public string M3_FRAI => GetString("FRAI");

		/// <summary>
		/// Description: Accounting ID to
		/// FieldName: TOAI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting ID to")]
		public string M3_TOAI => GetString("TOAI");

		/// <summary>
		/// Description: Create/change date from
		/// FieldName: CCFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Create/change date from")]
		public DateTime? M3_CCFD => GetNullableDateTime("CCFD");

		/// <summary>
		/// Description: Create/change date to
		/// FieldName: CCTD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Create/change date to")]
		public DateTime? M3_CCTD => GetNullableDateTime("CCTD");

		/// <summary>
		/// Description: Blocked accounting identity
		/// FieldName: LCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blocked accounting identity")]
		public int? M3_LCCD => GetNullableInt("LCCD");

		/// <summary>
		/// Description: Budget account
		/// FieldName: BUAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget account")]
		public int? M3_BUAC => GetNullableInt("BUAC");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3_LNCD => GetString("LNCD");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");
	}
}
// EOF
