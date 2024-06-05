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

namespace M3H5Lib.Api.ABS100MI
{
	public partial class GetBankIdentResponse : M3BaseRecord 
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
		/// Description: Bank identifier
		/// FieldName: BSID
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank identifier")]
		public string M3_BSID => GetString("BSID");

		/// <summary>
		/// Description: Bank account id
		/// FieldName: BKID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account id")]
		public string M3_BKID => GetString("BKID");

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
		/// Description: FAM function
		/// FieldName: FNCN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function")]
		public int? M3_FNCN => GetNullableInt("FNCN");

		/// <summary>
		/// Description: FAM function - GL
		/// FieldName: BSFG
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function - GL")]
		public int? M3_BSFG => GetNullableInt("BSFG");

		/// <summary>
		/// Description: FAM function - AR
		/// FieldName: BSFR
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function - AR")]
		public int? M3_BSFR => GetNullableInt("BSFR");

		/// <summary>
		/// Description: FAM function - AP
		/// FieldName: BSFP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function - AP")]
		public int? M3_BSFP => GetNullableInt("BSFP");

		/// <summary>
		/// Description: Bank statement no
		/// FieldName: BSJD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank statement no")]
		public int? M3_BSJD => GetNullableInt("BSJD");

		/// <summary>
		/// Description: Last bank statement nu used
		/// FieldName: BSLN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last bank statement nu used")]
		public string M3_BSLN => GetString("BSLN");

		/// <summary>
		/// Description: Separate voucher number per line
		/// FieldName: BSSV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Separate voucher number per line")]
		public int? M3_BSSV => GetNullableInt("BSSV");

		/// <summary>
		/// Description: Accounting date used
		/// FieldName: BSAU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting date used")]
		public int? M3_BSAU => GetNullableInt("BSAU");

		/// <summary>
		/// Description: Payment date used
		/// FieldName: BSPU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment date used")]
		public int? M3_BSPU => GetNullableInt("BSPU");

		/// <summary>
		/// Description: Exchange rate date used
		/// FieldName: BSEU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate date used")]
		public int? M3_BSEU => GetNullableInt("BSEU");

		/// <summary>
		/// Description: Voucher text for bank transaction
		/// FieldName: BSVT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher text for bank transaction")]
		public int? M3_BSVT => GetNullableInt("BSVT");

		/// <summary>
		/// Description: Bank format
		/// FieldName: BSBF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank format")]
		public string M3_BSBF => GetString("BSBF");

		/// <summary>
		/// Description: Enter statement manually
		/// FieldName: BSEM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Enter statement manually")]
		public int? M3_BSEM => GetNullableInt("BSEM");

		/// <summary>
		/// Description: Variance check
		/// FieldName: BSVC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Variance check")]
		public int? M3_BSVC => GetNullableInt("BSVC");

		/// <summary>
		/// Description: User defined field 1
		/// FieldName: BSU1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 1")]
		public string M3_BSU1 => GetString("BSU1");

		/// <summary>
		/// Description: User defined field 2
		/// FieldName: BSU2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 2")]
		public string M3_BSU2 => GetString("BSU2");

		/// <summary>
		/// Description: User defined field 3
		/// FieldName: BSU3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 3")]
		public string M3_BSU3 => GetString("BSU3");

		/// <summary>
		/// Description: User defined field 4
		/// FieldName: BSU4
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 4")]
		public string M3_BSU4 => GetString("BSU4");

		/// <summary>
		/// Description: User defined field 5
		/// FieldName: BSU5
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 5")]
		public string M3_BSU5 => GetString("BSU5");

		/// <summary>
		/// Description: User defined field 6
		/// FieldName: BSU6
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 6")]
		public string M3_BSU6 => GetString("BSU6");

		/// <summary>
		/// Description: Next manual step - bank
		/// FieldName: NXST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next manual step - bank")]
		public int? M3_NXST => GetNullableInt("NXST");

		/// <summary>
		/// Description: Update log file
		/// FieldName: UPLO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update log file")]
		public int? M3_UPLO => GetNullableInt("UPLO");

		/// <summary>
		/// Description: Customer bank account
		/// FieldName: UPBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer bank account")]
		public int? M3_UPBA => GetNullableInt("UPBA");

		/// <summary>
		/// Description: Supplier bank account
		/// FieldName: UPBS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier bank account")]
		public int? M3_UPBS => GetNullableInt("UPBS");

		/// <summary>
		/// Description: Bank account indicator
		/// FieldName: BKIN
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account indicator")]
		public int? M3_BKIN => GetNullableInt("BKIN");

		/// <summary>
		/// Description: Bank account balance
		/// FieldName: BSP1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account balance")]
		public int? M3_BSP1 => GetNullableInt("BSP1");

		/// <summary>
		/// Description: Structured
		/// FieldName: BSUC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structured")]
		public int? M3_BSUC => GetNullableInt("BSUC");

		/// <summary>
		/// Description: Qualifier sign
		/// FieldName: BSQS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Qualifier sign")]
		public string M3_BSQS => GetString("BSQS");

		/// <summary>
		/// Description: Transaction type
		/// FieldName: BSV1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type")]
		public int? M3_BSV1 => GetNullableInt("BSV1");

		/// <summary>
		/// Description: Business transaction code
		/// FieldName: BSV2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business transaction code")]
		public int? M3_BSV2 => GetNullableInt("BSV2");

		/// <summary>
		/// Description: Free field 1
		/// FieldName: BSF1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 1")]
		public int? M3_BSF1 => GetNullableInt("BSF1");

		/// <summary>
		/// Description: Free field 2
		/// FieldName: BSF2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 2")]
		public int? M3_BSF2 => GetNullableInt("BSF2");

		/// <summary>
		/// Description: Free field 3
		/// FieldName: BSF3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 3")]
		public string M3_BSF3 => GetString("BSF3");

		/// <summary>
		/// Description: Free field 4
		/// FieldName: BSF4
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 4")]
		public string M3_BSF4 => GetString("BSF4");

		/// <summary>
		/// Description: Bank statement type
		/// FieldName: BSTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank statement type")]
		public int? M3_BSTY => GetNullableInt("BSTY");

		/// <summary>
		/// Description: Reverse sign
		/// FieldName: LTCS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reverse sign")]
		public int? M3_LTCS => GetNullableInt("LTCS");

		/// <summary>
		/// Description: User-defined field 7 - bank stmnt lines
		/// FieldName: BSU7
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 7 - bank stmnt lines")]
		public string M3_BSU7 => GetString("BSU7");
	}
}
// EOF
