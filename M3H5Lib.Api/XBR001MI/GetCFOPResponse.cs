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

namespace M3H5Lib.Api.XBR001MI
{
	public partial class GetCFOPResponse : M3BaseRecord 
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
		/// Description: Internal CFOP Code
		/// FieldName: ICFO
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal CFOP Code")]
		public string M3_ICFO => GetString("ICFO");

		/// <summary>
		/// Description: CFOP
		/// FieldName: CFOP
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CFOP")]
		public string M3_CFOP => GetString("CFOP");

		/// <summary>
		/// Description: Text
		/// FieldName: TEXT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TEXT => GetString("TEXT");

		/// <summary>
		/// Description: Text
		/// FieldName: TEX1
		/// FieldType: A
		/// Length: 70
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TEX1 => GetString("TEX1");

		/// <summary>
		/// Description: Text
		/// FieldName: TEX2
		/// FieldType: A
		/// Length: 70
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TEX2 => GetString("TEX2");

		/// <summary>
		/// Description: Text
		/// FieldName: TEX3
		/// FieldType: A
		/// Length: 70
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TEX3 => GetString("TEX3");

		/// <summary>
		/// Description: Text
		/// FieldName: TEX4
		/// FieldType: A
		/// Length: 70
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TEX4 => GetString("TEX4");

		/// <summary>
		/// Description: Freight Invoice
		/// FieldName: FINV
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight Invoice")]
		public string M3_FINV => GetString("FINV");

		/// <summary>
		/// Description: Service Invoice
		/// FieldName: SINV
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service Invoice")]
		public string M3_SINV => GetString("SINV");

		/// <summary>
		/// Description: Service Code
		/// FieldName: SERV
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service Code")]
		public string M3_SERV => GetString("SERV");

		/// <summary>
		/// Description: % ISS
		/// FieldName: CISS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% ISS")]
		public int? M3_CISS => GetNullableInt("CISS");

		/// <summary>
		/// Description: Calculates IPI
		/// FieldName: XCIP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculates IPI")]
		public string M3_XCIP => GetString("XCIP");

		/// <summary>
		/// Description: Calculates ICMS
		/// FieldName: CICM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculates ICMS")]
		public int? M3_CICM => GetNullableInt("CICM");

		/// <summary>
		/// Description: % ICMS
		/// FieldName: ICMS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% ICMS")]
		public int? M3_ICMS => GetNullableInt("ICMS");

		/// <summary>
		/// Description: % Repasse discount
		/// FieldName: RDIS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Repasse discount")]
		public int? M3_RDIS => GetNullableInt("RDIS");

		/// <summary>
		/// Description: PIS from Item
		/// FieldName: CPIS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS from Item")]
		public string M3_CPIS => GetString("CPIS");

		/// <summary>
		/// Description: COFINS from Item
		/// FieldName: XCCO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS from Item")]
		public string M3_XCCO => GetString("XCCO");

		/// <summary>
		/// Description: IPI Credit at Goods receipt
		/// FieldName: GIPI
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IPI Credit at Goods receipt")]
		public string M3_GIPI => GetString("GIPI");

		/// <summary>
		/// Description: ICMS Credit at Goods receipt
		/// FieldName: GICM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS Credit at Goods receipt")]
		public string M3_GICM => GetString("GICM");

		/// <summary>
		/// Description: PIS Credit at Goods receipt
		/// FieldName: GPIS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS Credit at Goods receipt")]
		public string M3_GPIS => GetString("GPIS");

		/// <summary>
		/// Description: COFINS Credit at Goods receipt
		/// FieldName: GCOF
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS Credit at Goods receipt")]
		public string M3_GCOF => GetString("GCOF");

		/// <summary>
		/// Description: Gen Acc Payable
		/// FieldName: GEAP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gen Acc Payable")]
		public string M3_GEAP => GetString("GEAP");

		/// <summary>
		/// Description: Gen Acc Receiv
		/// FieldName: GEAR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gen Acc Receiv")]
		public string M3_GEAR => GetString("GEAR");

		/// <summary>
		/// Description: % Red. base IPI
		/// FieldName: RIPI
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Red. base IPI")]
		public int? M3_RIPI => GetNullableInt("RIPI");

		/// <summary>
		/// Description: % Red. base ICMS
		/// FieldName: RICM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Red. base ICMS")]
		public int? M3_RICM => GetNullableInt("RICM");

		/// <summary>
		/// Description: % Ret PIS
		/// FieldName: RPIS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Ret PIS")]
		public int? M3_RPIS => GetNullableInt("RPIS");

		/// <summary>
		/// Description: % Ret COFINS
		/// FieldName: RCOF
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% Ret COFINS")]
		public int? M3_RCOF => GetNullableInt("RCOF");

		/// <summary>
		/// Description: ICMS tribute code
		/// FieldName: TICM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS tribute code")]
		public string M3_TICM => GetString("TICM");

		/// <summary>
		/// Description: Fiscal code
		/// FieldName: XFIS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fiscal code")]
		public string M3_XFIS => GetString("XFIS");

		/// <summary>
		/// Description: SUFRAMA
		/// FieldName: XURF
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SUFRAMA")]
		public string M3_XURF => GetString("XURF");

		/// <summary>
		/// Description: Cv ICMS 24/2001
		/// FieldName: OICM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cv ICMS 24/2001")]
		public string M3_OICM => GetString("OICM");

		/// <summary>
		/// Description: PIS retained
		/// FieldName: PISR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS retained")]
		public string M3_PISR => GetString("PISR");

		/// <summary>
		/// Description: COFINS retained
		/// FieldName: COFR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS retained")]
		public string M3_COFR => GetString("COFR");

		/// <summary>
		/// Description: CSLL retained
		/// FieldName: CSLR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CSLL retained")]
		public string M3_CSLR => GetString("CSLR");

		/// <summary>
		/// Description: ISS retained
		/// FieldName: ISSR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ISS retained")]
		public string M3_ISSR => GetString("ISSR");

		/// <summary>
		/// Description: PIS import
		/// FieldName: IPIS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS import")]
		public string M3_IPIS => GetString("IPIS");

		/// <summary>
		/// Description: COFINS import
		/// FieldName: XICO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS import")]
		public string M3_XICO => GetString("XICO");

		/// <summary>
		/// Description: % PIS
		/// FieldName: XPI1
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% PIS")]
		public string M3_XPI1 => GetString("XPI1");

		/// <summary>
		/// Description: % COFINS
		/// FieldName: COFI
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% COFINS")]
		public int? M3_COFI => GetNullableInt("COFI");

		/// <summary>
		/// Description: Cred sub trib
		/// FieldName: GSUB
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cred sub trib")]
		public string M3_GSUB => GetString("GSUB");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: IPI Tributation Code
		/// FieldName: TIPI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IPI Tributation Code")]
		public string M3_TIPI => GetString("TIPI");

		/// <summary>
		/// Description: PIS Tributation Code
		/// FieldName: TPIS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS Tributation Code")]
		public string M3_TPIS => GetString("TPIS");

		/// <summary>
		/// Description: % COFINS
		/// FieldName: TCOF
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% COFINS")]
		public int? M3_TCOF => GetNullableInt("TCOF");

		/// <summary>
		/// Description: ISSQN tributation code
		/// FieldName: ISSC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ISSQN tributation code")]
		public string M3_ISSC => GetString("ISSC");
	}
}
// EOF
