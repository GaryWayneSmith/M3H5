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

namespace M3H5Lib.Api.CRS610MI
{
	public partial class LstCustChargesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3_CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Charge
		/// FieldName: CRID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge")]
		public string M3_CRID => GetString("CRID");

		/// <summary>
		/// Description: Internal charge
		/// FieldName: CRTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal charge")]
		public int? M3_CRTY => GetNullableInt("CRTY");

		/// <summary>
		/// Description: Debit frequency
		/// FieldName: HACD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit frequency")]
		public int? M3_HACD => GetNullableInt("HACD");

		/// <summary>
		/// Description: Description language 0
		/// FieldName: CRD0
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description language 0")]
		public string M3_CRD0 => GetString("CRD0");

		/// <summary>
		/// Description: Charge amount
		/// FieldName: CRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge amount")]
		public decimal? M3_CRAM => GetNullableDecimal("CRAM");

		/// <summary>
		/// Description: Calculation method
		/// FieldName: CRME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation method")]
		public int? M3_CRME => GetNullableInt("CRME");

		/// <summary>
		/// Description: Calculation factor
		/// FieldName: CRFA
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation factor")]
		public decimal? M3_CRFA => GetNullableDecimal("CRFA");

		/// <summary>
		/// Description: Included in cost total 1
		/// FieldName: CRN1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 1")]
		public int? M3_CRN1 => GetNullableInt("CRN1");

		/// <summary>
		/// Description: Included in cost total 2
		/// FieldName: CRN2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 2")]
		public int? M3_CRN2 => GetNullableInt("CRN2");

		/// <summary>
		/// Description: Included in cost total 3
		/// FieldName: CRN3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 3")]
		public int? M3_CRN3 => GetNullableInt("CRN3");

		/// <summary>
		/// Description: Included in cost total 4
		/// FieldName: CRN4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 4")]
		public int? M3_CRN4 => GetNullableInt("CRN4");

		/// <summary>
		/// Description: Included in cost total 5
		/// FieldName: CRN5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 5")]
		public int? M3_CRN5 => GetNullableInt("CRN5");

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public int? M3_VTCD => GetNullableInt("VTCD");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3_CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Tax code
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code")]
		public string M3_TAXC => GetString("TAXC");
	}
}
// EOF
