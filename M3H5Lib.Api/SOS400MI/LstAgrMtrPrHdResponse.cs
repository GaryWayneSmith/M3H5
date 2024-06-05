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

namespace M3H5Lib.Api.SOS400MI
{
	public partial class LstAgrMtrPrHdResponse : M3BaseRecord 
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
		/// Description: Customer site
		/// FieldName: CUPL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer site")]
		public string M3_CUPL => GetString("CUPL");

		/// <summary>
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3_ADID => GetString("ADID");

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
		/// Description: Line suffix
		/// FieldName: POSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3_POSX => GetNullableInt("POSX");

		/// <summary>
		/// Description: Contract item
		/// FieldName: AGRS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Contract item")]
		public string M3_AGRS => GetString("AGRS");

		/// <summary>
		/// Description: Price schedule type
		/// FieldName: PSCT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price schedule type")]
		public int? M3_PSCT => GetNullableInt("PSCT");

		/// <summary>
		/// Description: Agreed fixed price
		/// FieldName: AFXP
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed fixed price")]
		public decimal? M3_AFXP => GetNullableDecimal("AFXP");

		/// <summary>
		/// Description: Agreed total quantity
		/// FieldName: ATOQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed total quantity")]
		public decimal? M3_ATOQ => GetNullableDecimal("ATOQ");

		/// <summary>
		/// Description: Agreed meter unit price
		/// FieldName: AMPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed meter unit price")]
		public decimal? M3_AMPR => GetNullableDecimal("AMPR");

		/// <summary>
		/// Description: Agreed interval - years
		/// FieldName: AIYR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed interval - years")]
		public int? M3_AIYR => GetNullableInt("AIYR");

		/// <summary>
		/// Description: Agreed interval - months
		/// FieldName: AIMO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed interval - months")]
		public int? M3_AIMO => GetNullableInt("AIMO");

		/// <summary>
		/// Description: Agreed interval - days
		/// FieldName: AIDY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed interval - days")]
		public int? M3_AIDY => GetNullableInt("AIDY");

		/// <summary>
		/// Description: Reinvoice percentage
		/// FieldName: RIPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinvoice percentage")]
		public int? M3_RIPC => GetNullableInt("RIPC");

		/// <summary>
		/// Description: Reconciliation interval - years
		/// FieldName: RCYR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reconciliation interval - years")]
		public int? M3_RCYR => GetNullableInt("RCYR");

		/// <summary>
		/// Description: Reconciliation interval - months
		/// FieldName: RCMO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reconciliation interval - months")]
		public int? M3_RCMO => GetNullableInt("RCMO");

		/// <summary>
		/// Description: Reconciliation interval - days
		/// FieldName: RCDY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reconciliation interval - days")]
		public int? M3_RCDY => GetNullableInt("RCDY");

		/// <summary>
		/// Description: Overusage meter unit price
		/// FieldName: OUMP
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overusage meter unit price")]
		public decimal? M3_OUMP => GetNullableDecimal("OUMP");

		/// <summary>
		/// Description: Underusage meter unit price
		/// FieldName: UUMP
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Underusage meter unit price")]
		public decimal? M3_UUMP => GetNullableDecimal("UUMP");

		/// <summary>
		/// Description: Credit unit price - inv meter
		/// FieldName: ICP1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit unit price - inv meter")]
		public decimal? M3_ICP1 => GetNullableDecimal("ICP1");

		/// <summary>
		/// Description: Credit unit price - inv meter
		/// FieldName: ICP2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit unit price - inv meter")]
		public decimal? M3_ICP2 => GetNullableDecimal("ICP2");

		/// <summary>
		/// Description: Credit unit price - inv meter
		/// FieldName: ICP3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit unit price - inv meter")]
		public decimal? M3_ICP3 => GetNullableDecimal("ICP3");

		/// <summary>
		/// Description: Credit unit price - inv meter
		/// FieldName: ICP4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit unit price - inv meter")]
		public decimal? M3_ICP4 => GetNullableDecimal("ICP4");

