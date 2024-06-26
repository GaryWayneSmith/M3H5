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

namespace M3H5Lib.Api.SOS400MI
{
	public partial class LstMtrByItmResponse : M3BaseRecord 
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
		/// Description: Descr - act mtr 1
		/// FieldName: A1DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - act mtr 1")]
		public string M3A1DS => GetString("A1DS");

		/// <summary>
		/// Description: Descr - act mtr 2
		/// FieldName: A2DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - act mtr 2")]
		public string M3A2DS => GetString("A2DS");

		/// <summary>
		/// Description: Descr - act mtr 3
		/// FieldName: A3DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - act mtr 3")]
		public string M3A3DS => GetString("A3DS");

		/// <summary>
		/// Description: Descr - act mtr 4
		/// FieldName: A4DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - act mtr 4")]
		public string M3A4DS => GetString("A4DS");

		/// <summary>
		/// Description: Descr - act mtr 5
		/// FieldName: A5DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - act mtr 5")]
		public string M3A5DS => GetString("A5DS");

		/// <summary>
		/// Description: Descr - act mtr 6
		/// FieldName: A6DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - act mtr 6")]
		public string M3A6DS => GetString("A6DS");

		/// <summary>
		/// Description: Name - act mtr 1
		/// FieldName: A1NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - act mtr 1")]
		public string M3A1NA => GetString("A1NA");

		/// <summary>
		/// Description: Name - act mtr 2
		/// FieldName: A2NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - act mtr 2")]
		public string M3A2NA => GetString("A2NA");

		/// <summary>
		/// Description: Name - act mtr 3
		/// FieldName: A3NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - act mtr 3")]
		public string M3A3NA => GetString("A3NA");

		/// <summary>
		/// Description: Name - act mtr 4
		/// FieldName: A4NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - act mtr 4")]
		public string M3A4NA => GetString("A4NA");

		/// <summary>
		/// Description: Name - act mtr 5
		/// FieldName: A5NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - act mtr 5")]
		public string M3A5NA => GetString("A5NA");

		/// <summary>
		/// Description: Name - act mtr 6
		/// FieldName: A6NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - act mtr 6")]
		public string M3A6NA => GetString("A6NA");

		/// <summary>
		/// Description: Descr log mtr 1
		/// FieldName: L1DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 1")]
		public string M3L1DS => GetString("L1DS");

		/// <summary>
		/// Description: Descr log mtr 2
		/// FieldName: L2DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 2")]
		public string M3L2DS => GetString("L2DS");

		/// <summary>
		/// Description: Descr log mtr 3
		/// FieldName: L3DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 3")]
		public string M3L3DS => GetString("L3DS");

		/// <summary>
		/// Description: Descr log mtr 4
		/// FieldName: L4DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 4")]
		public string M3L4DS => GetString("L4DS");

		/// <summary>
		/// Description: Descr log mtr 5
		/// FieldName: L5DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 5")]
		public string M3L5DS => GetString("L5DS");

		/// <summary>
		/// Description: Descr log mtr 6
		/// FieldName: L6DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr log mtr 6")]
		public string M3L6DS => GetString("L6DS");

		/// <summary>
		/// Description: Formula log mtr 1
		/// FieldName: L1FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 1")]
		public string M3L1FO => GetString("L1FO");

		/// <summary>
		/// Description: Formula log mtr 2
		/// FieldName: L2FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 2")]
		public string M3L2FO => GetString("L2FO");

		/// <summary>
		/// Description: Formula log mtr 3
		/// FieldName: L3FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 3")]
		public string M3L3FO => GetString("L3FO");

		/// <summary>
		/// Description: Formula log mtr 4
		/// FieldName: L4FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 4")]
		public string M3L4FO => GetString("L4FO");

		/// <summary>
		/// Description: Formula log mtr 5
		/// FieldName: L5FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 5")]
		public string M3L5FO => GetString("L5FO");

		/// <summary>
		/// Description: Formula log mtr 6
		/// FieldName: L6FO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula log mtr 6")]
		public string M3L6FO => GetString("L6FO");

