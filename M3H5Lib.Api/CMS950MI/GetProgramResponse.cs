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

namespace M3H5Lib.Api.CMS950MI
{
	public partial class GetProgramResponse : M3BaseRecord 
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
		/// Description: Version
		/// FieldName: BEVE
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Version")]
		public int? M3BEVE => GetNullableInt("BEVE");

		/// <summary>
		/// Description: System component
		/// FieldName: SYCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("System component")]
		public string M3SYCO => GetString("SYCO");

		/// <summary>
		/// Description: File
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FILE => GetString("FILE");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SQCE
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3SQCE => GetNullableInt("SQCE");

		/// <summary>
		/// Description: Submit job
		/// FieldName: SBMJ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Submit job")]
		public int? M3SBMJ => GetNullableInt("SBMJ");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Number of records
		/// FieldName: NOR2
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of records")]
		public decimal? M3NOR2 => GetNullableDecimal("NOR2");

		/// <summary>
		/// Description: Number of records read
		/// FieldName: NOR6
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of records read")]
		public decimal? M3NOR6 => GetNullableDecimal("NOR6");

		/// <summary>
		/// Description: Number of records updated
		/// FieldName: NOR3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of records updated")]
		public decimal? M3NOR3 => GetNullableDecimal("NOR3");

		/// <summary>
		/// Description: Number of records written
		/// FieldName: NOR4
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of records written")]
		public decimal? M3NOR4 => GetNullableDecimal("NOR4");

		/// <summary>
		/// Description: Number of records deleted
		/// FieldName: NOR5
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of records deleted")]
		public decimal? M3NOR5 => GetNullableDecimal("NOR5");

		/// <summary>
		/// Description: Migration status
		/// FieldName: MIST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Migration status")]
		public string M3MIST => GetString("MIST");

		/// <summary>
		/// Description: Optional to run
		/// FieldName: OPTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Optional to run")]
		public int? M3OPTR => GetNullableInt("OPTR");

		/// <summary>
		/// Description: Migration log
		/// FieldName: MLOG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Migration log")]
		public int? M3MLOG => GetNullableInt("MLOG");

		/// <summary>
		/// Description: Program dependency
		/// FieldName: RPGM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program dependency")]
		public string M3RPGM => GetString("RPGM");

		/// <summary>
		/// Description: Safe to run several times
		/// FieldName: SFTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safe to run several times")]
		public int? M3SFTR => GetNullableInt("SFTR");

		/// <summary>
		/// Description: Job name
		/// FieldName: JNA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job name")]
		public string M3JNA => GetString("JNA");

		/// <summary>
		/// Description: Job number
		/// FieldName: JNU
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job number")]
		public int? M3JNU => GetNullableInt("JNU");

		/// <summary>
		/// Description: User
		/// FieldName: USS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3USS => GetString("USS");

		/// <summary>
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Start time
		/// FieldName: STTI
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time")]
		public int? M3STTI => GetNullableInt("STTI");

		/// <summary>
		/// Description: Finish date
		/// FieldName: ENDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish date")]
		public DateTime? M3ENDT => GetNullableDateTime("ENDT");

		/// <summary>
		/// Description: Finish time
		/// FieldName: FTIM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish time")]
		public int? M3FTIM => GetNullableInt("FTIM");

		/// <summary>
		/// Description: Active job
		/// FieldName: AJOB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active job")]
		public int? M3AJOB => GetNullableInt("AJOB");
	}
}
// EOF
