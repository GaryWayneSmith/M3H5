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
		public int? M3CONO => GetNullableInt("CONO");

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
		/// Description: Productnumber
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Productnumber")]
		public string M3PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Manufacturing order number
		/// FieldName: MWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3MWNO => GetString("MWNO");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Operation element number
		/// FieldName: ACTS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation element number")]
		public int? M3ACTS => GetNullableInt("ACTS");

		/// <summary>
		/// Description: InspectionID
		/// FieldName: INSI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("InspectionID")]
		public string M3INSI => GetString("INSI");

		/// <summary>
		/// Description: LineNumber
		/// FieldName: SPOS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("LineNumber")]
		public int? M3SPOS => GetNullableInt("SPOS");

		/// <summary>
		/// Description: SerialNumber
		/// FieldName: LNNR
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SerialNumber")]
		public int? M3LNNR => GetNullableInt("LNNR");

		/// <summary>
		/// Description: Expected value
		/// FieldName: EVAL
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected value")]
		public string M3EVAL => GetString("EVAL");

		/// <summary>
		/// Description: ReportedValue
		/// FieldName: RVAL
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ReportedValue")]
		public string M3RVAL => GetString("RVAL");

		/// <summary>
		/// Description: ReportingDate
		/// FieldName: RPDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ReportingDate")]
		public DateTime? M3RPDT => GetNullableDateTime("RPDT");

		/// <summary>
		/// Description: ResonsibleReporting
		/// FieldName: RPRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ResonsibleReporting")]
		public string M3RPRE => GetString("RPRE");

		/// <summary>
		/// Description: TransactionDate YMD8
		/// FieldName: TRDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TransactionDate YMD8")]
		public DateTime? M3TRDT => GetNullableDateTime("TRDT");

		/// <summary>
		/// Description: TransactionTime HHMMSS
		/// FieldName: TRTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TransactionTime HHMMSS")]
		public int? M3TRTM => GetNullableInt("TRTM");

		/// <summary>
		/// Description: ReportedUnitOfMeasure
		/// FieldName: RUOM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ReportedUnitOfMeasure")]
		public string M3RUOM => GetString("RUOM");

		/// <summary>
		/// Description: InspectionDescription
		/// FieldName: IITX
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("InspectionDescription")]
		public string M3IITX => GetString("IITX");

		/// <summary>
		/// Description: Equipment
		/// FieldName: EQNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment")]
		public string M3EQNO => GetString("EQNO");

		/// <summary>
		/// Description: EquipmentDescription
		/// FieldName: ALII
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EquipmentDescription")]
		public string M3ALII => GetString("ALII");

		/// <summary>
		/// Description: ConfigPosition
		/// FieldName: CFGL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ConfigPosition")]
		public string M3CFGL => GetString("CFGL");

		/// <summary>
		/// Description: ConfigPositionDescription
		/// FieldName: CFTX
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ConfigPositionDescription")]
		public string M3CFTX => GetString("CFTX");

		/// <summary>
		/// Description: OperatorFromRange
		/// FieldName: OPE1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorFromRange")]
		public string M3OPE1 => GetString("OPE1");

		/// <summary>
		/// Description: FromRange
		/// FieldName: RBFR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FromRange")]
		public string M3RBFR => GetString("RBFR");

		/// <summary>
		/// Description: OperatorToRange
		/// FieldName: OPE2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorToRange")]
		public string M3OPE2 => GetString("OPE2");

		/// <summary>
		/// Description: ToRange
		/// FieldName: RBTO
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ToRange")]
		public string M3RBTO => GetString("RBTO");

		/// <summary>
		/// Description: OperatorFromExternalLimit
		/// FieldName: OPE3
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorFromExternalLimit")]
		public string M3OPE3 => GetString("OPE3");

		/// <summary>
		/// Description: FromExternalLimit
		/// FieldName: EAFR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FromExternalLimit")]
		public string M3EAFR => GetString("EAFR");

		/// <summary>
		/// Description: OperatorToExternalLimit
		/// FieldName: OPE4
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorToExternalLimit")]
		public string M3OPE4 => GetString("OPE4");

		/// <summary>
		/// Description: ToExternalLimit
		/// FieldName: EATO
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ToExternalLimit")]
		public string M3EATO => GetString("EATO");

		/// <summary>
		/// Description: OperatorFromAlarmLimit
		/// FieldName: OPE5
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorFromAlarmLimit")]
		public string M3OPE5 => GetString("OPE5");

		/// <summary>
		/// Description: AlarmFromLimit
		/// FieldName: AAFR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("AlarmFromLimit")]
		public string M3AAFR => GetString("AAFR");

		/// <summary>
		/// Description: OperatorToAlarmLimit
		/// FieldName: OPE6
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorToAlarmLimit")]
		public string M3OPE6 => GetString("OPE6");

		/// <summary>
		/// Description: AlarmToLimit
		/// FieldName: AATO
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("AlarmToLimit")]
		public string M3AATO => GetString("AATO");

		/// <summary>
		/// Description: OperatorTrendLimit
		/// FieldName: OPE7
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperatorTrendLimit")]
		public string M3OPE7 => GetString("OPE7");

		/// <summary>
		/// Description: TrendLimit
		/// FieldName: AATR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TrendLimit")]
		public string M3AATR => GetString("AATR");

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
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3BANO => GetString("BANO");

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
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Start time
		/// FieldName: MSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time")]
		public int? M3MSTI => GetNullableInt("MSTI");

		/// <summary>
		/// Description: Finish date
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish date")]
		public DateTime? M3FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Finish time
		/// FieldName: MFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish time")]
		public int? M3MFTI => GetNullableInt("MFTI");

		/// <summary>
		/// Description: Remark
		/// FieldName: REMK
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3REMK => GetString("REMK");

		/// <summary>
		/// Description: OperationElementDescription
		/// FieldName: ACDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OperationElementDescription")]
		public string M3ACDS => GetString("ACDS");

		/// <summary>
		/// Description: Operation description
		/// FieldName: OPDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation description")]
		public string M3OPDS => GetString("OPDS");

		/// <summary>
		/// Description: Text Identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Result identity
		/// FieldName: RSIY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result identity")]
		public string M3RSIY => GetString("RSIY");
	}
}
// EOF
