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

namespace M3H5Lib.Api.OIS100MI
{
	public partial class LstCOLineInfoResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: POSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3POSX => GetNullableInt("POSX");

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
		/// Description: Line type
		/// FieldName: LTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line type")]
		public string M3LTYP => GetString("LTYP");

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
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Description 1
		/// FieldName: TEDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 1")]
		public string M3TEDS => GetString("TEDS");

		/// <summary>
		/// Description: Ordered quantity - alternate U/M
		/// FieldName: ORQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - alternate U/M")]
		public decimal? M3ORQA => GetNullableDecimal("ORQA");

		/// <summary>
		/// Description: Alternate U/M
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M")]
		public string M3ALUN => GetString("ALUN");

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
		/// Description: Discount amount
		/// FieldName: DIAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount")]
		public decimal? M3DIAM => GetNullableDecimal("DIAM");

		/// <summary>
		/// Description: Discount amount per unit
		/// FieldName: DIPR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount per unit")]
		public decimal? M3DIPR => GetNullableDecimal("DIPR");

		/// <summary>
		/// Description: Sales price unit of measure
		/// FieldName: SPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price unit of measure")]
		public string M3SPUN => GetString("SPUN");

		/// <summary>
		/// Description: Highest status - customer order
		/// FieldName: ORST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status - customer order")]
		public string M3ORST => GetString("ORST");

		/// <summary>
		/// Description: Line amount - order currency
		/// FieldName: LNAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line amount - order currency")]
		public decimal? M3LNAM => GetNullableDecimal("LNAM");

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
		/// Description: Confirmed delivery date
		/// FieldName: CODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed delivery date")]
		public DateTime? M3CODT => GetNullableDateTime("CODT");

		/// <summary>
		/// Description: Configuration number
		/// FieldName: CFIN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration number")]
		public long? M3CFIN => GetNullableLong("CFIN");

		/// <summary>
		/// Description: Margin amount
		/// FieldName: TBAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin amount")]
		public decimal? M3TBAM => GetNullableDecimal("TBAM");

		/// <summary>
		/// Description: Margin amount VAT included
		/// FieldName: TBAV
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin amount VAT included")]
		public decimal? M3TBAV => GetNullableDecimal("TBAV");

		/// <summary>
		/// Description: Margin percent
		/// FieldName: TBPR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin percent")]
		public int? M3TBPR => GetNullableInt("TBPR");

		/// <summary>
		/// Description: Cost price
		/// FieldName: UCOS
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price")]
		public decimal? M3UCOS => GetNullableDecimal("UCOS");

		/// <summary>
		/// Description: Invoice per location
		/// FieldName: IVCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice per location")]
		public int? M3IVCD => GetNullableInt("IVCD");

		/// <summary>
		/// Description: Minimum amount per payment reminder
		/// FieldName: REMA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum amount per payment reminder")]
		public decimal? M3REMA => GetNullableDecimal("REMA");

		/// <summary>
		/// Description: Total price
		/// FieldName: TOPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total price")]
		public decimal? M3TOPR => GetNullableDecimal("TOPR");

		/// <summary>
		/// Description: Order total discount - percentage
		/// FieldName: OTDP
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order total discount - percentage")]
		public decimal? M3OTDP => GetNullableDecimal("OTDP");

		/// <summary>
		/// Description: Text heading
		/// FieldName: TXTH
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text heading")]
		public string M3TXTH => GetString("TXTH");

		/// <summary>
		/// Description: Text - lines
		/// FieldName: TXTL
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text - lines")]
		public string M3TXTL => GetString("TXTL");

		/// <summary>
		/// Description: Sales campaign
		/// FieldName: CMNO
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales campaign")]
		public string M3CMNO => GetString("CMNO");

		/// <summary>
		/// Description: Net price used
		/// FieldName: NTCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net price used")]
		public int? M3NTCD => GetNullableInt("NTCD");

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
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Number of price decimal places
		/// FieldName: PDCC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of price decimal places")]
		public int? M3PDCC => GetNullableInt("PDCC");

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
		/// Description: Supplier order number
		/// FieldName: SORN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier order number")]
		public string M3SORN => GetString("SORN");

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
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3CUNM => GetString("CUNM");

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
		/// Description: Modification date
		/// FieldName: MODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Modification date")]
		public DateTime? M3MODT => GetNullableDateTime("MODT");

		/// <summary>
		/// Description: Delivered quantity - basic U/M
		/// FieldName: DLQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivered quantity - basic U/M")]
		public decimal? M3DLQT => GetNullableDecimal("DLQT");

		/// <summary>
		/// Description: Delivered quantity - alternate U/M
		/// FieldName: DLQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivered quantity - alternate U/M")]
		public decimal? M3DLQA => GetNullableDecimal("DLQA");

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
		/// Description: Invoiced quantity - alternate U/M
		/// FieldName: IVQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced quantity - alternate U/M")]
		public decimal? M3IVQA => GetNullableDecimal("IVQA");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Backlog rounding
		/// FieldName: BLRO
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Backlog rounding")]
		public decimal? M3BLRO => GetNullableDecimal("BLRO");

		/// <summary>
		/// Description: Prepay amount - order currency
		/// FieldName: CUAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prepay amount - order currency")]
		public decimal? M3CUAM => GetNullableDecimal("CUAM");

		/// <summary>
		/// Description: External charge
		/// FieldName: EFAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External charge")]
		public decimal? M3EFAM => GetNullableDecimal("EFAM");

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
	}
}
// EOF
