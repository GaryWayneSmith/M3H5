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

namespace M3H5Lib.Api.PDS055MI
{
	public partial class ListResponse : M3BaseRecord 
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
		public int? M3_CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Feature
		/// FieldName: FTID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3_FTID => GetString("FTID");

		/// <summary>
		/// Description: Feature type
		/// FieldName: FTTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature type")]
		public int? M3_FTTP => GetNullableInt("FTTP");

		/// <summary>
		/// Description: Text
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TX30 => GetString("TX30");

		/// <summary>
		/// Description: Text
		/// FieldName: TX10
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TX10 => GetString("TX10");

		/// <summary>
		/// Description: Feature group
		/// FieldName: FGRP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature group")]
		public string M3_FGRP => GetString("FGRP");

		/// <summary>
		/// Description: Feature check
		/// FieldName: FICR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature check")]
		public int? M3_FICR => GetNullableInt("FICR");

		/// <summary>
		/// Description: Option check
		/// FieldName: VAOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option check")]
		public int? M3_VAOP => GetNullableInt("VAOP");

		/// <summary>
		/// Description: Additional feature
		/// FieldName: ADDF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional feature")]
		public int? M3_ADDF => GetNullableInt("ADDF");

		/// <summary>
		/// Description: Print on manufacturing order
		/// FieldName: POMO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print on manufacturing order")]
		public int? M3_POMO => GetNullableInt("POMO");

		/// <summary>
		/// Description: Print control - order document
		/// FieldName: PRED
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print control - order document")]
		public int? M3_PRED => GetNullableInt("PRED");

		/// <summary>
		/// Description: Retreive from previous CO line
		/// FieldName: DCOO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Retreive from previous CO line")]
		public int? M3_DCOO => GetNullableInt("DCOO");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
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
		/// Description: Numeric range multiple
		/// FieldName: NRMU
		/// FieldType: A
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric range multiple")]
		public string M3_NRMU => GetString("NRMU");

		/// <summary>
		/// Description: From numeric range value
		/// FieldName: NUVF
		/// FieldType: A
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From numeric range value")]
		public string M3_NUVF => GetString("NUVF");

		/// <summary>
		/// Description: To numeric range value
		/// FieldName: NUVT
		/// FieldType: A
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To numeric range value")]
		public string M3_NUVT => GetString("NUVT");

		/// <summary>
		/// Description: Bill of material group
		/// FieldName: GRPF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bill of material group")]
		public int? M3_GRPF => GetNullableInt("GRPF");

		/// <summary>
		/// Description: Item group
		/// FieldName: ITGF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group")]
		public string M3_ITGF => GetString("ITGF");

		/// <summary>
		/// Description: Item group
		/// FieldName: ITGT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group")]
		public string M3_ITGT => GetString("ITGT");

		/// <summary>
		/// Description: Product Group
		/// FieldName: ITCF
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product Group")]
		public string M3_ITCF => GetString("ITCF");

		/// <summary>
		/// Description: Product Group
		/// FieldName: ITCT
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product Group")]
		public string M3_ITCT => GetString("ITCT");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3_ATID => GetString("ATID");

		/// <summary>
		/// Description: Print feature information
		/// FieldName: PRFI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print feature information")]
		public int? M3_PRFI => GetNullableInt("PRFI");

		/// <summary>
		/// Description: Print option information
		/// FieldName: PRII
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print option information")]
		public int? M3_PRII => GetNullableInt("PRII");

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
	}
}
// EOF
