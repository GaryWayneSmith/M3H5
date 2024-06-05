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

namespace M3H5Lib.Api.SOS200MI
{
	public partial class LstIndivItemsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Individual item number
		/// FieldName: INNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item number")]
		public string M3INNO => GetString("INNO");

		/// <summary>
		/// Description: Model description
		/// FieldName: MODE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Model description")]
		public string M3MODE => GetString("MODE");

		/// <summary>
		/// Description: Individual item type
		/// FieldName: INTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item type")]
		public int? M3INTY => GetNullableInt("INTY");

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
		/// FieldName: SERI
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SERI => GetString("SERI");

		/// <summary>
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Customer number
		/// FieldName: CUPL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3CUPL => GetString("CUPL");

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
		/// Description: Owner
		/// FieldName: CUOW
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Owner")]
		public string M3CUOW => GetString("CUOW");

		/// <summary>
		/// Description: Meter item
		/// FieldName: MEIT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter item")]
		public int? M3MEIT => GetNullableInt("MEIT");

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
		/// Description: Status - individual item
		/// FieldName: ISTS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - individual item")]
		public string M3ISTS => GetString("ISTS");

		/// <summary>
		/// Description: Individual item group
		/// FieldName: INGR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item group")]
		public string M3INGR => GetString("INGR");

		/// <summary>
		/// Description: Brand
		/// FieldName: BRAN
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Brand")]
		public string M3BRAN => GetString("BRAN");

		/// <summary>
		/// Description: Model name
		/// FieldName: MODC
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Model name")]
		public string M3MODC => GetString("MODC");

		/// <summary>
		/// Description: Technician
		/// FieldName: TECH
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Technician")]
		public string M3TECH => GetString("TECH");

		/// <summary>
		/// Description: Service manager
		/// FieldName: SRES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service manager")]
		public string M3SRES => GetString("SRES");

		/// <summary>
		/// Description: Item group
		/// FieldName: ITGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group")]
		public string M3ITGR => GetString("ITGR");

		/// <summary>
		/// Description: Delivery date
		/// FieldName: DEDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery date")]
		public DateTime? M3DEDA => GetNullableDateTime("DEDA");

		/// <summary>
		/// Description: Receipt date
		/// FieldName: REDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt date")]
		public DateTime? M3REDA => GetNullableDateTime("REDA");

		/// <summary>
		/// Description: Installation date
		/// FieldName: INDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Installation date")]
		public DateTime? M3INDA => GetNullableDateTime("INDA");

		/// <summary>
		/// Description: Contract item
		/// FieldName: AGRS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Contract item")]
		public string M3AGRS => GetString("AGRS");

		/// <summary>
		/// Description: Contract item - rent
		/// FieldName: AGRR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Contract item - rent")]
		public string M3AGRR => GetString("AGRR");

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
		/// Description: Year model
		/// FieldName: MLYR
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year model")]
		public string M3MLYR => GetString("MLYR");

		/// <summary>
		/// Description: Location description
		/// FieldName: AREA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location description")]
		public string M3AREA => GetString("AREA");

		/// <summary>
		/// Description: Warranty date sales
		/// FieldName: GDT1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty date sales")]
		public DateTime? M3GDT1 => GetNullableDateTime("GDT1");

		/// <summary>
		/// Description: General agent
		/// FieldName: CUGA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("General agent")]
		public string M3CUGA => GetString("CUGA");

		/// <summary>
		/// Description: Warranty date supplier
		/// FieldName: GDT2
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty date supplier")]
		public DateTime? M3GDT2 => GetNullableDateTime("GDT2");

		/// <summary>
		/// Description: Manufacturer
		/// FieldName: PROD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturer")]
		public string M3PROD => GetString("PROD");

		/// <summary>
		/// Description: Customer number at the insurance company
		/// FieldName: CUIC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number at the insurance company")]
		public string M3CUIC => GetString("CUIC");

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
		/// Description: Agreement number
		/// FieldName: CTNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3CTNO => GetString("CTNO");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: CTNA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3CTNA => GetString("CTNA");

		/// <summary>
		/// Description: Main individual item code
		/// FieldName: MICD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main individual item code")]
		public int? M3MICD => GetNullableInt("MICD");

		/// <summary>
		/// Description: Main individual item
		/// FieldName: MINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main individual item")]
		public string M3MINO => GetString("MINO");

