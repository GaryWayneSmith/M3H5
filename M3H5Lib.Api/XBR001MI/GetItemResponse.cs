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
	public partial class GetItemResponse : M3BaseRecord 
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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Item name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Description 2
		/// FieldName: FUDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 2")]
		public string M3FUDS => GetString("FUDS");

		/// <summary>
		/// Description: Classificacao Fiscal
		/// FieldName: CFIS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Classificacao Fiscal")]
		public string M3CFIS => GetString("CFIS");

		/// <summary>
		/// Description: % IPI
		/// FieldName: IIPI
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% IPI")]
		public int? M3IIPI => GetNullableInt("IIPI");

		/// <summary>
		/// Description: % Red/Incr Base IPI
		/// FieldName: CIPI
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Red/Incr Base IPI")]
		public int? M3CIPI => GetNullableInt("CIPI");

		/// <summary>
		/// Description: % PIS
		/// FieldName: XPI1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% PIS")]
		public int? M3XPI1 => GetNullableInt("XPI1");

		/// <summary>
		/// Description: PIS from Item
		/// FieldName: CPIS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS from Item")]
		public string M3CPIS => GetString("CPIS");

		/// <summary>
		/// Description: % Ret PIS
		/// FieldName: RPIS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Ret PIS")]
		public int? M3RPIS => GetNullableInt("RPIS");

		/// <summary>
		/// Description: % COFINS
		/// FieldName: COFI
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% COFINS")]
		public int? M3COFI => GetNullableInt("COFI");

		/// <summary>
		/// Description: COFINS from Item
		/// FieldName: XCCO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS from Item")]
		public string M3XCCO => GetString("XCCO");

		/// <summary>
		/// Description: % Ret COFINS
		/// FieldName: RCOF
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Ret COFINS")]
		public int? M3RCOF => GetNullableInt("RCOF");

		/// <summary>
		/// Description: % importation tax
		/// FieldName: XIMP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% importation tax")]
		public int? M3XIMP => GetNullableInt("XIMP");

		/// <summary>
		/// Description: Item Origin
		/// FieldName: IORI
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item Origin")]
		public string M3IORI => GetString("IORI");

		/// <summary>
		/// Description: Sales Type
		/// FieldName: XSAT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales Type")]
		public string M3XSAT => GetString("XSAT");

		/// <summary>
		/// Description: TIPI's Ex Code
		/// FieldName: EXIP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("TIPI's Ex Code")]
		public int? M3EXIP => GetNullableInt("EXIP");

		/// <summary>
		/// Description: Type of ICMS Base Calculation
		/// FieldName: BICM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of ICMS Base Calculation")]
		public int? M3BICM => GetNullableInt("BICM");

		/// <summary>
		/// Description: Type of ICMS Base Calc - Tax substitute
		/// FieldName: BCST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of ICMS Base Calc - Tax substitute")]
		public int? M3BCST => GetNullableInt("BCST");

		/// <summary>
		/// Description: PIS - Fix Charged
		/// FieldName: VPIS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS - Fix Charged")]
		public decimal? M3VPIS => GetNullableDecimal("VPIS");

		/// <summary>
		/// Description: COFINS - Fix Charge
		/// FieldName: VCOF
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS - Fix Charge")]
		public string M3VCOF => GetString("VCOF");
	}
}
// EOF
