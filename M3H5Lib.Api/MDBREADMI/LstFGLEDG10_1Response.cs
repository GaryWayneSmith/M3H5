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
	public partial class LstFGLEDG10_1Response : M3BaseRecord 
	{

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Journal no
		/// FieldName: JRNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Journal no")]
		public int? M3JRNO => GetNullableInt("JRNO");

		/// <summary>
		/// Description: Journal seq no
		/// FieldName: JSNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Journal seq no")]
		public int? M3JSNO => GetNullableInt("JSNO");

		/// <summary>
		/// Description: Trans code
		/// FieldName: TRCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trans code")]
		public int? M3TRCD => GetNullableInt("TRCD");

		/// <summary>
		/// Description: Voucher no
		/// FieldName: VONO
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher no")]
		public int? M3VONO => GetNullableInt("VONO");

		/// <summary>
		/// Description: FAM function
		/// FieldName: FEID
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function")]
		public string M3FEID => GetString("FEID");

		/// <summary>
		/// Description: FAM function
		/// FieldName: FNCN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function")]
		public int? M3FNCN => GetNullableInt("FNCN");

		/// <summary>
		/// Description: Trans descr
		/// FieldName: TDSC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trans descr")]
		public string M3TDSC => GetString("TDSC");

		/// <summary>
		/// Description: Voucher name
		/// FieldName: VDSC
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher name")]
		public string M3VDSC => GetString("VDSC");

		/// <summary>
		/// Description: Ext/int trans
		/// FieldName: EICD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ext/int trans")]
		public int? M3EICD => GetNullableInt("EICD");
	}
}
// EOF
