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

namespace M3H5Lib.Api.PPS095MI
{
	public partial class LstOrderTypeResponse : M3BaseRecord 
	{

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
		/// Description: Purchase order category
		/// FieldName: POTC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order category")]
		public string M3POTC => GetString("POTC");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Panel sequence
		/// FieldName: PSEQ
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel sequence")]
		public string M3PSEQ => GetString("PSEQ");

		/// <summary>
		/// Description: Panel sequence
		/// FieldName: PSQ1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel sequence")]
		public string M3PSQ1 => GetString("PSQ1");

		/// <summary>
		/// Description: 020 Number series - PO
		/// FieldName: P020
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("020 Number series - PO")]
		public string M3P020 => GetString("P020");

		/// <summary>
		/// Description: 021 Number series - goods receiving doc
		/// FieldName: P021
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("021 Number series - goods receiving doc")]
		public string M3P021 => GetString("P021");

		/// <summary>
		/// Description: 022 Number series - claims
		/// FieldName: P022
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("022 Number series - claims")]
		public string M3P022 => GetString("P022");

		/// <summary>
		/// Description: 030 Document variant - PO
		/// FieldName: P030
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("030 Document variant - PO")]
		public string M3P030 => GetString("P030");

		/// <summary>
		/// Description: 040 Goods receiving method
		/// FieldName: P040
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("040 Goods receiving method")]
		public string M3P040 => GetString("P040");

		/// <summary>
		/// Description: 050 Media Profile - PO
		/// FieldName: P050
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("050 Media Profile - PO")]
		public string M3P050 => GetString("P050");

		/// <summary>
		/// Description: 060 Reference order category
		/// FieldName: P060
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("060 Reference order category")]
		public int? M3P060 => GetNullableInt("P060");

		/// <summary>
		/// Description: 070 Authority check
		/// FieldName: P070
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("070 Authority check")]
		public int? M3P070 => GetNullableInt("P070");

		/// <summary>
		/// Description: 110 Mandatory item/supplier record
		/// FieldName: P110
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("110 Mandatory item/supplier record")]
		public int? M3P110 => GetNullableInt("P110");

		/// <summary>
		/// Description: 120 Printout method - item name
		/// FieldName: P120
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("120 Printout method - item name")]
		public int? M3P120 => GetNullableInt("P120");

		/// <summary>
		/// Description: 121 Printout method - item description
		/// FieldName: P121
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("121 Printout method - item description")]
		public int? M3P121 => GetNullableInt("P121");

		/// <summary>
		/// Description: 130 Print PO lines
		/// FieldName: P130
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("130 Print PO lines")]
		public int? M3P130 => GetNullableInt("P130");

		/// <summary>
		/// Description: 140 PO split on reference person
		/// FieldName: P140
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("140 PO split on reference person")]
		public int? M3P140 => GetNullableInt("P140");

		/// <summary>
		/// Description: 150 Update material plan
		/// FieldName: P150
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("150 Update material plan")]
		public int? M3P150 => GetNullableInt("P150");

		/// <summary>
		/// Description: 160 Multiple agreements per PO
		/// FieldName: P160
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("160 Multiple agreements per PO")]
		public int? M3P160 => GetNullableInt("P160");

		/// <summary>
		/// Description: 161 Agreement check - PO entry
		/// FieldName: P161
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("161 Agreement check - PO entry")]
		public int? M3P161 => GetNullableInt("P161");

		/// <summary>
		/// Description: 170 PO deletion method - PO
		/// FieldName: P170
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("170 PO deletion method - PO")]
		public int? M3P170 => GetNullableInt("P170");

		/// <summary>
		/// Description: 175 Initial provisioning order
		/// FieldName: P175
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("175 Initial provisioning order")]
		public int? M3P175 => GetNullableInt("P175");

		/// <summary>
		/// Description: Update pre-allocation when qty chg
		/// FieldName: PTQC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update pre-allocation when qty chg")]
		public int? M3PTQC => GetNullableInt("PTQC");

		/// <summary>
		/// Description: 180 Project number check
		/// FieldName: P180
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("180 Project number check")]
		public int? M3P180 => GetNullableInt("P180");

		/// <summary>
		/// Description: 190 PO type check
		/// FieldName: P190
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("190 PO type check")]
		public int? M3P190 => GetNullableInt("P190");

		/// <summary>
		/// Description: 200 Should PO proposal get a warning if
		/// FieldName: P200
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("200 Should PO proposal get a warning if")]
		public int? M3P200 => GetNullableInt("P200");

		/// <summary>
		/// Description: 210 Maximum number of PO lines
		/// FieldName: P210
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("210 Maximum number of PO lines")]
		public int? M3P210 => GetNullableInt("P210");

		/// <summary>
		/// Description: 220 Update item file with purchase price
		/// FieldName: P220
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("220 Update item file with purchase price")]
		public int? M3P220 => GetNullableInt("P220");

		/// <summary>
		/// Description: 225 Retrieve price from last invoice
		/// FieldName: P225
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("225 Retrieve price from last invoice")]
		public int? M3P225 => GetNullableInt("P225");

		/// <summary>
		/// Description: 230 Pricing rule - phantom items
		/// FieldName: P230
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("230 Pricing rule - phantom items")]
		public int? M3P230 => GetNullableInt("P230");

		/// <summary>
		/// Description: 240 Price text
		/// FieldName: P240
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("240 Price text")]
		public int? M3P240 => GetNullableInt("P240");

		/// <summary>
		/// Description: 250 PO to agent
		/// FieldName: P250
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("250 PO to agent")]
		public int? M3P250 => GetNullableInt("P250");

		/// <summary>
		/// Description: 260 Revision check
		/// FieldName: P260
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("260 Revision check")]
		public int? M3P260 => GetNullableInt("P260");

		/// <summary>
		/// Description: 280 Purch costing calc on each line
		/// FieldName: P280
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("280 Purch costing calc on each line")]
		public int? M3P280 => GetNullableInt("P280");

		/// <summary>
		/// Description: 290 Usage of recipient field on PO line
		/// FieldName: P290
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("290 Usage of recipient field on PO line")]
		public int? M3P290 => GetNullableInt("P290");

		/// <summary>
		/// Description: 320 Representative price
		/// FieldName: P320
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("320 Representative price")]
		public int? M3P320 => GetNullableInt("P320");

		/// <summary>
		/// Description: 330 Check maximum service charge limit
		/// FieldName: P330
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("330 Check maximum service charge limit")]
		public int? M3P330 => GetNullableInt("P330");

		/// <summary>
		/// Description: 340 Multiple warehouses per PO
		/// FieldName: P340
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("340 Multiple warehouses per PO")]
		public int? M3P340 => GetNullableInt("P340");

		/// <summary>
		/// Description: 341 Multiple delivery addresses per PO
		/// FieldName: P341
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("341 Multiple delivery addresses per PO")]
		public int? M3P341 => GetNullableInt("P341");

		/// <summary>
		/// Description: 350 Consolidation fence - PO
		/// FieldName: P350
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("350 Consolidation fence - PO")]
		public int? M3P350 => GetNullableInt("P350");

		/// <summary>
		/// Description: 360 PO status -confirmed- after printing
		/// FieldName: P360
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("360 PO status -confirmed- after printing")]
		public int? M3P360 => GetNullableInt("P360");

		/// <summary>
		/// Description: 370 Warning - dely date within lead time
		/// FieldName: P370
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("370 Warning - dely date within lead time")]
		public int? M3P370 => GetNullableInt("P370");

		/// <summary>
		/// Description: 380 Inventory management
		/// FieldName: P380
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("380 Inventory management")]
		public int? M3P380 => GetNullableInt("P380");

		/// <summary>
		/// Description: 381 Default order type for repair order
		/// FieldName: P381
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("381 Default order type for repair order")]
		public string M3P381 => GetString("P381");

		/// <summary>
		/// Description: 390 EU labor code
		/// FieldName: P390
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("390 EU labor code")]
		public string M3P390 => GetString("P390");

		/// <summary>
		/// Description: 400 EU origin code trade transaction
		/// FieldName: P400
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("400 EU origin code trade transaction")]
		public string M3P400 => GetString("P400");

		/// <summary>
		/// Description: 510 Stop if excess delivery
		/// FieldName: P510
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("510 Stop if excess delivery")]
		public int? M3P510 => GetNullableInt("P510");

		/// <summary>
		/// Description: 520 get buyer from agreement
		/// FieldName: P520
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("520 get buyer from agreement")]
		public int? M3P520 => GetNullableInt("P520");

		/// <summary>
		/// Description: 530 PO transaction - order confirmation
		/// FieldName: P530
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("530 PO transaction - order confirmation")]
		public int? M3P530 => GetNullableInt("P530");

		/// <summary>
		/// Description: 531 PO transaction - shipment advice
		/// FieldName: P531
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("531 PO transaction - shipment advice")]
		public int? M3P531 => GetNullableInt("P531");

		/// <summary>
		/// Description: 532 PO transaction - transport notificat
		/// FieldName: P532
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("532 PO transaction - transport notificat")]
		public int? M3P532 => GetNullableInt("P532");

		/// <summary>
		/// Description: 540 Completion flag open - goods receipt
		/// FieldName: P540
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("540 Completion flag open - goods receipt")]
		public int? M3P540 => GetNullableInt("P540");

		/// <summary>
		/// Description: Packaging action
		/// FieldName: PCKA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging action")]
		public int? M3PCKA => GetNullableInt("PCKA");

		/// <summary>
		/// Description: 610 Invoice reporting
		/// FieldName: P610
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("610 Invoice reporting")]
		public int? M3P610 => GetNullableInt("P610");

		/// <summary>
		/// Description: 620 Auto display accounting string
		/// FieldName: P620
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("620 Auto display accounting string")]
		public int? M3P620 => GetNullableInt("P620");

		/// <summary>
		/// Description: 630 Invoicing permitted
		/// FieldName: P630
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("630 Invoicing permitted")]
		public int? M3P630 => GetNullableInt("P630");

		/// <summary>
		/// Description: 640 Manual update of due date
		/// FieldName: P640
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("640 Manual update of due date")]
		public int? M3P640 => GetNullableInt("P640");

		/// <summary>
		/// Description: 650 Partial payment permitted
		/// FieldName: P650
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("650 Partial payment permitted")]
		public int? M3P650 => GetNullableInt("P650");

		/// <summary>
		/// Description: 710 Automatic printout of PO documents.
		/// FieldName: P710
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("710 Automatic printout of PO documents.")]
		public int? M3P710 => GetNullableInt("P710");

		/// <summary>
		/// Description: 720 Supplier performance affected
		/// FieldName: P720
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("720 Supplier performance affected")]
		public int? M3P720 => GetNullableInt("P720");

		/// <summary>
		/// Description: 730 Automatic delivery note generation
		/// FieldName: P730
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("730 Automatic delivery note generation")]
		public int? M3P730 => GetNullableInt("P730");

		/// <summary>
		/// Description: 740 Vendor statistics update
		/// FieldName: P740
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("740 Vendor statistics update")]
		public int? M3P740 => GetNullableInt("P740");

		/// <summary>
		/// Description: Consolidation group
		/// FieldName: CGRP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidation group")]
		public string M3CGRP => GetString("CGRP");

		/// <summary>
		/// Description: Season control
		/// FieldName: SEAG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Season control")]
		public int? M3SEAG => GetNullableInt("SEAG");

		/// <summary>
		/// Description: Frozen requsted delivery date
		/// FieldName: P770
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frozen requsted delivery date")]
		public int? M3P770 => GetNullableInt("P770");
	}
}
// EOF
