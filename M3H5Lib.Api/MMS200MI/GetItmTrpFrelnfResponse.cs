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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class GetItmTrpFrelnfResponse : M3BaseRecord 
	{

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
		/// Description: Alpha field 30 positions
		/// FieldName: A001
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A001 => GetString("A001");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A002
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A002 => GetString("A002");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A003
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A003 => GetString("A003");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A004
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A004 => GetString("A004");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A005
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A005 => GetString("A005");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A006
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A006 => GetString("A006");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A007
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A007 => GetString("A007");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A008
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A008 => GetString("A008");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A009
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A009 => GetString("A009");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A010
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A010 => GetString("A010");

		/// <summary>
		/// Description: Alpha field 1 positions
		/// FieldName: A021
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 1 positions")]
		public string M3A021 => GetString("A021");

		/// <summary>
		/// Description: Alpha field 1 positions
		/// FieldName: A022
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 1 positions")]
		public string M3A022 => GetString("A022");

		/// <summary>
		/// Description: Alpha field 1 positions
		/// FieldName: A023
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 1 positions")]
		public string M3A023 => GetString("A023");

		/// <summary>
		/// Description: Alpha field 1 positions
		/// FieldName: A024
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 1 positions")]
		public string M3A024 => GetString("A024");

		/// <summary>
		/// Description: Alpha field 1 positions
		/// FieldName: A025
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 1 positions")]
		public string M3A025 => GetString("A025");

		/// <summary>
		/// Description: Alpha field 5 positions
		/// FieldName: A026
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 5 positions")]
		public string M3A026 => GetString("A026");

		/// <summary>
		/// Description: Alpha field 5 positions
		/// FieldName: A027
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 5 positions")]
		public string M3A027 => GetString("A027");

		/// <summary>
		/// Description: Alpha field 5 positions
		/// FieldName: A028
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 5 positions")]
		public string M3A028 => GetString("A028");

		/// <summary>
		/// Description: Alpha field 5 positions
		/// FieldName: A029
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 5 positions")]
		public string M3A029 => GetString("A029");

		/// <summary>
		/// Description: Alpha field 5 positions
		/// FieldName: A030
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 5 positions")]
		public string M3A030 => GetString("A030");

		/// <summary>
		/// Description: Alpha field 10 positions
		/// FieldName: A031
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 10 positions")]
		public string M3A031 => GetString("A031");

		/// <summary>
		/// Description: Alpha field 10 positions
		/// FieldName: A032
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 10 positions")]
		public string M3A032 => GetString("A032");

		/// <summary>
		/// Description: Alpha field 10 positions
		/// FieldName: A033
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 10 positions")]
		public string M3A033 => GetString("A033");

		/// <summary>
		/// Description: Alpha field 10 positions
		/// FieldName: A034
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 10 positions")]
		public string M3A034 => GetString("A034");

		/// <summary>
		/// Description: Alpha field 10 positions
		/// FieldName: A035
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 10 positions")]
		public string M3A035 => GetString("A035");

		/// <summary>
		/// Description: Alpha field 10 positions
		/// FieldName: A036
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 10 positions")]
		public string M3A036 => GetString("A036");

		/// <summary>
		/// Description: Alpha field 10 positions
		/// FieldName: A037
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 10 positions")]
		public string M3A037 => GetString("A037");

		/// <summary>
		/// Description: Alpha field 10 positions
		/// FieldName: A038
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 10 positions")]
		public string M3A038 => GetString("A038");

		/// <summary>
		/// Description: Alpha field 10 positions
		/// FieldName: A039
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 10 positions")]
		public string M3A039 => GetString("A039");

		/// <summary>
		/// Description: Alpha field 10 positions
		/// FieldName: A040
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 10 positions")]
		public string M3A040 => GetString("A040");
	}
}
// EOF
