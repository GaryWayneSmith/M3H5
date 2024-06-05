/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.CEVENTMI
{
	public partial class GetResponse : M3BaseRecord 
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
		public string M3EVID => GetString("EVID");

		/// <summary>
		/// Description: Connector  ID
		/// FieldName: CNID
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Connector  ID")]
		public int? M3CNID => GetNullableInt("CNID");

		/// <summary>
		/// Description: Event priority
		/// FieldName: EVPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event priority")]
		public int? M3EVPR => GetNullableInt("EVPR");

		/// <summary>
		/// Description: Business object name
		/// FieldName: BONM
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business object name")]
		public string M3BONM => GetString("BONM");

		/// <summary>
		/// Description: Event verb
		/// FieldName: BOVB
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event verb")]
		public string M3BOVB => GetString("BOVB");

		/// <summary>
		/// Description: Business object key
		/// FieldName: BOKY
		/// FieldType: A
		/// Length: 300
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business object key")]
		public string M3BOKY => GetString("BOKY");

		/// <summary>
		/// Description: Business object attributes
		/// FieldName: BOAT
		/// FieldType: A
		/// Length: 300
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business object attributes")]
		public string M3BOAT => GetString("BOAT");

		/// <summary>
		/// Description: Event status
		/// FieldName: ESTS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event status")]
		public int? M3ESTS => GetNullableInt("ESTS");

		/// <summary>
		/// Description: Message ID
		/// FieldName: MSID
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message ID")]
		public string M3MSID => GetString("MSID");

		/// <summary>
		/// Description: Message
		/// FieldName: MSGD
		/// FieldType: A
		/// Length: 78
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message")]
		public string M3MSGD => GetString("MSGD");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Event processed date
		/// FieldName: PEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event processed date")]
		public DateTime? M3PEDT => GetNullableDateTime("PEDT");

		/// <summary>
		/// Description: Event processed time
		/// FieldName: PETM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event processed time")]
		public int? M3PETM => GetNullableInt("PETM");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");
	}
}
// EOF
