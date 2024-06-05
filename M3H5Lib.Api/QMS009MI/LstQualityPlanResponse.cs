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

namespace M3H5Lib.Api.QMS009MI
{
	public partial class LstQualityPlanResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Quality plan
		/// FieldName: QLPN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quality plan")]
		public string M3_QLPN => GetString("QLPN");

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
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Active
		/// FieldName: ACTF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active")]
		public int? M3_ACTF => GetNullableInt("ACTF");

		/// <summary>
		/// Description: Changing QI request
		/// FieldName: QIMD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changing QI request")]
		public int? M3_QIMD => GetNullableInt("QIMD");

		/// <summary>
		/// Description: Adding test to QI req
		/// FieldName: QIAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adding test to QI req")]
		public int? M3_QIAT => GetNullableInt("QIAT");

		/// <summary>
		/// Description: Spec approval basis
		/// FieldName: QPLN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Spec approval basis")]
		public int? M3_QPLN => GetNullableInt("QPLN");

		/// <summary>
		/// Description: QI req appr basis
		/// FieldName: QPLT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("QI req appr basis")]
		public int? M3_QPLT => GetNullableInt("QPLT");

		/// <summary>
		/// Description: Approval passed/passed
		/// FieldName: QAPP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval passed/passed")]
		public int? M3_QAPP => GetNullableInt("QAPP");

		/// <summary>
		/// Description: Approval passed/failed
		/// FieldName: QAPF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval passed/failed")]
		public int? M3_QAPF => GetNullableInt("QAPF");

		/// <summary>
		/// Description: Approval passed/not tested
		/// FieldName: QAPN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval passed/not tested")]
		public int? M3_QAPN => GetNullableInt("QAPN");

		/// <summary>
		/// Description: Approval passed/none
		/// FieldName: QAPE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval passed/none")]
		public int? M3_QAPE => GetNullableInt("QAPE");

		/// <summary>
		/// Description: Approval failed/passed
		/// FieldName: QAFP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval failed/passed")]
		public int? M3_QAFP => GetNullableInt("QAFP");

		/// <summary>
		/// Description: Approval failed/failed
		/// FieldName: QAFF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval failed/failed")]
		public int? M3_QAFF => GetNullableInt("QAFF");

		/// <summary>
		/// Description: Approval failed/not tested
		/// FieldName: QAFN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval failed/not tested")]
		public int? M3_QAFN => GetNullableInt("QAFN");

		/// <summary>
		/// Description: Approval failed/none
		/// FieldName: QAFE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval failed/none")]
		public int? M3_QAFE => GetNullableInt("QAFE");

		/// <summary>
		/// Description: Approval not tested/passed
		/// FieldName: QANP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval not tested/passed")]
		public int? M3_QANP => GetNullableInt("QANP");

		/// <summary>
		/// Description: Approval not tested/failed
		/// FieldName: QANF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval not tested/failed")]
		public int? M3_QANF => GetNullableInt("QANF");

		/// <summary>
		/// Description: Approval not tested/not tested
		/// FieldName: QANN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval not tested/not tested")]
		public int? M3_QANN => GetNullableInt("QANN");

		/// <summary>
		/// Description: Approval not tested/none
		/// FieldName: QANE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval not tested/none")]
		public int? M3_QANE => GetNullableInt("QANE");

		/// <summary>
		/// Description: Approval none/passed
		/// FieldName: QAEP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval none/passed")]
		public int? M3_QAEP => GetNullableInt("QAEP");

		/// <summary>
		/// Description: Approval none/failed
		/// FieldName: QAEF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval none/failed")]
		public int? M3_QAEF => GetNullableInt("QAEF");

		/// <summary>
		/// Description: Approval none/not tested
		/// FieldName: QAEN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval none/not tested")]
		public int? M3_QAEN => GetNullableInt("QAEN");

		/// <summary>
		/// Description: Lot auto-approval
		/// FieldName: QLTA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot auto-approval")]
		public int? M3_QLTA => GetNullableInt("QLTA");

		/// <summary>
		/// Description: Spec auto-approval
		/// FieldName: QSPA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Spec auto-approval")]
		public int? M3_QSPA => GetNullableInt("QSPA");

		/// <summary>
		/// Description: QI request auto-approval
		/// FieldName: QIRA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("QI request auto-approval")]
		public int? M3_QIRA => GetNullableInt("QIRA");

		/// <summary>
		/// Description: QI request level
		/// FieldName: QRLV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("QI request level")]
		public int? M3_QRLV => GetNullableInt("QRLV");

		/// <summary>
		/// Description: Max quantity per QI req
		/// FieldName: QMQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max quantity per QI req")]
		public decimal? M3_QMQT => GetNullableDecimal("QMQT");

		/// <summary>
		/// Description: Maximum quantity per QI req U/M
		/// FieldName: QMUM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum quantity per QI req U/M")]
		public string M3_QMUM => GetString("QMUM");

		/// <summary>
		/// Description: Manual QI req status
		/// FieldName: QST1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual QI req status")]
		public int? M3_QST1 => GetNullableInt("QST1");

		/// <summary>
		/// Description: Default QI req as test at pre-ship
		/// FieldName: TPS2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default QI req as test at pre-ship")]
		public int? M3_TPS2 => GetNullableInt("TPS2");

		/// <summary>
		/// Description: Test freq basis for PO
		/// FieldName: QIFR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test freq basis for PO")]
		public int? M3_QIFR => GetNullableInt("QIFR");

		/// <summary>
		/// Description: Replace PO QI request
		/// FieldName: QIRP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Replace PO QI request")]
		public int? M3_QIRP => GetNullableInt("QIRP");

		/// <summary>
		/// Description: Test freq basis for MO
		/// FieldName: QIF1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test freq basis for MO")]
		public int? M3_QIF1 => GetNullableInt("QIF1");

		/// <summary>
		/// Description: Replace MO QI request
		/// FieldName: QIPF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Replace MO QI request")]
		public int? M3_QIPF => GetNullableInt("QIPF");

		/// <summary>
		/// Description: Create QI request on CO returns
		/// FieldName: QCRF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Create QI request on CO returns")]
		public int? M3_QCRF => GetNullableInt("QCRF");

		/// <summary>
		/// Description: Copy QI request on new lot
		/// FieldName: QCRO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Copy QI request on new lot")]
		public int? M3_QCRO => GetNullableInt("QCRO");

		/// <summary>
		/// Description: Auto-reinspection of lots
		/// FieldName: QARE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Auto-reinspection of lots")]
		public int? M3_QARE => GetNullableInt("QARE");

		/// <summary>
		/// Description: QI reinspection level
		/// FieldName: QARL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("QI reinspection level")]
		public int? M3_QARL => GetNullableInt("QARL");

		/// <summary>
		/// Description: Reinspection generation basis
		/// FieldName: QARB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinspection generation basis")]
		public int? M3_QARB => GetNullableInt("QARB");

		/// <summary>
		/// Description: Reinspection calculation date
		/// FieldName: QARD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinspection calculation date")]
		public int? M3_QARD => GetNullableInt("QARD");
	}
}
// EOF
