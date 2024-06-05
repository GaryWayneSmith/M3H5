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

namespace M3H5Lib.Api.COS117MI
{
	public partial class GetResponse : M3BaseRecord 
	{

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
		/// Description: Payer agreement
		/// FieldName: PYAG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer agreement")]
		public string M3PYAG => GetString("PYAG");

		/// <summary>
		/// Description: Labor
		/// FieldName: TIAM
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor")]
		public decimal? M3TIAM => GetNullableDecimal("TIAM");

		/// <summary>
		/// Description: Material
		/// FieldName: MAA1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material")]
		public decimal? M3MAA1 => GetNullableDecimal("MAA1");

		/// <summary>
		/// Description: Subcontract
		/// FieldName: SUAM
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subcontract")]
		public decimal? M3SUAM => GetNullableDecimal("SUAM");

		/// <summary>
		/// Description: Miscellaneous
		/// FieldName: MIA1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Miscellaneous")]
		public decimal? M3MIA1 => GetNullableDecimal("MIA1");

		/// <summary>
		/// Description: Loan
		/// FieldName: LOA3
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loan")]
		public decimal? M3LOA3 => GetNullableDecimal("LOA3");

		/// <summary>
		/// Description: Labor %
		/// FieldName: TIP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor %")]
		public int? M3TIP1 => GetNullableInt("TIP1");

		/// <summary>
		/// Description: Material %
		/// FieldName: MAP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material %")]
		public int? M3MAP1 => GetNullableInt("MAP1");

		/// <summary>
		/// Description: Subcontract %
		/// FieldName: SUP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subcontract %")]
		public int? M3SUP1 => GetNullableInt("SUP1");

		/// <summary>
		/// Description: Miscellaneous %
		/// FieldName: MIP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Miscellaneous %")]
		public int? M3MIP1 => GetNullableInt("MIP1");

		/// <summary>
		/// Description: Loan percent
		/// FieldName: LOP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loan percent")]
		public int? M3LOP1 => GetNullableInt("LOP1");

		/// <summary>
		/// Description: Service bill of material
		/// FieldName: ASBO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service bill of material")]
		public int? M3ASBO => GetNullableInt("ASBO");

		/// <summary>
		/// Description: Claim warranty
		/// FieldName: ACWA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim warranty")]
		public int? M3ACWA => GetNullableInt("ACWA");

		/// <summary>
		/// Description: Product service BoM
		/// FieldName: WPRN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product service BoM")]
		public string M3WPRN => GetString("WPRN");

		/// <summary>
		/// Description: Structure type service bill of material
		/// FieldName: WSTR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type service bill of material")]
		public string M3WSTR => GetString("WSTR");

		/// <summary>
		/// Description: Service bill of material
		/// FieldName: WSUF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service bill of material")]
		public string M3WSUF => GetString("WSUF");

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
		/// Description: Invoice date
		/// FieldName: IVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3IVDT => GetNullableDateTime("IVDT");

		/// <summary>
		/// Description: Highest status
		/// FieldName: AOST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status")]
		public string M3AOST => GetString("AOST");

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public int? M3VTCD => GetNullableInt("VTCD");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Tax applicable
		/// FieldName: TXAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax applicable")]
		public int? M3TXAP => GetNullableInt("TXAP");

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
		/// Description: Previous invoice year
		/// FieldName: PREY
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous invoice year")]
		public int? M3PREY => GetNullableInt("PREY");

		/// <summary>
		/// Description: Labor Warranty split
		/// FieldName: TIA7
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor Warranty split")]
		public decimal? M3TIA7 => GetNullableDecimal("TIA7");

		/// <summary>
		/// Description: Material Warranty split
		/// FieldName: MAA7
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material Warranty split")]
		public decimal? M3MAA7 => GetNullableDecimal("MAA7");

		/// <summary>
		/// Description: Subcontract Warranty split
		/// FieldName: SUA7
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subcontract Warranty split")]
		public decimal? M3SUA7 => GetNullableDecimal("SUA7");

		/// <summary>
		/// Description: Misc amount
		/// FieldName: MIA7
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Misc amount")]
		public decimal? M3MIA7 => GetNullableDecimal("MIA7");

		/// <summary>
		/// Description: Loan amount
		/// FieldName: LOA7
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loan amount")]
		public string M3LOA7 => GetString("LOA7");

		/// <summary>
		/// Description: Labor discount
		/// FieldName: TIP7
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor discount")]
		public int? M3TIP7 => GetNullableInt("TIP7");

		/// <summary>
		/// Description: Material discount
		/// FieldName: MAP7
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material discount")]
		public int? M3MAP7 => GetNullableInt("MAP7");

		/// <summary>
		/// Description: Misc discount
		/// FieldName: MIP7
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Misc discount")]
		public int? M3MIP7 => GetNullableInt("MIP7");

		/// <summary>
		/// Description: Loan discount
		/// FieldName: LPO7
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loan discount")]
		public int? M3LPO7 => GetNullableInt("LPO7");

		/// <summary>
		/// Description: Fixed amount
		/// FieldName: APAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed amount")]
		public int? M3APAC => GetNullableInt("APAC");

		/// <summary>
		/// Description: Payment class
		/// FieldName: PYCL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment class")]
		public int? M3PYCL => GetNullableInt("PYCL");

		/// <summary>
		/// Description: Agreement Claim
		/// FieldName: CLAG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement Claim")]
		public string M3CLAG => GetString("CLAG");

		/// <summary>
		/// Description: Claim
		/// FieldName: CLNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim")]
		public string M3CLNO => GetString("CLNO");

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
		/// Description: Previous invoice prefix
		/// FieldName: PINP
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous invoice prefix")]
		public string M3PINP => GetString("PINP");

		/// <summary>
		/// Description: Previous extended invoice number
		/// FieldName: PXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous extended invoice number")]
		public string M3PXIN => GetString("PXIN");

		/// <summary>
		/// Description: Labor split %
		/// FieldName: TIP3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor split %")]
		public int? M3TIP3 => GetNullableInt("TIP3");

		/// <summary>
		/// Description: Material split %
		/// FieldName: MAP3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material split %")]
		public int? M3MAP3 => GetNullableInt("MAP3");

		/// <summary>
		/// Description: Subcontract split %
		/// FieldName: SUP3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subcontract split %")]
		public int? M3SUP3 => GetNullableInt("SUP3");

		/// <summary>
		/// Description: New field description
		/// FieldName: MIP3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New field description")]
		public int? M3MIP3 => GetNullableInt("MIP3");

		/// <summary>
		/// Description: Loan split %
		/// FieldName: LOP3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loan split %")]
		public int? M3LOP3 => GetNullableInt("LOP3");

		/// <summary>
		/// Description: Service price method
		/// FieldName: SRVP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service price method")]
		public int? M3SRVP => GetNullableInt("SRVP");

		/// <summary>
		/// Description: Split origin
		/// FieldName: ORSP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split origin")]
		public int? M3ORSP => GetNullableInt("ORSP");
	}
}
// EOF
