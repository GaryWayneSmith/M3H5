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

namespace M3H5Lib.Api.PPSSPPMI
{
	public partial class LstSupHeadResponse : M3BaseRecord 
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
		/// Description: Purchase order number
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order number")]
		public string M3_PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Purchase order category
		/// FieldName: POTC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order category")]
		public string M3_POTC => GetString("POTC");

		/// <summary>
		/// Description: Lowest status - purchase order
		/// FieldName: PUSL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest status - purchase order")]
		public string M3_PUSL => GetString("PUSL");

		/// <summary>
		/// Description: Change date - order status
		/// FieldName: SLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date - order status")]
		public DateTime? M3_SLDT => GetNullableDateTime("SLDT");

		/// <summary>
		/// Description: Highest status - purchase order
		/// FieldName: PUST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status - purchase order")]
		public string M3_PUST => GetString("PUST");

		/// <summary>
		/// Description: Change date highest order status
		/// FieldName: SCDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date highest order status")]
		public DateTime? M3_SCDT => GetNullableDateTime("SCDT");

		/// <summary>
		/// Description: Communication code
		/// FieldName: CMCO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Communication code")]
		public string M3_CMCO => GetString("CMCO");

		/// <summary>
		/// Description: Order date
		/// FieldName: PUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order date")]
		public DateTime? M3_PUDT => GetNullableDateTime("PUDT");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3_SUNO => GetString("SUNO");

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
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3_CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Name
		/// FieldName: CUTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_CUTX => GetString("CUTX");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3_TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Payment terms name
		/// FieldName: PYTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms name")]
		public string M3_PYTX => GetString("PYTX");

		/// <summary>
		/// Description: Payment method - accounts payable
		/// FieldName: PYME
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method - accounts payable")]
		public string M3_PYME => GetString("PYME");

		/// <summary>
		/// Description: Freight terms
		/// FieldName: TEAF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight terms")]
		public string M3_TEAF => GetString("TEAF");

		/// <summary>
		/// Description: Freight terms name
		/// FieldName: FRTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight terms name")]
		public string M3_FRTX => GetString("FRTX");

		/// <summary>
		/// Description: Packaging terms
		/// FieldName: TEPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging terms")]
		public string M3_TEPA => GetString("TEPA");

		/// <summary>
		/// Description: Reference
		/// FieldName: RFID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference")]
		public string M3_RFID => GetString("RFID");

		/// <summary>
		/// Description: Your reference
		/// FieldName: YRE1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference")]
		public string M3_YRE1 => GetString("YRE1");

		/// <summary>
		/// Description: Requested delivery date
		/// FieldName: DWDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery date")]
		public DateTime? M3_DWDT => GetNullableDateTime("DWDT");

		/// <summary>
		/// Description: Last day of delivery
		/// FieldName: HDDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last day of delivery")]
		public DateTime? M3_HDDT => GetNullableDateTime("HDDT");

		/// <summary>
		/// Description: Payee
		/// FieldName: PRSU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payee")]
		public string M3_PRSU => GetString("PRSU");

		/// <summary>
		/// Description: Our reference number
		/// FieldName: OURR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our reference number")]
		public string M3_OURR => GetString("OURR");

		/// <summary>
		/// Description: Reference type
		/// FieldName: OURT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference type")]
		public string M3_OURT => GetString("OURT");

		/// <summary>
		/// Description: Recipient agreement type 1 - commission
		/// FieldName: AGNT
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recipient agreement type 1 - commission")]
		public string M3_AGNT => GetString("AGNT");

		/// <summary>
		/// Description: Net order value
		/// FieldName: NTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net order value")]
		public decimal? M3_NTAM => GetNullableDecimal("NTAM");

		/// <summary>
		/// Description: Order value gross
		/// FieldName: BRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order value gross")]
		public decimal? M3_BRAM => GetNullableDecimal("BRAM");

		/// <summary>
		/// Description: Order total discount generating amount
		/// FieldName: OTBA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order total discount generating amount")]
		public decimal? M3_OTBA => GetNullableDecimal("OTBA");

		/// <summary>
		/// Description: Requisition by
		/// FieldName: PURC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requisition by")]
		public string M3_PURC => GetString("PURC");

		/// <summary>
		/// Description: Buyer
		/// FieldName: BUYE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Buyer")]
		public string M3_BUYE => GetString("BUYE");

		/// <summary>
		/// Description: Buyer name
		/// FieldName: BUTX
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Buyer name")]
		public string M3_BUTX => GetString("BUTX");

		/// <summary>
		/// Description: Authorized
		/// FieldName: AURE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorized")]
		public string M3_AURE => GetString("AURE");

		/// <summary>
		/// Description: First printout date
		/// FieldName: LEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("First printout date")]
		public DateTime? M3_LEDT => GetNullableDateTime("LEDT");

		/// <summary>
		/// Description: Monitoring activity list
		/// FieldName: FUSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monitoring activity list")]
		public string M3_FUSC => GetString("FUSC");

		/// <summary>
		/// Description: Monitoring active
		/// FieldName: EXAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monitoring active")]
		public int? M3_EXAT => GetNullableInt("EXAT");

		/// <summary>
		/// Description: Payment table active
		/// FieldName: PTAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment table active")]
		public int? M3_PTAC => GetNullableInt("PTAC");

		/// <summary>
		/// Description: Revision table active
		/// FieldName: RTAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision table active")]
		public int? M3_RTAC => GetNullableInt("RTAC");

		/// <summary>
		/// Description: Charge active
		/// FieldName: EXAV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge active")]
		public int? M3_EXAV => GetNullableInt("EXAV");

