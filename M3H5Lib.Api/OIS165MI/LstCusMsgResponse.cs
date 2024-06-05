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

namespace M3H5Lib.Api.OIS165MI
{
	public partial class LstCusMsgResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Transaction type
		/// FieldName: TRTP
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type")]
		public string M3TRTP => GetString("TRTP");

		/// <summary>
		/// Description: Qualifier
		/// FieldName: QLYF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Qualifier")]
		public int? M3QLYF => GetNullableInt("QLYF");

		/// <summary>
		/// Description: Display priority
		/// FieldName: DPRI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Display priority")]
		public int? M3DPRI => GetNullableInt("DPRI");

		/// <summary>
		/// Description: From date
		/// FieldName: FRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public DateTime? M3FRDT => GetNullableDateTime("FRDT");

		/// <summary>
		/// Description: To date
		/// FieldName: TODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3TODT => GetNullableDateTime("TODT");

		/// <summary>
		/// Description: Identity
		/// FieldName: QLVA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Identity")]
		public string M3QLVA => GetString("QLVA");

		/// <summary>
		/// Description: Tab limit value
		/// FieldName: TLVA
		/// FieldType: N
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tab limit value")]
		public decimal? M3TLVA => GetNullableDecimal("TLVA");

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
		/// Description: Description user
		/// FieldName: TUID
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description user")]
		public string M3TUID => GetString("TUID");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Line number
		/// FieldName: LINO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3LINO => GetNullableInt("LINO");

		/// <summary>
		/// Description: Text
		/// FieldName: TX60
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TX60 => GetString("TX60");
	}
}
// EOF
