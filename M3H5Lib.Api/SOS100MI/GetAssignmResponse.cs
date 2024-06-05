/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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
	public partial class GetAssignmResponse : M3BaseRecord 
	{

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
		/// Description: Error symtom code
		/// FieldName: ESCO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symtom code")]
		public string M3ESCO => GetString("ESCO");

		/// <summary>
		/// Description: Error symtom text 1
		/// FieldName: ETX1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symtom text 1")]
		public string M3ETX1 => GetString("ETX1");

		/// <summary>
		/// Description: Error symtom text 2
		/// FieldName: ETX2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symtom text 2")]
		public string M3ETX2 => GetString("ETX2");

		/// <summary>
		/// Description: Error symtom text 3
		/// FieldName: ETX3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symtom text 3")]
		public string M3ETX3 => GetString("ETX3");

		/// <summary>
		/// Description: Error symtom text 4
		/// FieldName: ETX4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symtom text 4")]
		public string M3ETX4 => GetString("ETX4");

		/// <summary>
		/// Description: Payer control
		/// FieldName: DBCO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer control")]
		public string M3DBCO => GetString("DBCO");

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
		/// Description: Forcasted work hours
		/// FieldName: WOTM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forcasted work hours")]
		public int? M3WOTM => GetNullableInt("WOTM");

		/// <summary>
		/// Description: Qualification
		/// FieldName: QUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Qualification")]
		public string M3QUNO => GetString("QUNO");

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
		/// Description: Line status - Lowest
		/// FieldName: ORSL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line status - Lowest")]
		public string M3ORSL => GetString("ORSL");

		/// <summary>
		/// Description: Line status - Highest
		/// FieldName: ORST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line status - Highest")]
		public string M3ORST => GetString("ORST");

		/// <summary>
		/// Description: Error report date
		/// FieldName: PMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error report date")]
		public DateTime? M3PMDT => GetNullableDateTime("PMDT");

		/// <summary>
		/// Description: Error report time
		/// FieldName: PMTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error report time")]
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
		/// Description: Planned start date task
		/// FieldName: PSDW
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date task")]
		public DateTime? M3PSDW => GetNullableDateTime("PSDW");

		/// <summary>
		/// Description: Planned start time task
		/// FieldName: PSTW
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time task")]
		public int? M3PSTW => GetNullableInt("PSTW");

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
		/// Description: Planned finish date task
		/// FieldName: PFDW
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date task")]
		public DateTime? M3PFDW => GetNullableDateTime("PFDW");

		/// <summary>
		/// Description: Planned finish time task
		/// FieldName: PFTW
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time task")]
		public int? M3PFTW => GetNullableInt("PFTW");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: CTNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3CTNO => GetString("CTNO");

		/// <summary>
		/// Description: Valid from date (agreement)
		/// FieldName: VADF
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from date (agreement)")]
		public DateTime? M3VADF => GetNullableDateTime("VADF");

		/// <summary>
		/// Description: Valid to date (agreement)
		/// FieldName: VADT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to date (agreement)")]
		public DateTime? M3VADT => GetNullableDateTime("VADT");

		/// <summary>
		/// Description: Agreement type
		/// FieldName: AGTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement type")]
		public string M3AGTP => GetString("AGTP");

		/// <summary>
		/// Description: Project number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number")]
		public string M3PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3ELNO => GetString("ELNO");

		/// <summary>
		/// Description: Error cause
		/// FieldName: ERCO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error cause")]
		public string M3ERCO => GetString("ERCO");

		/// <summary>
		/// Description: Action code
		/// FieldName: MECO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action code")]
		public string M3MECO => GetString("MECO");

		/// <summary>
		/// Description: Action text code
		/// FieldName: MTCO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action text code")]
		public string M3MTCO => GetString("MTCO");

		/// <summary>
		/// Description: Action text 1
		/// FieldName: MTX1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action text 1")]
		public string M3MTX1 => GetString("MTX1");

		/// <summary>
		/// Description: Action text 2
		/// FieldName: MTX2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action text 2")]
		public string M3MTX2 => GetString("MTX2");

		/// <summary>
		/// Description: Action text 3
		/// FieldName: MTX3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action text 3")]
		public string M3MTX3 => GetString("MTX3");

		/// <summary>
		/// Description: Action text 4
		/// FieldName: MTX4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action text 4")]
		public string M3MTX4 => GetString("MTX4");

		/// <summary>
		/// Description: Real start date assignment
		/// FieldName: RSDJ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Real start date assignment")]
		public DateTime? M3RSDJ => GetNullableDateTime("RSDJ");

		/// <summary>
		/// Description: Real start time assignment
		/// FieldName: RSTJ
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Real start time assignment")]
		public string M3RSTJ => GetString("RSTJ");

		/// <summary>
		/// Description: Real finish date assignment
		/// FieldName: RFDJ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Real finish date assignment")]
		public DateTime? M3RFDJ => GetNullableDateTime("RFDJ");

		/// <summary>
		/// Description: Real finish time assignment
		/// FieldName: RFTJ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Real finish time assignment")]
		public int? M3RFTJ => GetNullableInt("RFTJ");

		/// <summary>
		/// Description: End flag assignment
		/// FieldName: OEND
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End flag assignment")]
		public int? M3OEND => GetNullableInt("OEND");

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
		/// Description: Short technican name
		/// FieldName: TNL2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Short technican name")]
		public string M3TNL2 => GetString("TNL2");

		/// <summary>
		/// Description: Short service manager name
		/// FieldName: SNL2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Short service manager name")]
		public string M3SNL2 => GetString("SNL2");

		/// <summary>
		/// Description: Real start date work
		/// FieldName: RSDW
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Real start date work")]
		public DateTime? M3RSDW => GetNullableDateTime("RSDW");

		/// <summary>
		/// Description: Real start time work
		/// FieldName: RSTW
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Real start time work")]
		public int? M3RSTW => GetNullableInt("RSTW");

		/// <summary>
		/// Description: Real finish date work
		/// FieldName: RFDW
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Real finish date work")]
		public DateTime? M3RFDW => GetNullableDateTime("RFDW");

		/// <summary>
		/// Description: Real finish time work
		/// FieldName: RFTW
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Real finish time work")]
		public int? M3RFTW => GetNullableInt("RFTW");

		/// <summary>
		/// Description: Agreement order type text
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement order type text")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Additional status
		/// FieldName: JBSE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional status")]
		public string M3JBSE => GetString("JBSE");

		/// <summary>
		/// Description: Customers order number
		/// FieldName: CUOR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customers order number")]
		public string M3CUOR => GetString("CUOR");

		/// <summary>
		/// Description: Geographic area
		/// FieldName: GEOG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic area")]
		public string M3GEOG => GetString("GEOG");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AGNB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3AGNB => GetString("AGNB");

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: POSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3POSX => GetNullableInt("POSX");

		/// <summary>
		/// Description: Service expense
		/// FieldName: SVID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service expense")]
		public string M3SVID => GetString("SVID");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Role/organizational position
		/// FieldName: ROLE
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Role/organizational position")]
		public string M3ROLE => GetString("ROLE");
	}
}
// EOF
