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

namespace M3H5Lib.Api.PMS070MI
{
	public partial class GetOperationResponse : M3BaseRecord 
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
		/// Description: Name (product)
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name (product)")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Manufacturing order number
		/// FieldName: MFNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public int? M3MFNO => GetNullableInt("MFNO");

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
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Status - manufacturing order
		/// FieldName: WHST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - manufacturing order")]
		public string M3WHST => GetString("WHST");

		/// <summary>
		/// Description: Highest operation status - order
		/// FieldName: WHHS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest operation status - order")]
		public string M3WHHS => GetString("WHHS");

		/// <summary>
		/// Description: Planned start date (order)
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date (order)")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Planned finish time (order)
		/// FieldName: MFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time (order)")]
		public int? M3MFTI => GetNullableInt("MFTI");

		/// <summary>
		/// Description: Planned finish date (order)
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date (order)")]
		public DateTime? M3FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Planned start time (order)
		/// FieldName: MSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time (order)")]
		public int? M3MSTI => GetNullableInt("MSTI");

		/// <summary>
		/// Description: Planned start date (operation)
		/// FieldName: STD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date (operation)")]
		public DateTime? M3STD1 => GetNullableDateTime("STD1");

		/// <summary>
		/// Description: Planned start time (operation)
		/// FieldName: MST1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time (operation)")]
		public int? M3MST1 => GetNullableInt("MST1");

		/// <summary>
		/// Description: Planned finish date (operation)
		/// FieldName: FID1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date (operation)")]
		public DateTime? M3FID1 => GetNullableDateTime("FID1");

		/// <summary>
		/// Description: Planned finish time (operation)
		/// FieldName: MFT1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time (operation)")]
		public int? M3MFT1 => GetNullableInt("MFT1");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3RESP => GetString("RESP");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPN1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3OPN1 => GetNullableInt("OPN1");

		/// <summary>
		/// Description: Operation description
		/// FieldName: OPD1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation description")]
		public string M3OPD1 => GetString("OPD1");

		/// <summary>
		/// Description: Operation status
		/// FieldName: WOS1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation status")]
		public string M3WOS1 => GetString("WOS1");

		/// <summary>
		/// Description: Work center
		/// FieldName: PLG1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3PLG1 => GetString("PLG1");

		/// <summary>
		/// Description: Name (work center)
		/// FieldName: PLNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name (work center)")]
		public string M3PLNM => GetString("PLNM");

		/// <summary>
		/// Description: Automatic receipt
		/// FieldName: AUI1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic receipt")]
		public int? M3AUI1 => GetNullableInt("AUI1");

		/// <summary>
		/// Description: Automatic reporting
		/// FieldName: AUR1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic reporting")]
		public int? M3AUR1 => GetNullableInt("AUR1");

		/// <summary>
		/// Description: Ord qty for op in manufacturing U/M
		/// FieldName: ORQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ord qty for op in manufacturing U/M")]
		public decimal? M3ORQ1 => GetNullableDecimal("ORQ1");

		/// <summary>
		/// Description: Operation reporting number
		/// FieldName: WOS2
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation reporting number")]
		public int? M3WOS2 => GetNullableInt("WOS2");

		/// <summary>
		/// Description: Production lot number
		/// FieldName: PLNO
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production lot number")]
		public decimal? M3PLNO => GetNullableDecimal("PLNO");

		/// <summary>
		/// Description: Remaining machine setup time
		/// FieldName: RSET
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining machine setup time")]
		public int? M3RSET => GetNullableInt("RSET");

		/// <summary>
		/// Description: Used machine setup time
		/// FieldName: USE1
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used machine setup time")]
		public int? M3USE1 => GetNullableInt("USE1");

		/// <summary>
		/// Description: Remaining setup time
		/// FieldName: RMAS
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining setup time")]
		public int? M3RMAS => GetNullableInt("RMAS");

		/// <summary>
		/// Description: Used labor setup time
		/// FieldName: UMA1
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor setup time")]
		public int? M3UMA1 => GetNullableInt("UMA1");

		/// <summary>
		/// Description: Remaining machine run time
		/// FieldName: RPIT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining machine run time")]
		public int? M3RPIT => GetNullableInt("RPIT");

		/// <summary>
		/// Description: Used machine run time
		/// FieldName: UPI1
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used machine run time")]
		public int? M3UPI1 => GetNullableInt("UPI1");

