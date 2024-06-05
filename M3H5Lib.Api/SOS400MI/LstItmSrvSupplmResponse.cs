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

namespace M3H5Lib.Api.SOS400MI
{
	public partial class LstItmSrvSupplmResponse : M3BaseRecord 
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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Individual item management
		/// FieldName: INDC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item management")]
		public int? M3_INDC => GetNullableInt("INDC");

		/// <summary>
		/// Description: Response time
		/// FieldName: APTM
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Response time")]
		public int? M3_APTM => GetNullableInt("APTM");

		/// <summary>
		/// Description: Service expense type
		/// FieldName: SETP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service expense type")]
		public string M3_SETP => GetString("SETP");

		/// <summary>
		/// Description: Supplier warranty time method
		/// FieldName: DGTC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier warranty time method")]
		public int? M3_DGTC => GetNullableInt("DGTC");

		/// <summary>
		/// Description: Sales warranty time method
		/// FieldName: SGTC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales warranty time method")]
		public int? M3_SGTC => GetNullableInt("SGTC");

		/// <summary>
		/// Description: Supplier warranty time years
		/// FieldName: DGYR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier warranty time years")]
		public int? M3_DGYR => GetNullableInt("DGYR");

		/// <summary>
		/// Description: Supplier warranty time months
		/// FieldName: DGMO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier warranty time months")]
		public int? M3_DGMO => GetNullableInt("DGMO");

		/// <summary>
		/// Description: Supplier warranty time days
		/// FieldName: DGDA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier warranty time days")]
		public int? M3_DGDA => GetNullableInt("DGDA");

		/// <summary>
		/// Description: Sales warranty time years
		/// FieldName: SGYR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales warranty time years")]
		public int? M3_SGYR => GetNullableInt("SGYR");

		/// <summary>
		/// Description: Sales warranty time months
		/// FieldName: SGMO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales warranty time months")]
		public int? M3_SGMO => GetNullableInt("SGMO");

		/// <summary>
		/// Description: Sales warranty time days
		/// FieldName: SGDA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales warranty time days")]
		public int? M3_SGDA => GetNullableInt("SGDA");

		/// <summary>
		/// Description: Individual item template
		/// FieldName: TIND
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item template")]
		public string M3_TIND => GetString("TIND");

		/// <summary>
		/// Description: Agreement order type
		/// FieldName: AOTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement order type")]
		public string M3_AOTP => GetString("AOTP");

		/// <summary>
		/// Description: Agreement type
		/// FieldName: AGTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement type")]
		public string M3_AGTP => GetString("AGTP");

		/// <summary>
		/// Description: Preventive service order
		/// FieldName: PSCO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preventive service order")]
		public int? M3_PSCO => GetNullableInt("PSCO");

		/// <summary>
		/// Description: Meter item
		/// FieldName: MEIT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter item")]
		public int? M3_MEIT => GetNullableInt("MEIT");

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
		/// Description: Actual meter 1 in use
		/// FieldName: AM1U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual meter 1 in use")]
		public int? M3_AM1U => GetNullableInt("AM1U");

		/// <summary>
		/// Description: Actual meter 2 in use
		/// FieldName: AM2U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual meter 2 in use")]
		public int? M3_AM2U => GetNullableInt("AM2U");

		/// <summary>
		/// Description: Actual meter 3 in use
		/// FieldName: AM3U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual meter 3 in use")]
		public int? M3_AM3U => GetNullableInt("AM3U");

		/// <summary>
		/// Description: Actual meter 4 in use
		/// FieldName: AM4U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual meter 4 in use")]
		public int? M3_AM4U => GetNullableInt("AM4U");

		/// <summary>
		/// Description: Actual meter 5 in use
		/// FieldName: AM5U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual meter 5 in use")]
		public int? M3_AM5U => GetNullableInt("AM5U");

		/// <summary>
		/// Description: Actual meter 6 in use
		/// FieldName: AM6U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual meter 6 in use")]
		public int? M3_AM6U => GetNullableInt("AM6U");

		/// <summary>
		/// Description: Logical meter 1 in use
		/// FieldName: LM1U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logical meter 1 in use")]
		public int? M3_LM1U => GetNullableInt("LM1U");

		/// <summary>
		/// Description: Logical meter 2 in use
		/// FieldName: LM2U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logical meter 2 in use")]
		public int? M3_LM2U => GetNullableInt("LM2U");

		/// <summary>
		/// Description: Logical meter 3 in use
		/// FieldName: LM3U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logical meter 3 in use")]
		public int? M3_LM3U => GetNullableInt("LM3U");

		/// <summary>
		/// Description: Logical meter 4 in use
		/// FieldName: LM4U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logical meter 4 in use")]
		public int? M3_LM4U => GetNullableInt("LM4U");

		/// <summary>
		/// Description: Logical meter 5 in use
		/// FieldName: LM5U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logical meter 5 in use")]
		public int? M3_LM5U => GetNullableInt("LM5U");

		/// <summary>
		/// Description: Logical meter 6 in use
		/// FieldName: LM6U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logical meter 6 in use")]
		public int? M3_LM6U => GetNullableInt("LM6U");

		/// <summary>
		/// Description: Invoice meter 1 in use
		/// FieldName: IM1U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice meter 1 in use")]
		public int? M3_IM1U => GetNullableInt("IM1U");

		/// <summary>
		/// Description: Invoice meter 2 in use
		/// FieldName: IM2U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice meter 2 in use")]
		public int? M3_IM2U => GetNullableInt("IM2U");

		/// <summary>
		/// Description: Invoice meter 3 in use
		/// FieldName: IM3U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice meter 3 in use")]
		public int? M3_IM3U => GetNullableInt("IM3U");

		/// <summary>
		/// Description: Invoice meter 4 in use
		/// FieldName: IM4U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice meter 4 in use")]
		public int? M3_IM4U => GetNullableInt("IM4U");

		/// <summary>
		/// Description: Invoice meter 5 in use
		/// FieldName: IM5U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice meter 5 in use")]
		public int? M3_IM5U => GetNullableInt("IM5U");

		/// <summary>
		/// Description: Invoice meter 6 in use
		/// FieldName: IM6U
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice meter 6 in use")]
		public int? M3_IM6U => GetNullableInt("IM6U");
	}
}
// EOF
