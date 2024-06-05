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

namespace M3H5Lib.Api.OIS100MI
{
	public partial class GetLineChrgResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3_ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Debit frequency
		/// FieldName: HACD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit frequency")]
		public int? M3_HACD => GetNullableInt("HACD");

		/// <summary>
		/// Description: Description language 0
		/// FieldName: CRD0
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description language 0")]
		public string M3_CRD0 => GetString("CRD0");

		/// <summary>
		/// Description: Charge
		/// FieldName: CRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge")]
		public decimal? M3_CRAM => GetNullableDecimal("CRAM");

		/// <summary>
		/// Description: Calculation method
		/// FieldName: CRME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation method")]
		public int? M3_CRME => GetNullableInt("CRME");

		/// <summary>
		/// Description: Calculation factor
		/// FieldName: CRFA
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation factor")]
		public decimal? M3_CRFA => GetNullableDecimal("CRFA");

		/// <summary>
		/// Description: Charge U/M
		/// FieldName: CHUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge U/M")]
		public string M3_CHUN => GetString("CHUN");

		/// <summary>
		/// Description: Charge quantity
		/// FieldName: CHPD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge quantity")]
		public int? M3_CHPD => GetNullableInt("CHPD");

		/// <summary>
		/// Description: Decimals places - charge base
		/// FieldName: CHDC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimals places - charge base")]
		public int? M3_CHDC => GetNullableInt("CHDC");

		/// <summary>
		/// Description: Bonus group
		/// FieldName: BGRP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus group")]
		public string M3_BGRP => GetString("BGRP");

		/// <summary>
		/// Description: Commission group
		/// FieldName: PRVG
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commission group")]
		public string M3_PRVG => GetString("PRVG");

		/// <summary>
		/// Description: Bonus generating
		/// FieldName: BOGR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus generating")]
		public int? M3_BOGR => GetNullableInt("BOGR");

		/// <summary>
		/// Description: Commission generating
		/// FieldName: PRGR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commission generating")]
		public int? M3_PRGR => GetNullableInt("PRGR");

		/// <summary>
		/// Description: Presentation code - item charges
		/// FieldName: CHPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Presentation code - item charges")]
		public int? M3_CHPR => GetNullableInt("CHPR");

		/// <summary>
		/// Description: Included in cost total 1
		/// FieldName: CRN1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 1")]
		public int? M3_CRN1 => GetNullableInt("CRN1");

		/// <summary>
		/// Description: Included in cost total 2
		/// FieldName: CRN2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 2")]
		public int? M3_CRN2 => GetNullableInt("CRN2");

		/// <summary>
		/// Description: Included in cost total 3
		/// FieldName: CRN3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 3")]
		public int? M3_CRN3 => GetNullableInt("CRN3");

		/// <summary>
		/// Description: Included in cost total 4
		/// FieldName: CRN4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 4")]
		public int? M3_CRN4 => GetNullableInt("CRN4");

		/// <summary>
		/// Description: Included in cost total 5
		/// FieldName: CRN5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in cost total 5")]
		public int? M3_CRN5 => GetNullableInt("CRN5");

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public int? M3_VTCD => GetNullableInt("VTCD");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3_CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Status - charge
		/// FieldName: CHST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - charge")]
		public string M3_CHST => GetString("CHST");

		/// <summary>
		/// Description: Pricing code for item charges
		/// FieldName: CHPM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pricing code for item charges")]
		public string M3_CHPM => GetString("CHPM");

		/// <summary>
		/// Description: Tax code customer/address
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code customer/address")]
		public string M3_TAXC => GetString("TAXC");

		/// <summary>
		/// Description: Item dependent sales tax
		/// FieldName: TAXI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item dependent sales tax")]
		public int? M3_TAXI => GetNullableInt("TAXI");
	}
}
// EOF
