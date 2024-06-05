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

namespace M3H5Lib.Api.ECS200MI
{
	public partial class LstModRefCompResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Engineering order number
		/// FieldName: AECN
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Engineering order number")]
		public string M3_AECN => GetString("AECN");

		/// <summary>
		/// Description: Revision number - engineering order
		/// FieldName: AECR
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number - engineering order")]
		public string M3_AECR => GetString("AECR");

		/// <summary>
		/// Description: Old item number
		/// FieldName: AOPN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old item number")]
		public string M3_AOPN => GetString("AOPN");

		/// <summary>
		/// Description: Modification marking
		/// FieldName: MODM
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Modification marking")]
		public string M3_MODM => GetString("MODM");

		/// <summary>
		/// Description: New item number
		/// FieldName: ANPN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New item number")]
		public string M3_ANPN => GetString("ANPN");

		/// <summary>
		/// Description: Instruction
		/// FieldName: AINS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Instruction")]
		public string M3_AINS => GetString("AINS");

		/// <summary>
		/// Description: Quantity
		/// FieldName: CNQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity")]
		public decimal? M3_CNQT => GetNullableDecimal("CNQT");
	}
}
// EOF
