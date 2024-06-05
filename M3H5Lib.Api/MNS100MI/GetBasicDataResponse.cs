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

namespace M3H5Lib.Api.MNS100MI
{
	public partial class GetBasicDataResponse : M3BaseRecord 
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
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Information line 2 - panel/report
		/// FieldName: ROW2
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information line 2 - panel/report")]
		public string M3ROW2 => GetString("ROW2");

		/// <summary>
		/// Description: Information line 3 - panel/report
		/// FieldName: ROW3
		/// FieldType: A
		/// Length: 78
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information line 3 - panel/report")]
		public string M3ROW3 => GetString("ROW3");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Facility name
		/// FieldName: FACT
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility name")]
		public string M3FACT => GetString("FACT");

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
		/// Description: Warehouse name
		/// FieldName: WHLT
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse name")]
		public string M3WHLT => GetString("WHLT");

		/// <summary>
		/// Description: Date format
		/// FieldName: DTFM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date format")]
		public string M3DTFM => GetString("DTFM");

		/// <summary>
		/// Description: Object access group
		/// FieldName: ACGR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Object access group")]
		public string M3ACGR => GetString("ACGR");

		/// <summary>
		/// Description: Local currency
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency")]
		public string M3LOCD => GetString("LOCD");

		/// <summary>
		/// Description: Local currency description
		/// FieldName: LOCT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency description")]
		public string M3LOCT => GetString("LOCT");

		/// <summary>
		/// Description: Tax method
		/// FieldName: TATM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax method")]
		public int? M3TATM => GetNullableInt("TATM");

		/// <summary>
		/// Description: Trade statistics (TST)
		/// FieldName: ISTA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trade statistics (TST)")]
		public int? M3ISTA => GetNullableInt("ISTA");

		/// <summary>
		/// Description: Right justify employee number
		/// FieldName: RAEM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Right justify employee number")]
		public int? M3RAEM => GetNullableInt("RAEM");

		/// <summary>
		/// Description: Number of periods - period type 1
		/// FieldName: NPT1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of periods - period type 1")]
		public int? M3NPT1 => GetNullableInt("NPT1");

		/// <summary>
		/// Description: Number of periods - period type 2
		/// FieldName: NPT2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of periods - period type 2")]
		public int? M3NPT2 => GetNullableInt("NPT2");

		/// <summary>
		/// Description: Number of periods - period type 3
		/// FieldName: NPT3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of periods - period type 3")]
		public int? M3NPT3 => GetNullableInt("NPT3");

		/// <summary>
		/// Description: Number of periods - period type 4
		/// FieldName: NPT4
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of periods - period type 4")]
		public int? M3NPT4 => GetNullableInt("NPT4");

		/// <summary>
		/// Description: Number of periods - period type 5
		/// FieldName: NPT5
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of periods - period type 5")]
		public int? M3NPT5 => GetNullableInt("NPT5");

		/// <summary>
		/// Description: Currency conversion method
		/// FieldName: DMCU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency conversion method")]
		public int? M3DMCU => GetNullableInt("DMCU");

		/// <summary>
		/// Description: Period type MPM
		/// FieldName: PTMP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type MPM")]
		public int? M3PTMP => GetNullableInt("PTMP");

		/// <summary>
		/// Description: Period type SLS
		/// FieldName: PTOI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type SLS")]
		public int? M3PTOI => GetNullableInt("PTOI");

		/// <summary>
		/// Description: Period type FAM
		/// FieldName: PTFA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type FAM")]
		public int? M3PTFA => GetNullableInt("PTFA");

		/// <summary>
		/// Description: Period type HRM
		/// FieldName: PTPA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type HRM")]
		public int? M3PTPA => GetNullableInt("PTPA");

		/// <summary>
		/// Description: Period type XXX
		/// FieldName: PTEI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type XXX")]
		public int? M3PTEI => GetNullableInt("PTEI");

		/// <summary>
		/// Description: VAT declaration method
		/// FieldName: VDME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT declaration method")]
		public int? M3VDME => GetNullableInt("VDME");

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3VRNO => GetString("VRNO");

		/// <summary>
		/// Description: Company address 1
		/// FieldName: COA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 1")]
		public string M3COA1 => GetString("COA1");

		/// <summary>
		/// Description: Company address 2
		/// FieldName: COA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 2")]
		public string M3COA2 => GetString("COA2");

		/// <summary>
		/// Description: Company address 3
		/// FieldName: COA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 3")]
		public string M3COA3 => GetString("COA3");

		/// <summary>
		/// Description: Company address 4
		/// FieldName: COA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company address 4")]
		public string M3COA4 => GetString("COA4");

