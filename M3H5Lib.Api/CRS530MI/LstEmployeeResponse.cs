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

namespace M3H5Lib.Api.CRS530MI
{
	public partial class LstEmployeeResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

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
		/// Description: Name
		/// FieldName: EMNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3EMNM => GetString("EMNM");

		/// <summary>
		/// Description: User
		/// FieldName: USID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3USID => GetString("USID");

		/// <summary>
		/// Description: Active employee
		/// FieldName: ACEM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active employee")]
		public int? M3ACEM => GetNullableInt("ACEM");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Work center
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3PLGR => GetString("PLGR");

		/// <summary>
		/// Description: Department
		/// FieldName: DEPT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department")]
		public string M3DEPT => GetString("DEPT");

		/// <summary>
		/// Description: Planning area
		/// FieldName: REAR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning area")]
		public string M3REAR => GetString("REAR");

		/// <summary>
		/// Description: Work schedule
		/// FieldName: WOSC
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work schedule")]
		public int? M3WOSC => GetNullableInt("WOSC");

		/// <summary>
		/// Description: Work schedule from date
		/// FieldName: WODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work schedule from date")]
		public DateTime? M3WODT => GetNullableDateTime("WODT");

		/// <summary>
		/// Description: Start week - schedule
		/// FieldName: SWSC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start week - schedule")]
		public int? M3SWSC => GetNullableInt("SWSC");

		/// <summary>
		/// Description: Card number
		/// FieldName: CANO
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Card number")]
		public long? M3CANO => GetNullableLong("CANO");

		/// <summary>
		/// Description: PIN code
		/// FieldName: PNCO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIN code")]
		public string M3PNCO => GetString("PNCO");

		/// <summary>
		/// Description: Telephone number 1
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 1")]
		public string M3PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Telephone number 1
		/// FieldName: IPHN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 1")]
		public string M3IPHN => GetString("IPHN");

		/// <summary>
		/// Description: Celluar telephone number
		/// FieldName: CAPH
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Celluar telephone number")]
		public string M3CAPH => GetString("CAPH");

		/// <summary>
		/// Description: Used in Time & Attendance
		/// FieldName: MXTM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used in Time & Attendance")]
		public int? M3MXTM => GetNullableInt("MXTM");

		/// <summary>
		/// Description: Used in Service and Rental
		/// FieldName: MXSO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used in Service and Rental")]
		public int? M3MXSO => GetNullableInt("MXSO");

		/// <summary>
		/// Description: Used in Time accounting
		/// FieldName: MXTA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used in Time accounting")]
		public int? M3MXTA => GetNullableInt("MXTA");

		/// <summary>
		/// Description: Used in Manufactoring Orde Processing
		/// FieldName: MXPM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used in Manufactoring Orde Processing")]
		public int? M3MXPM => GetNullableInt("MXPM");

		/// <summary>
		/// Description: Ued in Maintenance
		/// FieldName: MXMO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ued in Maintenance")]
		public int? M3MXMO => GetNullableInt("MXMO");

		/// <summary>
		/// Description: Employee group
		/// FieldName: TMGR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee group")]
		public string M3TMGR => GetString("TMGR");

		/// <summary>
		/// Description: Operation include Time and Attendance
		/// FieldName: SUSD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation include Time and Attendance")]
		public int? M3SUSD => GetNullableInt("SUSD");

		/// <summary>
		/// Description: Calculation method - overtime
		/// FieldName: OTCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation method - overtime")]
		public int? M3OTCD => GetNullableInt("OTCD");

		/// <summary>
		/// Description: Minimum overtime per day
		/// FieldName: MNOT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum overtime per day")]
		public int? M3MNOT => GetNullableInt("MNOT");

		/// <summary>
		/// Description: Calculation method - flextime
		/// FieldName: FLAW
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation method - flextime")]
		public int? M3FLAW => GetNullableInt("FLAW");

		/// <summary>
		/// Description: Time type for flextime
		/// FieldName: FLTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time type for flextime")]
		public string M3FLTP => GetString("FLTP");

		/// <summary>
		/// Description: Time type
		/// FieldName: TTPE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time type")]
		public string M3TTPE => GetString("TTPE");

		/// <summary>
		/// Description: Time type actual attendance
		/// FieldName: TMRP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time type actual attendance")]
		public string M3TMRP => GetString("TMRP");

		/// <summary>
		/// Description: Time type missing time
		/// FieldName: RMTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time type missing time")]
		public string M3RMTP => GetString("RMTP");

		/// <summary>
		/// Description: Variable workday
		/// FieldName: FXWD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Variable workday")]
		public int? M3FXWD => GetNullableInt("FXWD");

