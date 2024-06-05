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

namespace M3H5Lib.Api.MWS070MI
{
	public partial class ListTransByDateResponse : M3BaseRecord 
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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Time suffix
		/// FieldName: TMSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time suffix")]
		public int? M3TMSX => GetNullableInt("TMSX");

		/// <summary>
		/// Description: Transaction date
		/// FieldName: TRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction date")]
		public DateTime? M3TRDT => GetNullableDateTime("TRDT");

		/// <summary>
		/// Description: Transaction time
		/// FieldName: TRTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction time")]
		public int? M3TRTM => GetNullableInt("TRTM");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3RESP => GetString("RESP");

		/// <summary>
		/// Description: Transaction identity
		/// FieldName: TTID
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction identity")]
		public string M3TTID => GetString("TTID");

		/// <summary>
		/// Description: Order type
		/// FieldName: TRTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3TRTP => GetString("TRTP");

		/// <summary>
		/// Description: Stock transaction type
		/// FieldName: TTYP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock transaction type")]
		public int? M3TTYP => GetNullableInt("TTYP");

		/// <summary>
		/// Description: Stock zone
		/// FieldName: SLTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock zone")]
		public string M3SLTP => GetString("SLTP");

		/// <summary>
		/// Description: Location
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3WHSL => GetString("WHSL");

		/// <summary>
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Container
		/// FieldName: CAMU
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container")]
		public string M3CAMU => GetString("CAMU");

		/// <summary>
		/// Description: Lot reference 1
		/// FieldName: BREF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot reference 1")]
		public string M3BREF => GetString("BREF");

		/// <summary>
		/// Description: Lot reference 2
		/// FieldName: BRE2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot reference 2")]
		public string M3BRE2 => GetString("BRE2");

		/// <summary>
		/// Description: Order number
		/// FieldName: RIDN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order number")]
		public string M3RIDN => GetString("RIDN");

		/// <summary>
		/// Description: Order operation
		/// FieldName: RIDO
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order operation")]
		public int? M3RIDO => GetNullableInt("RIDO");

