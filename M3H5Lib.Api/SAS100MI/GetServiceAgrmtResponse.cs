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

namespace M3H5Lib.Api.SAS100MI
{
	public partial class GetServiceAgrmtResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Agreement number
		/// FieldName: CTNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3_CTNO => GetString("CTNO");

		/// <summary>
		/// Description: Customer site
		/// FieldName: CUPL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer site")]
		public string M3_CUPL => GetString("CUPL");

		/// <summary>
		/// Description: Agreement type
		/// FieldName: AGTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement type")]
		public string M3_AGTP => GetString("AGTP");

		/// <summary>
		/// Description: Validity type
		/// FieldName: VLCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validity type")]
		public string M3_VLCD => GetString("VLCD");

		/// <summary>
		/// Description: Customers order number
		/// FieldName: CUOR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customers order number")]
		public string M3_CUOR => GetString("CUOR");

		/// <summary>
		/// Description: Valid from
		/// FieldName: VADF
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3_VADF => GetNullableDateTime("VADF");

		/// <summary>
		/// Description: Start date - invoicing range
		/// FieldName: IIDF
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date - invoicing range")]
		public DateTime? M3_IIDF => GetNullableDateTime("IIDF");

		/// <summary>
		/// Description: Valid to
		/// FieldName: VADT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3_VADT => GetNullableDateTime("VADT");

		/// <summary>
		/// Description: End date - invoicing range
		/// FieldName: IIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End date - invoicing range")]
		public DateTime? M3_IIDT => GetNullableDateTime("IIDT");

		/// <summary>
		/// Description: Next order date
		/// FieldName: NODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next order date")]
		public DateTime? M3_NODT => GetNullableDateTime("NODT");

		/// <summary>
		/// Description: Invoicing interval - years
		/// FieldName: IIYR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing interval - years")]
		public int? M3_IIYR => GetNullableInt("IIYR");

		/// <summary>
		/// Description: Invoicing interval - months
		/// FieldName: IIMO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing interval - months")]
		public int? M3_IIMO => GetNullableInt("IIMO");

		/// <summary>
		/// Description: Invoicing interval - days
		/// FieldName: IIDA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing interval - days")]
		public int? M3_IIDA => GetNullableInt("IIDA");

		/// <summary>
		/// Description: Invoicing method
		/// FieldName: INVM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing method")]
		public string M3_INVM => GetString("INVM");

		/// <summary>
		/// Description: Invoice block
		/// FieldName: ILCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice block")]
		public int? M3_ILCD => GetNullableInt("ILCD");

		/// <summary>
		/// Description: Service stop
		/// FieldName: LSCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service stop")]
		public int? M3_LSCD => GetNullableInt("LSCD");

		/// <summary>
		/// Description: Payer control
		/// FieldName: DBCO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer control")]
		public string M3_DBCO => GetString("DBCO");

		/// <summary>
		/// Description: Aggregated meter invoicing
		/// FieldName: MAIV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aggregated meter invoicing")]
		public int? M3_MAIV => GetNullableInt("MAIV");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3_TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Summary invoice
		/// FieldName: AICD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Summary invoice")]
		public int? M3_AICD => GetNullableInt("AICD");

		/// <summary>
		/// Description: Curve
		/// FieldName: AMTN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Curve")]
		public int? M3_AMTN => GetNullableInt("AMTN");

		/// <summary>
		/// Description: Number of periods
		/// FieldName: NPAM
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of periods")]
		public int? M3_NPAM => GetNullableInt("NPAM");

		/// <summary>
		/// Description: Check agreement on higher level
		/// FieldName: ADDI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check agreement on higher level")]
		public int? M3_ADDI => GetNullableInt("ADDI");

		/// <summary>
		/// Description: Our reference
		/// FieldName: OREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our reference")]
		public string M3_OREF => GetString("OREF");

		/// <summary>
		/// Description: Your reference 1
		/// FieldName: YREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference 1")]
		public string M3_YREF => GetString("YREF");

