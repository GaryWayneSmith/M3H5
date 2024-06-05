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

namespace M3H5Lib.Api.OIS320MI
{
	public partial class GetPriceLineResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Warehouse location
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse location")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAPR => GetNullableDecimal("SAPR");

		/// <summary>
		/// Description: Line amount
		/// FieldName: LNAM
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line amount")]
		public decimal? M3_LNAM => GetNullableDecimal("LNAM");

		/// <summary>
		/// Description: Order date
		/// FieldName: ORDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order date")]
		public DateTime? M3_ORDT => GetNullableDateTime("ORDT");

		/// <summary>
		/// Description: Ordered quantity
		/// FieldName: ORQA
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity")]
		public decimal? M3_ORQA => GetNullableDecimal("ORQA");

		/// <summary>
		/// Description: Ordered quantity - sales price
		/// FieldName: ORQS
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - sales price")]
		public decimal? M3_ORQS => GetNullableDecimal("ORQS");

		/// <summary>
		/// Description: Pricelist
		/// FieldName: PRRF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pricelist")]
		public string M3_PRRF => GetString("PRRF");

		/// <summary>
		/// Description: Sales person
		/// FieldName: SMCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales person")]
		public string M3_SMCD => GetString("SMCD");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_ORTP => GetString("ORTP");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AAGN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3_AAGN => GetString("AAGN");

		/// <summary>
		/// Description: Blanket agreement number
		/// FieldName: BAGN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blanket agreement number")]
		public string M3_BAGN => GetString("BAGN");

		/// <summary>
		/// Description: Discount model
		/// FieldName: DISY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount model")]
		public string M3_DISY => GetString("DISY");

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
		/// Description: Alternative unit
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternative unit")]
		public string M3_ALUN => GetString("ALUN");

		/// <summary>
		/// Description: Price origin
		/// FieldName: PRMO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price origin")]
		public string M3_PRMO => GetString("PRMO");

		/// <summary>
		/// Description: Sales price unit of measure
		/// FieldName: SPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price unit of measure")]
		public string M3_SPUN => GetString("SPUN");

		/// <summary>
		/// Description: Sales price quantity
		/// FieldName: SACD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price quantity")]
		public string M3_SACD => GetString("SACD");

		/// <summary>
		/// Description: Pricelist
		/// FieldName: PRRO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pricelist")]
		public string M3_PRRO => GetString("PRRO");

		/// <summary>
		/// Description: Sales campaign ID
		/// FieldName: CMNO
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales campaign ID")]
		public string M3_CMNO => GetString("CMNO");

		/// <summary>
		/// Description: Discount amount 1
		/// FieldName: DIA1
		/// FieldType: A
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 1")]
		public string M3_DIA1 => GetString("DIA1");

		/// <summary>
		/// Description: Discount amount 2
		/// FieldName: DIA2
		/// FieldType: A
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 2")]
		public string M3_DIA2 => GetString("DIA2");

		/// <summary>
		/// Description: Discount amount 3
		/// FieldName: DIA3
		/// FieldType: A
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 3")]
		public string M3_DIA3 => GetString("DIA3");

		/// <summary>
		/// Description: Discount amount 4
		/// FieldName: DIA4
		/// FieldType: A
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 4")]
		public string M3_DIA4 => GetString("DIA4");

		/// <summary>
		/// Description: Discount amount 5
		/// FieldName: DIA5
		/// FieldType: A
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 5")]
		public string M3_DIA5 => GetString("DIA5");

		/// <summary>
		/// Description: Discount amount 6
		/// FieldName: DIA6
		/// FieldType: A
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 6")]
		public string M3_DIA6 => GetString("DIA6");

		/// <summary>
		/// Description: Status discount 1 - origin
		/// FieldName: DIC1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 1 - origin")]
		public int? M3_DIC1 => GetNullableInt("DIC1");

		/// <summary>
		/// Description: Status discount 2 - origin
		/// FieldName: DIC2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 2 - origin")]
		public int? M3_DIC2 => GetNullableInt("DIC2");

		/// <summary>
		/// Description: Status discount 3 - origin
		/// FieldName: DIC3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 3 - origin")]
		public int? M3_DIC3 => GetNullableInt("DIC3");

		/// <summary>
		/// Description: Status discount 4 - origin
		/// FieldName: DIC4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 4 - origin")]
		public int? M3_DIC4 => GetNullableInt("DIC4");

		/// <summary>
		/// Description: Status discount 5 - origin
		/// FieldName: DIC5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 5 - origin")]
		public int? M3_DIC5 => GetNullableInt("DIC5");

		/// <summary>
		/// Description: Status discount 6 - origin
		/// FieldName: DIC6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 6 - origin")]
		public int? M3_DIC6 => GetNullableInt("DIC6");

