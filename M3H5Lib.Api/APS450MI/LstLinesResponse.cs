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

namespace M3H5Lib.Api.APS450MI
{
	public partial class LstLinesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Transaction number
		/// FieldName: TRNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction number")]
		public int? M3TRNO => GetNullableInt("TRNO");

		/// <summary>
		/// Description: Line type
		/// FieldName: RDTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line type")]
		public int? M3RDTP => GetNullableInt("RDTP");

		/// <summary>
		/// Description: Invoice batch line error
		/// FieldName: IBLE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice batch line error")]
		public int? M3IBLE => GetNullableInt("IBLE");

		/// <summary>
		/// Description: Service code
		/// FieldName: SERS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service code")]
		public int? M3SERS => GetNullableInt("SERS");

		/// <summary>
		/// Description: Net amount - line
		/// FieldName: NLAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net amount - line")]
		public decimal? M3NLAM => GetNullableDecimal("NLAM");

		/// <summary>
		/// Description: Adjusted amount
		/// FieldName: ADAB
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjusted amount")]
		public decimal? M3ADAB => GetNullableDecimal("ADAB");

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
		/// Description: VAT amount 1
		/// FieldName: VTA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT amount 1")]
		public decimal? M3VTA1 => GetNullableDecimal("VTA1");

		/// <summary>
		/// Description: VAT amount 2
		/// FieldName: VTA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT amount 2")]
		public decimal? M3VTA2 => GetNullableDecimal("VTA2");

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public int? M3VTCD => GetNullableInt("VTCD");

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
		/// Description: Purchase order line subnumber
		/// FieldName: PNLS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order line subnumber")]
		public int? M3PNLS => GetNullableInt("PNLS");

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
		/// Description: Purchase order U/M
		/// FieldName: PUUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order U/M")]
		public string M3PUUN => GetString("PUUN");

		/// <summary>
		/// Description: Gross price
		/// FieldName: GRPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross price")]
		public decimal? M3GRPR => GetNullableDecimal("GRPR");

		/// <summary>
		/// Description: Purchase price U/M
		/// FieldName: PPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price U/M")]
		public string M3PPUN => GetString("PPUN");

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
		/// Description: Purchase price quantity
		/// FieldName: PUCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price quantity")]
		public int? M3PUCD => GetNullableInt("PUCD");

		/// <summary>
		/// Description: Gross amount - line
		/// FieldName: GLAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross amount - line")]
		public decimal? M3GLAM => GetNullableDecimal("GLAM");

		/// <summary>
		/// Description: Discount
		/// FieldName: DIPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount")]
		public int? M3DIPC => GetNullableInt("DIPC");

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
		/// Description: Invoiced catch weight
		/// FieldName: IVCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced catch weight")]
		public decimal? M3IVCW => GetNullableDecimal("IVCW");

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
		/// Description: Alias number
		/// FieldName: POPN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias number")]
		public string M3POPN => GetString("POPN");

		/// <summary>
		/// Description: Self-billing agreement number
		/// FieldName: SBAN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Self-billing agreement number")]
		public string M3SBAN => GetString("SBAN");

		/// <summary>
		/// Description: Sequence number - costing element
		/// FieldName: CDSE
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number - costing element")]
		public int? M3CDSE => GetNullableInt("CDSE");

		/// <summary>
		/// Description: Costing element
		/// FieldName: CEID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing element")]
		public string M3CEID => GetString("CEID");

		/// <summary>
		/// Description: Receiving number
		/// FieldName: REPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving number")]
		public long? M3REPN => GetNullableLong("REPN");

		/// <summary>
		/// Description: Receipt type
		/// FieldName: RELP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt type")]
		public int? M3RELP => GetNullableInt("RELP");

		/// <summary>
		/// Description: Delivery note number
		/// FieldName: SUDO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note number")]
		public string M3SUDO => GetString("SUDO");

		/// <summary>
		/// Description: Delivery note date
		/// FieldName: DNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note date")]
		public DateTime? M3DNDT => GetNullableDateTime("DNDT");

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
		/// Description: VAT rate 1
		/// FieldName: VTP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT rate 1")]
		public int? M3VTP1 => GetNullableInt("VTP1");

		/// <summary>
		/// Description: VAT rate 2
		/// FieldName: VTP2
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT rate 2")]
		public int? M3VTP2 => GetNullableInt("VTP2");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: CINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public string M3CINO => GetString("CINO");

		/// <summary>
		/// Description: Invoice year
		/// FieldName: INYR
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice year")]
		public int? M3INYR => GetNullableInt("INYR");
	}
}
// EOF
