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

namespace M3H5Lib.Api.SOS400MI
{
	public partial class LstMtrTransHistResponse : M3BaseRecord 
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
		/// Description: Individual item number
		/// FieldName: INNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item number")]
		public string M3INNO => GetString("INNO");

		/// <summary>
		/// Description: Meter event
		/// FieldName: MEEV
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter event")]
		public string M3MEEV => GetString("MEEV");

		/// <summary>
		/// Description: Meter entry source
		/// FieldName: MEEN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter entry source")]
		public string M3MEEN => GetString("MEEN");

		/// <summary>
		/// Description: Customer order number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order number")]
		public string M3ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Service order job number
		/// FieldName: JOBN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service order job number")]
		public int? M3JOBN => GetNullableInt("JOBN");

		/// <summary>
		/// Description: Assignment suffix
		/// FieldName: JBSX
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assignment suffix")]
		public int? M3JBSX => GetNullableInt("JBSX");

		/// <summary>
		/// Description: Order line
		/// FieldName: RIDL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line")]
		public int? M3RIDL => GetNullableInt("RIDL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RIDX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RIDX => GetNullableInt("RIDX");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: CTNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3CTNO => GetString("CTNO");

		/// <summary>
		/// Description: Customer site
		/// FieldName: CUPL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer site")]
		public string M3CUPL => GetString("CUPL");

		/// <summary>
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3ADID => GetString("ADID");

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: POSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3POSX => GetNullableInt("POSX");

		/// <summary>
		/// Description: Owner
		/// FieldName: CUOW
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Owner")]
		public string M3CUOW => GetString("CUOW");

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
		/// Description: Invoice number
		/// FieldName: IVNO
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public int? M3IVNO => GetNullableInt("IVNO");

		/// <summary>
		/// Description: Invoice date
		/// FieldName: IVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3IVDT => GetNullableDateTime("IVDT");

		/// <summary>
		/// Description: Technician
		/// FieldName: TECH
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Technician")]
		public string M3TECH => GetString("TECH");

		/// <summary>
		/// Description: Service manager
		/// FieldName: SRES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service manager")]
		public string M3SRES => GetString("SRES");

		/// <summary>
		/// Description: Contract item
		/// FieldName: AGRS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Contract item")]
		public string M3AGRS => GetString("AGRS");

		/// <summary>
		/// Description: Price schedule type
		/// FieldName: PSCT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price schedule type")]
		public int? M3PSCT => GetNullableInt("PSCT");

		/// <summary>
		/// Description: Value - invoice meter 1
		/// FieldName: IMV1
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value - invoice meter 1")]
		public decimal? M3IMV1 => GetNullableDecimal("IMV1");

		/// <summary>
		/// Description: Value - invoice meter 2
		/// FieldName: IMV2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value - invoice meter 2")]
		public decimal? M3IMV2 => GetNullableDecimal("IMV2");

		/// <summary>
		/// Description: Value - invoice meter 3
		/// FieldName: IMV3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value - invoice meter 3")]
		public decimal? M3IMV3 => GetNullableDecimal("IMV3");

		/// <summary>
		/// Description: Value - invoice meter 4
		/// FieldName: IMV4
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value - invoice meter 4")]
		public decimal? M3IMV4 => GetNullableDecimal("IMV4");

		/// <summary>
		/// Description: Value - invoice meter 5
		/// FieldName: IMV5
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value - invoice meter 5")]
		public decimal? M3IMV5 => GetNullableDecimal("IMV5");

		/// <summary>
		/// Description: Value - invoice meter 6
		/// FieldName: IMV6
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value - invoice meter 6")]
		public decimal? M3IMV6 => GetNullableDecimal("IMV6");

		/// <summary>
		/// Description: Value - total meter
		/// FieldName: TMVA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value - total meter")]
		public decimal? M3TMVA => GetNullableDecimal("TMVA");

		/// <summary>
		/// Description: Reading value - act mtr 1
		/// FieldName: AMV1
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reading value - act mtr 1")]
		public decimal? M3AMV1 => GetNullableDecimal("AMV1");

		/// <summary>
		/// Description: Reading value - act mtr 2
		/// FieldName: AMV2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reading value - act mtr 2")]
		public decimal? M3AMV2 => GetNullableDecimal("AMV2");

		/// <summary>
		/// Description: Reading value - act mtr 3
		/// FieldName: AMV3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reading value - act mtr 3")]
		public decimal? M3AMV3 => GetNullableDecimal("AMV3");

		/// <summary>
		/// Description: Reading value - act mtr 4
		/// FieldName: AMV4
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reading value - act mtr 4")]
		public decimal? M3AMV4 => GetNullableDecimal("AMV4");

		/// <summary>
		/// Description: Reading value - act mtr 5
		/// FieldName: AMV5
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reading value - act mtr 5")]
		public decimal? M3AMV5 => GetNullableDecimal("AMV5");

		/// <summary>
		/// Description: Reading value - act mtr 6
		/// FieldName: AMV6
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reading value - act mtr 6")]
		public decimal? M3AMV6 => GetNullableDecimal("AMV6");

		/// <summary>
		/// Description: Event date
		/// FieldName: EVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event date")]
		public DateTime? M3EVDT => GetNullableDateTime("EVDT");

		/// <summary>
		/// Description: Event time
		/// FieldName: EVTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event time")]
		public int? M3EVTM => GetNullableInt("EVTM");

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
		/// Description: Reporting round
		/// FieldName: RNMB
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting round")]
		public long? M3RNMB => GetNullableLong("RNMB");

		/// <summary>
		/// Description: Reporting line
		/// FieldName: RLNB
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting line")]
		public int? M3RLNB => GetNullableInt("RLNB");

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
		/// Description: Agreement origin
		/// FieldName: AGRO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement origin")]
		public int? M3AGRO => GetNullableInt("AGRO");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Free units - act mtr 1
		/// FieldName: AMF1
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free units - act mtr 1")]
		public decimal? M3AMF1 => GetNullableDecimal("AMF1");

		/// <summary>
		/// Description: Free units - act mtr 2
		/// FieldName: AMF2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free units - act mtr 2")]
		public decimal? M3AMF2 => GetNullableDecimal("AMF2");

		/// <summary>
		/// Description: Free units - act mtr 3
		/// FieldName: AMF3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free units - act mtr 3")]
		public decimal? M3AMF3 => GetNullableDecimal("AMF3");

		/// <summary>
		/// Description: Free units - act mtr 4
		/// FieldName: AMF4
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free units - act mtr 4")]
		public decimal? M3AMF4 => GetNullableDecimal("AMF4");

		/// <summary>
		/// Description: Free units - act mtr 5
		/// FieldName: AMF5
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free units - act mtr 5")]
		public decimal? M3AMF5 => GetNullableDecimal("AMF5");

		/// <summary>
		/// Description: Free units - act mtr 6
		/// FieldName: AMF6
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free units - act mtr 6")]
		public decimal? M3AMF6 => GetNullableDecimal("AMF6");

		/// <summary>
		/// Description: Credit units - act mtr 1
		/// FieldName: AMC1
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit units - act mtr 1")]
		public decimal? M3AMC1 => GetNullableDecimal("AMC1");

		/// <summary>
		/// Description: Credit units - act mtr 2
		/// FieldName: AMC2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit units - act mtr 2")]
		public decimal? M3AMC2 => GetNullableDecimal("AMC2");

		/// <summary>
		/// Description: Credit units - act mtr 3
		/// FieldName: AMC3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit units - act mtr 3")]
		public decimal? M3AMC3 => GetNullableDecimal("AMC3");

		/// <summary>
		/// Description: Credit units - act mtr 4
		/// FieldName: AMC4
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit units - act mtr 4")]
		public decimal? M3AMC4 => GetNullableDecimal("AMC4");

		/// <summary>
		/// Description: Credit units - act mtr 5
		/// FieldName: AMC5
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit units - act mtr 5")]
		public decimal? M3AMC5 => GetNullableDecimal("AMC5");

		/// <summary>
		/// Description: Credit units - act mtr 6
		/// FieldName: AMC6
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit units - act mtr 6")]
		public decimal? M3AMC6 => GetNullableDecimal("AMC6");

		/// <summary>
		/// Description: Employee number
		/// FieldName: EMNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee number")]
		public string M3EMNO => GetString("EMNO");

		/// <summary>
		/// Description: Invoice Prefix
		/// FieldName: INPX
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Prefix")]
		public string M3INPX => GetString("INPX");

		/// <summary>
		/// Description: Extended Invoice Number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended Invoice Number")]
		public string M3EXIN => GetString("EXIN");
	}
}
// EOF
