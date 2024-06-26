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

namespace M3H5Lib.Api.CRBE01MI
{
	public partial class GetBasicDataResponse : M3BaseRecord 
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
		/// Description: Local FAM Parameter ID
		/// FieldName: STCO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local FAM Parameter ID")]
		public string M3STCO => GetString("STCO");

		/// <summary>
		/// Description: Payment Code
		/// FieldName: XCPM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment Code")]
		public string M3XCPM => GetString("XCPM");

		/// <summary>
		/// Description: Code Kost
		/// FieldName: XCST
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Kost")]
		public string M3XCST => GetString("XCST");

		/// <summary>
		/// Description: Code BLIW
		/// FieldName: XBLW
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code BLIW")]
		public string M3XBLW => GetString("XBLW");

		/// <summary>
		/// Description: Period Type Quartal List
		/// FieldName: XPTQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period Type Quartal List")]
		public int? M3XPTQ => GetNullableInt("XPTQ");

		/// <summary>
		/// Description: Category
		/// FieldName: XCTQ
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Category")]
		public string M3XCTQ => GetString("XCTQ");

		/// <summary>
		/// Description: Address Code 1
		/// FieldName: XCD1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address Code 1")]
		public string M3XCD1 => GetString("XCD1");

		/// <summary>
		/// Description: Address Code 2
		/// FieldName: XCD2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address Code 2")]
		public string M3XCD2 => GetString("XCD2");

		/// <summary>
		/// Description: Address Code 3
		/// FieldName: XCD3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address Code 3")]
		public string M3XCD3 => GetString("XCD3");

		/// <summary>
		/// Description: Local FAM
		/// FieldName: XLFM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local FAM")]
		public string M3XLFM => GetString("XLFM");

		/// <summary>
		/// Description: Company Name
		/// FieldName: XCNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Name")]
		public string M3XCNM => GetString("XCNM");

		/// <summary>
		/// Description: Address Line 1
		/// FieldName: ZAD1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address Line 1")]
		public string M3ZAD1 => GetString("ZAD1");

		/// <summary>
		/// Description: Postal Code
		/// FieldName: XPCD
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal Code")]
		public int? M3XPCD => GetNullableInt("XPCD");

		/// <summary>
		/// Description: Country Code ISO
		/// FieldName: XPCP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country Code ISO")]
		public string M3XPCP => GetString("XPCP");

		/// <summary>
		/// Description: Address Line 1
		/// FieldName: XCIL
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address Line 1")]
		public string M3XCIL => GetString("XCIL");

		/// <summary>
		/// Description: Country
		/// FieldName: XCTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3XCTY => GetString("XCTY");

		/// <summary>
		/// Description: Document Type
		/// FieldName: XPDT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document Type")]
		public string M3XPDT => GetString("XPDT");

		/// <summary>
		/// Description: Document Type
		/// FieldName: XNDT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document Type")]
		public string M3XNDT => GetString("XNDT");

		/// <summary>
		/// Description: Labor Code - Trade Statistic
		/// FieldName: XPLC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor Code - Trade Statistic")]
		public string M3XPLC => GetString("XPLC");

		/// <summary>
		/// Description: Labor Code - Trade Statistic
		/// FieldName: XNLC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor Code - Trade Statistic")]
		public string M3XNLC => GetString("XNLC");

		/// <summary>
		/// Description: Accounting Dimension
		/// FieldName: AITP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting Dimension")]
		public int? M3AITP => GetNullableInt("AITP");

		/// <summary>
		/// Description: File Extension
		/// FieldName: XFLE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File Extension")]
		public string M3XFLE => GetString("XFLE");

		/// <summary>
		/// Description: Create Member for Disk File
		/// FieldName: XMBR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Create Member for Disk File")]
		public string M3XMBR => GetString("XMBR");

		/// <summary>
		/// Description: Number of Invoice Payments
		/// FieldName: XNIV
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of Invoice Payments")]
		public int? M3XNIV => GetNullableInt("XNIV");

		/// <summary>
		/// Description: VAT Number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT Number")]
		public string M3VRNO => GetString("VRNO");

		/// <summary>
		/// Description: Country Code
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country Code")]
		public string M3CSCD => GetString("CSCD");
	}
}
// EOF
