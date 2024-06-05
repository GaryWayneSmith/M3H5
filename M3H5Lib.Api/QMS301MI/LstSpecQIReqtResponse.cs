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

namespace M3H5Lib.Api.QMS301MI
{
	public partial class LstSpecQIReqtResponse : M3BaseRecord 
	{

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

		/// <summary>
		/// Description: Request ID
		/// FieldName: QRID
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Request ID")]
		public string M3_QRID => GetString("QRID");

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
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3_BANO => GetString("BANO");

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
		/// Description: Specification status
		/// FieldName: QSST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification status")]
		public int? M3_QSST => GetNullableInt("QSST");

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
		/// Description: Prior status
		/// FieldName: PVST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prior status")]
		public int? M3_PVST => GetNullableInt("PVST");

		/// <summary>
		/// Description: Reason
		/// FieldName: QRSN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reason")]
		public string M3_QRSN => GetString("QRSN");

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
		/// Description: Approved time
		/// FieldName: APTE
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved time")]
		public int? M3_APTE => GetNullableInt("APTE");

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
		/// Description: Rejected date
		/// FieldName: RJDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejected date")]
		public DateTime? M3_RJDT => GetNullableDateTime("RJDT");

		/// <summary>
		/// Description: Rejected time
		/// FieldName: RJTE
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejected time")]
		public int? M3_RJTE => GetNullableInt("RJTE");

		/// <summary>
		/// Description: Rejected by
		/// FieldName: RJUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejected by")]
		public string M3_RJUS => GetString("RJUS");

		/// <summary>
		/// Description: Overrided date
		/// FieldName: OVDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overrided date")]
		public DateTime? M3_OVDT => GetNullableDateTime("OVDT");

		/// <summary>
		/// Description: Overrided time
		/// FieldName: OVTE
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overrided time")]
		public int? M3_OVTE => GetNullableInt("OVTE");

		/// <summary>
		/// Description: Overrided by
		/// FieldName: OVUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overrided by")]
		public string M3_OVUS => GetString("OVUS");

		/// <summary>
		/// Description: Bulk item
		/// FieldName: BITN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bulk item")]
		public string M3_BITN => GetString("BITN");
	}
}
// EOF
