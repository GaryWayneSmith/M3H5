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
	public partial class GetCustomerResponse : M3BaseRecord 
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
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Customer address 1
		/// FieldName: CUA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 1")]
		public string M3CUA1 => GetString("CUA1");

		/// <summary>
		/// Description: Customer address 2
		/// FieldName: CUA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 2")]
		public string M3CUA2 => GetString("CUA2");

		/// <summary>
		/// Description: Customer address 3
		/// FieldName: CUA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 3")]
		public string M3CUA3 => GetString("CUA3");

		/// <summary>
		/// Description: Customer address 4
		/// FieldName: CUA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 4")]
		public string M3CUA4 => GetString("CUA4");

		/// <summary>
		/// Description: Telephone
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone")]
		public string M3PHNO => GetString("PHNO");

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
		/// Description: VAT registration number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3VRNO => GetString("VRNO");

		/// <summary>
		/// Description: Inscr Estadual
		/// FieldName: XIES
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inscr Estadual")]
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
		/// Description: Juridica / Fisica
		/// FieldName: JUFI
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Juridica / Fisica")]
		public string M3JUFI => GetString("JUFI");

		/// <summary>
		/// Description: SUFRAMA Reg no.
		/// FieldName: SURE
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SUFRAMA Reg no.")]
		public string M3SURE => GetString("SURE");

		/// <summary>
		/// Description: Federation unit
		/// FieldName: FEDA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Federation unit")]
		public string M3FEDA => GetString("FEDA");

		/// <summary>
		/// Description: Internal CFOP Code
		/// FieldName: ICFO
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal CFOP Code")]
		public string M3ICFO => GetString("ICFO");

		/// <summary>
		/// Description: Final consumer
		/// FieldName: XFIC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Final consumer")]
		public int? M3XFIC => GetNullableInt("XFIC");

		/// <summary>
		/// Description: Contribuinte
		/// FieldName: XCON
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Contribuinte")]
		public string M3XCON => GetString("XCON");

		/// <summary>
		/// Description: Forwarding agent
		/// FieldName: FWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarding agent")]
		public string M3FWNO => GetString("FWNO");

		/// <summary>
		/// Description: Supplier Invoice Line
		/// FieldName: CEEP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier Invoice Line")]
		public string M3CEEP => GetString("CEEP");

		/// <summary>
		/// Description: CEE Instruction
		/// FieldName: CEEI
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CEE Instruction")]
		public string M3CEEI => GetString("CEEI");

		/// <summary>
		/// Description: CEE Interest %
		/// FieldName: CEER
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CEE Interest %")]
		public int? M3CEER => GetNullableInt("CEER");

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
		/// Description: IBGE City code
		/// FieldName: IBCD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IBGE City code")]
		public string M3IBCD => GetString("IBCD");

		/// <summary>
		/// Description: City tax registration
		/// FieldName: IMUN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("City tax registration")]
		public string M3IMUN => GetString("IMUN");

		/// <summary>
		/// Description: CNAE code
		/// FieldName: CNAE
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CNAE code")]
		public string M3CNAE => GetString("CNAE");
	}
}
// EOF
