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

namespace M3H5Lib.Api.CRS886MI
{
	public partial class CnvPtrAliasQualResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Partner ID
		/// FieldName: PAID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner ID")]
		public string M3PAID => GetString("PAID");

		/// <summary>
		/// Description: Partner ID sublevel 1
		/// FieldName: PAI1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner ID sublevel 1")]
		public string M3PAI1 => GetString("PAI1");

		/// <summary>
		/// Description: Partner ID sublevel 2
		/// FieldName: PAI2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner ID sublevel 2")]
		public string M3PAI2 => GetString("PAI2");

		/// <summary>
		/// Description: Partner category
		/// FieldName: PCTG
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner category")]
		public int? M3PCTG => GetNullableInt("PCTG");

		/// <summary>
		/// Description: Partner qualifier
		/// FieldName: PAQU
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner qualifier")]
		public string M3PAQU => GetString("PAQU");

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
