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

namespace M3H5Lib.Api.MHS002MI
{
	public partial class GetIntItmWhsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Partner
		/// FieldName: E0PA
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner")]
		public string M3E0PA => GetString("E0PA");

		/// <summary>
		/// Description: Message type
		/// FieldName: E065
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message type")]
		public string M3E065 => GetString("E065");

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
		/// Description: Interface item number
		/// FieldName: IFIN
		/// FieldType: A
		/// Length: 32
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interface item number")]
		public string M3IFIN => GetString("IFIN");

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
		/// Description: Acquisition code
		/// FieldName: PUIT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acquisition code")]
		public int? M3PUIT => GetNullableInt("PUIT");

		/// <summary>
		/// Description: Planning method
		/// FieldName: OPLC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning method")]
		public int? M3OPLC => GetNullableInt("OPLC");

		/// <summary>
		/// Description: Master scheduled
		/// FieldName: MSCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Master scheduled")]
		public int? M3MSCH => GetNullableInt("MSCH");

		/// <summary>
		/// Description: Period frame
		/// FieldName: DPID
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period frame")]
		public int? M3DPID => GetNullableInt("DPID");

		/// <summary>
		/// Description: Planning policy
		/// FieldName: PLCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning policy")]
		public string M3PLCD => GetString("PLCD");

		/// <summary>
		/// Description: Supply lead time
		/// FieldName: LEA1
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply lead time")]
		public int? M3LEA1 => GetNullableInt("LEA1");

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
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3ORTY => GetString("ORTY");

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
		/// Description: Supplying warehouse
		/// FieldName: SUWH
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying warehouse")]
		public string M3SUWH => GetString("SUWH");

		/// <summary>
		/// Description: Safety stock
		/// FieldName: SSQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock")]
		public decimal? M3SSQT => GetNullableDecimal("SSQT");

		/// <summary>
		/// Description: Reorder point
		/// FieldName: REOP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reorder point")]
		public decimal? M3REOP => GetNullableDecimal("REOP");

		/// <summary>
		/// Description: Order quantity
		/// FieldName: EOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order quantity")]
		public decimal? M3EOQT => GetNullableDecimal("EOQT");

		/// <summary>
		/// Description: Maximum stock
		/// FieldName: MXST
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum stock")]
		public decimal? M3MXST => GetNullableDecimal("MXST");

		/// <summary>
		/// Description: Location
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3WHSL => GetString("WHSL");

		/// <summary>
		/// Description: Storage method
		/// FieldName: STMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Storage method")]
		public int? M3STMT => GetNullableInt("STMT");

		/// <summary>
		/// Description: Allocation method
		/// FieldName: ALMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocation method")]
		public int? M3ALMT => GetNullableInt("ALMT");

		/// <summary>
		/// Description: Issue method
		/// FieldName: SPMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue method")]
		public int? M3SPMT => GetNullableInt("SPMT");

		/// <summary>
		/// Description: Shelf life
		/// FieldName: SLDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shelf life")]
		public int? M3SLDY => GetNullableInt("SLDY");

		/// <summary>
		/// Description: Reinspection time
		/// FieldName: REDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinspection time")]
		public int? M3REDY => GetNullableInt("REDY");

		/// <summary>
		/// Description: Sales time
		/// FieldName: SAEL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales time")]
		public int? M3SAEL => GetNullableInt("SAEL");

		/// <summary>
		/// Description: Exist in BE
		/// FieldName: EXBE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exist in BE")]
		public int? M3EXBE => GetNullableInt("EXBE");

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
		/// Description: User-defined field
		/// FieldName: USD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD1 => GetString("USD1");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD2 => GetString("USD2");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD3 => GetString("USD3");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD4 => GetString("USD4");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD5 => GetString("USD5");

		/// <summary>
		/// Description: Status
		/// FieldName: STAI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAI => GetString("STAI");

