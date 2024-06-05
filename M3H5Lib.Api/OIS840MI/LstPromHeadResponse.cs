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

namespace M3H5Lib.Api.OIS840MI
{
	public partial class LstPromHeadResponse : M3BaseRecord 
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
		/// Description: Promotion
		/// FieldName: PIDE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion")]
		public string M3_PIDE => GetString("PIDE");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

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
		/// Description: Table
		/// FieldName: TAID
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Table")]
		public string M3_TAID => GetString("TAID");

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
		/// Description: Status - promotion
		/// FieldName: PROS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - promotion")]
		public int? M3_PROS => GetNullableInt("PROS");

		/// <summary>
		/// Description: Promotion type
		/// FieldName: PTPE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion type")]
		public string M3_PTPE => GetString("PTPE");

		/// <summary>
		/// Description: Promotion responsible
		/// FieldName: PRES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion responsible")]
		public string M3_PRES => GetString("PRES");

		/// <summary>
		/// Description: Date code
		/// FieldName: DTCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date code")]
		public int? M3_DTCD => GetNullableInt("DTCD");

		/// <summary>
		/// Description: Valid from
		/// FieldName: FVDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3_FVDT => GetNullableDateTime("FVDT");

		/// <summary>
		/// Description: Valid to
		/// FieldName: LVDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3_LVDT => GetNullableDateTime("LVDT");

		/// <summary>
		/// Description: Activity start date
		/// FieldName: FRD2
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Activity start date")]
		public DateTime? M3_FRD2 => GetNullableDateTime("FRD2");

		/// <summary>
		/// Description: Activity end date
		/// FieldName: TOD2
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Activity end date")]
		public DateTime? M3_TOD2 => GetNullableDateTime("TOD2");

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
		/// Description: Promotion terms
		/// FieldName: PTER
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion terms")]
		public int? M3_PTER => GetNullableInt("PTER");

		/// <summary>
		/// Description: Budgeted fixed cost
		/// FieldName: BUFC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budgeted fixed cost")]
		public decimal? M3_BUFC => GetNullableDecimal("BUFC");

		/// <summary>
		/// Description: Actual fixed cost
		/// FieldName: ACFC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual fixed cost")]
		public decimal? M3_ACFC => GetNullableDecimal("ACFC");

		/// <summary>
		/// Description: Distribution method
		/// FieldName: DIMI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution method")]
		public int? M3_DIMI => GetNullableInt("DIMI");

		/// <summary>
		/// Description: Amount sold
		/// FieldName: SOAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount sold")]
		public decimal? M3_SOAM => GetNullableDecimal("SOAM");

		/// <summary>
		/// Description: Additional text
		/// FieldName: TX08
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional text")]
		public string M3_TX08 => GetString("TX08");

		/// <summary>
		/// Description: Discount category
		/// FieldName: DICA
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount category")]
		public string M3_DICA => GetString("DICA");

		/// <summary>
		/// Description: Discount base
		/// FieldName: DIBE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount base")]
		public string M3_DIBE => GetString("DIBE");

		/// <summary>
		/// Description: Discount relation
		/// FieldName: DIRE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount relation")]
		public string M3_DIRE => GetString("DIRE");

		/// <summary>
		/// Description: Manually changeable discount
		/// FieldName: DCHA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manually changeable discount")]
		public int? M3_DCHA => GetNullableInt("DCHA");

		/// <summary>
		/// Description: Statistics field for discount
		/// FieldName: DPST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics field for discount")]
		public int? M3_DPST => GetNullableInt("DPST");

		/// <summary>
		/// Description: Discount presentation
		/// FieldName: DDSU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount presentation")]
		public int? M3_DDSU => GetNullableInt("DDSU");

		/// <summary>
		/// Description: Internal discount
		/// FieldName: IDSC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal discount")]
		public int? M3_IDSC => GetNullableInt("IDSC");

		/// <summary>
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3_ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Activity customer
		/// FieldName: ACUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Activity customer")]
		public string M3_ACUS => GetString("ACUS");

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
		/// Description: Costing model - sales price
		/// FieldName: SCMO
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing model - sales price")]
		public string M3_SCMO => GetString("SCMO");

		/// <summary>
		/// Description: Promotion statistics period type 1
		/// FieldName: PPT1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion statistics period type 1")]
		public int? M3_PPT1 => GetNullableInt("PPT1");

		/// <summary>
		/// Description: Promotion statistics period type 2
		/// FieldName: PPT2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Promotion statistics period type 2")]
		public int? M3_PPT2 => GetNullableInt("PPT2");

