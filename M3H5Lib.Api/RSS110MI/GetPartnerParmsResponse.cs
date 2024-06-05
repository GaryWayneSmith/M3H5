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

namespace M3H5Lib.Api.RSS110MI
{
	public partial class GetPartnerParmsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Delivery schedule type
		/// FieldName: DSTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule type")]
		public string M3_DSTY => GetString("DSTY");

		/// <summary>
		/// Description: Reconciliation method
		/// FieldName: RCMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reconciliation method")]
		public int? M3_RCMT => GetNullableInt("RCMT");

		/// <summary>
		/// Description: Reconciliation level
		/// FieldName: RCLV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reconciliation level")]
		public int? M3_RCLV => GetNullableInt("RCLV");

		/// <summary>
		/// Description: Cumulative type
		/// FieldName: CUMT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative type")]
		public int? M3_CUMT => GetNullableInt("CUMT");

		/// <summary>
		/// Description: Cumulative level
		/// FieldName: CUML
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative level")]
		public int? M3_CUML => GetNullableInt("CUML");

		/// <summary>
		/// Description: Packaging leveling
		/// FieldName: RSPL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging leveling")]
		public int? M3_RSPL => GetNullableInt("RSPL");

		/// <summary>
		/// Description: Deviation model
		/// FieldName: DEVM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deviation model")]
		public string M3_DEVM => GetString("DEVM");

		/// <summary>
		/// Description: Split model
		/// FieldName: SPMM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split model")]
		public string M3_SPMM => GetString("SPMM");

		/// <summary>
		/// Description: Date type
		/// FieldName: DTTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date type")]
		public int? M3_DTTP => GetNullableInt("DTTP");

		/// <summary>
		/// Description: Delivery schedule interval
		/// FieldName: DSIV
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule interval")]
		public int? M3_DSIV => GetNullableInt("DSIV");

		/// <summary>
		/// Description: Delivery schedule interval - hours
		/// FieldName: DSIU
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule interval - hours")]
		public int? M3_DSIU => GetNullableInt("DSIU");

		/// <summary>
		/// Description: Filing
		/// FieldName: ARCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filing")]
		public int? M3_ARCH => GetNullableInt("ARCH");

		/// <summary>
		/// Description: Days before archive/deletion
		/// FieldName: DSDD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days before archive/deletion")]
		public int? M3_DSDD => GetNullableInt("DSDD");

		/// <summary>
		/// Description: Consolidated forecast demand
		/// FieldName: COFD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidated forecast demand")]
		public int? M3_COFD => GetNullableInt("COFD");

		/// <summary>
		/// Description: Customer number - Consolidated fct
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number - Consolidated fct")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Customer order type - Consolidated fct
		/// FieldName: ORTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order type - Consolidated fct")]
		public string M3_ORTP => GetString("ORTP");

		/// <summary>
		/// Description: Address number - Consolidated fct
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number - Consolidated fct")]
		public string M3_ADID => GetString("ADID");

		/// <summary>
		/// Description: Delivery specification - Consolidated fc
		/// FieldName: DLSP
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery specification - Consolidated fc")]
		public string M3_DLSP => GetString("DLSP");

		/// <summary>
		/// Description: Change allocated orders
		/// FieldName: CHAO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change allocated orders")]
		public int? M3_CHAO => GetNullableInt("CHAO");

		/// <summary>
		/// Description: Move backorder to next delivery date
		/// FieldName: MOBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Move backorder to next delivery date")]
		public int? M3_MOBA => GetNullableInt("MOBA");

		/// <summary>
		/// Description: Priority
		/// FieldName: OPRI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3_OPRI => GetNullableInt("OPRI");

		/// <summary>
		/// Description: Controlling object
		/// FieldName: COOB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Controlling object")]
		public int? M3_COOB => GetNullableInt("COOB");

		/// <summary>
		/// Description: Update package information
		/// FieldName: UPPI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update package information")]
		public int? M3_UPPI => GetNullableInt("UPPI");

		/// <summary>
		/// Description: Delivery schedule group
		/// FieldName: DSGP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule group")]
		public string M3_DSGP => GetString("DSGP");

		/// <summary>
		/// Description: Delivery schedule level
		/// FieldName: DSLV
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule level")]
		public int? M3_DSLV => GetNullableInt("DSLV");

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
		/// Description: Consolidate item demands
		/// FieldName: SCSP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidate item demands")]
		public int? M3_SCSP => GetNullableInt("SCSP");

		/// <summary>
		/// Description: Application version
		/// FieldName: RSAV
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application version")]
		public string M3_RSAV => GetString("RSAV");

		/// <summary>
		/// Description: Backorder reconciliation
		/// FieldName: RSBT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Backorder reconciliation")]
		public int? M3_RSBT => GetNullableInt("RSBT");

		/// <summary>
		/// Description: Propose warehouse
		/// FieldName: OT77
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Propose warehouse")]
		public int? M3_OT77 => GetNullableInt("OT77");

		/// <summary>
		/// Description: Search standard facility table
		/// FieldName: FASH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search standard facility table")]
		public int? M3_FASH => GetNullableInt("FASH");

		/// <summary>
		/// Description: Date to use
		/// FieldName: DTUS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date to use")]
		public int? M3_DTUS => GetNullableInt("DTUS");

