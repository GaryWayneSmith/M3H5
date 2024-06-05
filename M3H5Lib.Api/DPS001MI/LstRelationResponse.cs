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

namespace M3H5Lib.Api.DPS001MI
{
	public partial class LstRelationResponse : M3BaseRecord 
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
		/// Description: Relation type
		/// FieldName: RLTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Relation type")]
		public int? M3RLTY => GetNullableInt("RLTY");

		/// <summary>
		/// Description: From Warehouse
		/// FieldName: FWLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From Warehouse")]
		public string M3FWLO => GetString("FWLO");

		/// <summary>
		/// Description: To Warehouse
		/// FieldName: TWLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To Warehouse")]
		public string M3TWLO => GetString("TWLO");

		/// <summary>
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3MODL => GetString("MODL");

		/// <summary>
		/// Description: Transportation days
		/// FieldName: TRDY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation days")]
		public int? M3TRDY => GetNullableInt("TRDY");

		/// <summary>
		/// Description: Transportation hours
		/// FieldName: TRTE
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation hours")]
		public int? M3TRTE => GetNullableInt("TRTE");
	}
}
// EOF
