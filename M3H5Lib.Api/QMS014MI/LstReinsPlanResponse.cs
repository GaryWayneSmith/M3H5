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

namespace M3H5Lib.Api.QMS014MI
{
	public partial class LstReinsPlanResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Reinspection ID
		/// FieldName: QTID
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinspection ID")]
		public string M3QTID => GetString("QTID");

		/// <summary>
		/// Description: Reinspection sequence
		/// FieldName: QTSQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinspection sequence")]
		public int? M3QTSQ => GetNullableInt("QTSQ");

		/// <summary>
		/// Description: Reinspection days
		/// FieldName: REDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinspection days")]
		public int? M3REDY => GetNullableInt("REDY");

		/// <summary>
		/// Description: Reinspection hours
		/// FieldName: REHR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinspection hours")]
		public int? M3REHR => GetNullableInt("REHR");

		/// <summary>
		/// Description: Reinspection minutes
		/// FieldName: REMN
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinspection minutes")]
		public int? M3REMN => GetNullableInt("REMN");
	}
}
// EOF
