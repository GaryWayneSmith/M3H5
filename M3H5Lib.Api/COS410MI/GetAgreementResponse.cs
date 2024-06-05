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

namespace M3H5Lib.Api.COS410MI
{
	public partial class GetAgreementResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Agreement
		/// FieldName: AAGN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement")]
		public string M3AAGN => GetString("AAGN");

		/// <summary>
		/// Description: Agreement type
		/// FieldName: AAGT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement type")]
		public string M3AAGT => GetString("AAGT");

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
		/// Description: Text
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TX30 => GetString("TX30");

		/// <summary>
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: To date
		/// FieldName: TODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3TODT => GetNullableDateTime("TODT");

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
		/// Description: Material currency
		/// FieldName: AMCU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material currency")]
		public string M3AMCU => GetString("AMCU");

		/// <summary>
		/// Description: Critical material
		/// FieldName: CRTM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Critical material")]
		public int? M3CRTM => GetNullableInt("CRTM");

		/// <summary>
		/// Description: Agreement currency
		/// FieldName: AACU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement currency")]
		public string M3AACU => GetString("AACU");

		/// <summary>
		/// Description: Exchange rate type
		/// FieldName: CRTA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public int? M3CRTA => GetNullableInt("CRTA");

		/// <summary>
		/// Description: Serial number administration
		/// FieldName: ACSE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number administration")]
		public int? M3ACSE => GetNullableInt("ACSE");

		/// <summary>
		/// Description: Maximum repair cost
		/// FieldName: AMRE
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum repair cost")]
		public int? M3AMRE => GetNullableInt("AMRE");

		/// <summary>
		/// Description: Modification
		/// FieldName: AMOD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Modification")]
		public int? M3AMOD => GetNullableInt("AMOD");

		/// <summary>
		/// Description: Removal/installation update invoice spec
		/// FieldName: RIUS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Removal/installation update invoice spec")]
		public int? M3RIUS => GetNullableInt("RIUS");

		/// <summary>
		/// Description: Invoice specification layout
		/// FieldName: AISP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice specification layout")]
		public int? M3AISP => GetNullableInt("AISP");

		/// <summary>
		/// Description: Serial number return code
		/// FieldName: SNRC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number return code")]
		public int? M3SNRC => GetNullableInt("SNRC");

		/// <summary>
		/// Description: Order type
		/// FieldName: AOTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3AOTY => GetString("AOTY");

		/// <summary>
		/// Description: Periodic invoice order type
		/// FieldName: PIOT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Periodic invoice order type")]
		public string M3PIOT => GetString("PIOT");

		/// <summary>
		/// Description: Invoicing method
		/// FieldName: INVM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing method")]
		public string M3INVM => GetString("INVM");

		/// <summary>
		/// Description: Material price method
		/// FieldName: APBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material price method")]
		public int? M3APBA => GetNullableInt("APBA");

		/// <summary>
		/// Description: Price origin sequence
		/// FieldName: PRMS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price origin sequence")]
		public string M3PRMS => GetString("PRMS");

		/// <summary>
		/// Description: Material handling charge method
		/// FieldName: AHCM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material handling charge method")]
		public int? M3AHCM => GetNullableInt("AHCM");

		/// <summary>
		/// Description: Price list 1
		/// FieldName: PRR1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 1")]
		public string M3PRR1 => GetString("PRR1");

		/// <summary>
		/// Description: Price list 2
		/// FieldName: PRR2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 2")]
		public string M3PRR2 => GetString("PRR2");

		/// <summary>
		/// Description: Price list 3
		/// FieldName: PRR3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 3")]
		public string M3PRR3 => GetString("PRR3");

		/// <summary>
		/// Description: Price list 4
		/// FieldName: PRR4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 4")]
		public string M3PRR4 => GetString("PRR4");

		/// <summary>
		/// Description: Price list 5
		/// FieldName: PRR5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 5")]
		public string M3PRR5 => GetString("PRR5");

		/// <summary>
		/// Description: Service price list
		/// FieldName: SPRL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service price list")]
		public string M3SPRL => GetString("SPRL");

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
		/// Description: User-defined field 2 - item
		/// FieldName: CFI2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - item")]
		public decimal? M3CFI2 => GetNullableDecimal("CFI2");

		/// <summary>
		/// Description: Summary invoice
		/// FieldName: AICD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Summary invoice")]
		public int? M3AICD => GetNullableInt("AICD");

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
		/// Description: Agreement cancellation - days notice
		/// FieldName: ACDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement cancellation - days notice")]
		public int? M3ACDY => GetNullableInt("ACDY");

		/// <summary>
		/// Description: External reference
		/// FieldName: AREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External reference")]
		public string M3AREF => GetString("AREF");

		/// <summary>
		/// Description: Our reference
		/// FieldName: OREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our reference")]
		public string M3OREF => GetString("OREF");

		/// <summary>
		/// Description: Your reference 1
		/// FieldName: YREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference 1")]
		public string M3YREF => GetString("YREF");

		/// <summary>
		/// Description: Curve
		/// FieldName: AMTN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Curve")]
		public int? M3AMTN => GetNullableInt("AMTN");

		/// <summary>
		/// Description: Number of periods
		/// FieldName: NPAM
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of periods")]
		public int? M3NPAM => GetNullableInt("NPAM");

		/// <summary>
		/// Description: Period accounting
		/// FieldName: PERA
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period accounting")]
		public string M3PERA => GetString("PERA");

		/// <summary>
		/// Description: Rounding-off category
		/// FieldName: ROPP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rounding-off category")]
		public int? M3ROPP => GetNullableInt("ROPP");

		/// <summary>
		/// Description: Check scope of agreement - object
		/// FieldName: ACT9
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check scope of agreement - object")]
		public int? M3ACT9 => GetNullableInt("ACT9");

		/// <summary>
		/// Description: Check scope of agreement - model indiv
		/// FieldName: ACRG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check scope of agreement - model indiv")]
		public int? M3ACRG => GetNullableInt("ACRG");

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
		/// Description: Freight terms
		/// FieldName: TEAF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight terms")]
		public string M3TEAF => GetString("TEAF");
	}
}
// EOF
