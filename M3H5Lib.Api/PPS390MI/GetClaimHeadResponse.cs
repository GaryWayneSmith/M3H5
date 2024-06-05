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

namespace M3H5Lib.Api.PPS390MI
{
	public partial class GetClaimHeadResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Suppliernumber
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliernumber")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Suppliername
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliername")]
		public string M3_SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Responsibleforreporting
		/// FieldName: RPRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsibleforreporting")]
		public string M3_RPRE => GetString("RPRE");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Warehousedescription
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehousedescription")]
		public string M3_WHNM => GetString("WHNM");

		/// <summary>
		/// Description: Claimnumber
		/// FieldName: CLAN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claimnumber")]
		public string M3_CLAN => GetString("CLAN");

		/// <summary>
		/// Description: Purchaseordernumber
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchaseordernumber")]
		public string M3_PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Lowestclaimstatus
		/// FieldName: CLAL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowestclaimstatus")]
		public string M3_CLAL => GetString("CLAL");

		/// <summary>
		/// Description: Highestclaimstatus
		/// FieldName: CLAH
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highestclaimstatus")]
		public string M3_CLAH => GetString("CLAH");

		/// <summary>
		/// Description: Claimofficer
		/// FieldName: CLRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claimofficer")]
		public string M3_CLRE => GetString("CLRE");

		/// <summary>
		/// Description: Claimdate
		/// FieldName: CLAD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claimdate")]
		public DateTime? M3_CLAD => GetNullableDateTime("CLAD");

		/// <summary>
		/// Description: Claimreference
		/// FieldName: CLRF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claimreference")]
		public string M3_CLRF => GetString("CLRF");

		/// <summary>
		/// Description: Yourreference
		/// FieldName: YRE1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yourreference")]
		public string M3_YRE1 => GetString("YRE1");

		/// <summary>
		/// Description: Replacementdelivery
		/// FieldName: REPT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Replacementdelivery")]
		public int? M3_REPT => GetNullableInt("REPT");

		/// <summary>
		/// Description: Credittoissue
		/// FieldName: CRTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credittoissue")]
		public int? M3_CRTI => GetNullableInt("CRTI");

		/// <summary>
		/// Description: Supplementarydelivery
		/// FieldName: COMD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplementarydelivery")]
		public int? M3_COMD => GetNullableInt("COMD");

		/// <summary>
		/// Description: Costtorepair
		/// FieldName: CORE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costtorepair")]
		public int? M3_CORE => GetNullableInt("CORE");

		/// <summary>
		/// Description: Updatematerialplan
		/// FieldName: UPAV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Updatematerialplan")]
		public int? M3_UPAV => GetNullableInt("UPAV");

		/// <summary>
		/// Description: Replacementdeliverydate
		/// FieldName: RPTD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Replacementdeliverydate")]
		public DateTime? M3_RPTD => GetNullableDateTime("RPTD");

		/// <summary>
		/// Description: Deliverynotenumber
		/// FieldName: SUDO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deliverynotenumber")]
		public string M3_SUDO => GetString("SUDO");

		/// <summary>
		/// Description: Supplierordernumber
		/// FieldName: SORN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplierordernumber")]
		public string M3_SORN => GetString("SORN");

		/// <summary>
		/// Description: Receiptdate
		/// FieldName: RCLD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiptdate")]
		public DateTime? M3_RCLD => GetNullableDateTime("RCLD");

		/// <summary>
		/// Description: Transactionidentity
		/// FieldName: TTID
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transactionidentity")]
		public string M3_TTID => GetString("TTID");

		/// <summary>
		/// Description: Communicationcode
		/// FieldName: CMCO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Communicationcode")]
		public string M3_CMCO => GetString("CMCO");

		/// <summary>
		/// Description: Facsimiletransmissionnumber
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimiletransmissionnumber")]
		public string M3_TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Yourviaaddress
		/// FieldName: SHVI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yourviaaddress")]
		public string M3_SHVI => GetString("SHVI");

		/// <summary>
		/// Description: Yourreceivingaddress
		/// FieldName: FIDS
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yourreceivingaddress")]
		public string M3_FIDS => GetString("FIDS");

		/// <summary>
		/// Description: Firstprintoutdate
		/// FieldName: LEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Firstprintoutdate")]
		public DateTime? M3_LEDT => GetNullableDateTime("LEDT");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

		/// <summary>
		/// Description: Consolidation value 1
		/// FieldName: CVE1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidation value 1")]
		public string M3_CVE1 => GetString("CVE1");

		/// <summary>
		/// Description: Consolidation value 2
		/// FieldName: CVE2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidation value 2")]
		public string M3_CVE2 => GetString("CVE2");

		/// <summary>
		/// Description: Consolidation value 3
		/// FieldName: CVE3
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidation value 3")]
		public string M3_CVE3 => GetString("CVE3");

		/// <summary>
		/// Description: Consolidation value 4
		/// FieldName: CVE4
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidation value 4")]
		public string M3_CVE4 => GetString("CVE4");

		/// <summary>
		/// Description: Consolidation value 5
		/// FieldName: CVE5
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidation value 5")]
		public string M3_CVE5 => GetString("CVE5");

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
		/// Description: Return to supplier order type
		/// FieldName: RTOT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return to supplier order type")]
		public string M3_RTOT => GetString("RTOT");

		/// <summary>
		/// Description: Return-to-supplier order category
		/// FieldName: RTOC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return-to-supplier order category")]
		public string M3_RTOC => GetString("RTOC");

		/// <summary>
		/// Description: Planned delivery date
		/// FieldName: DLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned delivery date")]
		public DateTime? M3_DLDT => GetNullableDateTime("DLDT");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3_USD1 => GetString("USD1");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3_USD2 => GetString("USD2");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3_USD3 => GetString("USD3");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3_USD4 => GetString("USD4");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3_USD5 => GetString("USD5");

		/// <summary>
		/// Description: External claim number
		/// FieldName: ECLN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External claim number")]
		public string M3_ECLN => GetString("ECLN");
	}
}
// EOF
