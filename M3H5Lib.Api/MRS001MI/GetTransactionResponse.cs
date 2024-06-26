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

namespace M3H5Lib.Api.MRS001MI
{
	public partial class GetTransactionResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Program name
		/// FieldName: MINM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3MINM => GetString("MINM");

		/// <summary>
		/// Description: Transaction name
		/// FieldName: TRNM
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction name")]
		public string M3TRNM => GetString("TRNM");

		/// <summary>
		/// Description: Transaction description
		/// FieldName: TRDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction description")]
		public string M3TRDS => GetString("TRDS");

		/// <summary>
		/// Description: Text ID of leading description
		/// FieldName: TXT1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text ID of leading description")]
		public decimal? M3TXT1 => GetNullableDecimal("TXT1");

		/// <summary>
		/// Description: Text ID of trailing description
		/// FieldName: TXT2
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text ID of trailing description")]
		public decimal? M3TXT2 => GetNullableDecimal("TXT2");

		/// <summary>
		/// Description: Movex version/release
		/// FieldName: VERS
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Movex version/release")]
		public string M3VERS => GetString("VERS");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public int? M3STAT => GetNullableInt("STAT");

		/// <summary>
		/// Description: Prefix input
		/// FieldName: PRFI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prefix input")]
		public string M3PRFI => GetString("PRFI");

		/// <summary>
		/// Description: Prefix output
		/// FieldName: PRFO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prefix output")]
		public string M3PRFO => GetString("PRFO");

		/// <summary>
		/// Description: Transaction type, Single/Multiple
		/// FieldName: SIMU
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type, Single/Multiple")]
		public string M3SIMU => GetString("SIMU");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 8
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
	}
}
// EOF
