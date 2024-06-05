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

namespace M3H5Lib.Api.EQINFOMI
{
	public partial class SelMaintCOLineResponse : M3BaseRecord 
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
		public string M3ORNO => GetString("ORNO");

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
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3STRT => GetString("STRT");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Order quantity
		/// FieldName: AORQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order quantity")]
		public decimal? M3AORQ => GetNullableDecimal("AORQ");

		/// <summary>
		/// Description: Highest status
		/// FieldName: AOST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status")]
		public string M3AOST => GetString("AOST");

		/// <summary>
		/// Description: Claim warranty
		/// FieldName: ACWA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim warranty")]
		public int? M3ACWA => GetNullableInt("ACWA");

		/// <summary>
		/// Description: Service price method
		/// FieldName: SRVP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service price method")]
		public int? M3SRVP => GetNullableInt("SRVP");

		/// <summary>
		/// Description: MCO line type
		/// FieldName: AEXT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MCO line type")]
		public int? M3AEXT => GetNullableInt("AEXT");

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
		/// Description: Order time
		/// FieldName: AORT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order time")]
		public int? M3AORT => GetNullableInt("AORT");

		/// <summary>
		/// Description: Requested delivery time
		/// FieldName: DWHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery time")]
		public int? M3DWHM => GetNullableInt("DWHM");
	}
}
// EOF
