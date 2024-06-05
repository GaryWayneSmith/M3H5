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

namespace M3H5Lib.Api.DPS170MI
{
	public partial class LstDistRelResponse : M3BaseRecord 
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
		/// Description: Division (for from whs)
		/// FieldName: DIVF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division (for from whs)")]
		public string M3DIVF => GetString("DIVF");

		/// <summary>
		/// Description: Facility (for from whs)
		/// FieldName: FACF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility (for from whs)")]
		public string M3FACF => GetString("FACF");

		/// <summary>
		/// Description: From warehouse
		/// FieldName: FWLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From warehouse")]
		public string M3FWLO => GetString("FWLO");

		/// <summary>
		/// Description: Division (for to whs)
		/// FieldName: DIVT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division (for to whs)")]
		public string M3DIVT => GetString("DIVT");

		/// <summary>
		/// Description: Facility (for to whs)
		/// FieldName: FACT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility (for to whs)")]
		public string M3FACT => GetString("FACT");

		/// <summary>
		/// Description: To Warehouse
		/// FieldName: TWLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To Warehouse")]
		public string M3TWLO => GetString("TWLO");

		/// <summary>
		/// Description: Transportation time(days)
		/// FieldName: TRDY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation time(days)")]
		public int? M3TRDY => GetNullableInt("TRDY");

		/// <summary>
		/// Description: Transportation hours
		/// FieldName: TRTE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation hours")]
		public int? M3TRTE => GetNullableInt("TRTE");

		/// <summary>
		/// Description: Relative share
		/// FieldName: RLSH
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Relative share")]
		public int? M3RLSH => GetNullableInt("RLSH");

		/// <summary>
		/// Description: Individual distribution calendar
		/// FieldName: ISHC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual distribution calendar")]
		public int? M3ISHC => GetNullableInt("ISHC");

		/// <summary>
		/// Description: Permitted delivery day
		/// FieldName: ADDY
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Permitted delivery day")]
		public string M3ADDY => GetString("ADDY");

		/// <summary>
		/// Description: Weight capacity
		/// FieldName: COWC
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weight capacity")]
		public decimal? M3COWC => GetNullableDecimal("COWC");

		/// <summary>
		/// Description: Volume capacity
		/// FieldName: COVC
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume capacity")]
		public decimal? M3COVC => GetNullableDecimal("COVC");

		/// <summary>
		/// Description: Container capacity
		/// FieldName: COCA
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container capacity")]
		public decimal? M3COCA => GetNullableDecimal("COCA");

		/// <summary>
		/// Description: Relation type
		/// FieldName: RLTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Relation type")]
		public int? M3RLTY => GetNullableInt("RLTY");

		/// <summary>
		/// Description: Group identity
		/// FieldName: DIKY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group identity")]
		public string M3DIKY => GetString("DIKY");

		/// <summary>
		/// Description: Document needs
		/// FieldName: DORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document needs")]
		public int? M3DORC => GetNullableInt("DORC");

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
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3MODL => GetString("MODL");

		/// <summary>
		/// Description: Delivery terms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms")]
		public string M3TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: To date
		/// FieldName: TODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3TODT => GetNullableDateTime("TODT");
	}
}
// EOF