		/// <summary>
		/// Description: Telephone number 1
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 1")]
		public string M3PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Telephone number 2
		/// FieldName: PHN2
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 2")]
		public string M3PHN2 => GetString("PHN2");

		/// <summary>
		/// Description: Telex number
		/// FieldName: TLNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telex number")]
		public string M3TLNO => GetString("TLNO");

		/// <summary>
		/// Description: Facsimile transmission number
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimile transmission number")]
		public string M3TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Our reference
		/// FieldName: OREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our reference")]
		public string M3OREF => GetString("OREF");

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
		/// Description: Country description
		/// FieldName: CSCT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country description")]
		public string M3CSCT => GetString("CSCT");

		/// <summary>
		/// Description: Time zone
		/// FieldName: TIZO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time zone")]
		public string M3TIZO => GetString("TIZO");

		/// <summary>
		/// Description: Time zone description
		/// FieldName: TIZT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time zone description")]
		public string M3TIZT => GetString("TIZT");

		/// <summary>
		/// Description: Library
		/// FieldName: LL01
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library")]
		public string M3LL01 => GetString("LL01");

		/// <summary>
		/// Description: Library
		/// FieldName: LL02
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library")]
		public string M3LL02 => GetString("LL02");

		/// <summary>
		/// Description: Library
		/// FieldName: LL03
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library")]
		public string M3LL03 => GetString("LL03");

		/// <summary>
		/// Description: Library
		/// FieldName: LL04
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library")]
		public string M3LL04 => GetString("LL04");

		/// <summary>
		/// Description: Library
		/// FieldName: LL05
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library")]
		public string M3LL05 => GetString("LL05");

		/// <summary>
		/// Description: Library
		/// FieldName: LL06
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library")]
		public string M3LL06 => GetString("LL06");

		/// <summary>
		/// Description: Library
		/// FieldName: LL07
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library")]
		public string M3LL07 => GetString("LL07");

		/// <summary>
		/// Description: Library
		/// FieldName: LL08
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library")]
		public string M3LL08 => GetString("LL08");

		/// <summary>
		/// Description: Library
		/// FieldName: LL09
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library")]
		public string M3LL09 => GetString("LL09");

		/// <summary>
		/// Description: Library
		/// FieldName: LL10
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library")]
		public string M3LL10 => GetString("LL10");

		/// <summary>
		/// Description: Library list
		/// FieldName: LLID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library list")]
		public string M3LLID => GetString("LLID");

		/// <summary>
		/// Description: Costing decimal places
		/// FieldName: CDCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing decimal places")]
		public int? M3CDCD => GetNullableInt("CDCD");

		/// <summary>
		/// Description: Registration number - Extrastat (Extra)
		/// FieldName: FIRM
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration number - Extrastat (Extra)")]
		public string M3FIRM => GetString("FIRM");

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
		/// Description: Tax declaration number
		/// FieldName: VRNL
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax declaration number")]
		public string M3VRNL => GetString("VRNL");

		/// <summary>
		/// Description: Responsible customs authority
		/// FieldName: RROF
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible customs authority")]
		public string M3RROF => GetString("RROF");

		/// <summary>
		/// Description: Separation number
		/// FieldName: UNST
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Separation number")]
		public string M3UNST => GetString("UNST");

		/// <summary>
		/// Description: Geographical code
		/// FieldName: GEOC
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographical code")]
		public long? M3GEOC => GetNullableLong("GEOC");

		/// <summary>
		/// Description: Company
		/// FieldName: CONL
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3CONL => GetNullableInt("CONL");

		/// <summary>
		/// Description: Accounts Payable installed
		/// FieldName: MXAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounts Payable installed")]
		public int? M3MXAP => GetNullableInt("MXAP");

		/// <summary>
		/// Description: Accounts Receivable installed
		/// FieldName: MXAR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounts Receivable installed")]
		public int? M3MXAR => GetNullableInt("MXAR");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXAT => GetNullableInt("MXAT");

		/// <summary>
		/// Description: Budget module installed
		/// FieldName: MXBU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget module installed")]
		public int? M3MXBU => GetNullableInt("MXBU");

		/// <summary>
		/// Description: Cost Accounting installed
		/// FieldName: MXCA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost Accounting installed")]
		public int? M3MXCA => GetNullableInt("MXCA");

		/// <summary>
		/// Description: Cash Flow installed
		/// FieldName: MXCF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash Flow installed")]
		public int? M3MXCF => GetNullableInt("MXCF");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXCP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXCP => GetNullableInt("MXCP");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXCR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXCR => GetNullableInt("MXCR");

