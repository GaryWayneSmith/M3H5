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

namespace M3H5Lib.Api.PPS200MI
{
	public partial class LstDelSchLineResponse : M3BaseRecord 
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
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Printout number - delivery schedule
		/// FieldName: DSPN
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printout number - delivery schedule")]
		public decimal? M3DSPN => GetNullableDecimal("DSPN");

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
		/// Description: Purchase order number
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order number")]
		public string M3PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Purchase order line
		/// FieldName: PNLI
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order line")]
		public int? M3PNLI => GetNullableInt("PNLI");

		/// <summary>
		/// Description: Purchase order line subnumber
		/// FieldName: PNLS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order line subnumber")]
		public int? M3PNLS => GetNullableInt("PNLS");

		/// <summary>
		/// Description: Valid delivery date
		/// FieldName: VDDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid delivery date")]
		public DateTime? M3VDDT => GetNullableDateTime("VDDT");

		/// <summary>
		/// Description: Ordered quantity - alternate U/M
		/// FieldName: ORQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - alternate U/M")]
		public decimal? M3ORQA => GetNullableDecimal("ORQA");

		/// <summary>
		/// Description: Printed quantity
		/// FieldName: PRQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printed quantity")]
		public decimal? M3PRQA => GetNullableDecimal("PRQA");

		/// <summary>
		/// Description: First printout date
		/// FieldName: LEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("First printout date")]
		public DateTime? M3LEDT => GetNullableDateTime("LEDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Planned order
		/// FieldName: PLPN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned order")]
		public int? M3PLPN => GetNullableInt("PLPN");

		/// <summary>
		/// Description: Subnumber - planned order
		/// FieldName: PLPS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnumber - planned order")]
		public int? M3PLPS => GetNullableInt("PLPS");

		/// <summary>
		/// Description: From planned order
		/// FieldName: FPLP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From planned order")]
		public int? M3FPLP => GetNullableInt("FPLP");

		/// <summary>
		/// Description: From date
		/// FieldName: FDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public DateTime? M3FDAT => GetNullableDateTime("FDAT");

		/// <summary>
		/// Description: Communication code
		/// FieldName: CMCO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Communication code")]
		public string M3CMCO => GetString("CMCO");

		/// <summary>
		/// Description: Media
		/// FieldName: MEDC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Media")]
		public string M3MEDC => GetString("MEDC");

		/// <summary>
		/// Description: Delivery status indicator
		/// FieldName: RSIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery status indicator")]
		public int? M3RSIN => GetNullableInt("RSIN");
	}
}
// EOF
