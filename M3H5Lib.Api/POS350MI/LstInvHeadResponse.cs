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

namespace M3H5Lib.Api.POS350MI
{
	public partial class LstInvHeadResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Invoice number
		/// FieldName: IVNO
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public int? M3IVNO => GetNullableInt("IVNO");

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
		/// Description: Due date
		/// FieldName: DUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3DUDT => GetNullableDateTime("DUDT");

		/// <summary>
		/// Description: Invoice date
		/// FieldName: IDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3IDAT => GetNullableDateTime("IDAT");

		/// <summary>
		/// Description: Facility
		/// FieldName: FAC2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FAC2 => GetString("FAC2");

		/// <summary>
		/// Description: Remaining amount to pay - foreign curr
		/// FieldName: RAFC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining amount to pay - foreign curr")]
		public decimal? M3RAFC => GetNullableDecimal("RAFC");

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
		/// Description: Status - invoice
		/// FieldName: INST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - invoice")]
		public string M3INST => GetString("INST");

		/// <summary>
		/// Description: Name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Ref field for amount
		/// FieldName: AMT1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for amount")]
		public decimal? M3AMT1 => GetNullableDecimal("AMT1");

		/// <summary>
		/// Description: Currency code 1
		/// FieldName: CUC1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency code 1")]
		public string M3CUC1 => GetString("CUC1");

		/// <summary>
		/// Description: Ref field for amount
		/// FieldName: AMT2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for amount")]
		public decimal? M3AMT2 => GetNullableDecimal("AMT2");

		/// <summary>
		/// Description: Currency code 2
		/// FieldName: CUC2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency code 2")]
		public string M3CUC2 => GetString("CUC2");

		/// <summary>
		/// Description: Invoice rate
		/// FieldName: RAIN
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice rate")]
		public decimal? M3RAIN => GetNullableDecimal("RAIN");

		/// <summary>
		/// Description: Update bonus/commission agreements
		/// FieldName: UPBC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update bonus/commission agreements")]
		public int? M3UPBC => GetNullableInt("UPBC");

		/// <summary>
		/// Description: Update EU sales
		/// FieldName: UPEC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update EU sales")]
		public int? M3UPEC => GetNullableInt("UPEC");

		/// <summary>
		/// Description: Update account entry
		/// FieldName: UPAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update account entry")]
		public int? M3UPAC => GetNullableInt("UPAC");

		/// <summary>
		/// Description: Cash desk sales
		/// FieldName: CASH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash desk sales")]
		public int? M3CASH => GetNullableInt("CASH");

		/// <summary>
		/// Description: Invoice prefix
		/// FieldName: INPX
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice prefix")]
		public string M3INPX => GetString("INPX");

		/// <summary>
		/// Description: Extended invoice number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended invoice number")]
		public string M3EXIN => GetString("EXIN");

		/// <summary>
		/// Description: Reference - extended invoice number
		/// FieldName: RXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference - extended invoice number")]
		public string M3RXIN => GetString("RXIN");

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
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");
	}
}
// EOF
