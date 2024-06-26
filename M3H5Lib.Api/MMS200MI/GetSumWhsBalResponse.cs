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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class GetSumWhsBalResponse : M3BaseRecord 
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
		/// Description: Alias number
		/// FieldName: POPN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias number")]
		public string M3POPN => GetString("POPN");

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
		/// Description: Warehouse description
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse description")]
		public string M3WHNM => GetString("WHNM");

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
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: On-hand balance for inspection
		/// FieldName: QUQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance for inspection")]
		public decimal? M3QUQT => GetNullableDecimal("QUQT");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Lead time
		/// FieldName: LEAT
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time")]
		public int? M3LEAT => GetNullableInt("LEAT");

		/// <summary>
		/// Description: Lead time date
		/// FieldName: LTDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time date")]
		public DateTime? M3LTDT => GetNullableDateTime("LTDT");

		/// <summary>
		/// Description: Rejected on-hand balance
		/// FieldName: RJQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejected on-hand balance")]
		public decimal? M3RJQT => GetNullableDecimal("RJQT");

		/// <summary>
		/// Description: Planning time fence
		/// FieldName: PFTM
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning time fence")]
		public int? M3PFTM => GetNullableInt("PFTM");

		/// <summary>
		/// Description: Planned fence date
		/// FieldName: PFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned fence date")]
		public DateTime? M3PFDT => GetNullableDateTime("PFDT");

		/// <summary>
		/// Description: On-hand balance approved
		/// FieldName: STQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance approved")]
		public decimal? M3STQT => GetNullableDecimal("STQT");

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
		/// Description: Ordered quantity - basic U/M
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - basic U/M")]
		public decimal? M3ORQT => GetNullableDecimal("ORQT");

		/// <summary>
		/// Description: Text line  1
		/// FieldName: ACT1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  1")]
		public string M3ACT1 => GetString("ACT1");

		/// <summary>
		/// Description: Text line  2
		/// FieldName: ACT2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  2")]
		public string M3ACT2 => GetString("ACT2");

		/// <summary>
		/// Description: Text line  3
		/// FieldName: ACT3
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  3")]
		public string M3ACT3 => GetString("ACT3");

		/// <summary>
		/// Description: Text line  4
		/// FieldName: ACT4
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  4")]
		public string M3ACT4 => GetString("ACT4");

		/// <summary>
		/// Description: Text line  5
		/// FieldName: ACT5
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  5")]
		public string M3ACT5 => GetString("ACT5");

		/// <summary>
		/// Description: Text line  6
		/// FieldName: ACT6
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  6")]
		public string M3ACT6 => GetString("ACT6");

		/// <summary>
		/// Description: Reply time
		/// FieldName: ACT7
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reply time")]
		public string M3ACT7 => GetString("ACT7");

		/// <summary>
		/// Description: Reserved quantity
		/// FieldName: REQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reserved quantity")]
		public decimal? M3REQT => GetNullableDecimal("REQT");

		/// <summary>
		/// Description: Forecast alarm 1
		/// FieldName: ALAR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast alarm 1")]
		public int? M3ALAR => GetNullableInt("ALAR");

		/// <summary>
		/// Description: Available inventory
		/// FieldName: AV02
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Available inventory")]
		public decimal? M3AV02 => GetNullableDecimal("AV02");

		/// <summary>
		/// Description: Acquisition code
		/// FieldName: PUIT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acquisition code")]
		public int? M3PUIT => GetNullableInt("PUIT");

		/// <summary>
		/// Description: Safety stock
		/// FieldName: SSQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock")]
		public decimal? M3SSQT => GetNullableDecimal("SSQT");

		/// <summary>
		/// Description: Allocatable on-hand balance
		/// FieldName: AVAL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable on-hand balance")]
		public decimal? M3AVAL => GetNullableDecimal("AVAL");

		/// <summary>
		/// Description: Reorder point
		/// FieldName: REOP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reorder point")]
		public decimal? M3REOP => GetNullableDecimal("REOP");

		/// <summary>
		/// Description: Allocated quantity - basic U/M
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - basic U/M")]
		public decimal? M3ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Allocation stop type
		/// FieldName: ASOT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocation stop type")]
		public int? M3ASOT => GetNullableInt("ASOT");

		/// <summary>
		/// Description: Valid to
		/// FieldName: VTDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3VTDT => GetNullableDateTime("VTDT");

		/// <summary>
		/// Description: Order quantity
		/// FieldName: EOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order quantity")]
		public decimal? M3EOQT => GetNullableDecimal("EOQT");

		/// <summary>
		/// Description: Allocatable net
		/// FieldName: AV01
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable net")]
		public decimal? M3AV01 => GetNullableDecimal("AV01");

		/// <summary>
		/// Description: ABC class - volume
		/// FieldName: ABCD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - volume")]
		public string M3ABCD => GetString("ABCD");

		/// <summary>
		/// Description: Note
		/// FieldName: STTX
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Note")]
		public string M3STTX => GetString("STTX");

		/// <summary>
		/// Description: Catch weight approved on hand balance
		/// FieldName: STCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight approved on hand balance")]
		public decimal? M3STCW => GetNullableDecimal("STCW");

		/// <summary>
		/// Description: Catch weight rejected on hand balance
		/// FieldName: RJCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight rejected on hand balance")]
		public decimal? M3RJCW => GetNullableDecimal("RJCW");

		/// <summary>
		/// Description: Catch weight for inspection on hand bal
		/// FieldName: QUCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight for inspection on hand bal")]
		public decimal? M3QUCW => GetNullableDecimal("QUCW");
	}
}
// EOF
