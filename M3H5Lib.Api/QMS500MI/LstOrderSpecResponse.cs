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

namespace M3H5Lib.Api.QMS500MI
{
	public partial class LstOrderSpecResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Specification
		/// FieldName: SPEC
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification")]
		public string M3SPEC => GetString("SPEC");

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
		/// Description: Effective date
		/// FieldName: QSE1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effective date")]
		public DateTime? M3QSE1 => GetNullableDateTime("QSE1");

		/// <summary>
		/// Description: Effective time
		/// FieldName: QSE2
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effective time")]
		public int? M3QSE2 => GetNullableInt("QSE2");

		/// <summary>
		/// Description: Bulk item
		/// FieldName: BITN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bulk item")]
		public string M3BITN => GetString("BITN");

		/// <summary>
		/// Description: Inactive date
		/// FieldName: QSI1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inactive date")]
		public DateTime? M3QSI1 => GetNullableDateTime("QSI1");

		/// <summary>
		/// Description: Inactive time
		/// FieldName: QSI2
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inactive time")]
		public int? M3QSI2 => GetNullableInt("QSI2");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Date approved
		/// FieldName: APDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date approved")]
		public DateTime? M3APDT => GetNullableDateTime("APDT");

		/// <summary>
		/// Description: Approved by
		/// FieldName: APUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved by")]
		public string M3APUS => GetString("APUS");

		/// <summary>
		/// Description: Deactivated date
		/// FieldName: DVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deactivated date")]
		public DateTime? M3DVDT => GetNullableDateTime("DVDT");

		/// <summary>
		/// Description: Deactivated by
		/// FieldName: DVUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deactivated by")]
		public string M3DVUS => GetString("DVUS");

		/// <summary>
		/// Description: Spec type
		/// FieldName: SPET
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Spec type")]
		public int? M3SPET => GetNullableInt("SPET");

		/// <summary>
		/// Description: Retest
		/// FieldName: SRTT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Retest")]
		public int? M3SRTT => GetNullableInt("SRTT");

		/// <summary>
		/// Description: Reclassification
		/// FieldName: SRCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reclassification")]
		public int? M3SRCL => GetNullableInt("SRCL");

		/// <summary>
		/// Description: Auto attach
		/// FieldName: AUAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Auto attach")]
		public int? M3AUAT => GetNullableInt("AUAT");

		/// <summary>
		/// Description: LI specification manager
		/// FieldName: SPRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("LI specification manager")]
		public string M3SPRE => GetString("SPRE");

		/// <summary>
		/// Description: Laboratory manager
		/// FieldName: SPAN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Laboratory manager")]
		public string M3SPAN => GetString("SPAN");

		/// <summary>
		/// Description: Number of copies
		/// FieldName: NBEX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of copies")]
		public int? M3NBEX => GetNullableInt("NBEX");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI01
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3SI01 => GetString("SI01");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI02
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3SI02 => GetString("SI02");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI03
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3SI03 => GetString("SI03");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI04
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3SI04 => GetString("SI04");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI05
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3SI05 => GetString("SI05");

		/// <summary>
		/// Description: Blending
		/// FieldName: SBLN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blending")]
		public int? M3SBLN => GetNullableInt("SBLN");

		/// <summary>
		/// Description: Retest DO rec
		/// FieldName: SDOR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Retest DO rec")]
		public int? M3SDOR => GetNullableInt("SDOR");
	}
}
// EOF
