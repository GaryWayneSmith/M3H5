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

namespace M3H5Lib.Api.XBE622MI
{
	public partial class GetSupplAddressResponse : M3BaseRecord 
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
		/// Description: Address Type
		/// FieldName: ADTE
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address Type")]
		public int? M3_ADTE => GetNullableInt("ADTE");

		/// <summary>
		/// Description: Address Number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address Number")]
		public string M3_ADID => GetString("ADID");

		/// <summary>
		/// Description: Start Date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start Date")]
		public DateTime? M3_STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Supplier Name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier Name")]
		public string M3_SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Printout Code
		/// FieldName: PRIA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printout Code")]
		public int? M3_PRIA => GetNullableInt("PRIA");

		/// <summary>
		/// Description: Address 1
		/// FieldName: ADR1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address 1")]
		public string M3_ADR1 => GetString("ADR1");

		/// <summary>
		/// Description: Address 2
		/// FieldName: ADR2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address 2")]
		public string M3_ADR2 => GetString("ADR2");

		/// <summary>
		/// Description: Address 3
		/// FieldName: ADR3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address 3")]
		public string M3_ADR3 => GetString("ADR3");

		/// <summary>
		/// Description: Address 4
		/// FieldName: ADR4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address 4")]
		public string M3_ADR4 => GetString("ADR4");

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
		/// Description: Postal Code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal Code")]
		public string M3_PONO => GetString("PONO");

		/// <summary>
		/// Description: Via Address
		/// FieldName: ADVI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Address")]
		public string M3_ADVI => GetString("ADVI");

		/// <summary>
		/// Description: Place
		/// FieldName: EDES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place")]
		public string M3_EDES => GetString("EDES");

		/// <summary>
		/// Description: Geographical Code
		/// FieldName: GEOC
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographical Code")]
		public int? M3_GEOC => GetNullableInt("GEOC");

		/// <summary>
		/// Description: Tax Code Customer/Address
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax Code Customer/Address")]
		public string M3_TAXC => GetString("TAXC");

		/// <summary>
		/// Description: Area/State
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Area/State")]
		public string M3_ECAR => GetString("ECAR");
	}
}
// EOF
