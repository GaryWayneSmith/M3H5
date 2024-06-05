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

namespace M3H5Lib.Api.PMS155MI
{
	public partial class LstResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Manufacturing order number
		/// FieldName: MFNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3_MFNO => GetString("MFNO");

		/// <summary>
		/// Description: Demand order category
		/// FieldName: DOCA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Demand order category")]
		public string M3_DOCA => GetString("DOCA");

		/// <summary>
		/// Description: Product
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product")]
		public string M3_PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Ordered quantity - alternate U/M
		/// FieldName: ORQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - alternate U/M")]
		public decimal? M3_ORQA => GetNullableDecimal("ORQA");

		/// <summary>
		/// Description: Manufacturing U/M
		/// FieldName: MAUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing U/M")]
		public string M3_MAUN => GetString("MAUN");

		/// <summary>
		/// Description: Order balanced quantity
		/// FieldName: NBEQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order balanced quantity")]
		public decimal? M3_NBEQ => GetNullableDecimal("NBEQ");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3_UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Received quantity
		/// FieldName: RVQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Received quantity")]
		public decimal? M3_RVQA => GetNullableDecimal("RVQA");

		/// <summary>
		/// Description: Last received balanced quantity
		/// FieldName: NBE1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last received balanced quantity")]
		public decimal? M3_NBE1 => GetNullableDecimal("NBE1");

		/// <summary>
		/// Description: Current balanced quantity
		/// FieldName: CBEQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Current balanced quantity")]
		public decimal? M3_CBEQ => GetNullableDecimal("CBEQ");

		/// <summary>
		/// Description: Current received balanced quantity
		/// FieldName: CBE1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Current received balanced quantity")]
		public decimal? M3_CBE1 => GetNullableDecimal("CBE1");
	}
}
// EOF
