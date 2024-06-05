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

namespace M3H5Lib.Api.EQINFOMI
{
	public partial class GetMaintParamResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Constant value
		/// FieldName: STCO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Constant value")]
		public string M3STCO => GetString("STCO");

		/// <summary>
		/// Description: Consolidated facility
		/// FieldName: CFAC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidated facility")]
		public string M3CFAC => GetString("CFAC");

		/// <summary>
		/// Description: Incl forecast orders in master schedule
		/// FieldName: MIN0
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl forecast orders in master schedule")]
		public int? M3MIN0 => GetNullableInt("MIN0");

		/// <summary>
		/// Description: Incl scheduled services in Master Sched
		/// FieldName: MIN1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl scheduled services in Master Sched")]
		public int? M3MIN1 => GetNullableInt("MIN1");

		/// <summary>
		/// Description: Incl unscheduled services in Master Sch
		/// FieldName: MIN2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl unscheduled services in Master Sch")]
		public int? M3MIN2 => GetNullableInt("MIN2");

		/// <summary>
		/// Description: Incl engineer orders in Master Schedule
		/// FieldName: MIN3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl engineer orders in Master Schedule")]
		public int? M3MIN3 => GetNullableInt("MIN3");

		/// <summary>
		/// Description: Incl external orders in Master Schedule
		/// FieldName: MIN4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl external orders in Master Schedule")]
		public int? M3MIN4 => GetNullableInt("MIN4");

		/// <summary>
		/// Description: Incl stocked items in Master Schedule
		/// FieldName: MIN5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Incl stocked items in Master Schedule")]
		public int? M3MIN5 => GetNullableInt("MIN5");

		/// <summary>
		/// Description: Warehouse for installed items
		/// FieldName: WHIN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse for installed items")]
		public string M3WHIN => GetString("WHIN");

		/// <summary>
		/// Description: Location for installed item
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location for installed item")]
		public string M3WHSL => GetString("WHSL");

		/// <summary>
		/// Description: Order type for item/equipment removal
		/// FieldName: TRT1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type for item/equipment removal")]
		public string M3TRT1 => GetString("TRT1");

		/// <summary>
		/// Description: Order type for item/equipment installation
		/// FieldName: TRT2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type for item/equipment installation")]
		public string M3TRT2 => GetString("TRT2");

		/// <summary>
		/// Description: Location for test
		/// FieldName: WSOS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location for test")]
		public string M3WSOS => GetString("WSOS");

		/// <summary>
		/// Description: Location for transport
		/// FieldName: WNSO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location for transport")]
		public string M3WNSO => GetString("WNSO");

		/// <summary>
		/// Description: Customer number at creation of external order
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number at creation of external order")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Structure type for intallation structure
		/// FieldName: STRI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type for intallation structure")]
		public string M3STRI => GetString("STRI");

		/// <summary>
		/// Description: Structure type for analysis of compl.(diff from 16)
		/// FieldName: STRR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type for analysis of compl.(diff from 16)")]
		public string M3STRR => GetString("STRR");

		/// <summary>
		/// Description: Check for open trans when WO reporting
		/// FieldName: UNWK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check for open trans when WO reporting")]
		public int? M3UNWK => GetNullableInt("UNWK");

		/// <summary>
		/// Description: Display validity date in plant structure
		/// FieldName: DISD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Display validity date in plant structure")]
		public int? M3DISD => GetNullableInt("DISD");

		/// <summary>
		/// Description: General service costing model
		/// FieldName: PRCM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("General service costing model")]
		public string M3PRCM => GetString("PRCM");

		/// <summary>
		/// Description: Default service for exchange in MOS300
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default service for exchange in MOS300")]
		public string M3SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Default competing meter type  for services in MOS300
		/// FieldName: BLTA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default competing meter type  for services in MOS300")]
		public int? M3BLTA => GetNullableInt("BLTA");

		/// <summary>
		/// Description: Is function no used in material planning
		/// FieldName: FUNK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Is function no used in material planning")]
		public int? M3FUNK => GetNullableInt("FUNK");

		/// <summary>
		/// Description: General planned maintenance for model item
		/// FieldName: AMIU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("General planned maintenance for model item")]
		public int? M3AMIU => GetNullableInt("AMIU");

		/// <summary>
		/// Description: Perform online check of basic data in WO entry
		/// FieldName: ACBD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Perform online check of basic data in WO entry")]
		public int? M3ACBD => GetNullableInt("ACBD");

		/// <summary>
		/// Description: Fixed assets - integration method
		/// FieldName: FAMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed assets - integration method")]
		public int? M3FAMA => GetNullableInt("FAMA");

		/// <summary>
		/// Description: Require scrap proposal printout before  scrap
		/// FieldName: SCRP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Require scrap proposal printout before  scrap")]
		public int? M3SCRP => GetNullableInt("SCRP");

		/// <summary>
		/// Description: Default site for  plant maintenance
		/// FieldName: TAIL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default site for  plant maintenance")]
		public string M3TAIL => GetString("TAIL");

		/// <summary>
		/// Description: Automatic  update of spare part list in MOS050
		/// FieldName: USPA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic  update of spare part list in MOS050")]
		public int? M3USPA => GetNullableInt("USPA");

		/// <summary>
		/// Description: Automatic creation of work requests from MOS085
		/// FieldName: ASUF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic creation of work requests from MOS085")]
		public string M3ASUF => GetString("ASUF");

		/// <summary>
		/// Description: Default meter when creating service record
		/// FieldName: MES0
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default meter when creating service record")]
		public string M3MES0 => GetString("MES0");

		/// <summary>
		/// Description: Default inspection identity
		/// FieldName: INSI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default inspection identity")]
		public string M3INSI => GetString("INSI");

		/// <summary>
		/// Description: Default order type - simulation
		/// FieldName: SOTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default order type - simulation")]
		public string M3SOTY => GetString("SOTY");

		/// <summary>
		/// Description: Default item type for temprary item
		/// FieldName: DITI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default item type for temprary item")]
		public string M3DITI => GetString("DITI");

		/// <summary>
		/// Description: Default order type- forecast
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default order type- forecast")]
		public string M3ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Order type for installation/removal
		/// FieldName: TRT3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type for installation/removal")]
		public string M3TRT3 => GetString("TRT3");

		/// <summary>
		/// Description: Text block ID for order notes
		/// FieldName: WEBN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text block ID for order notes")]
		public string M3WEBN => GetString("WEBN");

		/// <summary>
		/// Description: Externam service price list
		/// FieldName: SPRL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Externam service price list")]
		public string M3SPRL => GetString("SPRL");

		/// <summary>
		/// Description: Internam service price list
		/// FieldName: SPR2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internam service price list")]
		public string M3SPR2 => GetString("SPR2");

		/// <summary>
		/// Description: Miscallaneous cost defined as item
		/// FieldName: MIMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Miscallaneous cost defined as item")]
		public int? M3MIMA => GetNullableInt("MIMA");
	}
}
// EOF
