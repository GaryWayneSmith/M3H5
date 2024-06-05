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

namespace M3H5Lib.Api.PDS003MI
{
	public partial class ListResponse : M3BaseRecord 
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
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3STRT => GetString("STRT");

		/// <summary>
		/// Description: From date
		/// FieldName: FDAT
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public int? M3FDAT => GetNullableInt("FDAT");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: MSEQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3MSEQ => GetNullableInt("MSEQ");

		/// <summary>
		/// Description: Component number
		/// FieldName: MTNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component number")]
		public string M3MTNO => GetString("MTNO");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Work center
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3PLGR => GetString("PLGR");

		/// <summary>
		/// Description: Operation description
		/// FieldName: OPDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation description")]
		public string M3OPDS => GetString("OPDS");

		/// <summary>
		/// Description: Selection type
		/// FieldName: OTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection type")]
		public string M3OTYP => GetString("OTYP");

		/// <summary>
		/// Description: Feature
		/// FieldName: FTID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3FTID => GetString("FTID");

		/// <summary>
		/// Description: Option
		/// FieldName: OPTN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3OPTN => GetString("OPTN");

		/// <summary>
		/// Description: Text
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TX30 => GetString("TX30");

		/// <summary>
		/// Description: Include/exclude product strukture line
		/// FieldName: INCE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include/exclude product strukture line")]
		public string M3INCE => GetString("INCE");

		/// <summary>
		/// Description: From numeric range value
		/// FieldName: NUVF
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From numeric range value")]
		public string M3NUVF => GetString("NUVF");

		/// <summary>
		/// Description: To numeric range value
		/// FieldName: NUVT
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To numeric range value")]
		public string M3NUVT => GetString("NUVT");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3UNMS => GetString("UNMS");
	}
}
// EOF
