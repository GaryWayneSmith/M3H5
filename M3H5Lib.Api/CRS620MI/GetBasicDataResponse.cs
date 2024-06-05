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

namespace M3H5Lib.Api.CRS620MI
{
	public partial class GetBasicDataResponse : M3BaseRecord 
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
		/// Description: Suppliertype
		/// FieldName: SUTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliertype")]
		public int? M3_SUTY => GetNullableInt("SUTY");

		/// <summary>
		/// Description: Suppliername
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliername")]
		public string M3_SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Searchkey
		/// FieldName: ALSU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Searchkey")]
		public string M3_ALSU => GetString("ALSU");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Organizationnumber1
		/// FieldName: CORG
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organizationnumber1")]
		public string M3_CORG => GetString("CORG");

		/// <summary>
		/// Description: Organizationnumber2
		/// FieldName: COR2
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organizationnumber2")]
		public string M3_COR2 => GetString("COR2");

		/// <summary>
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3_LNCD => GetString("LNCD");

		/// <summary>
		/// Description: Telephonenumber1
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephonenumber1")]
		public string M3_PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Telephonenumber2
		/// FieldName: PHN2
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephonenumber2")]
		public string M3_PHN2 => GetString("PHN2");

		/// <summary>
		/// Description: Telexnumber
		/// FieldName: TLNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telexnumber")]
		public string M3_TLNO => GetString("TLNO");

		/// <summary>
		/// Description: Facsimiletransmissionnumber
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimiletransmissionnumber")]
		public string M3_TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Country
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3_CSCD => GetString("CSCD");

		/// <summary>
		/// Description: Dateformat
		/// FieldName: DTFM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dateformat")]
		public string M3_DTFM => GetString("DTFM");

		/// <summary>
		/// Description: Dateediting
		/// FieldName: EDIT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dateediting")]
		public string M3_EDIT => GetString("EDIT");

		/// <summary>
		/// Description: VATregistrationnumber
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VATregistrationnumber")]
		public string M3_VRNO => GetString("VRNO");

		/// <summary>
		/// Description: Suppliernumberwithingroup
		/// FieldName: SUCO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliernumberwithingroup")]
		public string M3_SUCO => GetString("SUCO");

		/// <summary>
		/// Description: Supplieralternativeidentity
		/// FieldName: SUAL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplieralternativeidentity")]
		public string M3_SUAL => GetString("SUAL");

		/// <summary>
		/// Description: Suppliercomutercommunicationaddress
		/// FieldName: SUCM
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliercomutercommunicationaddress")]
		public string M3_SUCM => GetString("SUCM");

		/// <summary>
		/// Description: Mediaprofile
		/// FieldName: MEPF
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mediaprofile")]
		public string M3_MEPF => GetString("MEPF");

		/// <summary>
		/// Description: Transmissionleadtime-supplier
		/// FieldName: PODA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transmissionleadtime-supplier")]
		public int? M3_PODA => GetNullableInt("PODA");

		/// <summary>
		/// Description: User-definedfield1-item
		/// FieldName: SFI1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield1-item")]
		public string M3_SFI1 => GetString("SFI1");

		/// <summary>
		/// Description: User-definedfield2-item
		/// FieldName: SFI2
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield2-item")]
		public int? M3_SFI2 => GetNullableInt("SFI2");

		/// <summary>
		/// Description: User-definedfield3-item
		/// FieldName: SFI3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield3-item")]
		public string M3_SFI3 => GetString("SFI3");

		/// <summary>
		/// Description: User-definedfield4-item
		/// FieldName: SFI4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield4-item")]
		public string M3_SFI4 => GetString("SFI4");

		/// <summary>
		/// Description: User-definedfield5-item
		/// FieldName: SFI5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield5-item")]
		public string M3_SFI5 => GetString("SFI5");

