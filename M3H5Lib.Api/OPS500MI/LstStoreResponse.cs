/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.OPS500MI
{
	public partial class LstStoreResponse : M3BaseRecord 
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
		/// Description: Store ID
		/// FieldName: RSTN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store ID")]
		public string M3RSTN => GetString("RSTN");

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
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3CUNM => GetString("CUNM");

		/// <summary>
		/// Description: District
		/// FieldName: SDST
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("District")]
		public string M3SDST => GetString("SDST");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3PYNO => GetString("PYNO");

		/// <summary>
		/// Description: Statistics customer
		/// FieldName: CUST
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics customer")]
		public string M3CUST => GetString("CUST");

		/// <summary>
		/// Description: Statistics identity 1
		/// FieldName: FRE1
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 1")]
		public string M3FRE1 => GetString("FRE1");

		/// <summary>
		/// Description: Statistics identity 2
		/// FieldName: FRE2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 2")]
		public string M3FRE2 => GetString("FRE2");

		/// <summary>
		/// Description: Company group customer
		/// FieldName: CCUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company group customer")]
		public string M3CCUS => GetString("CCUS");

		/// <summary>
		/// Description: User-defined field 1
		/// FieldName: CFC1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1")]
		public string M3CFC1 => GetString("CFC1");

		/// <summary>
		/// Description: User-defined field 2
		/// FieldName: CFC2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2")]
		public decimal? M3CFC2 => GetNullableDecimal("CFC2");

		/// <summary>
		/// Description: User-defined field 3
		/// FieldName: CFC3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3")]
		public string M3CFC3 => GetString("CFC3");

		/// <summary>
		/// Description: User-defined field 4
		/// FieldName: CFC4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4")]
		public string M3CFC4 => GetString("CFC4");

		/// <summary>
		/// Description: User-defined field 5
		/// FieldName: CFC5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5")]
		public string M3CFC5 => GetString("CFC5");

		/// <summary>
		/// Description: User-defined field 6
		/// FieldName: CFC6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 6")]
		public string M3CFC6 => GetString("CFC6");

		/// <summary>
		/// Description: User-defined field 7
		/// FieldName: CFC7
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 7")]
		public decimal? M3CFC7 => GetNullableDecimal("CFC7");

		/// <summary>
		/// Description: User-defined field 8
		/// FieldName: CFC8
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 8")]
		public string M3CFC8 => GetString("CFC8");

		/// <summary>
		/// Description: User-defined field 9
		/// FieldName: CFC9
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 9")]
		public string M3CFC9 => GetString("CFC9");

		/// <summary>
		/// Description: User-defined field 10
		/// FieldName: CFC0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 10")]
		public string M3CFC0 => GetString("CFC0");

		/// <summary>
		/// Description: Company name
		/// FieldName: CONM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company name")]
		public string M3CONM => GetString("CONM");

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
		/// Description: Area/State
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Area/State")]
		public string M3ECAR => GetString("ECAR");

		/// <summary>
		/// Description: Town/City
		/// FieldName: TOWN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Town/City")]
		public string M3TOWN => GetString("TOWN");

		/// <summary>
		/// Description: Planning Node
		/// FieldName: PNOD
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning Node")]
		public string M3PNOD => GetString("PNOD");

		/// <summary>
		/// Description: Shop category
		/// FieldName: STCE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shop category")]
		public string M3STCE => GetString("STCE");

		/// <summary>
		/// Description: Business area
		/// FieldName: BUAR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business area")]
		public string M3BUAR => GetString("BUAR");

		/// <summary>
		/// Description: Shop class
		/// FieldName: STOC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shop class")]
		public string M3STOC => GetString("STOC");

		/// <summary>
		/// Description: Shop volume class
		/// FieldName: VOLC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shop volume class")]
		public string M3VOLC => GetString("VOLC");

		/// <summary>
		/// Description: Store User-defined field 1
		/// FieldName: WF01
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 1")]
		public string M3WF01 => GetString("WF01");

		/// <summary>
		/// Description: Store User-defined field 2
		/// FieldName: WF02
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 2")]
		public string M3WF02 => GetString("WF02");

		/// <summary>
		/// Description: Store User-defined field 3
		/// FieldName: WF03
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 3")]
		public string M3WF03 => GetString("WF03");

		/// <summary>
		/// Description: Store User-defined field 4
		/// FieldName: WF04
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 4")]
		public string M3WF04 => GetString("WF04");

		/// <summary>
		/// Description: Store User-defined field 5
		/// FieldName: WF05
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 5")]
		public string M3WF05 => GetString("WF05");

		/// <summary>
		/// Description: Store User-defined field 6
		/// FieldName: WF06
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 6")]
		public string M3WF06 => GetString("WF06");

		/// <summary>
		/// Description: Store User-defined field 7
		/// FieldName: WF07
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 7")]
		public string M3WF07 => GetString("WF07");

		/// <summary>
		/// Description: Store User-defined field 8
		/// FieldName: WF08
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 8")]
		public string M3WF08 => GetString("WF08");

		/// <summary>
		/// Description: Store User-defined field 9
		/// FieldName: WF09
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 9")]
		public decimal? M3WF09 => GetNullableDecimal("WF09");

		/// <summary>
		/// Description: Store User-defined field 10
		/// FieldName: WF10
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 10")]
		public decimal? M3WF10 => GetNullableDecimal("WF10");

		/// <summary>
		/// Description: Store User-defined field 11
		/// FieldName: WF11
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 11")]
		public decimal? M3WF11 => GetNullableDecimal("WF11");

		/// <summary>
		/// Description: Store User-defined field 12
		/// FieldName: WF12
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 12")]
		public decimal? M3WF12 => GetNullableDecimal("WF12");

		/// <summary>
		/// Description: Store User-defined field 13
		/// FieldName: WF13
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 13")]
		public decimal? M3WF13 => GetNullableDecimal("WF13");

		/// <summary>
		/// Description: Store User-defined field 14
		/// FieldName: WF14
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 14")]
		public decimal? M3WF14 => GetNullableDecimal("WF14");

		/// <summary>
		/// Description: Store User-defined field 15
		/// FieldName: WF15
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 15")]
		public DateTime? M3WF15 => GetNullableDateTime("WF15");

		/// <summary>
		/// Description: Store User-defined field 16
		/// FieldName: WF16
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 16")]
		public DateTime? M3WF16 => GetNullableDateTime("WF16");

		/// <summary>
		/// Description: Store User-defined field 17
		/// FieldName: WF17
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 17")]
		public int? M3WF17 => GetNullableInt("WF17");

		/// <summary>
		/// Description: Store User-defined field 18
		/// FieldName: WF18
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 18")]
		public int? M3WF18 => GetNullableInt("WF18");

		/// <summary>
		/// Description: Store User-defined field 19
		/// FieldName: WF19
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 19")]
		public int? M3WF19 => GetNullableInt("WF19");

		/// <summary>
		/// Description: Store User-defined field 20
		/// FieldName: WF20
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 20")]
		public int? M3WF20 => GetNullableInt("WF20");

		/// <summary>
		/// Description: Store User-defined field 21
		/// FieldName: WF21
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 21")]
		public int? M3WF21 => GetNullableInt("WF21");

		/// <summary>
		/// Description: Store User-defined field 22
		/// FieldName: WF22
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 22")]
		public int? M3WF22 => GetNullableInt("WF22");

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
