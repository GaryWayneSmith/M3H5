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

namespace M3H5Lib.Api.CMS009MI
{
	public partial class LstXmlElementsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Printer file
		/// FieldName: PRTF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer file")]
		public string M3_PRTF => GetString("PRTF");

		/// <summary>
		/// Description: XML structure
		/// FieldName: RPLY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("XML structure")]
		public string M3_RPLY => GetString("RPLY");

		/// <summary>
		/// Description: XML section
		/// FieldName: RPBK
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("XML section")]
		public int? M3_RPBK => GetNullableInt("RPBK");

		/// <summary>
		/// Description: Element sequence number
		/// FieldName: ESEQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Element sequence number")]
		public int? M3_ESEQ => GetNullableInt("ESEQ");

		/// <summary>
		/// Description: Element type
		/// FieldName: ELNT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Element type")]
		public int? M3_ELNT => GetNullableInt("ELNT");

		/// <summary>
		/// Description: Source of data
		/// FieldName: BDAT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Source of data")]
		public int? M3_BDAT => GetNullableInt("BDAT");

		/// <summary>
		/// Description: Data type
		/// FieldName: DTTY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data type")]
		public int? M3_DTTY => GetNullableInt("DTTY");

		/// <summary>
		/// Description: Update at report run
		/// FieldName: UCON
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update at report run")]
		public int? M3_UCON => GetNullableInt("UCON");

		/// <summary>
		/// Description: Specific value
		/// FieldName: SPEV
		/// FieldType: A
		/// Length: 100
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific value")]
		public string M3_SPEV => GetString("SPEV");

		/// <summary>
		/// Description: Field
		/// FieldName: OBJC
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OBJC => GetString("OBJC");

		/// <summary>
		/// Description: XML section
		/// FieldName: RPB2
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("XML section")]
		public int? M3_RPB2 => GetNullableInt("RPB2");

		/// <summary>
		/// Description: File
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FILE => GetString("FILE");

		/// <summary>
		/// Description: Configuration component
		/// FieldName: COCO
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration component")]
		public string M3_COCO => GetString("COCO");

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
		/// Description: Element name
		/// FieldName: ELNM
		/// FieldType: A
		/// Length: 70
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Element name")]
		public string M3_ELNM => GetString("ELNM");

		/// <summary>
		/// Description: Label
		/// FieldName: LAIC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Label")]
		public int? M3_LAIC => GetNullableInt("LAIC");

		/// <summary>
		/// Description: Overriding message ID
		/// FieldName: OVM7
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overriding message ID")]
		public string M3_OVM7 => GetString("OVM7");

		/// <summary>
		/// Description: Message file
		/// FieldName: MSGF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message file")]
		public string M3_MSGF => GetString("MSGF");

		/// <summary>
		/// Description: Overriding name
		/// FieldName: OVNM
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overriding name")]
		public string M3_OVNM => GetString("OVNM");
	}
}
// EOF
