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

namespace M3H5Lib.Api.CRS065MI
{
	public partial class GetDelyTermResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Deliveryterms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deliveryterms")]
		public string M3TEDL => GetString("TEDL");

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
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Termstext
		/// FieldName: TEL1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Termstext")]
		public string M3TEL1 => GetString("TEL1");

		/// <summary>
		/// Description: Termstext
		/// FieldName: TEL2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Termstext")]
		public string M3TEL2 => GetString("TEL2");

		/// <summary>
		/// Description: Recipientpays
		/// FieldName: RCPY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recipientpays")]
		public int? M3RCPY => GetNullableInt("RCPY");

		/// <summary>
		/// Description: Goodsresponsibility
		/// FieldName: DELT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Goodsresponsibility")]
		public int? M3DELT => GetNullableInt("DELT");

		/// <summary>
		/// Description: Adjustmentfactorconsignee
		/// FieldName: ADJR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjustmentfactorconsignee")]
		public int? M3ADJR => GetNullableInt("ADJR");

		/// <summary>
		/// Description: Adjustmentfactorconsignor
		/// FieldName: ADJS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjustmentfactorconsignor")]
		public int? M3ADJS => GetNullableInt("ADJS");

		/// <summary>
		/// Description: Deliveryterms-INTRASTAT
		/// FieldName: ECDT
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deliveryterms-INTRASTAT")]
		public string M3ECDT => GetString("ECDT");

		/// <summary>
		/// Description: Delivery terms - Extrastat (Extra)
		/// FieldName: EXTD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms - Extrastat (Extra)")]
		public string M3EXTD => GetString("EXTD");

		/// <summary>
		/// Description: Tax point
		/// FieldName: TXPO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax point")]
		public int? M3TXPO => GetNullableInt("TXPO");

		/// <summary>
		/// Description: Freight cost control
		/// FieldName: FRCK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight cost control")]
		public int? M3FRCK => GetNullableInt("FRCK");

		/// <summary>
		/// Description: Fiscal representative rule
		/// FieldName: FRRU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fiscal representative rule")]
		public int? M3FRRU => GetNullableInt("FRRU");
	}
}
// EOF
