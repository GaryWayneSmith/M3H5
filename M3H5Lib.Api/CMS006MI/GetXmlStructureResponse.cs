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

namespace M3H5Lib.Api.CMS006MI
{
	public partial class GetXmlStructureResponse : M3BaseRecord 
	{

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
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Format
		/// FieldName: XMLF
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Format")]
		public int? M3XMLF => GetNullableInt("XMLF");

		/// <summary>
		/// Description: Variant
		/// FieldName: XMLT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Variant")]
		public int? M3XMLT => GetNullableInt("XMLT");

		/// <summary>
		/// Description: Split XML file
		/// FieldName: SPKY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split XML file")]
		public int? M3SPKY => GetNullableInt("SPKY");

		/// <summary>
		/// Description: Root element
		/// FieldName: RELM
		/// FieldType: A
		/// Length: 100
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Root element")]
		public string M3RELM => GetString("RELM");

		/// <summary>
		/// Description: Default namespace
		/// FieldName: NMSP
		/// FieldType: A
		/// Length: 100
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default namespace")]
		public string M3NMSP => GetString("NMSP");

		/// <summary>
		/// Description: Namespace 1
		/// FieldName: NMS1
		/// FieldType: A
		/// Length: 100
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Namespace 1")]
		public string M3NMS1 => GetString("NMS1");

		/// <summary>
		/// Description: Prefix for namespace 1
		/// FieldName: PRE1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prefix for namespace 1")]
		public string M3PRE1 => GetString("PRE1");

		/// <summary>
		/// Description: Schema namespace
		/// FieldName: SCNP
		/// FieldType: A
		/// Length: 100
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Schema namespace")]
		public string M3SCNP => GetString("SCNP");

		/// <summary>
		/// Description: Schema
		/// FieldName: SCHM
		/// FieldType: A
		/// Length: 100
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Schema")]
		public string M3SCHM => GetString("SCHM");

		/// <summary>
		/// Description: Element name
		/// FieldName: ELNM
		/// FieldType: A
		/// Length: 70
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Element name")]
		public string M3ELNM => GetString("ELNM");
	}
}
// EOF
