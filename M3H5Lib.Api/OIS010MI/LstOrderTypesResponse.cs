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

namespace M3H5Lib.Api.OIS010MI
{
	public partial class LstOrderTypesResponse : M3BaseRecord 
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
		/// Description: Customer order type
		/// FieldName: ORTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order type")]
		public string M3_ORTP => GetString("ORTP");

		/// <summary>
		/// Description: Customer order category
		/// FieldName: ORTK
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order category")]
		public string M3_ORTK => GetString("ORTK");

		/// <summary>
		/// Description: Next manual function
		/// FieldName: NEXT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next manual function")]
		public int? M3_NEXT => GetNullableInt("NEXT");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Business chain check
		/// FieldName: OT01
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain check")]
		public int? M3_OT01 => GetNullableInt("OT01");

		/// <summary>
		/// Description: Credit check - new entry of order
		/// FieldName: CLOE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit check - new entry of order")]
		public int? M3_CLOE => GetNullableInt("CLOE");

		/// <summary>
		/// Description: Credit chech - new entry of lines
		/// FieldName: CLLE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit chech - new entry of lines")]
		public int? M3_CLLE => GetNullableInt("CLLE");

		/// <summary>
		/// Description: Ignore payer block code
		/// FieldName: AUBC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ignore payer block code")]
		public int? M3_AUBC => GetNullableInt("AUBC");

		/// <summary>
		/// Description: Check order charges
		/// FieldName: OT67
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check order charges")]
		public int? M3_OT67 => GetNullableInt("OT67");

		/// <summary>
		/// Description: Season in use
		/// FieldName: SEAH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Season in use")]
		public int? M3_SEAH => GetNullableInt("SEAH");

		/// <summary>
		/// Description: Minimum processing time
		/// FieldName: OT22
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum processing time")]
		public int? M3_OT22 => GetNullableInt("OT22");

		/// <summary>
		/// Description: Check sequence - item ID
		/// FieldName: OT19
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check sequence - item ID")]
		public string M3_OT19 => GetString("OT19");

		/// <summary>
		/// Description: Search sequence - alias type
		/// FieldName: OT73
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search sequence - alias type")]
		public string M3_OT73 => GetString("OT73");

		/// <summary>
		/// Description: Quantity sign
		/// FieldName: OT11
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity sign")]
		public int? M3_OT11 => GetNullableInt("OT11");

		/// <summary>
		/// Description: Check duplicates
		/// FieldName: OT66
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check duplicates")]
		public int? M3_OT66 => GetNullableInt("OT66");

		/// <summary>
		/// Description: Pricing, discount and VAT setting
		/// FieldName: OT31
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pricing, discount and VAT setting")]
		public int? M3_OT31 => GetNullableInt("OT31");

		/// <summary>
		/// Description: Sales price rule
		/// FieldName: OT12
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price rule")]
		public int? M3_OT12 => GetNullableInt("OT12");

		/// <summary>
		/// Description: Propose quantity
		/// FieldName: OT72
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Propose quantity")]
		public int? M3_OT72 => GetNullableInt("OT72");

		/// <summary>
		/// Description: Several warehouses permitted
		/// FieldName: OT10
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Several warehouses permitted")]
		public int? M3_OT10 => GetNullableInt("OT10");

		/// <summary>
		/// Description: Price origin sequence
		/// FieldName: PRMS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price origin sequence")]
		public string M3_PRMS => GetString("PRMS");

		/// <summary>
		/// Description: Agreement check
		/// FieldName: AGCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement check")]
		public int? M3_AGCL => GetNullableInt("AGCL");

		/// <summary>
		/// Description: Contribution margin ratio check
		/// FieldName: OT63
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Contribution margin ratio check")]
		public int? M3_OT63 => GetNullableInt("OT63");

		/// <summary>
		/// Description: Quantity limit check
		/// FieldName: QLCH
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity limit check")]
		public int? M3_QLCH => GetNullableInt("QLCH");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3_TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Cash discount term
		/// FieldName: TECD
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount term")]
		public string M3_TECD => GetString("TECD");

		/// <summary>
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3_MODL => GetString("MODL");

		/// <summary>
		/// Description: Delivery terms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms")]
		public string M3_TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Line charge model
		/// FieldName: CHSY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line charge model")]
		public string M3_CHSY => GetString("CHSY");

		/// <summary>
		/// Description: Price list table
		/// FieldName: PLTB
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list table")]
		public string M3_PLTB => GetString("PLTB");

		/// <summary>
		/// Description: Service charge
		/// FieldName: EXCD
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service charge")]
		public string M3_EXCD => GetString("EXCD");

		/// <summary>
		/// Description: Discount model
		/// FieldName: DISY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount model")]
		public string M3_DISY => GetString("DISY");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3_CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Delivery address - order line
		/// FieldName: ADIL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery address - order line")]
		public string M3_ADIL => GetString("ADIL");

		/// <summary>
		/// Description: Field selections 1
		/// FieldName: FLDS
		/// FieldType: A
		/// Length: 100
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field selections 1")]
		public string M3_FLDS => GetString("FLDS");

		/// <summary>
		/// Description: Field selection 2
		/// FieldName: FLD2
		/// FieldType: A
		/// Length: 100
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field selection 2")]
		public string M3_FLD2 => GetString("FLD2");

		/// <summary>
		/// Description: Cost price rule
		/// FieldName: OT14
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price rule")]
		public int? M3_OT14 => GetNullableInt("OT14");

		/// <summary>
		/// Description: Exchange rate type
		/// FieldName: CRTP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public string M3_CRTP => GetString("CRTP");

		/// <summary>
		/// Description: Promotion check
		/// FieldName: OT17
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion check")]
		public int? M3_OT17 => GetNullableInt("OT17");

		/// <summary>
		/// Description: Advance invoicing
		/// FieldName: OT35
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Advance invoicing")]
		public int? M3_OT35 => GetNullableInt("OT35");

		/// <summary>
		/// Description: Default line type
		/// FieldName: OT47
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default line type")]
		public string M3_OT47 => GetString("OT47");

		/// <summary>
		/// Description: Cash desk active
		/// FieldName: CAPM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash desk active")]
		public int? M3_CAPM => GetNullableInt("CAPM");

		/// <summary>
		/// Description: Credit check - close
		/// FieldName: CLOQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit check - close")]
		public int? M3_CLOQ => GetNullableInt("CLOQ");
	}
}
// EOF
