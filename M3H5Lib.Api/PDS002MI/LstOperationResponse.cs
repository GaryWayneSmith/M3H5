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

namespace M3H5Lib.Api.PDS002MI
{
	public partial class LstOperationResponse : M3BaseRecord 
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
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3STRT => GetString("STRT");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Structure date
		/// FieldName: STRD
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure date")]
		public int? M3STRD => GetNullableInt("STRD");

		/// <summary>
		/// Description: Revision number
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3ECVE => GetString("ECVE");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Operation description
		/// FieldName: OPDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation description")]
		public string M3OPDS => GetString("OPDS");

		/// <summary>
		/// Description: Component number/work center
		/// FieldName: MTPL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component number/work center")]
		public string M3MTPL => GetString("MTPL");

		/// <summary>
		/// Description: From date
		/// FieldName: FDAT
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public int? M3FDAT => GetNullableInt("FDAT");

		/// <summary>
		/// Description: To date
		/// FieldName: TDAT
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public int? M3TDAT => GetNullableInt("TDAT");

		/// <summary>
		/// Description: Quantity per time unit
		/// FieldName: QTHR
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity per time unit")]
		public int? M3QTHR => GetNullableInt("QTHR");

		/// <summary>
		/// Description: Work center
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3PLGR => GetString("PLGR");

		/// <summary>
		/// Description: Planning group name
		/// FieldName: PLNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning group name")]
		public string M3PLNM => GetString("PLNM");

		/// <summary>
		/// Description: Department
		/// FieldName: DEPT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department")]
		public string M3DEPT => GetString("DEPT");

		/// <summary>
		/// Description: Planning area
		/// FieldName: REAR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning area")]
		public string M3REAR => GetString("REAR");

		/// <summary>
		/// Description: Run time
		/// FieldName: PITI
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time")]
		public int? M3PITI => GetNullableInt("PITI");

		/// <summary>
		/// Description: Time U/M
		/// FieldName: PTUN
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time U/M")]
		public string M3PTUN => GetString("PTUN");

		/// <summary>
		/// Description: Price and time quantity
		/// FieldName: CTCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price and time quantity")]
		public int? M3CTCD => GetNullableInt("CTCD");

		/// <summary>
		/// Description: Setup time
		/// FieldName: SETI
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time")]
		public int? M3SETI => GetNullableInt("SETI");

		/// <summary>
		/// Description: External setup time
		/// FieldName: OSET
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External setup time")]
		public int? M3OSET => GetNullableInt("OSET");

		/// <summary>
		/// Description: Fixed time
		/// FieldName: FXTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed time")]
		public int? M3FXTI => GetNullableInt("FXTI");

		/// <summary>
		/// Description: Planned number of machines
		/// FieldName: PRNM
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of machines")]
		public int? M3PRNM => GetNullableInt("PRNM");

		/// <summary>
		/// Description: Planned number of workers - run time
		/// FieldName: PRNP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - run time")]
		public int? M3PRNP => GetNullableInt("PRNP");

		/// <summary>
		/// Description: Planned number of workers - setup
		/// FieldName: SENP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - setup")]
		public int? M3SENP => GetNullableInt("SENP");

		/// <summary>
		/// Description: Alternate operation
		/// FieldName: AOPE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate operation")]
		public int? M3AOPE => GetNullableInt("AOPE");

		/// <summary>
		/// Description: Operation elements exist
		/// FieldName: OADS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation elements exist")]
		public int? M3OADS => GetNullableInt("OADS");

		/// <summary>
		/// Description: Phantom operation method
		/// FieldName: PHOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Phantom operation method")]
		public int? M3PHOP => GetNullableInt("PHOP");

		/// <summary>
		/// Description: Lead time offset
		/// FieldName: ODBF
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time offset")]
		public int? M3ODBF => GetNullableInt("ODBF");

		/// <summary>
		/// Description: Production days
		/// FieldName: PRDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production days")]
		public int? M3PRDY => GetNullableInt("PRDY");

		/// <summary>
		/// Description: Transport value in days
		/// FieldName: SLAC
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport value in days")]
		public string M3SLAC => GetString("SLAC");

		/// <summary>
		/// Description: Option percentage
		/// FieldName: VAPC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option percentage")]
		public int? M3VAPC => GetNullableInt("VAPC");

		/// <summary>
		/// Description: Scrap percentage
		/// FieldName: SCPC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrap percentage")]
		public int? M3SCPC => GetNullableInt("SCPC");

		/// <summary>
		/// Description: Setup scrap
		/// FieldName: SWQT
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup scrap")]
		public string M3SWQT => GetString("SWQT");

		/// <summary>
		/// Description: Document identity
		/// FieldName: DOID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3DOID => GetString("DOID");

		/// <summary>
		/// Description: Tool number
		/// FieldName: TOOL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool number")]
		public string M3TOOL => GetString("TOOL");

		/// <summary>
		/// Description: Subcontract control
		/// FieldName: SUBC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subcontract control")]
		public string M3SUBC => GetString("SUBC");

		/// <summary>
		/// Description: Infinite/finite
		/// FieldName: WLDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Infinite/finite")]
		public int? M3WLDE => GetNullableInt("WLDE");

		/// <summary>
		/// Description: Subservice
		/// FieldName: SSUF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subservice")]
		public string M3SSUF => GetString("SSUF");

