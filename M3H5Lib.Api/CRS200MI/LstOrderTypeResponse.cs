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

namespace M3H5Lib.Api.CRS200MI
{
	public partial class LstOrderTypeResponse : M3BaseRecord 
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
		/// Description: Order type
		/// FieldName: TRTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_TRTP => GetString("TRTP");

		/// <summary>
		/// Description: Next manual function
		/// FieldName: FSQ3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next manual function")]
		public string M3_FSQ3 => GetString("FSQ3");

		/// <summary>
		/// Description: Name
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Stock transaction type
		/// FieldName: TTYP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock transaction type")]
		public int? M3_TTYP => GetNullableInt("TTYP");

		/// <summary>
		/// Description: Transaction sign
		/// FieldName: TTSI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction sign")]
		public string M3_TTSI => GetString("TTSI");

		/// <summary>
		/// Description: Transaction identity
		/// FieldName: TTID
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction identity")]
		public string M3_TTID => GetString("TTID");

		/// <summary>
		/// Description: Purchased quantity
		/// FieldName: PUQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchased quantity")]
		public decimal? M3_PUQT => GetNullableDecimal("PUQT");

		/// <summary>
		/// Description: Manufactured quantity
		/// FieldName: MAQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufactured quantity")]
		public decimal? M3_MAQT => GetNullableDecimal("MAQT");

		/// <summary>
		/// Description: Sold quantity
		/// FieldName: SOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sold quantity")]
		public decimal? M3_SOQT => GetNullableDecimal("SOQT");

		/// <summary>
		/// Description: Quantity used
		/// FieldName: USQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity used")]
		public decimal? M3_USQT => GetNullableDecimal("USQT");

		/// <summary>
		/// Description: Scrapped quantity
		/// FieldName: SCQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrapped quantity")]
		public decimal? M3_SCQT => GetNullableDecimal("SCQT");

		/// <summary>
		/// Description: Positive physical inventory variance
		/// FieldName: STDP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Positive physical inventory variance")]
		public decimal? M3_STDP => GetNullableDecimal("STDP");

		/// <summary>
		/// Description: Negative physical inventory variance
		/// FieldName: STDN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Negative physical inventory variance")]
		public decimal? M3_STDN => GetNullableDecimal("STDN");

		/// <summary>
		/// Description: Positive transfer
		/// FieldName: MOVP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Positive transfer")]
		public decimal? M3_MOVP => GetNullableDecimal("MOVP");

		/// <summary>
		/// Description: Negative transfer
		/// FieldName: MOVN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Negative transfer")]
		public decimal? M3_MOVN => GetNullableDecimal("MOVN");

		/// <summary>
		/// Description: Positive reclassification
		/// FieldName: RECP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Positive reclassification")]
		public decimal? M3_RECP => GetNullableDecimal("RECP");

		/// <summary>
		/// Description: Negative reclassification
		/// FieldName: RECN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Negative reclassification")]
		public decimal? M3_RECN => GetNullableDecimal("RECN");

		/// <summary>
		/// Description: Optional statistics field
		/// FieldName: FSQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Optional statistics field")]
		public decimal? M3_FSQ1 => GetNullableDecimal("FSQ1");

		/// <summary>
		/// Description: Print transaction log
		/// FieldName: TRLP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print transaction log")]
		public int? M3_TRLP => GetNullableInt("TRLP");

		/// <summary>
		/// Description: Proposed status in stock transaction header
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Proposed status in stock transaction header")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Line number interval
		/// FieldName: SINT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number interval")]
		public int? M3_SINT => GetNullableInt("SINT");

		/// <summary>
		/// Description: Order type - issuing repairables
		/// FieldName: OVGT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type - issuing repairables")]
		public string M3_OVGT => GetString("OVGT");

		/// <summary>
		/// Description: Inquiry type
		/// FieldName: QTTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inquiry type")]
		public int? M3_QTTP => GetNullableInt("QTTP");

