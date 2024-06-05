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

namespace M3H5Lib.Api.OIS340MI
{
	public partial class LstSupplSummaryResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Alpha field 1 positions
		/// FieldName: MAR2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 1 positions")]
		public string M3MAR2 => GetString("MAR2");

		/// <summary>
		/// Description: Alpha field 2 positions
		/// FieldName: MARK
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 2 positions")]
		public string M3MARK => GetString("MARK");

		/// <summary>
		/// Description: Alternative
		/// FieldName: SPLA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternative")]
		public int? M3SPLA => GetNullableInt("SPLA");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Description
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3WHNM => GetString("WHNM");

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
		/// Description: Exchanged item
		/// FieldName: RITN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchanged item")]
		public string M3RITN => GetString("RITN");

		/// <summary>
		/// Description: Departure date
		/// FieldName: DSDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Departure date")]
		public DateTime? M3DSDT => GetNullableDateTime("DSDT");

		/// <summary>
		/// Description: Departure time
		/// FieldName: DSHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Departure time")]
		public int? M3DSHM => GetNullableInt("DSHM");

		/// <summary>
		/// Description: Confirmed delivery date
		/// FieldName: CODZ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed delivery date")]
		public DateTime? M3CODZ => GetNullableDateTime("CODZ");

		/// <summary>
		/// Description: Confirmed delivery time
		/// FieldName: COHZ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed delivery time")]
		public int? M3COHZ => GetNullableInt("COHZ");

		/// <summary>
		/// Description: Proposed quantity - alternate U/M
		/// FieldName: PBQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Proposed quantity - alternate U/M")]
		public decimal? M3PBQA => GetNullableDecimal("PBQA");

		/// <summary>
		/// Description: Alternate U/M
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M")]
		public string M3ALUN => GetString("ALUN");

		/// <summary>
		/// Description: Available-to-promise - cumulative
		/// FieldName: AVTP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Available-to-promise - cumulative")]
		public decimal? M3AVTP => GetNullableDecimal("AVTP");

		/// <summary>
		/// Description: Cond replacement
		/// FieldName: CNRE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cond replacement")]
		public int? M3CNRE => GetNullableInt("CNRE");

		/// <summary>
		/// Description: Condition
		/// FieldName: CNDN
		/// FieldType: A
		/// Length: 70
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Condition")]
		public string M3CNDN => GetString("CNDN");

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
		/// Description: Selected alternative
		/// FieldName: PALT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selected alternative")]
		public int? M3PALT => GetNullableInt("PALT");

		/// <summary>
		/// Description: Automatic option
		/// FieldName: AOPT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic option")]
		public int? M3AOPT => GetNullableInt("AOPT");

		/// <summary>
		/// Description: Split on alternative
		/// FieldName: SPLP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split on alternative")]
		public int? M3SPLP => GetNullableInt("SPLP");

		/// <summary>
		/// Description: Backorder
		/// FieldName: BCKO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Backorder")]
		public int? M3BCKO => GetNullableInt("BCKO");

		/// <summary>
		/// Description: Partial delivery
		/// FieldName: PADL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partial delivery")]
		public int? M3PADL => GetNullableInt("PADL");

		/// <summary>
		/// Description: Available-to-promise calculation
		/// FieldName: ATPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Available-to-promise calculation")]
		public int? M3ATPC => GetNullableInt("ATPC");

		/// <summary>
		/// Description: Capacity-to-promise check
		/// FieldName: CTPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity-to-promise check")]
		public int? M3CTPC => GetNullableInt("CTPC");

		/// <summary>
		/// Description: Material-to-promise check
		/// FieldName: MTPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material-to-promise check")]
		public int? M3MTPC => GetNullableInt("MTPC");

		/// <summary>
		/// Description: Transportation-to-promise check
		/// FieldName: TTPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation-to-promise check")]
		public int? M3TTPC => GetNullableInt("TTPC");

		/// <summary>
		/// Description: Line type
		/// FieldName: LTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line type")]
		public string M3LTYP => GetString("LTYP");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Sourcing warehouse
		/// FieldName: SWHL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sourcing warehouse")]
		public string M3SWHL => GetString("SWHL");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Replace item
		/// FieldName: AFL6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Replace item")]
		public int? M3AFL6 => GetNullableInt("AFL6");

		/// <summary>
		/// Description: Planning date
		/// FieldName: PLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning date")]
		public DateTime? M3PLDT => GetNullableDateTime("PLDT");

		/// <summary>
		/// Description: Planning time
		/// FieldName: PLHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning time")]
		public int? M3PLHM => GetNullableInt("PLHM");

