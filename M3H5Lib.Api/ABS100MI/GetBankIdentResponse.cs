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
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Bank identifier
		/// FieldName: BSID
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank identifier")]
		public string M3BSID => GetString("BSID");

		/// <summary>
		/// Description: Bank account id
		/// FieldName: BKID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account id")]
		public string M3BKID => GetString("BKID");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: FAM function
		/// FieldName: FNCN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function")]
		public int? M3FNCN => GetNullableInt("FNCN");

		/// <summary>
		/// Description: FAM function - GL
		/// FieldName: BSFG
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function - GL")]
		public int? M3BSFG => GetNullableInt("BSFG");

		/// <summary>
		/// Description: FAM function - AR
		/// FieldName: BSFR
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function - AR")]
		public int? M3BSFR => GetNullableInt("BSFR");

		/// <summary>
		/// Description: FAM function - AP
		/// FieldName: BSFP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function - AP")]
		public int? M3BSFP => GetNullableInt("BSFP");

		/// <summary>
		/// Description: Bank statement no
		/// FieldName: BSJD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank statement no")]
		public int? M3BSJD => GetNullableInt("BSJD");

		/// <summary>
		/// Description: Last bank statement nu used
		/// FieldName: BSLN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last bank statement nu used")]
		public string M3BSLN => GetString("BSLN");

		/// <summary>
		/// Description: Separate voucher number per line
		/// FieldName: BSSV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Separate voucher number per line")]
		public int? M3BSSV => GetNullableInt("BSSV");

		/// <summary>
		/// Description: Accounting date used
		/// FieldName: BSAU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting date used")]
		public int? M3BSAU => GetNullableInt("BSAU");

		/// <summary>
		/// Description: Payment date used
		/// FieldName: BSPU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment date used")]
		public int? M3BSPU => GetNullableInt("BSPU");

		/// <summary>
		/// Description: Exchange rate date used
		/// FieldName: BSEU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate date used")]
		public int? M3BSEU => GetNullableInt("BSEU");

		/// <summary>
		/// Description: Voucher text for bank transaction
		/// FieldName: BSVT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher text for bank transaction")]
		public int? M3BSVT => GetNullableInt("BSVT");

		/// <summary>
		/// Description: Bank format
		/// FieldName: BSBF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank format")]
		public string M3BSBF => GetString("BSBF");

		/// <summary>
		/// Description: Enter statement manually
		/// FieldName: BSEM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Enter statement manually")]
		public int? M3BSEM => GetNullableInt("BSEM");

		/// <summary>
		/// Description: Variance check
		/// FieldName: BSVC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Variance check")]
		public int? M3BSVC => GetNullableInt("BSVC");

		/// <summary>
		/// Description: User defined field 1
		/// FieldName: BSU1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 1")]
		public string M3BSU1 => GetString("BSU1");

		/// <summary>
		/// Description: User defined field 2
		/// FieldName: BSU2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 2")]
		public string M3BSU2 => GetString("BSU2");

		/// <summary>
		/// Description: User defined field 3
		/// FieldName: BSU3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 3")]
		public string M3BSU3 => GetString("BSU3");

		/// <summary>
		/// Description: User defined field 4
		/// FieldName: BSU4
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 4")]
		public string M3BSU4 => GetString("BSU4");

		/// <summary>
		/// Description: User defined field 5
		/// FieldName: BSU5
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 5")]
		public string M3BSU5 => GetString("BSU5");

		/// <summary>
		/// Description: User defined field 6
		/// FieldName: BSU6
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 6")]
		public string M3BSU6 => GetString("BSU6");

		/// <summary>
		/// Description: Next manual step - bank
		/// FieldName: NXST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next manual step - bank")]
		public int? M3NXST => GetNullableInt("NXST");

		/// <summary>
		/// Description: Update log file
		/// FieldName: UPLO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update log file")]
		public int? M3UPLO => GetNullableInt("UPLO");

		/// <summary>
		/// Description: Customer bank account
		/// FieldName: UPBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer bank account")]
		public int? M3UPBA => GetNullableInt("UPBA");

		/// <summary>
		/// Description: Supplier bank account
		/// FieldName: UPBS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier bank account")]
		public int? M3UPBS => GetNullableInt("UPBS");

		/// <summary>
		/// Description: Bank account indicator
		/// FieldName: BKIN
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account indicator")]
		public int? M3BKIN => GetNullableInt("BKIN");

		/// <summary>
		/// Description: Bank account balance
		/// FieldName: BSP1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account balance")]
		public int? M3BSP1 => GetNullableInt("BSP1");

		/// <summary>
		/// Description: Structured
		/// FieldName: BSUC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structured")]
		public int? M3BSUC => GetNullableInt("BSUC");

		/// <summary>
		/// Description: Qualifier sign
		/// FieldName: BSQS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Qualifier sign")]
		public string M3BSQS => GetString("BSQS");

		/// <summary>
		/// Description: Transaction type
		/// FieldName: BSV1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type")]
		public int? M3BSV1 => GetNullableInt("BSV1");

		/// <summary>
		/// Description: Business transaction code
		/// FieldName: BSV2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business transaction code")]
		public int? M3BSV2 => GetNullableInt("BSV2");

		/// <summary>
		/// Description: Free field 1
		/// FieldName: BSF1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 1")]
		public int? M3BSF1 => GetNullableInt("BSF1");

		/// <summary>
		/// Description: Free field 2
		/// FieldName: BSF2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 2")]
		public int? M3BSF2 => GetNullableInt("BSF2");

		/// <summary>
		/// Description: Free field 3
		/// FieldName: BSF3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 3")]
		public string M3BSF3 => GetString("BSF3");

		/// <summary>
		/// Description: Free field 4
		/// FieldName: BSF4
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 4")]
		public string M3BSF4 => GetString("BSF4");

		/// <summary>
		/// Description: Bank statement type
		/// FieldName: BSTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank statement type")]
		public int? M3BSTY => GetNullableInt("BSTY");

		/// <summary>
		/// Description: Reverse sign
		/// FieldName: LTCS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reverse sign")]
		public int? M3LTCS => GetNullableInt("LTCS");

		/// <summary>
		/// Description: User-defined field 7 - bank stmnt lines
		/// FieldName: BSU7
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 7 - bank stmnt lines")]
		public string M3BSU7 => GetString("BSU7");
	}
}
// EOF
