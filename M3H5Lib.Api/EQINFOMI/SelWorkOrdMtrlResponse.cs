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

namespace M3H5Lib.Api.EQINFOMI
{
	public partial class SelWorkOrdMtrlResponse : M3BaseRecord 
	{

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
		/// Description: Sequence number
		/// FieldName: MSEQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3MSEQ => GetNullableInt("MSEQ");

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
		/// Description: Material status
		/// FieldName: WMST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material status")]
		public string M3WMST => GetString("WMST");

		/// <summary>
		/// Description: Component number
		/// FieldName: MTNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component number")]
		public string M3MTNO => GetString("MTNO");

		/// <summary>
		/// Description: Quantity
		/// FieldName: CNQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity")]
		public decimal? M3CNQT => GetNullableDecimal("CNQT");

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
		/// Description: Issue method
		/// FieldName: SPMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue method")]
		public int? M3SPMT => GetNullableInt("SPMT");

		/// <summary>
		/// Description: Item category
		/// FieldName: TPCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item category")]
		public int? M3TPCD => GetNullableInt("TPCD");

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

		/// <summary>
		/// Description: Work order picking list status
		/// FieldName: WPST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work order picking list status")]
		public string M3WPST => GetString("WPST");

		/// <summary>
		/// Description: Line type
		/// FieldName: LTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line type")]
		public string M3LTYP => GetString("LTYP");

		/// <summary>
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3RORL => GetNullableInt("RORL");
	}
}
// EOF
