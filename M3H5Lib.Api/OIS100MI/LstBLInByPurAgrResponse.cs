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

namespace M3H5Lib.Api.OIS100MI
{
	public partial class LstBLInByPurAgrResponse : M3BaseRecord 
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
		/// Description: Order line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: POSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3POSX => GetNullableInt("POSX");

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
		/// Description: Item description
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item description")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Ordered quantity
		/// FieldName: ORQT
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity")]
		public string M3ORQT => GetString("ORQT");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Customer order line number
		/// FieldName: CUPO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order line number")]
		public string M3CUPO => GetString("CUPO");

		/// <summary>
		/// Description: Requested delivery date
		/// FieldName: DWDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery date")]
		public DateTime? M3DWDT => GetNullableDateTime("DWDT");

		/// <summary>
		/// Description: Joint delivery code
		/// FieldName: JDCD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Joint delivery code")]
		public string M3JDCD => GetString("JDCD");

		/// <summary>
		/// Description: Salesprice
		/// FieldName: SAPR
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Salesprice")]
		public string M3SAPR => GetString("SAPR");

		/// <summary>
		/// Description: Discount amount 1
		/// FieldName: DIA1
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 1")]
		public string M3DIA1 => GetString("DIA1");

		/// <summary>
		/// Description: Discount amount 2
		/// FieldName: DIA2
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 2")]
		public string M3DIA2 => GetString("DIA2");

		/// <summary>
		/// Description: Discount amount 3
		/// FieldName: DIA3
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 3")]
		public string M3DIA3 => GetString("DIA3");

		/// <summary>
		/// Description: Discount amount 4
		/// FieldName: DIA4
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 4")]
		public string M3DIA4 => GetString("DIA4");

		/// <summary>
		/// Description: Discount amount 5
		/// FieldName: DIA5
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 5")]
		public string M3DIA5 => GetString("DIA5");

		/// <summary>
		/// Description: Discount amount 6
		/// FieldName: DIA6
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 6")]
		public string M3DIA6 => GetString("DIA6");

		/// <summary>
		/// Description: Delivery specification
		/// FieldName: DLSP
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery specification")]
		public string M3DLSP => GetString("DLSP");

		/// <summary>
		/// Description: Delivery specification text
		/// FieldName: DLSX
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery specification text")]
		public string M3DLSX => GetString("DLSX");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3ATNR => GetNullableDecimal("ATNR");
	}
}
// EOF
