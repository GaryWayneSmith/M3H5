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

namespace M3H5Lib.Api.PPS040MI
{
	public partial class LstItemSupplierResponse : M3BaseRecord 
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
		/// Description: Suppliernumber
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliernumber")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Currentfullcostpurchasecosting
		/// FieldName: PCCP
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currentfullcostpurchasecosting")]
		public decimal? M3PCCP => GetNullableDecimal("PCCP");

		/// <summary>
		/// Description: Lastcostingdate-fullcost
		/// FieldName: LPCD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lastcostingdate-fullcost")]
		public DateTime? M3LPCD => GetNullableDateTime("LPCD");

		/// <summary>
		/// Description: Standardofapproval
		/// FieldName: STAP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standardofapproval")]
		public string M3STAP => GetString("STAP");

		/// <summary>
		/// Description: Ordermultiple
		/// FieldName: UNMU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordermultiple")]
		public decimal? M3UNMU => GetNullableDecimal("UNMU");

		/// <summary>
		/// Description: Receiptdate
		/// FieldName: RCDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiptdate")]
		public DateTime? M3RCDT => GetNullableDateTime("RCDT");

		/// <summary>
		/// Description: Itemnumber
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Itemnumber")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Supplieritemname
		/// FieldName: SITD
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplieritemname")]
		public string M3SITD => GetString("SITD");

		/// <summary>
		/// Description: Serviceprocess
		/// FieldName: PRCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serviceprocess")]
		public string M3PRCS => GetString("PRCS");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3SUFI => GetString("SUFI");
	}
}
// EOF
