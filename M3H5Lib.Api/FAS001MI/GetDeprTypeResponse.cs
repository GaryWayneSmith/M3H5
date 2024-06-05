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

namespace M3H5Lib.Api.FAS001MI
{
	public partial class GetDeprTypeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Status - fixed asset
		/// FieldName: FAST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - fixed asset")]
		public int? M3_FAST => GetNullableInt("FAST");

		/// <summary>
		/// Description: Fixed asset type
		/// FieldName: FATP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset type")]
		public string M3_FATP => GetString("FATP");

		/// <summary>
		/// Description: Depreciation type
		/// FieldName: DPTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Depreciation type")]
		public int? M3_DPTP => GetNullableInt("DPTP");

		/// <summary>
		/// Description: Depreciation method
		/// FieldName: DPMD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Depreciation method")]
		public int? M3_DPMD => GetNullableInt("DPMD");

		/// <summary>
		/// Description: Economic life
		/// FieldName: NOYR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Economic life")]
		public int? M3_NOYR => GetNullableInt("NOYR");

		/// <summary>
		/// Description: Lifetime in months
		/// FieldName: NOMT
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lifetime in months")]
		public int? M3_NOMT => GetNullableInt("NOMT");

		/// <summary>
		/// Description: Semi-annual adjustment
		/// FieldName: HYAD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Semi-annual adjustment")]
		public int? M3_HYAD => GetNullableInt("HYAD");

		/// <summary>
		/// Description: Value type
		/// FieldName: VTAD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value type")]
		public int? M3_VTAD => GetNullableInt("VTAD");

		/// <summary>
		/// Description: Depreciation share
		/// FieldName: NPER
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Depreciation share")]
		public int? M3_NPER => GetNullableInt("NPER");

		/// <summary>
		/// Description: Stop value
		/// FieldName: SVAL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stop value")]
		public decimal? M3_SVAL => GetNullableDecimal("SVAL");

		/// <summary>
		/// Description: Processing of remaining value
		/// FieldName: STPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Processing of remaining value")]
		public int? M3_STPC => GetNullableInt("STPC");

		/// <summary>
		/// Description: Method change
		/// FieldName: DELN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Method change")]
		public int? M3_DELN => GetNullableInt("DELN");

		/// <summary>
		/// Description: Depreciation plan
		/// FieldName: DTTB
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Depreciation plan")]
		public string M3_DTTB => GetString("DTTB");

		/// <summary>
		/// Description: Last depreciation period
		/// FieldName: LPER
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last depreciation period")]
		public int? M3_LPER => GetNullableInt("LPER");

		/// <summary>
		/// Description: Value type
		/// FieldName: VTDP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value type")]
		public int? M3_VTDP => GetNullableInt("VTDP");

		/// <summary>
		/// Description: Automatic change of depreciation method
		/// FieldName: DTLC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic change of depreciation method")]
		public string M3_DTLC => GetString("DTLC");

		/// <summary>
		/// Description: Coefficient template
		/// FieldName: MDTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Coefficient template")]
		public string M3_MDTP => GetString("MDTP");

		/// <summary>
		/// Description: Digressive to linear transfer period
		/// FieldName: DTLP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Digressive to linear transfer period")]
		public int? M3_DTLP => GetNullableInt("DTLP");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
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
		/// Description: Period type
		/// FieldName: DPBC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type")]
		public int? M3_DPBC => GetNullableInt("DPBC");

		/// <summary>
		/// Description: Below 0
		/// FieldName: BELZ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Below 0")]
		public int? M3_BELZ => GetNullableInt("BELZ");

		/// <summary>
		/// Description: Start period method
		/// FieldName: SPME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start period method")]
		public int? M3_SPME => GetNullableInt("SPME");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3_LMTS => GetNullableDecimal("LMTS");

		/// <summary>
		/// Description: Bonus Rate
		/// FieldName: BNRT
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus Rate")]
		public int? M3_BNRT => GetNullableInt("BNRT");

		/// <summary>
		/// Description: Accounting model ID
		/// FieldName: MOID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting model ID")]
		public string M3_MOID => GetString("MOID");

		/// <summary>
		/// Description: Accounting model line
		/// FieldName: MOLN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting model line")]
		public int? M3_MOLN => GetNullableInt("MOLN");

		/// <summary>
		/// Description: Zero revenue
		/// FieldName: ZREV
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Zero revenue")]
		public string M3_ZREV => GetString("ZREV");

		/// <summary>
		/// Description: Operation plan version
		/// FieldName: OPVR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation plan version")]
		public string M3_OPVR => GetString("OPVR");
	}
}
// EOF
