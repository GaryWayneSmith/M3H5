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

namespace M3H5Lib.Api.SOS500MI
{
	public partial class LstAssignmPerSOResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Service order job number
		/// FieldName: JOBN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service order job number")]
		public int? M3_JOBN => GetNullableInt("JOBN");

		/// <summary>
		/// Description: Assignment suffix
		/// FieldName: JBSX
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assignment suffix")]
		public int? M3_JBSX => GetNullableInt("JBSX");

		/// <summary>
		/// Description: Individual item number
		/// FieldName: INNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item number")]
		public string M3_INNO => GetString("INNO");

		/// <summary>
		/// Description: Serial number
		/// FieldName: SERI
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3_SERI => GetString("SERI");

		/// <summary>
		/// Description: Model description
		/// FieldName: MODE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Model description")]
		public string M3_MODE => GetString("MODE");

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
		/// Description: Technician
		/// FieldName: TECH
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Technician")]
		public string M3_TECH => GetString("TECH");

		/// <summary>
		/// Description: Service manager
		/// FieldName: SRES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service manager")]
		public string M3_SRES => GetString("SRES");

		/// <summary>
		/// Description: Error reporting date
		/// FieldName: PMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error reporting date")]
		public DateTime? M3_PMDT => GetNullableDateTime("PMDT");

		/// <summary>
		/// Description: Error report time
		/// FieldName: PMTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error report time")]
		public int? M3_PMTM => GetNullableInt("PMTM");

		/// <summary>
		/// Description: Required start date
		/// FieldName: RQSD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Required start date")]
		public DateTime? M3_RQSD => GetNullableDateTime("RQSD");

		/// <summary>
		/// Description: Required start time
		/// FieldName: RQST
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Required start time")]
		public int? M3_RQST => GetNullableInt("RQST");

		/// <summary>
		/// Description: Required finish date
		/// FieldName: RQFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Required finish date")]
		public DateTime? M3_RQFD => GetNullableDateTime("RQFD");

		/// <summary>
		/// Description: Required finish time
		/// FieldName: RQFT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Required finish time")]
		public int? M3_RQFT => GetNullableInt("RQFT");

		/// <summary>
		/// Description: Confirmed start date
		/// FieldName: CSDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed start date")]
		public DateTime? M3_CSDT => GetNullableDateTime("CSDT");

		/// <summary>
		/// Description: Confirmed start time
		/// FieldName: CSTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed start time")]
		public int? M3_CSTM => GetNullableInt("CSTM");

		/// <summary>
		/// Description: Confirmed finish date
		/// FieldName: CFDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed finish date")]
		public DateTime? M3_CFDA => GetNullableDateTime("CFDA");

		/// <summary>
		/// Description: Confirmed finish time
		/// FieldName: CFTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed finish time")]
		public int? M3_CFTM => GetNullableInt("CFTM");

		/// <summary>
		/// Description: Last start date
		/// FieldName: SSDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last start date")]
		public DateTime? M3_SSDT => GetNullableDateTime("SSDT");

		/// <summary>
		/// Description: Last start time
		/// FieldName: SSTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last start time")]
		public int? M3_SSTM => GetNullableInt("SSTM");

		/// <summary>
		/// Description: Actual start date - assignment
		/// FieldName: RSDJ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start date - assignment")]
		public DateTime? M3_RSDJ => GetNullableDateTime("RSDJ");

		/// <summary>
		/// Description: Actual start time - assignment
		/// FieldName: RSTJ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start time - assignment")]
		public int? M3_RSTJ => GetNullableInt("RSTJ");

		/// <summary>
		/// Description: Actual finish date - assignment
		/// FieldName: RFDJ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual finish date - assignment")]
		public DateTime? M3_RFDJ => GetNullableDateTime("RFDJ");

		/// <summary>
		/// Description: Actual finish time - assignment
		/// FieldName: RFTJ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual finish time - assignment")]
		public int? M3_RFTJ => GetNullableInt("RFTJ");

		/// <summary>
		/// Description: Actual start date - task
		/// FieldName: RSDW
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start date - task")]
		public DateTime? M3_RSDW => GetNullableDateTime("RSDW");

		/// <summary>
		/// Description: Actual start time - task
		/// FieldName: RSTW
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start time - task")]
		public int? M3_RSTW => GetNullableInt("RSTW");

		/// <summary>
		/// Description: Actual finish date - task
		/// FieldName: RFDW
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual finish date - task")]
		public DateTime? M3_RFDW => GetNullableDateTime("RFDW");

		/// <summary>
		/// Description: Actual finish time - task
		/// FieldName: RFTW
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual finish time - task")]
		public int? M3_RFTW => GetNullableInt("RFTW");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: CTNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3_CTNO => GetString("CTNO");

		/// <summary>
		/// Description: Error symptom
		/// FieldName: ESCO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom")]
		public string M3_ESCO => GetString("ESCO");

		/// <summary>
		/// Description: Error cause
		/// FieldName: ERCO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error cause")]
		public string M3_ERCO => GetString("ERCO");

		/// <summary>
		/// Description: Payer control
		/// FieldName: DBCO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer control")]
		public string M3_DBCO => GetString("DBCO");

		/// <summary>
		/// Description: Service expense
		/// FieldName: SVID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service expense")]
		public string M3_SVID => GetString("SVID");

		/// <summary>
		/// Description: Forecast work hours
		/// FieldName: WOTM
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast work hours")]
		public int? M3_WOTM => GetNullableInt("WOTM");