		/// <summary>
		/// Description: Number of pages - purchase order
		/// FieldName: NOPP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of pages - purchase order")]
		public int? M3_NOPP => GetNullableInt("NOPP");

		/// <summary>
		/// Description: Number of purchase order lines
		/// FieldName: NOLN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of purchase order lines")]
		public int? M3_NOLN => GetNullableInt("NOLN");

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
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

		/// <summary>
		/// Description: Facility name
		/// FieldName: FACN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility name")]
		public string M3_FACN => GetString("FACN");

		/// <summary>
		/// Description: Multiple warehouses
		/// FieldName: MTWP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple warehouses")]
		public int? M3_MTWP => GetNullableInt("MTWP");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Description
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_WHNM => GetString("WHNM");

		/// <summary>
		/// Description: Multiple delivery addresses
		/// FieldName: MTDP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple delivery addresses")]
		public int? M3_MTDP => GetNullableInt("MTDP");

		/// <summary>
		/// Description: Total order cost
		/// FieldName: COAM
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total order cost")]
		public decimal? M3_COAM => GetNullableDecimal("COAM");

		/// <summary>
		/// Description: Order total discount
		/// FieldName: ODAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order total discount")]
		public decimal? M3_ODAM => GetNullableDecimal("ODAM");

		/// <summary>
		/// Description: Order total discount generating
		/// FieldName: OTPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order total discount generating")]
		public int? M3_OTPC => GetNullableInt("OTPC");

		/// <summary>
		/// Description: Print line amount
		/// FieldName: PRLA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print line amount")]
		public int? M3_PRLA => GetNullableInt("PRLA");

		/// <summary>
		/// Description: Volume
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume")]
		public decimal? M3_VOL3 => GetNullableDecimal("VOL3");

		/// <summary>
		/// Description: Gross weight
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight")]
		public decimal? M3_GRWE => GetNullableDecimal("GRWE");

		/// <summary>
		/// Description: Total quantity
		/// FieldName: TOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total quantity")]
		public decimal? M3_TOQT => GetNullableDecimal("TOQT");

		/// <summary>
		/// Description: Facsimile transmission number
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimile transmission number")]
		public string M3_TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Last reply date
		/// FieldName: LRED
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last reply date")]
		public DateTime? M3_LRED => GetNullableDateTime("LRED");

		/// <summary>
		/// Description: Last activity date
		/// FieldName: ATDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last activity date")]
		public DateTime? M3_ATDT => GetNullableDateTime("ATDT");

		/// <summary>
		/// Description: Calculator print
		/// FieldName: POPO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculator print")]
		public int? M3_POPO => GetNullableInt("POPO");

		/// <summary>
		/// Description: Terms text
		/// FieldName: TEL1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Terms text")]
		public string M3_TEL1 => GetString("TEL1");

		/// <summary>
		/// Description: Due date
		/// FieldName: DUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3_DUDT => GetNullableDateTime("DUDT");

		/// <summary>
		/// Description: Currency terms
		/// FieldName: CUTE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency terms")]
		public int? M3_CUTE => GetNullableInt("CUTE");

		/// <summary>
		/// Description: Agreed rate
		/// FieldName: AGRA
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed rate")]
		public decimal? M3_AGRA => GetNullableDecimal("AGRA");

		/// <summary>
		/// Description: Our invoicing address
		/// FieldName: PYAD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our invoicing address")]
		public string M3_PYAD => GetString("PYAD");

		/// <summary>
		/// Description: Your via address
		/// FieldName: SHVI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your via address")]
		public string M3_SHVI => GetString("SHVI");

		/// <summary>
		/// Description: Your receiving address
		/// FieldName: FIDS
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your receiving address")]
		public string M3_FIDS => GetString("FIDS");

		/// <summary>
		/// Description: Receipt date
		/// FieldName: RCDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt date")]
		public DateTime? M3_RCDT => GetNullableDateTime("RCDT");

		/// <summary>
		/// Description: Last invoice date
		/// FieldName: LIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last invoice date")]
		public DateTime? M3_LIDT => GetNullableDateTime("LIDT");

		/// <summary>
		/// Description: External charge
		/// FieldName: EXEP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External charge")]
		public decimal? M3_EXEP => GetNullableDecimal("EXEP");

		/// <summary>
		/// Description: Internal charge
		/// FieldName: INEP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal charge")]
		public decimal? M3_INEP => GetNullableDecimal("INEP");

		/// <summary>
		/// Description: External line unique charges
		/// FieldName: TLEX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External line unique charges")]
		public decimal? M3_TLEX => GetNullableDecimal("TLEX");

		/// <summary>
		/// Description: Internal line unique charges
		/// FieldName: TLIN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal line unique charges")]
		public decimal? M3_TLIN => GetNullableDecimal("TLIN");

		/// <summary>
		/// Description: Telephone order
		/// FieldName: TEOR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone order")]
		public int? M3_TEOR => GetNullableInt("TEOR");

		/// <summary>
		/// Description: Project number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number")]
		public string M3_PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Project number Name
		/// FieldName: PRTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number Name")]
		public string M3_PRTX => GetString("PRTX");

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3_ELNO => GetString("ELNO");

		/// <summary>
		/// Description: Labor code - trade statistics (TST)
		/// FieldName: ECLC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor code - trade statistics (TST)")]
		public string M3_ECLC => GetString("ECLC");

		/// <summary>
		/// Description: Customs procedure - import
		/// FieldName: CPRI
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs procedure - import")]
		public string M3_CPRI => GetString("CPRI");

		/// <summary>
		/// Description: Media
		/// FieldName: MEDC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Media")]
		public string M3_MEDC => GetString("MEDC");

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
	}
}
// EOF
