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

namespace M3H5Lib.Api.OIS038MI
{
	public partial class LstBusChainCustResponse : M3BaseRecord 
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
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Superior business chain
		/// FieldName: CHCT
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Superior business chain")]
		public string M3CHCT => GetString("CHCT");

		/// <summary>
		/// Description: Business chain - level 1
		/// FieldName: CHL1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 1")]
		public string M3CHL1 => GetString("CHL1");

		/// <summary>
		/// Description: Business chain - level 2
		/// FieldName: CHL2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 2")]
		public string M3CHL2 => GetString("CHL2");

		/// <summary>
		/// Description: Business chain - level 3
		/// FieldName: CHL3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 3")]
		public string M3CHL3 => GetString("CHL3");

		/// <summary>
		/// Description: Business chain - level 4
		/// FieldName: CHL4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 4")]
		public string M3CHL4 => GetString("CHL4");

		/// <summary>
		/// Description: Valid from
		/// FieldName: FVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3FVDT => GetNullableDateTime("FVDT");

		/// <summary>
		/// Description: Valid to
		/// FieldName: LVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3LVDT => GetNullableDateTime("LVDT");

		/// <summary>
		/// Description: Member number
		/// FieldName: CHMB
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Member number")]
		public string M3CHMB => GetString("CHMB");

		/// <summary>
		/// Description: Status - member
		/// FieldName: MBST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - member")]
		public int? M3MBST => GetNullableInt("MBST");
	}
}
// EOF
