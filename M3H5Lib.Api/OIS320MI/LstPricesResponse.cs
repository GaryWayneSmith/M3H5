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

namespace M3H5Lib.Api.OIS320MI
{
	public partial class LstPricesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Lowest quantity limit - basic U/M
		/// FieldName: QTLB
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest quantity limit - basic U/M")]
		public decimal? M3QTLB => GetNullableDecimal("QTLB");

		/// <summary>
		/// Description: Scale unit of measure
		/// FieldName: SGGU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scale unit of measure")]
		public string M3SGGU => GetString("SGGU");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3SAPR => GetNullableDecimal("SAPR");

		/// <summary>
		/// Description: Discount
		/// FieldName: DIPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount")]
		public int? M3DIPC => GetNullableInt("DIPC");

		/// <summary>
		/// Description: Net price
		/// FieldName: NETP
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net price")]
		public decimal? M3NETP => GetNullableDecimal("NETP");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Sales price unit of measure
		/// FieldName: SPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price unit of measure")]
		public string M3SPUN => GetString("SPUN");

		/// <summary>
		/// Description: Price origin
		/// FieldName: PRMO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price origin")]
		public string M3PRMO => GetString("PRMO");

		/// <summary>
		/// Description: Blanket agreement number
		/// FieldName: AGNO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blanket agreement number")]
		public string M3AGNO => GetString("AGNO");

		/// <summary>
		/// Description: Price list
		/// FieldName: PRRF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list")]
		public string M3PRRF => GetString("PRRF");

		/// <summary>
		/// Description: Promotion
		/// FieldName: PIDE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion")]
		public string M3PIDE => GetString("PIDE");

		/// <summary>
		/// Description: Core charge item number
		/// FieldName: CCI1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Core charge item number")]
		public string M3CCI1 => GetString("CCI1");

		/// <summary>
		/// Description: Sales price - core charge
		/// FieldName: CCSA
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price - core charge")]
		public decimal? M3CCSA => GetNullableDecimal("CCSA");
	}
}
// EOF
