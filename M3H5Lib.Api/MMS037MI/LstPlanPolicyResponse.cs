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

namespace M3H5Lib.Api.MMS037MI
{
	public partial class LstPlanPolicyResponse : M3BaseRecord 
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
		/// Description: Planning policy
		/// FieldName: PLCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning policy")]
		public string M3PLCD => GetString("PLCD");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

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
		/// Description: Default Status - purchase order
		/// FieldName: PUSL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default Status - purchase order")]
		public string M3PUSL => GetString("PUSL");

		/// <summary>
		/// Description: Default Status - manufacturing order
		/// FieldName: WHST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default Status - manufacturing order")]
		public string M3WHST => GetString("WHST");

		/// <summary>
		/// Description: Default Status - DO
		/// FieldName: TRSL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default Status - DO")]
		public string M3TRSL => GetString("TRSL");

		/// <summary>
		/// Description: Default Status - work order
		/// FieldName: WHSM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default Status - work order")]
		public string M3WHSM => GetString("WHSM");

		/// <summary>
		/// Description: Release status - planned orders A1
		/// FieldName: STN1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Release status - planned orders A1")]
		public string M3STN1 => GetString("STN1");

		/// <summary>
		/// Description: Reschedule
		/// FieldName: RSC9
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reschedule")]
		public string M3RSC9 => GetString("RSC9");

		/// <summary>
		/// Description: Release status - planned orders
		/// FieldName: STNP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Release status - planned orders")]
		public string M3STNP => GetString("STNP");

		/// <summary>
		/// Description: Firm qty if planned order is within PTF
		/// FieldName: FQPP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Firm qty if planned order is within PTF")]
		public int? M3FQPP => GetNullableInt("FQPP");

		/// <summary>
		/// Description: Explode pl order for master scheduled
		/// FieldName: EXPM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Explode pl order for master scheduled")]
		public int? M3EXPM => GetNullableInt("EXPM");

		/// <summary>
		/// Description: Automatic firm up horizon
		/// FieldName: AFUH
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic firm up horizon")]
		public int? M3AFUH => GetNullableInt("AFUH");

		/// <summary>
		/// Description: Re-explode planned MO in status 20
		/// FieldName: CHMP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Re-explode planned MO in status 20")]
		public string M3CHMP => GetString("CHMP");

		/// <summary>
		/// Description: Update material on MO
		/// FieldName: UMMO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update material on MO")]
		public int? M3UMMO => GetNullableInt("UMMO");

		/// <summary>
		/// Description: Time filter - reschedule to earlier date
		/// FieldName: DRIM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time filter - reschedule to earlier date")]
		public int? M3DRIM => GetNullableInt("DRIM");

		/// <summary>
		/// Description: Time filter - reschedule to later date
		/// FieldName: DROM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time filter - reschedule to later date")]
		public int? M3DROM => GetNullableInt("DROM");

		/// <summary>
		/// Description: Amount filter - reschedule to later date
		/// FieldName: ALEA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount filter - reschedule to later date")]
		public decimal? M3ALEA => GetNullableDecimal("ALEA");

		/// <summary>
		/// Description: Should AM order delay be generated
		/// FieldName: GODM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Should AM order delay be generated")]
		public int? M3GODM => GetNullableInt("GODM");

		/// <summary>
		/// Description: Time filter - AM order delayed
		/// FieldName: DODN
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time filter - AM order delayed")]
		public int? M3DODN => GetNullableInt("DODN");

		/// <summary>
		/// Description: Should AM delay warnings be generated
		/// FieldName: GOWD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Should AM delay warnings be generated")]
		public int? M3GOWD => GetNullableInt("GOWD");

		/// <summary>
		/// Description: Time filter - AM order delay
		/// FieldName: DODM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time filter - AM order delay")]
		public int? M3DODM => GetNullableInt("DODM");

