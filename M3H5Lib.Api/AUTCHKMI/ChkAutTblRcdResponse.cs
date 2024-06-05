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

namespace M3H5Lib.Api.AUTCHKMI
{
	public partial class ChkAutTblRcdResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Authorized
		/// FieldName: TX05
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorized")]
		public string M3TX05 => GetString("TX05");

		/// <summary>
		/// Description: Message ID
		/// FieldName: MSID
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message ID")]
		public string M3MSID => GetString("MSID");

		/// <summary>
		/// Description: Message
		/// FieldName: MSGD
		/// FieldType: A
		/// Length: 78
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message")]
		public string M3MSGD => GetString("MSGD");
	}
}
// EOF
