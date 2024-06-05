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

namespace M3H5Lib.Api.CSS204MI
{
	public partial class GetCatScoreResponse : M3BaseRecord 
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
		public string M3DIVI => GetString("DIVI");

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
		/// Description: Serial number
		/// FieldName: SERN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SERN => GetString("SERN");

		/// <summary>
		/// Description: Creation date
		/// FieldName: CRDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Creation date")]
		public DateTime? M3CRDT => GetNullableDateTime("CRDT");

		/// <summary>
		/// Description: Transaction type
		/// FieldName: RETY
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type")]
		public string M3RETY => GetString("RETY");

		/// <summary>
		/// Description: Inventory dealer c
		/// FieldName: IDLR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory dealer c")]
		public string M3IDLR => GetString("IDLR");

		/// <summary>
		/// Description: Sale type
		/// FieldName: ALET
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sale type")]
		public string M3ALET => GetString("ALET");

		/// <summary>
		/// Description: Owner class
		/// FieldName: OWCL
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Owner class")]
		public string M3OWCL => GetString("OWCL");

		/// <summary>
		/// Description: Delivery code
		/// FieldName: DECD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery code")]
		public string M3DECD => GetString("DECD");

		/// <summary>
		/// Description: Selling dealer c
		/// FieldName: SDLR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selling dealer c")]
		public string M3SDLR => GetString("SDLR");

		/// <summary>
		/// Description: Salesperson
		/// FieldName: SMTX
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Salesperson")]
		public string M3SMTX => GetString("SMTX");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Address line 1
		/// FieldName: ADR1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 1")]
		public string M3ADR1 => GetString("ADR1");

		/// <summary>
		/// Description: Address line 2
		/// FieldName: ADR2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 2")]
		public string M3ADR2 => GetString("ADR2");

		/// <summary>
		/// Description: Address line 3
		/// FieldName: ADR3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 3")]
		public string M3ADR3 => GetString("ADR3");

		/// <summary>
		/// Description: Address
		/// FieldName: CITY
		/// FieldType: A
		/// Length: 28
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address")]
		public string M3CITY => GetString("CITY");

		/// <summary>
		/// Description: State
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("State")]
		public string M3ECAR => GetString("ECAR");

		/// <summary>
		/// Description: Country
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3CSCD => GetString("CSCD");

		/// <summary>
		/// Description: Postal code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3PONO => GetString("PONO");

		/// <summary>
		/// Description: Country name
		/// FieldName: CNTR
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country name")]
		public string M3CNTR => GetString("CNTR");

		/// <summary>
		/// Description: Telephone number 1
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 1")]
		public string M3PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Sale contact name
		/// FieldName: SACT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sale contact name")]
		public string M3SACT => GetString("SACT");

		/// <summary>
		/// Description: Serv contact name
		/// FieldName: SECT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv contact name")]
		public string M3SECT => GetString("SECT");

		/// <summary>
		/// Description: Sales date
		/// FieldName: SEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales date")]
		public DateTime? M3SEDT => GetNullableDateTime("SEDT");

		/// <summary>
		/// Description: Rent lease mos
		/// FieldName: RTMS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rent lease mos")]
		public int? M3RTMS => GetNullableInt("RTMS");

		/// <summary>
		/// Description: Principle work
		/// FieldName: PRWO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Principle work")]
		public string M3PRWO => GetString("PRWO");

		/// <summary>
		/// Description: Planned delivery date
		/// FieldName: DLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned delivery date")]
		public DateTime? M3DLDT => GetNullableDateTime("DLDT");

		/// <summary>
		/// Description: Cat extra code
		/// FieldName: CATX
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cat extra code")]
		public string M3CATX => GetString("CATX");

		/// <summary>
		/// Description: Rental income total
		/// FieldName: RTIN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rental income total")]
		public decimal? M3RTIN => GetNullableDecimal("RTIN");

		/// <summary>
		/// Description: Percent of rent applied
		/// FieldName: RTPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Percent of rent applied")]
		public int? M3RTPC => GetNullableInt("RTPC");

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
		/// Description: Sicc code
		/// FieldName: SICC
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sicc code")]
		public string M3SICC => GetString("SICC");

		/// <summary>
		/// Description: Transaction price
		/// FieldName: TRPI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction price")]
		public decimal? M3TRPI => GetNullableDecimal("TRPI");

		/// <summary>
		/// Description: Over allow amount
		/// FieldName: OVAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Over allow amount")]
		public decimal? M3OVAM => GetNullableDecimal("OVAM");

		/// <summary>
		/// Description: Vin
		/// FieldName: VINT
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Vin")]
		public string M3VINT => GetString("VINT");

		/// <summary>
		/// Description: Govt file no
		/// FieldName: GOVT
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Govt file no")]
		public string M3GOVT => GetString("GOVT");

		/// <summary>
		/// Description: Reinjes 7200 ser no
		/// FieldName: REJE
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinjes 7200 ser no")]
		public string M3REJE => GetString("REJE");

		/// <summary>
		/// Description: Trans gen chge
		/// FieldName: TRNG
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trans gen chge")]
		public string M3TRNG => GetString("TRNG");

		/// <summary>
		/// Description: Dist channel
		/// FieldName: DISH
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dist channel")]
		public string M3DISH => GetString("DISH");

		/// <summary>
		/// Description: Sic code
		/// FieldName: FRI1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sic code")]
		public string M3FRI1 => GetString("FRI1");

		/// <summary>
		/// Description: Application code
		/// FieldName: APCO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application code")]
		public string M3APCO => GetString("APCO");

		/// <summary>
		/// Description: To dealer code
		/// FieldName: TDLR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To dealer code")]
		public string M3TDLR => GetString("TDLR");

		/// <summary>
		/// Description: Transmitted dlr cd
		/// FieldName: TRMD
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transmitted dlr cd")]
		public string M3TRMD => GetString("TRMD");

		/// <summary>
		/// Description: Fuel code
		/// FieldName: FUEL
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fuel code")]
		public string M3FUEL => GetString("FUEL");

		/// <summary>
		/// Description: Sic code
		/// FieldName: CICC
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sic code")]
		public string M3CICC => GetString("CICC");

		/// <summary>
		/// Description: Submit date
		/// FieldName: SBDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Submit date")]
		public DateTime? M3SBDT => GetNullableDateTime("SBDT");

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
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3LMTS => GetNullableDecimal("LMTS");

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
		/// Description: From dealer
		/// FieldName: FDLR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From dealer")]
		public string M3FDLR => GetString("FDLR");

		/// <summary>
		/// Description: Salt
		/// FieldName: SALZ
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Salt")]
		public string M3SALZ => GetString("SALZ");

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
		/// Description: Hertz code
		/// FieldName: HRTZ
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hertz code")]
		public string M3HRTZ => GetString("HRTZ");

		/// <summary>
		/// Description: User field 2
		/// FieldName: FRI2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User field 2")]
		public string M3FRI2 => GetString("FRI2");

		/// <summary>
		/// Description: Spar  focus code
		/// FieldName: SPFO
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Spar  focus code")]
		public string M3SPFO => GetString("SPFO");

		/// <summary>
		/// Description: Comitted Y/N
		/// FieldName: COMI
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comitted Y/N")]
		public string M3COMI => GetString("COMI");

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
		/// Description: County ID
		/// FieldName: FRCO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County ID")]
		public string M3FRCO => GetString("FRCO");
	}
}
// EOF
