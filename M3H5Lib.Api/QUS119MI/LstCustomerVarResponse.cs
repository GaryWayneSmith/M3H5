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

namespace M3H5Lib.Api.QUS119MI
{
	public partial class LstCustomerVarResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Product
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product")]
		public string M3_PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3_CUNO => GetString("CUNO");

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
		/// Description: Hours used
		/// FieldName: USTI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hours used")]
		public int? M3_USTI => GetNullableInt("USTI");

		/// <summary>
		/// Description: Hourly price
		/// FieldName: SPHO
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hourly price")]
		public decimal? M3_SPHO => GetNullableDecimal("SPHO");

		/// <summary>
		/// Description: Hourly cost
		/// FieldName: CPHO
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hourly cost")]
		public decimal? M3_CPHO => GetNullableDecimal("CPHO");

		/// <summary>
		/// Description: Price in labor currency
		/// FieldName: ADF1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in labor currency")]
		public decimal? M3_ADF1 => GetNullableDecimal("ADF1");

		/// <summary>
		/// Description: Price in material currency
		/// FieldName: ADF2
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in material currency")]
		public decimal? M3_ADF2 => GetNullableDecimal("ADF2");

		/// <summary>
		/// Description: Price in subcontracting currency
		/// FieldName: ADF3
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in subcontracting currency")]
		public decimal? M3_ADF3 => GetNullableDecimal("ADF3");

		/// <summary>
		/// Description: Price in miscellaneous currency
		/// FieldName: ADF4
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in miscellaneous currency")]
		public decimal? M3_ADF4 => GetNullableDecimal("ADF4");

		/// <summary>
		/// Description: Cost in labor currency
		/// FieldName: CDF1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost in labor currency")]
		public decimal? M3_CDF1 => GetNullableDecimal("CDF1");

		/// <summary>
		/// Description: Cost in material currency
		/// FieldName: CDF2
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost in material currency")]
		public decimal? M3_CDF2 => GetNullableDecimal("CDF2");

		/// <summary>
		/// Description: Cost in subcontracting currency
		/// FieldName: CDF3
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost in subcontracting currency")]
		public decimal? M3_CDF3 => GetNullableDecimal("CDF3");

		/// <summary>
		/// Description: Cost in miscellaneous currency
		/// FieldName: CDF4
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost in miscellaneous currency")]
		public decimal? M3_CDF4 => GetNullableDecimal("CDF4");

		/// <summary>
		/// Description: OEM code
		/// FieldName: SMC0
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM code")]
		public string M3_SMC0 => GetString("SMC0");

		/// <summary>
		/// Description: OEM code
		/// FieldName: SMC1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM code")]
		public string M3_SMC1 => GetString("SMC1");

		/// <summary>
		/// Description: OEM code
		/// FieldName: SMC2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM code")]
		public string M3_SMC2 => GetString("SMC2");

		/// <summary>
		/// Description: OEM code
		/// FieldName: SMC3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM code")]
		public string M3_SMC3 => GetString("SMC3");

		/// <summary>
		/// Description: OEM code
		/// FieldName: SMC4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM code")]
		public string M3_SMC4 => GetString("SMC4");

		/// <summary>
		/// Description: OEM code
		/// FieldName: SMC5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM code")]
		public string M3_SMC5 => GetString("SMC5");

		/// <summary>
		/// Description: OEM code
		/// FieldName: SMC6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM code")]
		public string M3_SMC6 => GetString("SMC6");

		/// <summary>
		/// Description: OEM code
		/// FieldName: SMC7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM code")]
		public string M3_SMC7 => GetString("SMC7");

		/// <summary>
		/// Description: OEM code
		/// FieldName: SMC8
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM code")]
		public string M3_SMC8 => GetString("SMC8");

		/// <summary>
		/// Description: OEM code
		/// FieldName: SMC9
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("OEM code")]
		public string M3_SMC9 => GetString("SMC9");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3_SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3_STRT => GetString("STRT");

		/// <summary>
		/// Description: Create service
		/// FieldName: CRSE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Create service")]
		public int? M3_CRSE => GetNullableInt("CRSE");

		/// <summary>
		/// Description: Service
		/// FieldName: RSUF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3_RSUF => GetString("RSUF");

		/// <summary>
		/// Description: Agreement
		/// FieldName: AAGN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement")]
		public string M3_AAGN => GetString("AAGN");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3_RESP => GetString("RESP");

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
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");
	}
}
// EOF
