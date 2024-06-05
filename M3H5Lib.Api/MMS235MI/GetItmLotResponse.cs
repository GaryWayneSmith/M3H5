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

namespace M3H5Lib.Api.MMS235MI
{
	public partial class GetItmLotResponse : M3BaseRecord 
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
		/// Description: Itemnumber
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Itemnumber")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Lotnumber
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lotnumber")]
		public string M3_BANO => GetString("BANO");

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
		/// Description: Status-balanceID
		/// FieldName: STAS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status-balanceID")]
		public string M3_STAS => GetString("STAS");

		/// <summary>
		/// Description: Referenceordercategory
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Referenceordercategory")]
		public int? M3_RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Allocatable
		/// FieldName: ALOC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable")]
		public int? M3_ALOC => GetNullableInt("ALOC");

		/// <summary>
		/// Description: Referenceordernumber
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Referenceordernumber")]
		public string M3_RORN => GetString("RORN");

		/// <summary>
		/// Description: Lottype
		/// FieldName: LOTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lottype")]
		public int? M3_LOTY => GetNullableInt("LOTY");

		/// <summary>
		/// Description: Referenceorderline
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Referenceorderline")]
		public int? M3_RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Linesuffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Linesuffix")]
		public int? M3_RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Suppliernumber
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliernumber")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Manufacturer
		/// FieldName: PROD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturer")]
		public string M3_PROD => GetString("PROD");

		/// <summary>
		/// Description: Supplier/manufactureritemnumber
		/// FieldName: MFIT
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier/manufactureritemnumber")]
		public string M3_MFIT => GetString("MFIT");

		/// <summary>
		/// Description: Manufacturerserialnumber
		/// FieldName: MFSN
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturerserialnumber")]
		public string M3_MFSN => GetString("MFSN");

		/// <summary>
		/// Description: Revisionnumber
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revisionnumber")]
		public string M3_ECVE => GetString("ECVE");

		/// <summary>
		/// Description: Reclassificationdate
		/// FieldName: RCLS
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reclassificationdate")]
		public DateTime? M3_RCLS => GetNullableDateTime("RCLS");

		/// <summary>
		/// Description: Qualityinspectionapprovaldate
		/// FieldName: QIAD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Qualityinspectionapprovaldate")]
		public DateTime? M3_QIAD => GetNullableDateTime("QIAD");

		/// <summary>
		/// Description: Expirationdate
		/// FieldName: EXPI
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expirationdate")]
		public DateTime? M3_EXPI => GetNullableDateTime("EXPI");

		/// <summary>
		/// Description: Follow-update
		/// FieldName: CNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-update")]
		public DateTime? M3_CNDT => GetNullableDateTime("CNDT");

		/// <summary>
		/// Description: Salesdate
		/// FieldName: SEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Salesdate")]
		public DateTime? M3_SEDT => GetNullableDateTime("SEDT");

		/// <summary>
		/// Description: Lotreference1
		/// FieldName: BREF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lotreference1")]
		public string M3_BREF => GetString("BREF");

		/// <summary>
		/// Description: Lotreference2
		/// FieldName: BRE2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lotreference2")]
		public string M3_BRE2 => GetString("BRE2");

		/// <summary>
		/// Description: On-handbalanceapproved
		/// FieldName: STQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-handbalanceapproved")]
		public decimal? M3_STQT => GetNullableDecimal("STQT");

		/// <summary>
		/// Description: Allocatedquantity-basicU/M
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatedquantity-basicU/M")]
		public decimal? M3_ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Allocatableon-handbalance
		/// FieldName: AVAL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatableon-handbalance")]
		public decimal? M3_AVAL => GetNullableDecimal("AVAL");

		/// <summary>
		/// Description: Countryoforigin
		/// FieldName: ORCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Countryoforigin")]
		public string M3_ORCO => GetString("ORCO");

		/// <summary>
		/// Description: Filingaddress
		/// FieldName: ARLA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filingaddress")]
		public string M3_ARLA => GetString("ARLA");

		/// <summary>
		/// Description: Taggingtype
		/// FieldName: IDET
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Taggingtype")]
		public string M3_IDET => GetString("IDET");

		/// <summary>
		/// Description: Owner
		/// FieldName: OWNC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Owner")]
		public string M3_OWNC => GetString("OWNC");

		/// <summary>
		/// Description: Lotcost
		/// FieldName: LOTC
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lotcost")]
		public decimal? M3_LOTC => GetNullableDecimal("LOTC");

		/// <summary>
		/// Description: User-definedfield3-item
		/// FieldName: CFI3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield3-item")]
		public string M3_CFI3 => GetString("CFI3");

		/// <summary>
		/// Description: User-definedfield10-servagreement
		/// FieldName: CFJ0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield10-servagreement")]
		public string M3_CFJ0 => GetString("CFJ0");

		/// <summary>
		/// Description: User-definedfield2-item
		/// FieldName: CFI2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield2-item")]
		public decimal? M3_CFI2 => GetNullableDecimal("CFI2");

		/// <summary>
		/// Description: Lasttransactiondate
		/// FieldName: LATD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lasttransactiondate")]
		public DateTime? M3_LATD => GetNullableDateTime("LATD");

		/// <summary>
		/// Description: Manufacturingdate
		/// FieldName: MFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturingdate")]
		public DateTime? M3_MFDT => GetNullableDateTime("MFDT");

		/// <summary>
		/// Description: Receiptdate
		/// FieldName: REDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiptdate")]
		public DateTime? M3_REDA => GetNullableDateTime("REDA");

		/// <summary>
		/// Description: LI request rule
		/// FieldName: LIRR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("LI request rule")]
		public int? M3_LIRR => GetNullableInt("LIRR");

		/// <summary>
		/// Description: Harvested date
		/// FieldName: HVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harvested date")]
		public DateTime? M3_HVDT => GetNullableDateTime("HVDT");

		/// <summary>
		/// Description: Best before date
		/// FieldName: BBDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Best before date")]
		public DateTime? M3_BBDT => GetNullableDateTime("BBDT");

		/// <summary>
		/// Description: Harvested item
		/// FieldName: HVIT
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harvested item")]
		public string M3_HVIT => GetString("HVIT");

		/// <summary>
		/// Description: Harvested lot
		/// FieldName: HVLT
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harvested lot")]
		public string M3_HVLT => GetString("HVLT");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3_ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Potency
		/// FieldName: LPCY
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Potency")]
		public int? M3_LPCY => GetNullableInt("LPCY");

		/// <summary>
		/// Description: Normal potency
		/// FieldName: POCY
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal potency")]
		public int? M3_POCY => GetNullableInt("POCY");
	}
}
// EOF
