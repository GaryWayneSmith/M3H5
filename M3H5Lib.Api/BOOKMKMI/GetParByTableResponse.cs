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

namespace M3H5Lib.Api.BOOKMKMI
{
	public partial class GetParByTableResponse : M3BaseRecord 
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
		/// Description: Key field 1
		/// FieldName: KF01
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 1")]
		public string M3KF01 => GetString("KF01");

		/// <summary>
		/// Description: Key field 2
		/// FieldName: KF02
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 2")]
		public string M3KF02 => GetString("KF02");

		/// <summary>
		/// Description: Key field 3
		/// FieldName: KF03
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 3")]
		public string M3KF03 => GetString("KF03");

		/// <summary>
		/// Description: Key field 4
		/// FieldName: KF04
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 4")]
		public string M3KF04 => GetString("KF04");

		/// <summary>
		/// Description: Key field 5
		/// FieldName: KF05
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 5")]
		public string M3KF05 => GetString("KF05");

		/// <summary>
		/// Description: Key field 6
		/// FieldName: KF06
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 6")]
		public string M3KF06 => GetString("KF06");

		/// <summary>
		/// Description: Key field 7
		/// FieldName: KF07
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 7")]
		public string M3KF07 => GetString("KF07");

		/// <summary>
		/// Description: Key field 8
		/// FieldName: KF08
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 8")]
		public string M3KF08 => GetString("KF08");

		/// <summary>
		/// Description: Key field 9
		/// FieldName: KF09
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 9")]
		public string M3KF09 => GetString("KF09");

		/// <summary>
		/// Description: Key field 10
		/// FieldName: KF10
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 10")]
		public string M3KF10 => GetString("KF10");

		/// <summary>
		/// Description: Key field 11
		/// FieldName: KF11
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 11")]
		public string M3KF11 => GetString("KF11");

		/// <summary>
		/// Description: Key field 12
		/// FieldName: KF12
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 12")]
		public string M3KF12 => GetString("KF12");

		/// <summary>
		/// Description: Key field 13
		/// FieldName: KF13
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 13")]
		public string M3KF13 => GetString("KF13");

		/// <summary>
		/// Description: Key field 14
		/// FieldName: KF14
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 14")]
		public string M3KF14 => GetString("KF14");

		/// <summary>
		/// Description: Key field 15
		/// FieldName: KF15
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 15")]
		public string M3KF15 => GetString("KF15");

		/// <summary>
		/// Description: Key field 16
		/// FieldName: KF16
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field 16")]
		public string M3KF16 => GetString("KF16");

		/// <summary>
		/// Description: Allowed panel sequence
		/// FieldName: APSQ
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allowed panel sequence")]
		public string M3APSQ => GetString("APSQ");
	}
}
// EOF