		/// <summary>
		/// Description: Statistics identity 1 - Discount
		/// FieldName: CMP1
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 1 - Discount")]
		public string M3_CMP1 => GetString("CMP1");

		/// <summary>
		/// Description: Statistics identity 2 - Discount
		/// FieldName: CMP2
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 2 - Discount")]
		public string M3_CMP2 => GetString("CMP2");

		/// <summary>
		/// Description: Statistics identity 3 - Discount
		/// FieldName: CMP3
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 3 - Discount")]
		public string M3_CMP3 => GetString("CMP3");

		/// <summary>
		/// Description: Statistics identity 4 - Discount
		/// FieldName: CMP4
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 4 - Discount")]
		public string M3_CMP4 => GetString("CMP4");

		/// <summary>
		/// Description: Statistics identity 4 - Discount
		/// FieldName: CMP5
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 4 - Discount")]
		public string M3_CMP5 => GetString("CMP5");

		/// <summary>
		/// Description: Statistics identity 6 - Discount
		/// FieldName: CMP6
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 6 - Discount")]
		public string M3_CMP6 => GetString("CMP6");

		/// <summary>
		/// Description: Discount text 1
		/// FieldName: TX81
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount text 1")]
		public string M3_TX81 => GetString("TX81");

		/// <summary>
		/// Description: Discount text 2
		/// FieldName: TX82
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount text 2")]
		public string M3_TX82 => GetString("TX82");

		/// <summary>
		/// Description: Discount text 3
		/// FieldName: TX83
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount text 3")]
		public string M3_TX83 => GetString("TX83");

		/// <summary>
		/// Description: Discount text 4
		/// FieldName: TX84
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount text 4")]
		public string M3_TX84 => GetString("TX84");

		/// <summary>
		/// Description: Discount text 5
		/// FieldName: TX85
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount text 5")]
		public string M3_TX85 => GetString("TX85");

		/// <summary>
		/// Description: Discount text 6
		/// FieldName: TX86
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount text 6")]
		public string M3_TX86 => GetString("TX86");

		/// <summary>
		/// Description: Business chain - level 1
		/// FieldName: CHL1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 1")]
		public string M3_CHL1 => GetString("CHL1");

		/// <summary>
		/// Description: Business chain - level 2
		/// FieldName: CHL2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 2")]
		public string M3_CHL2 => GetString("CHL2");

		/// <summary>
		/// Description: Business chain - level 3
		/// FieldName: CHL3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 3")]
		public string M3_CHL3 => GetString("CHL3");

		/// <summary>
		/// Description: Business chain - level 4
		/// FieldName: CHL4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 4")]
		public string M3_CHL4 => GetString("CHL4");

		/// <summary>
		/// Description: VAT included
		/// FieldName: TINC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT included")]
		public int? M3_TINC => GetNullableInt("TINC");

		/// <summary>
		/// Description: Net price used
		/// FieldName: NTCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net price used")]
		public int? M3_NTCD => GetNullableInt("NTCD");

		/// <summary>
		/// Description: Promotion
		/// FieldName: PIDE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion")]
		public string M3_PIDE => GetString("PIDE");

		/// <summary>
		/// Description: Item number
		/// FieldName: KIT1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_KIT1 => GetString("KIT1");

		/// <summary>
		/// Description: Ordered quantity - basic U/M
		/// FieldName: KQT1
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - basic U/M")]
		public decimal? M3_KQT1 => GetNullableDecimal("KQT1");

		/// <summary>
		/// Description: Sales price
		/// FieldName: KSP1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_KSP1 => GetNullableDecimal("KSP1");

		/// <summary>
		/// Description: Name
		/// FieldName: KDS1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_KDS1 => GetString("KDS1");

		/// <summary>
		/// Description: Item number
		/// FieldName: KIT2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_KIT2 => GetString("KIT2");

		/// <summary>
		/// Description: Ordered quantity - basic U/M
		/// FieldName: KQT2
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - basic U/M")]
		public decimal? M3_KQT2 => GetNullableDecimal("KQT2");

		/// <summary>
		/// Description: Sales price
		/// FieldName: KSP2
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_KSP2 => GetNullableDecimal("KSP2");

		/// <summary>
		/// Description: Name
		/// FieldName: KDS2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_KDS2 => GetString("KDS2");

		/// <summary>
		/// Description: Item number
		/// FieldName: KIT3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_KIT3 => GetString("KIT3");

		/// <summary>
		/// Description: Ordered quantity - basic U/M
		/// FieldName: KQT3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - basic U/M")]
		public decimal? M3_KQT3 => GetNullableDecimal("KQT3");

		/// <summary>
		/// Description: Sales price
		/// FieldName: KSP3
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_KSP3 => GetNullableDecimal("KSP3");

