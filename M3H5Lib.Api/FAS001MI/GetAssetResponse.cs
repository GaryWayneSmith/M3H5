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

namespace M3H5Lib.Api.FAS001MI
{
	public partial class GetAssetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Fixed asset
		/// FieldName: ASID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset")]
		public string M3ASID => GetString("ASID");

		/// <summary>
		/// Description: Status - fixed asset
		/// FieldName: FAST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - fixed asset")]
		public int? M3FAST => GetNullableInt("FAST");

		/// <summary>
		/// Description: Name
		/// FieldName: FADS
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3FADS => GetString("FADS");

		/// <summary>
		/// Description: Text line 1
		/// FieldName: TXT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 1")]
		public string M3TXT1 => GetString("TXT1");

		/// <summary>
		/// Description: Text line 2
		/// FieldName: TXT2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 2")]
		public string M3TXT2 => GetString("TXT2");

		/// <summary>
		/// Description: Fixed asset type
		/// FieldName: FATP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset type")]
		public string M3FATP => GetString("FATP");

		/// <summary>
		/// Description: Fixed asset group
		/// FieldName: ACAT
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset group")]
		public string M3ACAT => GetString("ACAT");

		/// <summary>
		/// Description: Location type 1
		/// FieldName: LOC1
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location type 1")]
		public string M3LOC1 => GetString("LOC1");

		/// <summary>
		/// Description: Location type 2
		/// FieldName: LOC2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location type 2")]
		public string M3LOC2 => GetString("LOC2");

		/// <summary>
		/// Description: Location type 3
		/// FieldName: LOC3
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location type 3")]
		public string M3LOC3 => GetString("LOC3");

		/// <summary>
		/// Description: Serial number
		/// FieldName: SRNO
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SRNO => GetString("SRNO");

		/// <summary>
		/// Description: GUI picture
		/// FieldName: PINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("GUI picture")]
		public string M3PINO => GetString("PINO");

		/// <summary>
		/// Description: Warranty date
		/// FieldName: WADT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty date")]
		public DateTime? M3WADT => GetNullableDateTime("WADT");

		/// <summary>
		/// Description: Service agreement
		/// FieldName: SECN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service agreement")]
		public string M3SECN => GetString("SECN");

		/// <summary>
		/// Description: Service company
		/// FieldName: SECS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service company")]
		public string M3SECS => GetString("SECS");

		/// <summary>
		/// Description: Leasing agreement
		/// FieldName: LCNO
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Leasing agreement")]
		public string M3LCNO => GetString("LCNO");

		/// <summary>
		/// Description: Leasing company
		/// FieldName: LCCO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Leasing company")]
		public string M3LCCO => GetString("LCCO");

		/// <summary>
		/// Description: Manufacturing date
		/// FieldName: MPER
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing date")]
		public DateTime? M3MPER => GetNullableDateTime("MPER");

		/// <summary>
		/// Description: Activation date
		/// FieldName: APER
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Activation date")]
		public DateTime? M3APER => GetNullableDateTime("APER");

		/// <summary>
		/// Description: Building permit date
		/// FieldName: BPER
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Building permit date")]
		public DateTime? M3BPER => GetNullableDateTime("BPER");

		/// <summary>
		/// Description: Payee
		/// FieldName: SPYN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payee")]
		public string M3SPYN => GetString("SPYN");

		/// <summary>
		/// Description: Voucher number series
		/// FieldName: VSER
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number series")]
		public string M3VSER => GetString("VSER");

		/// <summary>
		/// Description: Voucher number
		/// FieldName: VONO
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number")]
		public int? M3VONO => GetNullableInt("VONO");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Exchange rate
		/// FieldName: ARAT
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate")]
		public decimal? M3ARAT => GetNullableDecimal("ARAT");

		/// <summary>
		/// Description: Acquisition date
		/// FieldName: PPER
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acquisition date")]
		public DateTime? M3PPER => GetNullableDateTime("PPER");

		/// <summary>
		/// Description: Cost of capital method
		/// FieldName: CCCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost of capital method")]
		public string M3CCCO => GetString("CCCO");

		/// <summary>
		/// Description: Accounting dimension 2
		/// FieldName: AIT2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 2")]
		public string M3AIT2 => GetString("AIT2");

		/// <summary>
		/// Description: Accounting dimension 3
		/// FieldName: AIT3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 3")]
		public string M3AIT3 => GetString("AIT3");

		/// <summary>
		/// Description: Accounting dimension 4
		/// FieldName: AIT4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 4")]
		public string M3AIT4 => GetString("AIT4");

