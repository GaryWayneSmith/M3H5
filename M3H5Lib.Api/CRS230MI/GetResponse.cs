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

namespace M3H5Lib.Api.CRS230MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Document identity
		/// FieldName: DOID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3DOID => GetString("DOID");

		/// <summary>
		/// Description: Document type
		/// FieldName: DOTY
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document type")]
		public string M3DOTY => GetString("DOTY");

		/// <summary>
		/// Description: Doc. type description
		/// FieldName: DTDS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Doc. type description")]
		public string M3DTDS => GetString("DTDS");

		/// <summary>
		/// Description: Document subtype
		/// FieldName: ADS1
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document subtype")]
		public string M3ADS1 => GetString("ADS1");

		/// <summary>
		/// Description: Doc. subtype description
		/// FieldName: STDS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Doc. subtype description")]
		public string M3STDS => GetString("STDS");

		/// <summary>
		/// Description: Document issuer
		/// FieldName: AISB
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document issuer")]
		public string M3AISB => GetString("AISB");

		/// <summary>
		/// Description: Issuer name
		/// FieldName: ISNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issuer name")]
		public string M3ISNM => GetString("ISNM");

		/// <summary>
		/// Description: Document number
		/// FieldName: DNUM
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document number")]
		public string M3DNUM => GetString("DNUM");

		/// <summary>
		/// Description: Document object
		/// FieldName: ADOB
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document object")]
		public string M3ADOB => GetString("ADOB");

		/// <summary>
		/// Description: Status - document
		/// FieldName: DOSS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - document")]
		public string M3DOSS => GetString("DOSS");

		/// <summary>
		/// Description: Document application
		/// FieldName: DOFM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document application")]
		public string M3DOFM => GetString("DOFM");

		/// <summary>
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3LNCD => GetString("LNCD");

		/// <summary>
		/// Description: ECO managed
		/// FieldName: ECMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ECO managed")]
		public int? M3ECMA => GetNullableInt("ECMA");

		/// <summary>
		/// Description: Revision number
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3ECVE => GetString("ECVE");

		/// <summary>
		/// Description: Name
		/// FieldName: DODE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3DODE => GetString("DODE");

		/// <summary>
		/// Description: Subject
		/// FieldName: ASBJ
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subject")]
		public string M3ASBJ => GetString("ASBJ");

		/// <summary>
		/// Description: Subject
		/// FieldName: ASB2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subject")]
		public string M3ASB2 => GetString("ASB2");

		/// <summary>
		/// Description: Document media
		/// FieldName: DOME
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document media")]
		public string M3DOME => GetString("DOME");

		/// <summary>
		/// Description: File location
		/// FieldName: FIOF
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File location")]
		public string M3FIOF => GetString("FIOF");

		/// <summary>
		/// Description: Function area
		/// FieldName: FUNC
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function area")]
		public string M3FUNC => GetString("FUNC");

		/// <summary>
		/// Description: Standard numbering system
		/// FieldName: STNC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard numbering system")]
		public string M3STNC => GetString("STNC");

		/// <summary>
		/// Description: Document group
		/// FieldName: DGRP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document group")]
		public string M3DGRP => GetString("DGRP");

		/// <summary>
		/// Description: Group description
		/// FieldName: GRDS
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group description")]
		public string M3GRDS => GetString("GRDS");

		/// <summary>
		/// Description: Modification document
		/// FieldName: MDOC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Modification document")]
		public int? M3MDOC => GetNullableInt("MDOC");

		/// <summary>
		/// Description: Authority document
		/// FieldName: DAUT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authority document")]
		public int? M3DAUT => GetNullableInt("DAUT");

		/// <summary>
		/// Description: Document issuer code
		/// FieldName: DINT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document issuer code")]
		public int? M3DINT => GetNullableInt("DINT");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3RESP => GetString("RESP");

		/// <summary>
		/// Description: Name of user responsible
		/// FieldName: RSDS
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name of user responsible")]
		public string M3RSDS => GetString("RSDS");

		/// <summary>
		/// Description: Department
		/// FieldName: DEPT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department")]
		public string M3DEPT => GetString("DEPT");

		/// <summary>
		/// Description: Department name
		/// FieldName: DPNM
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department name")]
		public string M3DPNM => GetString("DPNM");

		/// <summary>
		/// Description: Resp. engineering department
		/// FieldName: AREG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Resp. engineering department")]
		public string M3AREG => GetString("AREG");

		/// <summary>
		/// Description: Resp. engineering dept. name
		/// FieldName: RENM
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Resp. engineering dept. name")]
		public string M3RENM => GetString("RENM");

		/// <summary>
		/// Description: Date issued
		/// FieldName: AISD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date issued")]
		public DateTime? M3AISD => GetNullableDateTime("AISD");

		/// <summary>
		/// Description: Effectivity date From
		/// FieldName: AEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effectivity date From")]
		public DateTime? M3AEDT => GetNullableDateTime("AEDT");

		/// <summary>
		/// Description: Effectivity date To
		/// FieldName: AED2
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effectivity date To")]
		public DateTime? M3AED2 => GetNullableDateTime("AED2");

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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Revision service
		/// FieldName: ARVS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision service")]
		public int? M3ARVS => GetNullableInt("ARVS");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Compliance code
		/// FieldName: ACPL
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compliance code")]
		public string M3ACPL => GetString("ACPL");

		/// <summary>
		/// Description: Engineering order accomplishment date
		/// FieldName: AADA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Engineering order accomplishment date")]
		public DateTime? M3AADA => GetNullableDateTime("AADA");

		/// <summary>
		/// Description: Amendment text
		/// FieldName: AMTX
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amendment text")]
		public string M3AMTX => GetString("AMTX");

		/// <summary>
		/// Description: Text
		/// FieldName: ACPT
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3ACPT => GetString("ACPT");

		/// <summary>
		/// Description: Text
		/// FieldName: ACP2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3ACP2 => GetString("ACP2");
	}
}
// EOF
