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

namespace M3H5Lib.Api.DRS500MI
{
	public partial class LstFCMDetResponse : M3BaseRecord 
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
		/// Description: Freight rate aggregation level
		/// FieldName: FRAL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight rate aggregation level")]
		public int? M3FRAL => GetNullableInt("FRAL");

		/// <summary>
		/// Description: Shipment
		/// FieldName: CONN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment")]
		public int? M3CONN => GetNullableInt("CONN");

		/// <summary>
		/// Description: Delivery number
		/// FieldName: DLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3DLIX => GetNullableDecimal("DLIX");

		/// <summary>
		/// Description: Order number
		/// FieldName: RIDN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order number")]
		public string M3RIDN => GetString("RIDN");

		/// <summary>
		/// Description: Order line
		/// FieldName: RIDL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line")]
		public int? M3RIDL => GetNullableInt("RIDL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RIDX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RIDX => GetNullableInt("RIDX");

		/// <summary>
		/// Description: Stock transaction type
		/// FieldName: TTYP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock transaction type")]
		public int? M3TTYP => GetNullableInt("TTYP");

		/// <summary>
		/// Description: Sequence number - freight element
		/// FieldName: FDSE
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number - freight element")]
		public int? M3FDSE => GetNullableInt("FDSE");

		/// <summary>
		/// Description: Freight rate element
		/// FieldName: FREL
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight rate element")]
		public string M3FREL => GetString("FREL");

		/// <summary>
		/// Description: Freight operator
		/// FieldName: FROP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight operator")]
		public string M3FROP => GetString("FROP");

		/// <summary>
		/// Description: Freight rate
		/// FieldName: FRRA
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight rate")]
		public decimal? M3FRRA => GetNullableDecimal("FRRA");

		/// <summary>
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Exchange rate type
		/// FieldName: CRTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public int? M3CRTP => GetNullableInt("CRTP");

		/// <summary>
		/// Description: Freight element amount
		/// FieldName: ECMT
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight element amount")]
		public decimal? M3ECMT => GetNullableDecimal("ECMT");

		/// <summary>
		/// Description: Calculated quantity
		/// FieldName: CQTY
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated quantity")]
		public decimal? M3CQTY => GetNullableDecimal("CQTY");

		/// <summary>
		/// Description: Recipient pays
		/// FieldName: RCPY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recipient pays")]
		public int? M3RCPY => GetNullableInt("RCPY");

		/// <summary>
		/// Description: Manual update - freight rate
		/// FieldName: MNUP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual update - freight rate")]
		public int? M3MNUP => GetNullableInt("MNUP");

		/// <summary>
		/// Description: Manually locked
		/// FieldName: MLCK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manually locked")]
		public int? M3MLCK => GetNullableInt("MLCK");

		/// <summary>
		/// Description: Manually changed
		/// FieldName: MCHG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manually changed")]
		public int? M3MCHG => GetNullableInt("MCHG");

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
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
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
		/// Description: Included in internal freight cost
		/// FieldName: IINT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in internal freight cost")]
		public int? M3IINT => GetNullableInt("IINT");

		/// <summary>
		/// Description: Included in freight cost PO to main fwdr
		/// FieldName: IIPO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in freight cost PO to main fwdr")]
		public int? M3IIPO => GetNullableInt("IIPO");

		/// <summary>
		/// Description: Included in freight charge to consignee
		/// FieldName: IEXT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in freight charge to consignee")]
		public int? M3IEXT => GetNullableInt("IEXT");

		/// <summary>
		/// Description: Freight charge ID
		/// FieldName: FCID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight charge ID")]
		public string M3FCID => GetString("FCID");

		/// <summary>
		/// Description: Included in PO to 3rd-party forwarder
		/// FieldName: I3PT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in PO to 3rd-party forwarder")]
		public int? M3I3PT => GetNullableInt("I3PT");

		/// <summary>
		/// Description: Third-party forwarder
		/// FieldName: 3PFW
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third-party forwarder")]
		public string M33PFW => GetString("3PFW");
	}
}
// EOF
