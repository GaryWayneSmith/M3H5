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

namespace M3H5Lib.Api.CRS750MI
{
	public partial class GetGLSettingsResponse : M3BaseRecord 
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
		/// Description: Debit / credit code used
		/// FieldName: DCNY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit / credit code used")]
		public int? M3_DCNY => GetNullableInt("DCNY");

		/// <summary>
		/// Description: Sign debit
		/// FieldName: DBPS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sign debit")]
		public string M3_DBPS => GetString("DBPS");

		/// <summary>
		/// Description: Sign credit
		/// FieldName: DBNG
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sign credit")]
		public string M3_DBNG => GetString("DBNG");

		/// <summary>
		/// Description: Cancel A/C
		/// FieldName: AIT1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cancel A/C")]
		public string M3_AIT1 => GetString("AIT1");

		/// <summary>
		/// Description: A/C description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("A/C description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Voucher name
		/// FieldName: VDSC
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher name")]
		public string M3_VDSC => GetString("VDSC");

		/// <summary>
		/// Description: Compress account enteries for interest invoices
		/// FieldName: ATC2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compress account enteries for interest invoices")]
		public int? M3_ATC2 => GetNullableInt("ATC2");

		/// <summary>
		/// Description: Check transaction file
		/// FieldName: CHEC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check transaction file")]
		public int? M3_CHEC => GetNullableInt("CHEC");

		/// <summary>
		/// Description: Account addition
		/// FieldName: AACC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account addition")]
		public int? M3_AACC => GetNullableInt("AACC");

		/// <summary>
		/// Description: VAT check on-line
		/// FieldName: OLVC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT check on-line")]
		public int? M3_OLVC => GetNullableInt("OLVC");

		/// <summary>
		/// Description: Accepted VAT deviation
		/// FieldName: ACVD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accepted VAT deviation")]
		public decimal? M3_ACVD => GetNullableDecimal("ACVD");

		/// <summary>
		/// Description: Book of account
		/// FieldName: ACBC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Book of account")]
		public int? M3_ACBC => GetNullableInt("ACBC");

		/// <summary>
		/// Description: Reconciliation
		/// FieldName: RECE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reconciliation")]
		public int? M3_RECE => GetNullableInt("RECE");

		/// <summary>
		/// Description: VAT Last run date
		/// FieldName: FRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT Last run date")]
		public DateTime? M3_FRDT => GetNullableDateTime("FRDT");

		/// <summary>
		/// Description: Base amount - calc of doubtful accounts
		/// FieldName: AGNG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base amount - calc of doubtful accounts")]
		public int? M3_AGNG => GetNullableInt("AGNG");

		/// <summary>
		/// Description: Update General Ledger
		/// FieldName: UPGL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update General Ledger")]
		public int? M3_UPGL => GetNullableInt("UPGL");

		/// <summary>
		/// Description: External/internal transaction
		/// FieldName: EICD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External/internal transaction")]
		public int? M3_EICD => GetNullableInt("EICD");

		/// <summary>
		/// Description: VAT date type
		/// FieldName: VDTT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT date type")]
		public int? M3_VDTT => GetNullableInt("VDTT");

		/// <summary>
		/// Description: Cross division voucher
		/// FieldName: CRDI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cross division voucher")]
		public int? M3_CRDI => GetNullableInt("CRDI");

		/// <summary>
		/// Description: Third currency
		/// FieldName: THCC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency")]
		public string M3_THCC => GetString("THCC");

		/// <summary>
		/// Description: Third currency rate type
		/// FieldName: TCRT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency rate type")]
		public int? M3_TCRT => GetNullableInt("TCRT");

		/// <summary>
		/// Description: Use commitment
		/// FieldName: FUCO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Use commitment")]
		public int? M3_FUCO => GetNullableInt("FUCO");

		/// <summary>
		/// Description: Budget number (committed value)
		/// FieldName: BUNC
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget number (committed value)")]
		public int? M3_BUNC => GetNullableInt("BUNC");

		/// <summary>
		/// Description: Budget version (committed value)
		/// FieldName: BVVC
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget version (committed value)")]
		public string M3_BVVC => GetString("BVVC");

		/// <summary>
		/// Description: Budget number  (budget value)
		/// FieldName: BUNB
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget number  (budget value)")]
		public int? M3_BUNB => GetNullableInt("BUNB");

		/// <summary>
		/// Description: Budget version (budget value)
		/// FieldName: BVVB
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget version (budget value)")]
		public string M3_BVVB => GetString("BVVB");

		/// <summary>
		/// Description: Budget number (manual values)
		/// FieldName: BUNM
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget number (manual values)")]
		public int? M3_BUNM => GetNullableInt("BUNM");

		/// <summary>
		/// Description: Budget version (manual values)
		/// FieldName: BVVM
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget version (manual values)")]
		public string M3_BVVM => GetString("BVVM");

		/// <summary>
		/// Description: Block/warning
		/// FieldName: BLWA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Block/warning")]
		public int? M3_BLWA => GetNullableInt("BLWA");

		/// <summary>
		/// Description: Reduce at
		/// FieldName: REDU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reduce at")]
		public int? M3_REDU => GetNullableInt("REDU");

		/// <summary>
		/// Description: Comparision at
		/// FieldName: CMPA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comparision at")]
		public int? M3_CMPA => GetNullableInt("CMPA");

