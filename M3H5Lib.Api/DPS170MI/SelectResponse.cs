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

namespace M3H5Lib.Api.DPS170MI
{
	public partial class SelectResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company                         (DOCONO)
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company                         (DOCONO)")]
		public int? M3_CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Facility (of receiving whs)     (DOFACI)
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility (of receiving whs)     (DOFACI)")]
		public string M3_FACI => GetString("FACI");

		/// <summary>
		/// Description: From warehouse                  (DOFWHL)
		/// FieldName: FWHL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From warehouse                  (DOFWHL)")]
		public string M3_FWHL => GetString("FWHL");

		/// <summary>
		/// Description: To warehouse                    (DOTWHL)
		/// FieldName: TWHL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To warehouse                    (DOTWHL)")]
		public string M3_TWHL => GetString("TWHL");

		/// <summary>
		/// Description: Planned order number            (DOPLPN)
		/// FieldName: PLPN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned order number            (DOPLPN)")]
		public int? M3_PLPN => GetNullableInt("PLPN");

		/// <summary>
		/// Description: Planned order sub-number        (DOPLPS)
		/// FieldName: PLPS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned order sub-number        (DOPLPS)")]
		public int? M3_PLPS => GetNullableInt("PLPS");

		/// <summary>
		/// Description: Item number                     (DOITNO)
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number                     (DOITNO)")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Action message                  (DOACTP)
		/// FieldName: ACTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action message                  (DOACTP)")]
		public string M3_ACTP => GetString("ACTP");

		/// <summary>
		/// Description: Item description                (MMITDS)
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item description                (MMITDS)")]
		public string M3_ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Status - planned DO             (DOPSTS)
		/// FieldName: PSTS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - planned DO             (DOPSTS)")]
		public string M3_PSTS => GetString("PSTS");

		/// <summary>
		/// Description: Reference order category        (DORORC)
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category        (DORORC)")]
		public int? M3_RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Reference order number          (DORORN)
		/// FieldName: RORN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number          (DORORN)")]
		public long? M3_RORN => GetNullableLong("RORN");

		/// <summary>
		/// Description: Reference order line            (DORORL)
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line            (DORORL)")]
		public int? M3_RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3_RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Priority                        (DOPRIP)
		/// FieldName: PRIP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority                        (DOPRIP)")]
		public string M3_PRIP => GetString("PRIP");

		/// <summary>
		/// Description: Planned quantity                (DOPPQT)
		/// FieldName: PPQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned quantity                (DOPPQT)")]
		public decimal? M3_PPQT => GetNullableDecimal("PPQT");

		/// <summary>
		/// Description: Planned delivery (finish) date  (DODLDT)
		/// FieldName: DLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned delivery (finish) date  (DODLDT)")]
		public DateTime? M3_DLDT => GetNullableDateTime("DLDT");

		/// <summary>
		/// Description: Planned delivery (finish) time  (MOTIHM)
		/// FieldName: DLTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned delivery (finish) time  (MOTIHM)")]
		public int? M3_DLTM => GetNullableInt("DLTM");

		/// <summary>
		/// Description: Start date (issue at suppl. whs)(MOPLDT)
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date (issue at suppl. whs)(MOPLDT)")]
		public DateTime? M3_STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Start time (issue at suppl. whs)(MOTIHM)
		/// FieldName: STTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time (issue at suppl. whs)(MOTIHM)")]
		public int? M3_STTM => GetNullableInt("STTM");

		/// <summary>
		/// Description: Alternate planning date         (MONNDT)
		/// FieldName: NNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate planning date         (MONNDT)")]
		public DateTime? M3_NNDT => GetNullableDateTime("NNDT");

		/// <summary>
		/// Description: Release date                    (DORELD)
		/// FieldName: RELD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Release date                    (DORELD)")]
		public DateTime? M3_RELD => GetNullableDateTime("RELD");

		/// <summary>
		/// Description: Transportation time (days)      (DOTRDY)
		/// FieldName: TRDY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation time (days)      (DOTRDY)")]
		public int? M3_TRDY => GetNullableInt("TRDY");