		/// <summary>
		/// Description: Remaining labor run time
		/// FieldName: RMAT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining labor run time")]
		public int? M3RMAT => GetNullableInt("RMAT");

		/// <summary>
		/// Description: Used labor run time
		/// FieldName: UMA2
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor run time")]
		public int? M3UMA2 => GetNullableInt("UMA2");

		/// <summary>
		/// Description: Remaining quantity to manufacture
		/// FieldName: RMAQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining quantity to manufacture")]
		public decimal? M3RMAQ => GetNullableDecimal("RMAQ");

		/// <summary>
		/// Description: Manufactured quantity
		/// FieldName: MAQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufactured quantity")]
		public decimal? M3MAQ1 => GetNullableDecimal("MAQ1");

		/// <summary>
		/// Description: Operation completed (suggestion)
		/// FieldName: REND
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation completed (suggestion)")]
		public int? M3REND => GetNullableInt("REND");

		/// <summary>
		/// Description: Costing type
		/// FieldName: PCT1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing type")]
		public int? M3PCT1 => GetNullableInt("PCT1");

		/// <summary>
		/// Description: Description (costing type)
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description (costing type)")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Transaction date (current)
		/// FieldName: RPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction date (current)")]
		public DateTime? M3RPDT => GetNullableDateTime("RPDT");

		/// <summary>
		/// Description: Transaction time (current)
		/// FieldName: TRTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction time (current)")]
		public int? M3TRTM => GetNullableInt("TRTM");

		/// <summary>
		/// Description: Planned number of workers - run time
		/// FieldName: PRN1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - run time")]
		public int? M3PRN1 => GetNullableInt("PRN1");

		/// <summary>
		/// Description: Planned number of workers - setup time
		/// FieldName: SEN1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - setup time")]
		public int? M3SEN1 => GetNullableInt("SEN1");

		/// <summary>
		/// Description: Deviating work center
		/// FieldName: DPL1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deviating work center")]
		public string M3DPL1 => GetString("DPL1");

		/// <summary>
		/// Description: Yield quantity
		/// FieldName: BAQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield quantity")]
		public decimal? M3BAQT => GetNullableDecimal("BAQT");

		/// <summary>
		/// Description: Unit price
		/// FieldName: PIP1
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit price")]
		public decimal? M3PIP1 => GetNullableDecimal("PIP1");

		/// <summary>
		/// Description: Price and time quantity
		/// FieldName: CTC1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price and time quantity")]
		public int? M3CTC1 => GetNullableInt("CTC1");

		/// <summary>
		/// Description: Setup price
		/// FieldName: SEP1
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup price")]
		public decimal? M3SEP1 => GetNullableDecimal("SEP1");

		/// <summary>
		/// Description: Pay element
		/// FieldName: KIW1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pay element")]
		public int? M3KIW1 => GetNullableInt("KIW1");

		/// <summary>
		/// Description: Time rate
		/// FieldName: WAF1
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time rate")]
		public decimal? M3WAF1 => GetNullableDecimal("WAF1");

		/// <summary>
		/// Description: Latest reporting date - MO operation
		/// FieldName: RPD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Latest reporting date - MO operation")]
		public DateTime? M3RPD1 => GetNullableDateTime("RPD1");

		/// <summary>
		/// Description: Supplier no
		/// FieldName: SUN1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier no")]
		public string M3SUN1 => GetString("SUN1");

		/// <summary>
		/// Description: Suppplier name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppplier name")]
		public string M3SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Text ID
		/// FieldName: TXI1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text ID")]
		public decimal? M3TXI1 => GetNullableDecimal("TXI1");

		/// <summary>
		/// Description: By-product(s) exist
		/// FieldName: YPEX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("By-product(s) exist")]
		public int? M3YPEX => GetNullableInt("YPEX");

		/// <summary>
		/// Description: Co-product(s) exist
		/// FieldName: OPEX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Co-product(s) exist")]
		public int? M3OPEX => GetNullableInt("OPEX");

		/// <summary>
		/// Description: Manufacturing U/M
		/// FieldName: MAUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing U/M")]
		public string M3MAUN => GetString("MAUN");

		/// <summary>
		/// Description: Scrap quantity alternative unit
		/// FieldName: SCQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrap quantity alternative unit")]
		public decimal? M3SCQA => GetNullableDecimal("SCQA");

		/// <summary>
		/// Description: Manufacturing order number
		/// FieldName: MFN2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3MFN2 => GetString("MFN2");
	}
}
// EOF