		/// <summary>
		/// Description: Descr - inv mtr 1
		/// FieldName: I1DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - inv mtr 1")]
		public string M3I1DS => GetString("I1DS");

		/// <summary>
		/// Description: Descr - inv mtr 2
		/// FieldName: I2DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - inv mtr 2")]
		public string M3I2DS => GetString("I2DS");

		/// <summary>
		/// Description: Descr - inv mtr 3
		/// FieldName: I3DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - inv mtr 3")]
		public string M3I3DS => GetString("I3DS");

		/// <summary>
		/// Description: Descr - inv mtr 4
		/// FieldName: I4DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - inv mtr 4")]
		public string M3I4DS => GetString("I4DS");

		/// <summary>
		/// Description: Descr - inv mtr 5
		/// FieldName: I5DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - inv mtr 5")]
		public string M3I5DS => GetString("I5DS");

		/// <summary>
		/// Description: Descr - inv mtr 6
		/// FieldName: I6DS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Descr - inv mtr 6")]
		public string M3I6DS => GetString("I6DS");

		/// <summary>
		/// Description: Name - inv mtr 1
		/// FieldName: I1NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 1")]
		public string M3I1NA => GetString("I1NA");

		/// <summary>
		/// Description: Name - inv mtr 2
		/// FieldName: I2NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 2")]
		public string M3I2NA => GetString("I2NA");

		/// <summary>
		/// Description: Name - inv mtr 3
		/// FieldName: I3NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 3")]
		public string M3I3NA => GetString("I3NA");

		/// <summary>
		/// Description: Name - inv mtr 4
		/// FieldName: I4NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 4")]
		public string M3I4NA => GetString("I4NA");

		/// <summary>
		/// Description: Name - inv mtr 5
		/// FieldName: I5NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 5")]
		public string M3I5NA => GetString("I5NA");

		/// <summary>
		/// Description: Name - inv mtr 6
		/// FieldName: I6NA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - inv mtr 6")]
		public string M3I6NA => GetString("I6NA");

		/// <summary>
		/// Description: Inv mtr 1 based on mtr
		/// FieldName: I1BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 1 based on mtr")]
		public string M3I1BM => GetString("I1BM");

		/// <summary>
		/// Description: Inv mtr 2 based on mtr
		/// FieldName: I2BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 2 based on mtr")]
		public string M3I2BM => GetString("I2BM");

		/// <summary>
		/// Description: Inv mtr 3 based on mtr
		/// FieldName: I3BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 3 based on mtr")]
		public string M3I3BM => GetString("I3BM");

		/// <summary>
		/// Description: Inv mtr 4 based on mtr
		/// FieldName: I4BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 4 based on mtr")]
		public string M3I4BM => GetString("I4BM");

		/// <summary>
		/// Description: Inv mtr 5 based on mtr
		/// FieldName: I5BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 5 based on mtr")]
		public string M3I5BM => GetString("I5BM");

		/// <summary>
		/// Description: Inv mtr 6 based on mtr
		/// FieldName: I6BM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv mtr 6 based on mtr")]
		public string M3I6BM => GetString("I6BM");

		/// <summary>
		/// Description: Description - total meter
		/// FieldName: TMDS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - total meter")]
		public string M3TMDS => GetString("TMDS");

		/// <summary>
		/// Description: Tot mtr based on mtr
		/// FieldName: TMBM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tot mtr based on mtr")]
		public string M3TMBM => GetString("TMBM");

		/// <summary>
		/// Description: Name - total meter
		/// FieldName: TMNA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name - total meter")]
		public string M3TMNA => GetString("TMNA");

		/// <summary>
		/// Description: Usage period type 1
		/// FieldName: AMB1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Usage period type 1")]
		public int? M3AMB1 => GetNullableInt("AMB1");

		/// <summary>
		/// Description: Usage period type 2
		/// FieldName: AMB2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Usage period type 2")]
		public int? M3AMB2 => GetNullableInt("AMB2");
	}
}
// EOF
