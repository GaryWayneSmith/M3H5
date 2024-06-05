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

namespace M3H5Lib.Api.MMS450MI
{
	public partial class LstPckInstDetResponse : M3BaseRecord 
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
		/// Description: Packing instruction header number
		/// FieldName: PINN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packing instruction header number")]
		public long? M3PINN => GetNullableLong("PINN");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3SUNO => GetString("SUNO");

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
		/// Description: Requested delivery date
		/// FieldName: DWDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery date")]
		public DateTime? M3DWDT => GetNullableDateTime("DWDT");

		/// <summary>
		/// Description: Requested delivery time
		/// FieldName: DWHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery time")]
		public int? M3DWHM => GetNullableInt("DWHM");

		/// <summary>
		/// Description: Packaging Istruction Status
		/// FieldName: INPS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging Istruction Status")]
		public string M3INPS => GetString("INPS");

		/// <summary>
		/// Description: Pre-pack number
		/// FieldName: PPNB
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pre-pack number")]
		public string M3PPNB => GetString("PPNB");

		/// <summary>
		/// Description: Number of packages
		/// FieldName: NBPA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of packages")]
		public decimal? M3NBPA => GetNullableDecimal("NBPA");

		/// <summary>
		/// Description: Number of packages to consignee
		/// FieldName: NBPC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of packages to consignee")]
		public decimal? M3NBPC => GetNullableDecimal("NBPC");

		/// <summary>
		/// Description: Packaging Istruction Status
		/// FieldName: INP2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging Istruction Status")]
		public string M3INP2 => GetString("INP2");

		/// <summary>
		/// Description: SSCC number
		/// FieldName: SSCC
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SSCC number")]
		public string M3SSCC => GetString("SSCC");

		/// <summary>
		/// Description: Pre-pack type
		/// FieldName: PPTY
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pre-pack type")]
		public string M3PPTY => GetString("PPTY");

		/// <summary>
		/// Description: Pre-pack status
		/// FieldName: PPSA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pre-pack status")]
		public string M3PPSA => GetString("PPSA");

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Description
		/// FieldName: DSCR
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3DSCR => GetString("DSCR");

		/// <summary>
		/// Description: Packaging
		/// FieldName: PACT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging")]
		public string M3PACT => GetString("PACT");

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
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3STRT => GetString("STRT");

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
		/// Description: Item number
		/// FieldName: ITN2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITN2 => GetString("ITN2");

		/// <summary>
		/// Description: Style number
		/// FieldName: STYN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Style number")]
		public string M3STYN => GetString("STYN");

		/// <summary>
		/// Description: Z-option
		/// FieldName: OPTZ
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Z-option")]
		public string M3OPTZ => GetString("OPTZ");

		/// <summary>
		/// Description: Y-option
		/// FieldName: OPTY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Y-option")]
		public string M3OPTY => GetString("OPTY");

		/// <summary>
		/// Description: X-option
		/// FieldName: OPTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("X-option")]
		public string M3OPTX => GetString("OPTX");

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
		/// Description: Standard quantity
		/// FieldName: D1QT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard quantity")]
		public decimal? M3D1QT => GetNullableDecimal("D1QT");

		/// <summary>
		/// Description: Minimum quantity
		/// FieldName: D2QT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum quantity")]
		public decimal? M3D2QT => GetNullableDecimal("D2QT");

		/// <summary>
		/// Description: Maximum quantity
		/// FieldName: D3QT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum quantity")]
		public decimal? M3D3QT => GetNullableDecimal("D3QT");
	}
}
// EOF