		/// <summary>
		/// Description: Agreement rule
		/// FieldName: AGHD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement rule")]
		public int? M3_AGHD => GetNullableInt("AGHD");

		/// <summary>
		/// Description: Packaging terms
		/// FieldName: TEPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging terms")]
		public string M3_TEPA => GetString("TEPA");

		/// <summary>
		/// Description: Add zero records
		/// FieldName: ADZE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Add zero records")]
		public int? M3_ADZE => GetNullableInt("ADZE");

		/// <summary>
		/// Description: Number of weeks
		/// FieldName: NOWE
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of weeks")]
		public int? M3_NOWE => GetNullableInt("NOWE");

		/// <summary>
		/// Description: Override delivery status
		/// FieldName: CAAG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Override delivery status")]
		public int? M3_CAAG => GetNullableInt("CAAG");

		/// <summary>
		/// Description: Update fields from higher level schedule
		/// FieldName: UPAS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update fields from higher level schedule")]
		public int? M3_UPAS => GetNullableInt("UPAS");

		/// <summary>
		/// Description: User exit program - activate
		/// FieldName: EXP1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User exit program - activate")]
		public string M3_EXP1 => GetString("EXP1");

		/// <summary>
		/// Description: User exit program - transfer
		/// FieldName: EXP2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User exit program - transfer")]
		public string M3_EXP2 => GetString("EXP2");

		/// <summary>
		/// Description: User exit program - validate
		/// FieldName: EXP3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User exit program - validate")]
		public string M3_EXP3 => GetString("EXP3");

		/// <summary>
		/// Description: User exit program - product variants
		/// FieldName: EXP4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User exit program - product variants")]
		public string M3_EXP4 => GetString("EXP4");

		/// <summary>
		/// Description: Generic address search
		/// FieldName: GENS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Generic address search")]
		public int? M3_GENS => GetNullableInt("GENS");

		/// <summary>
		/// Description: Override mail recipient
		/// FieldName: OMRE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Override mail recipient")]
		public int? M3_OMRE => GetNullableInt("OMRE");

		/// <summary>
		/// Description: Receiver
		/// FieldName: REC2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiver")]
		public string M3_REC2 => GetString("REC2");

		/// <summary>
		/// Description: Adjust to issue multiple from item/whs
		/// FieldName: ADUM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjust to issue multiple from item/whs")]
		public int? M3_ADUM => GetNullableInt("ADUM");

		/// <summary>
		/// Description: Adjust to delivery pattern
		/// FieldName: AJDL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjust to delivery pattern")]
		public int? M3_AJDL => GetNullableInt("AJDL");

		/// <summary>
		/// Description: Create dely specifications auto
		/// FieldName: AADS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Create dely specifications auto")]
		public int? M3_AADS => GetNullableInt("AADS");

		/// <summary>
		/// Description: Hours and minutes in use
		/// FieldName: MNIU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hours and minutes in use")]
		public int? M3_MNIU => GetNullableInt("MNIU");

		/// <summary>
		/// Description: Date type received for delivery notes
		/// FieldName: DNRC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date type received for delivery notes")]
		public int? M3_DNRC => GetNullableInt("DNRC");

		/// <summary>
		/// Description: Check backorder deviations
		/// FieldName: CBOC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check backorder deviations")]
		public int? M3_CBOC => GetNullableInt("CBOC");

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
		/// Description: Processing customer order number
		/// FieldName: CUOH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Processing customer order number")]
		public int? M3_CUOH => GetNullableInt("CUOH");

		/// <summary>
		/// Description: Forecast calculation method
		/// FieldName: FCMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast calculation method")]
		public int? M3_FCMT => GetNullableInt("FCMT");

		/// <summary>
		/// Description: Check split table
		/// FieldName: CSPL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check split table")]
		public int? M3_CSPL => GetNullableInt("CSPL");

		/// <summary>
		/// Description: Run MRP calculation on changed items
		/// FieldName: CLCM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run MRP calculation on changed items")]
		public int? M3_CLCM => GetNullableInt("CLCM");

		/// <summary>
		/// Description: Explosion
		/// FieldName: BDCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Explosion")]
		public int? M3_BDCD => GetNullableInt("BDCD");

		/// <summary>
		/// Description: Lowest level
		/// FieldName: LEVL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest level")]
		public int? M3_LEVL => GetNullableInt("LEVL");

		/// <summary>
		/// Description: JIT release method
		/// FieldName: PACM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("JIT release method")]
		public string M3_PACM => GetString("PACM");

		/// <summary>
		/// Description: Calculate transportation lead time
		/// FieldName: CLCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculate transportation lead time")]
		public int? M3_CLCL => GetNullableInt("CLCL");

		/// <summary>
		/// Description: Delivery statuses to transfer
		/// FieldName: DSTF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery statuses to transfer")]
		public string M3_DSTF => GetString("DSTF");

		/// <summary>
		/// Description: Update customer cumulative statistics
		/// FieldName: UCCS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update customer cumulative statistics")]
		public int? M3_UCCS => GetNullableInt("UCCS");

		/// <summary>
		/// Description: Variant handling
		/// FieldName: VAHL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Variant handling")]
		public int? M3_VAHL => GetNullableInt("VAHL");
	}
}
// EOF