		/// <summary>
		/// Description: Data Collection installed
		/// FieldName: MXDC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data Collection installed")]
		public int? M3MXDC => GetNullableInt("MXDC");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXDO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXDO => GetNullableInt("MXDO");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXDP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXDP => GetNullableInt("MXDP");

		/// <summary>
		/// Description: Transportation Management installed
		/// FieldName: MXDR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation Management installed")]
		public int? M3MXDR => GetNullableInt("MXDR");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXDT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXDT => GetNullableInt("MXDT");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXDS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXDS => GetNullableInt("MXDS");

		/// <summary>
		/// Description: Engineering Change Orders installed
		/// FieldName: MXEC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Engineering Change Orders installed")]
		public int? M3MXEC => GetNullableInt("MXEC");

		/// <summary>
		/// Description: EDI module installed
		/// FieldName: MXED
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EDI module installed")]
		public int? M3MXED => GetNullableInt("MXED");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXEM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXEM => GetNullableInt("MXEM");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXEP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXEP => GetNullableInt("MXEP");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXET
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXET => GetNullableInt("MXET");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXEV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXEV => GetNullableInt("MXEV");

		/// <summary>
		/// Description: Fixed Asset installed
		/// FieldName: MXFA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed Asset installed")]
		public int? M3MXFA => GetNullableInt("MXFA");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXFC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXFC => GetNullableInt("MXFC");

		/// <summary>
		/// Description: General Ledger installed
		/// FieldName: MXGL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("General Ledger installed")]
		public int? M3MXGL => GetNullableInt("MXGL");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXGM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXGM => GetNullableInt("MXGM");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXIC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXIC => GetNullableInt("MXIC");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXIP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXIP => GetNullableInt("MXIP");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXJO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXJO => GetNullableInt("MXJO");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXJQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXJQ => GetNullableInt("MXJQ");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXLI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXLI => GetNullableInt("MXLI");

		/// <summary>
		/// Description: Sales and Marketing system installed
		/// FieldName: MXMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales and Marketing system installed")]
		public int? M3MXMA => GetNullableInt("MXMA");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXMC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXMC => GetNullableInt("MXMC");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXMD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXMD => GetNullableInt("MXMD");

		/// <summary>
		/// Description: Multi-Unit Coordination installed
		/// FieldName: MXMF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multi-Unit Coordination installed")]
		public int? M3MXMF => GetNullableInt("MXMF");

		/// <summary>
		/// Description: Maintenance integration installed
		/// FieldName: MXMI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maintenance integration installed")]
		public int? M3MXMI => GetNullableInt("MXMI");

		/// <summary>
		/// Description: Stock transacttions used
		/// FieldName: MXMM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock transacttions used")]
		public int? M3MXMM => GetNullableInt("MXMM");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXMN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXMN => GetNullableInt("MXMN");

		/// <summary>
		/// Description: Maintenance order installed
		/// FieldName: MXMO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maintenance order installed")]
		public int? M3MXMO => GetNullableInt("MXMO");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXMP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXMP => GetNullableInt("MXMP");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXMQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXMQ => GetNullableInt("MXMQ");

		/// <summary>
		/// Description: Material data safety sheet installed
		/// FieldName: MXMS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material data safety sheet installed")]
		public int? M3MXMS => GetNullableInt("MXMS");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXOC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXOC => GetNullableInt("MXOC");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXOD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXOD => GetNullableInt("MXOD");

		/// <summary>
		/// Description: Customer Order module installed
		/// FieldName: MXOI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer Order module installed")]
		public int? M3MXOI => GetNullableInt("MXOI");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXOQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXOQ => GetNullableInt("MXOQ");

		/// <summary>
		/// Description: Sales Statistics and Performance install
		/// FieldName: MXOS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales Statistics and Performance install")]
		public int? M3MXOS => GetNullableInt("MXOS");

		/// <summary>
		/// Description: Human Resoursing installed
		/// FieldName: MXPA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Human Resoursing installed")]
		public int? M3MXPA => GetNullableInt("MXPA");

		/// <summary>
		/// Description: Product Costing installed
		/// FieldName: MXPC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product Costing installed")]
		public int? M3MXPC => GetNullableInt("MXPC");

		/// <summary>
		/// Description: Product Data installed
		/// FieldName: MXPD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product Data installed")]
		public int? M3MXPD => GetNullableInt("MXPD");

		/// <summary>
		/// Description: Manufacturing Order installed
		/// FieldName: MXPM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing Order installed")]
		public int? M3MXPM => GetNullableInt("MXPM");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXPO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXPO => GetNullableInt("MXPO");

