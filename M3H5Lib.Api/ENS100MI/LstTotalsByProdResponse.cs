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

namespace M3H5Lib.Api.ENS100MI
{
	public partial class LstTotalsByProdResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Job number
		/// FieldName: BJNO
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job number")]
		public string M3_BJNO => GetString("BJNO");

		/// <summary>
		/// Description: Eco-organization
		/// FieldName: ECRG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Eco-organization")]
		public string M3_ECRG => GetString("ECRG");

		/// <summary>
		/// Description: Country of organization
		/// FieldName: CSOR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country of organization")]
		public string M3_CSOR => GetString("CSOR");

		/// <summary>
		/// Description: Supplier of organization
		/// FieldName: SUEC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier of organization")]
		public string M3_SUEC => GetString("SUEC");

		/// <summary>
		/// Description: Eco-product code
		/// FieldName: ECOP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Eco-product code")]
		public string M3_ECOP => GetString("ECOP");

		/// <summary>
		/// Description: Total quantity
		/// FieldName: TOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total quantity")]
		public decimal? M3_TOQT => GetNullableDecimal("TOQT");

		/// <summary>
		/// Description: Total amount
		/// FieldName: TOTC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total amount")]
		public decimal? M3_TOTC => GetNullableDecimal("TOTC");

		/// <summary>
		/// Description: Total gross weight
		/// FieldName: TOTG
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total gross weight")]
		public decimal? M3_TOTG => GetNullableDecimal("TOTG");

		/// <summary>
		/// Description: Total net weight
		/// FieldName: TOTN
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total net weight")]
		public decimal? M3_TOTN => GetNullableDecimal("TOTN");

		/// <summary>
		/// Description: Total package weight
		/// FieldName: TOTP
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total package weight")]
		public decimal? M3_TOTP => GetNullableDecimal("TOTP");
	}
}
// EOF