		/// <summary>
		/// Description: Commitment date
		/// FieldName: CMDT
		/// FieldType: D
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commitment date")]
		public DateTime? M3_CMDT => GetNullableDateTime("CMDT");

		/// <summary>
		/// Description: Accounting dimension 1 used
		/// FieldName: FAC1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 1 used")]
		public string M3_FAC1 => GetString("FAC1");

		/// <summary>
		/// Description: Accounting dimension 2 used
		/// FieldName: FAC2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 2 used")]
		public string M3_FAC2 => GetString("FAC2");

		/// <summary>
		/// Description: Accounting dimension 3 used
		/// FieldName: FAC3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 3 used")]
		public string M3_FAC3 => GetString("FAC3");

		/// <summary>
		/// Description: Accounting dimension 4 used
		/// FieldName: FAC4
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 4 used")]
		public string M3_FAC4 => GetString("FAC4");

		/// <summary>
		/// Description: Accounting dimension 5 used
		/// FieldName: FAC5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 5 used")]
		public string M3_FAC5 => GetString("FAC5");

		/// <summary>
		/// Description: Accounting dimension 6 used
		/// FieldName: FAC6
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 6 used")]
		public string M3_FAC6 => GetString("FAC6");

		/// <summary>
		/// Description: Accounting dimension 7 used
		/// FieldName: FAC7
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 7 used")]
		public string M3_FAC7 => GetString("FAC7");

		/// <summary>
		/// Description: VAT printout
		/// FieldName: VTPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT printout")]
		public int? M3_VTPC => GetNullableInt("VTPC");

		/// <summary>
		/// Description: VAT report from date
		/// FieldName: VTFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT report from date")]
		public DateTime? M3_VTFD => GetNullableDateTime("VTFD");

		/// <summary>
		/// Description: Credit check including VAT
		/// FieldName: CLVT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit check including VAT")]
		public int? M3_CLVT => GetNullableInt("CLVT");

		/// <summary>
		/// Description: Credit check incl blocked invoices
		/// FieldName: CLBI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit check incl blocked invoices")]
		public int? M3_CLBI => GetNullableInt("CLBI");

		/// <summary>
		/// Description: Draft accounting method
		/// FieldName: DAME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Draft accounting method")]
		public int? M3_DAME => GetNullableInt("DAME");

		/// <summary>
		/// Description: Accounting ID in multiple structure
		/// FieldName: AIMS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting ID in multiple structure")]
		public int? M3_AIMS => GetNullableInt("AIMS");

		/// <summary>
		/// Description: Legal reports
		/// FieldName: LRSP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Legal reports")]
		public string M3_LRSP => GetString("LRSP");

		/// <summary>
		/// Description: Official number
		/// FieldName: NBID
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Official number")]
		public string M3_NBID => GetString("NBID");

		/// <summary>
		/// Description: Credit time fence
		/// FieldName: TFC3
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit time fence")]
		public int? M3_TFC3 => GetNullableInt("TFC3");

		/// <summary>
		/// Description: Invoice class
		/// FieldName: IVCC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice class")]
		public int? M3_IVCC => GetNullableInt("IVCC");

		/// <summary>
		/// Description: Voucher cover sheet
		/// FieldName: VCSH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher cover sheet")]
		public int? M3_VCSH => GetNullableInt("VCSH");

		/// <summary>
		/// Description: Update accounting date in trans tables
		/// FieldName: CHAD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update accounting date in trans tables")]
		public int? M3_CHAD => GetNullableInt("CHAD");

		/// <summary>
		/// Description: Prepayment processing
		/// FieldName: PRPY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prepayment processing")]
		public int? M3_PRPY => GetNullableInt("PRPY");

		/// <summary>
		/// Description: VAT rate method
		/// FieldName: VTRM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT rate method")]
		public int? M3_VTRM => GetNullableInt("VTRM");

		/// <summary>
		/// Description: exchange rate type - VAT reporting
		/// FieldName: RTVR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("exchange rate type - VAT reporting")]
		public int? M3_RTVR => GetNullableInt("RTVR");

		/// <summary>
		/// Description: Retrieve VATcode
		/// FieldName: RTVC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Retrieve VATcode")]
		public int? M3_RTVC => GetNullableInt("RTVC");

		/// <summary>
		/// Description: Prevent balance file accumulation
		/// FieldName: PBF2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prevent balance file accumulation")]
		public int? M3_PBF2 => GetNullableInt("PBF2");

		/// <summary>
		/// Description: Prevent balance file accumulation
		/// FieldName: PBF3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prevent balance file accumulation")]
		public int? M3_PBF3 => GetNullableInt("PBF3");

		/// <summary>
		/// Description: Prevent balance file accumulation
		/// FieldName: PBF4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prevent balance file accumulation")]
		public int? M3_PBF4 => GetNullableInt("PBF4");

		/// <summary>
		/// Description: Prevent balance file accumulation
		/// FieldName: PBF5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prevent balance file accumulation")]
		public int? M3_PBF5 => GetNullableInt("PBF5");

		/// <summary>
		/// Description: Prevent balance file accumulation
		/// FieldName: PBF6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prevent balance file accumulation")]
		public int? M3_PBF6 => GetNullableInt("PBF6");

		/// <summary>
		/// Description: Prevent balance file accumulation
		/// FieldName: PBF7
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prevent balance file accumulation")]
		public int? M3_PBF7 => GetNullableInt("PBF7");
	}
}
// EOF
