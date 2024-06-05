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

namespace M3H5Lib.Api.OPS210MI
{
	public partial class LstExtTickLinResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Transaction type
		/// FieldName: TRTP
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type")]
		public string M3TRTP => GetString("TRTP");

		/// <summary>
		/// Description: Reference
		/// FieldName: REFE
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference")]
		public string M3REFE => GetString("REFE");

		/// <summary>
		/// Description: Transaction date
		/// FieldName: TRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction date")]
		public DateTime? M3TRDT => GetNullableDateTime("TRDT");

		/// <summary>
		/// Description: Transaction time
		/// FieldName: TRTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction time")]
		public int? M3TRTM => GetNullableInt("TRTM");

		/// <summary>
		/// Description: Record status
		/// FieldName: RDST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Record status")]
		public string M3RDST => GetString("RDST");

		/// <summary>
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Salesperson
		/// FieldName: SMCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Salesperson")]
		public string M3SMCD => GetString("SMCD");

		/// <summary>
		/// Description: Net daily rate
		/// FieldName: PDAN
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net daily rate")]
		public decimal? M3PDAN => GetNullableDecimal("PDAN");

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Quantity
		/// FieldName: QTYA
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity")]
		public decimal? M3QTYA => GetNullableDecimal("QTYA");

		/// <summary>
		/// Description: Alternate U/M
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M")]
		public string M3ALUN => GetString("ALUN");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3SAPR => GetNullableDecimal("SAPR");

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
		/// Description: Discount amount 1
		/// FieldName: DIA1
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 1")]
		public decimal? M3DIA1 => GetNullableDecimal("DIA1");

		/// <summary>
		/// Description: User-defined field 1 - customer
		/// FieldName: CFC1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - customer")]
		public string M3CFC1 => GetString("CFC1");

		/// <summary>
		/// Description: User-defined field 2 - customer
		/// FieldName: CFC2
		/// FieldType: N
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - customer")]
		public decimal? M3CFC2 => GetNullableDecimal("CFC2");

		/// <summary>
		/// Description: User-defined field 3 - customer
		/// FieldName: CFC3
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - customer")]
		public string M3CFC3 => GetString("CFC3");

		/// <summary>
		/// Description: User-defined field 4 - customer
		/// FieldName: CFC4
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - customer")]
		public string M3CFC4 => GetString("CFC4");

		/// <summary>
		/// Description: User-defined field 5 - customer
		/// FieldName: CFC5
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - customer")]
		public string M3CFC5 => GetString("CFC5");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDS => GetString("ITDS");
	}
}
// EOF
