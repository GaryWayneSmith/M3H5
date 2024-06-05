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

namespace M3H5Lib.Api.CRS620MI
{
	public partial class LstByNameResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3_CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Suppliernumber
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliernumber")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Suppliertype
		/// FieldName: SUTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliertype")]
		public int? M3_SUTY => GetNullableInt("SUTY");

		/// <summary>
		/// Description: Suppliername
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliername")]
		public string M3_SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Searchkey
		/// FieldName: ALSU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Searchkey")]
		public string M3_ALSU => GetString("ALSU");

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

		/// <summary>
		/// Description: Organizationnumber1
		/// FieldName: CORG
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organizationnumber1")]
		public string M3_CORG => GetString("CORG");

		/// <summary>
		/// Description: Organizationnumber2
		/// FieldName: COR2
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organizationnumber2")]
		public string M3_COR2 => GetString("COR2");

		/// <summary>
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3_LNCD => GetString("LNCD");

		/// <summary>
		/// Description: Telephonenumber1
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephonenumber1")]
		public string M3_PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Telephonenumber2
		/// FieldName: PHN2
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephonenumber2")]
		public string M3_PHN2 => GetString("PHN2");

		/// <summary>
		/// Description: Telexnumber
		/// FieldName: TLNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telexnumber")]
		public string M3_TLNO => GetString("TLNO");

		/// <summary>
		/// Description: Facsimiletransmissionnumber
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimiletransmissionnumber")]
		public string M3_TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Country
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3_CSCD => GetString("CSCD");

		/// <summary>
		/// Description: Dateformat
		/// FieldName: DTFM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dateformat")]
		public string M3_DTFM => GetString("DTFM");

		/// <summary>
		/// Description: Dateediting
		/// FieldName: EDIT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dateediting")]
		public string M3_EDIT => GetString("EDIT");

		/// <summary>
		/// Description: VATregistrationnumber
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VATregistrationnumber")]
		public string M3_VRNO => GetString("VRNO");

		/// <summary>
		/// Description: Suppliernumberwithingroup
		/// FieldName: SUCO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliernumberwithingroup")]
		public string M3_SUCO => GetString("SUCO");

		/// <summary>
		/// Description: Supplieralternativeidentity
		/// FieldName: SUAL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplieralternativeidentity")]
		public string M3_SUAL => GetString("SUAL");

		/// <summary>
		/// Description: Suppliercomutercommunicationaddress
		/// FieldName: SUCM
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliercomutercommunicationaddress")]
		public string M3_SUCM => GetString("SUCM");

		/// <summary>
		/// Description: Mediaprofile
		/// FieldName: MEPF
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mediaprofile")]
		public string M3_MEPF => GetString("MEPF");

		/// <summary>
		/// Description: Transmissionleadtime-supplier
		/// FieldName: PODA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transmissionleadtime-supplier")]
		public int? M3_PODA => GetNullableInt("PODA");

		/// <summary>
		/// Description: User-definedfield1-item
		/// FieldName: SFI1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield1-item")]
		public string M3_SFI1 => GetString("SFI1");

		/// <summary>
		/// Description: User-definedfield2-item
		/// FieldName: SFI2
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield2-item")]
		public int? M3_SFI2 => GetNullableInt("SFI2");

		/// <summary>
		/// Description: User-definedfield3-item
		/// FieldName: SFI3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield3-item")]
		public string M3_SFI3 => GetString("SFI3");

		/// <summary>
		/// Description: User-definedfield4-item
		/// FieldName: SFI4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield4-item")]
		public string M3_SFI4 => GetString("SFI4");

		/// <summary>
		/// Description: User-definedfield5-item
		/// FieldName: SFI5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-definedfield5-item")]
		public string M3_SFI5 => GetString("SFI5");

		/// <summary>
		/// Description: HarbourorAirport
		/// FieldName: HAFE
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("HarbourorAirport")]
		public string M3_HAFE => GetString("HAFE");

		/// <summary>
		/// Description: Textidentity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Textidentity")]
		public int? M3_TXID => GetNullableInt("TXID");

		/// <summary>
		/// Description: Area/State
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Area/State")]
		public string M3_ECAR => GetString("ECAR");

		/// <summary>
		/// Description: SCACCode
		/// FieldName: FWSC
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SCACCode")]
		public string M3_FWSC => GetString("FWSC");

		/// <summary>
		/// Description: Rail station
		/// FieldName: RASN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rail station")]
		public string M3_RASN => GetString("RASN");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXI2
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXI2 => GetNullableDecimal("TXI2");
	}
}
// EOF
