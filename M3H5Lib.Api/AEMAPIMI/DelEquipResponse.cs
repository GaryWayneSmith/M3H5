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

namespace M3H5Lib.Api.AEMAPIMI
{
	public partial class DelEquipResponse : M3BaseRecord 
	{

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
		/// Description: Serial number
		/// FieldName: SERN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SERN => GetString("SERN");

		/// <summary>
		/// Description: Interface status
		/// FieldName: STAI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interface status")]
		public string M3STAI => GetString("STAI");

		/// <summary>
		/// Description: Lowest status child table
		/// FieldName: STOT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest status child table")]
		public string M3STOT => GetString("STOT");

		/// <summary>
		/// Description: Manufacturer
		/// FieldName: PROD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturer")]
		public string M3PROD => GetString("PROD");

		/// <summary>
		/// Description: Fleet number
		/// FieldName: FLNO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fleet number")]
		public string M3FLNO => GetString("FLNO");

		/// <summary>
		/// Description: Registration number/site
		/// FieldName: TAIL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration number/site")]
		public string M3TAIL => GetString("TAIL");

		/// <summary>
		/// Description: Search key for equipment
		/// FieldName: SKEY
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search key for equipment")]
		public string M3SKEY => GetString("SKEY");

		/// <summary>
		/// Description: Process
		/// FieldName: PRSS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Process")]
		public string M3PRSS => GetString("PRSS");

		/// <summary>
		/// Description: Asset tag
		/// FieldName: RFIA
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Asset tag")]
		public string M3RFIA => GetString("RFIA");

		/// <summary>
		/// Description: Brand
		/// FieldName: BRAN
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Brand")]
		public string M3BRAN => GetString("BRAN");

		/// <summary>
		/// Description: Remark
		/// FieldName: REMK
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3REMK => GetString("REMK");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");
	}
}
// EOF
