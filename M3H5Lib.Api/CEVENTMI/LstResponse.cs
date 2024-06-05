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

namespace M3H5Lib.Api.CEVENTMI
{
	public partial class LstResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Event ID
		/// FieldName: EVID
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event ID")]
		public string M3_EVID => GetString("EVID");

		/// <summary>
		/// Description: Connector  ID
		/// FieldName: CNID
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Connector  ID")]
		public int? M3_CNID => GetNullableInt("CNID");

		/// <summary>
		/// Description: Event priority
		/// FieldName: EVPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event priority")]
		public int? M3_EVPR => GetNullableInt("EVPR");

		/// <summary>
		/// Description: Business object name
		/// FieldName: BONM
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business object name")]
		public string M3_BONM => GetString("BONM");

		/// <summary>
		/// Description: Event verb
		/// FieldName: BOVB
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event verb")]
		public string M3_BOVB => GetString("BOVB");

		/// <summary>
		/// Description: Business object key
		/// FieldName: BOKY
		/// FieldType: A
		/// Length: 300
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business object key")]
		public string M3_BOKY => GetString("BOKY");

		/// <summary>
		/// Description: Business object attributes
		/// FieldName: BOAT
		/// FieldType: A
		/// Length: 300
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business object attributes")]
		public string M3_BOAT => GetString("BOAT");

		/// <summary>
		/// Description: Event status
		/// FieldName: ESTS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event status")]
		public int? M3_ESTS => GetNullableInt("ESTS");

		/// <summary>
		/// Description: Message ID
		/// FieldName: MSID
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message ID")]
		public string M3_MSID => GetString("MSID");

		/// <summary>
		/// Description: Message
		/// FieldName: MSGD
		/// FieldType: A
		/// Length: 78
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message")]
		public string M3_MSGD => GetString("MSGD");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Event processed date
		/// FieldName: PEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event processed date")]
		public DateTime? M3_PEDT => GetNullableDateTime("PEDT");

		/// <summary>
		/// Description: Event processed time
		/// FieldName: PETM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event processed time")]
		public int? M3_PETM => GetNullableInt("PETM");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");
	}
}
// EOF
