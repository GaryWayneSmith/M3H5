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

namespace M3H5Lib.Api.CLAIMSMI
{
	public partial class GetClaimHeadTxtResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Claim
		/// FieldName: CLNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim")]
		public string M3_CLNO => GetString("CLNO");

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
		/// Description: Error symptom text
		/// FieldName: ETX1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom text")]
		public string M3_ETX1 => GetString("ETX1");

		/// <summary>
		/// Description: Error symptom text
		/// FieldName: ETX2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom text")]
		public string M3_ETX2 => GetString("ETX2");

		/// <summary>
		/// Description: Error symptom text
		/// FieldName: ETX3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom text")]
		public string M3_ETX3 => GetString("ETX3");

		/// <summary>
		/// Description: Error symptom text
		/// FieldName: ETX4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom text")]
		public string M3_ETX4 => GetString("ETX4");

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
		/// Description: Text
		/// FieldName: TX60
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TX60 => GetString("TX60");

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
		/// Description: Text
		/// FieldName: MTX1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_MTX1 => GetString("MTX1");

		/// <summary>
		/// Description: Text
		/// FieldName: MTX2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_MTX2 => GetString("MTX2");

		/// <summary>
		/// Description: Text
		/// FieldName: MTX3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_MTX3 => GetString("MTX3");

		/// <summary>
		/// Description: Text
		/// FieldName: MTX4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_MTX4 => GetString("MTX4");

		/// <summary>
		/// Description: Evaluation text
		/// FieldName: EVTX
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Evaluation text")]
		public string M3_EVTX => GetString("EVTX");

		/// <summary>
		/// Description: Evaluation text
		/// FieldName: EVT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Evaluation text")]
		public string M3_EVT1 => GetString("EVT1");

		/// <summary>
		/// Description: Claim notes
		/// FieldName: CLNT
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim notes")]
		public string M3_CLNT => GetString("CLNT");

		/// <summary>
		/// Description: Date to recall Customer
		/// FieldName: DTRC
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date to recall Customer")]
		public DateTime? M3_DTRC => GetNullableDateTime("DTRC");

		/// <summary>
		/// Description: Call notes
		/// FieldName: CANT
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Call notes")]
		public string M3_CANT => GetString("CANT");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXIR
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXIR => GetNullableDecimal("TXIR");

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
		/// Description: Warranty type
		/// FieldName: WATP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty type")]
		public string M3_WATP => GetString("WATP");
	}
}
// EOF
