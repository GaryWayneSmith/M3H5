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

namespace M3H5Lib.Api.COS150MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: User
		/// FieldName: USID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3USID => GetString("USID");

		/// <summary>
		/// Description: Transaction number
		/// FieldName: TRNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction number")]
		public int? M3TRNO => GetNullableInt("TRNO");

		/// <summary>
		/// Description: Customer order number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order number")]
		public string M3ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Work order number
		/// FieldName: MWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work order number")]
		public string M3MWNO => GetString("MWNO");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Miscellaneous cost types
		/// FieldName: AMTY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Miscellaneous cost types")]
		public string M3AMTY => GetString("AMTY");

		/// <summary>
		/// Description: Transaction quantity - basic U/M
		/// FieldName: TRQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction quantity - basic U/M")]
		public decimal? M3TRQT => GetNullableDecimal("TRQT");

		/// <summary>
		/// Description: Unit of measure
		/// FieldName: UNIT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit of measure")]
		public string M3UNIT => GetString("UNIT");

		/// <summary>
		/// Description: Sales price
		/// FieldName: ASP1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3ASP1 => GetNullableDecimal("ASP1");

		/// <summary>
		/// Description: Agreement currency
		/// FieldName: AACU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement currency")]
		public string M3AACU => GetString("AACU");

		/// <summary>
		/// Description: WIP debit
		/// FieldName: AWCO
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("WIP debit")]
		public decimal? M3AWCO => GetNullableDecimal("AWCO");

		/// <summary>
		/// Description: Local currency
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency")]
		public string M3LOCD => GetString("LOCD");

		/// <summary>
		/// Description: Update General Ledger
		/// FieldName: UPGL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update General Ledger")]
		public int? M3UPGL => GetNullableInt("UPGL");

		/// <summary>
		/// Description: Remark
		/// FieldName: REMK
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3REMK => GetString("REMK");

		/// <summary>
		/// Description: Transaction date
		/// FieldName: TRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction date")]
		public DateTime? M3TRDT => GetNullableDateTime("TRDT");

		/// <summary>
		/// Description: Transaction time
		/// FieldName: TRTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction time")]
		public int? M3TRTM => GetNullableInt("TRTM");

		/// <summary>
		/// Description: Manually updated
		/// FieldName: MAUP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manually updated")]
		public int? M3MAUP => GetNullableInt("MAUP");

		/// <summary>
		/// Description: Transaction status
		/// FieldName: AIST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction status")]
		public string M3AIST => GetString("AIST");

		/// <summary>
		/// Description: Employee number
		/// FieldName: EMNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee number")]
		public string M3EMNO => GetString("EMNO");

		/// <summary>
		/// Description: Registration number/site
		/// FieldName: TAIL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration number/site")]
		public string M3TAIL => GetString("TAIL");

		/// <summary>
		/// Description: Interface order number
		/// FieldName: IORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interface order number")]
		public string M3IORN => GetString("IORN");

		/// <summary>
		/// Description: Interface order line
		/// FieldName: IORL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interface order line")]
		public int? M3IORL => GetNullableInt("IORL");
	}
}
// EOF