		/// <summary>
		/// Description: Confirmed delivery date
		/// FieldName: CODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed delivery date")]
		public DateTime? M3CODT => GetNullableDateTime("CODT");

		/// <summary>
		/// Description: Confirmed delivery time
		/// FieldName: COHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed delivery time")]
		public int? M3COHM => GetNullableInt("COHM");

		/// <summary>
		/// Description: Route
		/// FieldName: ROUT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route")]
		public string M3ROUT => GetString("ROUT");

		/// <summary>
		/// Description: Route departure
		/// FieldName: RODN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route departure")]
		public int? M3RODN => GetNullableInt("RODN");

		/// <summary>
		/// Description: Main product
		/// FieldName: HDPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product")]
		public string M3HDPR => GetString("HDPR");

		/// <summary>
		/// Description: Transaction quantity in alt U/M
		/// FieldName: TRQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction quantity in alt U/M")]
		public decimal? M3TRQA => GetNullableDecimal("TRQA");

		/// <summary>
		/// Description: First delivery date
		/// FieldName: FDDZ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("First delivery date")]
		public DateTime? M3FDDZ => GetNullableDateTime("FDDZ");

		/// <summary>
		/// Description: First delivery time
		/// FieldName: FDHZ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("First delivery time")]
		public int? M3FDHZ => GetNullableInt("FDHZ");

		/// <summary>
		/// Description: Last delivery date
		/// FieldName: LDDZ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last delivery date")]
		public DateTime? M3LDDZ => GetNullableDateTime("LDDZ");

		/// <summary>
		/// Description: Last delivery time
		/// FieldName: LDHZ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last delivery time")]
		public int? M3LDHZ => GetNullableInt("LDHZ");

		/// <summary>
		/// Description: Availability date
		/// FieldName: AVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Availability date")]
		public DateTime? M3AVDT => GetNullableDateTime("AVDT");

		/// <summary>
		/// Description: Time hours & minutes
		/// FieldName: TIHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time hours & minutes")]
		public int? M3TIHM => GetNullableInt("TIHM");

		/// <summary>
		/// Description: Issue multiple
		/// FieldName: TOMU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue multiple")]
		public decimal? M3TOMU => GetNullableDecimal("TOMU");

		/// <summary>
		/// Description: Supply model
		/// FieldName: SPLM
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply model")]
		public string M3SPLM => GetString("SPLM");

		/// <summary>
		/// Description: Priority
		/// FieldName: PREX
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public string M3PREX => GetString("PREX");

		/// <summary>
		/// Description: Start value 1
		/// FieldName: OBV1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 1")]
		public string M3OBV1 => GetString("OBV1");

		/// <summary>
		/// Description: Start value 2
		/// FieldName: OBV2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 2")]
		public string M3OBV2 => GetString("OBV2");

		/// <summary>
		/// Description: Start value 3
		/// FieldName: OBV3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 3")]
		public string M3OBV3 => GetString("OBV3");

		/// <summary>
		/// Description: Start value 4
		/// FieldName: OBV4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 4")]
		public string M3OBV4 => GetString("OBV4");

		/// <summary>
		/// Description: From date
		/// FieldName: FDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public DateTime? M3FDAT => GetNullableDateTime("FDAT");

		/// <summary>
		/// Description: To date
		/// FieldName: TDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3TDAT => GetNullableDateTime("TDAT");

		/// <summary>
		/// Description: Multiple selection
		/// FieldName: MSEL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple selection")]
		public int? M3MSEL => GetNullableInt("MSEL");

		/// <summary>
		/// Description: Original confirmed delivery date
		/// FieldName: COD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original confirmed delivery date")]
		public DateTime? M3COD1 => GetNullableDateTime("COD1");

		/// <summary>
		/// Description: Original confirmed delivery time
		/// FieldName: COH1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original confirmed delivery time")]
		public int? M3COH1 => GetNullableInt("COH1");

		/// <summary>
		/// Description: Manually changed
		/// FieldName: MCPL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manually changed")]
		public int? M3MCPL => GetNullableInt("MCPL");

		/// <summary>
		/// Description: Free message 1
		/// FieldName: MSG1
		/// FieldType: A
		/// Length: 98
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free message 1")]
		public string M3MSG1 => GetString("MSG1");

		/// <summary>
		/// Description: Free message 2
		/// FieldName: MSG2
		/// FieldType: A
		/// Length: 98
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free message 2")]
		public string M3MSG2 => GetString("MSG2");

		/// <summary>
		/// Description: Free message 3
		/// FieldName: MSG3
		/// FieldType: A
		/// Length: 98
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free message 3")]
		public string M3MSG3 => GetString("MSG3");
	}
}
// EOF
