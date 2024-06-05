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

namespace M3H5Lib.Api.XBR001MI
{
	public partial class GetDivisionResponse : M3BaseRecord 
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
		/// Description: Company name
		/// FieldName: CONM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company name")]
		public string M3_CONM => GetString("CONM");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Company address 1
		/// FieldName: COA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 1")]
		public string M3_COA1 => GetString("COA1");

		/// <summary>
		/// Description: Company address 2
		/// FieldName: COA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 2")]
		public string M3_COA2 => GetString("COA2");

		/// <summary>
		/// Description: Company address 3
		/// FieldName: COA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 3")]
		public string M3_COA3 => GetString("COA3");

		/// <summary>
		/// Description: Company address 4
		/// FieldName: COA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 4")]
		public string M3_COA4 => GetString("COA4");

		/// <summary>
		/// Description: Telephone
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone")]
		public string M3_PHNO => GetString("PHNO");

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
		/// Description: Local currency
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency")]
		public string M3_LOCD => GetString("LOCD");

		/// <summary>
		/// Description: Tax declaration number
		/// FieldName: VRNL
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax declaration number")]
		public string M3_VRNL => GetString("VRNL");

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
		/// Description: Federation unit
		/// FieldName: FEDA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Federation unit")]
		public string M3_FEDA => GetString("FEDA");

		/// <summary>
		/// Description: Inscr Estadual
		/// FieldName: IEST
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inscr Estadual")]
		public string M3_IEST => GetString("IEST");

		/// <summary>
		/// Description: CNPJ / CPF
		/// FieldName: CNPJ
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CNPJ / CPF")]
		public decimal? M3_CNPJ => GetNullableDecimal("CNPJ");

		/// <summary>
		/// Description: Inscr Municipal
		/// FieldName: IMUN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inscr Municipal")]
		public string M3_IMUN => GetString("IMUN");

		/// <summary>
		/// Description: % IRRF
		/// FieldName: IRRF
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% IRRF")]
		public int? M3_IRRF => GetNullableInt("IRRF");

		/// <summary>
		/// Description: % ISS
		/// FieldName: CISS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% ISS")]
		public int? M3_CISS => GetNullableInt("CISS");

		/// <summary>
		/// Description: % COFINS
		/// FieldName: COFI
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% COFINS")]
		public int? M3_COFI => GetNullableInt("COFI");

		/// <summary>
		/// Description: % PIS
		/// FieldName: XPI1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% PIS")]
		public int? M3_XPI1 => GetNullableInt("XPI1");

		/// <summary>
		/// Description: % Ret CSLL
		/// FieldName: RCSL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Ret CSLL")]
		public int? M3_RCSL => GetNullableInt("RCSL");

		/// <summary>
		/// Description: % Ret PIS
		/// FieldName: RPIS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Ret PIS")]
		public int? M3_RPIS => GetNullableInt("RPIS");

		/// <summary>
		/// Description: % Ret COFINS
		/// FieldName: RCOF
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Ret COFINS")]
		public int? M3_RCOF => GetNullableInt("RCOF");

		/// <summary>
		/// Description: NF-e environment
		/// FieldName: NFEE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NF-e environment")]
		public int? M3_NFEE => GetNullableInt("NFEE");

		/// <summary>
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3_ADID => GetString("ADID");

		/// <summary>
		/// Description: IBGE City code
		/// FieldName: IBCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IBGE City code")]
		public int? M3_IBCD => GetNullableInt("IBCD");

		/// <summary>
		/// Description: CNAE code
		/// FieldName: CNAE
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CNAE code")]
		public string M3_CNAE => GetString("CNAE");

		/// <summary>
		/// Description: Tributary mode
		/// FieldName: CRTC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tributary mode")]
		public int? M3_CRTC => GetNullableInt("CRTC");

		/// <summary>
		/// Description: Issue type
		/// FieldName: NETE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue type")]
		public string M3_NETE => GetString("NETE");
	}
}
// EOF
