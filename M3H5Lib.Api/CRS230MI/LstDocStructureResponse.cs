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

namespace M3H5Lib.Api.CRS230MI
{
	public partial class LstDocStructureResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Document identity
		/// FieldName: DOID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3DOID => GetString("DOID");

		/// <summary>
		/// Description: Subdocument
		/// FieldName: SUID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subdocument")]
		public string M3SUID => GetString("SUID");

		/// <summary>
		/// Description: From revision number
		/// FieldName: FECV
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From revision number")]
		public string M3FECV => GetString("FECV");

		/// <summary>
		/// Description: To revision number
		/// FieldName: TECV
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To revision number")]
		public string M3TECV => GetString("TECV");

		/// <summary>
		/// Description: Remark
		/// FieldName: REMK
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3REMK => GetString("REMK");

		/// <summary>
		/// Description: Document type
		/// FieldName: DOTY
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document type")]
		public string M3DOTY => GetString("DOTY");

		/// <summary>
		/// Description: Document issuer
		/// FieldName: AISB
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document issuer")]
		public string M3AISB => GetString("AISB");

		/// <summary>
		/// Description: Document
		/// FieldName: DNUM
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document")]
		public string M3DNUM => GetString("DNUM");

		/// <summary>
		/// Description: Document object
		/// FieldName: ADOB
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document object")]
		public string M3ADOB => GetString("ADOB");
	}
}
// EOF
