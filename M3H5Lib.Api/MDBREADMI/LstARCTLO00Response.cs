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

namespace M3H5Lib.Api.MDBREADMI
{
	public partial class LstARCTLO00Response : M3BaseRecord 
	{

		/// <summary>
		/// Description: Arch run number
		/// FieldName: ARCN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Arch run number")]
		public decimal? M3ARCN => GetNullableDecimal("ARCN");

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
		/// Description: Master table
		/// FieldName: ARMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Master table")]
		public int? M3ARMA => GetNullableInt("ARMA");

		/// <summary>
		/// Description: Rec start prod
		/// FieldName: AROR
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rec start prod")]
		public decimal? M3AROR => GetNullableDecimal("AROR");

		/// <summary>
		/// Description: Rec end prod
		/// FieldName: ARRE
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rec end prod")]
		public decimal? M3ARRE => GetNullableDecimal("ARRE");

		/// <summary>
		/// Description: Arch library
		/// FieldName: ARLI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Arch library")]
		public string M3ARLI => GetString("ARLI");

		/// <summary>
		/// Description: Rec end arch
		/// FieldName: ARRL
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rec end arch")]
		public decimal? M3ARRL => GetNullableDecimal("ARRL");

		/// <summary>
		/// Description: Rec start arch
		/// FieldName: AROL
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rec start arch")]
		public decimal? M3AROL => GetNullableDecimal("AROL");

		/// <summary>
		/// Description: Archive records
		/// FieldName: ARTR
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Archive records")]
		public decimal? M3ARTR => GetNullableDecimal("ARTR");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");
	}
}
// EOF