		/// <summary>
		/// Description: Order line
		/// FieldName: RIDL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line")]
		public int? M3RIDL => GetNullableInt("RIDL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RIDX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RIDX => GetNullableInt("RIDX");

		/// <summary>
		/// Description: Delivery number
		/// FieldName: RIDI
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3RIDI => GetNullableDecimal("RIDI");

		/// <summary>
		/// Description: Picking list suffix
		/// FieldName: PLSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list suffix")]
		public int? M3PLSX => GetNullableInt("PLSX");

		/// <summary>
		/// Description: Reference text
		/// FieldName: RFTX
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference text")]
		public string M3RFTX => GetString("RFTX");

		/// <summary>
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Process manufacturing order number
		/// FieldName: PRMF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Process manufacturing order number")]
		public string M3PRMF => GetString("PRMF");

		/// <summary>
		/// Description: Representative transaction
		/// FieldName: RPRT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Representative transaction")]
		public int? M3RPRT => GetNullableInt("RPRT");

		/// <summary>
		/// Description: Revision number
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3ECVE => GetString("ECVE");

		/// <summary>
		/// Description: Status - balance ID
		/// FieldName: STAS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - balance ID")]
		public string M3STAS => GetString("STAS");

		/// <summary>
		/// Description: Transaction quantity - basic U/M
		/// FieldName: TRQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction quantity - basic U/M")]
		public decimal? M3TRQT => GetNullableDecimal("TRQT");

		/// <summary>
		/// Description: New on-hand balance
		/// FieldName: NSTQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New on-hand balance")]
		public decimal? M3NSTQ => GetNullableDecimal("NSTQ");

		/// <summary>
		/// Description: New on-hand balance per transaction date
		/// FieldName: NSTT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New on-hand balance per transaction date")]
		public decimal? M3NSTT => GetNullableDecimal("NSTT");

		/// <summary>
		/// Description: Receiving number
		/// FieldName: REPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving number")]
		public long? M3REPN => GetNullableLong("REPN");

		/// <summary>
		/// Description: Physical inventory error
		/// FieldName: INER
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical inventory error")]
		public int? M3INER => GetNullableInt("INER");

		/// <summary>
		/// Description: Updating code for transaction
		/// FieldName: TUPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Updating code for transaction")]
		public int? M3TUPC => GetNullableInt("TUPC");

		/// <summary>
		/// Description: Inventory accounting price
		/// FieldName: TRPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting price")]
		public decimal? M3TRPR => GetNullableDecimal("TRPR");

		/// <summary>
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Accounting number
		/// FieldName: ANBR
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting number")]
		public decimal? M3ANBR => GetNullableDecimal("ANBR");

		/// <summary>
		/// Description: Acquisition cost
		/// FieldName: MFCO
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acquisition cost")]
		public decimal? M3MFCO => GetNullableDecimal("MFCO");

		/// <summary>
		/// Description: Total on-hand balance
		/// FieldName: STNO
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total on-hand balance")]
		public decimal? M3STNO => GetNullableDecimal("STNO");

		/// <summary>
		/// Description: Project number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number")]
		public string M3PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3ELNO => GetString("ELNO");

		/// <summary>
		/// Description: Transaction reason
		/// FieldName: RSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction reason")]
		public string M3RSCD => GetString("RSCD");

		/// <summary>
		/// Description: Catchweight
		/// FieldName: CAWE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catchweight")]
		public decimal? M3CAWE => GetNullableDecimal("CAWE");

		/// <summary>
		/// Description: Consumption date
		/// FieldName: CNDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consumption date")]
		public DateTime? M3CNDA => GetNullableDateTime("CNDA");

		/// <summary>
		/// Description: Expiration time adjustment - days
		/// FieldName: ADCU
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expiration time adjustment - days")]
		public int? M3ADCU => GetNullableInt("ADCU");

		/// <summary>
		/// Description: Next item number
		/// FieldName: NHAI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next item number")]
		public string M3NHAI => GetString("NHAI");

		/// <summary>
		/// Description: Next serial number
		/// FieldName: NHSN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next serial number")]
		public string M3NHSN => GetString("NHSN");

		/// <summary>
		/// Description: Origin identity
		/// FieldName: BIRT
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Origin identity")]
		public long? M3BIRT => GetNullableLong("BIRT");

		/// <summary>
		/// Description: Lot control method
		/// FieldName: INDI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot control method")]
		public int? M3INDI => GetNullableInt("INDI");

		/// <summary>
		/// Description: Configuration position
		/// FieldName: CFGL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration position")]
		public string M3CFGL => GetString("CFGL");

		/// <summary>
		/// Description: Location history
		/// FieldName: LOCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location history")]
		public int? M3LOCH => GetNullableInt("LOCH");

		/// <summary>
		/// Description: Complaint
		/// FieldName: DEID
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Complaint")]
		public int? M3DEID => GetNullableInt("DEID");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Attribute number lot
		/// FieldName: ATNB
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number lot")]
		public decimal? M3ATNB => GetNullableDecimal("ATNB");

		/// <summary>
		/// Description: Cross dock type
		/// FieldName: CDTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cross dock type")]
		public int? M3CDTP => GetNullableInt("CDTP");

		/// <summary>
		/// Description: Transaction quantity in alt U/M
		/// FieldName: TRQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction quantity in alt U/M")]
		public decimal? M3TRQA => GetNullableDecimal("TRQA");

		/// <summary>
		/// Description: Inventory accounting
		/// FieldName: STCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting")]
		public int? M3STCD => GetNullableInt("STCD");

		/// <summary>
		/// Description: Delivery note number
		/// FieldName: SUDO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note number")]
		public string M3SUDO => GetString("SUDO");

		/// <summary>
		/// Description: Update INTRASTAT
		/// FieldName: UPIS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update INTRASTAT")]
		public int? M3UPIS => GetNullableInt("UPIS");

		/// <summary>
		/// Description: Package number
		/// FieldName: PANR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package number")]
		public string M3PANR => GetString("PANR");
	}
}
// EOF
