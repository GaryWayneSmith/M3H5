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

namespace M3H5Lib.Api.PDS600MI
{
	public partial class QuestRequestResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: 1=Feat 2=Draw 3=End Quest 4=Itno 5=Qty
		/// FieldName: QTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("1=Feat 2=Draw 3=End Quest 4=Itno 5=Qty")]
		public string M3QTYP => GetString("QTYP");

		/// <summary>
		/// Description: Configurator ID (Feature/Draw/Matrix)
		/// FieldName: CFID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configurator ID (Feature/Draw/Matrix)")]
		public string M3CFID => GetString("CFID");

		/// <summary>
		/// Description: Default, must or chosen value
		/// FieldName: OPTN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default, must or chosen value")]
		public string M3OPTN => GetString("OPTN");

		/// <summary>
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Open measurement/item matrix/qty matrix
		/// FieldName: NCLN
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Open measurement/item matrix/qty matrix")]
		public string M3NCLN => GetString("NCLN");

		/// <summary>
		/// Description: Unit om measurement
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit om measurement")]
		public string M3UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Measurement value
		/// FieldName: MEVA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement value")]
		public string M3MEVA => GetString("MEVA");

		/// <summary>
		/// Description: Question from product configurator
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Question from product configurator")]
		public string M3TX30 => GetString("TX30");

		/// <summary>
		/// Description: Chosen quantity for not closed matrix
		/// FieldName: CNQT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Chosen quantity for not closed matrix")]
		public string M3CNQT => GetString("CNQT");

		/// <summary>
		/// Description: Explanatory
		/// FieldName: TX75
		/// FieldType: A
		/// Length: 75
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Explanatory")]
		public string M3TX75 => GetString("TX75");

		/// <summary>
		/// Description: New question sequence
		/// FieldName: COLI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New question sequence")]
		public string M3COLI => GetString("COLI");

		/// <summary>
		/// Description: Option description
		/// FieldName: OPDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option description")]
		public string M3OPDS => GetString("OPDS");
	}
}
// EOF
