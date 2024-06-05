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

namespace M3H5Lib.Api.MMS080MI
{
	public partial class LstItemWarehousResponse : M3BaseRecord 
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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Item description
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item description")]
		public string M3_ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Approved on-hand balance qty (6 dec)
		/// FieldName: STQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved on-hand balance qty (6 dec)")]
		public decimal? M3_STQT => GetNullableDecimal("STQT");

		/// <summary>
		/// Description: Purchase lead time
		/// FieldName: LEAT
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase lead time")]
		public int? M3_LEAT => GetNullableInt("LEAT");

		/// <summary>
		/// Description: Acquisition code
		/// FieldName: PUIT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acquisition code")]
		public int? M3_PUIT => GetNullableInt("PUIT");

		/// <summary>
		/// Description: Sales item
		/// FieldName: SALE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales item")]
		public int? M3_SALE => GetNullableInt("SALE");

		/// <summary>
		/// Description: Maximum stock
		/// FieldName: MXST
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum stock")]
		public decimal? M3_MXST => GetNullableDecimal("MXST");

		/// <summary>
		/// Description: Safety stock
		/// FieldName: SSQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock")]
		public decimal? M3_SSQT => GetNullableDecimal("SSQT");

		/// <summary>
		/// Description: Cost price/average price
		/// FieldName: UCOS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price/average price")]
		public decimal? M3_UCOS => GetNullableDecimal("UCOS");

		/// <summary>
		/// Description: Minimum order quantity
		/// FieldName: LOQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum order quantity")]
		public decimal? M3_LOQT => GetNullableDecimal("LOQT");

		/// <summary>
		/// Description: Maximum order quantity
		/// FieldName: MOQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum order quantity")]
		public decimal? M3_MOQT => GetNullableDecimal("MOQT");

		/// <summary>
		/// Description: Order multiple
		/// FieldName: UNMU
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order multiple")]
		public decimal? M3_UNMU => GetNullableDecimal("UNMU");

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
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");

		/// <summary>
		/// Description: APP synchronization
		/// FieldName: APPC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP synchronization")]
		public string M3_APPC => GetString("APPC");

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
		/// Description: MRP low level code
		/// FieldName: LEVL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MRP low level code")]
		public int? M3_LEVL => GetNullableInt("LEVL");

		/// <summary>
		/// Description: Allocatable quantity
		/// FieldName: AVAL
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable quantity")]
		public decimal? M3_AVAL => GetNullableDecimal("AVAL");

		/// <summary>
		/// Description: Allocated quantity
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity")]
		public decimal? M3_ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Allocatable net
		/// FieldName: AV01
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable net")]
		public decimal? M3_AV01 => GetNullableDecimal("AV01");

		/// <summary>
		/// Description: Planning time fence
		/// FieldName: PFTM
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning time fence")]
		public int? M3_PFTM => GetNullableInt("PFTM");

		/// <summary>
		/// Description: Item group                      (MMITGR)
		/// FieldName: ITGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group                      (MMITGR)")]
		public string M3_ITGR => GetString("ITGR");

		/// <summary>
		/// Description: Product Group                   (MMITCL)
		/// FieldName: ITCL
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product Group                   (MMITCL)")]
		public string M3_ITCL => GetString("ITCL");

		/// <summary>
		/// Description: Procurement group               (MMPRGP)
		/// FieldName: PRGP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Procurement group               (MMPRGP)")]
		public string M3_PRGP => GetString("PRGP");

		/// <summary>
		/// Description: Item type                       (MMITTY)
		/// FieldName: ITTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item type                       (MMITTY)")]
		public string M3_ITTY => GetString("ITTY");

		/// <summary>
		/// Description: ABC class - manual              (MBMABC)
		/// FieldName: MABC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - manual              (MBMABC)")]
		public string M3_MABC => GetString("MABC");

		/// <summary>
		/// Description: ABC class - volume              (MBABCD)
		/// FieldName: ABCD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - volume              (MBABCD)")]
		public string M3_ABCD => GetString("ABCD");

		/// <summary>
		/// Description: ABC class - frequency           (MBABFC)
		/// FieldName: ABFC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - frequency           (MBABFC)")]
		public string M3_ABFC => GetString("ABFC");