		/// <summary>
		/// Description: Standard
		/// FieldName: SDCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard")]
		public int? M3SDCD => GetNullableInt("SDCD");

		/// <summary>
		/// Description: Number of options
		/// FieldName: NUVA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of options")]
		public int? M3NUVA => GetNullableInt("NUVA");

		/// <summary>
		/// Description: Labor skill
		/// FieldName: LASK
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor skill")]
		public string M3LASK => GetString("LASK");

		/// <summary>
		/// Description: Inspection skill
		/// FieldName: INSK
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection skill")]
		public string M3INSK => GetString("INSK");

		/// <summary>
		/// Description: Unit price
		/// FieldName: PIPR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit price")]
		public string M3PIPR => GetString("PIPR");

		/// <summary>
		/// Description: Time rate
		/// FieldName: WAFA
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time rate")]
		public string M3WAFA => GetString("WAFA");

		/// <summary>
		/// Description: Setup price
		/// FieldName: SEPR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup price")]
		public string M3SEPR => GetString("SEPR");

		/// <summary>
		/// Description: Time reference
		/// FieldName: WCRF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time reference")]
		public string M3WCRF => GetString("WCRF");

		/// <summary>
		/// Description: Pay element
		/// FieldName: KIWG
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pay element")]
		public int? M3KIWG => GetNullableInt("KIWG");

		/// <summary>
		/// Description: Number of labor tickets
		/// FieldName: CAMP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of labor tickets")]
		public int? M3CAMP => GetNullableInt("CAMP");

		/// <summary>
		/// Description: Initial weight
		/// FieldName: INWE
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Initial weight")]
		public int? M3INWE => GetNullableInt("INWE");

		/// <summary>
		/// Description: Operation volume
		/// FieldName: OPV3
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation volume")]
		public int? M3OPV3 => GetNullableInt("OPV3");

		/// <summary>
		/// Description: Multiplication factor - manufacturing
		/// FieldName: MFPR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiplication factor - manufacturing")]
		public int? M3MFPR => GetNullableInt("MFPR");

		/// <summary>
		/// Description: Operation cost multiplier
		/// FieldName: OPCM
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation cost multiplier")]
		public int? M3OPCM => GetNullableInt("OPCM");

		/// <summary>
		/// Description: Automatic receipt
		/// FieldName: AUIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic receipt")]
		public int? M3AUIN => GetNullableInt("AUIN");

		/// <summary>
		/// Description: Automatic operation reporting
		/// FieldName: AURP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic operation reporting")]
		public int? M3AURP => GetNullableInt("AURP");

		/// <summary>
		/// Description: Formula
		/// FieldName: CFID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula")]
		public string M3CFID => GetString("CFID");

		/// <summary>
		/// Description: Formula result
		/// FieldName: CFRI
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result")]
		public string M3CFRI => GetString("CFRI");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Next supplier
		/// FieldName: NSUN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next supplier")]
		public string M3NSUN => GetString("NSUN");

		/// <summary>
		/// Description: Assembly operation
		/// FieldName: ASOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assembly operation")]
		public int? M3ASOP => GetNullableInt("ASOP");

		/// <summary>
		/// Description: Multiplication factor - manufacturing
		/// FieldName: MFP2
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiplication factor - manufacturing")]
		public int? M3MFP2 => GetNullableInt("MFP2");

		/// <summary>
		/// Description: APP operation number
		/// FieldName: APON
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP operation number")]
		public int? M3APON => GetNullableInt("APON");

		/// <summary>
		/// Description: Next APP operation number
		/// FieldName: NXOP
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next APP operation number")]
		public int? M3NXOP => GetNullableInt("NXOP");

		/// <summary>
		/// Description: Transit unit of measure/Overlap code
		/// FieldName: SLAT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transit unit of measure/Overlap code")]
		public string M3SLAT => GetString("SLAT");

		/// <summary>
		/// Description: Parallel operation overlap code
		/// FieldName: POOC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parallel operation overlap code")]
		public int? M3POOC => GetNullableInt("POOC");

		/// <summary>
		/// Description: Resource restriction
		/// FieldName: RESR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Resource restriction")]
		public string M3RESR => GetString("RESR");

		/// <summary>
		/// Description: Preparation time
		/// FieldName: PRET
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preparation time")]
		public int? M3PRET => GetNullableInt("PRET");

		/// <summary>
		/// Description: Split method - operation
		/// FieldName: SPLK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split method - operation")]
		public int? M3SPLK => GetNullableInt("SPLK");

		/// <summary>
		/// Description: Number of operations after split
		/// FieldName: SPLN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of operations after split")]
		public int? M3SPLN => GetNullableInt("SPLN");

		/// <summary>
		/// Description: Split quantity
		/// FieldName: SPSZ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split quantity")]
		public decimal? M3SPSZ => GetNullableDecimal("SPSZ");

		/// <summary>
		/// Description: Max duration of operation in percent
		/// FieldName: MDOP
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max duration of operation in percent")]
		public int? M3MDOP => GetNullableInt("MDOP");

		/// <summary>
		/// Description: Post-operation time
		/// FieldName: POTM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-operation time")]
		public int? M3POTM => GetNullableInt("POTM");
	}
}
// EOF
