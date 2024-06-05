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

namespace M3H5Lib.Api.OIS017MI
{
	public partial class GetPriceListResponse : M3BaseRecord 
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
		/// Description: Pricelist
		/// FieldName: PRRF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pricelist")]
		public string M3PRRF => GetString("PRRF");

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
		/// Description: Customernumber
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customernumber")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Validfrom
		/// FieldName: FVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validfrom")]
		public DateTime? M3FVDT => GetNullableDateTime("FVDT");

		/// <summary>
		/// Description: Validto
		/// FieldName: LVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validto")]
		public DateTime? M3LVDT => GetNullableDateTime("LVDT");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Salescampaign
		/// FieldName: CMNO
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Salescampaign")]
		public string M3CMNO => GetString("CMNO");

		/// <summary>
		/// Description: Objectaccessgroup
		/// FieldName: ACGR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Objectaccessgroup")]
		public string M3ACGR => GetString("ACGR");

		/// <summary>
		/// Description: Costingmodel-salesprice
		/// FieldName: SCMO
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costingmodel-salesprice")]
		public string M3SCMO => GetString("SCMO");

		/// <summary>
		/// Description: Manualupdate-salesprices
		/// FieldName: SCMU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manualupdate-salesprices")]
		public int? M3SCMU => GetNullableInt("SCMU");

		/// <summary>
		/// Description: Manualupdaterule
		/// FieldName: SCSC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manualupdaterule")]
		public int? M3SCSC => GetNullableInt("SCSC");

		/// <summary>
		/// Description: Netpriceused
		/// FieldName: NTCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Netpriceused")]
		public int? M3NTCD => GetNullableInt("NTCD");

		/// <summary>
		/// Description: Bonusgenerating
		/// FieldName: BNCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonusgenerating")]
		public int? M3BNCD => GetNullableInt("BNCD");

		/// <summary>
		/// Description: Rounding-offcategory
		/// FieldName: ROPP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rounding-offcategory")]
		public int? M3ROPP => GetNullableInt("ROPP");

		/// <summary>
		/// Description: Commissiongenerating
		/// FieldName: PRAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commissiongenerating")]
		public int? M3PRAC => GetNullableInt("PRAC");

		/// <summary>
		/// Description: Field
		/// FieldName: OBJ1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OBJ1 => GetString("OBJ1");

		/// <summary>
		/// Description: Field
		/// FieldName: OBJ2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OBJ2 => GetString("OBJ2");

		/// <summary>
		/// Description: Field
		/// FieldName: OBJ3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OBJ3 => GetString("OBJ3");

		/// <summary>
		/// Description: Fromitemnumber
		/// FieldName: FITN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fromitemnumber")]
		public string M3FITN => GetString("FITN");

		/// <summary>
		/// Description: Toitemnumber
		/// FieldName: TITN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Toitemnumber")]
		public string M3TITN => GetString("TITN");

		/// <summary>
		/// Description: Fromitemgroup
		/// FieldName: FITG
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fromitemgroup")]
		public string M3FITG => GetString("FITG");

		/// <summary>
		/// Description: Toitemgroup
		/// FieldName: TITG
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Toitemgroup")]
		public string M3TITG => GetString("TITG");

		/// <summary>
		/// Description: Fromproductgroup
		/// FieldName: FITC
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fromproductgroup")]
		public string M3FITC => GetString("FITC");

		/// <summary>
		/// Description: Toproductgroup
		/// FieldName: TITC
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Toproductgroup")]
		public string M3TITC => GetString("TITC");

		/// <summary>
		/// Description: Fromitemtype
		/// FieldName: FITT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fromitemtype")]
		public string M3FITT => GetString("FITT");

		/// <summary>
		/// Description: Toitemtype
		/// FieldName: TITT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Toitemtype")]
		public string M3TITT => GetString("TITT");

		/// <summary>
		/// Description: Fromitemresponsible
		/// FieldName: FRSP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fromitemresponsible")]
		public string M3FRSP => GetString("FRSP");

		/// <summary>
		/// Description: Toitemresponsible
		/// FieldName: TRSP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Toitemresponsible")]
		public string M3TRSP => GetString("TRSP");

		/// <summary>
		/// Description: Fromstatus
		/// FieldName: SLFR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fromstatus")]
		public string M3SLFR => GetString("SLFR");

