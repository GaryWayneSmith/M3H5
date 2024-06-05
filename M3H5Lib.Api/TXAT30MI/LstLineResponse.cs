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

namespace M3H5Lib.Api.TXAT30MI
{
	public partial class LstLineResponse : M3BaseRecord 
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
		/// Description: Report reference line
		/// FieldName: RRLN
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Report reference line")]
		public int? M3_RRLN => GetNullableInt("RRLN");

		/// <summary>
		/// Description: Customs statistical number
		/// FieldName: CSNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs statistical number")]
		public string M3_CSNO => GetString("CSNO");

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
		/// Description: Country code ISO
		/// FieldName: IISO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country code ISO")]
		public string M3_IISO => GetString("IISO");

		/// <summary>
		/// Description: Fiscal value
		/// FieldName: FSVL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fiscal value")]
		public decimal? M3_FSVL => GetNullableDecimal("FSVL");

		/// <summary>
		/// Description: Fiscal currency code
		/// FieldName: FSCU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fiscal currency code")]
		public string M3_FSCU => GetString("FSCU");

		/// <summary>
		/// Description: Business type - trade statistics (TST)
		/// FieldName: VRCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business type - trade statistics (TST)")]
		public string M3_VRCD => GetString("VRCD");

		/// <summary>
		/// Description: Statistic value
		/// FieldName: SSVL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistic value")]
		public decimal? M3_SSVL => GetNullableDecimal("SSVL");

		/// <summary>
		/// Description: Net weight
		/// FieldName: ECNW
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight")]
		public decimal? M3_ECNW => GetNullableDecimal("ECNW");

		/// <summary>
		/// Description: Supplementary U/M
		/// FieldName: SUPL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplementary U/M")]
		public string M3_SUPL => GetString("SUPL");

		/// <summary>
		/// Description: Labor code - trade statistics (TST)
		/// FieldName: ECLC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor code - trade statistics (TST)")]
		public string M3_ECLC => GetString("ECLC");

		/// <summary>
		/// Description: Delivery terms - INTRASTAT
		/// FieldName: ECDT
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms - INTRASTAT")]
		public string M3_ECDT => GetString("ECDT");

		/// <summary>
		/// Description: Transport method - trade stat (TST)
		/// FieldName: VRDL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport method - trade stat (TST)")]
		public int? M3_VRDL => GetNullableInt("VRDL");

		/// <summary>
		/// Description: Country of origin - trade stat (TST)
		/// FieldName: EUOR
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country of origin - trade stat (TST)")]
		public int? M3_EUOR => GetNullableInt("EUOR");

		/// <summary>
		/// Description: Country of origin - ISO code
		/// FieldName: IIS2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country of origin - ISO code")]
		public string M3_IIS2 => GetString("IIS2");

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
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Customs quantity
		/// FieldName: ECQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs quantity")]
		public decimal? M3_ECQT => GetNullableDecimal("ECQT");

		/// <summary>
		/// Description: Information type
		/// FieldName: ECTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information type")]
		public int? M3_ECTP => GetNullableInt("ECTP");

		/// <summary>
		/// Description: Country of origin
		/// FieldName: ORCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country of origin")]
		public string M3_ORCO => GetString("ORCO");

		/// <summary>
		/// Description: Description Intrastat AT
		/// FieldName: XDES
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description Intrastat AT")]
		public string M3_XDES => GetString("XDES");

		/// <summary>
		/// Description: Procedure Intrastat AT
		/// FieldName: XPRO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Procedure Intrastat AT")]
		public string M3_XPRO => GetString("XPRO");
	}
}
// EOF
