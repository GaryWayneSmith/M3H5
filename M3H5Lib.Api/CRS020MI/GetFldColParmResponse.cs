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

namespace M3H5Lib.Api.CRS020MI
{
	public partial class GetFldColParmResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Program name
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3PGNM => GetString("PGNM");

		/// <summary>
		/// Description: Panel
		/// FieldName: PIC1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel")]
		public string M3PIC1 => GetString("PIC1");

		/// <summary>
		/// Description: Sort
		/// FieldName: SRTU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sort")]
		public int? M3SRTU => GetNullableInt("SRTU");

		/// <summary>
		/// Description: Sum
		/// FieldName: SUMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sum")]
		public int? M3SUMA => GetNullableInt("SUMA");

		/// <summary>
		/// Description: Max value used
		/// FieldName: MAXU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max value used")]
		public int? M3MAXU => GetNullableInt("MAXU");

		/// <summary>
		/// Description: Override used
		/// FieldName: OVRR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Override used")]
		public int? M3OVRR => GetNullableInt("OVRR");

		/// <summary>
		/// Description: Responsible active for panel versions
		/// FieldName: REAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible active for panel versions")]
		public int? M3REAC => GetNullableInt("REAC");

		/// <summary>
		/// Description: Max panel version length
		/// FieldName: MPVL
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max panel version length")]
		public int? M3MPVL => GetNullableInt("MPVL");
	}
}
// EOF
