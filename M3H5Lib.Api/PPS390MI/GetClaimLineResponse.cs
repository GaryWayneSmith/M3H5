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

namespace M3H5Lib.Api.PPS390MI
{
	public partial class GetClaimLineResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Warehousedescription
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehousedescription")]
		public string M3WHNM => GetString("WHNM");

		/// <summary>
		/// Description: Suppliernumber
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliernumber")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Suppliername
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliername")]
		public string M3SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Ordertype
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordertype")]
		public string M3ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Name
		/// FieldName: ORTT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ORTT => GetString("ORTT");

		/// <summary>
		/// Description: Purchaseordernumber
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchaseordernumber")]
		public string M3PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Purchaseorderline
		/// FieldName: PNLI
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchaseorderline")]
		public int? M3PNLI => GetNullableInt("PNLI");

		/// <summary>
		/// Description: Purchaseorderlinesubnumber
		/// FieldName: PNLS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchaseorderlinesubnumber")]
		public int? M3PNLS => GetNullableInt("PNLS");

		/// <summary>
		/// Description: Itemnumber
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Itemnumber")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Serviceprocess
		/// FieldName: PRCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serviceprocess")]
		public string M3PRCS => GetString("PRCS");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Claimnumber
		/// FieldName: CLAN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claimnumber")]
		public string M3CLAN => GetString("CLAN");

		/// <summary>
		/// Description: Claimorderline
		/// FieldName: CLLN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claimorderline")]
		public int? M3CLLN => GetNullableInt("CLLN");

		/// <summary>
		/// Description: Claimstatus
		/// FieldName: CLIS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claimstatus")]
		public string M3CLIS => GetString("CLIS");

		/// <summary>
		/// Description: Supplieritemnumber
		/// FieldName: SITE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplieritemnumber")]
		public string M3SITE => GetString("SITE");

		/// <summary>
		/// Description: Purchaseorderitemname
		/// FieldName: PITD
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchaseorderitemname")]
		public string M3PITD => GetString("PITD");

		/// <summary>
		/// Description: Purchaseorderitemdescription
		/// FieldName: PITT
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchaseorderitemdescription")]
		public string M3PITT => GetString("PITT");

		/// <summary>
		/// Description: Receivedquantity
		/// FieldName: RVQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receivedquantity")]
		public decimal? M3RVQA => GetNullableDecimal("RVQA");

		/// <summary>
		/// Description: PurchaseorderU/M
		/// FieldName: PUUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PurchaseorderU/M")]
		public string M3PUUN => GetString("PUUN");

		/// <summary>
		/// Description: Approvedquantity-alternateU/M
		/// FieldName: CAQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approvedquantity-alternateU/M")]
		public decimal? M3CAQA => GetNullableDecimal("CAQA");

		/// <summary>
		/// Description: Rejectedquantity
		/// FieldName: RJQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejectedquantity")]
		public decimal? M3RJQA => GetNullableDecimal("RJQA");

		/// <summary>
		/// Description: Rejectionreason
		/// FieldName: SCRE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejectionreason")]
		public string M3SCRE => GetString("SCRE");

		/// <summary>
		/// Description: Name
		/// FieldName: SCRT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3SCRT => GetString("SCRT");

		/// <summary>
		/// Description: Qualityinspectedcostamount
		/// FieldName: ICAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Qualityinspectedcostamount")]
		public decimal? M3ICAM => GetNullableDecimal("ICAM");

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
		/// Description: Lotnumber
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lotnumber")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Receivingnumber
		/// FieldName: REPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receivingnumber")]
		public long? M3REPN => GetNullableLong("REPN");

		/// <summary>
		/// Description: Separation
		/// FieldName: MOVC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Separation")]
		public int? M3MOVC => GetNullableInt("MOVC");

		/// <summary>
		/// Description: Quality inspected cost amount
		/// FieldName: ISAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quality inspected cost amount")]
		public decimal? M3ISAM => GetNullableDecimal("ISAM");

		/// <summary>
		/// Description: Partly credit quantity
		/// FieldName: PCQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partly credit quantity")]
		public decimal? M3PCQA => GetNullableDecimal("PCQA");

		/// <summary>
		/// Description: Rejected quantity
		/// FieldName: RSQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejected quantity")]
		public decimal? M3RSQA => GetNullableDecimal("RSQA");

		/// <summary>
		/// Description: Rejection reason
		/// FieldName: SSRE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejection reason")]
		public string M3SSRE => GetString("SSRE");

		/// <summary>
		/// Description: Credit note number
		/// FieldName: CRNN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit note number")]
		public int? M3CRNN => GetNullableInt("CRNN");

		/// <summary>
		/// Description: Credit note date
		/// FieldName: CRND
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit note date")]
		public DateTime? M3CRND => GetNullableDateTime("CRND");

		/// <summary>
		/// Description: Credit status
		/// FieldName: CRSS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit status")]
		public string M3CRSS => GetString("CRSS");

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
		/// Description: Entitlement number
		/// FieldName: ENNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entitlement number")]
		public string M3ENNO => GetString("ENNO");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD1 => GetString("USD1");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD2 => GetString("USD2");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD3 => GetString("USD3");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD4 => GetString("USD4");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD5 => GetString("USD5");
	}
}
// EOF
