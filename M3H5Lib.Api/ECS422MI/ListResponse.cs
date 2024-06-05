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

namespace M3H5Lib.Api.ECS422MI
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
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Change type
		/// FieldName: ECEX
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change type")]
		public string M3ECEX => GetString("ECEX");

		/// <summary>
		/// Description: Change ID
		/// FieldName: ECID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change ID")]
		public string M3ECID => GetString("ECID");

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
		/// Description: Structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type")]
		public string M3STRT => GetString("STRT");

		/// <summary>
		/// Description: Status
		/// FieldName: ECST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3ECST => GetString("ECST");

		/// <summary>
		/// Description: New revision
		/// FieldName: NECV
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New revision")]
		public string M3NECV => GetString("NECV");

		/// <summary>
		/// Description: Old subidentity
		/// FieldName: OLSI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old subidentity")]
		public string M3OLSI => GetString("OLSI");

		/// <summary>
		/// Description: New subidentity
		/// FieldName: NWSI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New subidentity")]
		public string M3NWSI => GetString("NWSI");

		/// <summary>
		/// Description: From date
		/// FieldName: FDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public DateTime? M3FDAT => GetNullableDateTime("FDAT");

		/// <summary>
		/// Description: Old operation number
		/// FieldName: OOPN
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old operation number")]
		public int? M3OOPN => GetNullableInt("OOPN");

		/// <summary>
		/// Description: New sequence number
		/// FieldName: NSEQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New sequence number")]
		public int? M3NSEQ => GetNullableInt("NSEQ");

		/// <summary>
		/// Description: New operation number
		/// FieldName: NOPN
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New operation number")]
		public int? M3NOPN => GetNullableInt("NOPN");

		/// <summary>
		/// Description: New qty
		/// FieldName: NCNQ
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New qty")]
		public string M3NCNQ => GetString("NCNQ");
	}
}
// EOF
