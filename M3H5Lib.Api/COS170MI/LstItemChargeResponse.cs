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

namespace M3H5Lib.Api.COS170MI
{
	public partial class LstItemChargeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Customer order number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order number")]
		public string M3_ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Order line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line number")]
		public int? M3_PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Quotation
		/// FieldName: AQUO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quotation")]
		public int? M3_AQUO => GetNullableInt("AQUO");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3_PYNO => GetString("PYNO");

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
		/// Description: Transaction number
		/// FieldName: ALI1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction number")]
		public int? M3_ALI1 => GetNullableInt("ALI1");

		/// <summary>
		/// Description: Geographical code
		/// FieldName: GEOC
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographical code")]
		public int? M3_GEOC => GetNullableInt("GEOC");

		/// <summary>
		/// Description: Tax amount 1
		/// FieldName: TXA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amount 1")]
		public decimal? M3_TXA1 => GetNullableDecimal("TXA1");

		/// <summary>
		/// Description: Tax rate 1
		/// FieldName: TXR1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 1")]
		public decimal? M3_TXR1 => GetNullableDecimal("TXR1");

		/// <summary>
		/// Description: Tax description 1
		/// FieldName: TXD1
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax description 1")]
		public string M3_TXD1 => GetString("TXD1");

		/// <summary>
		/// Description: Tax amount 2
		/// FieldName: TXA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amount 2")]
		public decimal? M3_TXA2 => GetNullableDecimal("TXA2");

		/// <summary>
		/// Description: Tax rate 2
		/// FieldName: TXR2
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 2")]
		public decimal? M3_TXR2 => GetNullableDecimal("TXR2");

		/// <summary>
		/// Description: Tax description 2
		/// FieldName: TXD2
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax description 2")]
		public string M3_TXD2 => GetString("TXD2");

		/// <summary>
		/// Description: Tax amount 3
		/// FieldName: TXA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amount 3")]
		public decimal? M3_TXA3 => GetNullableDecimal("TXA3");

		/// <summary>
		/// Description: Tax rate 3
		/// FieldName: TXR3
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 3")]
		public decimal? M3_TXR3 => GetNullableDecimal("TXR3");

		/// <summary>
		/// Description: Tax description 3
		/// FieldName: TXD3
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax description 3")]
		public string M3_TXD3 => GetString("TXD3");

		/// <summary>
		/// Description: Tax amount 4
		/// FieldName: TXA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amount 4")]
		public decimal? M3_TXA4 => GetNullableDecimal("TXA4");

		/// <summary>
		/// Description: Tax rate 4
		/// FieldName: TXR4
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 4")]
		public decimal? M3_TXR4 => GetNullableDecimal("TXR4");

		/// <summary>
		/// Description: Tax description 4
		/// FieldName: TXD4
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax description 4")]
		public string M3_TXD4 => GetString("TXD4");

		/// <summary>
		/// Description: Tax amount 5
		/// FieldName: TXA5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amount 5")]
		public decimal? M3_TXA5 => GetNullableDecimal("TXA5");

		/// <summary>
		/// Description: Tax rate 5
		/// FieldName: TXR5
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 5")]
		public decimal? M3_TXR5 => GetNullableDecimal("TXR5");

		/// <summary>
		/// Description: Tax description 5
		/// FieldName: TXD5
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax description 5")]
		public string M3_TXD5 => GetString("TXD5");

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
		/// Description: Tax code customer/address
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code customer/address")]
		public string M3_TAXC => GetString("TAXC");

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
		/// Description: Amount
		/// FieldName: PBAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount")]
		public decimal? M3_PBAM => GetNullableDecimal("PBAM");

		/// <summary>
		/// Description: Description
		/// FieldName: CRD0
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_CRD0 => GetString("CRD0");

		/// <summary>
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3_ACRF => GetString("ACRF");

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
		/// Description: Status - charge
		/// FieldName: CHST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - charge")]
		public string M3_CHST => GetString("CHST");
	}
}
// EOF
