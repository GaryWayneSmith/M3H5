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

namespace M3H5Lib.Api.QMS200MI
{
	public partial class LstSpecsBySpecResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Specification
		/// FieldName: SPEC
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification")]
		public string M3_SPEC => GetString("SPEC");

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
		/// Description: Quality group
		/// FieldName: QMGP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quality group")]
		public string M3_QMGP => GetString("QMGP");

		/// <summary>
		/// Description: Effective date
		/// FieldName: QSE1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effective date")]
		public DateTime? M3_QSE1 => GetNullableDateTime("QSE1");

		/// <summary>
		/// Description: Effective time
		/// FieldName: QSE2
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effective time")]
		public int? M3_QSE2 => GetNullableInt("QSE2");

		/// <summary>
		/// Description: Inactive date
		/// FieldName: QSI1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inactive date")]
		public DateTime? M3_QSI1 => GetNullableDateTime("QSI1");

		/// <summary>
		/// Description: Inactive time
		/// FieldName: QSI2
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inactive time")]
		public int? M3_QSI2 => GetNullableInt("QSI2");

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
		/// Description: Date approved
		/// FieldName: APDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date approved")]
		public DateTime? M3_APDT => GetNullableDateTime("APDT");

		/// <summary>
		/// Description: Approved by
		/// FieldName: APUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved by")]
		public string M3_APUS => GetString("APUS");

		/// <summary>
		/// Description: Deactivated date
		/// FieldName: DVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deactivated date")]
		public DateTime? M3_DVDT => GetNullableDateTime("DVDT");

		/// <summary>
		/// Description: Deactivated by
		/// FieldName: DVUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deactivated by")]
		public string M3_DVUS => GetString("DVUS");

		/// <summary>
		/// Description: Spec type
		/// FieldName: SPET
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Spec type")]
		public int? M3_SPET => GetNullableInt("SPET");

		/// <summary>
		/// Description: Retest
		/// FieldName: SRTT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Retest")]
		public int? M3_SRTT => GetNullableInt("SRTT");

		/// <summary>
		/// Description: Reclassification
		/// FieldName: SRCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reclassification")]
		public int? M3_SRCL => GetNullableInt("SRCL");

		/// <summary>
		/// Description: Auto attach
		/// FieldName: AUAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Auto attach")]
		public int? M3_AUAT => GetNullableInt("AUAT");

		/// <summary>
		/// Description: LI specification manager
		/// FieldName: SPRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("LI specification manager")]
		public string M3_SPRE => GetString("SPRE");

		/// <summary>
		/// Description: Laboratory manager
		/// FieldName: SPAN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Laboratory manager")]
		public string M3_SPAN => GetString("SPAN");

		/// <summary>
		/// Description: Number of copies
		/// FieldName: NBEX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of copies")]
		public int? M3_NBEX => GetNullableInt("NBEX");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI01
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3_SI01 => GetString("SI01");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI02
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3_SI02 => GetString("SI02");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI03
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3_SI03 => GetString("SI03");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI04
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3_SI04 => GetString("SI04");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI05
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3_SI05 => GetString("SI05");

		/// <summary>
		/// Description: Test at pre-shipment
		/// FieldName: TPSH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test at pre-shipment")]
		public int? M3_TPSH => GetNullableInt("TPSH");

		/// <summary>
		/// Description: Blending
		/// FieldName: SBLN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blending")]
		public int? M3_SBLN => GetNullableInt("SBLN");

		/// <summary>
		/// Description: Selectable for agreement
		/// FieldName: SAGN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selectable for agreement")]
		public int? M3_SAGN => GetNullableInt("SAGN");

		/// <summary>
		/// Description: Retest DO receipt
		/// FieldName: SDOR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Retest DO receipt")]
		public int? M3_SDOR => GetNullableInt("SDOR");
	}
}
// EOF