		/// <summary>
		/// Description: Equipment
		/// FieldName: CONS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment")]
		public string M3CONS => GetString("CONS");

		/// <summary>
		/// Description: User-defined field 1 - individual item
		/// FieldName: CFE1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - individual item")]
		public string M3CFE1 => GetString("CFE1");

		/// <summary>
		/// Description: User-defined field 2 - individual item
		/// FieldName: CFE2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - individual item")]
		public decimal? M3CFE2 => GetNullableDecimal("CFE2");

		/// <summary>
		/// Description: User-defined field 3 - individual item
		/// FieldName: CFE3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - individual item")]
		public string M3CFE3 => GetString("CFE3");

		/// <summary>
		/// Description: User-defined field 4 - individual item
		/// FieldName: CFE4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - individual item")]
		public string M3CFE4 => GetString("CFE4");

		/// <summary>
		/// Description: User-defined field 5 - individual item
		/// FieldName: CFE5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - individual item")]
		public string M3CFE5 => GetString("CFE5");

		/// <summary>
		/// Description: User-defined field 6 - individual item
		/// FieldName: CFE6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 6 - individual item")]
		public string M3CFE6 => GetString("CFE6");

		/// <summary>
		/// Description: User-defined field 7 - individual item
		/// FieldName: CFE7
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 7 - individual item")]
		public decimal? M3CFE7 => GetNullableDecimal("CFE7");

		/// <summary>
		/// Description: User-defined field 8 - individual item
		/// FieldName: CFE8
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 8 - individual item")]
		public string M3CFE8 => GetString("CFE8");

		/// <summary>
		/// Description: User-defined field 9 - individual item
		/// FieldName: CFE9
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 9 - individual item")]
		public string M3CFE9 => GetString("CFE9");

		/// <summary>
		/// Description: User-defined field 10 - individual item
		/// FieldName: CFE0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 10 - individual item")]
		public string M3CFE0 => GetString("CFE0");

		/// <summary>
		/// Description: User-defined field 11 - individual item
		/// FieldName: CFEA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 11 - individual item")]
		public string M3CFEA => GetString("CFEA");

		/// <summary>
		/// Description: User-defined field 12 - individual item
		/// FieldName: CFEB
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 12 - individual item")]
		public string M3CFEB => GetString("CFEB");

		/// <summary>
		/// Description: GUI picture
		/// FieldName: PINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("GUI picture")]
		public string M3PINO => GetString("PINO");

		/// <summary>
		/// Description: Drawing number
		/// FieldName: DWNO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing number")]
		public string M3DWNO => GetString("DWNO");

		/// <summary>
		/// Description: Warranty date workshop warranty
		/// FieldName: GDT3
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty date workshop warranty")]
		public DateTime? M3GDT3 => GetNullableDateTime("GDT3");

		/// <summary>
		/// Description: Update individual item structure
		/// FieldName: ISTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update individual item structure")]
		public int? M3ISTR => GetNullableInt("ISTR");

		/// <summary>
		/// Description: Update individual item history
		/// FieldName: IHIS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update individual item history")]
		public int? M3IHIS => GetNullableInt("IHIS");

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
		/// Description: Purchase order line
		/// FieldName: PNLI
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order line")]
		public int? M3PNLI => GetNullableInt("PNLI");

		/// <summary>
		/// Description: Manufacturing order number
		/// FieldName: MFNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3MFNO => GetString("MFNO");

		/// <summary>
		/// Description: Registration number
		/// FieldName: REBE
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration number")]
		public string M3REBE => GetString("REBE");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RORN => GetString("RORN");

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
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Location
		/// FieldName: LOCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3LOCS => GetString("LOCS");

		/// <summary>
		/// Description: Date disposed
		/// FieldName: DDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date disposed")]
		public DateTime? M3DDAT => GetNullableDateTime("DDAT");

		/// <summary>
		/// Description: Fixed asset
		/// FieldName: ASID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset")]
		public string M3ASID => GetString("ASID");

		/// <summary>
		/// Description: Subnumber
		/// FieldName: SBNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnumber")]
		public int? M3SBNO => GetNullableInt("SBNO");

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
		/// Description: Function area
		/// FieldName: FCTN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function area")]
		public string M3FCTN => GetString("FCTN");

		/// <summary>
		/// Description: Agreement customer
		/// FieldName: AGCN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement customer")]
		public string M3AGCN => GetString("AGCN");

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
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3CUNM => GetString("CUNM");
	}
}
// EOF