		/// <summary>
		/// Description: Agreement information
		/// FieldName: AINF
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement information")]
		public string M3_AINF => GetString("AINF");

		/// <summary>
		/// Description: Agreed discount
		/// FieldName: AGPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed discount")]
		public int? M3_AGPC => GetNullableInt("AGPC");

		/// <summary>
		/// Description: Response time
		/// FieldName: APTM
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Response time")]
		public int? M3_APTM => GetNullableInt("APTM");

		/// <summary>
		/// Description: Price index
		/// FieldName: IXCD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price index")]
		public string M3_IXCD => GetString("IXCD");

		/// <summary>
		/// Description: Price index value
		/// FieldName: IXVA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price index value")]
		public decimal? M3_IXVA => GetNullableDecimal("IXVA");

		/// <summary>
		/// Description: Period of notice years
		/// FieldName: NTYR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period of notice years")]
		public int? M3_NTYR => GetNullableInt("NTYR");

		/// <summary>
		/// Description: Period of notice months
		/// FieldName: NTMO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period of notice months")]
		public int? M3_NTMO => GetNullableInt("NTMO");

		/// <summary>
		/// Description: Period of notice days
		/// FieldName: NTDA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period of notice days")]
		public int? M3_NTDA => GetNullableInt("NTDA");

		/// <summary>
		/// Description: Agreement update/renewal
		/// FieldName: RNCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement update/renewal")]
		public int? M3_RNCD => GetNullableInt("RNCD");

		/// <summary>
		/// Description: Audit
		/// FieldName: RADJ
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Audit")]
		public string M3_RADJ => GetString("RADJ");

		/// <summary>
		/// Description: Fixed price
		/// FieldName: LOCP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed price")]
		public int? M3_LOCP => GetNullableInt("LOCP");

		/// <summary>
		/// Description: Fixed price to date
		/// FieldName: LODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed price to date")]
		public DateTime? M3_LODT => GetNullableDateTime("LODT");

		/// <summary>
		/// Description: Follow-up date
		/// FieldName: FUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-up date")]
		public DateTime? M3_FUDT => GetNullableDateTime("FUDT");

		/// <summary>
		/// Description: Follow-up code
		/// FieldName: FUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-up code")]
		public string M3_FUCD => GetString("FUCD");

		/// <summary>
		/// Description: Quotation number
		/// FieldName: OFNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quotation number")]
		public string M3_OFNO => GetString("OFNO");

		/// <summary>
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3_RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Project number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number")]
		public string M3_PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3_RORN => GetString("RORN");

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3_ELNO => GetString("ELNO");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3_RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3_RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3_ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Accounting dimension 1
		/// FieldName: AIT1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 1")]
		public string M3_AIT1 => GetString("AIT1");

		/// <summary>
		/// Description: Accounting dimension 2
		/// FieldName: AIT2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 2")]
		public string M3_AIT2 => GetString("AIT2");

		/// <summary>
		/// Description: Accounting dimension 3
		/// FieldName: AIT3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 3")]
		public string M3_AIT3 => GetString("AIT3");

		/// <summary>
		/// Description: Accounting dimension 4
		/// FieldName: AIT4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 4")]
		public string M3_AIT4 => GetString("AIT4");

		/// <summary>
		/// Description: Accounting dimension 5
		/// FieldName: AIT5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 5")]
		public string M3_AIT5 => GetString("AIT5");

		/// <summary>
		/// Description: Accounting dimension 6
		/// FieldName: AIT6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 6")]
		public string M3_AIT6 => GetString("AIT6");

		/// <summary>
		/// Description: Accounting dimension 7
		/// FieldName: AIT7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 7")]
		public string M3_AIT7 => GetString("AIT7");

		/// <summary>
		/// Description: Statistics identity 1 customer
		/// FieldName: FRE1
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 1 customer")]
		public string M3_FRE1 => GetString("FRE1");

