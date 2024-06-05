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

namespace M3H5Lib.Api.CRIT24MI
{
	public partial class GetAddressResponse : M3BaseRecord 
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
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Address type
		/// FieldName: ADTE
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address type")]
		public int? M3ADTE => GetNullableInt("ADTE");

		/// <summary>
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3ADID => GetString("ADID");

		/// <summary>
		/// Description: Stock Transaction Date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock Transaction Date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Printout code
		/// FieldName: PRIA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printout code")]
		public int? M3PRIA => GetNullableInt("PRIA");

		/// <summary>
		/// Description: Address line 1
		/// FieldName: ADR1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 1")]
		public string M3ADR1 => GetString("ADR1");

		/// <summary>
		/// Description: Address line 2
		/// FieldName: ADR2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 2")]
		public string M3ADR2 => GetString("ADR2");

		/// <summary>
		/// Description: Address line 3
		/// FieldName: ADR3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 3")]
		public string M3ADR3 => GetString("ADR3");

		/// <summary>
		/// Description: Address line 4
		/// FieldName: ADR4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 4")]
		public string M3ADR4 => GetString("ADR4");

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
		/// Description: Postal code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3PONO => GetString("PONO");

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
		/// Description: Place
		/// FieldName: EDES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place")]
		public string M3EDES => GetString("EDES");

		/// <summary>
		/// Description: Geographical code
		/// FieldName: GEOC
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographical code")]
		public int? M3GEOC => GetNullableInt("GEOC");

		/// <summary>
		/// Description: Tax code customer/address
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code customer/address")]
		public string M3TAXC => GetString("TAXC");

		/// <summary>
		/// Description: State
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("State")]
		public string M3ECAR => GetString("ECAR");

		/// <summary>
		/// Description: City
		/// FieldName: TOWN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("City")]
		public string M3TOWN => GetString("TOWN");

		/// <summary>
		/// Description: Planning node
		/// FieldName: PNOD
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning node")]
		public string M3PNOD => GetString("PNOD");
	}
}
// EOF
