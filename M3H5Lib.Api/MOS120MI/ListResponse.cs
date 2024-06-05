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

namespace M3H5Lib.Api.MOS120MI
{
	public partial class ListResponse : M3BaseRecord 
	{

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
		/// Description: Work order category
		/// FieldName: MOTC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work order category")]
		public string M3_MOTC => GetString("MOTC");

		/// <summary>
		/// Description: Update material plan
		/// FieldName: UPMP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update material plan")]
		public int? M3_UPMP => GetNullableInt("UPMP");

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
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: POS to M3 Requisition +
		/// FieldName: TRT1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("POS to M3 Requisition +")]
		public string M3_TRT1 => GetString("TRT1");

		/// <summary>
		/// Description: POS to M3 Requisition -
		/// FieldName: TRT2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("POS to M3 Requisition -")]
		public string M3_TRT2 => GetString("TRT2");

		/// <summary>
		/// Description: Supply model
		/// FieldName: SPLM
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply model")]
		public string M3_SPLM => GetString("SPLM");

		/// <summary>
		/// Description: Dispatch policy
		/// FieldName: DPOL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dispatch policy")]
		public string M3_DPOL => GetString("DPOL");
	}
}
// EOF