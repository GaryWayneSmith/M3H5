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

namespace M3H5Lib.Api.CRSPCIMI
{
	public partial class GetHeadings2Response : M3BaseRecord 
	{

		/// <summary>
		/// Description: Select
		/// FieldName: MS13
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Select")]
		public string M3_MS13 => GetString("MS13");

		/// <summary>
		/// Description: Create quote
		/// FieldName: MS14
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Create quote")]
		public string M3_MS14 => GetString("MS14");

		/// <summary>
		/// Description: Cancel
		/// FieldName: MS15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cancel")]
		public string M3_MS15 => GetString("MS15");

		/// <summary>
		/// Description: Revert
		/// FieldName: MS16
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revert")]
		public string M3_MS16 => GetString("MS16");

		/// <summary>
		/// Description: Save
		/// FieldName: MS17
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Save")]
		public string M3_MS17 => GetString("MS17");

		/// <summary>
		/// Description: Description
		/// FieldName: HE21
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_HE21 => GetString("HE21");

		/// <summary>
		/// Description: Attribute model
		/// FieldName: HE22
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute model")]
		public string M3_HE22 => GetString("HE22");

		/// <summary>
		/// Description: Display cost price
		/// FieldName: HE23
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Display cost price")]
		public string M3_HE23 => GetString("HE23");

		/// <summary>
		/// Description: Display sales price
		/// FieldName: HE24
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Display sales price")]
		public string M3_HE24 => GetString("HE24");

		/// <summary>
		/// Description: Warning - Configuration will be lost
		/// FieldName: MS18
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warning - Configuration will be lost")]
		public string M3_MS18 => GetString("MS18");

		/// <summary>
		/// Description: Confirm
		/// FieldName: MS19
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirm")]
		public string M3_MS19 => GetString("MS19");

		/// <summary>
		/// Description: Configuration summary
		/// FieldName: HE25
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration summary")]
		public string M3_HE25 => GetString("HE25");

		/// <summary>
		/// Description: Attachment indicator
		/// FieldName: HE26
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attachment indicator")]
		public string M3_HE26 => GetString("HE26");

		/// <summary>
		/// Description: Shipless indicator
		/// FieldName: HE27
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipless indicator")]
		public string M3_HE27 => GetString("HE27");

		/// <summary>
		/// Description: Installed
		/// FieldName: HE28
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Installed")]
		public string M3_HE28 => GetString("HE28");

		/// <summary>
		/// Description: Not installed
		/// FieldName: HE29
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Not installed")]
		public string M3_HE29 => GetString("HE29");

		/// <summary>
		/// Description: Detached
		/// FieldName: HE30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detached")]
		public string M3_HE30 => GetString("HE30");

		/// <summary>
		/// Description: Add a new instance of this attribute
		/// FieldName: MS20
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Add a new instance of this attribute")]
		public string M3_MS20 => GetString("MS20");

		/// <summary>
		/// Description: Remove this instance of the attribute
		/// FieldName: MS21
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remove this instance of the attribute")]
		public string M3_MS21 => GetString("MS21");

		/// <summary>
		/// Description: The last instance of an attribute cannot be removed
		/// FieldName: MS22
		/// FieldType: A
		/// Length: 70
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("The last instance of an attribute cannot be removed")]
		public string M3_MS22 => GetString("MS22");

		/// <summary>
		/// Description: Start configuration
		/// FieldName: HE31
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start configuration")]
		public string M3_HE31 => GetString("HE31");

		/// <summary>
		/// Description: Set value
		/// FieldName: HE32
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Set value")]
		public string M3_HE32 => GetString("HE32");

		/// <summary>
		/// Description: Conflict exist
		/// FieldName: HE33
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conflict exist")]
		public string M3_HE33 => GetString("HE33");

		/// <summary>
		/// Description: Add additional value
		/// FieldName: MS23
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Add additional value")]
		public string M3_MS23 => GetString("MS23");

		/// <summary>
		/// Description: Warning - invalid configuration
		/// FieldName: MS24
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warning - invalid configuration")]
		public string M3_MS24 => GetString("MS24");

		/// <summary>
		/// Description: Mandatory option not selected
		/// FieldName: MS25
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mandatory option not selected")]
		public string M3_MS25 => GetString("MS25");
	}
}
// EOF
