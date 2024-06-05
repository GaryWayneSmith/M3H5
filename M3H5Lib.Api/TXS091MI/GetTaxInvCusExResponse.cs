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

namespace M3H5Lib.Api.TXS091MI
{
	public partial class GetTaxInvCusExResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Reversed reporting
		/// FieldName: ARRV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reversed reporting")]
		public int? M3ARRV => GetNullableInt("ARRV");

		/// <summary>
		/// Description: Include in tax invoice
		/// FieldName: ARTX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include in tax invoice")]
		public int? M3ARTX => GetNullableInt("ARTX");

		/// <summary>
		/// Description: Group frequency
		/// FieldName: GRFQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group frequency")]
		public int? M3GRFQ => GetNullableInt("GRFQ");

		/// <summary>
		/// Description: Group debit/credit
		/// FieldName: GRDC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group debit/credit")]
		public int? M3GRDC => GetNullableInt("GRDC");

		/// <summary>
		/// Description: Invoice class
		/// FieldName: IVCL
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice class")]
		public string M3IVCL => GetString("IVCL");
	}
}
// EOF
