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

namespace M3H5Lib.Api.LTS100MI
{
	public partial class LstLTRByCustResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Agreement customer
		/// FieldName: AGCN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement customer")]
		public string M3_AGCN => GetString("AGCN");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AGNB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3_AGNB => GetString("AGNB");

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
		/// Description: Status
		/// FieldName: HILO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_HILO => GetString("HILO");
	}
}
// EOF