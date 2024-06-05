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

namespace M3H5Lib.Api.MOS446MI
{
	public partial class LstSiteCompResponse : M3BaseRecord 
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
		/// Description: Site
		/// FieldName: MOTP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Site")]
		public string M3_MOTP => GetString("MOTP");

		/// <summary>
		/// Description: Structure type
		/// FieldName: CSTR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type")]
		public string M3_CSTR => GetString("CSTR");

		/// <summary>
		/// Description: NHA Configuration Position
		/// FieldName: CFGH
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NHA Configuration Position")]
		public string M3_CFGH => GetString("CFGH");

		/// <summary>
		/// Description: Position/Equipment/Spare part
		/// FieldName: CFGL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Position/Equipment/Spare part")]
		public string M3_CFGL => GetString("CFGL");

		/// <summary>
		/// Description: Position/Equipment/spare part code 0/1/2
		/// FieldName: POEQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Position/Equipment/spare part code 0/1/2")]
		public int? M3_POEQ => GetNullableInt("POEQ");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Pos/Eq/spare description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pos/Eq/spare description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Lover level exists                   +/-
		/// FieldName: PLUS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lover level exists                   +/-")]
		public string M3_PLUS => GetString("PLUS");

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Serial number
		/// FieldName: SERN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3_SERN => GetString("SERN");

		/// <summary>
		/// Description: SubEquipment exists
		/// FieldName: SUBE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SubEquipment exists")]
		public string M3_SUBE => GetString("SUBE");
	}
}
// EOF
