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

namespace M3H5Lib.Api.PPS040MI
{
	public partial class GetItemSupplierResponse : M3BaseRecord 
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
		/// Description: Serviceprocess
		/// FieldName: PRCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serviceprocess")]
		public string M3_PRCS => GetString("PRCS");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3_SUFI => GetString("SUFI");

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
		/// Description: Recordtype
		/// FieldName: RTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recordtype")]
		public string M3_RTYP => GetString("RTYP");

		/// <summary>
		/// Description: Supplieritemnumber
		/// FieldName: SITE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplieritemnumber")]
		public string M3_SITE => GetString("SITE");

		/// <summary>
		/// Description: Supplieritemname
		/// FieldName: SITD
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplieritemname")]
		public string M3_SITD => GetString("SITD");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Supplieritemdescription
		/// FieldName: SITT
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplieritemdescription")]
		public string M3_SITT => GetString("SITT");

		/// <summary>
		/// Description: Description2
		/// FieldName: FUDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description2")]
		public string M3_FUDS => GetString("FUDS");

		/// <summary>
		/// Description: Status-item/supplier
		/// FieldName: ISRS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status-item/supplier")]
		public string M3_ISRS => GetString("ISRS");

		/// <summary>
		/// Description: Standardofapproval
		/// FieldName: STAP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standardofapproval")]
		public string M3_STAP => GetString("STAP");

		/// <summary>
		/// Description: Dateapproved
		/// FieldName: APDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dateapproved")]
		public DateTime? M3_APDT => GetNullableDateTime("APDT");

		/// <summary>
		/// Description: Leadtimeforreplacementdelivery
		/// FieldName: LEA5
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Leadtimeforreplacementdelivery")]
		public int? M3_LEA5 => GetNullableInt("LEA5");

		/// <summary>
		/// Description: Goodsreceivingmethod
		/// FieldName: GRMT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Goodsreceivingmethod")]
		public string M3_GRMT => GetString("GRMT");

		/// <summary>
		/// Description: Ordermultiple
		/// FieldName: UNMU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordermultiple")]
		public decimal? M3_UNMU => GetNullableDecimal("UNMU");

		/// <summary>
		/// Description: Ordertype
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordertype")]
		public string M3_ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Reference
		/// FieldName: RFID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference")]
		public string M3_RFID => GetString("RFID");

		/// <summary>
		/// Description: PurchaseorderU/M
		/// FieldName: PUUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PurchaseorderU/M")]
		public string M3_PUUN => GetString("PUUN");

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
		/// Description: PurchasepriceU/M
		/// FieldName: PPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PurchasepriceU/M")]
		public string M3_PPUN => GetString("PPUN");

		/// <summary>
		/// Description: Singlemanufacturer
		/// FieldName: SMFI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Singlemanufacturer")]
		public int? M3_SMFI => GetNullableInt("SMFI");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: Minimumorderquantity
		/// FieldName: LOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimumorderquantity")]
		public decimal? M3_LOQT => GetNullableDecimal("LOQT");

		/// <summary>
		/// Description: Externalsafetystock
		/// FieldName: SMSQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Externalsafetystock")]
		public decimal? M3_SMSQ => GetNullableDecimal("SMSQ");

		/// <summary>
		/// Description: Rawmaterialshare
		/// FieldName: MPSH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rawmaterialshare")]
		public int? M3_MPSH => GetNullableInt("MPSH");

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
		/// Description: Communicationcode
		/// FieldName: CMCO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Communicationcode")]
		public string M3_CMCO => GetString("CMCO");

		/// <summary>
		/// Description: Qualityclass
		/// FieldName: QUCL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Qualityclass")]
		public string M3_QUCL => GetString("QUCL");

		/// <summary>
		/// Description: Validto
		/// FieldName: QCUD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validto")]
		public DateTime? M3_QCUD => GetNullableDateTime("QCUD");

		/// <summary>
		/// Description: Packaging
		/// FieldName: PACT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging")]
		public string M3_PACT => GetString("PACT");

		/// <summary>
		/// Description: Tolerancelimit
		/// FieldName: MCPR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tolerancelimit")]
		public int? M3_MCPR => GetNullableInt("MCPR");

		/// <summary>
		/// Description: Invoicedprice-POpriceunit/Currency
		/// FieldName: IVPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicedprice-POpriceunit/Currency")]
		public decimal? M3_IVPR => GetNullableDecimal("IVPR");

		/// <summary>
		/// Description: Invoicedate
		/// FieldName: IVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicedate")]
		public DateTime? M3_IVDT => GetNullableDateTime("IVDT");

		/// <summary>
		/// Description: Currentfullcostpurchasecosting
		/// FieldName: PCCP
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currentfullcostpurchasecosting")]
		public decimal? M3_PCCP => GetNullableDecimal("PCCP");

		/// <summary>
		/// Description: Lastcostingdate-fullcost
		/// FieldName: LPCD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lastcostingdate-fullcost")]
		public DateTime? M3_LPCD => GetNullableDateTime("LPCD");

		/// <summary>
		/// Description: Validfrom
		/// FieldName: FVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validfrom")]
		public DateTime? M3_FVDT => GetNullableDateTime("FVDT");

		/// <summary>
		/// Description: Validto
		/// FieldName: UVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validto")]
		public DateTime? M3_UVDT => GetNullableDateTime("UVDT");

		/// <summary>
		/// Description: Purchasepricequantity
		/// FieldName: PUCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchasepricequantity")]
		public int? M3_PUCD => GetNullableInt("PUCD");

		/// <summary>
		/// Description: Purchaseprice
		/// FieldName: PUPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchaseprice")]
		public decimal? M3_PUPR => GetNullableDecimal("PUPR");

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
		/// Description: Setupprice
		/// FieldName: SUPR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setupprice")]
		public decimal? M3_SUPR => GetNullableDecimal("SUPR");

		/// <summary>
		/// Description: Exchangeratetype
		/// FieldName: CRTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchangeratetype")]
		public int? M3_CRTP => GetNullableInt("CRTP");

		/// <summary>
		/// Description: Validfrom
		/// FieldName: FVD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validfrom")]
		public DateTime? M3_FVD1 => GetNullableDateTime("FVD1");

		/// <summary>
		/// Description: Validto
		/// FieldName: UVD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validto")]
		public DateTime? M3_UVD1 => GetNullableDateTime("UVD1");

		/// <summary>
		/// Description: Purchaseprice
		/// FieldName: PUP1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchaseprice")]
		public decimal? M3_PUP1 => GetNullableDecimal("PUP1");

		/// <summary>
		/// Description: Setupprice
		/// FieldName: SUP1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setupprice")]
		public decimal? M3_SUP1 => GetNullableDecimal("SUP1");
	}
}
// EOF
