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

namespace M3H5Lib.Api.MNS260MI
{
	public partial class LstMBMInitResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: MBM Initiator Name
		/// FieldName: BMIN
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MBM Initiator Name")]
		public string M3BMIN => GetString("BMIN");

		/// <summary>
		/// Description: MBM Initiator Type
		/// FieldName: BMIT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MBM Initiator Type")]
		public string M3BMIT => GetString("BMIT");

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
		/// Description: Automatic resend
		/// FieldName: ARSD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic resend")]
		public int? M3ARSD => GetNullableInt("ARSD");

		/// <summary>
		/// Description: Document number
		/// FieldName: DONR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document number")]
		public string M3DONR => GetString("DONR");

		/// <summary>
		/// Description: Document variant
		/// FieldName: DOVA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document variant")]
		public string M3DOVA => GetString("DOVA");

		/// <summary>
		/// Description: Media profile
		/// FieldName: MEPF
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Media profile")]
		public string M3MEPF => GetString("MEPF");

		/// <summary>
		/// Description: Document/media controlling object 1
		/// FieldName: PRF1
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document/media controlling object 1")]
		public string M3PRF1 => GetString("PRF1");

		/// <summary>
		/// Description: Document/media control object 2
		/// FieldName: PRF2
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document/media control object 2")]
		public string M3PRF2 => GetString("PRF2");

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
		/// Description: Printer file
		/// FieldName: PRTF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer file")]
		public string M3PRTF => GetString("PRTF");

		/// <summary>
		/// Description: Copy
		/// FieldName: CPPL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Copy")]
		public int? M3CPPL => GetNullableInt("CPPL");

		/// <summary>
		/// Description: Field
		/// FieldName: OBJC
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OBJC => GetString("OBJC");

		/// <summary>
		/// Description: Document identity
		/// FieldName: DONO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3DONO => GetString("DONO");

		/// <summary>
		/// Description: Message key field 4
		/// FieldName: MKF4
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message key field 4")]
		public string M3MKF4 => GetString("MKF4");

		/// <summary>
		/// Description: Message key value 4
		/// FieldName: MKV4
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message key value 4")]
		public string M3MKV4 => GetString("MKV4");

		/// <summary>
		/// Description: Message key field 5
		/// FieldName: MKF5
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message key field 5")]
		public string M3MKF5 => GetString("MKF5");

		/// <summary>
		/// Description: Message key value 5
		/// FieldName: MKV5
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message key value 5")]
		public string M3MKV5 => GetString("MKV5");

		/// <summary>
		/// Description: Message key field 6
		/// FieldName: MKF6
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message key field 6")]
		public string M3MKF6 => GetString("MKF6");

		/// <summary>
		/// Description: Message key value 6
		/// FieldName: MKV6
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message key value 6")]
		public string M3MKV6 => GetString("MKV6");

		/// <summary>
		/// Description: Message key field 7
		/// FieldName: MKF7
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message key field 7")]
		public string M3MKF7 => GetString("MKF7");

		/// <summary>
		/// Description: Message key value 7
		/// FieldName: MKV7
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message key value 7")]
		public string M3MKV7 => GetString("MKV7");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change time
		/// FieldName: LMTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change time")]
		public int? M3LMTM => GetNullableInt("LMTM");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");
	}
}
// EOF
