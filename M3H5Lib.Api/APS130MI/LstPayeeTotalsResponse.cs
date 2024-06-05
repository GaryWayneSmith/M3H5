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

namespace M3H5Lib.Api.APS130MI
{
	public partial class LstPayeeTotalsResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Payment proposal
		/// FieldName: PRPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment proposal")]
		public long? M3PRPN => GetNullableLong("PRPN");

		/// <summary>
		/// Description: Payment order
		/// FieldName: PYON
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment order")]
		public int? M3PYON => GetNullableInt("PYON");

		/// <summary>
		/// Description: Payee
		/// FieldName: SPYN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payee")]
		public string M3SPYN => GetString("SPYN");

		/// <summary>
		/// Description: Payment document number
		/// FieldName: PDNB
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment document number")]
		public int? M3PDNB => GetNullableInt("PDNB");

		/// <summary>
		/// Description: Foreign currency amount
		/// FieldName: CUAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign currency amount")]
		public decimal? M3CUAM => GetNullableDecimal("CUAM");

		/// <summary>
		/// Description: Number of payments
		/// FieldName: NOPD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of payments")]
		public int? M3NOPD => GetNullableInt("NOPD");

		/// <summary>
		/// Description: Cost allocation code
		/// FieldName: CSTC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost allocation code")]
		public int? M3CSTC => GetNullableInt("CSTC");

		/// <summary>
		/// Description: Bank account identity
		/// FieldName: BKID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3BKID => GetString("BKID");

		/// <summary>
		/// Description: Bank number
		/// FieldName: BKNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank number")]
		public string M3BKNO => GetString("BKNO");

		/// <summary>
		/// Description: Bank name
		/// FieldName: BKNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank name")]
		public string M3BKNM => GetString("BKNM");

		/// <summary>
		/// Description: Bank address 1
		/// FieldName: BKA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 1")]
		public string M3BKA1 => GetString("BKA1");

		/// <summary>
		/// Description: Bank address 2
		/// FieldName: BKA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 2")]
		public string M3BKA2 => GetString("BKA2");

		/// <summary>
		/// Description: Bank address 3
		/// FieldName: BKA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 3")]
		public string M3BKA3 => GetString("BKA3");

		/// <summary>
		/// Description: Bank address 4
		/// FieldName: BKA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 4")]
		public string M3BKA4 => GetString("BKA4");

		/// <summary>
		/// Description: Bank country
		/// FieldName: BCCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank country")]
		public string M3BCCD => GetString("BCCD");

		/// <summary>
		/// Description: Bank account number for foreign payment
		/// FieldName: BKAC
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account number for foreign payment")]
		public string M3BKAC => GetString("BKAC");

		/// <summary>
		/// Description: Swift code
		/// FieldName: SWIC
		/// FieldType: A
		/// Length: 34
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Swift code")]
		public string M3SWIC => GetString("SWIC");

		/// <summary>
		/// Description: Bank account field 1
		/// FieldName: BAF1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 1")]
		public string M3BAF1 => GetString("BAF1");

		/// <summary>
		/// Description: Bank account field 2
		/// FieldName: BAF2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 2")]
		public string M3BAF2 => GetString("BAF2");

		/// <summary>
		/// Description: Bank account field 3
		/// FieldName: BAF3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 3")]
		public string M3BAF3 => GetString("BAF3");

		/// <summary>
		/// Description: Bank account field 4
		/// FieldName: BAF4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 4")]
		public string M3BAF4 => GetString("BAF4");

		/// <summary>
		/// Description: Bank account field 5
		/// FieldName: BAF5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 5")]
		public string M3BAF5 => GetString("BAF5");

		/// <summary>
		/// Description: Length - bank account identity field 1
		/// FieldName: BIL1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - bank account identity field 1")]
		public int? M3BIL1 => GetNullableInt("BIL1");

		/// <summary>
		/// Description: Length - bank account identity field 2
		/// FieldName: BIL2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - bank account identity field 2")]
		public int? M3BIL2 => GetNullableInt("BIL2");

		/// <summary>
		/// Description: Length - bank account identity field 3
		/// FieldName: BIL3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - bank account identity field 3")]
		public int? M3BIL3 => GetNullableInt("BIL3");

		/// <summary>
		/// Description: Length - bank account identity field 4
		/// FieldName: BIL4
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - bank account identity field 4")]
		public int? M3BIL4 => GetNullableInt("BIL4");

		/// <summary>
		/// Description: Length - bank account identity field 5
		/// FieldName: BIL5
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - bank account identity field 5")]
		public int? M3BIL5 => GetNullableInt("BIL5");

		/// <summary>
		/// Description: Numeric field 1 position
		/// FieldName: NUM1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 1 position")]
		public int? M3NUM1 => GetNullableInt("NUM1");

		/// <summary>
		/// Description: Numeric field 1 position
		/// FieldName: NUM2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 1 position")]
		public int? M3NUM2 => GetNullableInt("NUM2");

		/// <summary>
		/// Description: Numeric field 1 position
		/// FieldName: NUM3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 1 position")]
		public int? M3NUM3 => GetNullableInt("NUM3");

		/// <summary>
		/// Description: Numeric field 1 position
		/// FieldName: NUM4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 1 position")]
		public int? M3NUM4 => GetNullableInt("NUM4");

		/// <summary>
		/// Description: Numeric field 1 position
		/// FieldName: NUM5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 1 position")]
		public int? M3NUM5 => GetNullableInt("NUM5");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Address line 1
		/// FieldName: ADR1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 1")]
		public string M3ADR1 => GetString("ADR1");

		/// <summary>
		/// Description: Address line 2
		/// FieldName: ADR2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 2")]
		public string M3ADR2 => GetString("ADR2");

		/// <summary>
		/// Description: Address line 3
		/// FieldName: ADR3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 3")]
		public string M3ADR3 => GetString("ADR3");

		/// <summary>
		/// Description: Address line 4
		/// FieldName: ADR4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 4")]
		public string M3ADR4 => GetString("ADR4");

		/// <summary>
		/// Description: Country
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3CSCD => GetString("CSCD");

		/// <summary>
		/// Description: Postal code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3PONO => GetString("PONO");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACAM => GetNullableDecimal("ACAM");

		/// <summary>
		/// Description: City
		/// FieldName: TOWB
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("City")]
		public string M3TOWB => GetString("TOWB");

		/// <summary>
		/// Description: State
		/// FieldName: ECAB
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("State")]
		public string M3ECAB => GetString("ECAB");

		/// <summary>
		/// Description: Postal code
		/// FieldName: PONB
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3PONB => GetString("PONB");

		/// <summary>
		/// Description: City
		/// FieldName: TOWN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("City")]
		public string M3TOWN => GetString("TOWN");

		/// <summary>
		/// Description: State
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("State")]
		public string M3ECAR => GetString("ECAR");

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

		/// <summary>
		/// Description: County ID
		/// FieldName: FRCB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County ID")]
		public string M3FRCB => GetString("FRCB");
	}
}
// EOF
