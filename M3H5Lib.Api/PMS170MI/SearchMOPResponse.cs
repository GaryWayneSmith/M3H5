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

namespace M3H5Lib.Api.PMS170MI
{
	public partial class SearchMOPResponse : M3BaseRecord 
	{

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
		/// Description: Product
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product")]
		public string M3PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Planned order
		/// FieldName: PLPN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned order")]
		public int? M3PLPN => GetNullableInt("PLPN");

		/// <summary>
		/// Description: Subnumber - planned order
		/// FieldName: PLPS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnumber - planned order")]
		public int? M3PLPS => GetNullableInt("PLPS");

		/// <summary>
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Finish date
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish date")]
		public DateTime? M3FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Finish time
		/// FieldName: MFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish time")]
		public int? M3MFTI => GetNullableInt("MFTI");

		/// <summary>
		/// Description: Start time
		/// FieldName: MSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time")]
		public int? M3MSTI => GetNullableInt("MSTI");

		/// <summary>
		/// Description: Ordered quantity - alternate U/M
		/// FieldName: ORQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - alternate U/M")]
		public decimal? M3ORQA => GetNullableDecimal("ORQA");

		/// <summary>
		/// Description: Manufacturing U/M
		/// FieldName: MAUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing U/M")]
		public string M3MAUN => GetString("MAUN");

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
		/// Description: Process
		/// FieldName: MFPC
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Process")]
		public string M3MFPC => GetString("MFPC");

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

		/// <summary>
		/// Description: File
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FILE => GetString("FILE");

		/// <summary>
		/// Description: Key string
		/// FieldName: KSTR
		/// FieldType: A
		/// Length: 480
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key string")]
		public string M3KSTR => GetString("KSTR");
	}
}
// EOF
