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

namespace M3H5Lib.Api.MOS085MI
{
	public partial class LstInspResponse : M3BaseRecord 
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
		/// Description: Productnumber
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Productnumber")]
		public string M3_PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Manufacturing order number
		/// FieldName: MWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3_MWNO => GetString("MWNO");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3_OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Operation element number
		/// FieldName: ACTS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation element number")]
		public int? M3_ACTS => GetNullableInt("ACTS");

		/// <summary>
		/// Description: InspectionID
		/// FieldName: INSI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("InspectionID")]
		public string M3_INSI => GetString("INSI");

		/// <summary>
		/// Description: LineNumber
		/// FieldName: SPOS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("LineNumber")]
		public int? M3_SPOS => GetNullableInt("SPOS");

		/// <summary>
		/// Description: SerialNumber
		/// FieldName: LNNR
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SerialNumber")]
		public int? M3_LNNR => GetNullableInt("LNNR");

		/// <summary>
		/// Description: Expected value
		/// FieldName: EVAL
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected value")]
		public string M3_EVAL => GetString("EVAL");

		/// <summary>
		/// Description: ReportedValue
		/// FieldName: RVAL
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ReportedValue")]
		public string M3_RVAL => GetString("RVAL");

		/// <summary>
		/// Description: ReportingDate
		/// FieldName: RPDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ReportingDate")]
		public DateTime? M3_RPDT => GetNullableDateTime("RPDT");

		/// <summary>
		/// Description: ResonsibleReporting
		/// FieldName: RPRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ResonsibleReporting")]
		public string M3_RPRE => GetString("RPRE");

		/// <summary>
		/// Description: TransactionDate YMD8
		/// FieldName: TRDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TransactionDate YMD8")]
		public DateTime? M3_TRDT => GetNullableDateTime("TRDT");

		/// <summary>
		/// Description: TransactionTime HHMMSS
		/// FieldName: TRTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TransactionTime HHMMSS")]
		public int? M3_TRTM => GetNullableInt("TRTM");

		/// <summary>
		/// Description: ReportedUnitOfMeasure
		/// FieldName: RUOM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ReportedUnitOfMeasure")]
		public string M3_RUOM => GetString("RUOM");

		/// <summary>
		/// Description: InspectionDescription
		/// FieldName: IITX
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("InspectionDescription")]
		public string M3_IITX => GetString("IITX");

		/// <summary>
		/// Description: Equipment
		/// FieldName: EQNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment")]
		public string M3_EQNO => GetString("EQNO");

		/// <summary>
		/// Description: EquipmentDescription
		/// FieldName: ALII
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EquipmentDescription")]
		public string M3_ALII => GetString("ALII");

		/// <summary>
		/// Description: ConfigPosition
		/// FieldName: CFGL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ConfigPosition")]
		public string M3_CFGL => GetString("CFGL");

		/// <summary>
		/// Description: ConfigPositionDescription
		/// FieldName: CFTX
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ConfigPositionDescription")]
		public string M3_CFTX => GetString("CFTX");

		/// <summary>
		/// Description: OperatorFromRange
		/// FieldName: OPE1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorFromRange")]
		public string M3_OPE1 => GetString("OPE1");

		/// <summary>
		/// Description: FromRange
		/// FieldName: RBFR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FromRange")]
		public string M3_RBFR => GetString("RBFR");

		/// <summary>
		/// Description: OperatorToRange
		/// FieldName: OPE2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorToRange")]
		public string M3_OPE2 => GetString("OPE2");

		/// <summary>
		/// Description: ToRange
		/// FieldName: RBTO
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ToRange")]
		public string M3_RBTO => GetString("RBTO");

		/// <summary>
		/// Description: OperatorFromExternalLimit
		/// FieldName: OPE3
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorFromExternalLimit")]
		public string M3_OPE3 => GetString("OPE3");

		/// <summary>
		/// Description: FromExternalLimit
		/// FieldName: EAFR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FromExternalLimit")]
		public string M3_EAFR => GetString("EAFR");

		/// <summary>
		/// Description: OperatorToExternalLimit
		/// FieldName: OPE4
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorToExternalLimit")]
		public string M3_OPE4 => GetString("OPE4");

		/// <summary>
		/// Description: ToExternalLimit
		/// FieldName: EATO
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ToExternalLimit")]
		public string M3_EATO => GetString("EATO");

		/// <summary>
		/// Description: OperatorFromAlarmLimit
		/// FieldName: OPE5
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorFromAlarmLimit")]
		public string M3_OPE5 => GetString("OPE5");

		/// <summary>
		/// Description: AlarmFromLimit
		/// FieldName: AAFR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("AlarmFromLimit")]
		public string M3_AAFR => GetString("AAFR");

		/// <summary>
		/// Description: OperatorToAlarmLimit
		/// FieldName: OPE6
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorToAlarmLimit")]
		public string M3_OPE6 => GetString("OPE6");

		/// <summary>
		/// Description: AlarmToLimit
		/// FieldName: AATO
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("AlarmToLimit")]
		public string M3_AATO => GetString("AATO");

		/// <summary>
		/// Description: OperatorTrendLimit
		/// FieldName: OPE7
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorTrendLimit")]
		public string M3_OPE7 => GetString("OPE7");

		/// <summary>
		/// Description: TrendLimit
		/// FieldName: AATR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TrendLimit")]
		public string M3_AATR => GetString("AATR");

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
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3_BANO => GetString("BANO");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3_STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Start time
		/// FieldName: MSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time")]
		public int? M3_MSTI => GetNullableInt("MSTI");

		/// <summary>
		/// Description: Finish date
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish date")]
		public DateTime? M3_FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Finish time
		/// FieldName: MFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish time")]
		public int? M3_MFTI => GetNullableInt("MFTI");

		/// <summary>
		/// Description: Remark
		/// FieldName: REMK
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3_REMK => GetString("REMK");

		/// <summary>
		/// Description: OperationElementDescription
		/// FieldName: ACDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperationElementDescription")]
		public string M3_ACDS => GetString("ACDS");

		/// <summary>
		/// Description: Operation description
		/// FieldName: OPDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation description")]
		public string M3_OPDS => GetString("OPDS");

		/// <summary>
		/// Description: Text Identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Result identity
		/// FieldName: RSIY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result identity")]
		public string M3_RSIY => GetString("RSIY");
	}
}
// EOF
