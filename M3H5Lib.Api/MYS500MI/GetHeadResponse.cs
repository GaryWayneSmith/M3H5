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

namespace M3H5Lib.Api.MYS500MI
{
	public partial class GetHeadResponse : M3BaseRecord 
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
		/// Description: Message direction
		/// FieldName: E0IO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message direction")]
		public string M3E0IO => GetString("E0IO");

		/// <summary>
		/// Description: Direction
		/// FieldName: INOU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Direction")]
		public int? M3INOU => GetNullableInt("INOU");

		/// <summary>
		/// Description: TEI Transfer ID
		/// FieldName: TINR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TEI Transfer ID")]
		public string M3TINR => GetString("TINR");

		/// <summary>
		/// Description: TEI partner
		/// FieldName: TIPI
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TEI partner")]
		public string M3TIPI => GetString("TIPI");

		/// <summary>
		/// Description: Event
		/// FieldName: EVNT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event")]
		public string M3EVNT => GetString("EVNT");

		/// <summary>
		/// Description: Event key object 1
		/// FieldName: EVO1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event key object 1")]
		public string M3EVO1 => GetString("EVO1");

		/// <summary>
		/// Description: Event key object 2
		/// FieldName: EVO2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event key object 2")]
		public string M3EVO2 => GetString("EVO2");

		/// <summary>
		/// Description: Event key object 3
		/// FieldName: EVO3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event key object 3")]
		public string M3EVO3 => GetString("EVO3");

		/// <summary>
		/// Description: Event key 1
		/// FieldName: EVK1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event key 1")]
		public string M3EVK1 => GetString("EVK1");

		/// <summary>
		/// Description: Event key 2
		/// FieldName: EVK2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event key 2")]
		public string M3EVK2 => GetString("EVK2");

		/// <summary>
		/// Description: Event key 3
		/// FieldName: EVK3
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event key 3")]
		public string M3EVK3 => GetString("EVK3");

		/// <summary>
		/// Description: Detail type
		/// FieldName: DETP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detail type")]
		public int? M3DETP => GetNullableInt("DETP");

		/// <summary>
		/// Description: Document number
		/// FieldName: DONR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document number")]
		public string M3DONR => GetString("DONR");

		/// <summary>
		/// Description: Document variant
		/// FieldName: DOVA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document variant")]
		public string M3DOVA => GetString("DOVA");

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
		/// Description: TEI Transfer origin
		/// FieldName: TORI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TEI Transfer origin")]
		public int? M3TORI => GetNullableInt("TORI");

		/// <summary>
		/// Description: Complementary transaction
		/// FieldName: CTRA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Complementary transaction")]
		public int? M3CTRA => GetNullableInt("CTRA");

		/// <summary>
		/// Description: Allow duplicate
		/// FieldName: DUDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow duplicate")]
		public int? M3DUDE => GetNullableInt("DUDE");

		/// <summary>
		/// Description: Send TEI transfers automatically
		/// FieldName: AUTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Send TEI transfers automatically")]
		public int? M3AUTR => GetNullableInt("AUTR");

		/// <summary>
		/// Description: Export/Import
		/// FieldName: EXIM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Export/Import")]
		public int? M3EXIM => GetNullableInt("EXIM");

		/// <summary>
		/// Description: Transaction alias external ID
		/// FieldName: TAEI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction alias external ID")]
		public string M3TAEI => GetString("TAEI");

		/// <summary>
		/// Description: Country
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3CSCD => GetString("CSCD");

		/// <summary>
		/// Description: Job number
		/// FieldName: BJNO
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job number")]
		public string M3BJNO => GetString("BJNO");

		/// <summary>
		/// Description: Via address
		/// FieldName: ADVI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via address")]
		public string M3ADVI => GetString("ADVI");

		/// <summary>
		/// Description: Report version
		/// FieldName: LIVR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Report version")]
		public string M3LIVR => GetString("LIVR");

		/// <summary>
		/// Description: Report type
		/// FieldName: RPTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Report type")]
		public int? M3RPTP => GetNullableInt("RPTP");

		/// <summary>
		/// Description: Selection object 1
		/// FieldName: SE01
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection object 1")]
		public string M3SE01 => GetString("SE01");

		/// <summary>
		/// Description: Selection from value 1
		/// FieldName: SFV1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection from value 1")]
		public string M3SFV1 => GetString("SFV1");

		/// <summary>
		/// Description: Selection to value 1
		/// FieldName: STV1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection to value 1")]
		public string M3STV1 => GetString("STV1");

