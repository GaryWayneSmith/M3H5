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

namespace M3H5Lib.Api.CRS230MI
{
	public partial class GetDocTypeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Document type
		/// FieldName: DOTY
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document type")]
		public string M3_DOTY => GetString("DOTY");

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
		/// Description: Number series
		/// FieldName: NBID
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number series")]
		public string M3_NBID => GetString("NBID");

		/// <summary>
		/// Description: Document template
		/// FieldName: DTEM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document template")]
		public string M3_DTEM => GetString("DTEM");

		/// <summary>
		/// Description: Modification document
		/// FieldName: MDOC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Modification document")]
		public int? M3_MDOC => GetNullableInt("MDOC");

		/// <summary>
		/// Description: Document deletion permitted
		/// FieldName: DDEL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document deletion permitted")]
		public int? M3_DDEL => GetNullableInt("DDEL");

		/// <summary>
		/// Description: Document identity method
		/// FieldName: DIDM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity method")]
		public int? M3_DIDM => GetNullableInt("DIDM");

		/// <summary>
		/// Description: Document revision permitted
		/// FieldName: DSIR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document revision permitted")]
		public int? M3_DSIR => GetNullableInt("DSIR");

		/// <summary>
		/// Description: Authority document
		/// FieldName: DAUT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authority document")]
		public int? M3_DAUT => GetNullableInt("DAUT");

		/// <summary>
		/// Description: Document issuer code
		/// FieldName: DINT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document issuer code")]
		public int? M3_DINT => GetNullableInt("DINT");

		/// <summary>
		/// Description: Document reference level
		/// FieldName: DREF
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document reference level")]
		public int? M3_DREF => GetNullableInt("DREF");

		/// <summary>
		/// Description: Approve activity
		/// FieldName: AARE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approve activity")]
		public int? M3_AARE => GetNullableInt("AARE");
	}
}
// EOF
