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

namespace M3H5Lib.Api.MOS390MI
{
	public partial class ChkWarMtrlResponse : M3BaseRecord 
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
		/// Description: Serial number
		/// FieldName: SERN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SERN => GetString("SERN");

		/// <summary>
		/// Description: Warranty date
		/// FieldName: WADT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty date")]
		public DateTime? M3WADT => GetNullableDateTime("WADT");

		/// <summary>
		/// Description: Warranty type
		/// FieldName: WATP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty type")]
		public string M3WATP => GetString("WATP");

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
		/// Description: Content category
		/// FieldName: CNCT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Content category")]
		public string M3CNCT => GetString("CNCT");

		/// <summary>
		/// Description: Excluded
		/// FieldName: EXCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Excluded")]
		public int? M3EXCL => GetNullableInt("EXCL");

		/// <summary>
		/// Description: Line type
		/// FieldName: ALNT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line type")]
		public int? M3ALNT => GetNullableInt("ALNT");

		/// <summary>
		/// Description: Item ID type
		/// FieldName: IDTY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item ID type")]
		public int? M3IDTY => GetNullableInt("IDTY");

		/// <summary>
		/// Description: Item ID
		/// FieldName: IDEN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item ID")]
		public string M3IDEN => GetString("IDEN");

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
		/// Description: Agreement number
		/// FieldName: AAGN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3AAGN => GetString("AAGN");

		/// <summary>
		/// Description: Service bill of material
		/// FieldName: ASBO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service bill of material")]
		public int? M3ASBO => GetNullableInt("ASBO");

		/// <summary>
		/// Description: Return processing
		/// FieldName: RTPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return processing")]
		public int? M3RTPR => GetNullableInt("RTPR");

		/// <summary>
		/// Description: Settlement
		/// FieldName: SLEM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Settlement")]
		public int? M3SLEM => GetNullableInt("SLEM");

		/// <summary>
		/// Description: Claimable
		/// FieldName: CLYN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claimable")]
		public int? M3CLYN => GetNullableInt("CLYN");

		/// <summary>
		/// Description: Claim price
		/// FieldName: CLPR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim price")]
		public string M3CLPR => GetString("CLPR");

		/// <summary>
		/// Description: Claim story
		/// FieldName: CSTO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim story")]
		public int? M3CSTO => GetNullableInt("CSTO");

		/// <summary>
		/// Description: Claim limit amount
		/// FieldName: CAML
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim limit amount")]
		public decimal? M3CAML => GetNullableDecimal("CAML");

		/// <summary>
		/// Description: Claim max labor hours
		/// FieldName: CLLA
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim max labor hours")]
		public int? M3CLLA => GetNullableInt("CLLA");
	}
}
// EOF
