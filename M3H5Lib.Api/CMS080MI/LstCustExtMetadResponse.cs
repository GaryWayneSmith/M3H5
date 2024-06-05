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

namespace M3H5Lib.Api.CMS080MI
{
	public partial class LstCustExtMetadResponse : M3BaseRecord 
	{

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
		/// Description: Customer extension reference
		/// FieldName: CUER
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer extension reference")]
		public string M3_CUER => GetString("CUER");

		/// <summary>
		/// Description: Field
		/// FieldName: FLDI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FLDI => GetString("FLDI");

		/// <summary>
		/// Description: Name
		/// FieldName: TX05
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX05 => GetString("TX05");

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
		/// Description: Message ID
		/// FieldName: MSID
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message ID")]
		public string M3_MSID => GetString("MSID");

		/// <summary>
		/// Description: Field type
		/// FieldName: FLTE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field type")]
		public string M3_FLTE => GetString("FLTE");

		/// <summary>
		/// Description: Category
		/// FieldName: CTGY
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Category")]
		public string M3_CTGY => GetString("CTGY");

		/// <summary>
		/// Description: Field length
		/// FieldName: FLDB
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field length")]
		public int? M3_FLDB => GetNullableInt("FLDB");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: FLDP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3_FLDP => GetNullableInt("FLDP");

		/// <summary>
		/// Description: Uppercase
		/// FieldName: FLUC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Uppercase")]
		public int? M3_FLUC => GetNullableInt("FLUC");

		/// <summary>
		/// Description: Field - lower limit
		/// FieldName: FLLL
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field - lower limit")]
		public decimal? M3_FLLL => GetNullableDecimal("FLLL");

		/// <summary>
		/// Description: Field - upper limit
		/// FieldName: FLUL
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field - upper limit")]
		public decimal? M3_FLUL => GetNullableDecimal("FLUL");

		/// <summary>
		/// Description: Field - limit multiple
		/// FieldName: FLLM
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field - limit multiple")]
		public decimal? M3_FLLM => GetNullableDecimal("FLLM");

		/// <summary>
		/// Description: Edit code
		/// FieldName: ECDE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Edit code")]
		public string M3_ECDE => GetString("ECDE");

		/// <summary>
		/// Description: Check digit method
		/// FieldName: NBMO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check digit method")]
		public int? M3_NBMO => GetNullableInt("NBMO");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Description in user language
		/// FieldName: TX4L
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description in user language")]
		public string M3_TX4L => GetString("TX4L");

		/// <summary>
		/// Description: Name in user language
		/// FieldName: TX1L
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name in user language")]
		public string M3_TX1L => GetString("TX1L");
	}
}
// EOF
