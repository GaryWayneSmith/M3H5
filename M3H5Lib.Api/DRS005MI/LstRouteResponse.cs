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

namespace M3H5Lib.Api.DRS005MI
{
	public partial class LstRouteResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Route
		/// FieldName: ROUT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route")]
		public string M3_ROUT => GetString("ROUT");

		/// <summary>
		/// Description: Route type
		/// FieldName: RUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route type")]
		public int? M3_RUTP => GetNullableInt("RUTP");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: Place of loading
		/// FieldName: SDES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place of loading")]
		public string M3_SDES => GetString("SDES");

		/// <summary>
		/// Description: Place
		/// FieldName: EDES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place")]
		public string M3_EDES => GetString("EDES");

		/// <summary>
		/// Description: Stipulated internal lead time - days
		/// FieldName: SILD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stipulated internal lead time - days")]
		public int? M3_SILD => GetNullableInt("SILD");

		/// <summary>
		/// Description: Stipulated internal lead time - hours
		/// FieldName: SILH
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stipulated internal lead time - hours")]
		public int? M3_SILH => GetNullableInt("SILH");

		/// <summary>
		/// Description: Stipulated internal lead time - minutes
		/// FieldName: SILM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stipulated internal lead time - minutes")]
		public int? M3_SILM => GetNullableInt("SILM");

		/// <summary>
		/// Description: Manual shipment scheduling allowed
		/// FieldName: DLMC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual shipment scheduling allowed")]
		public int? M3_DLMC => GetNullableInt("DLMC");

		/// <summary>
		/// Description: Ignore deadline when connecting dely no
		/// FieldName: DLAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ignore deadline when connecting dely no")]
		public int? M3_DLAC => GetNullableInt("DLAC");

		/// <summary>
		/// Description: Automatic connection to shipment
		/// FieldName: ACNC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic connection to shipment")]
		public int? M3_ACNC => GetNullableInt("ACNC");

		/// <summary>
		/// Description: Responsible must be entered
		/// FieldName: MARE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible must be entered")]
		public int? M3_MARE => GetNullableInt("MARE");

		/// <summary>
		/// Description: Loading platform
		/// FieldName: MALP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loading platform")]
		public int? M3_MALP => GetNullableInt("MALP");

		/// <summary>
		/// Description: Transportation equipment
		/// FieldName: MACA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation equipment")]
		public int? M3_MACA => GetNullableInt("MACA");

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
		/// Description: Transportation equipment
		/// FieldName: TRCA
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation equipment")]
		public string M3_TRCA => GetString("TRCA");

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
		/// Description: Transportation service ID
		/// FieldName: TSID
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation service ID")]
		public string M3_TSID => GetString("TSID");

		/// <summary>
		/// Description: Number of kilometer
		/// FieldName: DIST
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of kilometer")]
		public int? M3_DIST => GetNullableInt("DIST");

		/// <summary>
		/// Description: Load building
		/// FieldName: LOBL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Load building")]
		public int? M3_LOBL => GetNullableInt("LOBL");

		/// <summary>
		/// Description: Loading platform
		/// FieldName: LODO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loading platform")]
		public string M3_LODO => GetString("LODO");

		/// <summary>
		/// Description: Direction
		/// FieldName: INOU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Direction")]
		public int? M3_INOU => GetNullableInt("INOU");
	}
}
// EOF
