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
		public string M3DSTY => GetString("DSTY");

		/// <summary>
		/// Description: Reconciliation method
		/// FieldName: RCMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reconciliation method")]
		public int? M3RCMT => GetNullableInt("RCMT");

		/// <summary>
		/// Description: Reconciliation level
		/// FieldName: RCLV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reconciliation level")]
		public int? M3RCLV => GetNullableInt("RCLV");

		/// <summary>
		/// Description: Cumulative type
		/// FieldName: CUMT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative type")]
		public int? M3CUMT => GetNullableInt("CUMT");

		/// <summary>
		/// Description: Cumulative level
		/// FieldName: CUML
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative level")]
		public int? M3CUML => GetNullableInt("CUML");

		/// <summary>
		/// Description: Packaging leveling
		/// FieldName: RSPL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging leveling")]
		public int? M3RSPL => GetNullableInt("RSPL");

		/// <summary>
		/// Description: Deviation model
		/// FieldName: DEVM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deviation model")]
		public string M3DEVM => GetString("DEVM");

		/// <summary>
		/// Description: Split model
		/// FieldName: SPMM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split model")]
		public string M3SPMM => GetString("SPMM");

		/// <summary>
		/// Description: Date type
		/// FieldName: DTTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date type")]
		public int? M3DTTP => GetNullableInt("DTTP");

		/// <summary>
		/// Description: Delivery schedule interval
		/// FieldName: DSIV
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule interval")]
		public int? M3DSIV => GetNullableInt("DSIV");

		/// <summary>
		/// Description: Delivery schedule interval - hours
		/// FieldName: DSIU
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule interval - hours")]
		public int? M3DSIU => GetNullableInt("DSIU");

		/// <summary>
		/// Description: Filing
		/// FieldName: ARCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filing")]
		public int? M3ARCH => GetNullableInt("ARCH");

		/// <summary>
		/// Description: Days before archive/deletion
		/// FieldName: DSDD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days before archive/deletion")]
		public int? M3DSDD => GetNullableInt("DSDD");

		/// <summary>
		/// Description: Consolidated forecast demand
		/// FieldName: COFD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidated forecast demand")]
		public int? M3COFD => GetNullableInt("COFD");

		/// <summary>
		/// Description: Customer number - Consolidated fct
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number - Consolidated fct")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Customer order type - Consolidated fct
		/// FieldName: ORTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order type - Consolidated fct")]
		public string M3ORTP => GetString("ORTP");

		/// <summary>
		/// Description: Address number - Consolidated fct
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number - Consolidated fct")]
		public string M3ADID => GetString("ADID");

		/// <summary>
		/// Description: Delivery specification - Consolidated fc
		/// FieldName: DLSP
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery specification - Consolidated fc")]
		public string M3DLSP => GetString("DLSP");

		/// <summary>
		/// Description: Change allocated orders
		/// FieldName: CHAO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change allocated orders")]
		public int? M3CHAO => GetNullableInt("CHAO");

		/// <summary>
		/// Description: Move backorder to next delivery date
		/// FieldName: MOBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Move backorder to next delivery date")]
		public int? M3MOBA => GetNullableInt("MOBA");

		/// <summary>
		/// Description: Priority
		/// FieldName: OPRI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3OPRI => GetNullableInt("OPRI");

		/// <summary>
		/// Description: Controlling object
		/// FieldName: COOB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Controlling object")]
		public int? M3COOB => GetNullableInt("COOB");

		/// <summary>
		/// Description: Update package information
		/// FieldName: UPPI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update package information")]
		public int? M3UPPI => GetNullableInt("UPPI");

		/// <summary>
		/// Description: Delivery schedule group
		/// FieldName: DSGP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule group")]
		public string M3DSGP => GetString("DSGP");

		/// <summary>
		/// Description: Delivery schedule level
		/// FieldName: DSLV
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule level")]
		public int? M3DSLV => GetNullableInt("DSLV");

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
		/// Description: Consolidate item demands
		/// FieldName: SCSP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidate item demands")]
		public int? M3SCSP => GetNullableInt("SCSP");

		/// <summary>
		/// Description: Application version
		/// FieldName: RSAV
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application version")]
		public string M3RSAV => GetString("RSAV");

		/// <summary>
		/// Description: Backorder reconciliation
		/// FieldName: RSBT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Backorder reconciliation")]
		public int? M3RSBT => GetNullableInt("RSBT");

		/// <summary>
		/// Description: Propose warehouse
		/// FieldName: OT77
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Propose warehouse")]
		public int? M3OT77 => GetNullableInt("OT77");

		/// <summary>
		/// Description: Search standard facility table
		/// FieldName: FASH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search standard facility table")]
		public int? M3FASH => GetNullableInt("FASH");

		/// <summary>
		/// Description: Date to use
		/// FieldName: DTUS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date to use")]
		public int? M3DTUS => GetNullableInt("DTUS");

		/// <summary>
		/// Description: Agreement rule
		/// FieldName: AGHD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement rule")]
		public int? M3AGHD => GetNullableInt("AGHD");

		/// <summary>
		/// Description: Packaging terms
		/// FieldName: TEPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging terms")]
		public string M3TEPA => GetString("TEPA");

		/// <summary>
		/// Description: Add zero records
		/// FieldName: ADZE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Add zero records")]
		public int? M3ADZE => GetNullableInt("ADZE");

		/// <summary>
		/// Description: Number of weeks
		/// FieldName: NOWE
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of weeks")]
		public int? M3NOWE => GetNullableInt("NOWE");

		/// <summary>
		/// Description: Override delivery status
		/// FieldName: CAAG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Override delivery status")]
		public int? M3CAAG => GetNullableInt("CAAG");

		/// <summary>
		/// Description: Update fields from higher level schedule
		/// FieldName: UPAS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update fields from higher level schedule")]
		public int? M3UPAS => GetNullableInt("UPAS");

		/// <summary>
		/// Description: User exit program - activate
		/// FieldName: EXP1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User exit program - activate")]
		public string M3EXP1 => GetString("EXP1");

		/// <summary>
		/// Description: User exit program - transfer
		/// FieldName: EXP2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User exit program - transfer")]
		public string M3EXP2 => GetString("EXP2");

		/// <summary>
		/// Description: User exit program - validate
		/// FieldName: EXP3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User exit program - validate")]
		public string M3EXP3 => GetString("EXP3");

		/// <summary>
		/// Description: User exit program - product variants
		/// FieldName: EXP4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User exit program - product variants")]
		public string M3EXP4 => GetString("EXP4");

		/// <summary>
		/// Description: Generic address search
		/// FieldName: GENS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Generic address search")]
		public int? M3GENS => GetNullableInt("GENS");

		/// <summary>
		/// Description: Override mail recipient
		/// FieldName: OMRE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Override mail recipient")]
		public int? M3OMRE => GetNullableInt("OMRE");

		/// <summary>
		/// Description: Receiver
		/// FieldName: REC2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiver")]
		public string M3REC2 => GetString("REC2");

		/// <summary>
		/// Description: Adjust to issue multiple from item/whs
		/// FieldName: ADUM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjust to issue multiple from item/whs")]
		public int? M3ADUM => GetNullableInt("ADUM");

		/// <summary>
		/// Description: Adjust to delivery pattern
		/// FieldName: AJDL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjust to delivery pattern")]
		public int? M3AJDL => GetNullableInt("AJDL");

		/// <summary>
		/// Description: Create dely specifications auto
		/// FieldName: AADS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Create dely specifications auto")]
		public int? M3AADS => GetNullableInt("AADS");

		/// <summary>
		/// Description: Hours and minutes in use
		/// FieldName: MNIU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hours and minutes in use")]
		public int? M3MNIU => GetNullableInt("MNIU");

		/// <summary>
		/// Description: Date type received for delivery notes
		/// FieldName: DNRC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date type received for delivery notes")]
		public int? M3DNRC => GetNullableInt("DNRC");

		/// <summary>
		/// Description: Check backorder deviations
		/// FieldName: CBOC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check backorder deviations")]
		public int? M3CBOC => GetNullableInt("CBOC");

		/// <summary>
		/// Description: Time zone
		/// FieldName: TIZO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time zone")]
		public string M3TIZO => GetString("TIZO");

		/// <summary>
		/// Description: Processing customer order number
		/// FieldName: CUOH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Processing customer order number")]
		public int? M3CUOH => GetNullableInt("CUOH");

		/// <summary>
		/// Description: Forecast calculation method
		/// FieldName: FCMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast calculation method")]
		public int? M3FCMT => GetNullableInt("FCMT");

		/// <summary>
		/// Description: Check split table
		/// FieldName: CSPL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check split table")]
		public int? M3CSPL => GetNullableInt("CSPL");

		/// <summary>
		/// Description: Run MRP calculation on changed items
		/// FieldName: CLCM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run MRP calculation on changed items")]
		public int? M3CLCM => GetNullableInt("CLCM");

		/// <summary>
		/// Description: Explosion
		/// FieldName: BDCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Explosion")]
		public int? M3BDCD => GetNullableInt("BDCD");

		/// <summary>
		/// Description: Lowest level
		/// FieldName: LEVL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest level")]
		public int? M3LEVL => GetNullableInt("LEVL");

		/// <summary>
		/// Description: JIT release method
		/// FieldName: PACM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("JIT release method")]
		public string M3PACM => GetString("PACM");

		/// <summary>
		/// Description: Calculate transportation lead time
		/// FieldName: CLCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculate transportation lead time")]
		public int? M3CLCL => GetNullableInt("CLCL");

		/// <summary>
		/// Description: Delivery statuses to transfer
		/// FieldName: DSTF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery statuses to transfer")]
		public string M3DSTF => GetString("DSTF");

		/// <summary>
		/// Description: Update customer cumulative statistics
		/// FieldName: UCCS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update customer cumulative statistics")]
		public int? M3UCCS => GetNullableInt("UCCS");

		/// <summary>
		/// Description: Variant handling
		/// FieldName: VAHL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Variant handling")]
		public int? M3VAHL => GetNullableInt("VAHL");
	}
}
// EOF