		/// <summary>
		/// Description: Purchase Order installed
		/// FieldName: MXPP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase Order installed")]
		public int? M3MXPP => GetNullableInt("MXPP");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXPQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXPQ => GetNullableInt("MXPQ");

		/// <summary>
		/// Description: Payroll and Benefits installed
		/// FieldName: MXPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payroll and Benefits installed")]
		public int? M3MXPR => GetNullableInt("MXPR");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXPS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXPS => GetNullableInt("MXPS");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXQP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXQP => GetNullableInt("MXQP");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXRC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXRC => GetNullableInt("MXRC");

		/// <summary>
		/// Description: Report Generator installed
		/// FieldName: MXRG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Report Generator installed")]
		public int? M3MXRG => GetNullableInt("MXRG");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXRM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXRM => GetNullableInt("MXRM");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXRP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXRP => GetNullableInt("MXRP");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXRR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXRR => GetNullableInt("MXRR");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXRS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXRS => GetNullableInt("MXRS");

		/// <summary>
		/// Description: Short-term Rental Agreements installed
		/// FieldName: MXSA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Short-term Rental Agreements installed")]
		public int? M3MXSA => GetNullableInt("MXSA");

		/// <summary>
		/// Description: Long-term Rental Agreements installed
		/// FieldName: MXSB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Long-term Rental Agreements installed")]
		public int? M3MXSB => GetNullableInt("MXSB");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXSE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXSE => GetNullableInt("MXSE");

		/// <summary>
		/// Description: Service Order installed
		/// FieldName: MXSO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service Order installed")]
		public int? M3MXSO => GetNullableInt("MXSO");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXSP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXSP => GetNullableInt("MXSP");

		/// <summary>
		/// Description: Time Accounting installed
		/// FieldName: MXTA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time Accounting installed")]
		public int? M3MXTA => GetNullableInt("MXTA");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXTE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXTE => GetNullableInt("MXTE");

		/// <summary>
		/// Description: Time and Attendance installed
		/// FieldName: MXTM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time and Attendance installed")]
		public int? M3MXTM => GetNullableInt("MXTM");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXTP => GetNullableInt("MXTP");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXWO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXWO => GetNullableInt("MXWO");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXWP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXWP => GetNullableInt("MXWP");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXWT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXWT => GetNullableInt("MXWT");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXST => GetNullableInt("MXST");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXLT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXLT => GetNullableInt("MXLT");

		/// <summary>
		/// Description: Industry application 1
		/// FieldName: MXV1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Industry application 1")]
		public string M3MXV1 => GetString("MXV1");

		/// <summary>
		/// Description: Industry application 1
		/// FieldName: MXV2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Industry application 1")]
		public string M3MXV2 => GetString("MXV2");

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
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Decimal format
		/// FieldName: DCFM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimal format")]
		public string M3DCFM => GetString("DCFM");

		/// <summary>
		/// Description: Ref field for quantity¤ alpha
		/// FieldName: MXAH
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for quantity¤ alpha")]
		public string M3MXAH => GetString("MXAH");

		/// <summary>
		/// Description: Ref field for quantity¤ alpha
		/// FieldName: MXAM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for quantity¤ alpha")]
		public string M3MXAM => GetString("MXAM");

		/// <summary>
		/// Description: Module installed
		/// FieldName: MXQM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Module installed")]
		public int? M3MXQM => GetNullableInt("MXQM");

		/// <summary>
		/// Description: Reporting manager
		/// FieldName: RMAN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting manager")]
		public int? M3RMAN => GetNullableInt("RMAN");

		/// <summary>
		/// Description: 212 Eco Contribution
		/// FieldName: ECOE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("212 Eco Contribution")]
		public int? M3ECOE => GetNullableInt("ECOE");

		/// <summary>
		/// Description: Organization number 1
		/// FieldName: CORG
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organization number 1")]
		public string M3CORG => GetString("CORG");

		/// <summary>
		/// Description: Organization number 2
		/// FieldName: COR2
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organization number 2")]
		public string M3COR2 => GetString("COR2");

		/// <summary>
		/// Description: EAN location code
		/// FieldName: EALO
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EAN location code")]
		public decimal? M3EALO => GetNullableDecimal("EALO");

		/// <summary>
		/// Description: Standard point location code
		/// FieldName: SPLE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard point location code")]
		public string M3SPLE => GetString("SPLE");

		/// <summary>
		/// Description: Country version
		/// FieldName: CSVN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country version")]
		public string M3CSVN => GetString("CSVN");
	}
}
// EOF
