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

namespace M3H5Lib.Api.DPS170MI
{
	public partial class GetDistRelResponse : M3BaseRecord 
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
		/// Description: Division (for from whs)
		/// FieldName: DIVF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division (for from whs)")]
		public string M3_DIVF => GetString("DIVF");

		/// <summary>
		/// Description: Facility (for from whs)
		/// FieldName: FACF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility (for from whs)")]
		public string M3_FACF => GetString("FACF");

		/// <summary>
		/// Description: From warehouse
		/// FieldName: FWLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From warehouse")]
		public string M3_FWLO => GetString("FWLO");

		/// <summary>
		/// Description: Division (for to whs)
		/// FieldName: DIVT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division (for to whs)")]
		public string M3_DIVT => GetString("DIVT");

		/// <summary>
		/// Description: Facility (for to whs)
		/// FieldName: FACT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility (for to whs)")]
		public string M3_FACT => GetString("FACT");

		/// <summary>
		/// Description: To Warehouse
		/// FieldName: TWLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To Warehouse")]
		public string M3_TWLO => GetString("TWLO");

		/// <summary>
		/// Description: Transportation time(days)
		/// FieldName: TRDY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation time(days)")]
		public int? M3_TRDY => GetNullableInt("TRDY");

		/// <summary>
		/// Description: Transportation hours
		/// FieldName: TRTE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation hours")]
		public int? M3_TRTE => GetNullableInt("TRTE");

		/// <summary>
		/// Description: Relative share
		/// FieldName: RLSH
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Relative share")]
		public int? M3_RLSH => GetNullableInt("RLSH");

		/// <summary>
		/// Description: Individual distribution calendar
		/// FieldName: ISHC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual distribution calendar")]
		public int? M3_ISHC => GetNullableInt("ISHC");

		/// <summary>
		/// Description: Permitted delivery day
		/// FieldName: ADDY
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Permitted delivery day")]
		public string M3_ADDY => GetString("ADDY");

		/// <summary>
		/// Description: Weight capacity
		/// FieldName: COWC
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weight capacity")]
		public decimal? M3_COWC => GetNullableDecimal("COWC");

		/// <summary>
		/// Description: Volume capacity
		/// FieldName: COVC
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume capacity")]
		public decimal? M3_COVC => GetNullableDecimal("COVC");

		/// <summary>
		/// Description: Container capacity
		/// FieldName: COCA
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container capacity")]
		public decimal? M3_COCA => GetNullableDecimal("COCA");

		/// <summary>
		/// Description: Relation type
		/// FieldName: RLTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Relation type")]
		public int? M3_RLTY => GetNullableInt("RLTY");

		/// <summary>
		/// Description: Group identity
		/// FieldName: DIKY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group identity")]
		public string M3_DIKY => GetString("DIKY");

		/// <summary>
		/// Description: Document needs
		/// FieldName: DORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document needs")]
		public int? M3_DORC => GetNullableInt("DORC");

		/// <summary>
		/// Description: Forwarding agent
		/// FieldName: FWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarding agent")]
		public string M3_FWNO => GetString("FWNO");

		/// <summary>
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3_MODL => GetString("MODL");

		/// <summary>
		/// Description: Delivery terms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms")]
		public string M3_TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3_STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: To date
		/// FieldName: TODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3_TODT => GetNullableDateTime("TODT");
	}
}
// EOF