		/// <summary>
		/// Description: Multiple warehouses permitted
		/// FieldName: MWHE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple warehouses permitted")]
		public int? M3_MWHE => GetNullableInt("MWHE");

		/// <summary>
		/// Description: Propose quantity for BoM
		/// FieldName: SUPQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Propose quantity for BoM")]
		public int? M3_SUPQ => GetNullableInt("SUPQ");

		/// <summary>
		/// Description: Availability check at line entry
		/// FieldName: SHAL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Availability check at line entry")]
		public int? M3_SHAL => GetNullableInt("SHAL");

		/// <summary>
		/// Description: Update subfile
		/// FieldName: SFUP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update subfile")]
		public int? M3_SFUP => GetNullableInt("SFUP");

		/// <summary>
		/// Description: Allow balance status other than 2
		/// FieldName: TRSC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow balance status other than 2")]
		public int? M3_TRSC => GetNullableInt("TRSC");

		/// <summary>
		/// Description: Update cumulative weight
		/// FieldName: AGWU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update cumulative weight")]
		public int? M3_AGWU => GetNullableInt("AGWU");

		/// <summary>
		/// Description: Check method- reference orders
		/// FieldName: TROC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check method- reference orders")]
		public int? M3_TROC => GetNullableInt("TROC");

		/// <summary>
		/// Description: Allow issues of nonstocked items
		/// FieldName: ISNI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow issues of nonstocked items")]
		public int? M3_ISNI => GetNullableInt("ISNI");

		/// <summary>
		/// Description: Check dangerous items
		/// FieldName: ITCR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check dangerous items")]
		public int? M3_ITCR => GetNullableInt("ITCR");

		/// <summary>
		/// Description: Reference text type
		/// FieldName: RFTT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference text type")]
		public int? M3_RFTT => GetNullableInt("RFTT");

		/// <summary>
		/// Description: Number series
		/// FieldName: NBID
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number series")]
		public string M3_NBID => GetString("NBID");

		/// <summary>
		/// Description: Allow different order dates on lines
		/// FieldName: DTRD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow different order dates on lines")]
		public int? M3_DTRD => GetNullableInt("DTRD");

		/// <summary>
		/// Description: Reduce gross reservation
		/// FieldName: RGRR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reduce gross reservation")]
		public int? M3_RGRR => GetNullableInt("RGRR");

		/// <summary>
		/// Description: Reference to replaced item number
		/// FieldName: RITS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference to replaced item number")]
		public int? M3_RITS => GetNullableInt("RITS");

		/// <summary>
		/// Description: Configuration management
		/// FieldName: EFMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration management")]
		public int? M3_EFMA => GetNullableInt("EFMA");

		/// <summary>
		/// Description: Order line for alias number permitted
		/// FieldName: ALIU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line for alias number permitted")]
		public int? M3_ALIU => GetNullableInt("ALIU");

		/// <summary>
		/// Description: Message when on-hand becomes zero
		/// FieldName: MQOH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message when on-hand becomes zero")]
		public int? M3_MQOH => GetNullableInt("MQOH");

		/// <summary>
		/// Description: Appl message for items with issue msg
		/// FieldName: MAUT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Appl message for items with issue msg")]
		public int? M3_MAUT => GetNullableInt("MAUT");

		/// <summary>
		/// Description: Update log when order lines are changed
		/// FieldName: UPCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update log when order lines are changed")]
		public int? M3_UPCL => GetNullableInt("UPCL");

		/// <summary>
		/// Description: Permit use of alternate U/M
		/// FieldName: ALUU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Permit use of alternate U/M")]
		public int? M3_ALUU => GetNullableInt("ALUU");

		/// <summary>
		/// Description: Facility owner
		/// FieldName: TSDV
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility owner")]
		public string M3_TSDV => GetString("TSDV");

		/// <summary>
		/// Description: Packaging action
		/// FieldName: PCKA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging action")]
		public int? M3_PCKA => GetNullableInt("PCKA");

