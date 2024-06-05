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

namespace M3H5Lib.Api.XBR001MI
{
	public partial class GetTranspInfoResponse : M3BaseRecord 
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
		/// Description: Delivery number
		/// FieldName: DLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3DLIX => GetNullableDecimal("DLIX");

		/// <summary>
		/// Description: Truck license plate
		/// FieldName: TRLP
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Truck license plate")]
		public string M3TRLP => GetString("TRLP");

		/// <summary>
		/// Description: Truck license plate UF
		/// FieldName: TRUF
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Truck license plate UF")]
		public string M3TRUF => GetString("TRUF");

		/// <summary>
		/// Description: Truck ANTT code
		/// FieldName: TRTT
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Truck ANTT code")]
		public string M3TRTT => GetString("TRTT");

		/// <summary>
		/// Description: Trailer license plate
		/// FieldName: TLLP
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trailer license plate")]
		public string M3TLLP => GetString("TLLP");

		/// <summary>
		/// Description: Trailer license plate UF
		/// FieldName: TLUF
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trailer license plate UF")]
		public string M3TLUF => GetString("TLUF");

		/// <summary>
		/// Description: Trailer ANTT code
		/// FieldName: TLTT
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trailer ANTT code")]
		public string M3TLTT => GetString("TLTT");

		/// <summary>
		/// Description: Freight train id
		/// FieldName: CRID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight train id")]
		public string M3CRID => GetString("CRID");

		/// <summary>
		/// Description: Ferry id
		/// FieldName: FRID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ferry id")]
		public string M3FRID => GetString("FRID");
	}
}
// EOF