		/// <summary>
		/// Description: Selection object 1
		/// FieldName: SE02
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection object 1")]
		public string M3SE02 => GetString("SE02");

		/// <summary>
		/// Description: Selection from value 2
		/// FieldName: SFV2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection from value 2")]
		public string M3SFV2 => GetString("SFV2");

		/// <summary>
		/// Description: Selection to value 2
		/// FieldName: STV2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection to value 2")]
		public string M3STV2 => GetString("STV2");

		/// <summary>
		/// Description: Selection object 1
		/// FieldName: SE03
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection object 1")]
		public string M3SE03 => GetString("SE03");

		/// <summary>
		/// Description: Selection from value 3
		/// FieldName: SFV3
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection from value 3")]
		public string M3SFV3 => GetString("SFV3");

		/// <summary>
		/// Description: Selection to value 3
		/// FieldName: STV3
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection to value 3")]
		public string M3STV3 => GetString("STV3");

		/// <summary>
		/// Description: Selection object 1
		/// FieldName: SE04
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection object 1")]
		public string M3SE04 => GetString("SE04");

		/// <summary>
		/// Description: Selection from value 4
		/// FieldName: SFV4
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection from value 4")]
		public string M3SFV4 => GetString("SFV4");

		/// <summary>
		/// Description: Selection to value 4
		/// FieldName: STV4
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection to value 4")]
		public string M3STV4 => GetString("STV4");

		/// <summary>
		/// Description: Sorting object 1
		/// FieldName: SOR1
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting object 1")]
		public string M3SOR1 => GetString("SOR1");

		/// <summary>
		/// Description: Sorting object 2
		/// FieldName: SOR2
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting object 2")]
		public string M3SOR2 => GetString("SOR2");

		/// <summary>
		/// Description: Sorting object 3
		/// FieldName: SOR3
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting object 3")]
		public string M3SOR3 => GetString("SOR3");

		/// <summary>
		/// Description: Selection break level 1
		/// FieldName: SBL1
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection break level 1")]
		public string M3SBL1 => GetString("SBL1");

		/// <summary>
		/// Description: Selection break level 2
		/// FieldName: SBL2
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection break level 2")]
		public string M3SBL2 => GetString("SBL2");

		/// <summary>
		/// Description: Selection break level 3
		/// FieldName: SBL3
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection break level 3")]
		public string M3SBL3 => GetString("SBL3");

		/// <summary>
		/// Description: Selection break value 1
		/// FieldName: SBV1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection break value 1")]
		public string M3SBV1 => GetString("SBV1");

		/// <summary>
		/// Description: Selection break value 2
		/// FieldName: SBV2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection break value 2")]
		public string M3SBV2 => GetString("SBV2");

		/// <summary>
		/// Description: Selection break value 3
		/// FieldName: SBV3
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection break value 3")]
		public string M3SBV3 => GetString("SBV3");

		/// <summary>
		/// Description: Fixed break - Place of loading
		/// FieldName: FBSD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed break - Place of loading")]
		public string M3FBSD => GetString("FBSD");

		/// <summary>
		/// Description: Fixed break - via address
		/// FieldName: FBAD
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed break - via address")]
		public string M3FBAD => GetString("FBAD");

		/// <summary>
		/// Description: Fixed break - warehouse
		/// FieldName: FBWH
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed break - warehouse")]
		public string M3FBWH => GetString("FBWH");

		/// <summary>
		/// Description: Transaction reference 1
		/// FieldName: TRR1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction reference 1")]
		public string M3TRR1 => GetString("TRR1");

		/// <summary>
		/// Description: Transaction reference 2
		/// FieldName: TRR2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction reference 2")]
		public string M3TRR2 => GetString("TRR2");

		/// <summary>
		/// Description: Date generated
		/// FieldName: GEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date generated")]
		public DateTime? M3GEDT => GetNullableDateTime("GEDT");

		/// <summary>
		/// Description: Time generated
		/// FieldName: GETM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time generated")]
		public int? M3GETM => GetNullableInt("GETM");

		/// <summary>
		/// Description: Message broker date
		/// FieldName: MBDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message broker date")]
		public DateTime? M3MBDT => GetNullableDateTime("MBDT");

		/// <summary>
		/// Description: Message broker time
		/// FieldName: MBTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message broker time")]
		public int? M3MBTM => GetNullableInt("MBTM");

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
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");
	}
}
// EOF
