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
		public string M3FILE => GetString("FILE");

		/// <summary>
		/// Description: Customer extension reference
		/// FieldName: CUER
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer extension reference")]
		public string M3CUER => GetString("CUER");

		/// <summary>
		/// Description: Field
		/// FieldName: FLDI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3FLDI => GetString("FLDI");

		/// <summary>
		/// Description: Name
		/// FieldName: TX05
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX05 => GetString("TX05");

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
		/// Description: Message ID
		/// FieldName: MSID
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message ID")]
		public string M3MSID => GetString("MSID");

		/// <summary>
		/// Description: Field type
		/// FieldName: FLTE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field type")]
		public string M3FLTE => GetString("FLTE");

		/// <summary>
		/// Description: Category
		/// FieldName: CTGY
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Category")]
		public string M3CTGY => GetString("CTGY");

		/// <summary>
		/// Description: Field length
		/// FieldName: FLDB
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field length")]
		public int? M3FLDB => GetNullableInt("FLDB");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: FLDP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3FLDP => GetNullableInt("FLDP");

		/// <summary>
		/// Description: Uppercase
		/// FieldName: FLUC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Uppercase")]
		public int? M3FLUC => GetNullableInt("FLUC");

		/// <summary>
		/// Description: Field - lower limit
		/// FieldName: FLLL
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field - lower limit")]
		public decimal? M3FLLL => GetNullableDecimal("FLLL");

		/// <summary>
		/// Description: Field - upper limit
		/// FieldName: FLUL
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field - upper limit")]
		public decimal? M3FLUL => GetNullableDecimal("FLUL");

		/// <summary>
		/// Description: Field - limit multiple
		/// FieldName: FLLM
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field - limit multiple")]
		public decimal? M3FLLM => GetNullableDecimal("FLLM");

		/// <summary>
		/// Description: Edit code
		/// FieldName: ECDE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Edit code")]
		public string M3ECDE => GetString("ECDE");

		/// <summary>
		/// Description: Check digit method
		/// FieldName: NBMO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check digit method")]
		public int? M3NBMO => GetNullableInt("NBMO");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Description in user language
		/// FieldName: TX4L
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description in user language")]
		public string M3TX4L => GetString("TX4L");

		/// <summary>
		/// Description: Name in user language
		/// FieldName: TX1L
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name in user language")]
		public string M3TX1L => GetString("TX1L");
	}
}
// EOF
