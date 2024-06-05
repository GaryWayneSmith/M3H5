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
		public string M3PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Supplier address key 2
		/// FieldName: SAK2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address key 2")]
		public string M3SAK2 => GetString("SAK2");

		/// <summary>
		/// Description: Supplier address key 3
		/// FieldName: SAK3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address key 3")]
		public string M3SAK3 => GetString("SAK3");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SNAM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3SNAM => GetString("SNAM");

		/// <summary>
		/// Description: Supplier address line 1
		/// FieldName: SAD1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address line 1")]
		public string M3SAD1 => GetString("SAD1");

		/// <summary>
		/// Description: Supplier address line 2
		/// FieldName: SAD2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address line 2")]
		public string M3SAD2 => GetString("SAD2");

		/// <summary>
		/// Description: Supplier address line 3
		/// FieldName: SAD3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address line 3")]
		public string M3SAD3 => GetString("SAD3");

		/// <summary>
		/// Description: Supplier address line 4
		/// FieldName: SAD4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier address line 4")]
		public string M3SAD4 => GetString("SAD4");

		/// <summary>
		/// Description: Supplier City
		/// FieldName: STOW
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier City")]
		public string M3STOW => GetString("STOW");

		/// <summary>
		/// Description: Supplier State
		/// FieldName: SECA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier State")]
		public string M3SECA => GetString("SECA");

		/// <summary>
		/// Description: Supplier Postal code
		/// FieldName: SPON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier Postal code")]
		public string M3SPON => GetString("SPON");

		/// <summary>
		/// Description: Supplier Country
		/// FieldName: SCSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier Country")]
		public string M3SCSC => GetString("SCSC");

		/// <summary>
		/// Description: Via Goods Receiver address key 2
		/// FieldName: VAK2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver address key 2")]
		public string M3VAK2 => GetString("VAK2");

		/// <summary>
		/// Description: Via Goods Receiver address key 3
		/// FieldName: VAK3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver address key 3")]
		public string M3VAK3 => GetString("VAK3");

		/// <summary>
		/// Description: Via Goods Receiver Name
		/// FieldName: VNAM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Name")]
		public string M3VNAM => GetString("VNAM");

		/// <summary>
		/// Description: Via Goods Receiver Address line 1
		/// FieldName: VAD1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Address line 1")]
		public string M3VAD1 => GetString("VAD1");

		/// <summary>
		/// Description: Via Goods Receiver Address line 2
		/// FieldName: VAD2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Address line 2")]
		public string M3VAD2 => GetString("VAD2");

		/// <summary>
		/// Description: Via Goods Receiver Address line 3
		/// FieldName: VAD3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Address line 3")]
		public string M3VAD3 => GetString("VAD3");

		/// <summary>
		/// Description: Via Goods Receiver Address line 4
		/// FieldName: VAD4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Address line 4")]
		public string M3VAD4 => GetString("VAD4");

		/// <summary>
		/// Description: Via Goods Receiver City
		/// FieldName: VTOW
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver City")]
		public string M3VTOW => GetString("VTOW");

		/// <summary>
		/// Description: Via Goods Receiver State
		/// FieldName: VECA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver State")]
		public string M3VECA => GetString("VECA");

		/// <summary>
		/// Description: Via Goods Receiver Postal code
		/// FieldName: VPON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Postal code")]
		public string M3VPON => GetString("VPON");

		/// <summary>
		/// Description: Via Goods Receiver Country
		/// FieldName: VCSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via Goods Receiver Country")]
		public string M3VCSC => GetString("VCSC");

		/// <summary>
		/// Description: Invoce Receiver name
		/// FieldName: INAM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoce Receiver name")]
		public string M3INAM => GetString("INAM");

		/// <summary>
		/// Description: Invoice Receiver Address line 1
		/// FieldName: IAD1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Address line 1")]
		public string M3IAD1 => GetString("IAD1");

		/// <summary>
		/// Description: Invoice Receiver Address line 2
		/// FieldName: IAD2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Address line 2")]
		public string M3IAD2 => GetString("IAD2");

		/// <summary>
		/// Description: Invoice Receiver Address line 3
		/// FieldName: IAD3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Address line 3")]
		public string M3IAD3 => GetString("IAD3");

		/// <summary>
		/// Description: Invoice Receiver Address line 4
		/// FieldName: IAD4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Address line 4")]
		public string M3IAD4 => GetString("IAD4");

		/// <summary>
		/// Description: Invoice Receiver City
		/// FieldName: ITOW
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver City")]
		public string M3ITOW => GetString("ITOW");

		/// <summary>
		/// Description: Invoice Receiver State
		/// FieldName: IECA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver State")]
		public string M3IECA => GetString("IECA");

		/// <summary>
		/// Description: Invoice Receiver Postal code
		/// FieldName: IPON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Postal code")]
		public string M3IPON => GetString("IPON");

		/// <summary>
		/// Description: Invoice Receiver Country
		/// FieldName: ICSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Receiver Country")]
		public string M3ICSC => GetString("ICSC");

		/// <summary>
		/// Description: Delivery Address key 2
		/// FieldName: DAK2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address key 2")]
		public string M3DAK2 => GetString("DAK2");

		/// <summary>
		/// Description: Delivery Address key 3
		/// FieldName: DAK3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address key 3")]
		public string M3DAK3 => GetString("DAK3");

		/// <summary>
		/// Description: Delivery Receiver name
		/// FieldName: DNAM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Receiver name")]
		public string M3DNAM => GetString("DNAM");

		/// <summary>
		/// Description: Delivery Address line 1
		/// FieldName: DAD1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address line 1")]
		public string M3DAD1 => GetString("DAD1");

		/// <summary>
		/// Description: Delivery Address line 2
		/// FieldName: DAD2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address line 2")]
		public string M3DAD2 => GetString("DAD2");

		/// <summary>
		/// Description: Delivery Address line 3
		/// FieldName: DAD3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address line 3")]
		public string M3DAD3 => GetString("DAD3");

		/// <summary>
		/// Description: Delivery Address line 4
		/// FieldName: DAD4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address line 4")]
		public string M3DAD4 => GetString("DAD4");

		/// <summary>
		/// Description: Delivery Address City
		/// FieldName: DTOW
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address City")]
		public string M3DTOW => GetString("DTOW");

		/// <summary>
		/// Description: Delivery Address State
		/// FieldName: DECA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address State")]
		public string M3DECA => GetString("DECA");

		/// <summary>
		/// Description: Delivery Address Postal code
		/// FieldName: DPON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address Postal code")]
		public string M3DPON => GetString("DPON");

		/// <summary>
		/// Description: Delivery Address Country
		/// FieldName: DCSC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery Address Country")]
		public string M3DCSC => GetString("DCSC");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3LMTS => GetNullableDecimal("LMTS");

		/// <summary>
		/// Description: County ID
		/// FieldName: FRCO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County ID")]
		public string M3FRCO => GetString("FRCO");
	}
}
// EOF
