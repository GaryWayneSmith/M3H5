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

namespace M3H5Lib.Api.CRS175MI
{
	public partial class GetSetTradeStatResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: INTRASTAT generating
		/// FieldName: INYN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("INTRASTAT generating")]
		public int? M3INYN => GetNullableInt("INYN");

		/// <summary>
		/// Description: INTRASTAT generation for other countries
		/// FieldName: INYO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("INTRASTAT generation for other countries")]
		public int? M3INYO => GetNullableInt("INYO");

		/// <summary>
		/// Description: EU exemption text 1
		/// FieldName: ECE1
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EU exemption text 1")]
		public string M3ECE1 => GetString("ECE1");

		/// <summary>
		/// Description: EU exemption text 2
		/// FieldName: ECE2
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EU exemption text 2")]
		public string M3ECE2 => GetString("ECE2");

		/// <summary>
		/// Description: Business type - trade statistics (TST)
		/// FieldName: VRCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business type - trade statistics (TST)")]
		public string M3VRCD => GetString("VRCD");

		/// <summary>
		/// Description: Sender location
		/// FieldName: PSND
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sender location")]
		public string M3PSND => GetString("PSND");

		/// <summary>
		/// Description: Receiver location
		/// FieldName: PRCV
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiver location")]
		public string M3PRCV => GetString("PRCV");

		/// <summary>
		/// Description: Receiving material number - INTRASTAT
		/// FieldName: MNRI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving material number - INTRASTAT")]
		public string M3MNRI => GetString("MNRI");

		/// <summary>
		/// Description: Sending material number - INTRASTAT
		/// FieldName: MNSI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sending material number - INTRASTAT")]
		public string M3MNSI => GetString("MNSI");

		/// <summary>
		/// Description: Receiving material number - EXTRASTAT
		/// FieldName: MNRE
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving material number - EXTRASTAT")]
		public string M3MNRE => GetString("MNRE");

		/// <summary>
		/// Description: Sending material number - EXTRASTAT
		/// FieldName: MNSE
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sending material number - EXTRASTAT")]
		public string M3MNSE => GetString("MNSE");

		/// <summary>
		/// Description: INTRASTAT level
		/// FieldName: INLV
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("INTRASTAT level")]
		public string M3INLV => GetString("INLV");

		/// <summary>
		/// Description: Business type for import - DO
		/// FieldName: VRC1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business type for import - DO")]
		public string M3VRC1 => GetString("VRC1");

		/// <summary>
		/// Description: Labor code - import DO
		/// FieldName: ECL1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor code - import DO")]
		public string M3ECL1 => GetString("ECL1");

		/// <summary>
		/// Description: Business type for export - DO
		/// FieldName: VRC2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business type for export - DO")]
		public string M3VRC2 => GetString("VRC2");

		/// <summary>
		/// Description: Labor code export - DO
		/// FieldName: ECL2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor code export - DO")]
		public string M3ECL2 => GetString("ECL2");

		/// <summary>
		/// Description: Triangular trade value
		/// FieldName: CUVL
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Triangular trade value")]
		public string M3CUVL => GetString("CUVL");

		/// <summary>
		/// Description: Business type for customer return
		/// FieldName: VRC0
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business type for customer return")]
		public string M3VRC0 => GetString("VRC0");

		/// <summary>
		/// Description: Labor code customer return
		/// FieldName: ECL0
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor code customer return")]
		public string M3ECL0 => GetString("ECL0");

		/// <summary>
		/// Description: Exchange rate type
		/// FieldName: CRTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public int? M3CRTP => GetNullableInt("CRTP");

		/// <summary>
		/// Description: 10 MUC divisions in the same country
		/// FieldName: TR10
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("10 MUC divisions in the same country")]
		public string M3TR10 => GetString("TR10");

		/// <summary>
		/// Description: 20 MUC selling division = customer
		/// FieldName: TR20
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("20 MUC selling division = customer")]
		public string M3TR20 => GetString("TR20");

		/// <summary>
		/// Description: 30 MUC divs and customer in 3 countries
		/// FieldName: TR30
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("30 MUC divs and customer in 3 countries")]
		public string M3TR30 => GetString("TR30");

		/// <summary>
		/// Description: 40 MUC warehouse = customer
		/// FieldName: TR40
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("40 MUC warehouse = customer")]
		public string M3TR40 => GetString("TR40");

		/// <summary>
		/// Description: 50 MUC not used
		/// FieldName: TR50
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("50 MUC not used")]
		public string M3TR50 => GetString("TR50");

		/// <summary>
		/// Description: Bank format
		/// FieldName: BNKF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank format")]
		public string M3BNKF => GetString("BNKF");
	}
}
// EOF
