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

namespace M3H5Lib.Api.CLAIMSMI
{
	public partial class SelClaimSpecResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Claim
		/// FieldName: CLNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim")]
		public string M3CLNO => GetString("CLNO");

		/// <summary>
		/// Description: Version
		/// FieldName: VENO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Version")]
		public int? M3VENO => GetNullableInt("VENO");

		/// <summary>
		/// Description: Claim spec
		/// FieldName: CLSP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim spec")]
		public int? M3CLSP => GetNullableInt("CLSP");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: Line type
		/// FieldName: ALNT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line type")]
		public int? M3ALNT => GetNullableInt("ALNT");

		/// <summary>
		/// Description: Transaction number
		/// FieldName: ALI1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction number")]
		public int? M3ALI1 => GetNullableInt("ALI1");

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

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
		/// Description: Return date
		/// FieldName: ARET
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return date")]
		public DateTime? M3ARET => GetNullableDateTime("ARET");

		/// <summary>
		/// Description: Return date
		/// FieldName: ARE1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return date")]
		public DateTime? M3ARE1 => GetNullableDateTime("ARE1");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: MSEQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3MSEQ => GetNullableInt("MSEQ");

		/// <summary>
		/// Description: Employee number
		/// FieldName: EMNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee number")]
		public string M3EMNO => GetString("EMNO");

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
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Miscellaneous cost type
		/// FieldName: MCTP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Miscellaneous cost type")]
		public string M3MCTP => GetString("MCTP");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Invoiced quantity - basic U/M
		/// FieldName: IVQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced quantity - basic U/M")]
		public decimal? M3IVQT => GetNullableDecimal("IVQT");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3SAPR => GetNullableDecimal("SAPR");

		/// <summary>
		/// Description: Handling charge
		/// FieldName: AHPR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Handling charge")]
		public decimal? M3AHPR => GetNullableDecimal("AHPR");

		/// <summary>
		/// Description: Parts settlement percentage
		/// FieldName: PSPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parts settlement percentage")]
		public int? M3PSPC => GetNullableInt("PSPC");

		/// <summary>
		/// Description: Mfg approved qty
		/// FieldName: MFAQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mfg approved qty")]
		public decimal? M3MFAQ => GetNullableDecimal("MFAQ");

		/// <summary>
		/// Description: Mfg approved price
		/// FieldName: MFAP
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mfg approved price")]
		public decimal? M3MFAP => GetNullableDecimal("MFAP");

		/// <summary>
		/// Description: Mfg handling approved amount
		/// FieldName: MHAA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mfg handling approved amount")]
		public decimal? M3MHAA => GetNullableDecimal("MHAA");

		/// <summary>
		/// Description: Net price
		/// FieldName: NEPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net price")]
		public decimal? M3NEPR => GetNullableDecimal("NEPR");

		/// <summary>
		/// Description: Total amount
		/// FieldName: TOAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total amount")]
		public decimal? M3TOAM => GetNullableDecimal("TOAM");

		/// <summary>
		/// Description: Date part return requested
		/// FieldName: DPRR
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date part return requested")]
		public DateTime? M3DPRR => GetNullableDateTime("DPRR");

		/// <summary>
		/// Description: Part rtn dt ship
		/// FieldName: RTND
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Part rtn dt ship")]
		public DateTime? M3RTND => GetNullableDateTime("RTND");

		/// <summary>
		/// Description: Remark
		/// FieldName: DLRM
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3DLRM => GetString("DLRM");

		/// <summary>
		/// Description: Text
		/// FieldName: TX60
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TX60 => GetString("TX60");

		/// <summary>
		/// Description: Work order number
		/// FieldName: MWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work order number")]
		public string M3MWNO => GetString("MWNO");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: WIP debit
		/// FieldName: AWCO
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("WIP debit")]
		public decimal? M3AWCO => GetNullableDecimal("AWCO");

		/// <summary>
		/// Description: Discount
		/// FieldName: DIPL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount")]
		public int? M3DIPL => GetNullableInt("DIPL");

		/// <summary>
		/// Description: Discount amount
		/// FieldName: DIAL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount")]
		public decimal? M3DIAL => GetNullableDecimal("DIAL");

		/// <summary>
		/// Description: Unit of measure
		/// FieldName: UNIT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit of measure")]
		public string M3UNIT => GetString("UNIT");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Time type
		/// FieldName: TTPE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time type")]
		public string M3TTPE => GetString("TTPE");
	}
}
// EOF