		/// <summary>
		/// Description: Accounting dimension 5
		/// FieldName: AIT5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 5")]
		public string M3AIT5 => GetString("AIT5");

		/// <summary>
		/// Description: Accounting dimension 6
		/// FieldName: AIT6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 6")]
		public string M3AIT6 => GetString("AIT6");

		/// <summary>
		/// Description: Accounting dimension 7
		/// FieldName: AIT7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 7")]
		public string M3AIT7 => GetString("AIT7");

		/// <summary>
		/// Description: Planning area
		/// FieldName: REAR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning area")]
		public string M3REAR => GetString("REAR");

		/// <summary>
		/// Description: Last physical inventory date
		/// FieldName: PCDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last physical inventory date")]
		public DateTime? M3PCDA => GetNullableDateTime("PCDA");

		/// <summary>
		/// Description: Physical inventory number
		/// FieldName: PHCN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical inventory number")]
		public long? M3PHCN => GetNullableLong("PHCN");

		/// <summary>
		/// Description: Physical inventory run number
		/// FieldName: PHSN
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical inventory run number")]
		public int? M3PHSN => GetNullableInt("PHSN");

		/// <summary>
		/// Description: Physical inventory text
		/// FieldName: PHCT
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical inventory text")]
		public string M3PHCT => GetString("PHCT");

		/// <summary>
		/// Description: Physical inventory code
		/// FieldName: PHCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical inventory code")]
		public int? M3PHCD => GetNullableInt("PHCD");

		/// <summary>
		/// Description: Sales date
		/// FieldName: SPER
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales date")]
		public DateTime? M3SPER => GetNullableDateTime("SPER");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3PYNO => GetString("PYNO");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: CINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public string M3CINO => GetString("CINO");

		/// <summary>
		/// Description: Currency
		/// FieldName: SCUC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3SCUC => GetString("SCUC");

		/// <summary>
		/// Description: Exchange rate
		/// FieldName: SRAT
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate")]
		public decimal? M3SRAT => GetNullableDecimal("SRAT");

		/// <summary>
		/// Description: Individual item number
		/// FieldName: INNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item number")]
		public string M3INNO => GetString("INNO");

		/// <summary>
		/// Description: User-defined field 1 - fixed asset
		/// FieldName: FRF1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - fixed asset")]
		public string M3FRF1 => GetString("FRF1");

		/// <summary>
		/// Description: User-defined field 2 - fixed asset
		/// FieldName: FRF2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - fixed asset")]
		public string M3FRF2 => GetString("FRF2");

		/// <summary>
		/// Description: User-defined field 3 - fixed asset
		/// FieldName: FRF3
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - fixed asset")]
		public string M3FRF3 => GetString("FRF3");

		/// <summary>
		/// Description: User-defined field 4 - fixed asset
		/// FieldName: FRF4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - fixed asset")]
		public string M3FRF4 => GetString("FRF4");

		/// <summary>
		/// Description: User-defined field 5 - fixed asset
		/// FieldName: FRF5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - fixed asset")]
		public string M3FRF5 => GetString("FRF5");

		/// <summary>
		/// Description: Quantity  - fixed asset
		/// FieldName: FAQT
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity  - fixed asset")]
		public decimal? M3FAQT => GetNullableDecimal("FAQT");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

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
		/// Description: Last revaluation date
		/// FieldName: LRVD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last revaluation date")]
		public DateTime? M3LRVD => GetNullableDateTime("LRVD");

		/// <summary>
		/// Description: Origin identity
		/// FieldName: BIRT
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Origin identity")]
		public long? M3BIRT => GetNullableLong("BIRT");

		/// <summary>
		/// Description: Receipt date
		/// FieldName: REDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt date")]
		public DateTime? M3REDA => GetNullableDateTime("REDA");

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
		/// Description: Equipment group
		/// FieldName: EQGR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment group")]
		public string M3EQGR => GetString("EQGR");

		/// <summary>
		/// Description: Geographic cod X
		/// FieldName: GEOX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic cod X")]
		public decimal? M3GEOX => GetNullableDecimal("GEOX");

		/// <summary>
		/// Description: Geographic code Y
		/// FieldName: GEOY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic code Y")]
		public decimal? M3GEOY => GetNullableDecimal("GEOY");

		/// <summary>
		/// Description: Geographic cod  Z
		/// FieldName: GEOZ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic cod  Z")]
		public decimal? M3GEOZ => GetNullableDecimal("GEOZ");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3LMTS => GetNullableDecimal("LMTS");
	}
}
// EOF
