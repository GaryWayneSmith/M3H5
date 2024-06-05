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

namespace M3H5Lib.Api.ECS300MI
{
	public partial class LstOpResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3STRT => GetString("STRT");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Revision number
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3ECVE => GetString("ECVE");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Work center
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3PLGR => GetString("PLGR");

		/// <summary>
		/// Description: Operation description
		/// FieldName: OPDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation description")]
		public string M3OPDS => GetString("OPDS");

		/// <summary>
		/// Description: Text line 1
		/// FieldName: TXT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 1")]
		public string M3TXT1 => GetString("TXT1");

		/// <summary>
		/// Description: Text line 2
		/// FieldName: TXT2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 2")]
		public string M3TXT2 => GetString("TXT2");

		/// <summary>
		/// Description: Document identity
		/// FieldName: DOID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3DOID => GetString("DOID");

		/// <summary>
		/// Description: Fixed time
		/// FieldName: FXTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed time")]
		public int? M3FXTI => GetNullableInt("FXTI");

		/// <summary>
		/// Description: Setup time
		/// FieldName: SETI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time")]
		public int? M3SETI => GetNullableInt("SETI");

		/// <summary>
		/// Description: Run time
		/// FieldName: PITI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time")]
		public int? M3PITI => GetNullableInt("PITI");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Tool number
		/// FieldName: TOOL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool number")]
		public string M3TOOL => GetString("TOOL");

		/// <summary>
		/// Description: Transport value in days
		/// FieldName: SLAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport value in days")]
		public decimal? M3SLAC => GetNullableDecimal("SLAC");

		/// <summary>
		/// Description: Production days
		/// FieldName: PRDY
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production days")]
		public int? M3PRDY => GetNullableInt("PRDY");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: OEM hours
		/// FieldName: RUNO
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM hours")]
		public int? M3RUNO => GetNullableInt("RUNO");

		/// <summary>
		/// Description: Price hours
		/// FieldName: RUNP
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price hours")]
		public int? M3RUNP => GetNullableInt("RUNP");

		/// <summary>
		/// Description: Target hours
		/// FieldName: RUNT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Target hours")]
		public int? M3RUNT => GetNullableInt("RUNT");

		/// <summary>
		/// Description: Multiplication factor - manufacturing
		/// FieldName: MFPR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiplication factor - manufacturing")]
		public int? M3MFPR => GetNullableInt("MFPR");

		/// <summary>
		/// Description: Operation cost multiplier
		/// FieldName: OPCM
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation cost multiplier")]
		public int? M3OPCM => GetNullableInt("OPCM");

		/// <summary>
		/// Description: Number of labor tickets
		/// FieldName: CAMP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of labor tickets")]
		public int? M3CAMP => GetNullableInt("CAMP");

		/// <summary>
		/// Description: Structure sequence number
		/// FieldName: STSQ
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure sequence number")]
		public long? M3STSQ => GetNullableLong("STSQ");
	}
}
// EOF
