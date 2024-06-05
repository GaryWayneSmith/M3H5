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

namespace M3H5Lib.Api.RPS300MI
{
	public partial class SelMatByHeadResponse : M3BaseRecord 
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
		/// Description: Macro order number
		/// FieldName: MONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order number")]
		public string M3_MONO => GetString("MONO");

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
		/// Description: Macro order qualifier
		/// FieldName: MOQF
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order qualifier")]
		public string M3_MOQF => GetString("MOQF");

		/// <summary>
		/// Description: Macro order value
		/// FieldName: MOQV
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order value")]
		public string M3_MOQV => GetString("MOQV");

		/// <summary>
		/// Description: Bucket end date
		/// FieldName: EDBU
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bucket end date")]
		public DateTime? M3_EDBU => GetNullableDateTime("EDBU");

		/// <summary>
		/// Description: Bucket start date
		/// FieldName: SDBU
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bucket start date")]
		public DateTime? M3_SDBU => GetNullableDateTime("SDBU");

		/// <summary>
		/// Description: Reserved quantity
		/// FieldName: REQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reserved quantity")]
		public decimal? M3_REQT => GetNullableDecimal("REQT");

		/// <summary>
		/// Description: Unit of measurement
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit of measurement")]
		public string M3_UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Allocated quantity
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity")]
		public decimal? M3_ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Material sequence number
		/// FieldName: SEMA
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material sequence number")]
		public int? M3_SEMA => GetNullableInt("SEMA");

		/// <summary>
		/// Description: Operation sequence number
		/// FieldName: SEOP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation sequence number")]
		public int? M3_SEOP => GetNullableInt("SEOP");

		/// <summary>
		/// Description: Reservation date
		/// FieldName: RDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reservation date")]
		public DateTime? M3_RDAT => GetNullableDateTime("RDAT");

		/// <summary>
		/// Description: Attribute value alpha 1
		/// FieldName: AVA1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value alpha 1")]
		public string M3_AVA1 => GetString("AVA1");

		/// <summary>
		/// Description: Attribute value alpha 2
		/// FieldName: AVA2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value alpha 2")]
		public string M3_AVA2 => GetString("AVA2");

		/// <summary>
		/// Description: Attribute value alpha 3
		/// FieldName: AVA3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value alpha 3")]
		public string M3_AVA3 => GetString("AVA3");

		/// <summary>
		/// Description: Attribute value alpha 4
		/// FieldName: AVA4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value alpha 4")]
		public string M3_AVA4 => GetString("AVA4");

		/// <summary>
		/// Description: Attribute value alpha 5
		/// FieldName: AVA5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value alpha 5")]
		public string M3_AVA5 => GetString("AVA5");

		/// <summary>
		/// Description: Attrubite value numeric 1
		/// FieldName: AVN1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attrubite value numeric 1")]
		public decimal? M3_AVN1 => GetNullableDecimal("AVN1");

		/// <summary>
		/// Description: Attrubite value numeric 2
		/// FieldName: AVN2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attrubite value numeric 2")]
		public decimal? M3_AVN2 => GetNullableDecimal("AVN2");

		/// <summary>
		/// Description: Attrubite value numeric 3
		/// FieldName: AVN3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attrubite value numeric 3")]
		public decimal? M3_AVN3 => GetNullableDecimal("AVN3");

		/// <summary>
		/// Description: Attrubite value numeric 4
		/// FieldName: AVN4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attrubite value numeric 4")]
		public decimal? M3_AVN4 => GetNullableDecimal("AVN4");

		/// <summary>
		/// Description: Attrubite value numeric 5
		/// FieldName: AVN5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attrubite value numeric 5")]
		public decimal? M3_AVN5 => GetNullableDecimal("AVN5");

		/// <summary>
		/// Description: Safety time
		/// FieldName: SATD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety time")]
		public int? M3_SATD => GetNullableInt("SATD");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");

		/// <summary>
		/// Description: Time hours & minutes
		/// FieldName: TIHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time hours & minutes")]
		public int? M3_TIHM => GetNullableInt("TIHM");

		/// <summary>
		/// Description: Shipping buffer in production days
		/// FieldName: SHBP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipping buffer in production days")]
		public int? M3_SHBP => GetNullableInt("SHBP");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");
	}
}
// EOF
