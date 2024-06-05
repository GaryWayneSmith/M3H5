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

namespace M3H5Lib.Api.SOS100MI
{
	public partial class LstServOrdTypeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Service order type
		/// FieldName: SOTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service order type")]
		public string M3_SOTP => GetString("SOTP");

		/// <summary>
		/// Description: Service order type category
		/// FieldName: SOTK
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service order type category")]
		public string M3_SOTK => GetString("SOTK");

		/// <summary>
		/// Description: Next manuall function
		/// FieldName: NEXT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next manuall function")]
		public int? M3_NEXT => GetNullableInt("NEXT");

		/// <summary>
		/// Description: Order type description
		/// FieldName: OTDE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type description")]
		public string M3_OTDE => GetString("OTDE");

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
		/// Description: Internal payer 1
		/// FieldName: SO62
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal payer 1")]
		public string M3_SO62 => GetString("SO62");

		/// <summary>
		/// Description: Internal payer 2
		/// FieldName: SO63
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal payer 2")]
		public string M3_SO63 => GetString("SO63");

		/// <summary>
		/// Description: Internal payer 3
		/// FieldName: SO64
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal payer 3")]
		public string M3_SO64 => GetString("SO64");

		/// <summary>
		/// Description: Internal payer 4
		/// FieldName: SO65
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal payer 4")]
		public string M3_SO65 => GetString("SO65");

		/// <summary>
		/// Description: Assignment type
		/// FieldName: ASST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assignment type")]
		public string M3_ASST => GetString("ASST");

		/// <summary>
		/// Description: Additional status
		/// FieldName: ESTI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional status")]
		public string M3_ESTI => GetString("ESTI");

		/// <summary>
		/// Description: Response time
		/// FieldName: SO61
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Response time")]
		public int? M3_SO61 => GetNullableInt("SO61");

		/// <summary>
		/// Description: Work schedule
		/// FieldName: SO80
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work schedule")]
		public int? M3_SO80 => GetNullableInt("SO80");

		/// <summary>
		/// Description: Default work time
		/// FieldName: SO79
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default work time")]
		public int? M3_SO79 => GetNullableInt("SO79");

		/// <summary>
		/// Description: Summary invoice code
		/// FieldName: SO37
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Summary invoice code")]
		public int? M3_SO37 => GetNullableInt("SO37");

		/// <summary>
		/// Description: All assignment together code
		/// FieldName: SO40
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("All assignment together code")]
		public int? M3_SO40 => GetNullableInt("SO40");

		/// <summary>
		/// Description: Several line types permitted
		/// FieldName: SO09
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Several line types permitted")]
		public int? M3_SO09 => GetNullableInt("SO09");

		/// <summary>
		/// Description: Several warehouses permitted
		/// FieldName: SO10
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Several warehouses permitted")]
		public int? M3_SO10 => GetNullableInt("SO10");

		/// <summary>
		/// Description: Check sequence - item ID
		/// FieldName: SO19
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check sequence - item ID")]
		public string M3_SO19 => GetString("SO19");

		/// <summary>
		/// Description: Manual due date
		/// FieldName: SO23
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual due date")]
		public int? M3_SO23 => GetNullableInt("SO23");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: SO43
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3_SO43 => GetString("SO43");

		/// <summary>
		/// Description: Cost price rule
		/// FieldName: SO14
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price rule")]
		public int? M3_SO14 => GetNullableInt("SO14");

		/// <summary>
		/// Description: Sales price rule
		/// FieldName: SO12
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price rule")]
		public int? M3_SO12 => GetNullableInt("SO12");

		/// <summary>
		/// Description: Discount maintenance
		/// FieldName: SO13
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount maintenance")]
		public int? M3_SO13 => GetNullableInt("SO13");

		/// <summary>
		/// Description: Quantity sign
		/// FieldName: SO11
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity sign")]
		public int? M3_SO11 => GetNullableInt("SO11");

		/// <summary>
		/// Description: Payer control
		/// FieldName: SO60
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer control")]
		public string M3_SO60 => GetString("SO60");

		/// <summary>
		/// Description: Parameters from service manager
		/// FieldName: SO66
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parameters from service manager")]
		public int? M3_SO66 => GetNullableInt("SO66");

		/// <summary>
		/// Description: Total price allowed
		/// FieldName: TPAL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total price allowed")]
		public int? M3_TPAL => GetNullableInt("TPAL");

		/// <summary>
		/// Description: Total price distribution method
		/// FieldName: TPMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total price distribution method")]
		public int? M3_TPMT => GetNullableInt("TPMT");

		/// <summary>
		/// Description: Price print out code
		/// FieldName: PPCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price print out code")]
		public int? M3_PPCD => GetNullableInt("PPCD");

		/// <summary>
		/// Description: Slack time service order
		/// FieldName: SO67
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Slack time service order")]
		public int? M3_SO67 => GetNullableInt("SO67");

		/// <summary>
		/// Description: Planned preparation time
		/// FieldName: SO68
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned preparation time")]
		public int? M3_SO68 => GetNullableInt("SO68");

		/// <summary>
		/// Description: Planned completion time
		/// FieldName: SO69
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned completion time")]
		public int? M3_SO69 => GetNullableInt("SO69");

		/// <summary>
		/// Description: Planned travel time
		/// FieldName: SO70
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned travel time")]
		public int? M3_SO70 => GetNullableInt("SO70");

		/// <summary>
		/// Description: Travel type
		/// FieldName: SO71
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Travel type")]
		public string M3_SO71 => GetString("SO71");

		/// <summary>
		/// Description: Default line type
		/// FieldName: SO47
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default line type")]
		public string M3_SO47 => GetString("SO47");

		/// <summary>
		/// Description: Transportation of individual item
		/// FieldName: TRIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation of individual item")]
		public int? M3_TRIN => GetNullableInt("TRIN");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: SO58
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_SO58 => GetString("SO58");

		/// <summary>
		/// Description: Location
		/// FieldName: SO59
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3_SO59 => GetString("SO59");

		/// <summary>
		/// Description: Downtime
		/// FieldName: DOWT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Downtime")]
		public int? M3_DOWT => GetNullableInt("DOWT");

		/// <summary>
		/// Description: Credit check
		/// FieldName: SO02
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit check")]
		public int? M3_SO02 => GetNullableInt("SO02");

		/// <summary>
		/// Description: Inventory accounting code
		/// FieldName: SO18
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting code")]
		public int? M3_SO18 => GetNullableInt("SO18");
	}
}
// EOF
