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

namespace M3H5Lib.Api.MOS256MI
{
	public partial class LstAsBuildResponse : M3BaseRecord 
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
		/// Description: Component identity
		/// FieldName: MTRL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component identity")]
		public string M3MTRL => GetString("MTRL");

		/// <summary>
		/// Description: Serial number
		/// FieldName: SERN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SERN => GetString("SERN");

		/// <summary>
		/// Description: Configuration position
		/// FieldName: CFGL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration position")]
		public string M3CFGL => GetString("CFGL");

		/// <summary>
		/// Description: Position Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Position Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Serial number
		/// FieldName: SER2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SER2 => GetString("SER2");

		/// <summary>
		/// Description: Item Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Not known
		/// FieldName: NOTK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Not known")]
		public int? M3NOTK => GetNullableInt("NOTK");

		/// <summary>
		/// Description: Concession number
		/// FieldName: EXNO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Concession number")]
		public string M3EXNO => GetString("EXNO");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: Number of units for config position
		/// FieldName: NUCP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of units for config position")]
		public int? M3NUCP => GetNullableInt("NUCP");

		/// <summary>
		/// Description: Item/serial number code
		/// FieldName: FEMP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item/serial number code")]
		public string M3FEMP => GetString("FEMP");

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
		/// Description: Engine
		/// FieldName: ENGI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Engine")]
		public int? M3ENGI => GetNullableInt("ENGI");

		/// <summary>
		/// Description: Meter 1
		/// FieldName: MES1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 1")]
		public string M3MES1 => GetString("MES1");

		/// <summary>
		/// Description: Meter value 1
		/// FieldName: MVA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 1")]
		public decimal? M3MVA1 => GetNullableDecimal("MVA1");

		/// <summary>
		/// Description: Meter 2
		/// FieldName: MES2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 2")]
		public string M3MES2 => GetString("MES2");

		/// <summary>
		/// Description: Meter value 2
		/// FieldName: MVA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 2")]
		public decimal? M3MVA2 => GetNullableDecimal("MVA2");

		/// <summary>
		/// Description: Meter 3
		/// FieldName: MES3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 3")]
		public string M3MES3 => GetString("MES3");

		/// <summary>
		/// Description: Meter value 3
		/// FieldName: MVA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 3")]
		public decimal? M3MVA3 => GetNullableDecimal("MVA3");

		/// <summary>
		/// Description: Meter 4
		/// FieldName: MES4
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 4")]
		public string M3MES4 => GetString("MES4");

		/// <summary>
		/// Description: Meter value 4
		/// FieldName: MVA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 4")]
		public decimal? M3MVA4 => GetNullableDecimal("MVA4");

		/// <summary>
		/// Description: Lower level exist
		/// FieldName: PLUS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lower level exist")]
		public string M3PLUS => GetString("PLUS");

		/// <summary>
		/// Description: Equipment type
		/// FieldName: EQTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment type")]
		public string M3EQTP => GetString("EQTP");

		/// <summary>
		/// Description: Sales model
		/// FieldName: ASLM
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales model")]
		public string M3ASLM => GetString("ASLM");

		/// <summary>
		/// Description: Manufacturer
		/// FieldName: PROD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturer")]
		public string M3PROD => GetString("PROD");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3SUNM => GetString("SUNM");
	}
}
// EOF
