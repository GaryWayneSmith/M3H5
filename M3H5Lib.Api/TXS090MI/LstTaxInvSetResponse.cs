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

namespace M3H5Lib.Api.TXS090MI
{
	public partial class LstTaxInvSetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Base country
		/// FieldName: BSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base country")]
		public string M3_BSCD => GetString("BSCD");

		/// <summary>
		/// Description: Include in tax invoice
		/// FieldName: ARTX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include in tax invoice")]
		public int? M3_ARTX => GetNullableInt("ARTX");

		/// <summary>
		/// Description: Group frequency
		/// FieldName: GRFQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group frequency")]
		public int? M3_GRFQ => GetNullableInt("GRFQ");

		/// <summary>
		/// Description: Group debit/credit
		/// FieldName: GRDC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group debit/credit")]
		public int? M3_GRDC => GetNullableInt("GRDC");

		/// <summary>
		/// Description: Invoice class
		/// FieldName: IVCL
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice class")]
		public string M3_IVCL => GetString("IVCL");

		/// <summary>
		/// Description: Payment stop rule
		/// FieldName: APBL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment stop rule")]
		public int? M3_APBL => GetNullableInt("APBL");

		/// <summary>
		/// Description: Payment stop
		/// FieldName: IVBL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment stop")]
		public int? M3_IVBL => GetNullableInt("IVBL");

		/// <summary>
		/// Description: Stopped by
		/// FieldName: BLBY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stopped by")]
		public string M3_BLBY => GetString("BLBY");
	}
}
// EOF
