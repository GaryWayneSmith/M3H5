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

namespace M3H5Lib.Api.CRS610MI
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
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3_LNCD => GetString("LNCD");

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
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3_CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Customer address 1
		/// FieldName: CUA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 1")]
		public string M3_CUA1 => GetString("CUA1");

		/// <summary>
		/// Description: Customer address 2
		/// FieldName: CUA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 2")]
		public string M3_CUA2 => GetString("CUA2");

		/// <summary>
		/// Description: Customer address 3
		/// FieldName: CUA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 3")]
		public string M3_CUA3 => GetString("CUA3");

		/// <summary>
		/// Description: Customer address 4
		/// FieldName: CUA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 4")]
		public string M3_CUA4 => GetString("CUA4");

		/// <summary>
		/// Description: Postal code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3_PONO => GetString("PONO");

		/// <summary>
		/// Description: Telephone number 1
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 1")]
		public string M3_PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Telephone number 2
		/// FieldName: PHN2
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 2")]
		public string M3_PHN2 => GetString("PHN2");

		/// <summary>
		/// Description: Facsimile number
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimile number")]
		public string M3_TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Customer type
		/// FieldName: CUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer type")]
		public int? M3_CUTP => GetNullableInt("CUTP");

		/// <summary>
		/// Description: Search key
		/// FieldName: ALCU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search key")]
		public string M3_ALCU => GetString("ALCU");

		/// <summary>
		/// Description: Your reference 1
		/// FieldName: YREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference 1")]
		public string M3_YREF => GetString("YREF");

		/// <summary>
		/// Description: Your reference 2
		/// FieldName: YRE2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference 2")]
		public string M3_YRE2 => GetString("YRE2");

		/// <summary>
		/// Description: E-mail address
		/// FieldName: MAIL
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("E-mail address")]
		public string M3_MAIL => GetString("MAIL");

		/// <summary>
		/// Description: Country code
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country code")]
		public string M3_CSCD => GetString("CSCD");

		/// <summary>
		/// Description: Area/state
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Area/state")]
		public string M3_ECAR => GetString("ECAR");

		/// <summary>
		/// Description: free field 1
		/// FieldName: CFC1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("free field 1")]
		public string M3_CFC1 => GetString("CFC1");

		/// <summary>
		/// Description: Free field 2
		/// FieldName: CFC2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 2")]
		public decimal? M3_CFC2 => GetNullableDecimal("CFC2");

		/// <summary>
		/// Description: Free field 3
		/// FieldName: CFC3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 3")]
		public string M3_CFC3 => GetString("CFC3");

		/// <summary>
		/// Description: Free field 4
		/// FieldName: CFC4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 4")]
		public string M3_CFC4 => GetString("CFC4");

		/// <summary>
		/// Description: Free field 5
		/// FieldName: CFC5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 5")]
		public string M3_CFC5 => GetString("CFC5");

		/// <summary>
		/// Description: Free field 6
		/// FieldName: CFC6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 6")]
		public string M3_CFC6 => GetString("CFC6");

		/// <summary>
		/// Description: Free field 7
		/// FieldName: CFC7
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 7")]
		public decimal? M3_CFC7 => GetNullableDecimal("CFC7");

		/// <summary>
		/// Description: Free field 8
		/// FieldName: CFC8
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 8")]
		public string M3_CFC8 => GetString("CFC8");

		/// <summary>
		/// Description: Free field 9
		/// FieldName: CFC9
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 9")]
		public string M3_CFC9 => GetString("CFC9");

		/// <summary>
		/// Description: Free field 10
		/// FieldName: CFC0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 10")]
		public string M3_CFC0 => GetString("CFC0");

		/// <summary>
		/// Description: SMS id
		/// FieldName: CESA
		/// FieldType: A
		/// Length: 32
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SMS id")]
		public string M3_CESA => GetString("CESA");

		/// <summary>
		/// Description: Customer status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Change date for customer
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date for customer")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Search path  -  payer
		/// FieldName: PYOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search path  -  payer")]
		public int? M3_PYOP => GetNullableInt("PYOP");

		/// <summary>
		/// Description: City
		/// FieldName: TOWN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("City")]
		public string M3_TOWN => GetString("TOWN");

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
		/// Description: Customer order number mandatory
		/// FieldName: MCOS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order number mandatory")]
		public int? M3_MCOS => GetNullableInt("MCOS");

		/// <summary>
		/// Description: County ID
		/// FieldName: FRCO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County ID")]
		public string M3_FRCO => GetString("FRCO");

		/// <summary>
		/// Description: Our supplier number at customer
		/// FieldName: CUSU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our supplier number at customer")]
		public string M3_CUSU => GetString("CUSU");

		/// <summary>
		/// Description: EAN location code
		/// FieldName: EALO
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EAN location code")]
		public decimal? M3_EALO => GetNullableDecimal("EALO");

		/// <summary>
		/// Description: Rail station
		/// FieldName: RASN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rail station")]
		public string M3_RASN => GetString("RASN");

		/// <summary>
		/// Description: Standard point location code
		/// FieldName: SPLE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard point location code")]
		public string M3_SPLE => GetString("SPLE");

		/// <summary>
		/// Description: User
		/// FieldName: LSID
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3_LSID => GetString("LSID");

		/// <summary>
		/// Description: Address
		/// FieldName: LSAD
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address")]
		public string M3_LSAD => GetString("LSAD");

		/// <summary>
		/// Description: Valid media
		/// FieldName: MEAL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid media")]
		public string M3_MEAL => GetString("MEAL");

		/// <summary>
		/// Description: Harbor or airport
		/// FieldName: HAFE
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harbor or airport")]
		public string M3_HAFE => GetString("HAFE");

		/// <summary>
		/// Description: Text Identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text Identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Entry date for customer
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date for customer")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: County
		/// FieldName: TXCO
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County")]
		public string M3_TXCO => GetString("TXCO");

		/// <summary>
		/// Description: Geographical code
		/// FieldName: GEOC
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographical code")]
		public int? M3_GEOC => GetNullableInt("GEOC");
	}
}
// EOF
