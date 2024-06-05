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

namespace M3H5Lib.Api.MMS850MI
{
	public partial class GetStkHeadResponse : M3BaseRecord 
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
		/// Description: Message number
		/// FieldName: MSNR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message number")]
		public string M3MSNR => GetString("MSNR");

		/// <summary>
		/// Description: Message direction
		/// FieldName: E0IO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message direction")]
		public string M3E0IO => GetString("E0IO");

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
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: External message number
		/// FieldName: PMSN
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External message number")]
		public string M3PMSN => GetString("PMSN");

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
		/// Description: Lowest status
		/// FieldName: STLO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest status")]
		public string M3STLO => GetString("STLO");

		/// <summary>
		/// Description: Highest status
		/// FieldName: STHI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status")]
		public string M3STHI => GetString("STHI");

		/// <summary>
		/// Description: Date generated
		/// FieldName: GEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date generated")]
		public DateTime? M3GEDT => GetNullableDateTime("GEDT");

		/// <summary>
		/// Description: Time generated
		/// FieldName: GETM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time generated")]
		public int? M3GETM => GetNullableInt("GETM");

		/// <summary>
		/// Description: Date changed
		/// FieldName: CHGD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date changed")]
		public DateTime? M3CHGD => GetNullableDateTime("CHGD");

		/// <summary>
		/// Description: Sender/receiver ID
		/// FieldName: E004
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sender/receiver ID")]
		public string M3E004 => GetString("E004");

		/// <summary>
		/// Description: Qualifier
		/// FieldName: E007
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Qualifier")]
		public string M3E007 => GetString("E007");

		/// <summary>
		/// Description: Routing address
		/// FieldName: E014
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Routing address")]
		public string M3E014 => GetString("E014");

		/// <summary>
		/// Description: Application reference
		/// FieldName: E026
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application reference")]
		public string M3E026 => GetString("E026");

		/// <summary>
		/// Description: Test indicator
		/// FieldName: E035
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test indicator")]
		public int? M3E035 => GetNullableInt("E035");

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
		/// Description: Message version
		/// FieldName: E052
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message version")]
		public string M3E052 => GetString("E052");

		/// <summary>
		/// Description: Message release
		/// FieldName: E054
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message release")]
		public string M3E054 => GetString("E054");

		/// <summary>
		/// Description: Controlling organization
		/// FieldName: E051
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Controlling organization")]
		public string M3E051 => GetString("E051");

		/// <summary>
		/// Description: Organization assigned code
		/// FieldName: E057
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organization assigned code")]
		public string M3E057 => GetString("E057");

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
		/// Description: Code list qualifier
		/// FieldName: E0QA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code list qualifier")]
		public string M3E0QA => GetString("E0QA");

		/// <summary>
		/// Description: Partner ID
		/// FieldName: E0PB
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner ID")]
		public string M3E0PB => GetString("E0PB");

		/// <summary>
		/// Description: Code list qualifier
		/// FieldName: E0QB
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code list qualifier")]
		public string M3E0QB => GetString("E0QB");

		/// <summary>
		/// Description: Document number
		/// FieldName: DONR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document number")]
		public string M3DONR => GetString("DONR");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3RESP => GetString("RESP");

		/// <summary>
		/// Description: EDI reference
		/// FieldName: EDFR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EDI reference")]
		public string M3EDFR => GetString("EDFR");

		/// <summary>
		/// Description: Message identity 1
		/// FieldName: ID01
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message identity 1")]
		public string M3ID01 => GetString("ID01");

		/// <summary>
		/// Description: Message identity 2
		/// FieldName: ID02
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message identity 2")]
		public string M3ID02 => GetString("ID02");

		/// <summary>
		/// Description: Message identity 3
		/// FieldName: ID03
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message identity 3")]
		public string M3ID03 => GetString("ID03");

		/// <summary>
		/// Description: Message identity 4
		/// FieldName: ID04
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message identity 4")]
		public string M3ID04 => GetString("ID04");

		/// <summary>
		/// Description: Message identity 5
		/// FieldName: ID05
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message identity 5")]
		public string M3ID05 => GetString("ID05");

		/// <summary>
		/// Description: Customers order number
		/// FieldName: CUOR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customers order number")]
		public string M3CUOR => GetString("CUOR");

		/// <summary>
		/// Description: Customer´s purchase order date
		/// FieldName: CUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer´s purchase order date")]
		public DateTime? M3CUDT => GetNullableDateTime("CUDT");

		/// <summary>
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3ADID => GetString("ADID");

		/// <summary>
		/// Description: Delivery specification
		/// FieldName: DLSP
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery specification")]
		public string M3DLSP => GetString("DLSP");

		/// <summary>
		/// Description: Delivery contract number
		/// FieldName: RSAG
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery contract number")]
		public string M3RSAG => GetString("RSAG");

		/// <summary>
		/// Description: Carrier
		/// FieldName: CARR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Carrier")]
		public string M3CARR => GetString("CARR");

		/// <summary>
		/// Description: Customer´s carrier name
		/// FieldName: CCAR
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer´s carrier name")]
		public string M3CCAR => GetString("CCAR");

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
		/// Description: Data identity
		/// FieldName: DTID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity")]
		public decimal? M3DTID => GetNullableDecimal("DTID");

		/// <summary>
		/// Description: Local currency
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency")]
		public string M3LOCD => GetString("LOCD");

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
		/// Description: Exchange rate
		/// FieldName: ARAT
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate")]
		public decimal? M3ARAT => GetNullableDecimal("ARAT");

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
	}
}
// EOF
