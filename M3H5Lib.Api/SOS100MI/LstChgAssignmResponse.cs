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

namespace M3H5Lib.Api.SOS100MI
{
	public partial class LstChgAssignmResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Service order number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service order number")]
		public string M3ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Assignment number
		/// FieldName: JOBN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assignment number")]
		public int? M3JOBN => GetNullableInt("JOBN");

		/// <summary>
		/// Description: Assignment suffix
		/// FieldName: JBSX
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assignment suffix")]
		public int? M3JBSX => GetNullableInt("JBSX");

		/// <summary>
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Customer address 1
		/// FieldName: CUA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 1")]
		public string M3CUA1 => GetString("CUA1");

		/// <summary>
		/// Description: Customer address 2
		/// FieldName: CUA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 2")]
		public string M3CUA2 => GetString("CUA2");

		/// <summary>
		/// Description: Customer address 3
		/// FieldName: CUA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 3")]
		public string M3CUA3 => GetString("CUA3");

		/// <summary>
		/// Description: Customer address 4
		/// FieldName: CUA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 4")]
		public string M3CUA4 => GetString("CUA4");

		/// <summary>
		/// Description: Your reference
		/// FieldName: YREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference")]
		public string M3YREF => GetString("YREF");

		/// <summary>
		/// Description: Phone number
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Phone number")]
		public string M3PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Service manager
		/// FieldName: SRES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service manager")]
		public string M3SRES => GetString("SRES");

		/// <summary>
		/// Description: Technician
		/// FieldName: TECH
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Technician")]
		public string M3TECH => GetString("TECH");

		/// <summary>
		/// Description: Due date
		/// FieldName: DUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3DUDT => GetNullableDateTime("DUDT");

		/// <summary>
		/// Description: Due time
		/// FieldName: DUTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due time")]
		public int? M3DUTM => GetNullableInt("DUTM");

		/// <summary>
		/// Description: Duration - Forceasted work hours
		/// FieldName: WOTM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Duration - Forceasted work hours")]
		public int? M3WOTM => GetNullableInt("WOTM");

		/// <summary>
		/// Description: Duration in minutes
		/// FieldName: DURA
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Duration in minutes")]
		public int? M3DURA => GetNullableInt("DURA");

		/// <summary>
		/// Description: Error reporting date
		/// FieldName: PMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error reporting date")]
		public DateTime? M3PMDT => GetNullableDateTime("PMDT");

		/// <summary>
		/// Description: Error reporting time
		/// FieldName: PMTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error reporting time")]
		public int? M3PMTM => GetNullableInt("PMTM");

		/// <summary>
		/// Description: Last start date
		/// FieldName: SSDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last start date")]
		public DateTime? M3SSDT => GetNullableDateTime("SSDT");

		/// <summary>
		/// Description: Last start time
		/// FieldName: SSTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last start time")]
		public int? M3SSTM => GetNullableInt("SSTM");

		/// <summary>
		/// Description: Postal code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3PONO => GetString("PONO");

		/// <summary>
		/// Description: Assignment type
		/// FieldName: ASST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assignment type")]
		public string M3ASST => GetString("ASST");

		/// <summary>
		/// Description: Priority
		/// FieldName: OPRI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3OPRI => GetNullableInt("OPRI");

		/// <summary>
		/// Description: Planned start date assignment
		/// FieldName: PSDJ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date assignment")]
		public DateTime? M3PSDJ => GetNullableDateTime("PSDJ");

		/// <summary>
		/// Description: Planned start time assignment
		/// FieldName: PSTJ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time assignment")]
		public int? M3PSTJ => GetNullableInt("PSTJ");

		/// <summary>
		/// Description: Planned finish date assignment
		/// FieldName: PFDJ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date assignment")]
		public DateTime? M3PFDJ => GetNullableDateTime("PFDJ");

		/// <summary>
		/// Description: Planned finish time assignment
		/// FieldName: PFTJ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time assignment")]
		public int? M3PFTJ => GetNullableInt("PFTJ");

		/// <summary>
		/// Description: Error symptom text 1
		/// FieldName: ETX1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom text 1")]
		public string M3ETX1 => GetString("ETX1");

		/// <summary>
		/// Description: Error symptom text 2
		/// FieldName: ETX2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom text 2")]
		public string M3ETX2 => GetString("ETX2");

		/// <summary>
		/// Description: Individual item number
		/// FieldName: INNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item number")]
		public string M3INNO => GetString("INNO");

		/// <summary>
		/// Description: Model description
		/// FieldName: MODE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Model description")]
		public string M3MODE => GetString("MODE");

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
		/// FieldName: SERI
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SERI => GetString("SERI");

		/// <summary>
		/// Description: Skill - Qualification
		/// FieldName: QUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Skill - Qualification")]
		public string M3QUNO => GetString("QUNO");

		/// <summary>
		/// Description: Assignment status
		/// FieldName: JBST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assignment status")]
		public string M3JBST => GetString("JBST");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");
	}
}
// EOF
