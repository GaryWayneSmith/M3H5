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

namespace M3H5Lib.Api.CRS275MI
{
	public partial class LstLineChrgHeadResponse : M3BaseRecord 
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
		/// Description: Charge
		/// FieldName: CRID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge")]
		public string M3CRID => GetString("CRID");

		/// <summary>
		/// Description: Cost distribution key 1
		/// FieldName: PC01
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost distribution key 1")]
		public string M3PC01 => GetString("PC01");

		/// <summary>
		/// Description: Cost distribution key 2
		/// FieldName: PC02
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost distribution key 2")]
		public string M3PC02 => GetString("PC02");

		/// <summary>
		/// Description: Cost distribution key 3
		/// FieldName: PC03
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost distribution key 3")]
		public string M3PC03 => GetString("PC03");

		/// <summary>
		/// Description: Internal charge
		/// FieldName: CRTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal charge")]
		public int? M3CRTY => GetNullableInt("CRTY");

		/// <summary>
		/// Description: Debit frequency
		/// FieldName: HACD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit frequency")]
		public int? M3HACD => GetNullableInt("HACD");

		/// <summary>
		/// Description: Description language 0
		/// FieldName: CRD0
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description language 0")]
		public string M3CRD0 => GetString("CRD0");

		/// <summary>
		/// Description: Calculation method
		/// FieldName: CRME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation method")]
		public int? M3CRME => GetNullableInt("CRME");

		/// <summary>
		/// Description: Charge U/M
		/// FieldName: CHUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge U/M")]
		public string M3CHUN => GetString("CHUN");

		/// <summary>
		/// Description: Decimals places - charge base
		/// FieldName: CHDC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimals places - charge base")]
		public int? M3CHDC => GetNullableInt("CHDC");

		/// <summary>
		/// Description: Presentation code - item charges
		/// FieldName: CHPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Presentation code - item charges")]
		public int? M3CHPR => GetNullableInt("CHPR");

		/// <summary>
		/// Description: Included in cost total 1
		/// FieldName: CRN1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 1")]
		public int? M3CRN1 => GetNullableInt("CRN1");

		/// <summary>
		/// Description: Included in cost total 2
		/// FieldName: CRN2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 2")]
		public int? M3CRN2 => GetNullableInt("CRN2");

		/// <summary>
		/// Description: Included in cost total 3
		/// FieldName: CRN3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 3")]
		public int? M3CRN3 => GetNullableInt("CRN3");

		/// <summary>
		/// Description: Included in cost total 4
		/// FieldName: CRN4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 4")]
		public int? M3CRN4 => GetNullableInt("CRN4");

		/// <summary>
		/// Description: Included in cost total 5
		/// FieldName: CRN5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 5")]
		public int? M3CRN5 => GetNullableInt("CRN5");

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
		/// Description: Tax code
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code")]
		public string M3TAXC => GetString("TAXC");

		/// <summary>
		/// Description: Item dependent sales tax
		/// FieldName: TAXI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item dependent sales tax")]
		public int? M3TAXI => GetNullableInt("TAXI");
	}
}
// EOF
