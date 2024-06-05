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

namespace M3H5Lib.Api.XBR001MI
{
	public partial class GetCOAddressResponse : M3BaseRecord 
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
		/// Description: Customer order number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order number")]
		public string M3ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Address type
		/// FieldName: ADRT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address type")]
		public int? M3ADRT => GetNullableInt("ADRT");

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
		/// Description: City tax registration number
		/// FieldName: IMUN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("City tax registration number")]
		public string M3IMUN => GetString("IMUN");

		/// <summary>
		/// Description: State registration number
		/// FieldName: XIES
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("State registration number")]
		public string M3XIES => GetString("XIES");

		/// <summary>
		/// Description: CNPJ / CPF
		/// FieldName: CNPJ
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CNPJ / CPF")]
		public decimal? M3CNPJ => GetNullableDecimal("CNPJ");

		/// <summary>
		/// Description: Postal code
		/// FieldName: PJUR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3PJUR => GetString("PJUR");

		/// <summary>
		/// Description: Federation Unit
		/// FieldName: FEDA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Federation Unit")]
		public string M3FEDA => GetString("FEDA");

		/// <summary>
		/// Description: IBGE City code
		/// FieldName: IBCD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IBGE City code")]
		public string M3IBCD => GetString("IBCD");
	}
}
// EOF
