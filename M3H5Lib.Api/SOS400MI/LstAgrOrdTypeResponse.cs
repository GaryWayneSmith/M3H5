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

namespace M3H5Lib.Api.SOS400MI
{
	public partial class LstAgrOrdTypeResponse : M3BaseRecord 
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
		/// Description: Agreement order type
		/// FieldName: AOTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement order type")]
		public string M3_AOTP => GetString("AOTP");

		/// <summary>
		/// Description: Agreement order category
		/// FieldName: AOTK
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement order category")]
		public string M3_AOTK => GetString("AOTK");

		/// <summary>
		/// Description: Next manual function
		/// FieldName: NEXT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next manual function")]
		public int? M3_NEXT => GetNullableInt("NEXT");

		/// <summary>
		/// Description: Agreement order type description
		/// FieldName: ATDE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement order type description")]
		public string M3_ATDE => GetString("ATDE");

		/// <summary>
		/// Description: Agreement type
		/// FieldName: AT51
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement type")]
		public string M3_AT51 => GetString("AT51");

		/// <summary>
		/// Description: Indiv item number in agr
		/// FieldName: AT52
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Indiv item number in agr")]
		public int? M3_AT52 => GetNullableInt("AT52");

		/// <summary>
		/// Description: Item number in agreement
		/// FieldName: AT53
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number in agreement")]
		public int? M3_AT53 => GetNullableInt("AT53");

		/// <summary>
		/// Description: Several agreement types
		/// FieldName: AT54
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Several agreement types")]
		public int? M3_AT54 => GetNullableInt("AT54");

		/// <summary>
		/// Description: Sales price rule
		/// FieldName: AT57
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price rule")]
		public int? M3_AT57 => GetNullableInt("AT57");

		/// <summary>
		/// Description: Discount updates
		/// FieldName: AT58
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount updates")]
		public int? M3_AT58 => GetNullableInt("AT58");

		/// <summary>
		/// Description: Check sequence item identity
		/// FieldName: AT60
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check sequence item identity")]
		public string M3_AT60 => GetString("AT60");

		/// <summary>
		/// Description: Contract item
		/// FieldName: AT77
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Contract item")]
		public string M3_AT77 => GetString("AT77");

		/// <summary>
		/// Description: Serv ord type - prev service
		/// FieldName: PSOT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv ord type - prev service")]
		public string M3_PSOT => GetString("PSOT");

		/// <summary>
		/// Description: Serv ord type - agr order
		/// FieldName: AIOT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serv ord type - agr order")]
		public string M3_AIOT => GetString("AIOT");

		/// <summary>
		/// Description: Credit check
		/// FieldName: AT80
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit check")]
		public int? M3_AT80 => GetNullableInt("AT80");

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
	}
}
// EOF