		/// <summary>
		/// Description: ABC class - contribution        (MBACOC)
		/// FieldName: ACOC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - contribution        (MBACOC)")]
		public string M3_ACOC => GetString("ACOC");

		/// <summary>
		/// Description: Gross weight                    (MMGRWE)
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight                    (MMGRWE)")]
		public long? M3_GRWE => GetNullableLong("GRWE");

		/// <summary>
		/// Description: Net weight                      (MMNEWE)
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight                      (MMNEWE)")]
		public long? M3_NEWE => GetNullableLong("NEWE");

		/// <summary>
		/// Description: Volume                          (MMVOL3)
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume                          (MMVOL3)")]
		public long? M3_VOL3 => GetNullableLong("VOL3");

		/// <summary>
		/// Description: Item category (Reusable = P)    (MMTPCD)
		/// FieldName: TPCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item category (Reusable = P)    (MMTPCD)")]
		public string M3_TPCD => GetString("TPCD");

		/// <summary>
		/// Description: Group technology class          (MMGRTI)
		/// FieldName: GRTI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group technology class          (MMGRTI)")]
		public string M3_GRTI => GetString("GRTI");

		/// <summary>
		/// Description: Main product                    (PHHDPR)
		/// FieldName: HDPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product                    (PHHDPR)")]
		public string M3_HDPR => GetString("HDPR");

		/// <summary>
		/// Description: Responsible                     (MBRESP)
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible                     (MBRESP)")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: Inventory accounting            (MMSTCD)
		/// FieldName: STCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting            (MMSTCD)")]
		public int? M3_STCD => GetNullableInt("STCD");

		/// <summary>
		/// Description: Master scheduled
		/// FieldName: MSCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Master scheduled")]
		public int? M3_MSCH => GetNullableInt("MSCH");

		/// <summary>
		/// Description: Safety time
		/// FieldName: SATD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety time")]
		public int? M3_SATD => GetNullableInt("SATD");

		/// <summary>
		/// Description: Supply lead time
		/// FieldName: LEA1
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply lead time")]
		public int? M3_LEA1 => GetNullableInt("LEA1");

		/// <summary>
		/// Description: Inspection lead time
		/// FieldName: LEA2
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection lead time")]
		public int? M3_LEA2 => GetNullableInt("LEA2");

		/// <summary>
		/// Description: Transportation lead time
		/// FieldName: LEA3
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation lead time")]
		public int? M3_LEA3 => GetNullableInt("LEA3");

		/// <summary>
		/// Description: Responisible
		/// FieldName: RES1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responisible")]
		public string M3_RES1 => GetString("RES1");

		/// <summary>
		/// Description: Sales time
		/// FieldName: SAEL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales time")]
		public int? M3_SAEL => GetNullableInt("SAEL");

		/// <summary>
		/// Description: Shelf Life
		/// FieldName: SLDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shelf Life")]
		public int? M3_SLDY => GetNullableInt("SLDY");

		/// <summary>
		/// Description: Reorder point
		/// FieldName: REOP
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reorder point")]
		public decimal? M3_REOP => GetNullableDecimal("REOP");

		/// <summary>
		/// Description: On-hand balance for inspection
		/// FieldName: QUQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance for inspection")]
		public decimal? M3_QUQT => GetNullableDecimal("QUQT");

		/// <summary>
		/// Description: Priority value
		/// FieldName: PRIF
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority value")]
		public int? M3_PRIF => GetNullableInt("PRIF");

		/// <summary>
		/// Description: Run-out time
		/// FieldName: SODY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run-out time")]
		public int? M3_SODY => GetNullableInt("SODY");

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
		/// Description: Pending putaway - basic U/M
		/// FieldName: PPAQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pending putaway - basic U/M")]
		public decimal? M3_PPAQ => GetNullableDecimal("PPAQ");

		/// <summary>
		/// Description: Supply chain policy
		/// FieldName: SCPO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply chain policy")]
		public string M3_SCPO => GetString("SCPO");

		/// <summary>
		/// Description: Cost price in basic unit
		/// FieldName: UCOB
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price in basic unit")]
		public decimal? M3_UCOB => GetNullableDecimal("UCOB");
	}
}
// EOF
