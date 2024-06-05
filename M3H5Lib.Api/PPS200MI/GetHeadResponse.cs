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

namespace M3H5Lib.Api.PPS200MI
{
	public partial class GetHeadResponse : M3BaseRecord 
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
		/// Description: Purchase order number
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order number")]
		public string M3PUNO => GetString("PUNO");

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
		/// Description: Document variant
		/// FieldName: DOVA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document variant")]
		public string M3DOVA => GetString("DOVA");

		/// <summary>
		/// Description: Entry date
		/// FieldName: DATE
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3DATE => GetNullableDateTime("DATE");

		/// <summary>
		/// Description: Order date
		/// FieldName: PUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order date")]
		public DateTime? M3PUDT => GetNullableDateTime("PUDT");

		/// <summary>
		/// Description: Requested delivery date
		/// FieldName: DWDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery date")]
		public DateTime? M3DWDT => GetNullableDateTime("DWDT");

		/// <summary>
		/// Description: First printout date
		/// FieldName: LEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("First printout date")]
		public DateTime? M3LEDT => GetNullableDateTime("LEDT");

		/// <summary>
		/// Description: Company name
		/// FieldName: CONM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company name")]
		public string M3CONM => GetString("CONM");

		/// <summary>
		/// Description: Revision number
		/// FieldName: REVN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3REVN => GetString("REVN");

		/// <summary>
		/// Description: Name of user responsible
		/// FieldName: RENM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name of user responsible")]
		public string M3RENM => GetString("RENM");

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
		/// Description: Currency name
		/// FieldName: TXCU
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency name")]
		public string M3TXCU => GetString("TXCU");

		/// <summary>
		/// Description: Terms of Payment name
		/// FieldName: TXPY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Terms of Payment name")]
		public string M3TXPY => GetString("TXPY");

		/// <summary>
		/// Description: Delivery Mode name
		/// FieldName: TXMO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Mode name")]
		public string M3TXMO => GetString("TXMO");

		/// <summary>
		/// Description: Terms of Delivery name
		/// FieldName: TXDL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Terms of Delivery name")]
		public string M3TXDL => GetString("TXDL");

		/// <summary>
		/// Description: Terms of Freight name
		/// FieldName: TXAF
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Terms of Freight name")]
		public string M3TXAF => GetString("TXAF");

		/// <summary>
		/// Description: Terms of Packaging name
		/// FieldName: TXPA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Terms of Packaging name")]
		public string M3TXPA => GetString("TXPA");

		/// <summary>
		/// Description: Harbor or airport name
		/// FieldName: TXHA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harbor or airport name")]
		public string M3TXHA => GetString("TXHA");

		/// <summary>
		/// Description: Your reference
		/// FieldName: YRE1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference")]
		public string M3YRE1 => GetString("YRE1");

		/// <summary>
		/// Description: Telephone number
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number")]
		public string M3PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Facsimile transmission number
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimile transmission number")]
		public string M3TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Revision amount
		/// FieldName: REVV
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision amount")]
		public decimal? M3REVV => GetNullableDecimal("REVV");

		/// <summary>
		/// Description: Remark
		/// FieldName: REMK
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3REMK => GetString("REMK");

		/// <summary>
		/// Description: Amount before revision
		/// FieldName: REV1
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount before revision")]
		public decimal? M3REV1 => GetNullableDecimal("REV1");

		/// <summary>
		/// Description: Total order cost
		/// FieldName: COAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total order cost")]
		public decimal? M3COAM => GetNullableDecimal("COAM");

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
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3LNCD => GetString("LNCD");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3MODL => GetString("MODL");

		/// <summary>
		/// Description: Delivery terms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms")]
		public string M3TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Freight terms
		/// FieldName: TEAF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight terms")]
		public string M3TEAF => GetString("TEAF");

		/// <summary>
		/// Description: Packaging terms
		/// FieldName: TEPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging terms")]
		public string M3TEPA => GetString("TEPA");

		/// <summary>
		/// Description: Reference
		/// FieldName: RFID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference")]
		public string M3RFID => GetString("RFID");

		/// <summary>
		/// Description: Terms text
		/// FieldName: TEL1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Terms text")]
		public string M3TEL1 => GetString("TEL1");

		/// <summary>
		/// Description: Harbor or airport
		/// FieldName: HAFE
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harbor or airport")]
		public string M3HAFE => GetString("HAFE");

		/// <summary>
		/// Description: Purchase order category
		/// FieldName: POTC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order category")]
		public string M3POTC => GetString("POTC");

		/// <summary>
		/// Description: Our invoicing address
		/// FieldName: PYAD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our invoicing address")]
		public string M3PYAD => GetString("PYAD");

		/// <summary>
		/// Description: Multiple delivery addresses
		/// FieldName: MTDP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple delivery addresses")]
		public int? M3MTDP => GetNullableInt("MTDP");

		/// <summary>
		/// Description: Multiple warehouses
		/// FieldName: MTWP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple warehouses")]
		public int? M3MTWP => GetNullableInt("MTWP");

		/// <summary>
		/// Description: Our reference number
		/// FieldName: OURR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our reference number")]
		public string M3OURR => GetString("OURR");

		/// <summary>
		/// Description: Reference type
		/// FieldName: OURT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference type")]
		public string M3OURT => GetString("OURT");

		/// <summary>
		/// Description: Payee
		/// FieldName: PRSU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payee")]
		public string M3PRSU => GetString("PRSU");

		/// <summary>
		/// Description: Agent
		/// FieldName: AGNT
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agent")]
		public string M3AGNT => GetString("AGNT");

		/// <summary>
		/// Description: Net order value
		/// FieldName: NTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net order value")]
		public decimal? M3NTAM => GetNullableDecimal("NTAM");

		/// <summary>
		/// Description: Total quantity
		/// FieldName: TOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total quantity")]
		public decimal? M3TOQT => GetNullableDecimal("TOQT");

		/// <summary>
		/// Description: Total order cost - local currency
		/// FieldName: SAAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total order cost - local currency")]
		public decimal? M3SAAM => GetNullableDecimal("SAAM");

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
		/// Description: Rail station
		/// FieldName: RASN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rail station")]
		public string M3RASN => GetString("RASN");

		/// <summary>
		/// Description: Monitoring active
		/// FieldName: EXAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monitoring active")]
		public int? M3EXAT => GetNullableInt("EXAT");

		/// <summary>
		/// Description: Monitoring activity list
		/// FieldName: FUSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monitoring activity list")]
		public string M3FUSC => GetString("FUSC");

		/// <summary>
		/// Description: Order total discount
		/// FieldName: ODAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order total discount")]
		public decimal? M3ODAM => GetNullableDecimal("ODAM");

		/// <summary>
		/// Description: Project number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number")]
		public string M3PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3ELNO => GetString("ELNO");

		/// <summary>
		/// Description: Order value gross
		/// FieldName: BRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order value gross")]
		public decimal? M3BRAM => GetNullableDecimal("BRAM");
	}
}
// EOF
