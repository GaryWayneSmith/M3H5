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

namespace M3H5Lib.Api.CRS881MI
{
	public partial class LstTranslDataResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Record type
		/// FieldName: TRQF
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Record type")]
		public string M3_TRQF => GetString("TRQF");

		/// <summary>
		/// Description: Message standard
		/// FieldName: MSTD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message standard")]
		public string M3_MSTD => GetString("MSTD");

		/// <summary>
		/// Description: Message version
		/// FieldName: MVRS
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message version")]
		public string M3_MVRS => GetString("MVRS");

		/// <summary>
		/// Description: Business message
		/// FieldName: BMSG
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business message")]
		public string M3_BMSG => GetString("BMSG");

		/// <summary>
		/// Description: Inbound or outbound message
		/// FieldName: IBOB
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inbound or outbound message")]
		public string M3_IBOB => GetString("IBOB");

		/// <summary>
		/// Description: Parent element(s)
		/// FieldName: ELMP
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parent element(s)")]
		public string M3_ELMP => GetString("ELMP");

		/// <summary>
		/// Description: Data element
		/// FieldName: ELMD
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data element")]
		public string M3_ELMD => GetString("ELMD");

		/// <summary>
		/// Description: Conditional element
		/// FieldName: ELMC
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conditional element")]
		public string M3_ELMC => GetString("ELMC");

		/// <summary>
		/// Description: Conditional data
		/// FieldName: MBMC
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conditional data")]
		public string M3_MBMC => GetString("MBMC");

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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Business data translation identity
		/// FieldName: IDTR
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business data translation identity")]
		public int? M3_IDTR => GetNullableInt("IDTR");

		/// <summary>
		/// Description: Movex partner address
		/// FieldName: MVXP
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Movex partner address")]
		public string M3_MVXP => GetString("MVXP");

		/// <summary>
		/// Description: External partner address
		/// FieldName: EXTP
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External partner address")]
		public string M3_EXTP => GetString("EXTP");

		/// <summary>
		/// Description: Movex data
		/// FieldName: MVXD
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Movex data")]
		public string M3_MVXD => GetString("MVXD");

		/// <summary>
		/// Description: Message data
		/// FieldName: MBMD
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message data")]
		public string M3_MBMD => GetString("MBMD");
	}
}
// EOF
