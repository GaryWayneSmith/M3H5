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

namespace M3H5Lib.Api.GTCN10MI
{
	public partial class GetBatchHeadResponse : M3BaseRecord 
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
		/// Description: Batch number 10 pos
		/// FieldName: BA10
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Batch number 10 pos")]
		public long? M3BA10 => GetNullableLong("BA10");

		/// <summary>
		/// Description: Type of transfer
		/// FieldName: XTTF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of transfer")]
		public int? M3XTTF => GetNullableInt("XTTF");

		/// <summary>
		/// Description: Transfer date
		/// FieldName: TRDE
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer date")]
		public DateTime? M3TRDE => GetNullableDateTime("TRDE");

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
		/// Description: Transfer status
		/// FieldName: XTST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer status")]
		public int? M3XTST => GetNullableInt("XTST");

		/// <summary>
		/// Description: Header - text file
		/// FieldName: XHTX
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Header - text file")]
		public string M3XHTX => GetString("XHTX");

		/// <summary>
		/// Description: Company information 1
		/// FieldName: XCI1
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company information 1")]
		public string M3XCI1 => GetString("XCI1");

		/// <summary>
		/// Description: Company information 2
		/// FieldName: XCI2
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company information 2")]
		public string M3XCI2 => GetString("XCI2");

		/// <summary>
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3ADID => GetString("ADID");
	}
}
// EOF
