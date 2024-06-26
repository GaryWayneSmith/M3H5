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

namespace M3H5Lib.Api.MMS080MI
{
	public partial class SelItemWarehousResponse : M3BaseRecord 
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
		/// Description: Item description
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item description")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Approved on-hand balance qty (6 dec)
		/// FieldName: STQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved on-hand balance qty (6 dec)")]
		public decimal? M3STQT => GetNullableDecimal("STQT");

		/// <summary>
		/// Description: Purchase lead time
		/// FieldName: LEAT
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase lead time")]
		public int? M3LEAT => GetNullableInt("LEAT");

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
		/// Description: Sales item
		/// FieldName: SALE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales item")]
		public int? M3SALE => GetNullableInt("SALE");

		/// <summary>
		/// Description: Maximum stock
		/// FieldName: MXST
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum stock")]
		public decimal? M3MXST => GetNullableDecimal("MXST");

		/// <summary>
		/// Description: Safety stock
		/// FieldName: SSQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock")]
		public decimal? M3SSQT => GetNullableDecimal("SSQT");

		/// <summary>
		/// Description: Cost price/average price
		/// FieldName: UCOS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price/average price")]
		public decimal? M3UCOS => GetNullableDecimal("UCOS");

		/// <summary>
		/// Description: Minimum order quantity
		/// FieldName: LOQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum order quantity")]
		public decimal? M3LOQT => GetNullableDecimal("LOQT");

		/// <summary>
		/// Description: Maximum order quantity
		/// FieldName: MOQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum order quantity")]
		public decimal? M3MOQT => GetNullableDecimal("MOQT");

		/// <summary>
		/// Description: Order multiple
		/// FieldName: UNMU
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order multiple")]
		public decimal? M3UNMU => GetNullableDecimal("UNMU");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");

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
		/// Description: MRP low level code
		/// FieldName: LEVL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MRP low level code")]
		public int? M3LEVL => GetNullableInt("LEVL");

		/// <summary>
		/// Description: Allocatable quantity
		/// FieldName: AVAL
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable quantity")]
		public decimal? M3AVAL => GetNullableDecimal("AVAL");

		/// <summary>
		/// Description: Allocated quantity
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity")]
		public decimal? M3ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Allocatable net
		/// FieldName: AV01
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable net")]
		public decimal? M3AV01 => GetNullableDecimal("AV01");

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
		/// Description: Item group                      (MMITGR)
		/// FieldName: ITGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group                      (MMITGR)")]
		public string M3ITGR => GetString("ITGR");

		/// <summary>
		/// Description: Product Group                   (MMITCL)
		/// FieldName: ITCL
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product Group                   (MMITCL)")]
		public string M3ITCL => GetString("ITCL");

		/// <summary>
		/// Description: Procurement group               (MMPRGP)
		/// FieldName: PRGP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Procurement group               (MMPRGP)")]
		public string M3PRGP => GetString("PRGP");

		/// <summary>
		/// Description: Item type                       (MMITTY)
		/// FieldName: ITTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item type                       (MMITTY)")]
		public string M3ITTY => GetString("ITTY");

		/// <summary>
		/// Description: ABC class - manual              (MBMABC)
		/// FieldName: MABC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - manual              (MBMABC)")]
		public string M3MABC => GetString("MABC");

		/// <summary>
		/// Description: ABC class - volume              (MBABCD)
		/// FieldName: ABCD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - volume              (MBABCD)")]
		public string M3ABCD => GetString("ABCD");

		/// <summary>
		/// Description: ABC class - frequency           (MBABFC)
		/// FieldName: ABFC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - frequency           (MBABFC)")]
		public string M3ABFC => GetString("ABFC");

		/// <summary>
		/// Description: ABC class - contribution        (MBACOC)
		/// FieldName: ACOC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - contribution        (MBACOC)")]
		public string M3ACOC => GetString("ACOC");

		/// <summary>
		/// Description: Gross weight                    (MMGRWE)
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight                    (MMGRWE)")]
		public long? M3GRWE => GetNullableLong("GRWE");

		/// <summary>
		/// Description: Net weight                      (MMNEWE)
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight                      (MMNEWE)")]
		public long? M3NEWE => GetNullableLong("NEWE");

		/// <summary>
		/// Description: Volume                          (MMVOL3)
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume                          (MMVOL3)")]
		public long? M3VOL3 => GetNullableLong("VOL3");

		/// <summary>
		/// Description: Item category (Reusable = P)    (MMTPCD)
		/// FieldName: TPCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item category (Reusable = P)    (MMTPCD)")]
		public string M3TPCD => GetString("TPCD");

		/// <summary>
		/// Description: Group technology class          (MMGRTI)
		/// FieldName: GRTI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group technology class          (MMGRTI)")]
		public string M3GRTI => GetString("GRTI");

		/// <summary>
		/// Description: Main product                    (PHHDPR)
		/// FieldName: HDPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product                    (PHHDPR)")]
		public string M3HDPR => GetString("HDPR");

		/// <summary>
		/// Description: Responsible                     (MBRESP)
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible                     (MBRESP)")]
		public string M3RESP => GetString("RESP");

