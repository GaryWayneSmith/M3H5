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

namespace M3H5Lib.Api.RPS180MI
{
	public partial class ListPLTResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Planning template
		/// FieldName: PLNT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning template")]
		public string M3_PLNT => GetString("PLNT");

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
		/// Description: Generate messages
		/// FieldName: GMSG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Generate messages")]
		public int? M3_GMSG => GetNullableInt("GMSG");

		/// <summary>
		/// Description: Acquisition code
		/// FieldName: PUIT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acquisition code")]
		public int? M3_PUIT => GetNullableInt("PUIT");

		/// <summary>
		/// Description: Period frame
		/// FieldName: DPID
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period frame")]
		public int? M3_DPID => GetNullableInt("DPID");

		/// <summary>
		/// Description: Planning method
		/// FieldName: OPLC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning method")]
		public int? M3_OPLC => GetNullableInt("OPLC");

		/// <summary>
		/// Description: Planning policy
		/// FieldName: PLCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning policy")]
		public string M3_PLCD => GetString("PLCD");

		/// <summary>
		/// Description: Master scheduled
		/// FieldName: MSCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Master scheduled")]
		public int? M3_MSCH => GetNullableInt("MSCH");

		/// <summary>
		/// Description: Supply chain policy
		/// FieldName: SCPO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply chain policy")]
		public string M3_SCPO => GetString("SCPO");

		/// <summary>
		/// Description: Inventory planned
		/// FieldName: IPLA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory planned")]
		public string M3_IPLA => GetString("IPLA");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Continuous net change
		/// FieldName: CONC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Continuous net change")]
		public int? M3_CONC => GetNullableInt("CONC");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Forecast method
		/// FieldName: PRCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast method")]
		public string M3_PRCD => GetString("PRCD");

		/// <summary>
		/// Description: Forecast logic
		/// FieldName: FCCM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast logic")]
		public string M3_FCCM => GetString("FCCM");

		/// <summary>
		/// Description: Multiple supply
		/// FieldName: SVEI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple supply")]
		public int? M3_SVEI => GetNullableInt("SVEI");

		/// <summary>
		/// Description: Safety stock method
		/// FieldName: SSMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock method")]
		public int? M3_SSMT => GetNullableInt("SSMT");

		/// <summary>
		/// Description: Safety stock unit
		/// FieldName: SSDA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock unit")]
		public int? M3_SSDA => GetNullableInt("SSDA");

		/// <summary>
		/// Description: Service level
		/// FieldName: SCGR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service level")]
		public int? M3_SCGR => GetNullableInt("SCGR");

		/// <summary>
		/// Description: Reorder point method
		/// FieldName: OPOM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reorder point method")]
		public int? M3_OPOM => GetNullableInt("OPOM");

		/// <summary>
		/// Description: Order policy
		/// FieldName: EOQM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order policy")]
		public int? M3_EOQM => GetNullableInt("EOQM");

		/// <summary>
		/// Description: Sales item
		/// FieldName: SALE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales item")]
		public int? M3_SALE => GetNullableInt("SALE");

		/// <summary>
		/// Description: Clear demand
		/// FieldName: CLDM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clear demand")]
		public int? M3_CLDM => GetNullableInt("CLDM");

		/// <summary>
		/// Description: Clear order quantities
		/// FieldName: CLOR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clear order quantities")]
		public int? M3_CLOR => GetNullableInt("CLOR");
	}
}
// EOF
