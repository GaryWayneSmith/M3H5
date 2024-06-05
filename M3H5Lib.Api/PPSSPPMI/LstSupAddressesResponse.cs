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

namespace M3H5Lib.Api.PPSSPPMI
{
	public partial class LstSupAddressesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Purchase order number
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order number")]
		public string M3_PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Supplier address key 2
		/// FieldName: SAK2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address key 2")]
		public string M3_SAK2 => GetString("SAK2");

		/// <summary>
		/// Description: Supplier address key 3
		/// FieldName: SAK3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address key 3")]
		public string M3_SAK3 => GetString("SAK3");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SNAM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3_SNAM => GetString("SNAM");

		/// <summary>
		/// Description: Supplier address line 1
		/// FieldName: SAD1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address line 1")]
		public string M3_SAD1 => GetString("SAD1");

		/// <summary>
		/// Description: Supplier address line 2
		/// FieldName: SAD2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address line 2")]
		public string M3_SAD2 => GetString("SAD2");

		/// <summary>
		/// Description: Supplier address line 3
		/// FieldName: SAD3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address line 3")]
		public string M3_SAD3 => GetString("SAD3");

		/// <summary>
		/// Description: Supplier address line 4
		/// FieldName: SAD4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address line 4")]
		public string M3_SAD4 => GetString("SAD4");

		/// <summary>
		/// Description: Supplier City
		/// FieldName: STOW
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier City")]
		public string M3_STOW => GetString("STOW");

		/// <summary>
		/// Description: Supplier State
		/// FieldName: SECA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier State")]
		public string M3_SECA => GetString("SECA");

		/// <summary>
		/// Description: Supplier Postal code
		/// FieldName: SPON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier Postal code")]
		public string M3_SPON => GetString("SPON");

		/// <summary>
		/// Description: Supplier Country
		/// FieldName: SCSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier Country")]
		public string M3_SCSC => GetString("SCSC");

		/// <summary>
		/// Description: Via Goods Receiver address key 2
		/// FieldName: VAK2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver address key 2")]
		public string M3_VAK2 => GetString("VAK2");

		/// <summary>
		/// Description: Via Goods Receiver address key 3
		/// FieldName: VAK3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver address key 3")]
		public string M3_VAK3 => GetString("VAK3");

		/// <summary>
		/// Description: Via Goods Receiver Name
		/// FieldName: VNAM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Name")]
		public string M3_VNAM => GetString("VNAM");

		/// <summary>
		/// Description: Via Goods Receiver Address line 1
		/// FieldName: VAD1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Address line 1")]
		public string M3_VAD1 => GetString("VAD1");

		/// <summary>
		/// Description: Via Goods Receiver Address line 2
		/// FieldName: VAD2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Address line 2")]
		public string M3_VAD2 => GetString("VAD2");

		/// <summary>
		/// Description: Via Goods Receiver Address line 3
		/// FieldName: VAD3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Address line 3")]
		public string M3_VAD3 => GetString("VAD3");

		/// <summary>
		/// Description: Via Goods Receiver Address line 4
		/// FieldName: VAD4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Address line 4")]
		public string M3_VAD4 => GetString("VAD4");

		/// <summary>
		/// Description: Via Goods Receiver City
		/// FieldName: VTOW
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver City")]
		public string M3_VTOW => GetString("VTOW");

		/// <summary>
		/// Description: Via Goods Receiver State
		/// FieldName: VECA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver State")]
		public string M3_VECA => GetString("VECA");

		/// <summary>
		/// Description: Via Goods Receiver Postal code
		/// FieldName: VPON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Postal code")]
		public string M3_VPON => GetString("VPON");

		/// <summary>
		/// Description: Via Goods Receiver Country
		/// FieldName: VCSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Country")]
		public string M3_VCSC => GetString("VCSC");

		/// <summary>
		/// Description: Invoce Receiver name
		/// FieldName: INAM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoce Receiver name")]
		public string M3_INAM => GetString("INAM");

		/// <summary>
		/// Description: Invoice Receiver Address line 1
		/// FieldName: IAD1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Address line 1")]
		public string M3_IAD1 => GetString("IAD1");

		/// <summary>
		/// Description: Invoice Receiver Address line 2
		/// FieldName: IAD2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Address line 2")]
		public string M3_IAD2 => GetString("IAD2");

		/// <summary>
		/// Description: Invoice Receiver Address line 3
		/// FieldName: IAD3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Address line 3")]
		public string M3_IAD3 => GetString("IAD3");

		/// <summary>
		/// Description: Invoice Receiver Address line 4
		/// FieldName: IAD4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Address line 4")]
		public string M3_IAD4 => GetString("IAD4");

		/// <summary>
		/// Description: Invoice Receiver City
		/// FieldName: ITOW
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver City")]
		public string M3_ITOW => GetString("ITOW");

		/// <summary>
		/// Description: Invoice Receiver State
		/// FieldName: IECA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver State")]
		public string M3_IECA => GetString("IECA");

		/// <summary>
		/// Description: Invoice Receiver Postal code
		/// FieldName: IPON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Postal code")]
		public string M3_IPON => GetString("IPON");

		/// <summary>
		/// Description: Invoice Receiver Country
		/// FieldName: ICSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Country")]
		public string M3_ICSC => GetString("ICSC");

		/// <summary>
		/// Description: Delivery Address key 2
		/// FieldName: DAK2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address key 2")]
		public string M3_DAK2 => GetString("DAK2");

		/// <summary>
		/// Description: Delivery Address key 3
		/// FieldName: DAK3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address key 3")]
		public string M3_DAK3 => GetString("DAK3");

		/// <summary>
		/// Description: Delivery Receiver name
		/// FieldName: DNAM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Receiver name")]
		public string M3_DNAM => GetString("DNAM");

		/// <summary>
		/// Description: Delivery Address line 1
		/// FieldName: DAD1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address line 1")]
		public string M3_DAD1 => GetString("DAD1");

		/// <summary>
		/// Description: Delivery Address line 2
		/// FieldName: DAD2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address line 2")]
		public string M3_DAD2 => GetString("DAD2");

		/// <summary>
		/// Description: Delivery Address line 3
		/// FieldName: DAD3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address line 3")]
		public string M3_DAD3 => GetString("DAD3");

		/// <summary>
		/// Description: Delivery Address line 4
		/// FieldName: DAD4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address line 4")]
		public string M3_DAD4 => GetString("DAD4");

		/// <summary>
		/// Description: Delivery Address City
		/// FieldName: DTOW
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address City")]
		public string M3_DTOW => GetString("DTOW");

		/// <summary>
		/// Description: Delivery Address State
		/// FieldName: DECA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address State")]
		public string M3_DECA => GetString("DECA");

		/// <summary>
		/// Description: Delivery Address Postal code
		/// FieldName: DPON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address Postal code")]
		public string M3_DPON => GetString("DPON");

		/// <summary>
		/// Description: Delivery Address Country
		/// FieldName: DCSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address Country")]
		public string M3_DCSC => GetString("DCSC");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3_LMTS => GetNullableDecimal("LMTS");

		/// <summary>
		/// Description: County ID
		/// FieldName: FRCO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County ID")]
		public string M3_FRCO => GetString("FRCO");
	}
}
// EOF