		/// <summary>
		/// Description: Due date                       (special)
		/// FieldName: DUED
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date                       (special)")]
		public DateTime? M3_DUED => GetNullableDateTime("DUED");

		/// <summary>
		/// Description: Order-dependent                (special)
		/// FieldName: ORDP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order-dependent                (special)")]
		public int? M3_ORDP => GetNullableInt("ORDP");

		/// <summary>
		/// Description: Delivery method                 (DOMODL)
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method                 (DOMODL)")]
		public string M3_MODL => GetString("MODL");

		/// <summary>
		/// Description: Delivery terms                  (DOTEDL)
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms                  (DOTEDL)")]
		public string M3_TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Order type                      (DOORTY)
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type                      (DOORTY)")]
		public string M3_ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Old CFIN
		/// FieldName: CFXX
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old CFIN")]
		public int? M3_CFXX => GetNullableInt("CFXX");

		/// <summary>
		/// Description: Main product                    (DOHDPR)
		/// FieldName: HDPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product                    (DOHDPR)")]
		public string M3_HDPR => GetString("HDPR");

		/// <summary>
		/// Description: Responsible                     (DORESP)
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible                     (DORESP)")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: Forwarding agent                (DOFWNO)
		/// FieldName: FWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarding agent                (DOFWNO)")]
		public string M3_FWNO => GetString("FWNO");

		/// <summary>
		/// Description: From facility (sending whs)    (special)
		/// FieldName: FFAC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From facility (sending whs)    (special)")]
		public string M3_FFAC => GetString("FFAC");

		/// <summary>
		/// Description: Network status                 (special)
		/// FieldName: NWST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Network status                 (special)")]
		public int? M3_NWST => GetNullableInt("NWST");

		/// <summary>
		/// Description: Supplying MO proposal          (special)
		/// FieldName: SPPL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying MO proposal          (special)")]
		public int? M3_SPPL => GetNullableInt("SPPL");

		/// <summary>
		/// Description: Safety time                     (MBSATD)
		/// FieldName: SATD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety time                     (MBSATD)")]
		public int? M3_SATD => GetNullableInt("SATD");

		/// <summary>
		/// Description: Re-schedule in filter date
		/// FieldName: RIFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Re-schedule in filter date")]
		public DateTime? M3_RIFD => GetNullableDateTime("RIFD");

		/// <summary>
		/// Description: Re-schedule out filter date
		/// FieldName: ROFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Re-schedule out filter date")]
		public DateTime? M3_ROFD => GetNullableDateTime("ROFD");

		/// <summary>
		/// Description: Sub-network mark
		/// FieldName: SUBN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sub-network mark")]
		public int? M3_SUBN => GetNullableInt("SUBN");

		/// <summary>
		/// Description: Subnetwork due date
		/// FieldName: SUBD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnetwork due date")]
		public DateTime? M3_SUBD => GetNullableDateTime("SUBD");

		/// <summary>
		/// Description: Timedifference between FWHL and TWHL
		/// FieldName: TIMZ
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timedifference between FWHL and TWHL")]
		public int? M3_TIMZ => GetNullableInt("TIMZ");

		/// <summary>
		/// Description: Transportation hours
		/// FieldName: TRTE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation hours")]
		public int? M3_TRTE => GetNullableInt("TRTE");

		/// <summary>
		/// Description: Estimated free unit of assigned goods
		/// FieldName: FCU1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated free unit of assigned goods")]
		public decimal? M3_FCU1 => GetNullableDecimal("FCU1");

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
		/// Description: Macro order number
		/// FieldName: MACN
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order number")]
		public decimal? M3_MACN => GetNullableDecimal("MACN");

		/// <summary>
		/// Description: Configuration number            (DOCFIN)
		/// FieldName: CFIN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration number            (DOCFIN)")]
		public long? M3_CFIN => GetNullableLong("CFIN");
	}
}
// EOF
