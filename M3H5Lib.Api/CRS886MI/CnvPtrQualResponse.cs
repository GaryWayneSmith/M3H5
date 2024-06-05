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

namespace M3H5Lib.Api.CRS886MI
{
	public partial class CnvPtrQualResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Partner alias
		/// FieldName: PAAL
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner alias")]
		public string M3PAAL => GetString("PAAL");

		/// <summary>
		/// Description: Partner alias 1
		/// FieldName: PAA1
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner alias 1")]
		public string M3PAA1 => GetString("PAA1");

		/// <summary>
		/// Description: Partner alias 2
		/// FieldName: PAA2
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner alias 2")]
		public string M3PAA2 => GetString("PAA2");

		/// <summary>
		/// Description: Partner alias qualifier
		/// FieldName: PAAQ
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner alias qualifier")]
		public string M3PAAQ => GetString("PAAQ");

		/// <summary>
		/// Description: Partner alias category
		/// FieldName: PAAC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner alias category")]
		public int? M3PAAC => GetNullableInt("PAAC");

		/// <summary>
		/// Description: Partner ID higher level
		/// FieldName: PAIH
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner ID higher level")]
		public string M3PAIH => GetString("PAIH");
	}
}
// EOF
