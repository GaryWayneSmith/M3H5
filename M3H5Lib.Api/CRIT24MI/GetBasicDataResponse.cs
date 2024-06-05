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
	public partial class GetBasicDataResponse : M3BaseRecord 
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
		/// Description: Supplier type
		/// FieldName: XSTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier type")]
		public int? M3XSTI => GetNullableInt("XSTI");

		/// <summary>
		/// Description: VAT tax number
		/// FieldName: XTAN
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT tax number")]
		public string M3XTAN => GetString("XTAN");

		/// <summary>
		/// Description: Fiscal code
		/// FieldName: XFCO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fiscal code")]
		public string M3XFCO => GetString("XFCO");

		/// <summary>
		/// Description: Ancipated Instalment
		/// FieldName: XSAT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ancipated Instalment")]
		public string M3XSAT => GetString("XSAT");

		/// <summary>
		/// Description: Date of birth
		/// FieldName: XBDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date of birth")]
		public DateTime? M3XBDA => GetNullableDateTime("XBDA");

		/// <summary>
		/// Description: Sex
		/// FieldName: XSEX
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sex")]
		public string M3XSEX => GetString("XSEX");

		/// <summary>
		/// Description: Birthplace/state
		/// FieldName: XBPL
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Birthplace/state")]
		public string M3XBPL => GetString("XBPL");

		/// <summary>
		/// Description: Birtharea/state
		/// FieldName: XBCO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Birtharea/state")]
		public string M3XBCO => GetString("XBCO");

		/// <summary>
		/// Description: Change period
		/// FieldName: XCPE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change period")]
		public int? M3XCPE => GetNullableInt("XCPE");

		/// <summary>
		/// Description: City
		/// FieldName: PLAC
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("City")]
		public string M3PLAC => GetString("PLAC");

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
		/// Description: Registration number - Extrastat (Extra)
		/// FieldName: FIRM
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration number - Extrastat (Extra)")]
		public string M3FIRM => GetString("FIRM");

		/// <summary>
		/// Description: Prefix number
		/// FieldName: XPTN
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prefix number")]
		public string M3XPTN => GetString("XPTN");

		/// <summary>
		/// Description: Telephone number
		/// FieldName: XTEN
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number")]
		public string M3XTEN => GetString("XTEN");

		/// <summary>
		/// Description: Payment tax identification Mod.770
		/// FieldName: XPTI
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment tax identification Mod.770")]
		public string M3XPTI => GetString("XPTI");

		/// <summary>
		/// Description: Surname
		/// FieldName: XCOG
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Surname")]
		public string M3XCOG => GetString("XCOG");

		/// <summary>
		/// Description: Name
		/// FieldName: XNAM
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3XNAM => GetString("XNAM");
	}
}
// EOF
