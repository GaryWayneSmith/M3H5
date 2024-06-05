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

namespace M3H5Lib.Api.EXPORTMI
{
	public partial class LstFieldsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Field name
		/// FieldName: FLDN
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field name")]
		public string M3FLDN => GetString("FLDN");

		/// <summary>
		/// Description: Field description
		/// FieldName: FLDS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field description")]
		public string M3FLDS => GetString("FLDS");

		/// <summary>
		/// Description: Field type
		/// FieldName: FLTY
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field type")]
		public string M3FLTY => GetString("FLTY");

		/// <summary>
		/// Description: Field length
		/// FieldName: FLLE
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field length")]
		public int? M3FLLE => GetNullableInt("FLLE");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: FLDP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3FLDP => GetNullableInt("FLDP");
	}
}
// EOF
