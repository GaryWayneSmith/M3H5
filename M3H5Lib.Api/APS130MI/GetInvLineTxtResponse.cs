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

namespace M3H5Lib.Api.APS130MI
{
	public partial class GetInvLineTxtResponse : M3BaseRecord 
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
		/// Description: Payment proposal
		/// FieldName: PRPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment proposal")]
		public long? M3PRPN => GetNullableLong("PRPN");

		/// <summary>
		/// Description: Payment order
		/// FieldName: PYON
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment order")]
		public int? M3PYON => GetNullableInt("PYON");

		/// <summary>
		/// Description: Payee
		/// FieldName: SPYN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payee")]
		public string M3SPYN => GetString("SPYN");

		/// <summary>
		/// Description: Original division
		/// FieldName: ODIV
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original division")]
		public string M3ODIV => GetString("ODIV");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Supplier customer number
		/// FieldName: SCNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier customer number")]
		public string M3SCNO => GetString("SCNO");

		/// <summary>
		/// Description: Supplier invoice number
		/// FieldName: SINO
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier invoice number")]
		public string M3SINO => GetString("SINO");

		/// <summary>
		/// Description: Invoice year
		/// FieldName: INYR
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice year")]
		public int? M3INYR => GetNullableInt("INYR");

		/// <summary>
		/// Description: Voucher text
		/// FieldName: VTXT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher text")]
		public string M3VTXT => GetString("VTXT");

		/// <summary>
		/// Description: External text 1
		/// FieldName: TX51
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External text 1")]
		public string M3TX51 => GetString("TX51");

		/// <summary>
		/// Description: External text 2
		/// FieldName: TX52
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External text 2")]
		public string M3TX52 => GetString("TX52");

		/// <summary>
		/// Description: External text 3
		/// FieldName: TX53
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External text 3")]
		public string M3TX53 => GetString("TX53");

		/// <summary>
		/// Description: External text 4
		/// FieldName: TX54
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External text 4")]
		public string M3TX54 => GetString("TX54");

		/// <summary>
		/// Description: Detailed description 1-3
		/// FieldName: AW10
		/// FieldType: A
		/// Length: 140
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detailed description 1-3")]
		public string M3AW10 => GetString("AW10");

		/// <summary>
		/// Description: External text 5
		/// FieldName: TX55
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External text 5")]
		public string M3TX55 => GetString("TX55");
	}
}
// EOF
