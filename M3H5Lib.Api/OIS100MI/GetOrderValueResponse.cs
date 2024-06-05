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
	public partial class GetOrderValueResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Net order amount
		/// FieldName: NTAM
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net order amount")]
		public decimal? M3NTAM => GetNullableDecimal("NTAM");

		/// <summary>
		/// Description: Order discount
		/// FieldName: ODAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order discount")]
		public decimal? M3ODAM => GetNullableDecimal("ODAM");

		/// <summary>
		/// Description: Order net
		/// FieldName: ONET
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order net")]
		public decimal? M3ONET => GetNullableDecimal("ONET");

		/// <summary>
		/// Description: Charge
		/// FieldName: EXAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge")]
		public decimal? M3EXAM => GetNullableDecimal("EXAM");

		/// <summary>
		/// Description: External charge
		/// FieldName: EFAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External charge")]
		public decimal? M3EFAM => GetNullableDecimal("EFAM");

		/// <summary>
		/// Description: Subtotal before tax
		/// FieldName: ORVA
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subtotal before tax")]
		public decimal? M3ORVA => GetNullableDecimal("ORVA");

		/// <summary>
		/// Description: VAT amount
		/// FieldName: VTAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT amount")]
		public decimal? M3VTAM => GetNullableDecimal("VTAM");

		/// <summary>
		/// Description: Subtotal after tax
		/// FieldName: TOAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subtotal after tax")]
		public decimal? M3TOAM => GetNullableDecimal("TOAM");

		/// <summary>
		/// Description: Rounding off
		/// FieldName: ROAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rounding off")]
		public decimal? M3ROAM => GetNullableDecimal("ROAM");

		/// <summary>
		/// Description: Total
		/// FieldName: TOPY
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total")]
		public decimal? M3TOPY => GetNullableDecimal("TOPY");

		/// <summary>
		/// Description: Order value gross
		/// FieldName: BRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order value gross")]
		public decimal? M3BRAM => GetNullableDecimal("BRAM");

		/// <summary>
		/// Description: Invoiced net order amount
		/// FieldName: INTA
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced net order amount")]
		public decimal? M3INTA => GetNullableDecimal("INTA");

		/// <summary>
		/// Description: Invoiced order total discount
		/// FieldName: IDAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced order total discount")]
		public decimal? M3IDAM => GetNullableDecimal("IDAM");

		/// <summary>
		/// Description: Invoiced order net
		/// FieldName: INET
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced order net")]
		public decimal? M3INET => GetNullableDecimal("INET");

		/// <summary>
		/// Description: Invoiced service charge
		/// FieldName: IXAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced service charge")]
		public decimal? M3IXAM => GetNullableDecimal("IXAM");

		/// <summary>
		/// Description: Invoiced external charge
		/// FieldName: IFAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced external charge")]
		public decimal? M3IFAM => GetNullableDecimal("IFAM");

		/// <summary>
		/// Description: Invoiced subtotal before tax
		/// FieldName: IRVA
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced subtotal before tax")]
		public decimal? M3IRVA => GetNullableDecimal("IRVA");

		/// <summary>
		/// Description: Invoiced VAT amount
		/// FieldName: IVTA
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced VAT amount")]
		public decimal? M3IVTA => GetNullableDecimal("IVTA");

		/// <summary>
		/// Description: Invoiced subtotal after tax
		/// FieldName: ITOA
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced subtotal after tax")]
		public decimal? M3ITOA => GetNullableDecimal("ITOA");

		/// <summary>
		/// Description: Invoiced rounding off
		/// FieldName: IROA
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced rounding off")]
		public decimal? M3IROA => GetNullableDecimal("IROA");

		/// <summary>
		/// Description: Invoiced total amount
		/// FieldName: ITOP
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced total amount")]
		public decimal? M3ITOP => GetNullableDecimal("ITOP");

		/// <summary>
		/// Description: Invoiced gross order value
		/// FieldName: IRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced gross order value")]
		public decimal? M3IRAM => GetNullableDecimal("IRAM");

		/// <summary>
		/// Description: Summary invoice indicator
		/// FieldName: ISUM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Summary invoice indicator")]
		public string M3ISUM => GetString("ISUM");

		/// <summary>
		/// Description: Total price indicator
		/// FieldName: ITPR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total price indicator")]
		public string M3ITPR => GetString("ITPR");

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
		/// Description: Vertex not calc
		/// FieldName: VXCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Vertex not calc")]
		public int? M3VXCL => GetNullableInt("VXCL");
	}
}
// EOF
