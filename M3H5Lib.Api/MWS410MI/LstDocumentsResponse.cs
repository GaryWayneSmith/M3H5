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

namespace M3H5Lib.Api.MWS410MI
{
	public partial class LstDocumentsResponse : M3BaseRecord 
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
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Direction
		/// FieldName: INOU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Direction")]
		public int? M3INOU => GetNullableInt("INOU");

		/// <summary>
		/// Description: Delivery number
		/// FieldName: DLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3DLIX => GetNullableDecimal("DLIX");

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
		/// Description: Shipment
		/// FieldName: CONN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment")]
		public int? M3CONN => GetNullableInt("CONN");

		/// <summary>
		/// Description: Delivery document number
		/// FieldName: FDNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery document number")]
		public string M3FDNO => GetString("FDNO");

		/// <summary>
		/// Description: Status - freight document
		/// FieldName: FDST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - freight document")]
		public string M3FDST => GetString("FDST");

		/// <summary>
		/// Description: Documents manually added
		/// FieldName: FDMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Documents manually added")]
		public int? M3FDMA => GetNullableInt("FDMA");

		/// <summary>
		/// Description: Documents changed
		/// FieldName: FDCG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Documents changed")]
		public int? M3FDCG => GetNullableInt("FDCG");

		/// <summary>
		/// Description: Date generated
		/// FieldName: GEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date generated")]
		public DateTime? M3GEDT => GetNullableDateTime("GEDT");

		/// <summary>
		/// Description: Time generated
		/// FieldName: GETM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time generated")]
		public int? M3GETM => GetNullableInt("GETM");

		/// <summary>
		/// Description: Last printout date
		/// FieldName: DODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last printout date")]
		public DateTime? M3DODT => GetNullableDateTime("DODT");

		/// <summary>
		/// Description: Printout time
		/// FieldName: POTI
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printout time")]
		public int? M3POTI => GetNullableInt("POTI");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Bill of lading number
		/// FieldName: NBOL
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bill of lading number")]
		public string M3NBOL => GetString("NBOL");

		/// <summary>
		/// Description: Master bill of lading number
		/// FieldName: MBOL
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Master bill of lading number")]
		public string M3MBOL => GetString("MBOL");

		/// <summary>
		/// Description: Shipment
		/// FieldName: KCON
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment")]
		public int? M3KCON => GetNullableInt("KCON");

		/// <summary>
		/// Description: Master connected
		/// FieldName: CMBL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Master connected")]
		public int? M3CMBL => GetNullableInt("CMBL");

		/// <summary>
		/// Description: Freight document alias ID
		/// FieldName: FDAL
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight document alias ID")]
		public string M3FDAL => GetString("FDAL");

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
		/// Description: Program name
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3PGNM => GetString("PGNM");
	}
}
// EOF
