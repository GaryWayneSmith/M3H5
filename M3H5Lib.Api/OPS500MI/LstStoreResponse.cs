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
		public int? M3_CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Store ID
		/// FieldName: RSTN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store ID")]
		public string M3_RSTN => GetString("RSTN");

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
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3_CUNM => GetString("CUNM");

		/// <summary>
		/// Description: District
		/// FieldName: SDST
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("District")]
		public string M3_SDST => GetString("SDST");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3_PYNO => GetString("PYNO");

		/// <summary>
		/// Description: Statistics customer
		/// FieldName: CUST
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics customer")]
		public string M3_CUST => GetString("CUST");

		/// <summary>
		/// Description: Statistics identity 1
		/// FieldName: FRE1
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 1")]
		public string M3_FRE1 => GetString("FRE1");

		/// <summary>
		/// Description: Statistics identity 2
		/// FieldName: FRE2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 2")]
		public string M3_FRE2 => GetString("FRE2");

		/// <summary>
		/// Description: Company group customer
		/// FieldName: CCUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company group customer")]
		public string M3_CCUS => GetString("CCUS");

		/// <summary>
		/// Description: User-defined field 1
		/// FieldName: CFC1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1")]
		public string M3_CFC1 => GetString("CFC1");

		/// <summary>
		/// Description: User-defined field 2
		/// FieldName: CFC2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2")]
		public decimal? M3_CFC2 => GetNullableDecimal("CFC2");

		/// <summary>
		/// Description: User-defined field 3
		/// FieldName: CFC3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3")]
		public string M3_CFC3 => GetString("CFC3");

		/// <summary>
		/// Description: User-defined field 4
		/// FieldName: CFC4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4")]
		public string M3_CFC4 => GetString("CFC4");

		/// <summary>
		/// Description: User-defined field 5
		/// FieldName: CFC5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5")]
		public string M3_CFC5 => GetString("CFC5");

		/// <summary>
		/// Description: User-defined field 6
		/// FieldName: CFC6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 6")]
		public string M3_CFC6 => GetString("CFC6");

		/// <summary>
		/// Description: User-defined field 7
		/// FieldName: CFC7
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 7")]
		public decimal? M3_CFC7 => GetNullableDecimal("CFC7");

		/// <summary>
		/// Description: User-defined field 8
		/// FieldName: CFC8
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 8")]
		public string M3_CFC8 => GetString("CFC8");

		/// <summary>
		/// Description: User-defined field 9
		/// FieldName: CFC9
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 9")]
		public string M3_CFC9 => GetString("CFC9");

		/// <summary>
		/// Description: User-defined field 10
		/// FieldName: CFC0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 10")]
		public string M3_CFC0 => GetString("CFC0");

		/// <summary>
		/// Description: Company name
		/// FieldName: CONM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company name")]
		public string M3_CONM => GetString("CONM");

		/// <summary>
		/// Description: Address line 1
		/// FieldName: ADR1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 1")]
		public string M3_ADR1 => GetString("ADR1");

		/// <summary>
		/// Description: Address line 2
		/// FieldName: ADR2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 2")]
		public string M3_ADR2 => GetString("ADR2");

		/// <summary>
		/// Description: Address line 3
		/// FieldName: ADR3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 3")]
		public string M3_ADR3 => GetString("ADR3");

		/// <summary>
		/// Description: Address line 4
		/// FieldName: ADR4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address line 4")]
		public string M3_ADR4 => GetString("ADR4");

		/// <summary>
		/// Description: Country
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3_CSCD => GetString("CSCD");

		/// <summary>
		/// Description: Postal code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3_PONO => GetString("PONO");

		/// <summary>
		/// Description: Area/State
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Area/State")]
		public string M3_ECAR => GetString("ECAR");

		/// <summary>
		/// Description: Town/City
		/// FieldName: TOWN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Town/City")]
		public string M3_TOWN => GetString("TOWN");

		/// <summary>
		/// Description: Planning Node
		/// FieldName: PNOD
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning Node")]
		public string M3_PNOD => GetString("PNOD");

		/// <summary>
		/// Description: Shop category
		/// FieldName: STCE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shop category")]
		public string M3_STCE => GetString("STCE");

		/// <summary>
		/// Description: Business area
		/// FieldName: BUAR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business area")]
		public string M3_BUAR => GetString("BUAR");

		/// <summary>
		/// Description: Shop class
		/// FieldName: STOC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shop class")]
		public string M3_STOC => GetString("STOC");

		/// <summary>
		/// Description: Shop volume class
		/// FieldName: VOLC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shop volume class")]
		public string M3_VOLC => GetString("VOLC");

		/// <summary>
		/// Description: Store User-defined field 1
		/// FieldName: WF01
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 1")]
		public string M3_WF01 => GetString("WF01");

		/// <summary>
		/// Description: Store User-defined field 2
		/// FieldName: WF02
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 2")]
		public string M3_WF02 => GetString("WF02");

		/// <summary>
		/// Description: Store User-defined field 3
		/// FieldName: WF03
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 3")]
		public string M3_WF03 => GetString("WF03");

		/// <summary>
		/// Description: Store User-defined field 4
		/// FieldName: WF04
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 4")]
		public string M3_WF04 => GetString("WF04");

		/// <summary>
		/// Description: Store User-defined field 5
		/// FieldName: WF05
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 5")]
		public string M3_WF05 => GetString("WF05");

		/// <summary>
		/// Description: Store User-defined field 6
		/// FieldName: WF06
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 6")]
		public string M3_WF06 => GetString("WF06");

		/// <summary>
		/// Description: Store User-defined field 7
		/// FieldName: WF07
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 7")]
		public string M3_WF07 => GetString("WF07");

		/// <summary>
		/// Description: Store User-defined field 8
		/// FieldName: WF08
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 8")]
		public string M3_WF08 => GetString("WF08");

		/// <summary>
		/// Description: Store User-defined field 9
		/// FieldName: WF09
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 9")]
		public decimal? M3_WF09 => GetNullableDecimal("WF09");

		/// <summary>
		/// Description: Store User-defined field 10
		/// FieldName: WF10
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 10")]
		public decimal? M3_WF10 => GetNullableDecimal("WF10");

		/// <summary>
		/// Description: Store User-defined field 11
		/// FieldName: WF11
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 11")]
		public decimal? M3_WF11 => GetNullableDecimal("WF11");

		/// <summary>
		/// Description: Store User-defined field 12
		/// FieldName: WF12
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 12")]
		public decimal? M3_WF12 => GetNullableDecimal("WF12");

		/// <summary>
		/// Description: Store User-defined field 13
		/// FieldName: WF13
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 13")]
		public decimal? M3_WF13 => GetNullableDecimal("WF13");

		/// <summary>
		/// Description: Store User-defined field 14
		/// FieldName: WF14
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 14")]
		public decimal? M3_WF14 => GetNullableDecimal("WF14");

		/// <summary>
		/// Description: Store User-defined field 15
		/// FieldName: WF15
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 15")]
		public DateTime? M3_WF15 => GetNullableDateTime("WF15");

		/// <summary>
		/// Description: Store User-defined field 16
		/// FieldName: WF16
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 16")]
		public DateTime? M3_WF16 => GetNullableDateTime("WF16");

		/// <summary>
		/// Description: Store User-defined field 17
		/// FieldName: WF17
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 17")]
		public int? M3_WF17 => GetNullableInt("WF17");

		/// <summary>
		/// Description: Store User-defined field 18
		/// FieldName: WF18
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 18")]
		public int? M3_WF18 => GetNullableInt("WF18");

		/// <summary>
		/// Description: Store User-defined field 19
		/// FieldName: WF19
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 19")]
		public int? M3_WF19 => GetNullableInt("WF19");

		/// <summary>
		/// Description: Store User-defined field 20
		/// FieldName: WF20
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 20")]
		public int? M3_WF20 => GetNullableInt("WF20");

		/// <summary>
		/// Description: Store User-defined field 21
		/// FieldName: WF21
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 21")]
		public int? M3_WF21 => GetNullableInt("WF21");

		/// <summary>
		/// Description: Store User-defined field 22
		/// FieldName: WF22
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Store User-defined field 22")]
		public int? M3_WF22 => GetNullableInt("WF22");

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
