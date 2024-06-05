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

namespace M3H5Lib.Api.EQINFOMI
{
	public partial class GetAgreementResponse : M3BaseRecord 
	{

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
		/// Description: Agreement type
		/// FieldName: AAGT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement type")]
		public string M3_AAGT => GetString("AAGT");

		/// <summary>
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3_CUNO => GetString("CUNO");

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
		/// Description: Text
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TX30 => GetString("TX30");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

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
		/// Description: Statistical customer
		/// FieldName: ACS1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistical customer")]
		public string M3_ACS1 => GetString("ACS1");

		/// <summary>
		/// Description: Statistical agreement
		/// FieldName: AAGS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistical agreement")]
		public string M3_AAGS => GetString("AAGS");

		/// <summary>
		/// Description: Project
		/// FieldName: APRS
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project")]
		public string M3_APRS => GetString("APRS");

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
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3_STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: To date
		/// FieldName: TODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3_TODT => GetNullableDateTime("TODT");

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
		/// Description: External reference
		/// FieldName: AREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External reference")]
		public string M3_AREF => GetString("AREF");

		/// <summary>
		/// Description: Material price method
		/// FieldName: APBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material price method")]
		public int? M3_APBA => GetNullableInt("APBA");

		/// <summary>
		/// Description: Material handling charge method
		/// FieldName: AHCM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material handling charge method")]
		public int? M3_AHCM => GetNullableInt("AHCM");

		/// <summary>
		/// Description: General handling charge
		/// FieldName: AMHA
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("General handling charge")]
		public int? M3_AMHA => GetNullableInt("AMHA");

		/// <summary>
		/// Description: Maximum handling charge per order
		/// FieldName: AMHT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum handling charge per order")]
		public decimal? M3_AMHT => GetNullableDecimal("AMHT");

		/// <summary>
		/// Description: Maximum handling charge per transaction
		/// FieldName: AMHL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum handling charge per transaction")]
		public decimal? M3_AMHL => GetNullableDecimal("AMHL");

		/// <summary>
		/// Description: Maximum handling charge per item
		/// FieldName: AMHI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum handling charge per item")]
		public decimal? M3_AMHI => GetNullableDecimal("AMHI");

		/// <summary>
		/// Description: Material currency
		/// FieldName: AMCU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material currency")]
		public string M3_AMCU => GetString("AMCU");

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
		/// Description: Agreement currency
		/// FieldName: AACU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement currency")]
		public string M3_AACU => GetString("AACU");

		/// <summary>
		/// Description: Exchange rate type
		/// FieldName: CRT1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public int? M3_CRT1 => GetNullableInt("CRT1");

		/// <summary>
		/// Description: Agreement cancellation - days notice
		/// FieldName: ACDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement cancellation - days notice")]
		public int? M3_ACDY => GetNullableInt("ACDY");

		/// <summary>
		/// Description: Check scope of agreement - object
		/// FieldName: ACT9
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check scope of agreement - object")]
		public int? M3_ACT9 => GetNullableInt("ACT9");

		/// <summary>
		/// Description: Check scope of agreement - model indiv
		/// FieldName: ACRG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check scope of agreement - model indiv")]
		public int? M3_ACRG => GetNullableInt("ACRG");

		/// <summary>
		/// Description: Serial number administration
		/// FieldName: ACSE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number administration")]
		public int? M3_ACSE => GetNullableInt("ACSE");

		/// <summary>
		/// Description: Modification
		/// FieldName: AMOD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Modification")]
		public int? M3_AMOD => GetNullableInt("AMOD");

		/// <summary>
		/// Description: Maintenance program
		/// FieldName: MPGM
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maintenance program")]
		public string M3_MPGM => GetString("MPGM");

		/// <summary>
		/// Description: Order type
		/// FieldName: AOTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_AOTY => GetString("AOTY");

		/// <summary>
		/// Description: Service price list
		/// FieldName: SPRL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service price list")]
		public string M3_SPRL => GetString("SPRL");

		/// <summary>
		/// Description: Monitoring list
		/// FieldName: AMON
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monitoring list")]
		public string M3_AMON => GetString("AMON");

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
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3_MODL => GetString("MODL");

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
		/// Description: Packaging terms
		/// FieldName: TEPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging terms")]
		public string M3_TEPA => GetString("TEPA");

		/// <summary>
		/// Description: Freight terms
		/// FieldName: TEAF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight terms")]
		public string M3_TEAF => GetString("TEAF");

		/// <summary>
		/// Description: Delivery terms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms")]
		public string M3_TEDL => GetString("TEDL");

		/// <summary>
		/// Description: User-defined field 1 - item
		/// FieldName: CFI1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - item")]
		public string M3_CFI1 => GetString("CFI1");

		/// <summary>
		/// Description: User-defined field 2 - item
		/// FieldName: CFI2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - item")]
		public decimal? M3_CFI2 => GetNullableDecimal("CFI2");

		/// <summary>
		/// Description: User-defined field 3 - item
		/// FieldName: CFI3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - item")]
		public string M3_CFI3 => GetString("CFI3");

		/// <summary>
		/// Description: User-defined field 4 - item
		/// FieldName: CFI4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - item")]
		public string M3_CFI4 => GetString("CFI4");

		/// <summary>
		/// Description: User-defined field 5 - item
		/// FieldName: CFI5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - item")]
		public string M3_CFI5 => GetString("CFI5");

		/// <summary>
		/// Description: Price list
		/// FieldName: PRRF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list")]
		public string M3_PRRF => GetString("PRRF");

		/// <summary>
		/// Description: Price list 2
		/// FieldName: PRR2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 2")]
		public string M3_PRR2 => GetString("PRR2");

		/// <summary>
		/// Description: Price list 3
		/// FieldName: PRR3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 3")]
		public string M3_PRR3 => GetString("PRR3");

		/// <summary>
		/// Description: Price list 4
		/// FieldName: PRR4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 4")]
		public string M3_PRR4 => GetString("PRR4");

		/// <summary>
		/// Description: Price list 5
		/// FieldName: PRR5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 5")]
		public string M3_PRR5 => GetString("PRR5");

		/// <summary>
		/// Description: Operation plan version
		/// FieldName: OPVR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation plan version")]
		public string M3_OPVR => GetString("OPVR");

		/// <summary>
		/// Description: Operation plan version actual
		/// FieldName: OPVC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation plan version actual")]
		public string M3_OPVC => GetString("OPVC");

		/// <summary>
		/// Description: Operation plan version divergence
		/// FieldName: OPVD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation plan version divergence")]
		public string M3_OPVD => GetString("OPVD");

		/// <summary>
		/// Description: Maximum handling charge per order
		/// FieldName: ASHT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum handling charge per order")]
		public decimal? M3_ASHT => GetNullableDecimal("ASHT");

		/// <summary>
		/// Description: Maximum handling charge per transaction
		/// FieldName: ASHL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum handling charge per transaction")]
		public decimal? M3_ASHL => GetNullableDecimal("ASHL");

		/// <summary>
		/// Description: Maximum handling charge per item
		/// FieldName: ASHI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum handling charge per item")]
		public decimal? M3_ASHI => GetNullableDecimal("ASHI");
	}
}
// EOF
