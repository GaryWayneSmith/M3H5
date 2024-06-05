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

namespace M3H5Lib.Api.PPS360MI
{
	public partial class GetHeadResponse : M3BaseRecord 
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
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Warehouse description
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse description")]
		public string M3_WHNM => GetString("WHNM");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Supplier type
		/// FieldName: SUTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier type")]
		public int? M3_SUTY => GetNullableInt("SUTY");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3_SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Delivery note number
		/// FieldName: SUDO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note number")]
		public string M3_SUDO => GetString("SUDO");

		/// <summary>
		/// Description: Delivery note date
		/// FieldName: DNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note date")]
		public DateTime? M3_DNDT => GetNullableDateTime("DNDT");

		/// <summary>
		/// Description: Delivery note time
		/// FieldName: DNTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note time")]
		public int? M3_DNTM => GetNullableInt("DNTM");

		/// <summary>
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3_ADID => GetString("ADID");

		/// <summary>
		/// Description: Partner
		/// FieldName: E0PA
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner")]
		public string M3_E0PA => GetString("E0PA");

		/// <summary>
		/// Description: Code list qualifier
		/// FieldName: E0QA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code list qualifier")]
		public string M3_E0QA => GetString("E0QA");

		/// <summary>
		/// Description: Planned delivery date
		/// FieldName: DLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned delivery date")]
		public DateTime? M3_DLDT => GetNullableDateTime("DLDT");

		/// <summary>
		/// Description: Time of delivery
		/// FieldName: DLTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time of delivery")]
		public int? M3_DLTM => GetNullableInt("DLTM");

		/// <summary>
		/// Description: Requested departure date
		/// FieldName: SHD4
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested departure date")]
		public DateTime? M3_SHD4 => GetNullableDateTime("SHD4");

		/// <summary>
		/// Description: Requested departure time
		/// FieldName: SHTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested departure time")]
		public int? M3_SHTM => GetNullableInt("SHTM");

		/// <summary>
		/// Description: Receipt date
		/// FieldName: RCDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt date")]
		public DateTime? M3_RCDT => GetNullableDateTime("RCDT");

		/// <summary>
		/// Description: Receipt time
		/// FieldName: RCTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt time")]
		public int? M3_RCTM => GetNullableInt("RCTM");

		/// <summary>
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3_MODL => GetString("MODL");

		/// <summary>
		/// Description: Transport identity - departure
		/// FieldName: E0B4
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport identity - departure")]
		public string M3_E0B4 => GetString("E0B4");

		/// <summary>
		/// Description: Trailer registration number
		/// FieldName: E0BH
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trailer registration number")]
		public string M3_E0BH => GetString("E0BH");

		/// <summary>
		/// Description: Transport nationality - departure
		/// FieldName: E0B5
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport nationality - departure")]
		public string M3_E0B5 => GetString("E0B5");

		/// <summary>
		/// Description: Delivery terms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms")]
		public string M3_TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Your reference 1
		/// FieldName: YREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference 1")]
		public string M3_YREF => GetString("YREF");

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
		/// Description: VAT registration number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3_VRNO => GetString("VRNO");

		/// <summary>
		/// Description: Order category
		/// FieldName: ORCA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order category")]
		public string M3_ORCA => GetString("ORCA");

		/// <summary>
		/// Description: Delivery schedule
		/// FieldName: DPNR
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule")]
		public string M3_DPNR => GetString("DPNR");

		/// <summary>
		/// Description: Delivery contract number
		/// FieldName: RSAG
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery contract number")]
		public string M3_RSAG => GetString("RSAG");

		/// <summary>
		/// Description: Supplier order number
		/// FieldName: SORN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier order number")]
		public string M3_SORN => GetString("SORN");

		/// <summary>
		/// Description: Lowest status - purchase order
		/// FieldName: PUSL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest status - purchase order")]
		public string M3_PUSL => GetString("PUSL");

		/// <summary>
		/// Description: Highest status - purchase order
		/// FieldName: PUST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status - purchase order")]
		public string M3_PUST => GetString("PUST");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: User-defined field 1 supplier
		/// FieldName: CFH1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 supplier")]
		public string M3_CFH1 => GetString("CFH1");

		/// <summary>
		/// Description: User-defined field 1 - import tracking
		/// FieldName: CFK1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - import tracking")]
		public string M3_CFK1 => GetString("CFK1");

		/// <summary>
		/// Description: User-defined field 1 supplier
		/// FieldName: CFH2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 supplier")]
		public string M3_CFH2 => GetString("CFH2");

		/// <summary>
		/// Description: User-defined field 2 - import tracking
		/// FieldName: CFK2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - import tracking")]
		public string M3_CFK2 => GetString("CFK2");

		/// <summary>
		/// Description: User-defined field 1 supplier
		/// FieldName: CFH3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 supplier")]
		public string M3_CFH3 => GetString("CFH3");

		/// <summary>
		/// Description: User-defined field 3 - import tracking
		/// FieldName: CFK3
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - import tracking")]
		public string M3_CFK3 => GetString("CFK3");

		/// <summary>
		/// Description: User-defined field 1 supplier
		/// FieldName: CFH4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 supplier")]
		public string M3_CFH4 => GetString("CFH4");

		/// <summary>
		/// Description: User-defined field 4 - import tracking
		/// FieldName: CFK4
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - import tracking")]
		public string M3_CFK4 => GetString("CFK4");

		/// <summary>
		/// Description: User-defined field 1 supplier
		/// FieldName: CFH5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 supplier")]
		public string M3_CFH5 => GetString("CFH5");

		/// <summary>
		/// Description: User-defined field 5 - import tracking
		/// FieldName: CFK5
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - import tracking")]
		public string M3_CFK5 => GetString("CFK5");

		/// <summary>
		/// Description: User-defined field 1 supplier
		/// FieldName: CFH6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 supplier")]
		public string M3_CFH6 => GetString("CFH6");

		/// <summary>
		/// Description: User-defined date 1 - import tracking
		/// FieldName: CFK6
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined date 1 - import tracking")]
		public DateTime? M3_CFK6 => GetNullableDateTime("CFK6");

		/// <summary>
		/// Description: User-defined field 1 supplier
		/// FieldName: CFH7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 supplier")]
		public string M3_CFH7 => GetString("CFH7");

		/// <summary>
		/// Description: User-defined date 2 - import tracking
		/// FieldName: CFK7
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined date 2 - import tracking")]
		public DateTime? M3_CFK7 => GetNullableDateTime("CFK7");

		/// <summary>
		/// Description: User-defined field 1 supplier
		/// FieldName: CFH8
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 supplier")]
		public string M3_CFH8 => GetString("CFH8");

		/// <summary>
		/// Description: User-defined date 3 - import tracking
		/// FieldName: CFK8
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined date 3 - import tracking")]
		public DateTime? M3_CFK8 => GetNullableDateTime("CFK8");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");
	}
}
// EOF
