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
	public partial class GetInstructionResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Requested delivery date
		/// FieldName: RLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery date")]
		public DateTime? M3RLDT => GetNullableDateTime("RLDT");

		/// <summary>
		/// Description: Requested delivery time
		/// FieldName: RLTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery time")]
		public int? M3RLTM => GetNullableInt("RLTM");

		/// <summary>
		/// Description: Requested quantity
		/// FieldName: DEMQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested quantity")]
		public decimal? M3DEMQ => GetNullableDecimal("DEMQ");

		/// <summary>
		/// Description: Delivery status indicator
		/// FieldName: RSIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery status indicator")]
		public int? M3RSIN => GetNullableInt("RSIN");

		/// <summary>
		/// Description: Quantity qualifier
		/// FieldName: QTQL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity qualifier")]
		public int? M3QTQL => GetNullableInt("QTQL");

		/// <summary>
		/// Description: Instruction reason
		/// FieldName: INRA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Instruction reason")]
		public int? M3INRA => GetNullableInt("INRA");

		/// <summary>
		/// Description: Instruction activity code
		/// FieldName: INSA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Instruction activity code")]
		public int? M3INSA => GetNullableInt("INSA");

		/// <summary>
		/// Description: Customers order number
		/// FieldName: CUOR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customers order number")]
		public string M3CUOR => GetString("CUOR");

		/// <summary>
		/// Description: Customer´s purchase order date
		/// FieldName: CUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer´s purchase order date")]
		public DateTime? M3CUDT => GetNullableDateTime("CUDT");

		/// <summary>
		/// Description: Delivery contract number
		/// FieldName: RSAG
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery contract number")]
		public string M3RSAG => GetString("RSAG");

		/// <summary>
		/// Description: Update method
		/// FieldName: RSAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update method")]
		public int? M3RSAC => GetNullableInt("RSAC");

		/// <summary>
		/// Description: Period to date
		/// FieldName: RTDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period to date")]
		public DateTime? M3RTDT => GetNullableDateTime("RTDT");

		/// <summary>
		/// Description: Period to time
		/// FieldName: RTTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period to time")]
		public int? M3RTTM => GetNullableInt("RTTM");

		/// <summary>
		/// Description: Cumulative quantity
		/// FieldName: CQCF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative quantity")]
		public decimal? M3CQCF => GetNullableDecimal("CQCF");

		/// <summary>
		/// Description: Production sequence number
		/// FieldName: PDSQ
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production sequence number")]
		public string M3PDSQ => GetString("PDSQ");

		/// <summary>
		/// Description: Kanban card number
		/// FieldName: RSKN
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Kanban card number")]
		public string M3RSKN => GetString("RSKN");

		/// <summary>
		/// Description: Chassi number
		/// FieldName: CHAS
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Chassi number")]
		public string M3CHAS => GetString("CHAS");

		/// <summary>
		/// Description: Your reference 1
		/// FieldName: YREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference 1")]
		public string M3YREF => GetString("YREF");
	}
}
// EOF
