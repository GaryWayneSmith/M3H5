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

namespace M3H5Lib.Api.TXS910MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Approval number
		/// FieldName: TIAN
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval number")]
		public string M3TIAN => GetString("TIAN");

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3VRNO => GetString("VRNO");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: TIVN
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3TIVN => GetString("TIVN");

		/// <summary>
		/// Description: File name
		/// FieldName: TIFN
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File name")]
		public string M3TIFN => GetString("TIFN");

		/// <summary>
		/// Description: Supplier contact person
		/// FieldName: TICP
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier contact person")]
		public string M3TICP => GetString("TICP");

		/// <summary>
		/// Description: Address
		/// FieldName: TIAD
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address")]
		public string M3TIAD => GetString("TIAD");

		/// <summary>
		/// Description: Email
		/// FieldName: TIEM
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Email")]
		public string M3TIEM => GetString("TIEM");

		/// <summary>
		/// Description: Creation date for tax invoice
		/// FieldName: TICR
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Creation date for tax invoice")]
		public DateTime? M3TICR => GetNullableDateTime("TICR");

		/// <summary>
		/// Description: Issue date
		/// FieldName: TIID
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue date")]
		public DateTime? M3TIID => GetNullableDateTime("TIID");

		/// <summary>
		/// Description: Gross amount
		/// FieldName: GAMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross amount")]
		public decimal? M3GAMT => GetNullableDecimal("GAMT");

		/// <summary>
		/// Description: VAT
		/// FieldName: VTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT")]
		public decimal? M3VTAM => GetNullableDecimal("VTAM");

		/// <summary>
		/// Description: Net amount
		/// FieldName: NAMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net amount")]
		public decimal? M3NAMT => GetNullableDecimal("NAMT");

		/// <summary>
		/// Description: Type of tax invoice
		/// FieldName: TIT1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of tax invoice")]
		public string M3TIT1 => GetString("TIT1");

		/// <summary>
		/// Description: Type of tax invoice 2
		/// FieldName: TIT2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of tax invoice 2")]
		public string M3TIT2 => GetString("TIT2");

		/// <summary>
		/// Description: Unpaid/paid
		/// FieldName: TIRR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unpaid/paid")]
		public string M3TIRR => GetString("TIRR");

		/// <summary>
		/// Description: Status
		/// FieldName: TISA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public int? M3TISA => GetNullableInt("TISA");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3YEA4 => GetNullableInt("YEA4");

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
		/// Description: Supplier invoice number
		/// FieldName: SINO
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier invoice number")]
		public string M3SINO => GetString("SINO");

		/// <summary>
		/// Description: Status: 0=Not in progress, 1=In progress
		/// FieldName: TIIP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status: 0=Not in progress, 1=In progress")]
		public int? M3TIIP => GetNullableInt("TIIP");

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
