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

namespace M3H5Lib.Api.POS350MI
{
	public partial class GetInvLineResponse : M3BaseRecord 
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
		/// Description: Delivery number
		/// FieldName: DLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3_DLIX => GetNullableDecimal("DLIX");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Invoice reference
		/// FieldName: IVRF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reference")]
		public string M3_IVRF => GetString("IVRF");

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
		/// Description: Name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Ref field for amount
		/// FieldName: AMT1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for amount")]
		public decimal? M3_AMT1 => GetNullableDecimal("AMT1");

		/// <summary>
		/// Description: Ref field for amount
		/// FieldName: AMT2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for amount")]
		public decimal? M3_AMT2 => GetNullableDecimal("AMT2");

		/// <summary>
		/// Description: Calc basis amount, invoicing, order curr
		/// FieldName: AMT3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calc basis amount, invoicing, order curr")]
		public decimal? M3_AMT3 => GetNullableDecimal("AMT3");

		/// <summary>
		/// Description: VAT
		/// FieldName: VTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT")]
		public decimal? M3_VTAM => GetNullableDecimal("VTAM");

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
		/// Description: From/to country
		/// FieldName: FTCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From/to country")]
		public string M3_FTCO => GetString("FTCO");

		/// <summary>
		/// Description: State
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("State")]
		public string M3_ECAR => GetString("ECAR");

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
		/// Description: VAT amt, loc curr
		/// FieldName: CVTM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT amt, loc curr")]
		public decimal? M3_CVTM => GetNullableDecimal("CVTM");

		/// <summary>
		/// Description: Base amount, local curr
		/// FieldName: CVBA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base amount, local curr")]
		public decimal? M3_CVBA => GetNullableDecimal("CVBA");

		/// <summary>
		/// Description: VAT rate 1
		/// FieldName: VTP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT rate 1")]
		public int? M3_VTP1 => GetNullableInt("VTP1");

		/// <summary>
		/// Description: VAT rate 2
		/// FieldName: VTP2
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT rate 2")]
		public int? M3_VTP2 => GetNullableInt("VTP2");

		/// <summary>
		/// Description: VAT registration number internal
		/// FieldName: VRIN
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number internal")]
		public string M3_VRIN => GetString("VRIN");

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3_VRNO => GetString("VRNO");

		/// <summary>
		/// Description: Quebec sales tax rate
		/// FieldName: VTPQ
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quebec sales tax rate")]
		public int? M3_VTPQ => GetNullableInt("VTPQ");
	}
}
// EOF
