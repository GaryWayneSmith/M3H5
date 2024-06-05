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

namespace M3H5Lib.Api.MOS054MI
{
	public partial class GetSerErrorResponse : M3BaseRecord 
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
		/// Description: WO No.
		/// FieldName: MWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("WO No.")]
		public string M3_MWNO => GetString("MWNO");

		/// <summary>
		/// Description: Product
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product")]
		public string M3_PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Serial No
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial No")]
		public string M3_BANO => GetString("BANO");

		/// <summary>
		/// Description: Reg no/site
		/// FieldName: TAIL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reg no/site")]
		public string M3_TAIL => GetString("TAIL");

		/// <summary>
		/// Description: Item Causing Failure
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item Causing Failure")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Text Item Causing Failure
		/// FieldName: TLX1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Item Causing Failure")]
		public string M3_TLX1 => GetString("TLX1");

		/// <summary>
		/// Description: Text Item Causing Failure
		/// FieldName: TLX2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Item Causing Failure")]
		public string M3_TLX2 => GetString("TLX2");

		/// <summary>
		/// Description: Error code 1
		/// FieldName: FCLA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error code 1")]
		public string M3_FCLA => GetString("FCLA");

		/// <summary>
		/// Description: Text Error code 1
		/// FieldName: TLX3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Error code 1")]
		public string M3_TLX3 => GetString("TLX3");

		/// <summary>
		/// Description: Text Error code 1
		/// FieldName: TLX4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Error code 1")]
		public string M3_TLX4 => GetString("TLX4");

		/// <summary>
		/// Description: Error code 2
		/// FieldName: FCL2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error code 2")]
		public string M3_FCL2 => GetString("FCL2");

		/// <summary>
		/// Description: Text Error code 2
		/// FieldName: TLX5
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Error code 2")]
		public string M3_TLX5 => GetString("TLX5");

		/// <summary>
		/// Description: Text Error code 2
		/// FieldName: TLX6
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Error code 2")]
		public string M3_TLX6 => GetString("TLX6");

		/// <summary>
		/// Description: Error code 3
		/// FieldName: FCL3
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error code 3")]
		public string M3_FCL3 => GetString("FCL3");

		/// <summary>
		/// Description: Text Error code 3
		/// FieldName: TLX7
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Error code 3")]
		public string M3_TLX7 => GetString("TLX7");

		/// <summary>
		/// Description: Text Error code 3
		/// FieldName: TLX8
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Error code 3")]
		public string M3_TLX8 => GetString("TLX8");

		/// <summary>
		/// Description: Repair Comments
		/// FieldName: TLX9
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repair Comments")]
		public string M3_TLX9 => GetString("TLX9");

		/// <summary>
		/// Description: Repair Comments
		/// FieldName: TLX0
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repair Comments")]
		public string M3_TLX0 => GetString("TLX0");

		/// <summary>
		/// Description: Breakdown date
		/// FieldName: BRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Breakdown date")]
		public DateTime? M3_BRDT => GetNullableDateTime("BRDT");

		/// <summary>
		/// Description: Breakdown time
		/// FieldName: BRTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Breakdown time")]
		public int? M3_BRTI => GetNullableInt("BRTI");

		/// <summary>
		/// Description: Ready date
		/// FieldName: MRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ready date")]
		public DateTime? M3_MRDT => GetNullableDateTime("MRDT");

		/// <summary>
		/// Description: Ready time
		/// FieldName: MRTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ready time")]
		public int? M3_MRTI => GetNullableInt("MRTI");

		/// <summary>
		/// Description: Running date
		/// FieldName: EQDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Running date")]
		public DateTime? M3_EQDT => GetNullableDateTime("EQDT");

		/// <summary>
		/// Description: Running time
		/// FieldName: EQTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Running time")]
		public int? M3_EQTI => GetNullableInt("EQTI");

		/// <summary>
		/// Description: Warranty type
		/// FieldName: WATP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty type")]
		public string M3_WATP => GetString("WATP");

		/// <summary>
		/// Description: User defined field 1
		/// FieldName: SMC0
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 1")]
		public string M3_SMC0 => GetString("SMC0");

		/// <summary>
		/// Description: User defined field 2
		/// FieldName: SMC1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 2")]
		public string M3_SMC1 => GetString("SMC1");

		/// <summary>
		/// Description: User defined field 3
		/// FieldName: SMC2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 3")]
		public string M3_SMC2 => GetString("SMC2");

		/// <summary>
		/// Description: User defined field 3
		/// FieldName: SMC3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 3")]
		public string M3_SMC3 => GetString("SMC3");

		/// <summary>
		/// Description: User defined field 5
		/// FieldName: SMC4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 5")]
		public string M3_SMC4 => GetString("SMC4");

		/// <summary>
		/// Description: User defined field 6
		/// FieldName: SMC5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 6")]
		public string M3_SMC5 => GetString("SMC5");

		/// <summary>
		/// Description: User defined field 7
		/// FieldName: SMC6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 7")]
		public string M3_SMC6 => GetString("SMC6");

		/// <summary>
		/// Description: User defined field 8
		/// FieldName: SMC7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 8")]
		public string M3_SMC7 => GetString("SMC7");

		/// <summary>
		/// Description: User defined field 9
		/// FieldName: SMC8
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 9")]
		public string M3_SMC8 => GetString("SMC8");

		/// <summary>
		/// Description: User defined field 10
		/// FieldName: SMC9
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 10")]
		public string M3_SMC9 => GetString("SMC9");

		/// <summary>
		/// Description: Drawing position
		/// FieldName: DWPO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing position")]
		public string M3_DWPO => GetString("DWPO");
	}
}
// EOF