		/// <summary>
		/// Description: User-defined field 1 - serv agreement
		/// FieldName: CFJ1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - serv agreement")]
		public string M3_CFJ1 => GetString("CFJ1");

		/// <summary>
		/// Description: User-defined field 2 - serv agreement
		/// FieldName: CFJ2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - serv agreement")]
		public decimal? M3_CFJ2 => GetNullableDecimal("CFJ2");

		/// <summary>
		/// Description: User-defined field 3 - serv agreement
		/// FieldName: CFJ3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - serv agreement")]
		public string M3_CFJ3 => GetString("CFJ3");

		/// <summary>
		/// Description: User-defined field 4 - serv agreement
		/// FieldName: CFJ4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - serv agreement")]
		public string M3_CFJ4 => GetString("CFJ4");

		/// <summary>
		/// Description: User-defined field 5 - serv agreement
		/// FieldName: CFJ5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - serv agreement")]
		public string M3_CFJ5 => GetString("CFJ5");

		/// <summary>
		/// Description: User-defined field 6 - serv agreement
		/// FieldName: CFJ6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 6 - serv agreement")]
		public string M3_CFJ6 => GetString("CFJ6");

		/// <summary>
		/// Description: User-defined field 7 - serv agreement
		/// FieldName: CFJ7
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 7 - serv agreement")]
		public decimal? M3_CFJ7 => GetNullableDecimal("CFJ7");

		/// <summary>
		/// Description: User-defined field 8 - serv agreement
		/// FieldName: CFJ8
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 8 - serv agreement")]
		public string M3_CFJ8 => GetString("CFJ8");

		/// <summary>
		/// Description: User-defined field 9 - serv agreement
		/// FieldName: CFJ9
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 9 - serv agreement")]
		public string M3_CFJ9 => GetString("CFJ9");

		/// <summary>
		/// Description: User-defined field 10 - serv agreement
		/// FieldName: CFJ0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 10 - serv agreement")]
		public string M3_CFJ0 => GetString("CFJ0");

		/// <summary>
		/// Description: Language code order head
		/// FieldName: LHCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language code order head")]
		public string M3_LHCD => GetString("LHCD");

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
		/// Description: Exchange rate type
		/// FieldName: CRTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public int? M3_CRTP => GetNullableInt("CRTP");

		/// <summary>
		/// Description: Price list SO
		/// FieldName: PRS1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list SO")]
		public string M3_PRS1 => GetString("PRS1");

		/// <summary>
		/// Description: Priority
		/// FieldName: OPRI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3_OPRI => GetNullableInt("OPRI");

		/// <summary>
		/// Description: Price list SO
		/// FieldName: PR01
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list SO")]
		public string M3_PR01 => GetString("PR01");

		/// <summary>
		/// Description: Price list 2 SO
		/// FieldName: PRS2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 2 SO")]
		public string M3_PRS2 => GetString("PRS2");

		/// <summary>
		/// Description: Price list 3 SO
		/// FieldName: PRS3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 3 SO")]
		public string M3_PRS3 => GetString("PRS3");

		/// <summary>
		/// Description: Price list 4 SO
		/// FieldName: PRS4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 4 SO")]
		public string M3_PRS4 => GetString("PRS4");

		/// <summary>
		/// Description: Price list 5 SO
		/// FieldName: PRS5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 5 SO")]
		public string M3_PRS5 => GetString("PRS5");

		/// <summary>
		/// Description: District
		/// FieldName: SDST
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("District")]
		public string M3_SDST => GetString("SDST");

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Salesperson
		/// FieldName: SMCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Salesperson")]
		public string M3_SMCD => GetString("SMCD");

		/// <summary>
		/// Description: Price list service
		/// FieldName: PLSO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list service")]
		public string M3_PLSO => GetString("PLSO");

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
		/// Description: Customer group
		/// FieldName: CUCL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer group")]
		public string M3_CUCL => GetString("CUCL");

		/// <summary>
		/// Description: Service charge
		/// FieldName: EXCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service charge")]
		public string M3_EXCD => GetString("EXCD");
	}
}
// EOF
