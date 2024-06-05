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

namespace M3H5Lib.Api.SOS200MI
{
	public partial class LstDiscNumbersResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Discount number
		/// FieldName: DIPO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount number")]
		public int? M3_DIPO => GetNullableInt("DIPO");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Additional text
		/// FieldName: TX08
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional text")]
		public string M3_TX08 => GetString("TX08");

		/// <summary>
		/// Description: Accumulation
		/// FieldName: DACC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accumulation")]
		public int? M3_DACC => GetNullableInt("DACC");

		/// <summary>
		/// Description: Manually changeable discount
		/// FieldName: DCHA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manually changeable discount")]
		public int? M3_DCHA => GetNullableInt("DCHA");

		/// <summary>
		/// Description: Discount presentation
		/// FieldName: DDSU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount presentation")]
		public int? M3_DDSU => GetNullableInt("DDSU");

		/// <summary>
		/// Description: Allocated discount number
		/// FieldName: ALDP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated discount number")]
		public int? M3_ALDP => GetNullableInt("ALDP");

		/// <summary>
		/// Description: Discount type
		/// FieldName: DITP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount type")]
		public int? M3_DITP => GetNullableInt("DITP");

		/// <summary>
		/// Description: Discount base
		/// FieldName: DIBE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount base")]
		public string M3_DIBE => GetString("DIBE");

		/// <summary>
		/// Description: Discount relation
		/// FieldName: DIRE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount relation")]
		public string M3_DIRE => GetString("DIRE");

		/// <summary>
		/// Description: Internal discount
		/// FieldName: IDSC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal discount")]
		public int? M3_IDSC => GetNullableInt("IDSC");

		/// <summary>
		/// Description: Discount scale base
		/// FieldName: SGGB
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount scale base")]
		public string M3_SGGB => GetString("SGGB");

		/// <summary>
		/// Description: Discount scale code
		/// FieldName: SGGC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount scale code")]
		public string M3_SGGC => GetString("SGGC");

		/// <summary>
		/// Description: Scale unit of measure
		/// FieldName: SGGU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scale unit of measure")]
		public string M3_SGGU => GetString("SGGU");

		/// <summary>
		/// Description: Discount model
		/// FieldName: DISY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount model")]
		public string M3_DISY => GetString("DISY");
	}
}
// EOF
