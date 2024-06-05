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

namespace M3H5Lib.Api.ARS450MI
{
	public partial class GetBasicDataResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Bank account identity
		/// FieldName: BKID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3_BKID => GetString("BKID");

		/// <summary>
		/// Description: Bank account identity
		/// FieldName: BKI2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3_BKI2 => GetString("BKI2");

		/// <summary>
		/// Description: Agreement indicator
		/// FieldName: AGIN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement indicator")]
		public string M3_AGIN => GetString("AGIN");

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
		/// Description: Text
		/// FieldName: TX20
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TX20 => GetString("TX20");

		/// <summary>
		/// Description: Bank EDI agreement number
		/// FieldName: BKAG
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank EDI agreement number")]
		public string M3_BKAG => GetString("BKAG");

		/// <summary>
		/// Description: Valid from
		/// FieldName: VFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3_VFDT => GetNullableDateTime("VFDT");

		/// <summary>
		/// Description: Valid to
		/// FieldName: VTDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3_VTDT => GetNullableDateTime("VTDT");

		/// <summary>
		/// Description: Maximum invoice amount
		/// FieldName: MAXA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum invoice amount")]
		public decimal? M3_MAXA => GetNullableDecimal("MAXA");

		/// <summary>
		/// Description: Maximum total amount
		/// FieldName: MTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum total amount")]
		public decimal? M3_MTAM => GetNullableDecimal("MTAM");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3_CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Agreement 1
		/// FieldName: AGR1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 1")]
		public string M3_AGR1 => GetString("AGR1");

		/// <summary>
		/// Description: Agreement 2
		/// FieldName: AGR2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 2")]
		public string M3_AGR2 => GetString("AGR2");

		/// <summary>
		/// Description: Agreement 3
		/// FieldName: AGR3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 3")]
		public string M3_AGR3 => GetString("AGR3");

		/// <summary>
		/// Description: Agreement 4
		/// FieldName: AGR4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 4")]
		public string M3_AGR4 => GetString("AGR4");

		/// <summary>
		/// Description: Agreement 5
		/// FieldName: AGR5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 5")]
		public string M3_AGR5 => GetString("AGR5");

		/// <summary>
		/// Description: Agreement 6
		/// FieldName: AGR6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 6")]
		public string M3_AGR6 => GetString("AGR6");

		/// <summary>
		/// Description: Agreement 7
		/// FieldName: AGR7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 7")]
		public string M3_AGR7 => GetString("AGR7");

		/// <summary>
		/// Description: Transfer status
		/// FieldName: TSTA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer status")]
		public int? M3_TSTA => GetNullableInt("TSTA");

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
		/// Description: One time agreement
		/// FieldName: AGOT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("One time agreement")]
		public int? M3_AGOT => GetNullableInt("AGOT");

		/// <summary>
		/// Description: Last collection date
		/// FieldName: LCOL
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last collection date")]
		public DateTime? M3_LCOL => GetNullableDateTime("LCOL");

		/// <summary>
		/// Description: Last remittance proposal number
		/// FieldName: LRMN
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last remittance proposal number")]
		public int? M3_LRMN => GetNullableInt("LRMN");

		/// <summary>
		/// Description: Amended mandate
		/// FieldName: AMRC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amended mandate")]
		public string M3_AMRC => GetString("AMRC");

		/// <summary>
		/// Description: Reference agreement number
		/// FieldName: BRAG
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference agreement number")]
		public string M3_BRAG => GetString("BRAG");

		/// <summary>
		/// Description: Direct debit scheme
		/// FieldName: SDDS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Direct debit scheme")]
		public int? M3_SDDS => GetNullableInt("SDDS");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: SEPA DD frequency
		/// FieldName: SEFR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SEPA DD frequency")]
		public int? M3_SEFR => GetNullableInt("SEFR");

		/// <summary>
		/// Description: Last printout date
		/// FieldName: DODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last printout date")]
		public DateTime? M3_DODT => GetNullableDateTime("DODT");

		/// <summary>
		/// Description: Status
		/// FieldName: STCF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public int? M3_STCF => GetNullableInt("STCF");

		/// <summary>
		/// Description: Signature date
		/// FieldName: SIGD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Signature date")]
		public DateTime? M3_SIGD => GetNullableDateTime("SIGD");
	}
}
// EOF
