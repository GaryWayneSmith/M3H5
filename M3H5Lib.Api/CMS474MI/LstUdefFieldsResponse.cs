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

namespace M3H5Lib.Api.CMS474MI
{
	public partial class LstUdefFieldsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Item group
		/// FieldName: ITGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group")]
		public string M3_ITGR => GetString("ITGR");

		/// <summary>
		/// Description: Supplier group
		/// FieldName: SUCL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier group")]
		public string M3_SUCL => GetString("SUCL");

		/// <summary>
		/// Description: Field group
		/// FieldName: CFMG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field group")]
		public string M3_CFMG => GetString("CFMG");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

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
		/// Description: Heading
		/// FieldName: CFML
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Heading")]
		public string M3_CFML => GetString("CFML");

		/// <summary>
		/// Description: Field type
		/// FieldName: FLDM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field type")]
		public string M3_FLDM => GetString("FLDM");

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
		/// Description: Decimals
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimals")]
		public int? M3_DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Meter
		/// FieldName: MES0
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter")]
		public string M3_MES0 => GetString("MES0");

		/// <summary>
		/// Description: Filed
		/// FieldName: CFMF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filed")]
		public string M3_CFMF => GetString("CFMF");
	}
}
// EOF