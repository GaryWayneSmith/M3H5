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

namespace M3H5Lib.Api.ARS460MI
{
	public partial class GetAgByCustomerResponse : M3BaseRecord 
	{

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
		/// Description: Agreement proposal number
		/// FieldName: DDAN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement proposal number")]
		public long? M3DDAN => GetNullableLong("DDAN");

		/// <summary>
		/// Description: Bank account identity
		/// FieldName: BKI2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3BKI2 => GetString("BKI2");

		/// <summary>
		/// Description: Agreement indicator
		/// FieldName: AGIN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement indicator")]
		public string M3AGIN => GetString("AGIN");

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
		/// Description: Bank account identity
		/// FieldName: BKID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3BKID => GetString("BKID");

		/// <summary>
		/// Description: Bank EDI agreement number
		/// FieldName: BKAG
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank EDI agreement number")]
		public string M3BKAG => GetString("BKAG");

		/// <summary>
		/// Description: Customer stop
		/// FieldName: BLCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer stop")]
		public int? M3BLCD => GetNullableInt("BLCD");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: Valid from
		/// FieldName: VFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3VFDT => GetNullableDateTime("VFDT");

		/// <summary>
		/// Description: Valid to
		/// FieldName: VTDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3VTDT => GetNullableDateTime("VTDT");

		/// <summary>
		/// Description: Maximum invoice amount
		/// FieldName: MAXA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum invoice amount")]
		public decimal? M3MAXA => GetNullableDecimal("MAXA");

		/// <summary>
		/// Description: Maximum total amount
		/// FieldName: MTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum total amount")]
		public decimal? M3MTAM => GetNullableDecimal("MTAM");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Agreement 1
		/// FieldName: AGR1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 1")]
		public string M3AGR1 => GetString("AGR1");

		/// <summary>
		/// Description: Agreement 1
		/// FieldName: AGR2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 1")]
		public string M3AGR2 => GetString("AGR2");

		/// <summary>
		/// Description: Agreement 1
		/// FieldName: AGR3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 1")]
		public string M3AGR3 => GetString("AGR3");

		/// <summary>
		/// Description: Agreement 1
		/// FieldName: AGR4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 1")]
		public string M3AGR4 => GetString("AGR4");

		/// <summary>
		/// Description: Agreement 1
		/// FieldName: AGR5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 1")]
		public string M3AGR5 => GetString("AGR5");

		/// <summary>
		/// Description: Agreement 1
		/// FieldName: AGR6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 1")]
		public string M3AGR6 => GetString("AGR6");

		/// <summary>
		/// Description: Agreement 1
		/// FieldName: AGR7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement 1")]
		public string M3AGR7 => GetString("AGR7");

		/// <summary>
		/// Description: Length - agreement ID field 1
		/// FieldName: DIL1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - agreement ID field 1")]
		public int? M3DIL1 => GetNullableInt("DIL1");

		/// <summary>
		/// Description: Length - agreement ID field 2
		/// FieldName: DIL2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - agreement ID field 2")]
		public int? M3DIL2 => GetNullableInt("DIL2");

		/// <summary>
		/// Description: Length - agreement ID field 3
		/// FieldName: DIL3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - agreement ID field 3")]
		public int? M3DIL3 => GetNullableInt("DIL3");

		/// <summary>
		/// Description: Length - agreement ID field 4
		/// FieldName: DIL4
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - agreement ID field 4")]
		public int? M3DIL4 => GetNullableInt("DIL4");

		/// <summary>
		/// Description: Length - agreement ID field 5
		/// FieldName: DIL5
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - agreement ID field 5")]
		public int? M3DIL5 => GetNullableInt("DIL5");

		/// <summary>
		/// Description: Length - agreement ID field 6
		/// FieldName: DIL6
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - agreement ID field 6")]
		public int? M3DIL6 => GetNullableInt("DIL6");

		/// <summary>
		/// Description: Length - agreement ID field 7
		/// FieldName: DIL7
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - agreement ID field 7")]
		public int? M3DIL7 => GetNullableInt("DIL7");

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
	}
}
// EOF
