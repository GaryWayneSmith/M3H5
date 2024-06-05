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

namespace M3H5Lib.Api.CRS682MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Insurance type
		/// FieldName: ITRQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance type")]
		public int? M3ITRQ => GetNullableInt("ITRQ");

		/// <summary>
		/// Description: Insurance ID
		/// FieldName: CIID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance ID")]
		public string M3CIID => GetString("CIID");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Insurance required
		/// FieldName: INRQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance required")]
		public int? M3INRQ => GetNullableInt("INRQ");

		/// <summary>
		/// Description: Insured from date
		/// FieldName: INFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insured from date")]
		public DateTime? M3INFD => GetNullableDateTime("INFD");

		/// <summary>
		/// Description: Insured to date
		/// FieldName: INTD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insured to date")]
		public DateTime? M3INTD => GetNullableDateTime("INTD");

		/// <summary>
		/// Description: Insured for amount
		/// FieldName: INFA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insured for amount")]
		public decimal? M3INFA => GetNullableDecimal("INFA");

		/// <summary>
		/// Description: Insurance policy no
		/// FieldName: IPOL
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance policy no")]
		public string M3IPOL => GetString("IPOL");

		/// <summary>
		/// Description: Insurance vendor
		/// FieldName: IVEN
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance vendor")]
		public string M3IVEN => GetString("IVEN");

		/// <summary>
		/// Description: Note
		/// FieldName: NOT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Note")]
		public string M3NOT1 => GetString("NOT1");

		/// <summary>
		/// Description: Note
		/// FieldName: NOT2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Note")]
		public string M3NOT2 => GetString("NOT2");
	}
}
// EOF
