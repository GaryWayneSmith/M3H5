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

namespace M3H5Lib.Api.PDS600MI
{
	public partial class OptionRequestResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Feature type
		/// FieldName: FTTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature type")]
		public string M3FTTP => GetString("FTTP");

		/// <summary>
		/// Description: Alph. Option (Item no. for FTTP = 2)
		/// FieldName: OPTN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alph. Option (Item no. for FTTP = 2)")]
		public string M3OPTN => GetString("OPTN");

		/// <summary>
		/// Description: Operation des. (Item des. for FTTP = 2)
		/// FieldName: OPDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation des. (Item des. for FTTP = 2)")]
		public string M3OPDS => GetString("OPDS");

		/// <summary>
		/// Description: (Feature type 3) From value, 6 Decimals
		/// FieldName: NUVF
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("(Feature type 3) From value, 6 Decimals")]
		public string M3NUVF => GetString("NUVF");

		/// <summary>
		/// Description: (Feature type 3) To value, 6 Decimals
		/// FieldName: NUVT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("(Feature type 3) To value, 6 Decimals")]
		public string M3NUVT => GetString("NUVT");

		/// <summary>
		/// Description: Unit of measurement (Feature type 3 & 4)
		/// FieldName: UNIT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit of measurement (Feature type 3 & 4)")]
		public string M3UNIT => GetString("UNIT");

		/// <summary>
		/// Description: Numeric range multiple
		/// FieldName: NRMU
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric range multiple")]
		public int? M3NRMU => GetNullableInt("NRMU");

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
		/// Description: RGB-code blue
		/// FieldName: RGBG
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("RGB-code blue")]
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
		/// Description: Picture Id
		/// FieldName: PINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picture Id")]
		public string M3PINO => GetString("PINO");

		/// <summary>
		/// Description: Numeric range multiple
		/// FieldName: NRM1
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric range multiple")]
		public string M3NRM1 => GetString("NRM1");
	}
}
// EOF