		/// <summary>
		/// Description: Credit unit price - inv meter
		/// FieldName: ICP5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit unit price - inv meter")]
		public decimal? M3_ICP5 => GetNullableDecimal("ICP5");

		/// <summary>
		/// Description: Credit unit price - inv meter
		/// FieldName: ICP6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit unit price - inv meter")]
		public decimal? M3_ICP6 => GetNullableDecimal("ICP6");

		/// <summary>
		/// Description: Start reconciliation date
		/// FieldName: SRED
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start reconciliation date")]
		public DateTime? M3_SRED => GetNullableDateTime("SRED");

		/// <summary>
		/// Description: End reconciliation date
		/// FieldName: ERED
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End reconciliation date")]
		public DateTime? M3_ERED => GetNullableDateTime("ERED");

		/// <summary>
		/// Description: Next reconciliation date
		/// FieldName: NRED
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next reconciliation date")]
		public DateTime? M3_NRED => GetNullableDateTime("NRED");

		/// <summary>
		/// Description: Last invoice date meter value
		/// FieldName: LIMD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last invoice date meter value")]
		public DateTime? M3_LIMD => GetNullableDateTime("LIMD");

		/// <summary>
		/// Description: Last meter (1-6) value
		/// FieldName: LIM1
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last meter (1-6) value")]
		public decimal? M3_LIM1 => GetNullableDecimal("LIM1");

		/// <summary>
		/// Description: Last meter (1-6) value
		/// FieldName: LIM2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last meter (1-6) value")]
		public decimal? M3_LIM2 => GetNullableDecimal("LIM2");

		/// <summary>
		/// Description: Last meter (1-6) value
		/// FieldName: LIM3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last meter (1-6) value")]
		public decimal? M3_LIM3 => GetNullableDecimal("LIM3");

		/// <summary>
		/// Description: Last meter (1-6) value
		/// FieldName: LIM4
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last meter (1-6) value")]
		public decimal? M3_LIM4 => GetNullableDecimal("LIM4");

		/// <summary>
		/// Description: Last meter (1-6) value
		/// FieldName: LIM5
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last meter (1-6) value")]
		public decimal? M3_LIM5 => GetNullableDecimal("LIM5");

		/// <summary>
		/// Description: Last meter (1-6) value
		/// FieldName: LIM6
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last meter (1-6) value")]
		public decimal? M3_LIM6 => GetNullableDecimal("LIM6");

		/// <summary>
		/// Description: Agreed QTY meter 1
		/// FieldName: AQM1
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed QTY meter 1")]
		public decimal? M3_AQM1 => GetNullableDecimal("AQM1");

		/// <summary>
		/// Description: Agreed QTY meter 2
		/// FieldName: AQM2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed QTY meter 2")]
		public decimal? M3_AQM2 => GetNullableDecimal("AQM2");

		/// <summary>
		/// Description: Agreed QTY meter 3
		/// FieldName: AQM3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed QTY meter 3")]
		public decimal? M3_AQM3 => GetNullableDecimal("AQM3");

		/// <summary>
		/// Description: Agreed QTY meter 4
		/// FieldName: AQM4
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed QTY meter 4")]
		public decimal? M3_AQM4 => GetNullableDecimal("AQM4");

		/// <summary>
		/// Description: Agreed QTY meter 5
		/// FieldName: AQM5
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed QTY meter 5")]
		public decimal? M3_AQM5 => GetNullableDecimal("AQM5");

		/// <summary>
		/// Description: Agreed QTY meter 6
		/// FieldName: AQM6
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed QTY meter 6")]
		public decimal? M3_AQM6 => GetNullableDecimal("AQM6");

		/// <summary>
		/// Description: Agreement origin
		/// FieldName: AGRO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement origin")]
		public int? M3_AGRO => GetNullableInt("AGRO");

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
	}
}
// EOF
