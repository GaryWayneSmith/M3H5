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

namespace M3H5Lib.Api.COS403MI
{
	public partial class GetAgrSiteResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3_CUNO => GetString("CUNO");

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
		/// Description: Next invoice date
		/// FieldName: NODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next invoice date")]
		public DateTime? M3_NODT => GetNullableDateTime("NODT");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: IVNO
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public int? M3_IVNO => GetNullableInt("IVNO");

		/// <summary>
		/// Description: First invoice date
		/// FieldName: IFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("First invoice date")]
		public DateTime? M3_IFDT => GetNullableDateTime("IFDT");

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
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3_PYNO => GetString("PYNO");

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
		/// Description: Invoice prefix
		/// FieldName: INPX
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice prefix")]
		public string M3_INPX => GetString("INPX");

		/// <summary>
		/// Description: Extended invoice number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended invoice number")]
		public string M3_EXIN => GetString("EXIN");

		/// <summary>
		/// Description: Service manager
		/// FieldName: SRES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service manager")]
		public string M3_SRES => GetString("SRES");

		/// <summary>
		/// Description: Technician
		/// FieldName: TEC1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Technician")]
		public string M3_TEC1 => GetString("TEC1");

		/// <summary>
		/// Description: Technician
		/// FieldName: TEC2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Technician")]
		public string M3_TEC2 => GetString("TEC2");

		/// <summary>
		/// Description: Number of kilometer
		/// FieldName: DIST
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of kilometer")]
		public int? M3_DIST => GetNullableInt("DIST");

		/// <summary>
		/// Description: Service zone
		/// FieldName: LZON
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service zone")]
		public int? M3_LZON => GetNullableInt("LZON");

		/// <summary>
		/// Description: Planned travel time
		/// FieldName: TRTI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned travel time")]
		public int? M3_TRTI => GetNullableInt("TRTI");

		/// <summary>
		/// Description: Travel type
		/// FieldName: TVCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Travel type")]
		public string M3_TVCD => GetString("TVCD");

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
		/// Description: Work schedule
		/// FieldName: WOSC
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work schedule")]
		public int? M3_WOSC => GetNullableInt("WOSC");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Text
		/// FieldName: PRTX
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_PRTX => GetString("PRTX");

		/// <summary>
		/// Description: Retrieve purchase order line text
		/// FieldName: POTX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Retrieve purchase order line text")]
		public int? M3_POTX => GetNullableInt("POTX");

		/// <summary>
		/// Description: Downtime
		/// FieldName: DOWT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Downtime")]
		public int? M3_DOWT => GetNullableInt("DOWT");

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
	}
}
// EOF
