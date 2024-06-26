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

namespace M3H5Lib.Api.BROWSEMI
{
	public partial class GetBrowseParmsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Reference field
		/// FieldName: RFLD
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference field")]
		public string M3RFLD => GetString("RFLD");

		/// <summary>
		/// Description: Browse variant
		/// FieldName: VARI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Browse variant")]
		public string M3VARI => GetString("VARI");

		/// <summary>
		/// Description: Table
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Table")]
		public string M3FILE => GetString("FILE");

		/// <summary>
		/// Description: Field type MUC C=central, L=Local, M=Mixed
		/// FieldName: FTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field type MUC C=central, L=Local, M=Mixed")]
		public string M3FTYP => GetString("FTYP");

		/// <summary>
		/// Description: Selection key ('EQ' / blanks)
		/// FieldName: KYT1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection key ('EQ' / blanks)")]
		public string M3KYT1 => GetString("KYT1");

		/// <summary>
		/// Description: Selection key ('EQ' / blanks)
		/// FieldName: KYT2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection key ('EQ' / blanks)")]
		public string M3KYT2 => GetString("KYT2");

		/// <summary>
		/// Description: Selection key ('EQ' / blanks)
		/// FieldName: KYT3
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection key ('EQ' / blanks)")]
		public string M3KYT3 => GetString("KYT3");

		/// <summary>
		/// Description: Constant - Only CSYTAB
		/// FieldName: CONS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Constant - Only CSYTAB")]
		public string M3CONS => GetString("CONS");

		/// <summary>
		/// Description: Field 1 in browse window
		/// FieldName: KYF1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field 1 in browse window")]
		public string M3KYF1 => GetString("KYF1");

		/// <summary>
		/// Description: Field 2 in browse window
		/// FieldName: KYF2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field 2 in browse window")]
		public string M3KYF2 => GetString("KYF2");

		/// <summary>
		/// Description: Program name
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3PGNM => GetString("PGNM");

		/// <summary>
		/// Description: Return field from prompt program
		/// FieldName: FLDI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return field from prompt program")]
		public string M3FLDI => GetString("FLDI");

		/// <summary>
		/// Description: Blank language - only CSYTAB (0=Language, 1=Blank)
		/// FieldName: BLLD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blank language - only CSYTAB (0=Language, 1=Blank)")]
		public string M3BLLD => GetString("BLLD");
	}
}
// EOF