		/// <summary>
		/// Description: CTP policy
		/// FieldName: CPCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CTP policy")]
		public string M3CPCD => GetString("CPCD");

		/// <summary>
		/// Description: Maximum stock method
		/// FieldName: MXSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum stock method")]
		public int? M3MXSM => GetNullableInt("MXSM");

		/// <summary>
		/// Description: ABC class - volume
		/// FieldName: ABCD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - volume")]
		public string M3ABCD => GetString("ABCD");

		/// <summary>
		/// Description: ABC class - frequency
		/// FieldName: ABFC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - frequency")]
		public string M3ABFC => GetString("ABFC");

		/// <summary>
		/// Description: ABC class - contribution
		/// FieldName: ACOC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - contribution")]
		public string M3ACOC => GetString("ACOC");

		/// <summary>
		/// Description: ABC class - manual
		/// FieldName: MABC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - manual")]
		public string M3MABC => GetString("MABC");

		/// <summary>
		/// Description: ABC method  - volume
		/// FieldName: ABCM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC method  - volume")]
		public int? M3ABCM => GetNullableInt("ABCM");

		/// <summary>
		/// Description: ABC method - frequency
		/// FieldName: ABFM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC method - frequency")]
		public int? M3ABFM => GetNullableInt("ABFM");

		/// <summary>
		/// Description: ABC method - contribution
		/// FieldName: ACOM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC method - contribution")]
		public int? M3ACOM => GetNullableInt("ACOM");

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
		/// Description: Buyer
		/// FieldName: BUYE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Buyer")]
		public string M3BUYE => GetString("BUYE");

		/// <summary>
		/// Description: Reorder point method
		/// FieldName: OPOM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reorder point method")]
		public int? M3OPOM => GetNullableInt("OPOM");

		/// <summary>
		/// Description: Order policy
		/// FieldName: EOQM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order policy")]
		public int? M3EOQM => GetNullableInt("EOQM");

		/// <summary>
		/// Description: Economical order quantity days
		/// FieldName: EQDA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Economical order quantity days")]
		public int? M3EQDA => GetNullableInt("EQDA");

		/// <summary>
		/// Description: Maximum stock percentage
		/// FieldName: MXPC
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum stock percentage")]
		public int? M3MXPC => GetNullableInt("MXPC");

		/// <summary>
		/// Description: Minimum order quantity
		/// FieldName: LOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum order quantity")]
		public decimal? M3LOQT => GetNullableDecimal("LOQT");

		/// <summary>
		/// Description: Maximum order quantity
		/// FieldName: MOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum order quantity")]
		public decimal? M3MOQT => GetNullableDecimal("MOQT");

		/// <summary>
		/// Description: Returnable / non returnable indicator
		/// FieldName: RNRI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Returnable / non returnable indicator")]
		public int? M3RNRI => GetNullableInt("RNRI");

		/// <summary>
		/// Description: Returnable message
		/// FieldName: RMSG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Returnable message")]
		public int? M3RMSG => GetNullableInt("RMSG");

		/// <summary>
		/// Description: Scan required
		/// FieldName: SCRQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scan required")]
		public int? M3SCRQ => GetNullableInt("SCRQ");

		/// <summary>
		/// Description: Best before time
		/// FieldName: BBTM
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Best before time")]
		public int? M3BBTM => GetNullableInt("BBTM");

		/// <summary>
		/// Description: Aging days
		/// FieldName: AGDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aging days")]
		public int? M3AGDY => GetNullableInt("AGDY");

		/// <summary>
		/// Description: Aging hours
		/// FieldName: AGHO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aging hours")]
		public int? M3AGHO => GetNullableInt("AGHO");

		/// <summary>
		/// Description: Aging minutes
		/// FieldName: AGMI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aging minutes")]
		public int? M3AGMI => GetNullableInt("AGMI");

		/// <summary>
		/// Description: Inventory segment
		/// FieldName: ISEG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory segment")]
		public string M3ISEG => GetString("ISEG");
	}
}
// EOF
