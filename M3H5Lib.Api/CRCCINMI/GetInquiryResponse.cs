/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 3/9/2024 12:26:01 AM
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
/// All fields are prefixed with M3_ as C# doesn not handle numeric leading
/// digits and some return values fall into this category.  So it was decided
/// that we standardize on a leading prefix

using M3H5Lib.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace M3H5Lib.Api.CRCCINMI
{
	public partial class GetInquiryResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Credit card error code
		/// FieldName: CCEC
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit card error code")]
		public string M3_CCEC => GetString("CCEC");

		/// <summary>
		/// Description: Message text
		/// FieldName: MSG1
		/// FieldType: A
		/// Length: 128
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text")]
		public string M3_MSG1 => GetString("MSG1");

		/// <summary>
		/// Description: Message text
		/// FieldName: MSG2
		/// FieldType: A
		/// Length: 128
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text")]
		public string M3_MSG2 => GetString("MSG2");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");
	}
}
// EOF
