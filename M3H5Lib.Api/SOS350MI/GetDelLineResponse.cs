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

namespace M3H5Lib.Api.SOS350MI
{
	public partial class GetDelLineResponse : M3BaseRecord 
	{

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
		/// Description: Customer name
		/// FieldName: CUN1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3CUN1 => GetString("CUN1");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3PYNO => GetString("PYNO");

		/// <summary>
		/// Description: Payer name
		/// FieldName: CUN2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer name")]
		public string M3CUN2 => GetString("CUN2");

		/// <summary>
		/// Description: Customer order number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order number")]
		public string M3ORNO => GetString("ORNO");

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
		/// Description: Warehouse description
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse description")]
		public string M3WHNM => GetString("WHNM");

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
		/// Description: Approved by signature
		/// FieldName: APBY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved by signature")]
		public string M3APBY => GetString("APBY");

		/// <summary>
		/// Description: Date approved
		/// FieldName: APDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date approved")]
		public DateTime? M3APDT => GetNullableDateTime("APDT");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Delivered quantity - basic U/M
		/// FieldName: QTY1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivered quantity - basic U/M")]
		public decimal? M3QTY1 => GetNullableDecimal("QTY1");

		/// <summary>
		/// Description: Invoiced quantity - basic U/M
		/// FieldName: QTY4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced quantity - basic U/M")]
		public decimal? M3QTY4 => GetNullableDecimal("QTY4");

		/// <summary>
		/// Description: Quantity difference
		/// FieldName: CHQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity difference")]
		public decimal? M3CHQT => GetNullableDecimal("CHQT");

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
		/// Description: Delivered quantity - alternate U/M
		/// FieldName: QTY2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivered quantity - alternate U/M")]
		public decimal? M3QTY2 => GetNullableDecimal("QTY2");

		/// <summary>
		/// Description: Invoiced quantity - alternate U/M
		/// FieldName: QTY5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced quantity - alternate U/M")]
		public decimal? M3QTY5 => GetNullableDecimal("QTY5");

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
		/// Description: Delivered quantity - sales price U/M
		/// FieldName: QTY3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivered quantity - sales price U/M")]
		public decimal? M3QTY3 => GetNullableDecimal("QTY3");

		/// <summary>
		/// Description: Invoiced quantity - sales price U/M
		/// FieldName: QTY6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced quantity - sales price U/M")]
		public decimal? M3QTY6 => GetNullableDecimal("QTY6");

		/// <summary>
		/// Description: Inventory accounting
		/// FieldName: STCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting")]
		public int? M3STCD => GetNullableInt("STCD");

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
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3SAPR => GetNullableDecimal("SAPR");

		/// <summary>
		/// Description: Sales price quantity
		/// FieldName: SACD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price quantity")]
		public int? M3SACD => GetNullableInt("SACD");

		/// <summary>
		/// Description: Issued cost amount
		/// FieldName: DCOS
		/// FieldType: N
		/// Length: 23
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issued cost amount")]
		public decimal? M3DCOS => GetNullableDecimal("DCOS");

		/// <summary>
		/// Description: Issued cost amount - local currency
		/// FieldName: ACAM
		/// FieldType: N
		/// Length: 23
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issued cost amount - local currency")]
		public decimal? M3ACAM => GetNullableDecimal("ACAM");

		/// <summary>
		/// Description: Sales price - local currency
		/// FieldName: SAP1
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price - local currency")]
		public decimal? M3SAP1 => GetNullableDecimal("SAP1");
	}
}
// EOF
