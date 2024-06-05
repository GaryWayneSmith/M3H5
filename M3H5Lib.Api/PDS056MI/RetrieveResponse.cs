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

namespace M3H5Lib.Api.PDS056MI
{
	public partial class RetrieveResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Feature
		/// FieldName: FTID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3FTID => GetString("FTID");

		/// <summary>
		/// Description: Text
		/// FieldName: FTTX
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3FTTX => GetString("FTTX");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SQNU
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3SQNU => GetNullableInt("SQNU");

		/// <summary>
		/// Description: Option
		/// FieldName: OPTN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3OPTN => GetString("OPTN");

		/// <summary>
		/// Description: Text
		/// FieldName: OPTX
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3OPTX => GetString("OPTX");

		/// <summary>
		/// Description: RGB-code red
		/// FieldName: RGBR
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("RGB-code red")]
		public int? M3RGBR => GetNullableInt("RGBR");

		/// <summary>
		/// Description: RGB-code green
		/// FieldName: RGBG
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("RGB-code green")]
		public int? M3RGBG => GetNullableInt("RGBG");

		/// <summary>
		/// Description: RGB-code blue
		/// FieldName: RGBB
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("RGB-code blue")]
		public int? M3RGBB => GetNullableInt("RGBB");

		/// <summary>
		/// Description: Material category
		/// FieldName: MTCT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material category")]
		public string M3MTCT => GetString("MTCT");

		/// <summary>
		/// Description: GUI picture
		/// FieldName: PINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("GUI picture")]
		public string M3PINO => GetString("PINO");

		/// <summary>
		/// Description: Print option information
		/// FieldName: PRII
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print option information")]
		public int? M3PRII => GetNullableInt("PRII");

		/// <summary>
		/// Description: Print separator
		/// FieldName: PSEP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print separator")]
		public string M3PSEP => GetString("PSEP");

		/// <summary>
		/// Description: Print separator prefix
		/// FieldName: PSPR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print separator prefix")]
		public string M3PSPR => GetString("PSPR");

		/// <summary>
		/// Description: Print feature information
		/// FieldName: PRFI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print feature information")]
		public int? M3PRFI => GetNullableInt("PRFI");

		/// <summary>
		/// Description: Print on new line
		/// FieldName: PRNL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print on new line")]
		public int? M3PRNL => GetNullableInt("PRNL");

		/// <summary>
		/// Description: Print separator suffix
		/// FieldName: PSES
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print separator suffix")]
		public string M3PSES => GetString("PSES");
	}
}
// EOF
