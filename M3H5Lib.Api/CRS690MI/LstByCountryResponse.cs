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

namespace M3H5Lib.Api.CRS690MI
{
	public partial class LstByCountryResponse : M3BaseRecord 
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
		/// Description: Bank number
		/// FieldName: BKNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank number")]
		public string M3_BKNO => GetString("BKNO");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Bank name
		/// FieldName: BKNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank name")]
		public string M3_BKNM => GetString("BKNM");

		/// <summary>
		/// Description: Search key
		/// FieldName: ALBK
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search key")]
		public string M3_ALBK => GetString("ALBK");

		/// <summary>
		/// Description: Bank address 1
		/// FieldName: BKA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 1")]
		public string M3_BKA1 => GetString("BKA1");

		/// <summary>
		/// Description: Bank address 2
		/// FieldName: BKA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 2")]
		public string M3_BKA2 => GetString("BKA2");

		/// <summary>
		/// Description: Bank address 3
		/// FieldName: BKA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 3")]
		public string M3_BKA3 => GetString("BKA3");

		/// <summary>
		/// Description: Bank address 4
		/// FieldName: BKA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 4")]
		public string M3_BKA4 => GetString("BKA4");

		/// <summary>
		/// Description: Country
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3_CSCD => GetString("CSCD");

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
		/// Description: Facsimile transmission number
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimile transmission number")]
		public string M3_TFNO => GetString("TFNO");

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
		/// Description: Our reference
		/// FieldName: OREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our reference")]
		public string M3_OREF => GetString("OREF");

		/// <summary>
		/// Description: Fixed discount charge
		/// FieldName: FCDC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed discount charge")]
		public decimal? M3_FCDC => GetNullableDecimal("FCDC");

		/// <summary>
		/// Description: Discount rate
		/// FieldName: BIDC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount rate")]
		public int? M3_BIDC => GetNullableInt("BIDC");

		/// <summary>
		/// Description: Minimum number of days for interest
		/// FieldName: BMDI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum number of days for interest")]
		public int? M3_BMDI => GetNullableInt("BMDI");

		/// <summary>
		/// Description: Fixed collection charges
		/// FieldName: FCCO
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed collection charges")]
		public decimal? M3_FCCO => GetNullableDecimal("FCCO");

		/// <summary>
		/// Description: Bank group
		/// FieldName: BAGR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank group")]
		public string M3_BAGR => GetString("BAGR");

		/// <summary>
		/// Description: Electronic mail address
		/// FieldName: EMAL
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Electronic mail address")]
		public string M3_EMAL => GetString("EMAL");

		/// <summary>
		/// Description: Web site address
		/// FieldName: WESI
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Web site address")]
		public string M3_WESI => GetString("WESI");

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
		/// Description: Swift code
		/// FieldName: SWIC
		/// FieldType: A
		/// Length: 34
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Swift code")]
		public string M3_SWIC => GetString("SWIC");

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3_VRNO => GetString("VRNO");

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
		/// Description: County ID
		/// FieldName: FRCO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County ID")]
		public string M3_FRCO => GetString("FRCO");
	}
}
// EOF
