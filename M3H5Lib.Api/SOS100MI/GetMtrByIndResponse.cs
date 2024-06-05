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

namespace M3H5Lib.Api.SOS100MI
{
	public partial class GetMtrByIndResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Name meter 1
		/// FieldName: M1NA
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 1")]
		public string M3_M1NA => GetString("M1NA");

		/// <summary>
		/// Description: Name meter 2
		/// FieldName: M2NA
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 2")]
		public string M3_M2NA => GetString("M2NA");

		/// <summary>
		/// Description: Name meter 3
		/// FieldName: M3NA
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 3")]
		public string M3_M3NA => GetString("M3NA");

		/// <summary>
		/// Description: Name meter 4
		/// FieldName: M4NA
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 4")]
		public string M3_M4NA => GetString("M4NA");

		/// <summary>
		/// Description: Name meter 5
		/// FieldName: M5NA
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 5")]
		public string M3_M5NA => GetString("M5NA");

		/// <summary>
		/// Description: Name meter 6
		/// FieldName: M6NA
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 6")]
		public string M3_M6NA => GetString("M6NA");

		/// <summary>
		/// Description: Previous meter reading - Meter 1
		/// FieldName: PMV1
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous meter reading - Meter 1")]
		public long? M3_PMV1 => GetNullableLong("PMV1");

		/// <summary>
		/// Description: Previous meter reading - Meter 2
		/// FieldName: PMV2
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous meter reading - Meter 2")]
		public long? M3_PMV2 => GetNullableLong("PMV2");

		/// <summary>
		/// Description: Previous meter reading - Meter 3
		/// FieldName: PMV3
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous meter reading - Meter 3")]
		public long? M3_PMV3 => GetNullableLong("PMV3");

		/// <summary>
		/// Description: Previous meter reading - Meter 4
		/// FieldName: PMV4
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous meter reading - Meter 4")]
		public long? M3_PMV4 => GetNullableLong("PMV4");

		/// <summary>
		/// Description: Previous meter reading - Meter 5
		/// FieldName: PMV5
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous meter reading - Meter 5")]
		public long? M3_PMV5 => GetNullableLong("PMV5");

		/// <summary>
		/// Description: Previous meter reading - Meter 6
		/// FieldName: PMV6
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous meter reading - Meter 6")]
		public long? M3_PMV6 => GetNullableLong("PMV6");

		/// <summary>
		/// Description: Model description OBS 20 pos (30 pos)
		/// FieldName: MODE
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Model description OBS 20 pos (30 pos)")]
		public string M3_MODE => GetString("MODE");

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
		/// Description: Address ID
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address ID")]
		public string M3_ADID => GetString("ADID");

		/// <summary>
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3_CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Name meter 1
		/// FieldName: M1DC
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 1")]
		public string M3_M1DC => GetString("M1DC");

		/// <summary>
		/// Description: Name meter 2
		/// FieldName: M2DC
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 2")]
		public string M3_M2DC => GetString("M2DC");

		/// <summary>
		/// Description: Name meter 3
		/// FieldName: M3DC
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 3")]
		public string M3_M3DC => GetString("M3DC");

		/// <summary>
		/// Description: Name meter 4
		/// FieldName: M4DC
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 4")]
		public string M3_M4DC => GetString("M4DC");

		/// <summary>
		/// Description: Name meter 5
		/// FieldName: M5DC
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 5")]
		public string M3_M5DC => GetString("M5DC");

		/// <summary>
		/// Description: Name meter 6
		/// FieldName: M6DC
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name meter 6")]
		public string M3_M6DC => GetString("M6DC");

		/// <summary>
		/// Description: Estim meter value - Meter 1
		/// FieldName: M1ES
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estim meter value - Meter 1")]
		public decimal? M3_M1ES => GetNullableDecimal("M1ES");

		/// <summary>
		/// Description: Estim meter value - Meter 2
		/// FieldName: M2ES
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estim meter value - Meter 2")]
		public decimal? M3_M2ES => GetNullableDecimal("M2ES");

		/// <summary>
		/// Description: Estim meter value - Meter 3
		/// FieldName: M3ES
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estim meter value - Meter 3")]
		public decimal? M3_M3ES => GetNullableDecimal("M3ES");

		/// <summary>
		/// Description: Estim meter value - Meter 4
		/// FieldName: M4ES
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estim meter value - Meter 4")]
		public decimal? M3_M4ES => GetNullableDecimal("M4ES");

		/// <summary>
		/// Description: Estim meter value - Meter 5
		/// FieldName: M5ES
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estim meter value - Meter 5")]
		public decimal? M3_M5ES => GetNullableDecimal("M5ES");

		/// <summary>
		/// Description: Estim meter value - Meter 6
		/// FieldName: M6ES
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estim meter value - Meter 6")]
		public decimal? M3_M6ES => GetNullableDecimal("M6ES");

		/// <summary>
		/// Description: Tot mtr based on mtr
		/// FieldName: TMBM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tot mtr based on mtr")]
		public string M3_TMBM => GetString("TMBM");

		/// <summary>
		/// Description: Description - total meter
		/// FieldName: TMDS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - total meter")]
		public string M3_TMDS => GetString("TMDS");

		/// <summary>
		/// Description: Name - total meter
		/// FieldName: TMNA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - total meter")]
		public string M3_TMNA => GetString("TMNA");

		/// <summary>
		/// Description: Usage period type 1
		/// FieldName: AMB1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Usage period type 1")]
		public int? M3_AMB1 => GetNullableInt("AMB1");

