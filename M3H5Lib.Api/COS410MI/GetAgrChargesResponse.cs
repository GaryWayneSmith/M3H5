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

namespace M3H5Lib.Api.COS410MI
{
	public partial class GetAgrChargesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Agreement
		/// FieldName: AAGN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement")]
		public string M3AAGN => GetString("AAGN");

		/// <summary>
		/// Description: Charge
		/// FieldName: CRID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge")]
		public string M3CRID => GetString("CRID");

		/// <summary>
		/// Description: Charge
		/// FieldName: CRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge")]
		public decimal? M3CRAM => GetNullableDecimal("CRAM");

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public int? M3VTCD => GetNullableInt("VTCD");

		/// <summary>
		/// Description: Debit frequency
		/// FieldName: HACD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit frequency")]
		public int? M3HACD => GetNullableInt("HACD");

		/// <summary>
		/// Description: Description
		/// FieldName: CRD0
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3CRD0 => GetString("CRD0");

		/// <summary>
		/// Description: Cumulative release/accrual
		/// FieldName: CRAA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative release/accrual")]
		public decimal? M3CRAA => GetNullableDecimal("CRAA");

		/// <summary>
		/// Description: Tax code customer/address
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code customer/address")]
		public string M3TAXC => GetString("TAXC");
	}
}
// EOF