		/// <summary>
		/// Description: Time limit variable workday
		/// FieldName: TVWD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time limit variable workday")]
		public int? M3TVWD => GetNullableInt("TVWD");

		/// <summary>
		/// Description: Automatic generation time type
		/// FieldName: AUTT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic generation time type")]
		public string M3AUTT => GetString("AUTT");

		/// <summary>
		/// Description: Number of minutes
		/// FieldName: TMEM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of minutes")]
		public int? M3TMEM => GetNullableInt("TMEM");

		/// <summary>
		/// Description: Time type run time
		/// FieldName: TPOT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time type run time")]
		public string M3TPOT => GetString("TPOT");

		/// <summary>
		/// Description: Time type setup time
		/// FieldName: TPST
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time type setup time")]
		public string M3TPST => GetString("TPST");

		/// <summary>
		/// Description: Piece rate paid
		/// FieldName: PWPY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Piece rate paid")]
		public int? M3PWPY => GetNullableInt("PWPY");

		/// <summary>
		/// Description: Cost center
		/// FieldName: TMCC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost center")]
		public string M3TMCC => GetString("TMCC");

		/// <summary>
		/// Description: Calculated to date
		/// FieldName: CTOD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated to date")]
		public DateTime? M3CTOD => GetNullableDateTime("CTOD");

		/// <summary>
		/// Description: Latest transfer to date to history/pay
		/// FieldName: TTPD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Latest transfer to date to history/pay")]
		public DateTime? M3TTPD => GetNullableDateTime("TTPD");

		/// <summary>
		/// Description: Employee identity
		/// FieldName: EMID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee identity")]
		public string M3EMID => GetString("EMID");

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
		/// Description: Employee group - Time Accounting
		/// FieldName: PCAT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee group - Time Accounting")]
		public string M3PCAT => GetString("PCAT");

		/// <summary>
		/// Description: Approval ID
		/// FieldName: APID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval ID")]
		public string M3APID => GetString("APID");

		/// <summary>
		/// Description: Display total
		/// FieldName: DSSU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Display total")]
		public int? M3DSSU => GetNullableInt("DSSU");

		/// <summary>
		/// Description: View display
		/// FieldName: DSWD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("View display")]
		public int? M3DSWD => GetNullableInt("DSWD");

		/// <summary>
		/// Description: View entry
		/// FieldName: DSWE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("View entry")]
		public int? M3DSWE => GetNullableInt("DSWE");

		/// <summary>
		/// Description: Cost center
		/// FieldName: TACC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost center")]
		public string M3TACC => GetString("TACC");

		/// <summary>
		/// Description: User defined field 1
		/// FieldName: FRT1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 1")]
		public string M3FRT1 => GetString("FRT1");

		/// <summary>
		/// Description: User defined field 2
		/// FieldName: FRT2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 2")]
		public string M3FRT2 => GetString("FRT2");

		/// <summary>
		/// Description: User defined field 3
		/// FieldName: FRT3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 3")]
		public string M3FRT3 => GetString("FRT3");

		/// <summary>
		/// Description: User defined field 4
		/// FieldName: FRT4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 4")]
		public string M3FRT4 => GetString("FRT4");

		/// <summary>
		/// Description: User defined field 5
		/// FieldName: FRT5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 5")]
		public string M3FRT5 => GetString("FRT5");

		/// <summary>
		/// Description: User defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined accounting control object")]
		public string M3ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Short name
		/// FieldName: TNL2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Short name")]
		public string M3TNL2 => GetString("TNL2");

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
		/// Description: Location
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3WHSL => GetString("WHSL");

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
		/// Description: Hourly price
		/// FieldName: SPHO
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hourly price")]
		public decimal? M3SPHO => GetNullableDecimal("SPHO");

		/// <summary>
		/// Description: Currency - sales price
		/// FieldName: CUCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency - sales price")]
		public string M3CUCS => GetString("CUCS");

		/// <summary>
		/// Description: Hourly cost
		/// FieldName: CPHO
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hourly cost")]
		public decimal? M3CPHO => GetNullableDecimal("CPHO");

		/// <summary>
		/// Description: Application message recipient
		/// FieldName: RECM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application message recipient")]
		public int? M3RECM => GetNullableInt("RECM");

		/// <summary>
		/// Description: Employment date
		/// FieldName: EBDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employment date")]
		public DateTime? M3EBDT => GetNullableDateTime("EBDT");

		/// <summary>
		/// Description: Termination date
		/// FieldName: EEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Termination date")]
		public DateTime? M3EEDT => GetNullableDateTime("EEDT");
	}
}
// EOF