		/// <summary>
		/// Description: Usage period type 2
		/// FieldName: AMB2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Usage period type 2")]
		public int? M3_AMB2 => GetNullableInt("AMB2");

		/// <summary>
		/// Description: Descr log mtr 1
		/// FieldName: L1DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 1")]
		public string M3_L1DS => GetString("L1DS");

		/// <summary>
		/// Description: Descr log mtr 2
		/// FieldName: L2DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 2")]
		public string M3_L2DS => GetString("L2DS");

		/// <summary>
		/// Description: Descr log mtr 3
		/// FieldName: L3DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 3")]
		public string M3_L3DS => GetString("L3DS");

		/// <summary>
		/// Description: Descr log mtr 4
		/// FieldName: L4DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 4")]
		public string M3_L4DS => GetString("L4DS");

		/// <summary>
		/// Description: Descr log mtr 5
		/// FieldName: L5DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 5")]
		public string M3_L5DS => GetString("L5DS");

		/// <summary>
		/// Description: Descr log mtr 6
		/// FieldName: L6DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 6")]
		public string M3_L6DS => GetString("L6DS");

		/// <summary>
		/// Description: Formula log mtr 1
		/// FieldName: L1FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 1")]
		public string M3_L1FO => GetString("L1FO");

		/// <summary>
		/// Description: Formula log mtr 2
		/// FieldName: L2FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 2")]
		public string M3_L2FO => GetString("L2FO");

		/// <summary>
		/// Description: Formula log mtr 3
		/// FieldName: L3FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 3")]
		public string M3_L3FO => GetString("L3FO");

		/// <summary>
		/// Description: Formula log mtr 4
		/// FieldName: L4FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 4")]
		public string M3_L4FO => GetString("L4FO");

		/// <summary>
		/// Description: Formula log mtr 5
		/// FieldName: L5FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 5")]
		public string M3_L5FO => GetString("L5FO");

		/// <summary>
		/// Description: Formula log mtr 6
		/// FieldName: L6FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 6")]
		public string M3_L6FO => GetString("L6FO");

		/// <summary>
		/// Description: Desrc - inv mtr 1
		/// FieldName: I1DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Desrc - inv mtr 1")]
		public string M3_I1DS => GetString("I1DS");

		/// <summary>
		/// Description: Descr - inv mtr 2
		/// FieldName: I2DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - inv mtr 2")]
		public string M3_I2DS => GetString("I2DS");

		/// <summary>
		/// Description: Descr - inv mtr 3
		/// FieldName: I3DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - inv mtr 3")]
		public string M3_I3DS => GetString("I3DS");

		/// <summary>
		/// Description: Descr - inv mtr 4
		/// FieldName: I4DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - inv mtr 4")]
		public string M3_I4DS => GetString("I4DS");

		/// <summary>
		/// Description: Descr . inv mtr 5
		/// FieldName: I5DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr . inv mtr 5")]
		public string M3_I5DS => GetString("I5DS");

		/// <summary>
		/// Description: Descr - inv mtr 6
		/// FieldName: I6DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - inv mtr 6")]
		public string M3_I6DS => GetString("I6DS");

		/// <summary>
		/// Description: Name - inv mtr 1
		/// FieldName: I1NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 1")]
		public string M3_I1NA => GetString("I1NA");

		/// <summary>
		/// Description: Name - inv mtr 2
		/// FieldName: I2NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 2")]
		public string M3_I2NA => GetString("I2NA");

		/// <summary>
		/// Description: Name - inv mtr 3
		/// FieldName: I3NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 3")]
		public string M3_I3NA => GetString("I3NA");

		/// <summary>
		/// Description: Name - inv mtr 4
		/// FieldName: I4NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 4")]
		public string M3_I4NA => GetString("I4NA");

		/// <summary>
		/// Description: Name - inv mtr 5
		/// FieldName: I5NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 5")]
		public string M3_I5NA => GetString("I5NA");

		/// <summary>
		/// Description: Name - inv mtr 6
		/// FieldName: I6NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 6")]
		public string M3_I6NA => GetString("I6NA");

		/// <summary>
		/// Description: Inv mtr 1 based on mtr
		/// FieldName: I1BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 1 based on mtr")]
		public string M3_I1BM => GetString("I1BM");

		/// <summary>
		/// Description: Inv mtr 2 based on mtr
		/// FieldName: I2BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 2 based on mtr")]
		public string M3_I2BM => GetString("I2BM");

		/// <summary>
		/// Description: Inv mtr 3 based on mtr
		/// FieldName: I3BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 3 based on mtr")]
		public string M3_I3BM => GetString("I3BM");

		/// <summary>
		/// Description: Inv mtr 4 based on mtr
		/// FieldName: I4BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 4 based on mtr")]
		public string M3_I4BM => GetString("I4BM");

		/// <summary>
		/// Description: Inv mtr 5 based on mtr
		/// FieldName: I5BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 5 based on mtr")]
		public string M3_I5BM => GetString("I5BM");

		/// <summary>
		/// Description: Inv mtr 6 based on mtr
		/// FieldName: I6BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 6 based on mtr")]
		public string M3_I6BM => GetString("I6BM");

		/// <summary>
		/// Description: Last meter reading date
		/// FieldName: LMRD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last meter reading date")]
		public DateTime? M3_LMRD => GetNullableDateTime("LMRD");
	}
}
// EOF
