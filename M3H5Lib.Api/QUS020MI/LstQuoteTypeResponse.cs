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

namespace M3H5Lib.Api.QUS020MI
{
	public partial class LstQuoteTypeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Quotation type
		/// FieldName: QUTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quotation type")]
		public string M3_QUTY => GetString("QUTY");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Customer order type
		/// FieldName: ORTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order type")]
		public string M3_ORTP => GetString("ORTP");

		/// <summary>
		/// Description: Sales manager
		/// FieldName: SMNG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales manager")]
		public string M3_SMNG => GetString("SMNG");

		/// <summary>
		/// Description: Preliminary quotation
		/// FieldName: PREL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preliminary quotation")]
		public int? M3_PREL => GetNullableInt("PREL");

		/// <summary>
		/// Description: Location
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3_WHSL => GetString("WHSL");

		/// <summary>
		/// Description: Template customer
		/// FieldName: TPCU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Template customer")]
		public string M3_TPCU => GetString("TPCU");

		/// <summary>
		/// Description: Price list table
		/// FieldName: PLTB
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list table")]
		public string M3_PLTB => GetString("PLTB");

		/// <summary>
		/// Description: SMS Quote
		/// FieldName: QSMS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SMS Quote")]
		public int? M3_QSMS => GetNullableInt("QSMS");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

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
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");

		/// <summary>
		/// Description: Lowest margin
		/// FieldName: QLMA
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest margin")]
		public int? M3_QLMA => GetNullableInt("QLMA");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3_STRT => GetString("STRT");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3_SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Entry option
		/// FieldName: OT06
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry option")]
		public int? M3_OT06 => GetNullableInt("OT06");
	}
}
// EOF