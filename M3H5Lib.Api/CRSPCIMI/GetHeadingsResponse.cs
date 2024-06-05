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

namespace M3H5Lib.Api.CRSPCIMI
{
	public partial class GetHeadingsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Description
		/// FieldName: HE01
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3HE01 => GetString("HE01");

		/// <summary>
		/// Description: Description
		/// FieldName: HE02
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3HE02 => GetString("HE02");

		/// <summary>
		/// Description: Description
		/// FieldName: HE03
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3HE03 => GetString("HE03");

		/// <summary>
		/// Description: Description
		/// FieldName: HE04
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3HE04 => GetString("HE04");

		/// <summary>
		/// Description: Text
		/// FieldName: HE05
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3HE05 => GetString("HE05");

		/// <summary>
		/// Description: Text
		/// FieldName: HE06
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3HE06 => GetString("HE06");

		/// <summary>
		/// Description: Text
		/// FieldName: HE07
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3HE07 => GetString("HE07");

		/// <summary>
		/// Description: Text
		/// FieldName: HE08
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3HE08 => GetString("HE08");

		/// <summary>
		/// Description: Text
		/// FieldName: HE09
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3HE09 => GetString("HE09");

		/// <summary>
		/// Description: Description
		/// FieldName: HE10
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3HE10 => GetString("HE10");

		/// <summary>
		/// Description: Description
		/// FieldName: MS01
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3MS01 => GetString("MS01");

		/// <summary>
		/// Description: Description
		/// FieldName: MS02
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3MS02 => GetString("MS02");

		/// <summary>
		/// Description: Description
		/// FieldName: MS03
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3MS03 => GetString("MS03");

		/// <summary>
		/// Description: Text
		/// FieldName: HE11
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3HE11 => GetString("HE11");

		/// <summary>
		/// Description: Text
		/// FieldName: HE12
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3HE12 => GetString("HE12");

		/// <summary>
		/// Description: Text
		/// FieldName: HE13
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3HE13 => GetString("HE13");

		/// <summary>
		/// Description: Text
		/// FieldName: HE14
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3HE14 => GetString("HE14");

		/// <summary>
		/// Description: Name
		/// FieldName: HE15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3HE15 => GetString("HE15");

		/// <summary>
		/// Description: Name
		/// FieldName: HE16
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3HE16 => GetString("HE16");

		/// <summary>
		/// Description: Name
		/// FieldName: HE17
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3HE17 => GetString("HE17");

		/// <summary>
		/// Description: Name
		/// FieldName: HE18
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3HE18 => GetString("HE18");

		/// <summary>
		/// Description: Name
		/// FieldName: HE19
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3HE19 => GetString("HE19");

		/// <summary>
		/// Description: Name
		/// FieldName: HE20
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3HE20 => GetString("HE20");

		/// <summary>
		/// Description: Text
		/// FieldName: MS04
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3MS04 => GetString("MS04");

		/// <summary>
		/// Description: Name
		/// FieldName: ITN1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITN1 => GetString("ITN1");

		/// <summary>
		/// Description: Name
		/// FieldName: ITD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITD1 => GetString("ITD1");

		/// <summary>
		/// Description: Name
		/// FieldName: FUD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3FUD1 => GetString("FUD1");

		/// <summary>
		/// Description: Name
		/// FieldName: CUC1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3CUC1 => GetString("CUC1");

		/// <summary>
		/// Description: Name
		/// FieldName: PRD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3PRD1 => GetString("PRD1");

		/// <summary>
		/// Description: Name
		/// FieldName: SAP1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3SAP1 => GetString("SAP1");

		/// <summary>
		/// Description: Name
		/// FieldName: LOS1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3LOS1 => GetString("LOS1");

		/// <summary>
		/// Description: Name
		/// FieldName: ANU1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ANU1 => GetString("ANU1");

		/// <summary>
		/// Description: Name
		/// FieldName: ANU2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ANU2 => GetString("ANU2");

		/// <summary>
		/// Description: Name
		/// FieldName: TGN1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TGN1 => GetString("TGN1");

		/// <summary>
		/// Description: Name
		/// FieldName: NRM1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3NRM1 => GetString("NRM1");

		/// <summary>
		/// Description: Name
		/// FieldName: DCC1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3DCC1 => GetString("DCC1");

		/// <summary>
		/// Description: Name
		/// FieldName: UCO1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3UCO1 => GetString("UCO1");

		/// <summary>
		/// Description: Product Group
		/// FieldName: MS05
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product Group")]
		public string M3MS05 => GetString("MS05");

		/// <summary>
		/// Description: Model
		/// FieldName: MS06
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Model")]
		public string M3MS06 => GetString("MS06");

		/// <summary>
		/// Description: Item
		/// FieldName: MS07
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item")]
		public string M3MS07 => GetString("MS07");

		/// <summary>
		/// Description: Configure
		/// FieldName: MS08
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configure")]
		public string M3MS08 => GetString("MS08");

		/// <summary>
		/// Description: Select product group
		/// FieldName: MS09
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Select product group")]
		public string M3MS09 => GetString("MS09");

		/// <summary>
		/// Description: Select model
		/// FieldName: MS10
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Select model")]
		public string M3MS10 => GetString("MS10");

		/// <summary>
		/// Description: Select item
		/// FieldName: MS11
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Select item")]
		public string M3MS11 => GetString("MS11");

		/// <summary>
		/// Description: Back
		/// FieldName: MS12
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Back")]
		public string M3MS12 => GetString("MS12");
	}
}
// EOF
