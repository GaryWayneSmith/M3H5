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

namespace M3H5Lib.Api.CRS020MI
{
	public partial class LstSortingSeqResponse : M3BaseRecord 
	{

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
		/// Description: Panel
		/// FieldName: PIC1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel")]
		public string M3PIC1 => GetString("PIC1");

		/// <summary>
		/// Description: Inquiry type
		/// FieldName: QTTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inquiry type")]
		public int? M3QTTP => GetNullableInt("QTTP");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEYF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KEYF => GetString("KEYF");

		/// <summary>
		/// Description: Sequence
		/// FieldName: SEQC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence")]
		public int? M3SEQC => GetNullableInt("SEQC");

		/// <summary>
		/// Description: Filter field
		/// FieldName: FILF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filter field")]
		public int? M3FILF => GetNullableInt("FILF");

		/// <summary>
		/// Description: Information browser category
		/// FieldName: IBCA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information browser category")]
		public string M3IBCA => GetString("IBCA");
	}
}
// EOF