		/// <summary>
		/// Description: AM order release prior to release date
		/// FieldName: ORMH
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("AM order release prior to release date")]
		public int? M3ORMH => GetNullableInt("ORMH");

		/// <summary>
		/// Description: Recalculate qty for order policy 15
		/// FieldName: RCLQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recalculate qty for order policy 15")]
		public int? M3RCLQ => GetNullableInt("RCLQ");

		/// <summary>
		/// Description: Comp SS and proj ohb at planning fence
		/// FieldName: SSPF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comp SS and proj ohb at planning fence")]
		public int? M3SSPF => GetNullableInt("SSPF");

		/// <summary>
		/// Description: Compare RoP and available total
		/// FieldName: RPTA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compare RoP and available total")]
		public int? M3RPTA => GetNullableInt("RPTA");

		/// <summary>
		/// Description: Comp RoP and proj ohb at planning fence
		/// FieldName: RPCA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comp RoP and proj ohb at planning fence")]
		public int? M3RPCA => GetNullableInt("RPCA");

		/// <summary>
		/// Description: Should (RoP - avail at LT) > EOQ create
		/// FieldName: SRAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Should (RoP - avail at LT) > EOQ create")]
		public int? M3SRAC => GetNullableInt("SRAC");

		/// <summary>
		/// Description: Shortage qty included in ordered qty
		/// FieldName: SQOQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shortage qty included in ordered qty")]
		public int? M3SQOQ => GetNullableInt("SQOQ");

		/// <summary>
		/// Description: Not repr reserv within lt reduce ohb
		/// FieldName: NREP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Not repr reserv within lt reduce ohb")]
		public int? M3NREP => GetNullableInt("NREP");

		/// <summary>
		/// Description: Priority values generate planned orders
		/// FieldName: UPPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority values generate planned orders")]
		public int? M3UPPR => GetNullableInt("UPPR");

		/// <summary>
		/// Description: Excess generates DO return
		/// FieldName: MXDR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Excess generates DO return")]
		public int? M3MXDR => GetNullableInt("MXDR");

		/// <summary>
		/// Description: Plan method 2 can be 1 at simulation
		/// FieldName: MRPS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Plan method 2 can be 1 at simulation")]
		public int? M3MRPS => GetNullableInt("MRPS");

		/// <summary>
		/// Description: Fixed reorder cycle
		/// FieldName: FXRC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed reorder cycle")]
		public int? M3FXRC => GetNullableInt("FXRC");

		/// <summary>
		/// Description: Amount limit - release planned orders
		/// FieldName: LS90
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount limit - release planned orders")]
		public decimal? M3LS90 => GetNullableDecimal("LS90");

		/// <summary>
		/// Description: Forecast alarm consideration
		/// FieldName: FACH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast alarm consideration")]
		public int? M3FACH => GetNullableInt("FACH");

		/// <summary>
		/// Description: Stop items with manual planning values
		/// FieldName: MPI6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stop items with manual planning values")]
		public int? M3MPI6 => GetNullableInt("MPI6");

		/// <summary>
		/// Description: File closed planned orders
		/// FieldName: ARCO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File closed planned orders")]
		public int? M3ARCO => GetNullableInt("ARCO");

		/// <summary>
		/// Description: ATP calculation horizon adjustment
		/// FieldName: ATPA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ATP calculation horizon adjustment")]
		public int? M3ATPA => GetNullableInt("ATPA");

		/// <summary>
		/// Description: Sum pland ord within PTF for ord plcy 12
		/// FieldName: SUPO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sum pland ord within PTF for ord plcy 12")]
		public int? M3SUPO => GetNullableInt("SUPO");

		/// <summary>
		/// Description: APP synchronization
		/// FieldName: APPC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP synchronization")]
		public string M3APPC => GetString("APPC");

		/// <summary>
		/// Description: Re-calculate run-out time at mtrl pl chg
		/// FieldName: RRMC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Re-calculate run-out time at mtrl pl chg")]
		public int? M3RRMC => GetNullableInt("RRMC");

		/// <summary>
		/// Description: Remove pl orders outside pl horizon
		/// FieldName: RPPH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remove pl orders outside pl horizon")]
		public int? M3RPPH => GetNullableInt("RPPH");

		/// <summary>
		/// Description: Proposed time for order policy 15
		/// FieldName: PRPT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Proposed time for order policy 15")]
		public int? M3PRPT => GetNullableInt("PRPT");

		/// <summary>
		/// Description: Consider shelf life in MRP
		/// FieldName: CSHL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consider shelf life in MRP")]
		public int? M3CSHL => GetNullableInt("CSHL");

		/// <summary>
		/// Description: Integrate APS planning
		/// FieldName: IAPS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Integrate APS planning")]
		public int? M3IAPS => GetNullableInt("IAPS");

		/// <summary>
		/// Description: Planning level
		/// FieldName: PLVL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning level")]
		public int? M3PLVL => GetNullableInt("PLVL");

		/// <summary>
		/// Description: Days to delay release after last issue
		/// FieldName: DRED
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days to delay release after last issue")]
		public int? M3DRED => GetNullableInt("DRED");
	}
}
// EOF
