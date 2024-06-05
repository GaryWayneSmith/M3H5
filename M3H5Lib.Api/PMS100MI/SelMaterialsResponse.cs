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

namespace M3H5Lib.Api.PMS100MI
{
	public partial class SelMaterialsResponse : M3BaseRecord 
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
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Manufacturing order number
		/// FieldName: MFNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3MFNO => GetString("MFNO");

		/// <summary>
		/// Description: Material sequence number
		/// FieldName: MSEQ
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material sequence number")]
		public string M3MSEQ => GetString("MSEQ");

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
		/// Description: Component description
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component description")]
		public string M3ITDS => GetString("ITDS");

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
		/// Description: Reserved quantity
		/// FieldName: REQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reserved quantity")]
		public decimal? M3REQT => GetNullableDecimal("REQT");

		/// <summary>
		/// Description: Reservation date
		/// FieldName: RDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reservation date")]
		public DateTime? M3RDAT => GetNullableDateTime("RDAT");

		/// <summary>
		/// Description: Consists-of quantity
		/// FieldName: CNQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consists-of quantity")]
		public decimal? M3CNQT => GetNullableDecimal("CNQT");

		/// <summary>
		/// Description: By-product code
		/// FieldName: BYPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("By-product code")]
		public int? M3BYPR => GetNullableInt("BYPR");

		/// <summary>
		/// Description: Acquisition code
		/// FieldName: PUIT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acquisition code")]
		public int? M3PUIT => GetNullableInt("PUIT");

		/// <summary>
		/// Description: Record type
		/// FieldName: RTYP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Record type")]
		public int? M3RTYP => GetNullableInt("RTYP");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");

		/// <summary>
		/// Description: Supplying MO
		/// FieldName: SPMO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying MO")]
		public string M3SPMO => GetString("SPMO");

		/// <summary>
		/// Description: Network status
		/// FieldName: NWST
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Network status")]
		public string M3NWST => GetString("NWST");

		/// <summary>
		/// Description: Safety time (days)
		/// FieldName: SATD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety time (days)")]
		public int? M3SATD => GetNullableInt("SATD");

		/// <summary>
		/// Description: Allocated quantity
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity")]
		public decimal? M3ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Remaining quantity (for allocation)
		/// FieldName: RNQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining quantity (for allocation)")]
		public decimal? M3RNQT => GetNullableDecimal("RNQT");

		/// <summary>
		/// Description: Transaction quantity - basic U/M
		/// FieldName: TRQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction quantity - basic U/M")]
		public decimal? M3TRQT => GetNullableDecimal("TRQT");

		/// <summary>
		/// Description: Warehouse                       (VMWHLO)
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse                       (VMWHLO)")]
		public string M3WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Product's warehouse             (VHWHLO)
		/// FieldName: PWHL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product's warehouse             (VHWHLO)")]
		public string M3PWHL => GetString("PWHL");

		/// <summary>
		/// Description: Supplying DO number             (MRTRNR)
		/// FieldName: SPDO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying DO number             (MRTRNR)")]
		public string M3SPDO => GetString("SPDO");

		/// <summary>
		/// Description: Supplying DO line               (MRPONR)
		/// FieldName: SPDL
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying DO line               (MRPONR)")]
		public int? M3SPDL => GetNullableInt("SPDL");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Supplying order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying order category")]
		public int? M3RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Supplying order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying order number")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Supplying order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying order line")]
		public int? M3RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Alternative material
		/// FieldName: MALT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternative material")]
		public int? M3MALT => GetNullableInt("MALT");

		/// <summary>
		/// Description: Quantity relation
		/// FieldName: FXCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity relation")]
		public int? M3FXCD => GetNullableInt("FXCD");

		/// <summary>
		/// Description: Priority on alternativ material
		/// FieldName: PREX
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority on alternativ material")]
		public string M3PREX => GetString("PREX");

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
		/// Description: Number of decimals (DCCD)
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimals (DCCD)")]
		public int? M3DCCD => GetNullableInt("DCCD");

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
		/// Description: Product engineering U/M
		/// FieldName: PEUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product engineering U/M")]
		public string M3PEUN => GetString("PEUN");
	}
}
// EOF
