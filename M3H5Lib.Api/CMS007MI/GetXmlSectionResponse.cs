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

namespace M3H5Lib.Api.CMS007MI
{
	public partial class GetXmlSectionResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Section status
		/// FieldName: XMBS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Section status")]
		public string M3XMBS => GetString("XMBS");

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

		/// <summary>
		/// Description: Section type
		/// FieldName: STYE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Section type")]
		public string M3STYE => GetString("STYE");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SNNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3SNNO => GetNullableInt("SNNO");

		/// <summary>
		/// Description: Section level
		/// FieldName: BLLE
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Section level")]
		public int? M3BLLE => GetNullableInt("BLLE");

		/// <summary>
		/// Description: Empty element
		/// FieldName: EMEL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Empty element")]
		public int? M3EMEL => GetNullableInt("EMEL");

		/// <summary>
		/// Description: Section attribute
		/// FieldName: SATR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Section attribute")]
		public int? M3SATR => GetNullableInt("SATR");

		/// <summary>
		/// Description: Group by element name
		/// FieldName: GRBY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group by element name")]
		public string M3GRBY => GetString("GRBY");

		/// <summary>
		/// Description: Subgroup by element name
		/// FieldName: FGBY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subgroup by element name")]
		public string M3FGBY => GetString("FGBY");
	}
}
// EOF
