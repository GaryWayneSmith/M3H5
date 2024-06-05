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

namespace M3H5Lib.Api.OIS120MI
{
	public partial class GetCOStopInfoResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3PYNO => GetString("PYNO");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Customer stop
		/// FieldName: BLCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer stop")]
		public int? M3BLCD => GetNullableInt("BLCD");

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
		/// Description: Customer order number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order number")]
		public string M3ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Customer order type
		/// FieldName: ORTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order type")]
		public string M3ORTP => GetString("ORTP");

		/// <summary>
		/// Description: Lowest status - customer order
		/// FieldName: ORSL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest status - customer order")]
		public string M3ORSL => GetString("ORSL");

		/// <summary>
		/// Description: Highest status - customer order
		/// FieldName: ORST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status - customer order")]
		public string M3ORST => GetString("ORST");

		/// <summary>
		/// Description: Order date
		/// FieldName: ORDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order date")]
		public DateTime? M3ORDT => GetNullableDateTime("ORDT");

		/// <summary>
		/// Description: Requested delivery date
		/// FieldName: RLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery date")]
		public DateTime? M3RLDT => GetNullableDateTime("RLDT");

		/// <summary>
		/// Description: Net order value
		/// FieldName: NTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net order value")]
		public decimal? M3NTAM => GetNullableDecimal("NTAM");

		/// <summary>
		/// Description: Customer order stop
		/// FieldName: OBLC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order stop")]
		public int? M3OBLC => GetNullableInt("OBLC");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3LNCD => GetString("LNCD");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3TEPY => GetString("TEPY");

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
		/// Description: Credit limit 1
		/// FieldName: CRLM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 1")]
		public decimal? M3CRLM => GetNullableDecimal("CRLM");

		/// <summary>
		/// Description: Overdue invoice amount
		/// FieldName: ODIN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overdue invoice amount")]
		public decimal? M3ODIN => GetNullableDecimal("ODIN");

		/// <summary>
		/// Description: Difference of CRLM and ODIN
		/// FieldName: DIF1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Difference of CRLM and ODIN")]
		public decimal? M3DIF1 => GetNullableDecimal("DIF1");

		/// <summary>
		/// Description: Credit limit 2
		/// FieldName: CRL2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 2")]
		public decimal? M3CRL2 => GetNullableDecimal("CRL2");

		/// <summary>
		/// Description: Outstanding invoice amount
		/// FieldName: OINA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Outstanding invoice amount")]
		public decimal? M3OINA => GetNullableDecimal("OINA");

		/// <summary>
		/// Description: Difference of CRL2 and OINA
		/// FieldName: DIF2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Difference of CRL2 and OINA")]
		public decimal? M3DIF2 => GetNullableDecimal("DIF2");

		/// <summary>
		/// Description: Credit limit 3
		/// FieldName: CRL3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 3")]
		public decimal? M3CRL3 => GetNullableDecimal("CRL3");

		/// <summary>
		/// Description: Order value not invoiced
		/// FieldName: OVNI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order value not invoiced")]
		public decimal? M3OVNI => GetNullableDecimal("OVNI");

		/// <summary>
		/// Description: Outstanding without risk
		/// FieldName: OWOR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Outstanding without risk")]
		public decimal? M3OWOR => GetNullableDecimal("OWOR");

		/// <summary>
		/// Description: Order value without risk
		/// FieldName: OVWR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order value without risk")]
		public decimal? M3OVWR => GetNullableDecimal("OVWR");

		/// <summary>
		/// Description: Difference of CRL3 and OVNI
		/// FieldName: DIF3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Difference of CRL3 and OVNI")]
		public decimal? M3DIF3 => GetNullableDecimal("DIF3");
	}
}
// EOF
