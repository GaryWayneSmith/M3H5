/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.CRS949MI
{
	public partial class GetPartnerMediaResponse : M3BaseRecord 
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
		/// Description: Media
		/// FieldName: MEDC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Media")]
		public string M3MEDC => GetString("MEDC");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SEQN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3SEQN => GetNullableInt("SEQN");

		/// <summary>
		/// Description: Service identity
		/// FieldName: SIID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service identity")]
		public string M3SIID => GetString("SIID");

		/// <summary>
		/// Description: Interface - media
		/// FieldName: MVIF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interface - media")]
		public string M3MVIF => GetString("MVIF");

		/// <summary>
		/// Description: Media category
		/// FieldName: METY
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Media category")]
		public string M3METY => GetString("METY");

		/// <summary>
		/// Description: Form
		/// FieldName: FMTP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Form")]
		public string M3FMTP => GetString("FMTP");

		/// <summary>
		/// Description: Number of copies
		/// FieldName: COPY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of copies")]
		public int? M3COPY => GetNullableInt("COPY");

		/// <summary>
		/// Description: Priority
		/// FieldName: OUTP
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public string M3OUTP => GetString("OUTP");

		/// <summary>
		/// Description: User data
		/// FieldName: UDTA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User data")]
		public string M3UDTA => GetString("UDTA");

		/// <summary>
		/// Description: Field selection
		/// FieldName: 1UDT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field selection")]
		public string M31UDT => GetString("1UDT");

		/// <summary>
		/// Description: Facsimile transmission number
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimile transmission number")]
		public string M3TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Fax text 1
		/// FieldName: TFT1
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fax text 1")]
		public string M3TFT1 => GetString("TFT1");

		/// <summary>
		/// Description: Field selection
		/// FieldName: 1TFT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field selection")]
		public string M31TFT => GetString("1TFT");

		/// <summary>
		/// Description: Folder name
		/// FieldName: FLRN
		/// FieldType: A
		/// Length: 63
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Folder name")]
		public string M3FLRN => GetString("FLRN");

		/// <summary>
		/// Description: File path
		/// FieldName: PAFD
		/// FieldType: A
		/// Length: 120
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File path")]
		public string M3PAFD => GetString("PAFD");

		/// <summary>
		/// Description: File suffix
		/// FieldName: FSUX
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File suffix")]
		public string M3FSUX => GetString("FSUX");

		/// <summary>
		/// Description: Generic name method
		/// FieldName: GNNM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Generic name method")]
		public int? M3GNNM => GetNullableInt("GNNM");

		/// <summary>
		/// Description: Printer
		/// FieldName: DEV
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer")]
		public string M3DEV => GetString("DEV");

		/// <summary>
		/// Description: Overlay front page name
		/// FieldName: FOVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overlay front page name")]
		public string M3FOVR => GetString("FOVR");

		/// <summary>
		/// Description: Bin
		/// FieldName: BINX
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bin")]
		public string M3BINX => GetString("BINX");

		/// <summary>
		/// Description: To email address
		/// FieldName: TOMA
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To email address")]
		public string M3TOMA => GetString("TOMA");

		/// <summary>
		/// Description: From email address
		/// FieldName: FRMA
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From email address")]
		public string M3FRMA => GetString("FRMA");

		/// <summary>
		/// Description: Copy to email address
		/// FieldName: CCMA
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Copy to email address")]
		public string M3CCMA => GetString("CCMA");

		/// <summary>
		/// Description: Send time - fax
		/// FieldName: FAXT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Send time - fax")]
		public int? M3FAXT => GetNullableInt("FAXT");

		/// <summary>
		/// Description: Subject
		/// FieldName: SUBJ
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subject")]
		public string M3SUBJ => GetString("SUBJ");

		/// <summary>
		/// Description: Note
		/// FieldName: NOTE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Note")]
		public string M3NOTE => GetString("NOTE");

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
		/// Description: User
		/// FieldName: LSID
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3LSID => GetString("LSID");

		/// <summary>
		/// Description: Address
		/// FieldName: LSAD
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address")]
		public string M3LSAD => GetString("LSAD");

		/// <summary>
		/// Description: Test flag
		/// FieldName: TEME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test flag")]
		public int? M3TEME => GetNullableInt("TEME");

		/// <summary>
		/// Description: Message type
		/// FieldName: E065
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message type")]
		public string M3E065 => GetString("E065");

		/// <summary>
		/// Description: Sender reference data 1
		/// FieldName: SRD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sender reference data 1")]
		public string M3SRD1 => GetString("SRD1");

		/// <summary>
		/// Description: Sender reference data 2
		/// FieldName: SRD2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sender reference data 2")]
		public string M3SRD2 => GetString("SRD2");

		/// <summary>
		/// Description: Receiver reference data 1
		/// FieldName: RRD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiver reference data 1")]
		public string M3RRD1 => GetString("RRD1");

		/// <summary>
		/// Description: Receiver reference data 2
		/// FieldName: RRD2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiver reference data 2")]
		public string M3RRD2 => GetString("RRD2");

		/// <summary>
		/// Description: Receiver reference data 3
		/// FieldName: RRD3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiver reference data 3")]
		public string M3RRD3 => GetString("RRD3");

		/// <summary>
		/// Description: Tray
		/// FieldName: TRAY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tray")]
		public string M3TRAY => GetString("TRAY");

		/// <summary>
		/// Description: Layout
		/// FieldName: LAYC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Layout")]
		public string M3LAYC => GetString("LAYC");

		/// <summary>
		/// Description: Country
		/// FieldName: MARI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3MARI => GetString("MARI");

		/// <summary>
		/// Description: Archive
		/// FieldName: ARCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Archive")]
		public int? M3ARCH => GetNullableInt("ARCH");

		/// <summary>
		/// Description: Connector ID
		/// FieldName: CNID
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Connector ID")]
		public int? M3CNID => GetNullableInt("CNID");

		/// <summary>
		/// Description: Event priority
		/// FieldName: EVPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event priority")]
		public int? M3EVPR => GetNullableInt("EVPR");

		/// <summary>
		/// Description: Business object name
		/// FieldName: BONM
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business object name")]
		public string M3BONM => GetString("BONM");

		/// <summary>
		/// Description: Event verb
		/// FieldName: BOVB
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event verb")]
		public string M3BOVB => GetString("BOVB");
	}
}
// EOF
