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

namespace M3H5Lib.Api.EVS001MI
{
	public partial class LstLogFilesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Names of found files
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 120
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Names of found files")]
		public string M3FILE => GetString("FILE");

		/// <summary>
		/// Description: Host name
		/// FieldName: HOST
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Host name")]
		public string M3HOST => GetString("HOST");

		/// <summary>
		/// Description: Folder
		/// FieldName: A120
		/// FieldType: A
		/// Length: 120
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Folder")]
		public string M3A120 => GetString("A120");

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
		/// Description: Actual length
		/// FieldName: ACTU
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual length")]
		public decimal? M3ACTU => GetNullableDecimal("ACTU");
	}
}
// EOF
