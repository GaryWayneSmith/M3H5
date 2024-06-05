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

namespace M3H5Lib.Api.MNS205MI
{
	public partial class LstResponse : M3BaseRecord 
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
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Printer file
		/// FieldName: PRTF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer file")]
		public string M3_PRTF => GetString("PRTF");

		/// <summary>
		/// Description: Workstation
		/// FieldName: DEVD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Workstation")]
		public string M3_DEVD => GetString("DEVD");

		/// <summary>
		/// Description: User
		/// FieldName: USID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3_USID => GetString("USID");

		/// <summary>
		/// Description: Media
		/// FieldName: MEDC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Media")]
		public string M3_MEDC => GetString("MEDC");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SEQN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3_SEQN => GetNullableInt("SEQN");

		/// <summary>
		/// Description: Form
		/// FieldName: FMTP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Form")]
		public string M3_FMTP => GetString("FMTP");

		/// <summary>
		/// Description: Number of copies
		/// FieldName: COPY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of copies")]
		public int? M3_COPY => GetNullableInt("COPY");

		/// <summary>
		/// Description: Priority
		/// FieldName: OUTP
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public string M3_OUTP => GetString("OUTP");

		/// <summary>
		/// Description: User data
		/// FieldName: UDTA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User data")]
		public string M3_UDTA => GetString("UDTA");

		/// <summary>
		/// Description: Facsimile transmission number
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimile transmission number")]
		public string M3_TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Fax text 1
		/// FieldName: TFT1
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fax text 1")]
		public string M3_TFT1 => GetString("TFT1");

		/// <summary>
		/// Description: Folder name
		/// FieldName: FLRN
		/// FieldType: A
		/// Length: 63
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Folder name")]
		public string M3_FLRN => GetString("FLRN");

		/// <summary>
		/// Description: Generic name method
		/// FieldName: GNNM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Generic name method")]
		public int? M3_GNNM => GetNullableInt("GNNM");

		/// <summary>
		/// Description: Path file
		/// FieldName: PAFD
		/// FieldType: A
		/// Length: 120
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Path file")]
		public string M3_PAFD => GetString("PAFD");

		/// <summary>
		/// Description: File suffix
		/// FieldName: FSUX
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File suffix")]
		public string M3_FSUX => GetString("FSUX");

		/// <summary>
		/// Description: Printer
		/// FieldName: DEV1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer")]
		public string M3_DEV1 => GetString("DEV1");

		/// <summary>
		/// Description: Overlay front page name
		/// FieldName: FOVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overlay front page name")]
		public string M3_FOVR => GetString("FOVR");

		/// <summary>
		/// Description: Tray
		/// FieldName: DRWR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tray")]
		public string M3_DRWR => GetString("DRWR");

		/// <summary>
		/// Description: Bin
		/// FieldName: BINX
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bin")]
		public string M3_BINX => GetString("BINX");

		/// <summary>
		/// Description: Tray
		/// FieldName: TRAY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tray")]
		public string M3_TRAY => GetString("TRAY");

		/// <summary>
		/// Description: To e-mail address
		/// FieldName: TOMA
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To e-mail address")]
		public string M3_TOMA => GetString("TOMA");

		/// <summary>
		/// Description: From e-mail address
		/// FieldName: FRMA
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From e-mail address")]
		public string M3_FRMA => GetString("FRMA");

		/// <summary>
		/// Description: Copy to e-mail address
		/// FieldName: CCMA
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Copy to e-mail address")]
		public string M3_CCMA => GetString("CCMA");

		/// <summary>
		/// Description: Send time - fax
		/// FieldName: FAXT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Send time - fax")]
		public int? M3_FAXT => GetNullableInt("FAXT");

		/// <summary>
		/// Description: Subject
		/// FieldName: SUBJ
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subject")]
		public string M3_SUBJ => GetString("SUBJ");

		/// <summary>
		/// Description: Note
		/// FieldName: NOT1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Note")]
		public string M3_NOT1 => GetString("NOT1");

		/// <summary>
		/// Description: Market identification
		/// FieldName: MARI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Market identification")]
		public string M3_MARI => GetString("MARI");

		/// <summary>
		/// Description: Layout
		/// FieldName: LAYC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Layout")]
		public string M3_LAYC => GetString("LAYC");
	}
}
// EOF
