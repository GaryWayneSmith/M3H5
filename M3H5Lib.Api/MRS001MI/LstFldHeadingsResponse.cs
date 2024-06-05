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

namespace M3H5Lib.Api.MRS001MI
{
	public partial class LstFldHeadingsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Field name
		/// FieldName: FLNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field name")]
		public string M3FLNM => GetString("FLNM");

		/// <summary>
		/// Description: Description in repository
		/// FieldName: FLDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description in repository")]
		public string M3FLDS => GetString("FLDS");

		/// <summary>
		/// Description: General Word
		/// FieldName: MSI5
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("General Word")]
		public string M3MSI5 => GetString("MSI5");

		/// <summary>
		/// Description: Text length 3
		/// FieldName: TX03
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text length 3")]
		public string M3TX03 => GetString("TX03");

		/// <summary>
		/// Description: Text length 5
		/// FieldName: TX05
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text length 5")]
		public string M3TX05 => GetString("TX05");

		/// <summary>
		/// Description: Text length 10
		/// FieldName: TX10
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text length 10")]
		public string M3TX10 => GetString("TX10");

		/// <summary>
		/// Description: Text length 15
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text length 15")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Text length 40 (AA)
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text length 40 (AA)")]
		public string M3TX40 => GetString("TX40");
	}
}
// EOF
