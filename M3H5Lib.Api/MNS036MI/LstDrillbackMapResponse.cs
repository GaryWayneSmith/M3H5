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

namespace M3H5Lib.Api.MNS036MI
{
	public partial class LstDrillbackMapResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Infor Drillback View ID
		/// FieldName: IDVI
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Infor Drillback View ID")]
		public string M3IDVI => GetString("IDVI");

		/// <summary>
		/// Description: User
		/// FieldName: USID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3USID => GetString("USID");

		/// <summary>
		/// Description: Manually created
		/// FieldName: MCRT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manually created")]
		public int? M3MCRT => GetNullableInt("MCRT");

		/// <summary>
		/// Description: Browse program
		/// FieldName: BPG1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Browse program")]
		public string M3BPG1 => GetString("BPG1");

		/// <summary>
		/// Description: Opening panel
		/// FieldName: SPIC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Opening panel")]
		public string M3SPIC => GetString("SPIC");

		/// <summary>
		/// Description: Option
		/// FieldName: RELO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3RELO => GetString("RELO");

		/// <summary>
		/// Description: Mashup
		/// FieldName: MASH
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mashup")]
		public string M3MASH => GetString("MASH");

		/// <summary>
		/// Description: Application
		/// FieldName: MAON
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application")]
		public string M3MAON => GetString("MAON");

		/// <summary>
		/// Description: Default values
		/// FieldName: MDEV
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default values")]
		public string M3MDEV => GetString("MDEV");

		/// <summary>
		/// Description: Browse program
		/// FieldName: BPG2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Browse program")]
		public string M3BPG2 => GetString("BPG2");

		/// <summary>
		/// Description: Opening panel
		/// FieldName: SPI3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Opening panel")]
		public string M3SPI3 => GetString("SPI3");

		/// <summary>
		/// Description: Option
		/// FieldName: REL2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3REL2 => GetString("REL2");

		/// <summary>
		/// Description: Mashup
		/// FieldName: MAS2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mashup")]
		public string M3MAS2 => GetString("MAS2");

		/// <summary>
		/// Description: Application
		/// FieldName: MAO2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application")]
		public string M3MAO2 => GetString("MAO2");

		/// <summary>
		/// Description: Default values
		/// FieldName: MDE2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default values")]
		public string M3MDE2 => GetString("MDE2");

		/// <summary>
		/// Description: Browse program
		/// FieldName: BPG3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Browse program")]
		public string M3BPG3 => GetString("BPG3");

		/// <summary>
		/// Description: Opening panel
		/// FieldName: SPI4
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Opening panel")]
		public string M3SPI4 => GetString("SPI4");

		/// <summary>
		/// Description: Option
		/// FieldName: REL3
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3REL3 => GetString("REL3");

		/// <summary>
		/// Description: Mashup
		/// FieldName: MAS3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mashup")]
		public string M3MAS3 => GetString("MAS3");

		/// <summary>
		/// Description: Application
		/// FieldName: MAO3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application")]
		public string M3MAO3 => GetString("MAO3");

		/// <summary>
		/// Description: Default values
		/// FieldName: MDE3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default values")]
		public string M3MDE3 => GetString("MDE3");
	}
}
// EOF
