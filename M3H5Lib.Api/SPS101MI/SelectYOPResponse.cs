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

namespace M3H5Lib.Api.SPS101MI
{
	public partial class SelectYOPResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: SCP Version
		/// FieldName: SCVE
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SCP Version")]
		public string M3SCVE => GetString("SCVE");

		/// <summary>
		/// Description: Version Category
		/// FieldName: VCAT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Version Category")]
		public string M3VCAT => GetString("VCAT");

		/// <summary>
		/// Description: Transfer Category
		/// FieldName: SCTR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer Category")]
		public string M3SCTR => GetString("SCTR");

		/// <summary>
		/// Description: From Date
		/// FieldName: FRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From Date")]
		public DateTime? M3FRDT => GetNullableDateTime("FRDT");

		/// <summary>
		/// Description: Node
		/// FieldName: NDID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Node")]
		public string M3NDID => GetString("NDID");

		/// <summary>
		/// Description: Node Category
		/// FieldName: NDCA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Node Category")]
		public int? M3NDCA => GetNullableInt("NDCA");

		/// <summary>
		/// Description: To Node
		/// FieldName: TNOD
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To Node")]
		public string M3TNOD => GetString("TNOD");

		/// <summary>
		/// Description: To Node Category
		/// FieldName: TNCA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To Node Category")]
		public int? M3TNCA => GetNullableInt("TNCA");

		/// <summary>
		/// Description: SCP Item Group
		/// FieldName: SCPG
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SCP Item Group")]
		public string M3SCPG => GetString("SCPG");

		/// <summary>
		/// Description: Supply Chain Key
		/// FieldName: SCKE
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply Chain Key")]
		public string M3SCKE => GetString("SCKE");

		/// <summary>
		/// Description: SCP Transfer Category Data
		/// FieldName: SCDA
		/// FieldType: A
		/// Length: 200
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SCP Transfer Category Data")]
		public string M3SCDA => GetString("SCDA");
	}
}
// EOF
