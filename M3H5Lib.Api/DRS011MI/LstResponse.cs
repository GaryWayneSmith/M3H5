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

namespace M3H5Lib.Api.DRS011MI
{
	public partial class LstResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Place of load
		/// FieldName: EDES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place of load")]
		public string M3EDES => GetString("EDES");

		/// <summary>
		/// Description: Priority
		/// FieldName: PREX
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public string M3PREX => GetString("PREX");

		/// <summary>
		/// Description: Start value 1
		/// FieldName: OBV1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 1")]
		public string M3OBV1 => GetString("OBV1");

		/// <summary>
		/// Description: Start value 2
		/// FieldName: OBV2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 2")]
		public string M3OBV2 => GetString("OBV2");

		/// <summary>
		/// Description: Start value 3
		/// FieldName: OBV3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 3")]
		public string M3OBV3 => GetString("OBV3");

		/// <summary>
		/// Description: Start value 4
		/// FieldName: OBV4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 4")]
		public string M3OBV4 => GetString("OBV4");

		/// <summary>
		/// Description: Route
		/// FieldName: ROUT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route")]
		public string M3ROUT => GetString("ROUT");

		/// <summary>
		/// Description: Route departure
		/// FieldName: RODN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route departure")]
		public int? M3RODN => GetNullableInt("RODN");

		/// <summary>
		/// Description: Selection method for departures
		/// FieldName: SEFB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection method for departures")]
		public int? M3SEFB => GetNullableInt("SEFB");

		/// <summary>
		/// Description: Try lower priority
		/// FieldName: SELP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Try lower priority")]
		public int? M3SELP => GetNullableInt("SELP");

		/// <summary>
		/// Description: Departure days
		/// FieldName: DDOW
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Departure days")]
		public string M3DDOW => GetString("DDOW");

		/// <summary>
		/// Description: Forwarding agent
		/// FieldName: FWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarding agent")]
		public string M3FWNO => GetString("FWNO");

		/// <summary>
		/// Description: Transportation equipment
		/// FieldName: TRCA
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation equipment")]
		public string M3TRCA => GetString("TRCA");

		/// <summary>
		/// Description: Reference
		/// FieldName: RFID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference")]
		public string M3RFID => GetString("RFID");

		/// <summary>
		/// Description: Pallet registration number
		/// FieldName: PAL1
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pallet registration number")]
		public string M3PAL1 => GetString("PAL1");

		/// <summary>
		/// Description: Preliminary route selection
		/// FieldName: PRRO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preliminary route selection")]
		public int? M3PRRO => GetNullableInt("PRRO");

		/// <summary>
		/// Description: Local transportation lead time - days
		/// FieldName: LOLD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local transportation lead time - days")]
		public int? M3LOLD => GetNullableInt("LOLD");

		/// <summary>
		/// Description: Local transportation lead time - hours
		/// FieldName: LOLH
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local transportation lead time - hours")]
		public int? M3LOLH => GetNullableInt("LOLH");

		/// <summary>
		/// Description: Local transportation lead time - minutes
		/// FieldName: LOLM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local transportation lead time - minutes")]
		public int? M3LOLM => GetNullableInt("LOLM");

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
