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

namespace M3H5Lib.Api.CRCCINMI
{
	public partial class AddAuthResponse : M3BaseRecord 
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
		public string M3CCEC => GetString("CCEC");

		/// <summary>
		/// Description: Message text
		/// FieldName: MSG1
		/// FieldType: A
		/// Length: 128
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text")]
		public string M3MSG1 => GetString("MSG1");

		/// <summary>
		/// Description: Message text
		/// FieldName: MSG2
		/// FieldType: A
		/// Length: 128
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text")]
		public string M3MSG2 => GetString("MSG2");

		/// <summary>
		/// Description: Reference number
		/// FieldName: NREF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference number")]
		public string M3NREF => GetString("NREF");

		/// <summary>
		/// Description: 3rd party provider
		/// FieldName: TRDP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("3rd party provider")]
		public string M3TRDP => GetString("TRDP");

		/// <summary>
		/// Description: Address verification service
		/// FieldName: AVS1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address verification service")]
		public string M3AVS1 => GetString("AVS1");

		/// <summary>
		/// Description: Address verification service
		/// FieldName: AVS2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address verification service")]
		public string M3AVS2 => GetString("AVS2");

		/// <summary>
		/// Description: Address verification service
		/// FieldName: AVS3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address verification service")]
		public string M3AVS3 => GetString("AVS3");

		/// <summary>
		/// Description: Address verification service
		/// FieldName: AVS4
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address verification service")]
		public string M3AVS4 => GetString("AVS4");

		/// <summary>
		/// Description: Card sequrity code check response
		/// FieldName: CSC2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Card sequrity code check response")]
		public string M3CSC2 => GetString("CSC2");

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
		/// Description: 3rd-party id
		/// FieldName: TRDI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("3rd-party id")]
		public string M3TRDI => GetString("TRDI");
	}
}
// EOF