		/// <summary>
		/// Description: Name
		/// FieldName: KDS3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_KDS3 => GetString("KDS3");

		/// <summary>
		/// Description: Discount 1
		/// FieldName: DIP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 1")]
		public int? M3_DIP1 => GetNullableInt("DIP1");

		/// <summary>
		/// Description: Discount 2
		/// FieldName: DIP2
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 2")]
		public int? M3_DIP2 => GetNullableInt("DIP2");

		/// <summary>
		/// Description: Discount 3
		/// FieldName: DIP3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 3")]
		public int? M3_DIP3 => GetNullableInt("DIP3");

		/// <summary>
		/// Description: Discount 4
		/// FieldName: DIP4
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 4")]
		public int? M3_DIP4 => GetNullableInt("DIP4");

		/// <summary>
		/// Description: Discount 5
		/// FieldName: DIP5
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 5")]
		public int? M3_DIP5 => GetNullableInt("DIP5");

		/// <summary>
		/// Description: Discount 6
		/// FieldName: DIP6
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 6")]
		public int? M3_DIP6 => GetNullableInt("DIP6");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAP1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAP1 => GetNullableDecimal("SAP1");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAP2
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAP2 => GetNullableDecimal("SAP2");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAP3
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAP3 => GetNullableDecimal("SAP3");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAP4
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAP4 => GetNullableDecimal("SAP4");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAP5
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAP5 => GetNullableDecimal("SAP5");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAP6
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAP6 => GetNullableDecimal("SAP6");

		/// <summary>
		/// Description: Discount amount per unit
		/// FieldName: DPR1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount per unit")]
		public decimal? M3_DPR1 => GetNullableDecimal("DPR1");

		/// <summary>
		/// Description: Discount amount per unit
		/// FieldName: DPR2
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount per unit")]
		public decimal? M3_DPR2 => GetNullableDecimal("DPR2");

		/// <summary>
		/// Description: Discount amount per unit
		/// FieldName: DPR3
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount per unit")]
		public decimal? M3_DPR3 => GetNullableDecimal("DPR3");

		/// <summary>
		/// Description: Discount amount per unit
		/// FieldName: DPR4
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount per unit")]
		public decimal? M3_DPR4 => GetNullableDecimal("DPR4");

		/// <summary>
		/// Description: Discount amount per unit
		/// FieldName: DPR5
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount per unit")]
		public decimal? M3_DPR5 => GetNullableDecimal("DPR5");

		/// <summary>
		/// Description: Discount amount per unit
		/// FieldName: DPR6
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount per unit")]
		public decimal? M3_DPR6 => GetNullableDecimal("DPR6");

		/// <summary>
		/// Description: Net price
		/// FieldName: NETP
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net price")]
		public decimal? M3_NETP => GetNullableDecimal("NETP");

		/// <summary>
		/// Description: Order total discount
		/// FieldName: ODAM
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order total discount")]
		public decimal? M3_ODAM => GetNullableDecimal("ODAM");

		/// <summary>
		/// Description: Core charge item number
		/// FieldName: CCI1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Core charge item number")]
		public string M3_CCI1 => GetString("CCI1");

		/// <summary>
		/// Description: Sales price - core charge
		/// FieldName: CCSA
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price - core charge")]
		public decimal? M3_CCSA => GetNullableDecimal("CCSA");

		/// <summary>
		/// Description: Margin percent
		/// FieldName: TBPR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin percent")]
		public int? M3_TBPR => GetNullableInt("TBPR");

		/// <summary>
		/// Description: Margin amount
		/// FieldName: TBAM
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin amount")]
		public decimal? M3_TBAM => GetNullableDecimal("TBAM");

		/// <summary>
		/// Description: Cost price
		/// FieldName: UCOS
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price")]
		public decimal? M3_UCOS => GetNullableDecimal("UCOS");

		/// <summary>
		/// Description: Average cost
		/// FieldName: APPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Average cost")]
		public decimal? M3_APPR => GetNullableDecimal("APPR");

		/// <summary>
		/// Description: Inventory accounting method
		/// FieldName: VAMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting method")]
		public int? M3_VAMT => GetNullableInt("VAMT");

		/// <summary>
		/// Description: Costing decimal places
		/// FieldName: CPDC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing decimal places")]
		public int? M3_CPDC => GetNullableInt("CPDC");

		/// <summary>
		/// Description: Item cost quantity
		/// FieldName: COCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item cost quantity")]
		public int? M3_COCD => GetNullableInt("COCD");

		/// <summary>
		/// Description: Cost unit of measure
		/// FieldName: CPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost unit of measure")]
		public string M3_CPUN => GetString("CPUN");

		/// <summary>
		/// Description: Local currency
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency")]
		public string M3_LOCD => GetString("LOCD");
	}
}
// EOF
