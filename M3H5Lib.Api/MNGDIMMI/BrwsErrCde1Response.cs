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

namespace M3H5Lib.Api.MNGDIMMI
{
	public partial class BrwsErrCde1Response : M3BaseRecord 
	{

		/// <summary>
		/// Description: Field
		/// FieldName: FLDI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FLDI => GetString("FLDI");

		/// <summary>
		/// Description: Start position for field column
		/// FieldName: FLDC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start position for field column")]
		public string M3_FLDC => GetString("FLDC");

		/// <summary>
		/// Description: Field length
		/// FieldName: FLDB
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field length")]
		public int? M3_FLDB => GetNullableInt("FLDB");

		/// <summary>
		/// Description: Justify right or left
		/// FieldName: FLDJ
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Justify right or left")]
		public string M3_FLDJ => GetString("FLDJ");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEYI
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEYI => GetString("KEYI");

		/// <summary>
		/// Description: Key position
		/// FieldName: KEYP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key position")]
		public string M3_KEYP => GetString("KEYP");

		/// <summary>
		/// Description: General word
		/// FieldName: MSI5
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("General word")]
		public string M3_MSI5 => GetString("MSI5");

		/// <summary>
		/// Description: Message text
		/// FieldName: MS15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text")]
		public string M3_MS15 => GetString("MS15");

		/// <summary>
		/// Description: Message text
		/// FieldName: MS40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text")]
		public string M3_MS40 => GetString("MS40");

		/// <summary>
		/// Description: Message text adjusted to column length
		/// FieldName: MS00
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text adjusted to column length")]
		public string M3_MS00 => GetString("MS00");

		/// <summary>
		/// Description: File
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FILE => GetString("FILE");

		/// <summary>
		/// Description: File key
		/// FieldName: KF01
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File key")]
		public string M3_KF01 => GetString("KF01");

		/// <summary>
		/// Description: File key
		/// FieldName: KF02
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File key")]
		public string M3_KF02 => GetString("KF02");

		/// <summary>
		/// Description: File key
		/// FieldName: KF03
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File key")]
		public string M3_KF03 => GetString("KF03");

		/// <summary>
		/// Description: File key
		/// FieldName: KF04
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File key")]
		public string M3_KF04 => GetString("KF04");

		/// <summary>
		/// Description: File key
		/// FieldName: KF05
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File key")]
		public string M3_KF05 => GetString("KF05");

		/// <summary>
		/// Description: File key
		/// FieldName: KF06
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File key")]
		public string M3_KF06 => GetString("KF06");

		/// <summary>
		/// Description: File key
		/// FieldName: KF07
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File key")]
		public string M3_KF07 => GetString("KF07");

		/// <summary>
		/// Description: Number of filters
		/// FieldName: NFTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of filters")]
		public int? M3_NFTR => GetNullableInt("NFTR");
	}
}
// EOF
