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

namespace M3H5Lib.Api.MDBREADMI
{
	public partial class GetOCUSMA00Response : M3BaseRecord 
	{

		/// <summary>
		/// Description: Rec agr type 1
		/// FieldName: AGNT
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rec agr type 1")]
		public string M3AGNT => GetString("AGNT");

		/// <summary>
		/// Description: Rec agr type 2
		/// FieldName: AGN2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rec agr type 2")]
		public string M3AGN2 => GetString("AGN2");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Stat customer
		/// FieldName: CUST
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stat customer")]
		public string M3CUST => GetString("CUST");

		/// <summary>
		/// Description: Group customer
		/// FieldName: CCUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group customer")]
		public string M3CCUS => GetString("CCUS");

		/// <summary>
		/// Description: User-def fld 6
		/// FieldName: CFC6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-def fld 6")]
		public string M3CFC6 => GetString("CFC6");

		/// <summary>
		/// Description: Inv recipient
		/// FieldName: INRC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv recipient")]
		public string M3INRC => GetString("INRC");
	}
}
// EOF
