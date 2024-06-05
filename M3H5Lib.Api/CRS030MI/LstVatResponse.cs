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

namespace M3H5Lib.Api.CRS030MI
{
	public partial class LstVatResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public int? M3VTCD => GetNullableInt("VTCD");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: VAT method
		/// FieldName: VATT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT method")]
		public int? M3VATT => GetNullableInt("VATT");

		/// <summary>
		/// Description: VAT date type
		/// FieldName: VDTT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT date type")]
		public int? M3VDTT => GetNullableInt("VDTT");

		/// <summary>
		/// Description: VAT reported on payment day
		/// FieldName: VPYM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT reported on payment day")]
		public int? M3VPYM => GetNullableInt("VPYM");

		/// <summary>
		/// Description: VAT corrections
		/// FieldName: VTCO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT corrections")]
		public int? M3VTCO => GetNullableInt("VTCO");

		/// <summary>
		/// Description: Self-assessment tax
		/// FieldName: SATX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Self-assessment tax")]
		public int? M3SATX => GetNullableInt("SATX");

		/// <summary>
		/// Description: VAT override
		/// FieldName: VTOV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT override")]
		public int? M3VTOV => GetNullableInt("VTOV");

		/// <summary>
		/// Description: VAT on services - yes/no
		/// FieldName: SERV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT on services - yes/no")]
		public int? M3SERV => GetNullableInt("SERV");

		/// <summary>
		/// Description: VAT code group
		/// FieldName: VATG
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code group")]
		public string M3VATG => GetString("VATG");
	}
}
// EOF