		/// <summary>
		/// Description: Tostatus
		/// FieldName: SLTO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tostatus")]
		public string M3SLTO => GetString("SLTO");

		/// <summary>
		/// Description: Frommake/buycode
		/// FieldName: FMAB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frommake/buycode")]
		public int? M3FMAB => GetNullableInt("FMAB");

		/// <summary>
		/// Description: Tomake/buycode
		/// FieldName: TMAB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tomake/buycode")]
		public int? M3TMAB => GetNullableInt("TMAB");

		/// <summary>
		/// Description: Fromconfigurationcode
		/// FieldName: FCHC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fromconfigurationcode")]
		public int? M3FCHC => GetNullableInt("FCHC");

		/// <summary>
		/// Description: Toconfigurationcode
		/// FieldName: TCHC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Toconfigurationcode")]
		public int? M3TCHC => GetNullableInt("TCHC");

		/// <summary>
		/// Description: Frommainsupplier
		/// FieldName: FSUN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frommainsupplier")]
		public string M3FSUN => GetString("FSUN");

		/// <summary>
		/// Description: Tomainsupplier
		/// FieldName: TSUN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tomainsupplier")]
		public string M3TSUN => GetString("TSUN");

		/// <summary>
		/// Description: Fromcustomernumber
		/// FieldName: FCUN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fromcustomernumber")]
		public string M3FCUN => GetString("FCUN");

		/// <summary>
		/// Description: Tocustomernumber
		/// FieldName: TCUN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tocustomernumber")]
		public string M3TCUN => GetString("TCUN");

		/// <summary>
		/// Description: Frombonusgroup
		/// FieldName: FBGR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frombonusgroup")]
		public string M3FBGR => GetString("FBGR");

		/// <summary>
		/// Description: Tobonusgroup
		/// FieldName: TBGR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tobonusgroup")]
		public string M3TBGR => GetString("TBGR");

		/// <summary>
		/// Description: Fromcommissiongroup
		/// FieldName: FPRC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fromcommissiongroup")]
		public string M3FPRC => GetString("FPRC");

		/// <summary>
		/// Description: Tocommissiongroup
		/// FieldName: TPRC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tocommissiongroup")]
		public string M3TPRC => GetString("TPRC");

		/// <summary>
		/// Description: Fromassortment
		/// FieldName: FASS
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fromassortment")]
		public string M3FASS => GetString("FASS");

		/// <summary>
		/// Description: Toassortment
		/// FieldName: TASS
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Toassortment")]
		public string M3TASS => GetString("TASS");

		/// <summary>
		/// Description: Calculationbase
		/// FieldName: CABA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculationbase")]
		public int? M3CABA => GetNullableInt("CABA");

		/// <summary>
		/// Description: Automaticsalespricecalculation
		/// FieldName: SCAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automaticsalespricecalculation")]
		public int? M3SCAC => GetNullableInt("SCAC");

		/// <summary>
		/// Description: Costingbaseroundedoff-salesprice
		/// FieldName: SCBR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costingbaseroundedoff-salesprice")]
		public int? M3SCBR => GetNullableInt("SCBR");

		/// <summary>
		/// Description: Exchangeratetype
		/// FieldName: CRTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchangeratetype")]
		public int? M3CRTP => GetNullableInt("CRTP");

		/// <summary>
		/// Description: Costingmodel-purchasing
		/// FieldName: WSCA
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costingmodel-purchasing")]
		public string M3WSCA => GetString("WSCA");

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
		/// Description: Basicpricelist
		/// FieldName: BAPL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basicpricelist")]
		public string M3BAPL => GetString("BAPL");

		/// <summary>
		/// Description: Costingtype
		/// FieldName: PCTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costingtype")]
		public string M3PCTP => GetString("PCTP");

		/// <summary>
		/// Description: Field
		/// FieldName: 1OBJ
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M31OBJ => GetString("1OBJ");

		/// <summary>
		/// Description: Field
		/// FieldName: 2OBJ
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M32OBJ => GetString("2OBJ");

		/// <summary>
		/// Description: Field
		/// FieldName: 3OBJ
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M33OBJ => GetString("3OBJ");
	}
}
// EOF
