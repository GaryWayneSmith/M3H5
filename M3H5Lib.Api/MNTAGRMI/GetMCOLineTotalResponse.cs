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

namespace M3H5Lib.Api.MNTAGRMI
{
	public partial class GetMCOLineTotalResponse : M3BaseRecord 
	{

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
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Quotation
		/// FieldName: AQUO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quotation")]
		public int? M3AQUO => GetNullableInt("AQUO");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3RESP => GetString("RESP");

		/// <summary>
		/// Description: Revenue time
		/// FieldName: ASTM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revenue time")]
		public decimal? M3ASTM => GetNullableDecimal("ASTM");

		/// <summary>
		/// Description: Revenue material
		/// FieldName: ASMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revenue material")]
		public decimal? M3ASMT => GetNullableDecimal("ASMT");

		/// <summary>
		/// Description: Revenue material handling charge
		/// FieldName: ASMC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revenue material handling charge")]
		public decimal? M3ASMC => GetNullableDecimal("ASMC");

		/// <summary>
		/// Description: Revenues subcontracting
		/// FieldName: ASSC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revenues subcontracting")]
		public decimal? M3ASSC => GetNullableDecimal("ASSC");

		/// <summary>
		/// Description: Revenue subcontracting handling charge
		/// FieldName: ASSH
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revenue subcontracting handling charge")]
		public decimal? M3ASSH => GetNullableDecimal("ASSH");

		/// <summary>
		/// Description: Revenue miscellaneous
		/// FieldName: ASMI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revenue miscellaneous")]
		public decimal? M3ASMI => GetNullableDecimal("ASMI");

		/// <summary>
		/// Description: Cost time
		/// FieldName: ACTU
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost time")]
		public decimal? M3ACTU => GetNullableDecimal("ACTU");

		/// <summary>
		/// Description: Cost material
		/// FieldName: ACM1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost material")]
		public decimal? M3ACM1 => GetNullableDecimal("ACM1");

		/// <summary>
		/// Description: Cost subcontracting
		/// FieldName: ACSC
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost subcontracting")]
		public decimal? M3ACSC => GetNullableDecimal("ACSC");

		/// <summary>
		/// Description: Cost miscellaneous
		/// FieldName: ACMS
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost miscellaneous")]
		public decimal? M3ACMS => GetNullableDecimal("ACMS");

		/// <summary>
		/// Description: Price in agreement currency
		/// FieldName: APA1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in agreement currency")]
		public decimal? M3APA1 => GetNullableDecimal("APA1");

		/// <summary>
		/// Description: Price in material currency
		/// FieldName: APM1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in material currency")]
		public decimal? M3APM1 => GetNullableDecimal("APM1");

		/// <summary>
		/// Description: Labor %
		/// FieldName: TIP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor %")]
		public int? M3TIP1 => GetNullableInt("TIP1");

		/// <summary>
		/// Description: Material %
		/// FieldName: MAP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material %")]
		public int? M3MAP1 => GetNullableInt("MAP1");

		/// <summary>
		/// Description: Subcontract %
		/// FieldName: SUP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subcontract %")]
		public int? M3SUP1 => GetNullableInt("SUP1");

		/// <summary>
		/// Description: Miscellaneous %
		/// FieldName: MIP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Miscellaneous %")]
		public int? M3MIP1 => GetNullableInt("MIP1");
	}
}
// EOF