		/// <summary>
		/// Description: Planned preparation time
		/// FieldName: PRTM
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned preparation time")]
		public int? M3_PRTM => GetNullableInt("PRTM");

		/// <summary>
		/// Description: Planned completion time
		/// FieldName: FITM
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned completion time")]
		public int? M3_FITM => GetNullableInt("FITM");

		/// <summary>
		/// Description: Planned travel time
		/// FieldName: TRTI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned travel time")]
		public int? M3_TRTI => GetNullableInt("TRTI");

		/// <summary>
		/// Description: Planned start date - task
		/// FieldName: PSDW
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date - task")]
		public DateTime? M3_PSDW => GetNullableDateTime("PSDW");

		/// <summary>
		/// Description: Planned start time - task
		/// FieldName: PSTW
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time - task")]
		public int? M3_PSTW => GetNullableInt("PSTW");

		/// <summary>
		/// Description: Planned finish date - task
		/// FieldName: PFDW
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date - task")]
		public DateTime? M3_PFDW => GetNullableDateTime("PFDW");

		/// <summary>
		/// Description: Planned finish time - task
		/// FieldName: PFTW
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time - task")]
		public int? M3_PFTW => GetNullableInt("PFTW");

		/// <summary>
		/// Description: Planned start date - assignment
		/// FieldName: PSDJ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date - assignment")]
		public DateTime? M3_PSDJ => GetNullableDateTime("PSDJ");

		/// <summary>
		/// Description: Planned start time - assignment
		/// FieldName: PSTJ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time - assignment")]
		public int? M3_PSTJ => GetNullableInt("PSTJ");

		/// <summary>
		/// Description: Planned finish date - assignment
		/// FieldName: PFDJ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date - assignment")]
		public DateTime? M3_PFDJ => GetNullableDateTime("PFDJ");

		/// <summary>
		/// Description: Planned finish time - assignment
		/// FieldName: PFTJ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time - assignment")]
		public int? M3_PFTJ => GetNullableInt("PFTJ");

		/// <summary>
		/// Description: Action text
		/// FieldName: MTCO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action text")]
		public string M3_MTCO => GetString("MTCO");

		/// <summary>
		/// Description: Action
		/// FieldName: MECO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action")]
		public string M3_MECO => GetString("MECO");

		/// <summary>
		/// Description: Priority
		/// FieldName: OPRI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3_OPRI => GetNullableInt("OPRI");

		/// <summary>
		/// Description: Joint delivery
		/// FieldName: JDCD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Joint delivery")]
		public string M3_JDCD => GetString("JDCD");

		/// <summary>
		/// Description: Status service assignment
		/// FieldName: JBST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status service assignment")]
		public string M3_JBST => GetString("JBST");

		/// <summary>
		/// Description: Project number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number")]
		public string M3_PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3_ELNO => GetString("ELNO");

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

		/// <summary>
		/// Description: Assignment type
		/// FieldName: ASST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assignment type")]
		public string M3_ASST => GetString("ASST");

		/// <summary>
		/// Description: Function area
		/// FieldName: FCTN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function area")]
		public string M3_FCTN => GetString("FCTN");

		/// <summary>
		/// Description: Transportation of individual item
		/// FieldName: TRIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation of individual item")]
		public int? M3_TRIN => GetNullableInt("TRIN");

		/// <summary>
		/// Description: Qualification
		/// FieldName: QUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Qualification")]
		public string M3_QUNO => GetString("QUNO");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Location
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3_WHSL => GetString("WHSL");

		/// <summary>
		/// Description: Additional status
		/// FieldName: JBSE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional status")]
		public string M3_JBSE => GetString("JBSE");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3_SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Latest finish date
		/// FieldName: LFDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Latest finish date")]
		public DateTime? M3_LFDA => GetNullableDateTime("LFDA");

		/// <summary>
		/// Description: Latest finish time
		/// FieldName: LFTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Latest finish time")]
		public int? M3_LFTM => GetNullableInt("LFTM");

		/// <summary>
		/// Description: Allocation block code
		/// FieldName: ABLC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocation block code")]
		public int? M3_ABLC => GetNullableInt("ABLC");

		/// <summary>
		/// Description: Authority required
		/// FieldName: ATQC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authority required")]
		public int? M3_ATQC => GetNullableInt("ATQC");

		/// <summary>
		/// Description: Fixed price exist
		/// FieldName: FIXE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed price exist")]
		public string M3_FIXE => GetString("FIXE");

		/// <summary>
		/// Description: Pre-text exist
		/// FieldName: TEX1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pre-text exist")]
		public string M3_TEX1 => GetString("TEX1");

		/// <summary>
		/// Description: Post-text exist
		/// FieldName: TEX2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-text exist")]
		public string M3_TEX2 => GetString("TEX2");

		/// <summary>
		/// Description: F6-text exist
		/// FieldName: TEX3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("F6-text exist")]
		public string M3_TEX3 => GetString("TEX3");

		/// <summary>
		/// Description: Response time
		/// FieldName: APTM
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Response time")]
		public int? M3_APTM => GetNullableInt("APTM");

		/// <summary>
		/// Description: Sent to remote server
		/// FieldName: PLME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sent to remote server")]
		public int? M3_PLME => GetNullableInt("PLME");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3_RORN => GetString("RORN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3_RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3_RORX => GetNullableInt("RORX");
	}
}
// EOF
