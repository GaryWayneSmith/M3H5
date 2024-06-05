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

namespace M3H5Lib.Api.COS406MI
{
	public partial class LstAgrTypeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Agreement type
		/// FieldName: AGTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement type")]
		public string M3AGTP => GetString("AGTP");

		/// <summary>
		/// Description: Service stop
		/// FieldName: LSCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service stop")]
		public int? M3LSCD => GetNullableInt("LSCD");

		/// <summary>
		/// Description: Invoice block
		/// FieldName: ILCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice block")]
		public int? M3ILCD => GetNullableInt("ILCD");

		/// <summary>
		/// Description: Invoicing interval - years
		/// FieldName: IIYR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing interval - years")]
		public int? M3IIYR => GetNullableInt("IIYR");

		/// <summary>
		/// Description: Invoicing interval - months
		/// FieldName: IIMO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing interval - months")]
		public int? M3IIMO => GetNullableInt("IIMO");

		/// <summary>
		/// Description: Invoicing interval - days
		/// FieldName: IIDA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing interval - days")]
		public int? M3IIDA => GetNullableInt("IIDA");

		/// <summary>
		/// Description: Invoicing method
		/// FieldName: INVM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing method")]
		public string M3INVM => GetString("INVM");
	}
}
// EOF
