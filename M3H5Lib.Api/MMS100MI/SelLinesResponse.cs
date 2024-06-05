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

namespace M3H5Lib.Api.MMS100MI
{
	public partial class SelLinesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company                         (MGCONO)
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company                         (MGCONO)")]
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Facility (of receiving whs)     (MGFACI)
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility (of receiving whs)     (MGFACI)")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: From warehouse                  (MRWHLO)
		/// FieldName: FWHL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From warehouse                  (MRWHLO)")]
		public string M3FWHL => GetString("FWHL");

		/// <summary>
		/// Description: To warehouse                    (MGTWLO)
		/// FieldName: TWHL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To warehouse                    (MGTWLO)")]
		public string M3TWHL => GetString("TWHL");

		/// <summary>
		/// Description: Order number                    (MGTRNR)
		/// FieldName: TRNR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order number                    (MGTRNR)")]
		public string M3TRNR => GetString("TRNR");

		/// <summary>
		/// Description: Line number                     (MRPONR)
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number                     (MRPONR)")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Line suffix                     (MRPOSX)
		/// FieldName: POSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix                     (MRPOSX)")]
		public int? M3POSX => GetNullableInt("POSX");

		/// <summary>
		/// Description: Item number                     (MRITNO)
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number                     (MRITNO)")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Action message                  (MOACTP)
		/// FieldName: ACTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action message                  (MOACTP)")]
		public string M3ACTP => GetString("ACTP");

		/// <summary>
		/// Description: Item description                (MMITDS)
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item description                (MMITDS)")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Reference order category        (MRRORC)
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category        (MRRORC)")]
		public int? M3RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Status (order line)             (MRTRSH)
		/// FieldName: TRSH
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status (order line)             (MRTRSH)")]
		public int? M3TRSH => GetNullableInt("TRSH");

		/// <summary>
		/// Description: Reference order number          (MRRORN)
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number          (MRRORN)")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Reference order line            (MRRORL)
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line            (MRRORL)")]
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
		/// Description: Priority                        (MGPRIO)
		/// FieldName: PRIO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority                        (MGPRIO)")]
		public int? M3PRIO => GetNullableInt("PRIO");

		/// <summary>
		/// Description: Quantity on order line          (MRTRQT)
		/// FieldName: TRQ1
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity on order line          (MRTRQT)")]
		public decimal? M3TRQ1 => GetNullableDecimal("TRQ1");

		/// <summary>
		/// Description: Material plan quantity          (MOTRQT)
		/// FieldName: TRQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material plan quantity          (MOTRQT)")]
		public decimal? M3TRQT => GetNullableDecimal("TRQT");

		/// <summary>
		/// Description: Allocated quantity              (MOALQT)
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity              (MOALQT)")]
		public decimal? M3ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Reported quantity               (MRRPQT)
		/// FieldName: RPQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reported quantity               (MRRPQT)")]
		public decimal? M3RPQT => GetNullableDecimal("RPQT");

		/// <summary>
		/// Description: Remaining quantity       (MOTRQT-MOALQT)
		/// FieldName: RNQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining quantity       (MOTRQT-MOALQT)")]
		public decimal? M3RNQT => GetNullableDecimal("RNQT");

		/// <summary>
		/// Description: Transaction date (issue)        (MRTRDT)
		/// FieldName: TRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction date (issue)        (MRTRDT)")]
		public DateTime? M3TRDT => GetNullableDateTime("TRDT");

		/// <summary>
		/// Description: Transaction time (issue)        (MOTIHM)
		/// FieldName: TIHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction time (issue)        (MOTIHM)")]
		public int? M3TIHM => GetNullableInt("TIHM");

		/// <summary>
		/// Description: Receiving date                  (MOPLDT)
		/// FieldName: RIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving date                  (MOPLDT)")]
		public DateTime? M3RIDT => GetNullableDateTime("RIDT");

		/// <summary>
		/// Description: Receiving time                  (MOTIHM)
		/// FieldName: RTME
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving time                  (MOTIHM)")]
		public int? M3RTME => GetNullableInt("RTME");

		/// <summary>
		/// Description: Alternate planning date         (MONNDT)
		/// FieldName: NNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate planning date         (MONNDT)")]
		public DateTime? M3NNDT => GetNullableDateTime("NNDT");

		/// <summary>
		/// Description: Transportation time (days)      (MGTRDY)
		/// FieldName: TRDY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation time (days)      (MGTRDY)")]
		public int? M3TRDY => GetNullableInt("TRDY");

		/// <summary>
		/// Description: Due date                       (special)
		/// FieldName: DUED
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date                       (special)")]
		public DateTime? M3DUED => GetNullableDateTime("DUED");

