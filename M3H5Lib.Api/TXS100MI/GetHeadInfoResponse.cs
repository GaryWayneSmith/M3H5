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

namespace M3H5Lib.Api.TXS100MI
{
	public partial class GetHeadInfoResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company name
		/// FieldName: CONM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company name")]
		public string M3CONM => GetString("CONM");

		/// <summary>
		/// Description: Company address 1
		/// FieldName: COA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 1")]
		public string M3COA1 => GetString("COA1");

		/// <summary>
		/// Description: Company address 2
		/// FieldName: COA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 2")]
		public string M3COA2 => GetString("COA2");

		/// <summary>
		/// Description: Company address 3
		/// FieldName: COA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 3")]
		public string M3COA3 => GetString("COA3");

		/// <summary>
		/// Description: Company address 4
		/// FieldName: COA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 4")]
		public string M3COA4 => GetString("COA4");

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
		/// Description: Telephone number 1
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 1")]
		public string M3PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Telephone number 2
		/// FieldName: PHN2
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 2")]
		public string M3PHN2 => GetString("PHN2");

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: OVRN
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3OVRN => GetString("OVRN");

		/// <summary>
		/// Description: VAT electronic report number
		/// FieldName: VERN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT electronic report number")]
		public long? M3VERN => GetNullableLong("VERN");

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
		/// Description: Reporting date
		/// FieldName: ERCD
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting date")]
		public DateTime? M3ERCD => GetNullableDateTime("ERCD");

		/// <summary>
		/// Description: Base country
		/// FieldName: FBSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base country")]
		public string M3FBSC => GetString("FBSC");

		/// <summary>
		/// Description: VAT date
		/// FieldName: FVTD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT date")]
		public DateTime? M3FVTD => GetNullableDateTime("FVTD");

		/// <summary>
		/// Description: VAT date
		/// FieldName: TVTD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT date")]
		public DateTime? M3TVTD => GetNullableDateTime("TVTD");

		/// <summary>
		/// Description: Electronic mail address
		/// FieldName: EMA8
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Electronic mail address")]
		public string M3EMA8 => GetString("EMA8");

		/// <summary>
		/// Description: Include already declared transactions
		/// FieldName: PVTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include already declared transactions")]
		public int? M3PVTR => GetNullableInt("PVTR");

		/// <summary>
		/// Description: Electronic VAT report - status
		/// FieldName: EVRS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Electronic VAT report - status")]
		public int? M3EVRS => GetNullableInt("EVRS");

		/// <summary>
		/// Description: Online VAT report
		/// FieldName: OLVR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Online VAT report")]
		public int? M3OLVR => GetNullableInt("OLVR");

		/// <summary>
		/// Description: Report process
		/// FieldName: OLRP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Report process")]
		public int? M3OLRP => GetNullableInt("OLRP");
	}
}
// EOF
