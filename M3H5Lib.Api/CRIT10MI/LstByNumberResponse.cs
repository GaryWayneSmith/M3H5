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

namespace M3H5Lib.Api.CRIT10MI
{
	public partial class LstByNumberResponse : M3BaseRecord 
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
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Customer type
		/// FieldName: XCTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer type")]
		public int? M3XCTI => GetNullableInt("XCTI");

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
		/// Description: Fiscal code jur.
		/// FieldName: XFCJ
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fiscal code jur.")]
		public string M3XFCJ => GetString("XFCJ");

		/// <summary>
		/// Description: Province
		/// FieldName: XPRV
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Province")]
		public string M3XPRV => GetString("XPRV");

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