		/// <summary>
		/// Description: Inventory accounting            (MMSTCD)
		/// FieldName: STCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting            (MMSTCD)")]
		public int? M3STCD => GetNullableInt("STCD");

		/// <summary>
		/// Description: Master scheduled
		/// FieldName: MSCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Master scheduled")]
		public int? M3MSCH => GetNullableInt("MSCH");

		/// <summary>
		/// Description: Safety time
		/// FieldName: SATD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety time")]
		public int? M3SATD => GetNullableInt("SATD");

		/// <summary>
		/// Description: Supply lead time
		/// FieldName: LEA1
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply lead time")]
		public int? M3LEA1 => GetNullableInt("LEA1");

		/// <summary>
		/// Description: Inspection lead time
		/// FieldName: LEA2
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection lead time")]
		public int? M3LEA2 => GetNullableInt("LEA2");

		/// <summary>
		/// Description: Transportation lead time
		/// FieldName: LEA3
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation lead time")]
		public int? M3LEA3 => GetNullableInt("LEA3");

		/// <summary>
		/// Description: Responisible
		/// FieldName: RES1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responisible")]
		public string M3RES1 => GetString("RES1");

		/// <summary>
		/// Description: Sales time
		/// FieldName: SAEL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales time")]
		public int? M3SAEL => GetNullableInt("SAEL");

		/// <summary>
		/// Description: Shelf Life
		/// FieldName: SLDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shelf Life")]
		public int? M3SLDY => GetNullableInt("SLDY");

		/// <summary>
		/// Description: Reorder point
		/// FieldName: REOP
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reorder point")]
		public decimal? M3REOP => GetNullableDecimal("REOP");

		/// <summary>
		/// Description: On-hand balance for inspection
		/// FieldName: QUQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance for inspection")]
		public decimal? M3QUQT => GetNullableDecimal("QUQT");

		/// <summary>
		/// Description: Priority value
		/// FieldName: PRIF
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority value")]
		public int? M3PRIF => GetNullableInt("PRIF");

		/// <summary>
		/// Description: Run-out time
		/// FieldName: SODY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run-out time")]
		public int? M3SODY => GetNullableInt("SODY");

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
		/// Description: Pending putaway - basic U/M
		/// FieldName: PPAQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pending putaway - basic U/M")]
		public decimal? M3PPAQ => GetNullableDecimal("PPAQ");

		/// <summary>
		/// Description: Supply chain policy
		/// FieldName: SCPO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply chain policy")]
		public string M3SCPO => GetString("SCPO");

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
		/// Description: By/co-product code
		/// FieldName: BYPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("By/co-product code")]
		public int? M3BYPR => GetNullableInt("BYPR");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3SAPR => GetNullableDecimal("SAPR");

		/// <summary>
		/// Description: Purchase price
		/// FieldName: PUPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price")]
		public decimal? M3PUPR => GetNullableDecimal("PUPR");

		/// <summary>
		/// Description: Aging days
		/// FieldName: AGDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aging days")]
		public int? M3AGDY => GetNullableInt("AGDY");

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
		/// Description: Supplying warehouse
		/// FieldName: SUWH
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying warehouse")]
		public string M3SUWH => GetString("SUWH");

		/// <summary>
		/// Description: Time phased safety stock exists
		/// FieldName: DDEX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time phased safety stock exists")]
		public int? M3DDEX => GetNullableInt("DDEX");

		/// <summary>
		/// Description: Period frame
		/// FieldName: DPID
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period frame")]
		public int? M3DPID => GetNullableInt("DPID");

		/// <summary>
		/// Description: Administrative lead time
		/// FieldName: LEA4
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Administrative lead time")]
		public int? M3LEA4 => GetNullableInt("LEA4");

		/// <summary>
		/// Description: Transmission lead time - supplier
		/// FieldName: PODA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transmission lead time - supplier")]
		public int? M3PODA => GetNullableInt("PODA");

		/// <summary>
		/// Description: Main warehouse
		/// FieldName: REWH
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main warehouse")]
		public string M3REWH => GetString("REWH");

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
		/// Description: Safety stock method
		/// FieldName: SSMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock method")]
		public int? M3SSMT => GetNullableInt("SSMT");

		/// <summary>
		/// Description: Safety stock unit
		/// FieldName: SSDA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock unit")]
		public int? M3SSDA => GetNullableInt("SSDA");

		/// <summary>
		/// Description: Cost price in basic unit
		/// FieldName: UCOB
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price in basic unit")]
		public decimal? M3UCOB => GetNullableDecimal("UCOB");

		/// <summary>
		/// Description: Sales price basic unit local curr
		/// FieldName: SPRB
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price basic unit local curr")]
		public decimal? M3SPRB => GetNullableDecimal("SPRB");

		/// <summary>
		/// Description: Purchase price basic unit local curr
		/// FieldName: PPRB
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price basic unit local curr")]
		public decimal? M3PPRB => GetNullableDecimal("PPRB");

		/// <summary>
		/// Description: Aging hours
		/// FieldName: AGHO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aging hours")]
		public int? M3AGHO => GetNullableInt("AGHO");

		/// <summary>
		/// Description: Aging minutes
		/// FieldName: AGMI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aging minutes")]
		public int? M3AGMI => GetNullableInt("AGMI");
	}
}
// EOF
