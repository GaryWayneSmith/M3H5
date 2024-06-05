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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class GetItmTechResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Volume
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume")]
		public decimal? M3_VOL3 => GetNullableDecimal("VOL3");

		/// <summary>
		/// Description: Net weight
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight")]
		public decimal? M3_NEWE => GetNullableDecimal("NEWE");

		/// <summary>
		/// Description: Gross weight
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight")]
		public decimal? M3_GRWE => GetNullableDecimal("GRWE");

		/// <summary>
		/// Description: By/co-product code
		/// FieldName: BYPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("By/co-product code")]
		public int? M3_BYPR => GetNullableInt("BYPR");

		/// <summary>
		/// Description: Normal waste percentage
		/// FieldName: WAPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal waste percentage")]
		public int? M3_WAPC => GetNullableInt("WAPC");

		/// <summary>
		/// Description: Inspection code
		/// FieldName: QACD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection code")]
		public int? M3_QACD => GetNullableInt("QACD");

		/// <summary>
		/// Description: Yield calculation
		/// FieldName: EPCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield calculation")]
		public int? M3_EPCD => GetNullableInt("EPCD");

		/// <summary>
		/// Description: Normal potency
		/// FieldName: POCY
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal potency")]
		public int? M3_POCY => GetNullableInt("POCY");

		/// <summary>
		/// Description: Active or catch weight item
		/// FieldName: ACTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active or catch weight item")]
		public int? M3_ACTI => GetNullableInt("ACTI");

		/// <summary>
		/// Description: Revision number
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3_ECVE => GetString("ECVE");

		/// <summary>
		/// Description: Engineering change order type
		/// FieldName: ECAC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Engineering change order type")]
		public string M3_ECAC => GetString("ECAC");

		/// <summary>
		/// Description: ECO managed
		/// FieldName: ECMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ECO managed")]
		public int? M3_ECMA => GetNullableInt("ECMA");

		/// <summary>
		/// Description: Active engineering changes
		/// FieldName: ECFL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active engineering changes")]
		public int? M3_ECFL => GetNullableInt("ECFL");

		/// <summary>
		/// Description: External instruction
		/// FieldName: ETRF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External instruction")]
		public string M3_ETRF => GetString("ETRF");

		/// <summary>
		/// Description: Description - External instruction
		/// FieldName: DS01
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - External instruction")]
		public string M3_DS01 => GetString("DS01");

		/// <summary>
		/// Description: Internal instruction
		/// FieldName: ITRF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal instruction")]
		public string M3_ITRF => GetString("ITRF");

		/// <summary>
		/// Description: Description - Internal instruction
		/// FieldName: DS02
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Internal instruction")]
		public string M3_DS02 => GetString("DS02");

		/// <summary>
		/// Description: Danger indicator
		/// FieldName: HAZI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Danger indicator")]
		public int? M3_HAZI => GetNullableInt("HAZI");

		/// <summary>
		/// Description: Fragility
		/// FieldName: FRAG
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fragility")]
		public int? M3_FRAG => GetNullableInt("FRAG");

		/// <summary>
		/// Description: Danger class 1
		/// FieldName: HAC1
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Danger class 1")]
		public string M3_HAC1 => GetString("HAC1");

		/// <summary>
		/// Description: Description - Danger class 1
		/// FieldName: DS03
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Danger class 1")]
		public string M3_DS03 => GetString("DS03");

		/// <summary>
		/// Description: Danger class 2
		/// FieldName: HAC2
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Danger class 2")]
		public string M3_HAC2 => GetString("HAC2");

		/// <summary>
		/// Description: Description - Danger class 2
		/// FieldName: DS04
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Danger class 2")]
		public string M3_DS04 => GetString("DS04");

		/// <summary>
		/// Description: Danger class 3
		/// FieldName: HAC3
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Danger class 3")]
		public string M3_HAC3 => GetString("HAC3");

		/// <summary>
		/// Description: Description - Danger class 3
		/// FieldName: DS05
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Danger class 3")]
		public string M3_DS05 => GetString("DS05");

		/// <summary>
		/// Description: Measurement 1
		/// FieldName: DIM1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement 1")]
		public string M3_DIM1 => GetString("DIM1");

		/// <summary>
		/// Description: Measurement 2
		/// FieldName: DIM2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement 2")]
		public string M3_DIM2 => GetString("DIM2");

		/// <summary>
		/// Description: Measurement 3
		/// FieldName: DIM3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement 3")]
		public string M3_DIM3 => GetString("DIM3");

		/// <summary>
		/// Description: Specification 1
		/// FieldName: SPE1
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 1")]
		public string M3_SPE1 => GetString("SPE1");

		/// <summary>
		/// Description: Specification 2
		/// FieldName: SPE2
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 2")]
		public string M3_SPE2 => GetString("SPE2");

		/// <summary>
		/// Description: Specification 3
		/// FieldName: SPE3
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 3")]
		public string M3_SPE3 => GetString("SPE3");

		/// <summary>
		/// Description: Specification 4
		/// FieldName: SPE4
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 4")]
		public string M3_SPE4 => GetString("SPE4");

		/// <summary>
		/// Description: Specification 5
		/// FieldName: SPE5
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 5")]
		public string M3_SPE5 => GetString("SPE5");

		/// <summary>
		/// Description: Repair supplier
		/// FieldName: ARPA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repair supplier")]
		public string M3_ARPA => GetString("ARPA");

		/// <summary>
		/// Description: Repair planner
		/// FieldName: ARPR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repair planner")]
		public string M3_ARPR => GetString("ARPR");

		/// <summary>
		/// Description: Repair time
		/// FieldName: AMPT
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repair time")]
		public int? M3_AMPT => GetNullableInt("AMPT");

		/// <summary>
		/// Description: Repair warranty - days
		/// FieldName: AWDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repair warranty - days")]
		public int? M3_AWDY => GetNullableInt("AWDY");

		/// <summary>
		/// Description: Tool quantity
		/// FieldName: NPTO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool quantity")]
		public int? M3_NPTO => GetNullableInt("NPTO");

		/// <summary>
		/// Description: Meter 1
		/// FieldName: MES1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 1")]
		public string M3_MES1 => GetString("MES1");

		/// <summary>
		/// Description: Meter 2
		/// FieldName: MES2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 2")]
		public string M3_MES2 => GetString("MES2");

		/// <summary>
		/// Description: Meter 3
		/// FieldName: MES3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 3")]
		public string M3_MES3 => GetString("MES3");

		/// <summary>
		/// Description: Meter 4
		/// FieldName: MES4
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 4")]
		public string M3_MES4 => GetString("MES4");

		/// <summary>
		/// Description: Meter value 1
		/// FieldName: MVA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 1")]
		public decimal? M3_MVA1 => GetNullableDecimal("MVA1");

		/// <summary>
		/// Description: Meter value 2
		/// FieldName: MVA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 2")]
		public decimal? M3_MVA2 => GetNullableDecimal("MVA2");

		/// <summary>
		/// Description: Meter value 3
		/// FieldName: MVA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 3")]
		public decimal? M3_MVA3 => GetNullableDecimal("MVA3");

		/// <summary>
		/// Description: Meter value 4
		/// FieldName: MVA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 4")]
		public decimal? M3_MVA4 => GetNullableDecimal("MVA4");

		/// <summary>
		/// Description: Quantity or time
		/// FieldName: PEQ1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity or time")]
		public int? M3_PEQ1 => GetNullableInt("PEQ1");

		/// <summary>
		/// Description: Quantity or time
		/// FieldName: PEQ2
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity or time")]
		public int? M3_PEQ2 => GetNullableInt("PEQ2");

		/// <summary>
		/// Description: Quantity or time
		/// FieldName: PEQ3
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity or time")]
		public int? M3_PEQ3 => GetNullableInt("PEQ3");

		/// <summary>
		/// Description: Quantity or time
		/// FieldName: PEQ4
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity or time")]
		public int? M3_PEQ4 => GetNullableInt("PEQ4");

		/// <summary>
		/// Description: Trigger type
		/// FieldName: PET1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trigger type")]
		public int? M3_PET1 => GetNullableInt("PET1");

		/// <summary>
		/// Description: Trigger type
		/// FieldName: PET2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trigger type")]
		public int? M3_PET2 => GetNullableInt("PET2");

		/// <summary>
		/// Description: Trigger type
		/// FieldName: PET3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trigger type")]
		public int? M3_PET3 => GetNullableInt("PET3");

		/// <summary>
		/// Description: Trigger type
		/// FieldName: PET4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trigger type")]
		public int? M3_PET4 => GetNullableInt("PET4");

		/// <summary>
		/// Description: Maintenance program
		/// FieldName: MPGM
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maintenance program")]
		public string M3_MPGM => GetString("MPGM");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Planning policy
		/// FieldName: PLCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning policy")]
		public string M3_PLCD => GetString("PLCD");

		/// <summary>
		/// Description: Planner - maintenance
		/// FieldName: MAPL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planner - maintenance")]
		public string M3_MAPL => GetString("MAPL");

		/// <summary>
		/// Description: Tool history
		/// FieldName: TOHI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool history")]
		public int? M3_TOHI => GetNullableInt("TOHI");

		/// <summary>
		/// Description: Tool allocation
		/// FieldName: TORE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool allocation")]
		public int? M3_TORE => GetNullableInt("TORE");

		/// <summary>
		/// Description: Tool reporting
		/// FieldName: FEBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool reporting")]
		public int? M3_FEBA => GetNullableInt("FEBA");

		/// <summary>
		/// Description: Downtime cost
		/// FieldName: STCS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Downtime cost")]
		public decimal? M3_STCS => GetNullableDecimal("STCS");

		/// <summary>
		/// Description: Next shop action type
		/// FieldName: NESA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next shop action type")]
		public string M3_NESA => GetString("NESA");

		/// <summary>
		/// Description: Next service
		/// FieldName: NSUF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next service")]
		public string M3_NSUF => GetString("NSUF");

		/// <summary>
		/// Description: Forecast logic
		/// FieldName: FCCM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast logic")]
		public string M3_FCCM => GetString("FCCM");

		/// <summary>
		/// Description: Period frame
		/// FieldName: DPID
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period frame")]
		public int? M3_DPID => GetNullableInt("DPID");

		/// <summary>
		/// Description: Continuous net change
		/// FieldName: CONC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Continuous net change")]
		public int? M3_CONC => GetNullableInt("CONC");

		/// <summary>
		/// Description: Planning horizon
		/// FieldName: PLMZ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning horizon")]
		public int? M3_PLMZ => GetNullableInt("PLMZ");

		/// <summary>
		/// Description: Calculation constant 1
		/// FieldName: CCO1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation constant 1")]
		public int? M3_CCO1 => GetNullableInt("CCO1");

		/// <summary>
		/// Description: Calculation constant 2
		/// FieldName: CCO2
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation constant 2")]
		public int? M3_CCO2 => GetNullableInt("CCO2");

		/// <summary>
		/// Description: Calculation constant 3
		/// FieldName: CCO3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation constant 3")]
		public int? M3_CCO3 => GetNullableInt("CCO3");

		/// <summary>
		/// Description: Time between scheduled shop visits
		/// FieldName: TBSR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time between scheduled shop visits")]
		public decimal? M3_TBSR => GetNullableDecimal("TBSR");

		/// <summary>
		/// Description: Meter - scheduled shop visits
		/// FieldName: MBSR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter - scheduled shop visits")]
		public string M3_MBSR => GetString("MBSR");

		/// <summary>
		/// Description: Unscheduled removal rate
		/// FieldName: TBUR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unscheduled removal rate")]
		public decimal? M3_TBUR => GetNullableDecimal("TBUR");

		/// <summary>
		/// Description: Meter - unscheduled removal rate
		/// FieldName: MBUR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter - unscheduled removal rate")]
		public string M3_MBUR => GetString("MBUR");

		/// <summary>
		/// Description: Time between failure
		/// FieldName: TBFR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time between failure")]
		public decimal? M3_TBFR => GetNullableDecimal("TBFR");

		/// <summary>
		/// Description: Meter - failure
		/// FieldName: MBFR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter - failure")]
		public string M3_MBFR => GetString("MBFR");

		/// <summary>
		/// Description: Criticality class
		/// FieldName: AESC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Criticality class")]
		public int? M3_AESC => GetNullableInt("AESC");

		/// <summary>
		/// Description: Extended-range twin-engine operations
		/// FieldName: AES2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended-range twin-engine operations")]
		public int? M3_AES2 => GetNullableInt("AES2");

		/// <summary>
		/// Description: Maintenance/overhaul/repair class
		/// FieldName: AMOR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maintenance/overhaul/repair class")]
		public int? M3_AMOR => GetNullableInt("AMOR");

		/// <summary>
		/// Description: Function area
		/// FieldName: FUNC
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function area")]
		public string M3_FUNC => GetString("FUNC");

		/// <summary>
		/// Description: Standard numbering system
		/// FieldName: STNC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard numbering system")]
		public string M3_STNC => GetString("STNC");

		/// <summary>
		/// Description: Dimensional removal rate
		/// FieldName: DIRR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dimensional removal rate")]
		public decimal? M3_DIRR => GetNullableDecimal("DIRR");

		/// <summary>
		/// Description: Meter - dimensioning removal rate
		/// FieldName: MDIR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter - dimensioning removal rate")]
		public string M3_MDIR => GetString("MDIR");

		/// <summary>
		/// Description: Service level
		/// FieldName: SCGR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service level")]
		public int? M3_SCGR => GetNullableInt("SCGR");

		/// <summary>
		/// Description: Removal class
		/// FieldName: ARR1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Removal class")]
		public int? M3_ARR1 => GetNullableInt("ARR1");

		/// <summary>
		/// Description: Extra quantity
		/// FieldName: AEQY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extra quantity")]
		public decimal? M3_AEQY => GetNullableDecimal("AEQY");

		/// <summary>
		/// Description: Internal lead time
		/// FieldName: LEAI
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal lead time")]
		public int? M3_LEAI => GetNullableInt("LEAI");

		/// <summary>
		/// Description: Warranty limit 1
		/// FieldName: WAL1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 1")]
		public decimal? M3_WAL1 => GetNullableDecimal("WAL1");

		/// <summary>
		/// Description: Warranty limit 2
		/// FieldName: WAL2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 2")]
		public decimal? M3_WAL2 => GetNullableDecimal("WAL2");

		/// <summary>
		/// Description: Warranty limit 3
		/// FieldName: WAL3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 3")]
		public decimal? M3_WAL3 => GetNullableDecimal("WAL3");

		/// <summary>
		/// Description: Warranty limit 4
		/// FieldName: WAL4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 4")]
		public decimal? M3_WAL4 => GetNullableDecimal("WAL4");

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
		/// Description: Group technology class
		/// FieldName: GRTI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group technology class")]
		public string M3_GRTI => GetString("GRTI");

		/// <summary>
		/// Description: Description group tech.class
		/// FieldName: DS06
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description group tech.class")]
		public string M3_DS06 => GetString("DS06");

		/// <summary>
		/// Description: Catch weight mode
		/// FieldName: CAWP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight mode")]
		public int? M3_CAWP => GetNullableInt("CAWP");

		/// <summary>
		/// Description: Catch weight unit of measure
		/// FieldName: CWUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight unit of measure")]
		public string M3_CWUN => GetString("CWUN");

		/// <summary>
		/// Description: Standard cost price unit of measure
		/// FieldName: CPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard cost price unit of measure")]
		public string M3_CPUN => GetString("CPUN");

		/// <summary>
		/// Description: Specific gravity
		/// FieldName: SPGV
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific gravity")]
		public decimal? M3_SPGV => GetNullableDecimal("SPGV");
	}
}
// EOF