		/// <summary>
		/// Description: Order number check at stock return
		/// FieldName: SRIC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order number check at stock return")]
		public int? M3_SRIC => GetNullableInt("SRIC");

		/// <summary>
		/// Description: Priority
		/// FieldName: PRIO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3_PRIO => GetNullableInt("PRIO");

		/// <summary>
		/// Description: Credit order account entry
		/// FieldName: COAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit order account entry")]
		public int? M3_COAC => GetNullableInt("COAC");

		/// <summary>
		/// Description: Dispatch policy
		/// FieldName: DPOL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dispatch policy")]
		public string M3_DPOL => GetString("DPOL");

		/// <summary>
		/// Description: Reschedule from when pre-alloc change
		/// FieldName: PTRG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reschedule from when pre-alloc change")]
		public int? M3_PTRG => GetNullableInt("PTRG");

		/// <summary>
		/// Description: Update pre-allocation when qty chg
		/// FieldName: PTQC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update pre-allocation when qty chg")]
		public int? M3_PTQC => GetNullableInt("PTQC");

		/// <summary>
		/// Description: Allow allocation below safety stock
		/// FieldName: AASS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow allocation below safety stock")]
		public int? M3_AASS => GetNullableInt("AASS");

		/// <summary>
		/// Description: Representative transaction
		/// FieldName: RPRT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Representative transaction")]
		public int? M3_RPRT => GetNullableInt("RPRT");

		/// <summary>
		/// Description: Automatic deletion
		/// FieldName: AUDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic deletion")]
		public int? M3_AUDE => GetNullableInt("AUDE");

		/// <summary>
		/// Description: Two-step put-away
		/// FieldName: TSPA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Two-step put-away")]
		public int? M3_TSPA => GetNullableInt("TSPA");

		/// <summary>
		/// Description: Return document control
		/// FieldName: PACA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return document control")]
		public int? M3_PACA => GetNullableInt("PACA");

		/// <summary>
		/// Description: New order per product for BoM requisitn
		/// FieldName: OHCC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New order per product for BoM requisitn")]
		public int? M3_OHCC => GetNullableInt("OHCC");

		/// <summary>
		/// Description: Accumulate requisition order value
		/// FieldName: ARVA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accumulate requisition order value")]
		public int? M3_ARVA => GetNullableInt("ARVA");

		/// <summary>
		/// Description: Accept zero quantity at order line entry
		/// FieldName: AZQT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accept zero quantity at order line entry")]
		public int? M3_AZQT => GetNullableInt("AZQT");

		/// <summary>
		/// Description: Noninventory via purchase requisition
		/// FieldName: NIPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Noninventory via purchase requisition")]
		public int? M3_NIPR => GetNullableInt("NIPR");

		/// <summary>
		/// Description: Default purchase order type
		/// FieldName: POTD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default purchase order type")]
		public string M3_POTD => GetString("POTD");

		/// <summary>
		/// Description: Confirm change of requisition resp
		/// FieldName: CFRC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirm change of requisition resp")]
		public int? M3_CFRC => GetNullableInt("CFRC");

		/// <summary>
		/// Description: Line suffix is used
		/// FieldName: SXUS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix is used")]
		public int? M3_SXUS => GetNullableInt("SXUS");

		/// <summary>
		/// Description: Update lowest picking location
		/// FieldName: ULPL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update lowest picking location")]
		public int? M3_ULPL => GetNullableInt("ULPL");

		/// <summary>
		/// Description: Authorization level
		/// FieldName: ATHC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorization level")]
		public int? M3_ATHC => GetNullableInt("ATHC");

		/// <summary>
		/// Description: Copy order header text
		/// FieldName: COHT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Copy order header text")]
		public int? M3_COHT => GetNullableInt("COHT");

		/// <summary>
		/// Description: Panel version
		/// FieldName: PAVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel version")]
		public string M3_PAVR => GetString("PAVR");

		/// <summary>
		/// Description: Panel sequence
		/// FieldName: PSQQ
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel sequence")]
		public string M3_PSQQ => GetString("PSQQ");
	}
}
// EOF
