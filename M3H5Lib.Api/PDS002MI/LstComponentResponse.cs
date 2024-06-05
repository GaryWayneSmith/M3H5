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

namespace M3H5Lib.Api.PDS002MI
{
	public partial class LstComponentResponse : M3BaseRecord 
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
		public int? M3_CONO => GetNullableInt("CONO");

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
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3_PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3_STRT => GetString("STRT");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: MSEQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3_MSEQ => GetNullableInt("MSEQ");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3_OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Operation element number
		/// FieldName: ACTS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation element number")]
		public int? M3_ACTS => GetNullableInt("ACTS");

		/// <summary>
		/// Description: Structure date
		/// FieldName: STRD
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure date")]
		public int? M3_STRD => GetNullableInt("STRD");

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
		/// Description: Component number/work center
		/// FieldName: MTPL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component number/work center")]
		public string M3_MTPL => GetString("MTPL");

		/// <summary>
		/// Description: From Date
		/// FieldName: FDAT
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From Date")]
		public int? M3_FDAT => GetNullableInt("FDAT");

		/// <summary>
		/// Description: To date
		/// FieldName: TDAT
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public int? M3_TDAT => GetNullableInt("TDAT");

		/// <summary>
		/// Description: Engineering change order number
		/// FieldName: ECON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Engineering change order number")]
		public string M3_ECON => GetString("ECON");

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3_PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: From revision number
		/// FieldName: FECV
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From revision number")]
		public string M3_FECV => GetString("FECV");

		/// <summary>
		/// Description: To revision number
		/// FieldName: TECV
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To revision number")]
		public string M3_TECV => GetString("TECV");

		/// <summary>
		/// Description: Item type
		/// FieldName: ITTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item type")]
		public string M3_ITTY => GetString("ITTY");

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
		/// Description: Phantom item
		/// FieldName: OVTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Phantom item")]
		public string M3_OVTP => GetString("OVTP");

		/// <summary>
		/// Description: Item category
		/// FieldName: TPCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item category")]
		public int? M3_TPCD => GetNullableInt("TPCD");

		/// <summary>
		/// Description: Order initiated
		/// FieldName: OVOP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order initiated")]
		public string M3_OVOP => GetString("OVOP");

		/// <summary>
		/// Description: Fixed quantity
		/// FieldName: FXCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed quantity")]
		public int? M3_FXCD => GetNullableInt("FXCD");

		/// <summary>
		/// Description: Planning method
		/// FieldName: OPLC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning method")]
		public int? M3_OPLC => GetNullableInt("OPLC");

		/// <summary>
		/// Description: Floor stock
		/// FieldName: FLST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Floor stock")]
		public int? M3_FLST => GetNullableInt("FLST");

		/// <summary>
		/// Description: Issue method
		/// FieldName: SPMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue method")]
		public int? M3_SPMT => GetNullableInt("SPMT");

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
		/// Description: Quantity
		/// FieldName: CNQT
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity")]
		public string M3_CNQT => GetString("CNQT");

		/// <summary>
		/// Description: Quantity on drawing
		/// FieldName: CCQT
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity on drawing")]
		public string M3_CCQT => GetString("CCQT");

		/// <summary>
		/// Description: Product engineering U/M
		/// FieldName: PEUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product engineering U/M")]
		public string M3_PEUN => GetString("PEUN");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3_UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Drawing position
		/// FieldName: DWPO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing position")]
		public string M3_DWPO => GetString("DWPO");

		/// <summary>
		/// Description: Option percentage
		/// FieldName: VAPC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option percentage")]
		public int? M3_VAPC => GetNullableInt("VAPC");

		/// <summary>
		/// Description: Normal waste percentage
		/// FieldName: WAPC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal waste percentage")]
		public int? M3_WAPC => GetNullableInt("WAPC");

		/// <summary>
		/// Description: Subcontract control
		/// FieldName: STGS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subcontract control")]
		public int? M3_STGS => GetNullableInt("STGS");

		/// <summary>
		/// Description: Subservice
		/// FieldName: SSUF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subservice")]
		public string M3_SSUF => GetString("SSUF");

		/// <summary>
		/// Description: Text
		/// FieldName: FMT1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FMT1 => GetString("FMT1");

		/// <summary>
		/// Description: Technical reference
		/// FieldName: FMT2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Technical reference")]
		public string M3_FMT2 => GetString("FMT2");

		/// <summary>
		/// Description: Component price
		/// FieldName: MPRC
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component price")]
		public string M3_MPRC => GetString("MPRC");

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
		/// Description: Yield component
		/// FieldName: EXMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield component")]
		public int? M3_EXMA => GetNullableInt("EXMA");

		/// <summary>
		/// Description: Lot controlling component
		/// FieldName: CMCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot controlling component")]
		public int? M3_CMCD => GetNullableInt("CMCD");

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
		/// Description: Lead time offset
		/// FieldName: MDBF
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time offset")]
		public int? M3_MDBF => GetNullableInt("MDBF");

		/// <summary>
		/// Description: Critical material
		/// FieldName: CRTM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Critical material")]
		public int? M3_CRTM => GetNullableInt("CRTM");

		/// <summary>
		/// Description: Standard
		/// FieldName: SDCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard")]
		public int? M3_SDCD => GetNullableInt("SDCD");

		/// <summary>
		/// Description: Length
		/// FieldName: LGTH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length")]
		public int? M3_LGTH => GetNullableInt("LGTH");

		/// <summary>
		/// Description: Width
		/// FieldName: WDTH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Width")]
		public int? M3_WDTH => GetNullableInt("WDTH");

		/// <summary>
		/// Description: Factor 1
		/// FieldName: LWF1
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Factor 1")]
		public string M3_LWF1 => GetString("LWF1");

		/// <summary>
		/// Description: Factor 2
		/// FieldName: LWF2
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Factor 2")]
		public string M3_LWF2 => GetString("LWF2");

		/// <summary>
		/// Description: Selection identity - component
		/// FieldName: SIDI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection identity - component")]
		public string M3_SIDI => GetString("SIDI");

		/// <summary>
		/// Description: Selection type - component
		/// FieldName: SITI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection type - component")]
		public int? M3_SITI => GetNullableInt("SITI");

		/// <summary>
		/// Description: Selection identity - quantity
		/// FieldName: SIDQ
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection identity - quantity")]
		public string M3_SIDQ => GetString("SIDQ");

		/// <summary>
		/// Description: Selection type - quantity
		/// FieldName: SITQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection type - quantity")]
		public int? M3_SITQ => GetNullableInt("SITQ");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FORI
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3_FORI => GetString("FORI");

		/// <summary>
		/// Description: Configurator line
		/// FieldName: CFLN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configurator line")]
		public int? M3_CFLN => GetNullableInt("CFLN");

		/// <summary>
		/// Description: Number of options
		/// FieldName: NUVA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of options")]
		public int? M3_NUVA => GetNullableInt("NUVA");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3_ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Item to inherit from
		/// FieldName: INHI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item to inherit from")]
		public int? M3_INHI => GetNullableInt("INHI");

		/// <summary>
		/// Description: Exchange
		/// FieldName: EXCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange")]
		public int? M3_EXCH => GetNullableInt("EXCH");

		/// <summary>
		/// Description: Quantity in basic unit of measure
		/// FieldName: CBQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity in basic unit of measure")]
		public decimal? M3_CBQT => GetNullableDecimal("CBQT");

		/// <summary>
		/// Description: External line reference
		/// FieldName: ELRF
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External line reference")]
		public int? M3_ELRF => GetNullableInt("ELRF");
	}
}
// EOF
