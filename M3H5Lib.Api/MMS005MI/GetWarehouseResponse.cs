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

namespace M3H5Lib.Api.MMS005MI
{
	public partial class GetWarehouseResponse : M3BaseRecord 
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
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

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
		/// Description: Warehouse name
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse name")]
		public string M3_WHNM => GetString("WHNM");

		/// <summary>
		/// Description: Shop info
		/// FieldName: STOF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shop info")]
		public int? M3_STOF => GetNullableInt("STOF");

		/// <summary>
		/// Description: DC info
		/// FieldName: DCIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("DC info")]
		public int? M3_DCIN => GetNullableInt("DCIN");

		/// <summary>
		/// Description: Warehouse alias
		/// FieldName: RSTN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse alias")]
		public string M3_RSTN => GetString("RSTN");

		/// <summary>
		/// Description: Phone Number
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Phone Number")]
		public string M3_PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Company name
		/// FieldName: CONM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company name")]
		public string M3_CONM => GetString("CONM");

		/// <summary>
		/// Description: Address line 1
		/// FieldName: ADR1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 1")]
		public string M3_ADR1 => GetString("ADR1");

		/// <summary>
		/// Description: Address line 2
		/// FieldName: ADR2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 2")]
		public string M3_ADR2 => GetString("ADR2");

		/// <summary>
		/// Description: Address line 3
		/// FieldName: ADR3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 3")]
		public string M3_ADR3 => GetString("ADR3");

		/// <summary>
		/// Description: Address line 4
		/// FieldName: ADR4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 4")]
		public string M3_ADR4 => GetString("ADR4");

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
		/// Description: Postal code (Zip code)
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code (Zip code)")]
		public string M3_PONO => GetString("PONO");

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
		/// Description: Town/City
		/// FieldName: TOWN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Town/City")]
		public string M3_TOWN => GetString("TOWN");

		/// <summary>
		/// Description: Planning Node
		/// FieldName: PNOD
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning Node")]
		public string M3_PNOD => GetString("PNOD");

		/// <summary>
		/// Description: Geographic cod X
		/// FieldName: GEOX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic cod X")]
		public decimal? M3_GEOX => GetNullableDecimal("GEOX");

		/// <summary>
		/// Description: Geographic code Y
		/// FieldName: GEOY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic code Y")]
		public decimal? M3_GEOY => GetNullableDecimal("GEOY");

		/// <summary>
		/// Description: Geographic cod  Z
		/// FieldName: GEOZ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic cod  Z")]
		public decimal? M3_GEOZ => GetNullableDecimal("GEOZ");

		/// <summary>
		/// Description: Geographic cod X
		/// FieldName: AGEX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic cod X")]
		public decimal? M3_AGEX => GetNullableDecimal("AGEX");

		/// <summary>
		/// Description: Geographic code Y
		/// FieldName: AGEY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic code Y")]
		public decimal? M3_AGEY => GetNullableDecimal("AGEY");

		/// <summary>
		/// Description: Geographic cod  Z
		/// FieldName: AGEZ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic cod  Z")]
		public decimal? M3_AGEZ => GetNullableDecimal("AGEZ");

		/// <summary>
		/// Description: Time zone
		/// FieldName: TIZO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time zone")]
		public string M3_TIZO => GetString("TIZO");

		/// <summary>
		/// Description: Description of timezone
		/// FieldName: T40X
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description of timezone")]
		public string M3_T40X => GetString("T40X");

		/// <summary>
		/// Description: Name of timezone
		/// FieldName: T15X
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name of timezone")]
		public string M3_T15X => GetString("T15X");

		/// <summary>
		/// Description: Number of hours from UTC
		/// FieldName: TGMT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of hours from UTC")]
		public int? M3_TGMT => GetNullableInt("TGMT");

		/// <summary>
		/// Description: Daylight savings time
		/// FieldName: DLST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Daylight savings time")]
		public int? M3_DLST => GetNullableInt("DLST");

		/// <summary>
		/// Description: Valid from
		/// FieldName: VFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3_VFDT => GetNullableDateTime("VFDT");

		/// <summary>
		/// Description: Valid to
		/// FieldName: VTDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3_VTDT => GetNullableDateTime("VTDT");

		/// <summary>
		/// Description: Main warehouse
		/// FieldName: MAWH
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main warehouse")]
		public string M3_MAWH => GetString("MAWH");

		/// <summary>
		/// Description: Put away task grouping
		/// FieldName: PWGR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Put away task grouping")]
		public int? M3_PWGR => GetNullableInt("PWGR");

		/// <summary>
		/// Description: County ID
		/// FieldName: FRCO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County ID")]
		public string M3_FRCO => GetString("FRCO");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3_CUNO => GetString("CUNO");

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
		/// Description: Standard point location code
		/// FieldName: SPLE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard point location code")]
		public string M3_SPLE => GetString("SPLE");

		/// <summary>
		/// Description: Warehouse type
		/// FieldName: WHTY
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse type")]
		public string M3_WHTY => GetString("WHTY");

		/// <summary>
		/// Description: Mobile warehouse
		/// FieldName: MWHL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mobile warehouse")]
		public int? M3_MWHL => GetNullableInt("MWHL");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Redistribution location
		/// FieldName: RDIL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Redistribution location")]
		public string M3_RDIL => GetString("RDIL");

		/// <summary>
		/// Description: Transport cost per unit of weght
		/// FieldName: TCUW
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport cost per unit of weght")]
		public decimal? M3_TCUW => GetNullableDecimal("TCUW");

		/// <summary>
		/// Description: Warehouse operations cost per one qunatity
		/// FieldName: WOPC
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse operations cost per one qunatity")]
		public decimal? M3_WOPC => GetNullableDecimal("WOPC");

		/// <summary>
		/// Description: Warehouse subtype
		/// FieldName: WHSY
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse subtype")]
		public string M3_WHSY => GetString("WHSY");

		/// <summary>
		/// Description: Communication address
		/// FieldName: COMA
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Communication address")]
		public string M3_COMA => GetString("COMA");

		/// <summary>
		/// Description: Place of loading
		/// FieldName: SDES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place of loading")]
		public string M3_SDES => GetString("SDES");

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
		/// Description: To location
		/// FieldName: TWSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To location")]
		public string M3_TWSL => GetString("TWSL");

		/// <summary>
		/// Description: Cross-dock
		/// FieldName: CDYN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cross-dock")]
		public int? M3_CDYN => GetNullableInt("CDYN");

		/// <summary>
		/// Description: Automatic add permitted
		/// FieldName: AUAD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic add permitted")]
		public int? M3_AUAD => GetNullableInt("AUAD");
	}
}
// EOF