		/// <summary>
		/// Description: Order-dependent                (special)
		/// FieldName: ORDP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order-dependent                (special)")]
		public int? M3ORDP => GetNullableInt("ORDP");

		/// <summary>
		/// Description: Delivery method                 (MGMODL)
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method                 (MGMODL)")]
		public string M3MODL => GetString("MODL");

		/// <summary>
		/// Description: Delivery terms                  (MGTEDL)
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms                  (MGTEDL)")]
		public string M3TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Order type                      (MGTRTP)
		/// FieldName: TRTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type                      (MGTRTP)")]
		public string M3TRTP => GetString("TRTP");

		/// <summary>
		/// Description: Old CFIN
		/// FieldName: CFXX
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old CFIN")]
		public int? M3CFXX => GetNullableInt("CFXX");

		/// <summary>
		/// Description: Main product                    (MRHDPR)
		/// FieldName: HDPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product                    (MRHDPR)")]
		public string M3HDPR => GetString("HDPR");

		/// <summary>
		/// Description: Responsible (order header)      (MGRESP)
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible (order header)      (MGRESP)")]
		public string M3RESP => GetString("RESP");

		/// <summary>
		/// Description: Forwarding agent                (MGFWNO)
		/// FieldName: FWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarding agent                (MGFWNO)")]
		public string M3FWNO => GetString("FWNO");

		/// <summary>
		/// Description: Network status                 (special)
		/// FieldName: NWST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Network status                 (special)")]
		public int? M3NWST => GetNullableInt("NWST");

		/// <summary>
		/// Description: From facility (sending whs)    (special)
		/// FieldName: FFAC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From facility (sending whs)    (special)")]
		public string M3FFAC => GetString("FFAC");

		/// <summary>
		/// Description: Supplying MO                   (special)
		/// FieldName: SPMO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying MO                   (special)")]
		public int? M3SPMO => GetNullableInt("SPMO");

		/// <summary>
		/// Description: Safety time                     (MBSATD)
		/// FieldName: SATD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety time                     (MBSATD)")]
		public int? M3SATD => GetNullableInt("SATD");

		/// <summary>
		/// Description: Reporting date                  (MRRPDT)
		/// FieldName: RPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting date                  (MRRPDT)")]
		public DateTime? M3RPDT => GetNullableDateTime("RPDT");

		/// <summary>
		/// Description: Re-schedule in filter date     (special)
		/// FieldName: RIFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Re-schedule in filter date     (special)")]
		public DateTime? M3RIFD => GetNullableDateTime("RIFD");

		/// <summary>
		/// Description: Re-schedule out filter date    (special)
		/// FieldName: ROFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Re-schedule out filter date    (special)")]
		public DateTime? M3ROFD => GetNullableDateTime("ROFD");

		/// <summary>
		/// Description: Supplying DO number             (MRTRNR)
		/// FieldName: SPDO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying DO number             (MRTRNR)")]
		public string M3SPDO => GetString("SPDO");

		/// <summary>
		/// Description: Supplying DO Line              (special)
		/// FieldName: SPDL
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying DO Line              (special)")]
		public int? M3SPDL => GetNullableInt("SPDL");

		/// <summary>
		/// Description: Sub-network mark
		/// FieldName: SUBN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sub-network mark")]
		public int? M3SUBN => GetNullableInt("SUBN");

		/// <summary>
		/// Description: Transportation hours
		/// FieldName: TRTE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation hours")]
		public int? M3TRTE => GetNullableInt("TRTE");

		/// <summary>
		/// Description: Timedifference between FWHL and TWHL
		/// FieldName: TIMZ
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timedifference between FWHL and TWHL")]
		public int? M3TIMZ => GetNullableInt("TIMZ");

		/// <summary>
		/// Description: Estimated free unit of assigned goods
		/// FieldName: FCU1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated free unit of assigned goods")]
		public decimal? M3FCU1 => GetNullableDecimal("FCU1");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Supplying order category
		/// FieldName: SORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying order category")]
		public int? M3SORC => GetNullableInt("SORC");

		/// <summary>
		/// Description: Supplier order number
		/// FieldName: SORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier order number")]
		public string M3SORN => GetString("SORN");

		/// <summary>
		/// Description: Supplying order line
		/// FieldName: SORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying order line")]
		public int? M3SORL => GetNullableInt("SORL");

		/// <summary>
		/// Description: Configuration number            (MRCFIN)
		/// FieldName: CFIN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration number            (MRCFIN)")]
		public long? M3CFIN => GetNullableLong("CFIN");
	}
}
// EOF