		/// <summary>
		/// Description: HarbourorAirport
		/// FieldName: HAFE
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("HarbourorAirport")]
		public string M3_HAFE => GetString("HAFE");

		/// <summary>
		/// Description: Textidentity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Textidentity")]
		public int? M3_TXID => GetNullableInt("TXID");

		/// <summary>
		/// Description: Area/State
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Area/State")]
		public string M3_ECAR => GetString("ECAR");

		/// <summary>
		/// Description: SCACcode
		/// FieldName: FWSC
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SCACcode")]
		public string M3_FWSC => GetString("FWSC");

		/// <summary>
		/// Description: Suppliergroup
		/// FieldName: SUCL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliergroup")]
		public string M3_SUCL => GetString("SUCL");

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
		/// Description: Deliveryterms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deliveryterms")]
		public string M3_TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Deliverymethod
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deliverymethod")]
		public string M3_MODL => GetString("MODL");

		/// <summary>
		/// Description: Freightterms
		/// FieldName: TEAF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freightterms")]
		public string M3_TEAF => GetString("TEAF");

		/// <summary>
		/// Description: Packagingterms
		/// FieldName: TEPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packagingterms")]
		public string M3_TEPA => GetString("TEPA");

		/// <summary>
		/// Description: Datetype
		/// FieldName: DT4T
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Datetype")]
		public int? M3_DT4T => GetNullableInt("DT4T");

		/// <summary>
		/// Description: Datecode
		/// FieldName: DTCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Datecode")]
		public int? M3_DTCD => GetNullableInt("DTCD");

		/// <summary>
		/// Description: VATcode
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VATcode")]
		public int? M3_VTCD => GetNullableInt("VTCD");

		/// <summary>
		/// Description: Taxapplicable
		/// FieldName: TXAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Taxapplicable")]
		public int? M3_TXAP => GetNullableInt("TXAP");

		/// <summary>
		/// Description: Taxcodecustomer/address
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Taxcodecustomer/address")]
		public string M3_TAXC => GetString("TAXC");

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
		/// Description: Paymentterms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Paymentterms")]
		public string M3_TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Paymentmethod-accountspayable
		/// FieldName: PYME
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Paymentmethod-accountspayable")]
		public string M3_PYME => GetString("PYME");

		/// <summary>
		/// Description: Attributepricingrule
		/// FieldName: ATPR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attributepricingrule")]
		public string M3_ATPR => GetString("ATPR");

		/// <summary>
		/// Description: User-definedaccountingcontrolobject
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedaccountingcontrolobject")]
		public string M3_ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Buyer
		/// FieldName: BUYE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Buyer")]
		public string M3_BUYE => GetString("BUYE");

		/// <summary>
		/// Description: Authorizeduser
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorizeduser")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: Agent
		/// FieldName: AGNT
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agent")]
		public string M3_AGNT => GetString("AGNT");

		/// <summary>
		/// Description: ABCclass-supplier
		/// FieldName: ABSK
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABCclass-supplier")]
		public string M3_ABSK => GetString("ABSK");

		/// <summary>
		/// Description: ABCmethod-supplier
		/// FieldName: ABSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABCmethod-supplier")]
		public int? M3_ABSM => GetNullableInt("ABSM");

		/// <summary>
		/// Description: PINcode
		/// FieldName: PWMT
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PINcode")]
		public string M3_PWMT => GetString("PWMT");

		/// <summary>
		/// Description: Discountcalculationmethod
		/// FieldName: DCSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discountcalculationmethod")]
		public int? M3_DCSM => GetNullableInt("DCSM");

		/// <summary>
		/// Description: Monitoringactivitylist
		/// FieldName: FUSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monitoringactivitylist")]
		public string M3_FUSC => GetString("FUSC");

		/// <summary>
		/// Description: Monitoringclass
		/// FieldName: SPFC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monitoringclass")]
		public string M3_SPFC => GetString("SPFC");

		/// <summary>
		/// Description: Groupofcompanies
		/// FieldName: COBI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Groupofcompanies")]
		public string M3_COBI => GetString("COBI");

		/// <summary>
		/// Description: Suppliercustomernumber
		/// FieldName: SCNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliercustomernumber")]
		public string M3_SCNO => GetString("SCNO");

		/// <summary>
		/// Description: Statisticalsupplier
		/// FieldName: SUGR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statisticalsupplier")]
		public string M3_SUGR => GetString("SUGR");

		/// <summary>
		/// Description: Shipmenttable
		/// FieldName: SHST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipmenttable")]
		public int? M3_SHST => GetNullableInt("SHST");

		/// <summary>
		/// Description: Pointoftimetable
		/// FieldName: POOT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pointoftimetable")]
		public string M3_POOT => GetString("POOT");

		/// <summary>
		/// Description: Ourcustomernumberatsupplier
		/// FieldName: OUCN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ourcustomernumberatsupplier")]
		public string M3_OUCN => GetString("OUCN");

		/// <summary>
		/// Description: TaxIDforsupplier
		/// FieldName: TINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TaxIDforsupplier")]
		public string M3_TINO => GetString("TINO");

		/// <summary>
		/// Description: Payee
		/// FieldName: PRSU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payee")]
		public string M3_PRSU => GetString("PRSU");

		/// <summary>
		/// Description: Servicecode
		/// FieldName: SERS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Servicecode")]
		public int? M3_SERS => GetNullableInt("SERS");

		/// <summary>
		/// Description: Self-billingpermitted
		/// FieldName: SBPE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Self-billingpermitted")]
		public int? M3_SBPE => GetNullableInt("SBPE");

		/// <summary>
		/// Description: Paymentpriority
		/// FieldName: PACD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Paymentpriority")]
		public string M3_PACD => GetString("PACD");

		/// <summary>
		/// Description: Tolerance-payment
		/// FieldName: PTDY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tolerance-payment")]
		public int? M3_PTDY => GetNullableInt("PTDY");

		/// <summary>
		/// Description: Supplierstatistics
		/// FieldName: SUST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplierstatistics")]
		public int? M3_SUST => GetNullableInt("SUST");

		/// <summary>
		/// Description: Tolerance-deliverydate
		/// FieldName: DTDY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tolerance-deliverydate")]
		public int? M3_DTDY => GetNullableInt("DTDY");

		/// <summary>
		/// Description: Lastinvoicedate
		/// FieldName: LIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lastinvoicedate")]
		public DateTime? M3_LIDT => GetNullableDateTime("LIDT");

		/// <summary>
		/// Description: Cashdiscountterm
		/// FieldName: TECD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cashdiscountterm")]
		public string M3_TECD => GetString("TECD");

		/// <summary>
		/// Description: Invoiceaccountingtemplate
		/// FieldName: REGR
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiceaccountingtemplate")]
		public int? M3_REGR => GetNullableInt("REGR");

		/// <summary>
		/// Description: Numberofyearsofstatistics
		/// FieldName: SUSY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numberofyearsofstatistics")]
		public int? M3_SUSY => GetNullableInt("SUSY");

		/// <summary>
		/// Description: Shipmentadvice
		/// FieldName: SHAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipmentadvice")]
		public int? M3_SHAC => GetNullableInt("SHAC");

		/// <summary>
		/// Description: Activitycode
		/// FieldName: AVCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Activitycode")]
		public string M3_AVCD => GetString("AVCD");

		/// <summary>
		/// Description: Taxwithholdingmethod
		/// FieldName: TAME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Taxwithholdingmethod")]
		public int? M3_TAME => GetNullableInt("TAME");

		/// <summary>
		/// Description: Tradecode
		/// FieldName: TDCD
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tradecode")]
		public string M3_TDCD => GetString("TDCD");

		/// <summary>
		/// Description: Automaticinvoiceapprovalcode
		/// FieldName: IAPT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automaticinvoiceapprovalcode")]
		public int? M3_IAPT => GetNullableInt("IAPT");

		/// <summary>
		/// Description: Invoiceapprovalcondition1
		/// FieldName: IAPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiceapprovalcondition1")]
		public int? M3_IAPC => GetNullableInt("IAPC");

		/// <summary>
		/// Description: Invoiceapprovalcondition2
		/// FieldName: IAPE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiceapprovalcondition2")]
		public int? M3_IAPE => GetNullableInt("IAPE");

		/// <summary>
		/// Description: Invoiceapprovalcondition3
		/// FieldName: IAPF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiceapprovalcondition3")]
		public int? M3_IAPF => GetNullableInt("IAPF");

		/// <summary>
		/// Description: User-definedfield1-item
		/// FieldName: CFI1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield1-item")]
		public string M3_CFI1 => GetString("CFI1");

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
		/// Description: User-definedfield4-item
		/// FieldName: CFI4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield4-item")]
		public string M3_CFI4 => GetString("CFI4");

		/// <summary>
		/// Description: User-definedfield5-item
		/// FieldName: CFI5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield5-item")]
		public string M3_CFI5 => GetString("CFI5");

		/// <summary>
		/// Description: Consolidation group
		/// FieldName: CGRP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidation group")]
		public string M3_CGRP => GetString("CGRP");

		/// <summary>
		/// Description: Rail station
		/// FieldName: RASN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rail station")]
		public string M3_RASN => GetString("RASN");

		/// <summary>
		/// Description: Level of purchase planning
		/// FieldName: PPLV
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Level of purchase planning")]
		public int? M3_PPLV => GetNullableInt("PPLV");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXI2
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXI2 => GetNullableDecimal("TXI2");

		/// <summary>
		/// Description: Claim invoice permitted
		/// FieldName: CINP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim invoice permitted")]
		public int? M3_CINP => GetNullableInt("CINP");

		/// <summary>
		/// Description: Rebate claim invoice setting ID
		/// FieldName: SCIS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rebate claim invoice setting ID")]
		public string M3_SCIS => GetString("SCIS");
	}
}
// EOF
