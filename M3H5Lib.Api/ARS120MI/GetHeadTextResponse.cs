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

namespace M3H5Lib.Api.ARS120MI
{
	public partial class GetHeadTextResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Job number
		/// FieldName: JBNO
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job number")]
		public int? M3JBNO => GetNullableInt("JBNO");

		/// <summary>
		/// Description: Job date
		/// FieldName: JBDT
		/// FieldType: D
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job date")]
		public DateTime? M3JBDT => GetNullableDateTime("JBDT");

		/// <summary>
		/// Description: Job time
		/// FieldName: JBTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job time")]
		public int? M3JBTM => GetNullableInt("JBTM");

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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: CINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public string M3CINO => GetString("CINO");

		/// <summary>
		/// Description: Invoice year
		/// FieldName: INYR
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice year")]
		public int? M3INYR => GetNullableInt("INYR");

		/// <summary>
		/// Description: Text line 1
		/// FieldName: BTX1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 1")]
		public string M3BTX1 => GetString("BTX1");

		/// <summary>
		/// Description: Text line  2
		/// FieldName: BTX2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  2")]
		public string M3BTX2 => GetString("BTX2");

		/// <summary>
		/// Description: Text line  3
		/// FieldName: BTX3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  3")]
		public string M3BTX3 => GetString("BTX3");

		/// <summary>
		/// Description: Text line 1
		/// FieldName: ATX1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 1")]
		public string M3ATX1 => GetString("ATX1");

		/// <summary>
		/// Description: Text line  2
		/// FieldName: ATX2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  2")]
		public string M3ATX2 => GetString("ATX2");
	}
}
// EOF
