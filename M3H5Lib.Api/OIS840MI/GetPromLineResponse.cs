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

namespace M3H5Lib.Api.OIS840MI
{
	public partial class GetPromLineResponse : M3BaseRecord 
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
		/// Description: Promotion
		/// FieldName: PIDE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion")]
		public string M3PIDE => GetString("PIDE");

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
		/// Description: Date code
		/// FieldName: DTCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date code")]
		public int? M3DTCD => GetNullableInt("DTCD");

		/// <summary>
		/// Description: Valid from
		/// FieldName: FVDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3FVDT => GetNullableDateTime("FVDT");

		/// <summary>
		/// Description: Valid to
		/// FieldName: LVDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3LVDT => GetNullableDateTime("LVDT");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3SAPR => GetNullableDecimal("SAPR");

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
		/// Description: Discount percentage
		/// FieldName: DISP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount percentage")]
		public int? M3DISP => GetNullableInt("DISP");

		/// <summary>
		/// Description: Budgeted fixed cost
		/// FieldName: BUFC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budgeted fixed cost")]
		public decimal? M3BUFC => GetNullableDecimal("BUFC");

		/// <summary>
		/// Description: Actual fixed cost
		/// FieldName: ACFC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual fixed cost")]
		public decimal? M3ACFC => GetNullableDecimal("ACFC");

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNR => GetString("ITNR");

		/// <summary>
		/// Description: Ordered quantity - basic U/M
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - basic U/M")]
		public decimal? M3ORQT => GetNullableDecimal("ORQT");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3SAPX => GetNullableDecimal("SAPX");

		/// <summary>
		/// Description: Budget quantity
		/// FieldName: BUQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget quantity")]
		public decimal? M3BUQT => GetNullableDecimal("BUQT");

		/// <summary>
		/// Description: Budget amount
		/// FieldName: BUAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget amount")]
		public decimal? M3BUAM => GetNullableDecimal("BUAM");

		/// <summary>
		/// Description: Sold quantity
		/// FieldName: SOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sold quantity")]
		public decimal? M3SOQT => GetNullableDecimal("SOQT");

		/// <summary>
		/// Description: Amount sold
		/// FieldName: SOAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount sold")]
		public decimal? M3SOAM => GetNullableDecimal("SOAM");

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
		/// Description: Invoice amount - foreign currenc
		/// FieldName: IVAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - foreign currenc")]
		public decimal? M3IVAM => GetNullableDecimal("IVAM");

		/// <summary>
		/// Description: Reserved discount
		/// FieldName: REDI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reserved discount")]
		public decimal? M3REDI => GetNullableDecimal("REDI");

		/// <summary>
		/// Description: Given discount
		/// FieldName: GIDI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Given discount")]
		public decimal? M3GIDI => GetNullableDecimal("GIDI");

		/// <summary>
		/// Description: Affected volume percentage
		/// FieldName: IVSH
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Affected volume percentage")]
		public int? M3IVSH => GetNullableInt("IVSH");

		/// <summary>
		/// Description: Actual volume percentage
		/// FieldName: AVSH
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual volume percentage")]
		public int? M3AVSH => GetNullableInt("AVSH");

		/// <summary>
		/// Description: Activity profile
		/// FieldName: APRF
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Activity profile")]
		public int? M3APRF => GetNullableInt("APRF");

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
		/// Description: Promotion terms
		/// FieldName: PTER
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion terms")]
		public int? M3PTER => GetNullableInt("PTER");

		/// <summary>
		/// Description: Distribution method
		/// FieldName: DIMI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution method")]
		public int? M3DIMI => GetNullableInt("DIMI");

		/// <summary>
		/// Description: Additional text
		/// FieldName: TX08
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional text")]
		public string M3TX08 => GetString("TX08");

		/// <summary>
		/// Description: Discount category
		/// FieldName: DICA
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount category")]
		public string M3DICA => GetString("DICA");

		/// <summary>
		/// Description: Discount base
		/// FieldName: DIBE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount base")]
		public string M3DIBE => GetString("DIBE");

		/// <summary>
		/// Description: Discount relation
		/// FieldName: DIRE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount relation")]
		public string M3DIRE => GetString("DIRE");

		/// <summary>
		/// Description: Manually changeable discount
		/// FieldName: DCHA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manually changeable discount")]
		public int? M3DCHA => GetNullableInt("DCHA");

		/// <summary>
		/// Description: Statistics field for discount
		/// FieldName: DPST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics field for discount")]
		public int? M3DPST => GetNullableInt("DPST");

		/// <summary>
		/// Description: Discount presentation
		/// FieldName: DDSU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount presentation")]
		public int? M3DDSU => GetNullableInt("DDSU");

		/// <summary>
		/// Description: Internal discount
		/// FieldName: IDSC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal discount")]
		public int? M3IDSC => GetNullableInt("IDSC");

		/// <summary>
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Delivery split rule
		/// FieldName: SPLC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery split rule")]
		public string M3SPLC => GetString("SPLC");

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
		/// Description: Costing model - sales price
		/// FieldName: SCMO
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing model - sales price")]
		public string M3SCMO => GetString("SCMO");

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
		/// Description: Conversion factor
		/// FieldName: COFA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion factor")]
		public decimal? M3COFA => GetNullableDecimal("COFA");

		/// <summary>
		/// Description: Conversion form
		/// FieldName: DMCF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion form")]
		public int? M3DMCF => GetNullableInt("DMCF");

		/// <summary>
		/// Description: Bonus generating
		/// FieldName: BNCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus generating")]
		public int? M3BNCD => GetNullableInt("BNCD");

		/// <summary>
		/// Description: Commission generating
		/// FieldName: PRAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commission generating")]
		public int? M3PRAC => GetNullableInt("PRAC");

		/// <summary>
		/// Description: Demand factor
		/// FieldName: DEFC
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Demand factor")]
		public int? M3DEFC => GetNullableInt("DEFC");

		/// <summary>
		/// Description: Budgeted cost
		/// FieldName: BCPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budgeted cost")]
		public decimal? M3BCPR => GetNullableDecimal("BCPR");

		/// <summary>
		/// Description: Actual cost
		/// FieldName: ACPI
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual cost")]
		public decimal? M3ACPI => GetNullableDecimal("ACPI");

		/// <summary>
		/// Description: Bill back
		/// FieldName: BILB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bill back")]
		public int? M3BILB => GetNullableInt("BILB");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SEQN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3SEQN => GetNullableInt("SEQN");

		/// <summary>
		/// Description: Status - promotion
		/// FieldName: PROS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - promotion")]
		public int? M3PROS => GetNullableInt("PROS");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 8
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
		/// Length: 8
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
		/// Description: SPA claim
		/// FieldName: SCLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SPA claim")]
		public decimal? M3SCLA => GetNullableDecimal("SCLA");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3SUNO => GetString("SUNO");

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
		/// Description: SPA claim percentage
		/// FieldName: SCLP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SPA claim percentage")]
		public int? M3SCLP => GetNullableInt("SCLP");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AGNB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3AGNB => GetString("AGNB");

		/// <summary>
		/// Description: Limit value
		/// FieldName: LIMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit value")]
		public decimal? M3LIMT => GetNullableDecimal("LIMT");
	}
}
// EOF