		/// <summary>
		/// Description: Bill back
		/// FieldName: BILB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bill back")]
		public int? M3_BILB => GetNullableInt("BILB");

		/// <summary>
		/// Description: Business chain
		/// FieldName: CHAI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain")]
		public string M3_CHAI => GetString("CHAI");

		/// <summary>
		/// Description: Customer selection
		/// FieldName: CUSE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer selection")]
		public string M3_CUSE => GetString("CUSE");

		/// <summary>
		/// Description: Update promotion
		/// FieldName: UPPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update promotion")]
		public int? M3_UPPC => GetNullableInt("UPPC");

		/// <summary>
		/// Description: Customer generated
		/// FieldName: CUGE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer generated")]
		public int? M3_CUGE => GetNullableInt("CUGE");

		/// <summary>
		/// Description: Warehouse generated
		/// FieldName: WHGE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse generated")]
		public int? M3_WHGE => GetNullableInt("WHGE");

		/// <summary>
		/// Description: Warehouse table
		/// FieldName: WHTA
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse table")]
		public string M3_WHTA => GetString("WHTA");

		/// <summary>
		/// Description: Warehouse selection
		/// FieldName: WHSE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse selection")]
		public string M3_WHSE => GetString("WHSE");

		/// <summary>
		/// Description: Object access group
		/// FieldName: ACGR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Object access group")]
		public string M3_ACGR => GetString("ACGR");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 8
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
		/// Length: 8
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

		/// <summary>
		/// Description: Bonus generating
		/// FieldName: BNCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus generating")]
		public int? M3_BNCD => GetNullableInt("BNCD");

		/// <summary>
		/// Description: Commission generating
		/// FieldName: PRAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commission generating")]
		public int? M3_PRAC => GetNullableInt("PRAC");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Claim calculation method
		/// FieldName: CLMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim calculation method")]
		public int? M3_CLMT => GetNullableInt("CLMT");

		/// <summary>
		/// Description: SPA claim percentage
		/// FieldName: SCLP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SPA claim percentage")]
		public int? M3_SCLP => GetNullableInt("SCLP");

		/// <summary>
		/// Description: Discount percentage
		/// FieldName: DISP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount percentage")]
		public int? M3_DISP => GetNullableInt("DISP");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AGNB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3_AGNB => GetString("AGNB");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3_TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Priority
		/// FieldName: PRI2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3_PRI2 => GetNullableInt("PRI2");

		/// <summary>
		/// Description: Propose supplier
		/// FieldName: PSUP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Propose supplier")]
		public int? M3_PSUP => GetNullableInt("PSUP");

		/// <summary>
		/// Description: Price list 1
		/// FieldName: PRR1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list 1")]
		public string M3_PRR1 => GetString("PRR1");

		/// <summary>
		/// Description: Currency code 1
		/// FieldName: CUC1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency code 1")]
		public string M3_CUC1 => GetString("CUC1");

		/// <summary>
		/// Description: Label flag 1
		/// FieldName: LFL1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Label flag 1")]
		public string M3_LFL1 => GetString("LFL1");

		/// <summary>
		/// Description: Price list
		/// FieldName: PRRF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list")]
		public string M3_PRRF => GetString("PRRF");

		/// <summary>
		/// Description: Order type group
		/// FieldName: OTYG
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type group")]
		public string M3_OTYG => GetString("OTYG");

		/// <summary>
		/// Description: Initial start
		/// FieldName: INIS
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Initial start")]
		public DateTime? M3_INIS => GetNullableDateTime("INIS");

		/// <summary>
		/// Description: Initial end
		/// FieldName: INIE
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Initial end")]
		public DateTime? M3_INIE => GetNullableDateTime("INIE");

		/// <summary>
		/// Description: Auto retrieval of promotion
		/// FieldName: ANIN
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Auto retrieval of promotion")]
		public DateTime? M3_ANIN => GetNullableDateTime("ANIN");

		/// <summary>
		/// Description: Hold Initial order
		/// FieldName: HOIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hold Initial order")]
		public int? M3_HOIN => GetNullableInt("HOIN");

		/// <summary>
		/// Description: Supply chain policy
		/// FieldName: SCPO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply chain policy")]
		public string M3_SCPO => GetString("SCPO");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Consumed percent
		/// FieldName: COPT
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consumed percent")]
		public int? M3_COPT => GetNullableInt("COPT");
	}
}
// EOF
