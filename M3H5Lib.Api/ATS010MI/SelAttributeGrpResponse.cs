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

namespace M3H5Lib.Api.ATS010MI
{
	public partial class SelAttributeGrpResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Attribute ID
		/// FieldName: ATID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute ID")]
		public string M3_ATID => GetString("ATID");

		/// <summary>
		/// Description: Attribute type
		/// FieldName: ATVC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute type")]
		public string M3_ATVC => GetString("ATVC");

		/// <summary>
		/// Description: Description
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX30 => GetString("TX30");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Attribute group
		/// FieldName: ATGR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute group")]
		public string M3_ATGR => GetString("ATGR");

		/// <summary>
		/// Description: Controlling object
		/// FieldName: COBT
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Controlling object")]
		public int? M3_COBT => GetNullableInt("COBT");

		/// <summary>
		/// Description: Man chg allowed
		/// FieldName: MCAL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Man chg allowed")]
		public int? M3_MCAL => GetNullableInt("MCAL");

		/// <summary>
		/// Description: Print attribute value
		/// FieldName: PRII
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print attribute value")]
		public int? M3_PRII => GetNullableInt("PRII");

		/// <summary>
		/// Description: Print attribute info
		/// FieldName: PRFI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print attribute info")]
		public int? M3_PRFI => GetNullableInt("PRFI");

		/// <summary>
		/// Description: Print on new line
		/// FieldName: PRNL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print on new line")]
		public int? M3_PRNL => GetNullableInt("PRNL");

		/// <summary>
		/// Description: Print separator
		/// FieldName: PSEP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print separator")]
		public string M3_PSEP => GetString("PSEP");

		/// <summary>
		/// Description: Print separator prefix
		/// FieldName: PSPR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print separator prefix")]
		public string M3_PSPR => GetString("PSPR");

		/// <summary>
		/// Description: Print separator suffix
		/// FieldName: PSES
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print separator suffix")]
		public string M3_PSES => GetString("PSES");

		/// <summary>
		/// Description: Basic UM
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic UM")]
		public string M3_UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3_DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Item attribute
		/// FieldName: IATT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item attribute")]
		public int? M3_IATT => GetNullableInt("IATT");

		/// <summary>
		/// Description: Multiple attribute values
		/// FieldName: MUAV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple attribute values")]
		public int? M3_MUAV => GetNullableInt("MUAV");

		/// <summary>
		/// Description: Attribute classification
		/// FieldName: ATCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute classification")]
		public int? M3_ATCL => GetNullableInt("ATCL");

		/// <summary>
		/// Description: Allow blanks
		/// FieldName: ALBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow blanks")]
		public int? M3_ALBA => GetNullableInt("ALBA");

		/// <summary>
		/// Description: Quality controlled
		/// FieldName: QLCT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quality controlled")]
		public int? M3_QLCT => GetNullableInt("QLCT");
	}
}
// EOF
