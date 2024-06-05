/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MMS200MI;
using M3H5Lib.Extensions;
using M3H5Lib.Models;
using ExtensibleHttp.Payload;
using ExtensibleHttp;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace M3H5Lib.Api
{

	/// <summary>
	/// Name: MMS200MI
	/// Component Name: ItemToolbox
	/// Description: Item toolbox interface
	/// Version Release: 5eaB
	///</summary>
	public partial class MMS200MIResource : M3BaseResourceEndpoint
	{
		public MMS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItmBasic
		/// Description Add Item Basic
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ITDS">Name (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3UNMS">Basic unit of measure (Required)</param>
		/// <param name="m3ITTY">Item type (Required)</param>
		/// <param name="m3MABU">Make/buy code (Required)</param>
		/// <param name="m3PRVG">Commission group (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3BUAR">Business area</param>
		/// <param name="m3TPCD">Item category</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3BACD">Lot numbering method</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3BYPR">By/co-product code</param>
		/// <param name="m3WAPC">Normal waste percentage</param>
		/// <param name="m3QACD">Inspection code</param>
		/// <param name="m3EPCD">Yield calculation</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3ACTI">Active or catch weight item</param>
		/// <param name="m3HIE1">Hierachy level 1</param>
		/// <param name="m3HIE2">Hierachy level 2</param>
		/// <param name="m3HIE3">Hierachy level 3</param>
		/// <param name="m3HIE4">Hierachy level 4</param>
		/// <param name="m3HIE5">Hierachy level 5</param>
		/// <param name="m3GRP1">Search group 1</param>
		/// <param name="m3GRP2">Search group 2</param>
		/// <param name="m3GRP3">Search group 3</param>
		/// <param name="m3GRP4">Search group 4</param>
		/// <param name="m3GRP5">Search group 5</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3ECMA">ECO managed</param>
		/// <param name="m3PRGP">Procurement group</param>
		/// <param name="m3INDI">Lot control method</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3ALUC">Alternate U/M in use</param>
		/// <param name="m3IEAA">Item exists as alias identity</param>
		/// <param name="m3EXPD">Expiration date method</param>
		/// <param name="m3GRMT">Goods receiving method</param>
		/// <param name="m3HAZI">Danger indicator</param>
		/// <param name="m3SALE">Sales item</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="m3ATMN">Attribute managed</param>
		/// <param name="m3TPLI">Template item number</param>
		/// <param name="m3FCU1">Estimated consumption free capacity unit</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3IACP">Attribute-controlled item</param>
		/// <param name="m3HDPR">Main product</param>
		/// <param name="m3AAD0">Extended QA used</param>
		/// <param name="m3AAD1">Generate txt from text template</param>
		/// <param name="m3CHCL">Charge calculation</param>
		/// <param name="m3ITRC">Individual item tracing</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3GRTI">Group technology class</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3PDCC">Number of price decimal places</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3EVGR">Envirenment group</param>
		/// <param name="m3GRTS">Distribution group technology</param>
		/// <param name="m3ETRF">External instruction</param>
		/// <param name="m3CAWP">Catch weight mode</param>
		/// <param name="m3CWUN">Catch weight unit of measure</param>
		/// <param name="m3CPUN">Standard cost price unit of measure</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3ACMC">Compatibility code</param>
		/// <param name="m3ITRU">Included in territorial roll-up</param>
		/// <param name="m3TECR">Core terms</param>
		/// <param name="m3EXCA">Exchangeable</param>
		/// <param name="m3ACCG">Acceptance group</param>
		/// <param name="m3CCCM">Costing model - core charge</param>
		/// <param name="m3CCI1">Core charge item number</param>
		/// <param name="m3CRI1">Core remain item number</param>
		/// <param name="m3HVMT">Harvest Method</param>
		/// <param name="m3ITNE">Extended item number</param>
		/// <param name="m3SPGV">Specific gravity</param>
		/// <param name="m3AUTC">Issue message</param>
		/// <param name="m3RIDE">Reference identity</param>
		/// <param name="m3RIDC">Reference identity code</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3SAFC">Suppliers ABC code</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3PDLN">Product line</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3SUME">Sublot method</param>
		/// <param name="m3SUMP">Sublot policy</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmBasic(
			string m3STAT, 
			string m3ITNO, 
			string m3ITDS, 
			string m3RESP, 
			string m3UNMS, 
			string m3ITTY, 
			int m3MABU, 
			string m3PRVG, 
			int? m3CONO = null, 
			string m3FUDS = null, 
			string m3DWNO = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3BUAR = null, 
			int? m3TPCD = null, 
			int? m3CHCD = null, 
			int? m3STCD = null, 
			int? m3BACD = null, 
			decimal? m3VOL3 = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			int? m3BYPR = null, 
			int? m3WAPC = null, 
			int? m3QACD = null, 
			int? m3EPCD = null, 
			int? m3POCY = null, 
			int? m3ACTI = null, 
			string m3HIE1 = null, 
			string m3HIE2 = null, 
			string m3HIE3 = null, 
			string m3HIE4 = null, 
			string m3HIE5 = null, 
			string m3GRP1 = null, 
			string m3GRP2 = null, 
			string m3GRP3 = null, 
			string m3GRP4 = null, 
			string m3GRP5 = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			decimal? m3TXID = null, 
			int? m3ECMA = null, 
			string m3PRGP = null, 
			int? m3INDI = null, 
			string m3PUUN = null, 
			int? m3ALUC = null, 
			int? m3IEAA = null, 
			int? m3EXPD = null, 
			string m3GRMT = null, 
			int? m3HAZI = null, 
			int? m3SALE = null, 
			string m3TAXC = null, 
			string m3ATMO = null, 
			int? m3ATMN = null, 
			string m3TPLI = null, 
			decimal? m3FCU1 = null, 
			string m3ALUN = null, 
			int? m3IACP = null, 
			string m3HDPR = null, 
			int? m3AAD0 = null, 
			int? m3AAD1 = null, 
			int? m3CHCL = null, 
			int? m3ITRC = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			string m3ECVE = null, 
			string m3GRTI = null, 
			int? m3DCCD = null, 
			int? m3PDCC = null, 
			string m3ACRF = null, 
			string m3EVGR = null, 
			string m3GRTS = null, 
			string m3ETRF = null, 
			int? m3CAWP = null, 
			string m3CWUN = null, 
			string m3CPUN = null, 
			string m3MOTP = null, 
			string m3ACMC = null, 
			int? m3ITRU = null, 
			string m3TECR = null, 
			int? m3EXCA = null, 
			string m3ACCG = null, 
			string m3CCCM = null, 
			string m3CCI1 = null, 
			string m3CRI1 = null, 
			int? m3HVMT = null, 
			string m3ITNE = null, 
			decimal? m3SPGV = null, 
			int? m3AUTC = null, 
			string m3RIDE = null, 
			int? m3RIDC = null, 
			int? m3RNRI = null, 
			string m3SAFC = null, 
			int? m3RMSG = null, 
			string m3PDLN = null, 
			string m3CPGR = null, 
			int? m3SUME = null, 
			string m3SUMP = null, 
			string m3QMGP = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItmBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3ITDS))
				throw new ArgumentNullException(nameof(m3ITDS));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));
			if (string.IsNullOrWhiteSpace(m3UNMS))
				throw new ArgumentNullException(nameof(m3UNMS));
			if (string.IsNullOrWhiteSpace(m3ITTY))
				throw new ArgumentNullException(nameof(m3ITTY));
			if (string.IsNullOrWhiteSpace(m3PRVG))
				throw new ArgumentNullException(nameof(m3PRVG));

			// Set mandatory parameters
			request
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ITDS", m3ITDS.Trim())
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("UNMS", m3UNMS.Trim())
				.WithQueryParameter("ITTY", m3ITTY.Trim())
				.WithQueryParameter("MABU", m3MABU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PRVG", m3PRVG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUAR))
				request.WithQueryParameter("BUAR", m3BUAR.Trim());
			if (m3TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3TPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACD.HasValue)
				request.WithQueryParameter("BACD", m3BACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3BYPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3WAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QACD.HasValue)
				request.WithQueryParameter("QACD", m3QACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EPCD.HasValue)
				request.WithQueryParameter("EPCD", m3EPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3ACTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HIE1))
				request.WithQueryParameter("HIE1", m3HIE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE2))
				request.WithQueryParameter("HIE2", m3HIE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE3))
				request.WithQueryParameter("HIE3", m3HIE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE4))
				request.WithQueryParameter("HIE4", m3HIE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE5))
				request.WithQueryParameter("HIE5", m3HIE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP1))
				request.WithQueryParameter("GRP1", m3GRP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP2))
				request.WithQueryParameter("GRP2", m3GRP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP3))
				request.WithQueryParameter("GRP3", m3GRP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP4))
				request.WithQueryParameter("GRP4", m3GRP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP5))
				request.WithQueryParameter("GRP5", m3GRP5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI1))
				request.WithQueryParameter("CFI1", m3CFI1.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI4))
				request.WithQueryParameter("CFI4", m3CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI5))
				request.WithQueryParameter("CFI5", m3CFI5.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3ECMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRGP))
				request.WithQueryParameter("PRGP", m3PRGP.Trim());
			if (m3INDI.HasValue)
				request.WithQueryParameter("INDI", m3INDI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (m3ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3ALUC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IEAA.HasValue)
				request.WithQueryParameter("IEAA", m3IEAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3EXPD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (m3HAZI.HasValue)
				request.WithQueryParameter("HAZI", m3HAZI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SALE.HasValue)
				request.WithQueryParameter("SALE", m3SALE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());
			if (m3ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3ATMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TPLI))
				request.WithQueryParameter("TPLI", m3TPLI.Trim());
			if (m3FCU1.HasValue)
				request.WithQueryParameter("FCU1", m3FCU1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3IACP.HasValue)
				request.WithQueryParameter("IACP", m3IACP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HDPR))
				request.WithQueryParameter("HDPR", m3HDPR.Trim());
			if (m3AAD0.HasValue)
				request.WithQueryParameter("AAD0", m3AAD0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AAD1.HasValue)
				request.WithQueryParameter("AAD1", m3AAD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHCL.HasValue)
				request.WithQueryParameter("CHCL", m3CHCL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITRC.HasValue)
				request.WithQueryParameter("ITRC", m3ITRC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTI))
				request.WithQueryParameter("GRTI", m3GRTI.Trim());
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PDCC.HasValue)
				request.WithQueryParameter("PDCC", m3PDCC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVGR))
				request.WithQueryParameter("EVGR", m3EVGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTS))
				request.WithQueryParameter("GRTS", m3GRTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETRF))
				request.WithQueryParameter("ETRF", m3ETRF.Trim());
			if (m3CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3CAWP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CWUN))
				request.WithQueryParameter("CWUN", m3CWUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPUN))
				request.WithQueryParameter("CPUN", m3CPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACMC))
				request.WithQueryParameter("ACMC", m3ACMC.Trim());
			if (m3ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3ITRU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECR))
				request.WithQueryParameter("TECR", m3TECR.Trim());
			if (m3EXCA.HasValue)
				request.WithQueryParameter("EXCA", m3EXCA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACCG))
				request.WithQueryParameter("ACCG", m3ACCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCCM))
				request.WithQueryParameter("CCCM", m3CCCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCI1))
				request.WithQueryParameter("CCI1", m3CCI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRI1))
				request.WithQueryParameter("CRI1", m3CRI1.Trim());
			if (m3HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3HVMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNE))
				request.WithQueryParameter("ITNE", m3ITNE.Trim());
			if (m3SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3SPGV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUTC.HasValue)
				request.WithQueryParameter("AUTC", m3AUTC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDE))
				request.WithQueryParameter("RIDE", m3RIDE.Trim());
			if (m3RIDC.HasValue)
				request.WithQueryParameter("RIDC", m3RIDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SAFC))
				request.WithQueryParameter("SAFC", m3SAFC.Trim());
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PDLN))
				request.WithQueryParameter("PDLN", m3PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (m3SUME.HasValue)
				request.WithQueryParameter("SUME", m3SUME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUMP))
				request.WithQueryParameter("SUMP", m3SUMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name AddItmFac
		/// Description Add Item Facility
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LEA4">Administrative lead time</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3SPFA">Conversion factor supplementary U/M</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3APPR">Average cost</param>
		/// <param name="m3UCOS">Cost price</param>
		/// <param name="m3SOCO">Ordering cost</param>
		/// <param name="m3EXPC">Yield percentage</param>
		/// <param name="m3BQTY">Batch quantity</param>
		/// <param name="m3BQTM">Batch quantity method</param>
		/// <param name="m3LLCM">Lowest level - BoM</param>
		/// <param name="m3DLET">MO lead time method</param>
		/// <param name="m3DLEF">Dynamic lead time fence - MO</param>
		/// <param name="m3DIDY">Flow order planning</param>
		/// <param name="m3DIDF">Flow order fence</param>
		/// <param name="m3PRRA">Production rate</param>
		/// <param name="m3TRHC">Throughput rate of capacity/day</param>
		/// <param name="m3MARC">MO reservations</param>
		/// <param name="m3JITF">Orderless production</param>
		/// <param name="m3REWH">Main warehouse</param>
		/// <param name="m3OPFQ">Optimal on-hand balance - facility</param>
		/// <param name="m3FANO">On-hand balance - facility</param>
		/// <param name="m3FANQ">On-hand balance for inspection -facility</param>
		/// <param name="m3FANR">Rejected on-hand balance - facility</param>
		/// <param name="m3FATM">On-hand balance method - facility</param>
		/// <param name="m3WCLN">Production line</param>
		/// <param name="m3EDEC">Method for expiry date excess control</param>
		/// <param name="m3AUGE">Automatic creation of MO</param>
		/// <param name="m3ECCC">Consumption code - trade stat (TST)</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3CPRI">Customs procedure - import</param>
		/// <param name="m3CPRE">Customs procedure - export</param>
		/// <param name="m3WSCA">Costing model - purchasing</param>
		/// <param name="m3PRCM">Costing model - product costing</param>
		/// <param name="m3PLAP">Planning process</param>
		/// <param name="m3PLUP">Push process</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3CPL0">Calculate price for line type 0</param>
		/// <param name="m3CPL1">Calculate price for line type 1</param>
		/// <param name="m3CPL2">Calculate price for line type 2</param>
		/// <param name="m3PPL0">Preliminary price for line type 0</param>
		/// <param name="m3PPL1">Preliminary price for line type 1</param>
		/// <param name="m3PPL2">Preliminary price for line type 2</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3CPDC">Costing decimal places</param>
		/// <param name="m3COCD">Item cost quantity</param>
		/// <param name="m3EVGR">Environment group</param>
		/// <param name="m3VAMT">Inventory accounting method</param>
		/// <param name="m3LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3GRTI">Group technology class</param>
		/// <param name="m3MOLL">MO leadtime limit</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3DICM">Costing model - distribution</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3STCW">Catch weight approved on hand balance</param>
		/// <param name="m3RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3CAWC">Catch weight cost</param>
		/// <param name="m3CPUN">Standard cost price unit of measure</param>
		/// <param name="m3COFA">Conversion factor</param>
		/// <param name="m3ALTS">Alternate structures</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmFac(
			string m3FACI, 
			string m3ITNO, 
			int? m3CONO = null, 
			int? m3LEA4 = null, 
			string m3CSNO = null, 
			decimal? m3SPFA = null, 
			string m3ORCO = null, 
			decimal? m3APPR = null, 
			decimal? m3UCOS = null, 
			decimal? m3SOCO = null, 
			int? m3EXPC = null, 
			decimal? m3BQTY = null, 
			int? m3BQTM = null, 
			int? m3LLCM = null, 
			int? m3DLET = null, 
			int? m3DLEF = null, 
			int? m3DIDY = null, 
			int? m3DIDF = null, 
			int? m3PRRA = null, 
			int? m3TRHC = null, 
			int? m3MARC = null, 
			int? m3JITF = null, 
			string m3REWH = null, 
			decimal? m3OPFQ = null, 
			decimal? m3FANO = null, 
			decimal? m3FANQ = null, 
			decimal? m3FANR = null, 
			int? m3FATM = null, 
			string m3WCLN = null, 
			string m3EDEC = null, 
			int? m3AUGE = null, 
			string m3ECCC = null, 
			string m3ECAR = null, 
			string m3CPRI = null, 
			string m3CPRE = null, 
			string m3WSCA = null, 
			string m3PRCM = null, 
			string m3PLAP = null, 
			string m3PLUP = null, 
			string m3SCMO = null, 
			int? m3CPL0 = null, 
			int? m3CPL1 = null, 
			int? m3CPL2 = null, 
			int? m3PPL0 = null, 
			int? m3PPL1 = null, 
			int? m3PPL2 = null, 
			decimal? m3TXID = null, 
			decimal? m3DTID = null, 
			int? m3CPDC = null, 
			int? m3COCD = null, 
			string m3EVGR = null, 
			int? m3VAMT = null, 
			int? m3LAMA = null, 
			string m3GRTI = null, 
			int? m3MOLL = null, 
			int? m3CRTM = null, 
			string m3DICM = null, 
			string m3ACRF = null, 
			decimal? m3STCW = null, 
			decimal? m3RJCW = null, 
			decimal? m3QUCW = null, 
			int? m3CAWC = null, 
			string m3CPUN = null, 
			decimal? m3COFA = null, 
			int? m3ALTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3LEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (m3SPFA.HasValue)
				request.WithQueryParameter("SPFA", m3SPFA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3APPR.HasValue)
				request.WithQueryParameter("APPR", m3APPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOCO.HasValue)
				request.WithQueryParameter("SOCO", m3SOCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3EXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BQTY.HasValue)
				request.WithQueryParameter("BQTY", m3BQTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BQTM.HasValue)
				request.WithQueryParameter("BQTM", m3BQTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LLCM.HasValue)
				request.WithQueryParameter("LLCM", m3LLCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLET.HasValue)
				request.WithQueryParameter("DLET", m3DLET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLEF.HasValue)
				request.WithQueryParameter("DLEF", m3DLEF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIDY.HasValue)
				request.WithQueryParameter("DIDY", m3DIDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIDF.HasValue)
				request.WithQueryParameter("DIDF", m3DIDF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRRA.HasValue)
				request.WithQueryParameter("PRRA", m3PRRA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRHC.HasValue)
				request.WithQueryParameter("TRHC", m3TRHC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MARC.HasValue)
				request.WithQueryParameter("MARC", m3MARC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JITF.HasValue)
				request.WithQueryParameter("JITF", m3JITF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REWH))
				request.WithQueryParameter("REWH", m3REWH.Trim());
			if (m3OPFQ.HasValue)
				request.WithQueryParameter("OPFQ", m3OPFQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FANO.HasValue)
				request.WithQueryParameter("FANO", m3FANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FANQ.HasValue)
				request.WithQueryParameter("FANQ", m3FANQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FANR.HasValue)
				request.WithQueryParameter("FANR", m3FANR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FATM.HasValue)
				request.WithQueryParameter("FATM", m3FATM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WCLN))
				request.WithQueryParameter("WCLN", m3WCLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDEC))
				request.WithQueryParameter("EDEC", m3EDEC.Trim());
			if (m3AUGE.HasValue)
				request.WithQueryParameter("AUGE", m3AUGE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECCC))
				request.WithQueryParameter("ECCC", m3ECCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPRI))
				request.WithQueryParameter("CPRI", m3CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPRE))
				request.WithQueryParameter("CPRE", m3CPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRCM))
				request.WithQueryParameter("PRCM", m3PRCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLAP))
				request.WithQueryParameter("PLAP", m3PLAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLUP))
				request.WithQueryParameter("PLUP", m3PLUP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (m3CPL0.HasValue)
				request.WithQueryParameter("CPL0", m3CPL0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPL1.HasValue)
				request.WithQueryParameter("CPL1", m3CPL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPL2.HasValue)
				request.WithQueryParameter("CPL2", m3CPL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPL0.HasValue)
				request.WithQueryParameter("PPL0", m3PPL0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPL1.HasValue)
				request.WithQueryParameter("PPL1", m3PPL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPL2.HasValue)
				request.WithQueryParameter("PPL2", m3PPL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPDC.HasValue)
				request.WithQueryParameter("CPDC", m3CPDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COCD.HasValue)
				request.WithQueryParameter("COCD", m3COCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVGR))
				request.WithQueryParameter("EVGR", m3EVGR.Trim());
			if (m3VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3VAMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3LAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRTI))
				request.WithQueryParameter("GRTI", m3GRTI.Trim());
			if (m3MOLL.HasValue)
				request.WithQueryParameter("MOLL", m3MOLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DICM))
				request.WithQueryParameter("DICM", m3DICM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3STCW.HasValue)
				request.WithQueryParameter("STCW", m3STCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3RJCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3QUCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWC.HasValue)
				request.WithQueryParameter("CAWC", m3CAWC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CPUN))
				request.WithQueryParameter("CPUN", m3CPUN.Trim());
			if (m3COFA.HasValue)
				request.WithQueryParameter("COFA", m3COFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALTS.HasValue)
				request.WithQueryParameter("ALTS", m3ALTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name AddItmTrpFrelnf
		/// Description Add Item Transport Information , fields A001-A040
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3A001">Alpha field 30 positions</param>
		/// <param name="m3A002">Alpha field 30 positions</param>
		/// <param name="m3A003">Alpha field 30 positions</param>
		/// <param name="m3A004">Alpha field 30 positions</param>
		/// <param name="m3A005">Alpha field 30 positions</param>
		/// <param name="m3A006">Alpha field 30 positions</param>
		/// <param name="m3A007">Alpha field 30 positions</param>
		/// <param name="m3A008">Alpha field 30 positions</param>
		/// <param name="m3A009">Alpha field 30 positions</param>
		/// <param name="m3A010">Alpha field 30 positions</param>
		/// <param name="m3A021">Alpha field 1 positions</param>
		/// <param name="m3A022">Alpha field 1 positions</param>
		/// <param name="m3A023">Alpha field 1 positions</param>
		/// <param name="m3A024">Alpha field 1 positions</param>
		/// <param name="m3A025">Alpha field 1 positions</param>
		/// <param name="m3A026">Alpha field 5 positions</param>
		/// <param name="m3A027">Alpha field 5 positions</param>
		/// <param name="m3A028">Alpha field 5 positions</param>
		/// <param name="m3A029">Alpha field 5 positions</param>
		/// <param name="m3A030">Alpha field 5 positions</param>
		/// <param name="m3A031">Alpha field 10 positions</param>
		/// <param name="m3A032">Alpha field 10 positions</param>
		/// <param name="m3A033">Alpha field 10 positions</param>
		/// <param name="m3A034">Alpha field 10 positions</param>
		/// <param name="m3A035">Alpha field 10 positions</param>
		/// <param name="m3A036">Alpha field 15 positions</param>
		/// <param name="m3A037">Alpha field 15 positions</param>
		/// <param name="m3A038">Alpha field 15 positions</param>
		/// <param name="m3A039">Alpha field 15 positions</param>
		/// <param name="m3A040">Alpha field 15 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmTrpFrelnf(
			string m3ITNO, 
			string m3A001 = null, 
			string m3A002 = null, 
			string m3A003 = null, 
			string m3A004 = null, 
			string m3A005 = null, 
			string m3A006 = null, 
			string m3A007 = null, 
			string m3A008 = null, 
			string m3A009 = null, 
			string m3A010 = null, 
			string m3A021 = null, 
			string m3A022 = null, 
			string m3A023 = null, 
			string m3A024 = null, 
			string m3A025 = null, 
			string m3A026 = null, 
			string m3A027 = null, 
			string m3A028 = null, 
			string m3A029 = null, 
			string m3A030 = null, 
			string m3A031 = null, 
			string m3A032 = null, 
			string m3A033 = null, 
			string m3A034 = null, 
			string m3A035 = null, 
			string m3A036 = null, 
			string m3A037 = null, 
			string m3A038 = null, 
			string m3A039 = null, 
			string m3A040 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItmTrpFrelnf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3A001))
				request.WithQueryParameter("A001", m3A001.Trim());
			if (!string.IsNullOrWhiteSpace(m3A002))
				request.WithQueryParameter("A002", m3A002.Trim());
			if (!string.IsNullOrWhiteSpace(m3A003))
				request.WithQueryParameter("A003", m3A003.Trim());
			if (!string.IsNullOrWhiteSpace(m3A004))
				request.WithQueryParameter("A004", m3A004.Trim());
			if (!string.IsNullOrWhiteSpace(m3A005))
				request.WithQueryParameter("A005", m3A005.Trim());
			if (!string.IsNullOrWhiteSpace(m3A006))
				request.WithQueryParameter("A006", m3A006.Trim());
			if (!string.IsNullOrWhiteSpace(m3A007))
				request.WithQueryParameter("A007", m3A007.Trim());
			if (!string.IsNullOrWhiteSpace(m3A008))
				request.WithQueryParameter("A008", m3A008.Trim());
			if (!string.IsNullOrWhiteSpace(m3A009))
				request.WithQueryParameter("A009", m3A009.Trim());
			if (!string.IsNullOrWhiteSpace(m3A010))
				request.WithQueryParameter("A010", m3A010.Trim());
			if (!string.IsNullOrWhiteSpace(m3A021))
				request.WithQueryParameter("A021", m3A021.Trim());
			if (!string.IsNullOrWhiteSpace(m3A022))
				request.WithQueryParameter("A022", m3A022.Trim());
			if (!string.IsNullOrWhiteSpace(m3A023))
				request.WithQueryParameter("A023", m3A023.Trim());
			if (!string.IsNullOrWhiteSpace(m3A024))
				request.WithQueryParameter("A024", m3A024.Trim());
			if (!string.IsNullOrWhiteSpace(m3A025))
				request.WithQueryParameter("A025", m3A025.Trim());
			if (!string.IsNullOrWhiteSpace(m3A026))
				request.WithQueryParameter("A026", m3A026.Trim());
			if (!string.IsNullOrWhiteSpace(m3A027))
				request.WithQueryParameter("A027", m3A027.Trim());
			if (!string.IsNullOrWhiteSpace(m3A028))
				request.WithQueryParameter("A028", m3A028.Trim());
			if (!string.IsNullOrWhiteSpace(m3A029))
				request.WithQueryParameter("A029", m3A029.Trim());
			if (!string.IsNullOrWhiteSpace(m3A030))
				request.WithQueryParameter("A030", m3A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3A031))
				request.WithQueryParameter("A031", m3A031.Trim());
			if (!string.IsNullOrWhiteSpace(m3A032))
				request.WithQueryParameter("A032", m3A032.Trim());
			if (!string.IsNullOrWhiteSpace(m3A033))
				request.WithQueryParameter("A033", m3A033.Trim());
			if (!string.IsNullOrWhiteSpace(m3A034))
				request.WithQueryParameter("A034", m3A034.Trim());
			if (!string.IsNullOrWhiteSpace(m3A035))
				request.WithQueryParameter("A035", m3A035.Trim());
			if (!string.IsNullOrWhiteSpace(m3A036))
				request.WithQueryParameter("A036", m3A036.Trim());
			if (!string.IsNullOrWhiteSpace(m3A037))
				request.WithQueryParameter("A037", m3A037.Trim());
			if (!string.IsNullOrWhiteSpace(m3A038))
				request.WithQueryParameter("A038", m3A038.Trim());
			if (!string.IsNullOrWhiteSpace(m3A039))
				request.WithQueryParameter("A039", m3A039.Trim());
			if (!string.IsNullOrWhiteSpace(m3A040))
				request.WithQueryParameter("A040", m3A040.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name AddItmTrplnf
		/// Description Add Item Transport Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3UNNN">UN number</param>
		/// <param name="m3NNNN">NA number</param>
		/// <param name="m3CASN">CAS number</param>
		/// <param name="m3ECNM">EU number</param>
		/// <param name="m3EINM">EINECS number</param>
		/// <param name="m3ATOM">Atomic number</param>
		/// <param name="m3CEAN">CEA number</param>
		/// <param name="m3NAIC">NAICS code</param>
		/// <param name="m3ITEQ">Item equipment profile</param>
		/// <param name="m3CMMC">Freight commodity code</param>
		/// <param name="m3HAZM">Hazardous material</param>
		/// <param name="m3CMCL">Commodity class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmTrplnf(
			string m3ITNO, 
			int? m3UNNN = null, 
			string m3NNNN = null, 
			string m3CASN = null, 
			string m3ECNM = null, 
			string m3EINM = null, 
			string m3ATOM = null, 
			string m3CEAN = null, 
			int? m3NAIC = null, 
			string m3ITEQ = null, 
			string m3CMMC = null, 
			int? m3HAZM = null, 
			string m3CMCL = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItmTrplnf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3UNNN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NNNN))
				request.WithQueryParameter("NNNN", m3NNNN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CASN))
				request.WithQueryParameter("CASN", m3CASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECNM))
				request.WithQueryParameter("ECNM", m3ECNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EINM))
				request.WithQueryParameter("EINM", m3EINM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATOM))
				request.WithQueryParameter("ATOM", m3ATOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CEAN))
				request.WithQueryParameter("CEAN", m3CEAN.Trim());
			if (m3NAIC.HasValue)
				request.WithQueryParameter("NAIC", m3NAIC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITEQ))
				request.WithQueryParameter("ITEQ", m3ITEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMMC))
				request.WithQueryParameter("CMMC", m3CMMC.Trim());
			if (m3HAZM.HasValue)
				request.WithQueryParameter("HAZM", m3HAZM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CMCL))
				request.WithQueryParameter("CMCL", m3CMCL.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name AddItmViaItmTyp
		/// Description Add Item Via Item Type
		/// Version Release: 5ea8
		/// </summary>
		/// <param name="m3ITTY">Item type (Required)</param>
		/// <param name="m3ITDS">Name (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3ITNE">Extended item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddItmViaItmTypResponse></returns>
		/// <exception cref="M3Exception<AddItmViaItmTypResponse>"></exception>
		public async Task<M3Response<AddItmViaItmTypResponse>> AddItmViaItmTyp(
			string m3ITTY, 
			string m3ITDS, 
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3FUDS = null, 
			string m3ITNE = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItmViaItmTyp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITTY))
				throw new ArgumentNullException(nameof(m3ITTY));
			if (string.IsNullOrWhiteSpace(m3ITDS))
				throw new ArgumentNullException(nameof(m3ITDS));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITTY", m3ITTY.Trim())
				.WithQueryParameter("ITDS", m3ITDS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNE))
				request.WithQueryParameter("ITNE", m3ITNE.Trim());

			// Execute the request
			var result = await Execute<AddItmViaItmTypResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name AddItmWhs
		/// Description Add Item Warehouse
		/// Version Release: 5ea8
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ALMT">Allocation method (Required)</param>
		/// <param name="m3STMT">Storage method (Required)</param>
		/// <param name="m3SPMT">Issue method (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3PLCD">Planning policy (Required)</param>
		/// <param name="m3ABCD">ABC class - volume (Required)</param>
		/// <param name="m3ABFC">ABC class - frequency (Required)</param>
		/// <param name="m3ACOC">ABC class - contribution (Required)</param>
		/// <param name="m3PUIT">Acquisition code (Required)</param>
		/// <param name="m3ORTY">Order type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3STRL">History storage method (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3CPCD">CTP policy (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STQT">On-hand balance approved</param>
		/// <param name="m3QUQT">On-hand balance for inspection</param>
		/// <param name="m3RJQT">Rejected on-hand balance</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3AVAL">Allocatable on-hand balance</param>
		/// <param name="m3PLQT">Picking list quantity - basic U/M</param>
		/// <param name="m3COMG">Container management</param>
		/// <param name="m3STTX">Note</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3REQT">Reserved quantity</param>
		/// <param name="m3RLQT">Reserved quantity to backorder</param>
		/// <param name="m3REQP">Reserved quantity - planned orders</param>
		/// <param name="m3IDDT">Last receipt date</param>
		/// <param name="m3ODDT">Last issue date</param>
		/// <param name="m3INDT">Latest physical inventory date</param>
		/// <param name="m3PRDC">Priority date selection</param>
		/// <param name="m3INCD">Physical inventory cycle</param>
		/// <param name="m3NUIN">Number of records for physical inventory</param>
		/// <param name="m3USYE">Annual usage</param>
		/// <param name="m3AVST">Average on-hand balance</param>
		/// <param name="m3DILE">Projected on-hand at end of lead time</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3WHTY">Warehouse type</param>
		/// <param name="m3WHSY">Warehouse subtype</param>
		/// <param name="m3INSC">Statistics storage group</param>
		/// <param name="m3DIGR">Distribution group</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3NUS7">Number of balance IDs</param>
		/// <param name="m3TOMU">Issue multiple</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="m3MABC">ABC class - manual</param>
		/// <param name="m3ABCM">ABC method  - volume</param>
		/// <param name="m3ABFM">ABC method - frequency</param>
		/// <param name="m3ACOM">ABC method - contribution</param>
		/// <param name="m3PRIF">Priority value</param>
		/// <param name="m3SODY">Run-out time</param>
		/// <param name="m3REOP">Reorder point</param>
		/// <param name="m3OPOM">Reorder point method</param>
		/// <param name="m3SSQT">Safety stock</param>
		/// <param name="m3SSMT">Safety stock method</param>
		/// <param name="m3MSSQ">Manual safety stock</param>
		/// <param name="m3SSDA">Safety stock unit</param>
		/// <param name="m3SCGR">Service level</param>
		/// <param name="m3MXST">Maximum stock</param>
		/// <param name="m3MXSM">Maximum stock method</param>
		/// <param name="m3MXPC">Maximum stock percentage</param>
		/// <param name="m3EOQT">Order quantity</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3EQDA">Economical order quantity days</param>
		/// <param name="m3YEQT">Annual demand</param>
		/// <param name="m3YEQM">Annual demand method</param>
		/// <param name="m3LOQT">Minimum order quantity</param>
		/// <param name="m3MOQT">Maximum order quantity</param>
		/// <param name="m3SUWH">Supplying warehouse</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3PRCD">Forecast method</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3LYQT">Fixed annual demand</param>
		/// <param name="m3LRYE">Fixed acquisition requirement</param>
		/// <param name="m3PFTM">Planning time fence</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3LEA2">Inspection lead time</param>
		/// <param name="m3LEA3">Transportation lead time</param>
		/// <param name="m3LEAT">Lead time</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3SVEI">Multiple supply</param>
		/// <param name="m3LEVL">Lowest level</param>
		/// <param name="m3LEVD">Lowest level DO</param>
		/// <param name="m3PLHZ">Planning horizon</param>
		/// <param name="m3DMFN">Demand time fence</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3SATD">Safety time</param>
		/// <param name="m3ALQC">Quantity controlled allocation</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3SHCC">Distribution/supplier calendar check</param>
		/// <param name="m3ZCAC">Zero mark</param>
		/// <param name="m3INSL">Inspection location</param>
		/// <param name="m3NCCA">Net change calculation active</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DDEX">Time phased safety stock exists</param>
		/// <param name="m3PLIC">Picking list information control</param>
		/// <param name="m3PPMC">Pending planning method change</param>
		/// <param name="m3MPCD">Calculation date - material planning</param>
		/// <param name="m3MPCT">Calculation time - material planning</param>
		/// <param name="m3DCSS">Time phased safety stock</param>
		/// <param name="m3RPOP">Responsible - planned purchase order</param>
		/// <param name="m3BCOS">Standard cost - warehouse</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3DPLO">Default pack location</param>
		/// <param name="m3DDLO">Default docking location</param>
		/// <param name="m3SPLC">Delivery split rule</param>
		/// <param name="m3ALS1">Allocate non-approved balance ID</param>
		/// <param name="m3POOT">Point of time table</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3MNUN">Main unit of calculation</param>
		/// <param name="m3GRTS">Distribution group technology</param>
		/// <param name="m3SLDY">Shelf life</param>
		/// <param name="m3REDY">Reinspection time</param>
		/// <param name="m3SAEL">Sales time</param>
		/// <param name="m3LEAQ">Quarantine lead time</param>
		/// <param name="m3SCHT">Scheduled reclassification allowed</param>
		/// <param name="m3STCW">Catch weight approved on hand balance</param>
		/// <param name="m3RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3IPLA">Inventory planned</param>
		/// <param name="m3BBTM">Best before time</param>
		/// <param name="m3FSSQ">Frozen safety stock</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3SSRE">SS reason code</param>
		/// <param name="m3ISEG">Inventory segment</param>
		/// <param name="m3SALM">Secondary allocation method</param>
		/// <param name="m3SCPO">Supply chain policy</param>
		/// <param name="m3AGDY">Aging days</param>
		/// <param name="m3AGHO">Aging hours</param>
		/// <param name="m3AGMI">Aging minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmWhs(
			string m3WHLO, 
			string m3ITNO, 
			int m3ALMT, 
			int m3STMT, 
			int m3SPMT, 
			string m3RESP, 
			string m3PLCD, 
			string m3ABCD, 
			string m3ABFC, 
			string m3ACOC, 
			int m3PUIT, 
			string m3ORTY, 
			string m3FACI, 
			int m3STRL, 
			string m3STAT, 
			string m3CPCD, 
			int? m3CONO = null, 
			decimal? m3STQT = null, 
			decimal? m3QUQT = null, 
			decimal? m3RJQT = null, 
			decimal? m3ALQT = null, 
			decimal? m3AVAL = null, 
			decimal? m3PLQT = null, 
			int? m3COMG = null, 
			string m3STTX = null, 
			decimal? m3ORQT = null, 
			decimal? m3REQT = null, 
			decimal? m3RLQT = null, 
			decimal? m3REQP = null, 
			DateTime? m3IDDT = null, 
			DateTime? m3ODDT = null, 
			DateTime? m3INDT = null, 
			int? m3PRDC = null, 
			string m3INCD = null, 
			int? m3NUIN = null, 
			decimal? m3USYE = null, 
			decimal? m3AVST = null, 
			decimal? m3DILE = null, 
			string m3BUYE = null, 
			string m3SUNO = null, 
			string m3WHTY = null, 
			string m3WHSY = null, 
			int? m3INSC = null, 
			string m3DIGR = null, 
			string m3WHSL = null, 
			string m3SLTP = null, 
			int? m3NUS7 = null, 
			decimal? m3TOMU = null, 
			string m3WHLT = null, 
			string m3PISE = null, 
			string m3MABC = null, 
			int? m3ABCM = null, 
			int? m3ABFM = null, 
			int? m3ACOM = null, 
			int? m3PRIF = null, 
			int? m3SODY = null, 
			decimal? m3REOP = null, 
			int? m3OPOM = null, 
			decimal? m3SSQT = null, 
			int? m3SSMT = null, 
			decimal? m3MSSQ = null, 
			int? m3SSDA = null, 
			int? m3SCGR = null, 
			decimal? m3MXST = null, 
			int? m3MXSM = null, 
			int? m3MXPC = null, 
			decimal? m3EOQT = null, 
			int? m3EOQM = null, 
			int? m3EQDA = null, 
			decimal? m3YEQT = null, 
			int? m3YEQM = null, 
			decimal? m3LOQT = null, 
			decimal? m3MOQT = null, 
			string m3SUWH = null, 
			int? m3DPID = null, 
			string m3PRCD = null, 
			string m3FCCM = null, 
			decimal? m3LYQT = null, 
			decimal? m3LRYE = null, 
			int? m3PFTM = null, 
			int? m3LEA1 = null, 
			int? m3LEA2 = null, 
			int? m3LEA3 = null, 
			int? m3LEAT = null, 
			decimal? m3UNMU = null, 
			int? m3SVEI = null, 
			int? m3LEVL = null, 
			int? m3LEVD = null, 
			int? m3PLHZ = null, 
			int? m3DMFN = null, 
			int? m3CONC = null, 
			int? m3SATD = null, 
			int? m3ALQC = null, 
			int? m3OPLC = null, 
			int? m3MSCH = null, 
			int? m3SHCC = null, 
			int? m3ZCAC = null, 
			string m3INSL = null, 
			int? m3NCCA = null, 
			string m3DIVI = null, 
			int? m3DDEX = null, 
			int? m3PLIC = null, 
			int? m3PPMC = null, 
			DateTime? m3MPCD = null, 
			int? m3MPCT = null, 
			int? m3DCSS = null, 
			int? m3RPOP = null, 
			decimal? m3BCOS = null, 
			decimal? m3TXID = null, 
			decimal? m3DTID = null, 
			string m3DPLO = null, 
			string m3DDLO = null, 
			string m3SPLC = null, 
			int? m3ALS1 = null, 
			string m3POOT = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			string m3MNUN = null, 
			string m3GRTS = null, 
			int? m3SLDY = null, 
			int? m3REDY = null, 
			int? m3SAEL = null, 
			int? m3LEAQ = null, 
			int? m3SCHT = null, 
			decimal? m3STCW = null, 
			decimal? m3RJCW = null, 
			decimal? m3QUCW = null, 
			string m3IPLA = null, 
			int? m3BBTM = null, 
			int? m3FSSQ = null, 
			int? m3RNRI = null, 
			int? m3RMSG = null, 
			string m3SSRE = null, 
			string m3ISEG = null, 
			int? m3SALM = null, 
			string m3SCPO = null, 
			int? m3AGDY = null, 
			int? m3AGHO = null, 
			int? m3AGMI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));
			if (string.IsNullOrWhiteSpace(m3PLCD))
				throw new ArgumentNullException(nameof(m3PLCD));
			if (string.IsNullOrWhiteSpace(m3ABCD))
				throw new ArgumentNullException(nameof(m3ABCD));
			if (string.IsNullOrWhiteSpace(m3ABFC))
				throw new ArgumentNullException(nameof(m3ABFC));
			if (string.IsNullOrWhiteSpace(m3ACOC))
				throw new ArgumentNullException(nameof(m3ACOC));
			if (string.IsNullOrWhiteSpace(m3ORTY))
				throw new ArgumentNullException(nameof(m3ORTY));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3CPCD))
				throw new ArgumentNullException(nameof(m3CPCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ALMT", m3ALMT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STMT", m3STMT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPMT", m3SPMT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("PLCD", m3PLCD.Trim())
				.WithQueryParameter("ABCD", m3ABCD.Trim())
				.WithQueryParameter("ABFC", m3ABFC.Trim())
				.WithQueryParameter("ACOC", m3ACOC.Trim())
				.WithQueryParameter("PUIT", m3PUIT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORTY", m3ORTY.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("STRL", m3STRL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("CPCD", m3CPCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STQT.HasValue)
				request.WithQueryParameter("STQT", m3STQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUQT.HasValue)
				request.WithQueryParameter("QUQT", m3QUQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RJQT.HasValue)
				request.WithQueryParameter("RJQT", m3RJQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVAL.HasValue)
				request.WithQueryParameter("AVAL", m3AVAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLQT.HasValue)
				request.WithQueryParameter("PLQT", m3PLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COMG.HasValue)
				request.WithQueryParameter("COMG", m3COMG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STTX))
				request.WithQueryParameter("STTX", m3STTX.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQT.HasValue)
				request.WithQueryParameter("REQT", m3REQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLQT.HasValue)
				request.WithQueryParameter("RLQT", m3RLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQP.HasValue)
				request.WithQueryParameter("REQP", m3REQP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDDT.HasValue)
				request.WithQueryParameter("IDDT", m3IDDT.Value.ToM3String());
			if (m3ODDT.HasValue)
				request.WithQueryParameter("ODDT", m3ODDT.Value.ToM3String());
			if (m3INDT.HasValue)
				request.WithQueryParameter("INDT", m3INDT.Value.ToM3String());
			if (m3PRDC.HasValue)
				request.WithQueryParameter("PRDC", m3PRDC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INCD))
				request.WithQueryParameter("INCD", m3INCD.Trim());
			if (m3NUIN.HasValue)
				request.WithQueryParameter("NUIN", m3NUIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3USYE.HasValue)
				request.WithQueryParameter("USYE", m3USYE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVST.HasValue)
				request.WithQueryParameter("AVST", m3AVST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DILE.HasValue)
				request.WithQueryParameter("DILE", m3DILE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHTY))
				request.WithQueryParameter("WHTY", m3WHTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSY))
				request.WithQueryParameter("WHSY", m3WHSY.Trim());
			if (m3INSC.HasValue)
				request.WithQueryParameter("INSC", m3INSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIGR))
				request.WithQueryParameter("DIGR", m3DIGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (m3NUS7.HasValue)
				request.WithQueryParameter("NUS7", m3NUS7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOMU.HasValue)
				request.WithQueryParameter("TOMU", m3TOMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MABC))
				request.WithQueryParameter("MABC", m3MABC.Trim());
			if (m3ABCM.HasValue)
				request.WithQueryParameter("ABCM", m3ABCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABFM.HasValue)
				request.WithQueryParameter("ABFM", m3ABFM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACOM.HasValue)
				request.WithQueryParameter("ACOM", m3ACOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRIF.HasValue)
				request.WithQueryParameter("PRIF", m3PRIF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SODY.HasValue)
				request.WithQueryParameter("SODY", m3SODY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REOP.HasValue)
				request.WithQueryParameter("REOP", m3REOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3OPOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3SSQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3SSMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3MSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3SSDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3SCGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXST.HasValue)
				request.WithQueryParameter("MXST", m3MXST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXSM.HasValue)
				request.WithQueryParameter("MXSM", m3MXSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3MXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQT.HasValue)
				request.WithQueryParameter("EOQT", m3EOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3EQDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3YEQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEQM.HasValue)
				request.WithQueryParameter("YEQM", m3YEQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3MOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUWH))
				request.WithQueryParameter("SUWH", m3SUWH.Trim());
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRCD))
				request.WithQueryParameter("PRCD", m3PRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3LYQT.HasValue)
				request.WithQueryParameter("LYQT", m3LYQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LRYE.HasValue)
				request.WithQueryParameter("LRYE", m3LRYE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFTM.HasValue)
				request.WithQueryParameter("PFTM", m3PFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3LEA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA2.HasValue)
				request.WithQueryParameter("LEA2", m3LEA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA3.HasValue)
				request.WithQueryParameter("LEA3", m3LEA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEAT.HasValue)
				request.WithQueryParameter("LEAT", m3LEAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SVEI.HasValue)
				request.WithQueryParameter("SVEI", m3SVEI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3LEVL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEVD.HasValue)
				request.WithQueryParameter("LEVD", m3LEVD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3PLHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DMFN.HasValue)
				request.WithQueryParameter("DMFN", m3DMFN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SATD.HasValue)
				request.WithQueryParameter("SATD", m3SATD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQC.HasValue)
				request.WithQueryParameter("ALQC", m3ALQC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3OPLC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3MSCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHCC.HasValue)
				request.WithQueryParameter("SHCC", m3SHCC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZCAC.HasValue)
				request.WithQueryParameter("ZCAC", m3ZCAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INSL))
				request.WithQueryParameter("INSL", m3INSL.Trim());
			if (m3NCCA.HasValue)
				request.WithQueryParameter("NCCA", m3NCCA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3DDEX.HasValue)
				request.WithQueryParameter("DDEX", m3DDEX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLIC.HasValue)
				request.WithQueryParameter("PLIC", m3PLIC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPMC.HasValue)
				request.WithQueryParameter("PPMC", m3PPMC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MPCD.HasValue)
				request.WithQueryParameter("MPCD", m3MPCD.Value.ToM3String());
			if (m3MPCT.HasValue)
				request.WithQueryParameter("MPCT", m3MPCT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCSS.HasValue)
				request.WithQueryParameter("DCSS", m3DCSS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPOP.HasValue)
				request.WithQueryParameter("RPOP", m3RPOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCOS.HasValue)
				request.WithQueryParameter("BCOS", m3BCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DPLO))
				request.WithQueryParameter("DPLO", m3DPLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DDLO))
				request.WithQueryParameter("DDLO", m3DDLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLC))
				request.WithQueryParameter("SPLC", m3SPLC.Trim());
			if (m3ALS1.HasValue)
				request.WithQueryParameter("ALS1", m3ALS1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POOT))
				request.WithQueryParameter("POOT", m3POOT.Trim());
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MNUN))
				request.WithQueryParameter("MNUN", m3MNUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTS))
				request.WithQueryParameter("GRTS", m3GRTS.Trim());
			if (m3SLDY.HasValue)
				request.WithQueryParameter("SLDY", m3SLDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REDY.HasValue)
				request.WithQueryParameter("REDY", m3REDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAEL.HasValue)
				request.WithQueryParameter("SAEL", m3SAEL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEAQ.HasValue)
				request.WithQueryParameter("LEAQ", m3LEAQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHT.HasValue)
				request.WithQueryParameter("SCHT", m3SCHT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STCW.HasValue)
				request.WithQueryParameter("STCW", m3STCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3RJCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3QUCW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IPLA))
				request.WithQueryParameter("IPLA", m3IPLA.Trim());
			if (m3BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3BBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3FSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSRE))
				request.WithQueryParameter("SSRE", m3SSRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISEG))
				request.WithQueryParameter("ISEG", m3ISEG.Trim());
			if (m3SALM.HasValue)
				request.WithQueryParameter("SALM", m3SALM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPO))
				request.WithQueryParameter("SCPO", m3SCPO.Trim());
			if (m3AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3AGDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3AGHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3AGMI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CpyItmBasic
		/// Description Copy Item Basic
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CITN">Copy Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3BUAR">Business area</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3CITT">Copy Item type</param>
		/// <param name="m3TPCD">Item category</param>
		/// <param name="m3MABU">Make/buy code</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3BACD">Lot numbering method</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3BYPR">By/co-product code</param>
		/// <param name="m3WAPC">Normal waste percentage</param>
		/// <param name="m3QACD">Inspection code</param>
		/// <param name="m3EPCD">Yield calculation</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3ACTI">Active or catch weight item</param>
		/// <param name="m3HIE1">Hierachy level 1</param>
		/// <param name="m3HIE2">Hierachy level 2</param>
		/// <param name="m3HIE3">Hierachy level 3</param>
		/// <param name="m3HIE4">Hierachy level 4</param>
		/// <param name="m3HIE5">Hierachy level 5</param>
		/// <param name="m3GRP1">Search group 1</param>
		/// <param name="m3GRP2">Search group 2</param>
		/// <param name="m3GRP3">Search group 3</param>
		/// <param name="m3GRP4">Search group 4</param>
		/// <param name="m3GRP5">Search group 5</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3ECMA">ECO managed</param>
		/// <param name="m3PRGP">Procurement group</param>
		/// <param name="m3INDI">Lot control method</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3ALUC">Alternate U/M in use</param>
		/// <param name="m3IEAA">Item exists as alias identity</param>
		/// <param name="m3EXPD">Expiration date method</param>
		/// <param name="m3GRMT">Goods receiving method</param>
		/// <param name="m3HAZI">Danger indicator</param>
		/// <param name="m3SALE">Sales item</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="m3ATMN">Attribute managed</param>
		/// <param name="m3TPLI">Template item number</param>
		/// <param name="m3FCU1">Estimated consumption free capacity unit</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3IACP">Attribute-controlled item</param>
		/// <param name="m3HDPR">Main product</param>
		/// <param name="m3AAD0">Extended QA used</param>
		/// <param name="m3AAD1">Generate txt from text template</param>
		/// <param name="m3CHCL">Charge calculation</param>
		/// <param name="m3ITRC">Individual item tracing</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3EVGR">Envirenment group</param>
		/// <param name="m3GRTS">Distribution group technology</param>
		/// <param name="m3ETRF">External instruction</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3GRTI">Group Technology Class</param>
		/// <param name="m3CAWP">Catch weight mode</param>
		/// <param name="m3CWUN">Catch weight unit of measure</param>
		/// <param name="m3CPUN">Standard cost price unit of measure</param>
		/// <param name="m3ITRU">Included in territorial roll-up</param>
		/// <param name="m3TECR">Core terms</param>
		/// <param name="m3EXCA">Exchangeable</param>
		/// <param name="m3ACCG">Acceptance group</param>
		/// <param name="m3CCCM">Costing model - core charge</param>
		/// <param name="m3CCI1">Core charge item number</param>
		/// <param name="m3CRI1">Core remain item number</param>
		/// <param name="m3HVMT">Harvest Method</param>
		/// <param name="m3ITNE">Extended item number</param>
		/// <param name="m3SPGV">Specific gravity</param>
		/// <param name="m3PDLN">Product line</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3SUME">Sublot method</param>
		/// <param name="m3SUMP">Sublot policy</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CpyItmBasicResponse></returns>
		/// <exception cref="M3Exception<CpyItmBasicResponse>"></exception>
		public async Task<M3Response<CpyItmBasicResponse>> CpyItmBasic(
			string m3STAT, 
			string m3ITNO, 
			int? m3CONO = null, 
			string m3CITN = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3DWNO = null, 
			string m3RESP = null, 
			string m3UNMS = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3BUAR = null, 
			string m3ITTY = null, 
			string m3CITT = null, 
			int? m3TPCD = null, 
			int? m3MABU = null, 
			int? m3CHCD = null, 
			int? m3STCD = null, 
			int? m3BACD = null, 
			decimal? m3VOL3 = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			string m3PPUN = null, 
			int? m3BYPR = null, 
			int? m3WAPC = null, 
			int? m3QACD = null, 
			int? m3EPCD = null, 
			int? m3POCY = null, 
			int? m3ACTI = null, 
			string m3HIE1 = null, 
			string m3HIE2 = null, 
			string m3HIE3 = null, 
			string m3HIE4 = null, 
			string m3HIE5 = null, 
			string m3GRP1 = null, 
			string m3GRP2 = null, 
			string m3GRP3 = null, 
			string m3GRP4 = null, 
			string m3GRP5 = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI5 = null, 
			string m3CFI4 = null, 
			decimal? m3TXID = null, 
			int? m3ECMA = null, 
			string m3PRGP = null, 
			int? m3INDI = null, 
			string m3PUUN = null, 
			int? m3ALUC = null, 
			int? m3IEAA = null, 
			int? m3EXPD = null, 
			string m3GRMT = null, 
			int? m3HAZI = null, 
			int? m3SALE = null, 
			string m3TAXC = null, 
			string m3ATMO = null, 
			int? m3ATMN = null, 
			string m3TPLI = null, 
			decimal? m3FCU1 = null, 
			string m3ALUN = null, 
			int? m3IACP = null, 
			string m3HDPR = null, 
			int? m3AAD0 = null, 
			int? m3AAD1 = null, 
			int? m3CHCL = null, 
			int? m3ITRC = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			string m3EVGR = null, 
			string m3GRTS = null, 
			string m3ETRF = null, 
			string m3ECVE = null, 
			string m3GRTI = null, 
			int? m3CAWP = null, 
			string m3CWUN = null, 
			string m3CPUN = null, 
			int? m3ITRU = null, 
			string m3TECR = null, 
			int? m3EXCA = null, 
			string m3ACCG = null, 
			string m3CCCM = null, 
			string m3CCI1 = null, 
			string m3CRI1 = null, 
			int? m3HVMT = null, 
			string m3ITNE = null, 
			decimal? m3SPGV = null, 
			string m3PDLN = null, 
			string m3CPGR = null, 
			int? m3SUME = null, 
			string m3SUMP = null, 
			string m3QMGP = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyItmBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CITN))
				request.WithQueryParameter("CITN", m3CITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUAR))
				request.WithQueryParameter("BUAR", m3BUAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CITT))
				request.WithQueryParameter("CITT", m3CITT.Trim());
			if (m3TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3TPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MABU.HasValue)
				request.WithQueryParameter("MABU", m3MABU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACD.HasValue)
				request.WithQueryParameter("BACD", m3BACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (m3BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3BYPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3WAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QACD.HasValue)
				request.WithQueryParameter("QACD", m3QACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EPCD.HasValue)
				request.WithQueryParameter("EPCD", m3EPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3ACTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HIE1))
				request.WithQueryParameter("HIE1", m3HIE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE2))
				request.WithQueryParameter("HIE2", m3HIE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE3))
				request.WithQueryParameter("HIE3", m3HIE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE4))
				request.WithQueryParameter("HIE4", m3HIE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE5))
				request.WithQueryParameter("HIE5", m3HIE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP1))
				request.WithQueryParameter("GRP1", m3GRP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP2))
				request.WithQueryParameter("GRP2", m3GRP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP3))
				request.WithQueryParameter("GRP3", m3GRP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP4))
				request.WithQueryParameter("GRP4", m3GRP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP5))
				request.WithQueryParameter("GRP5", m3GRP5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI1))
				request.WithQueryParameter("CFI1", m3CFI1.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI5))
				request.WithQueryParameter("CFI5", m3CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI4))
				request.WithQueryParameter("CFI4", m3CFI4.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3ECMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRGP))
				request.WithQueryParameter("PRGP", m3PRGP.Trim());
			if (m3INDI.HasValue)
				request.WithQueryParameter("INDI", m3INDI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (m3ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3ALUC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IEAA.HasValue)
				request.WithQueryParameter("IEAA", m3IEAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3EXPD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (m3HAZI.HasValue)
				request.WithQueryParameter("HAZI", m3HAZI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SALE.HasValue)
				request.WithQueryParameter("SALE", m3SALE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());
			if (m3ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3ATMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TPLI))
				request.WithQueryParameter("TPLI", m3TPLI.Trim());
			if (m3FCU1.HasValue)
				request.WithQueryParameter("FCU1", m3FCU1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3IACP.HasValue)
				request.WithQueryParameter("IACP", m3IACP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HDPR))
				request.WithQueryParameter("HDPR", m3HDPR.Trim());
			if (m3AAD0.HasValue)
				request.WithQueryParameter("AAD0", m3AAD0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AAD1.HasValue)
				request.WithQueryParameter("AAD1", m3AAD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHCL.HasValue)
				request.WithQueryParameter("CHCL", m3CHCL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITRC.HasValue)
				request.WithQueryParameter("ITRC", m3ITRC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVGR))
				request.WithQueryParameter("EVGR", m3EVGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTS))
				request.WithQueryParameter("GRTS", m3GRTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETRF))
				request.WithQueryParameter("ETRF", m3ETRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTI))
				request.WithQueryParameter("GRTI", m3GRTI.Trim());
			if (m3CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3CAWP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CWUN))
				request.WithQueryParameter("CWUN", m3CWUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPUN))
				request.WithQueryParameter("CPUN", m3CPUN.Trim());
			if (m3ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3ITRU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECR))
				request.WithQueryParameter("TECR", m3TECR.Trim());
			if (m3EXCA.HasValue)
				request.WithQueryParameter("EXCA", m3EXCA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACCG))
				request.WithQueryParameter("ACCG", m3ACCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCCM))
				request.WithQueryParameter("CCCM", m3CCCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCI1))
				request.WithQueryParameter("CCI1", m3CCI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRI1))
				request.WithQueryParameter("CRI1", m3CRI1.Trim());
			if (m3HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3HVMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNE))
				request.WithQueryParameter("ITNE", m3ITNE.Trim());
			if (m3SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3SPGV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PDLN))
				request.WithQueryParameter("PDLN", m3PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (m3SUME.HasValue)
				request.WithQueryParameter("SUME", m3SUME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUMP))
				request.WithQueryParameter("SUMP", m3SUMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());

			// Execute the request
			var result = await Execute<CpyItmBasicResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CpyItmFac
		/// Description Copy Item Facility
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CFAC">Copy Facility (Required)</param>
		/// <param name="m3CITN">Copy Item Number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LEA4">Administrative lead time</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3SPFA">Conversion factor supplementary U/M</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3APPR">Average cost</param>
		/// <param name="m3UCOS">Cost price</param>
		/// <param name="m3SOCO">Ordering cost</param>
		/// <param name="m3EXPC">Yield percentage</param>
		/// <param name="m3BQTY">Batch quantity</param>
		/// <param name="m3BQTM">Batch quantity method</param>
		/// <param name="m3LLCM">Lowest level - BoM</param>
		/// <param name="m3DLET">MO lead time method</param>
		/// <param name="m3DLEF">Dynamic lead time fence - MO</param>
		/// <param name="m3DIDY">Flow order planning</param>
		/// <param name="m3DIDF">Flow order fence</param>
		/// <param name="m3PRRA">Production rate</param>
		/// <param name="m3TRHC">Throughput rate of capacity/day</param>
		/// <param name="m3MARC">MO reservations</param>
		/// <param name="m3JITF">Orderless production</param>
		/// <param name="m3REWH">Main warehouse</param>
		/// <param name="m3OPFQ">Optimal on-hand balance - facility</param>
		/// <param name="m3FANO">On-hand balance - facility</param>
		/// <param name="m3FANQ">On-hand balance for inspection -facility</param>
		/// <param name="m3FANR">Rejected on-hand balance - facility</param>
		/// <param name="m3FATM">On-hand balance method - facility</param>
		/// <param name="m3WCLN">Production line</param>
		/// <param name="m3EDEC">Method for expiry date excess control</param>
		/// <param name="m3AUGE">Automatic creation of MO</param>
		/// <param name="m3ECCC">Consumption code - trade stat (TST)</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3CPRI">Customs procedure - import</param>
		/// <param name="m3CPRE">Customs procedure - export</param>
		/// <param name="m3WSCA">Costing model - purchasing</param>
		/// <param name="m3PRCM">Costing model - product costing</param>
		/// <param name="m3PLAP">Planning process</param>
		/// <param name="m3PLUP">Push process</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3CPL0">Calculate price for line type 0</param>
		/// <param name="m3CPL1">Calculate price for line type 1</param>
		/// <param name="m3CPL2">Calculate price for line type 2</param>
		/// <param name="m3PPL0">Preliminary price for line type 0</param>
		/// <param name="m3PPL1">Preliminary price for line type 1</param>
		/// <param name="m3PPL2">Preliminary price for line type 2</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3CPDC">Costing decimal places</param>
		/// <param name="m3COCD">Item cost quantity</param>
		/// <param name="m3EVGR">Environment group</param>
		/// <param name="m3VAMT">Inventory accounting method</param>
		/// <param name="m3LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3GRTI">Group technology class</param>
		/// <param name="m3MOLL">MO leadtime limit</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3DICM">Costing model - distribution</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3STCW">Catch weight approved on hand balance</param>
		/// <param name="m3RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3CAWC">Catch weight cost</param>
		/// <param name="m3CPUN">Standard cost price unit of measure</param>
		/// <param name="m3COFA">Conversion factor</param>
		/// <param name="m3ALTS">Alternate structures</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyItmFac(
			string m3FACI, 
			string m3ITNO, 
			string m3CFAC, 
			string m3CITN, 
			int? m3CONO = null, 
			int? m3LEA4 = null, 
			string m3CSNO = null, 
			decimal? m3SPFA = null, 
			string m3ORCO = null, 
			decimal? m3APPR = null, 
			decimal? m3UCOS = null, 
			decimal? m3SOCO = null, 
			int? m3EXPC = null, 
			decimal? m3BQTY = null, 
			int? m3BQTM = null, 
			int? m3LLCM = null, 
			int? m3DLET = null, 
			int? m3DLEF = null, 
			int? m3DIDY = null, 
			int? m3DIDF = null, 
			int? m3PRRA = null, 
			int? m3TRHC = null, 
			int? m3MARC = null, 
			int? m3JITF = null, 
			string m3REWH = null, 
			decimal? m3OPFQ = null, 
			decimal? m3FANO = null, 
			decimal? m3FANQ = null, 
			decimal? m3FANR = null, 
			int? m3FATM = null, 
			string m3WCLN = null, 
			string m3EDEC = null, 
			int? m3AUGE = null, 
			string m3ECCC = null, 
			string m3ECAR = null, 
			string m3CPRI = null, 
			string m3CPRE = null, 
			string m3WSCA = null, 
			string m3PRCM = null, 
			string m3PLAP = null, 
			string m3PLUP = null, 
			string m3SCMO = null, 
			int? m3CPL0 = null, 
			int? m3CPL1 = null, 
			int? m3CPL2 = null, 
			int? m3PPL0 = null, 
			int? m3PPL1 = null, 
			int? m3PPL2 = null, 
			decimal? m3TXID = null, 
			decimal? m3DTID = null, 
			int? m3CPDC = null, 
			int? m3COCD = null, 
			string m3EVGR = null, 
			int? m3VAMT = null, 
			int? m3LAMA = null, 
			string m3GRTI = null, 
			int? m3MOLL = null, 
			int? m3CRTM = null, 
			string m3DICM = null, 
			string m3ACRF = null, 
			decimal? m3STCW = null, 
			decimal? m3RJCW = null, 
			decimal? m3QUCW = null, 
			int? m3CAWC = null, 
			string m3CPUN = null, 
			decimal? m3COFA = null, 
			int? m3ALTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CFAC))
				throw new ArgumentNullException(nameof(m3CFAC));
			if (string.IsNullOrWhiteSpace(m3CITN))
				throw new ArgumentNullException(nameof(m3CITN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CFAC", m3CFAC.Trim())
				.WithQueryParameter("CITN", m3CITN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3LEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (m3SPFA.HasValue)
				request.WithQueryParameter("SPFA", m3SPFA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3APPR.HasValue)
				request.WithQueryParameter("APPR", m3APPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOCO.HasValue)
				request.WithQueryParameter("SOCO", m3SOCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3EXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BQTY.HasValue)
				request.WithQueryParameter("BQTY", m3BQTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BQTM.HasValue)
				request.WithQueryParameter("BQTM", m3BQTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LLCM.HasValue)
				request.WithQueryParameter("LLCM", m3LLCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLET.HasValue)
				request.WithQueryParameter("DLET", m3DLET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLEF.HasValue)
				request.WithQueryParameter("DLEF", m3DLEF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIDY.HasValue)
				request.WithQueryParameter("DIDY", m3DIDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIDF.HasValue)
				request.WithQueryParameter("DIDF", m3DIDF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRRA.HasValue)
				request.WithQueryParameter("PRRA", m3PRRA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRHC.HasValue)
				request.WithQueryParameter("TRHC", m3TRHC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MARC.HasValue)
				request.WithQueryParameter("MARC", m3MARC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JITF.HasValue)
				request.WithQueryParameter("JITF", m3JITF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REWH))
				request.WithQueryParameter("REWH", m3REWH.Trim());
			if (m3OPFQ.HasValue)
				request.WithQueryParameter("OPFQ", m3OPFQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FANO.HasValue)
				request.WithQueryParameter("FANO", m3FANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FANQ.HasValue)
				request.WithQueryParameter("FANQ", m3FANQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FANR.HasValue)
				request.WithQueryParameter("FANR", m3FANR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FATM.HasValue)
				request.WithQueryParameter("FATM", m3FATM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WCLN))
				request.WithQueryParameter("WCLN", m3WCLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDEC))
				request.WithQueryParameter("EDEC", m3EDEC.Trim());
			if (m3AUGE.HasValue)
				request.WithQueryParameter("AUGE", m3AUGE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECCC))
				request.WithQueryParameter("ECCC", m3ECCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPRI))
				request.WithQueryParameter("CPRI", m3CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPRE))
				request.WithQueryParameter("CPRE", m3CPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRCM))
				request.WithQueryParameter("PRCM", m3PRCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLAP))
				request.WithQueryParameter("PLAP", m3PLAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLUP))
				request.WithQueryParameter("PLUP", m3PLUP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (m3CPL0.HasValue)
				request.WithQueryParameter("CPL0", m3CPL0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPL1.HasValue)
				request.WithQueryParameter("CPL1", m3CPL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPL2.HasValue)
				request.WithQueryParameter("CPL2", m3CPL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPL0.HasValue)
				request.WithQueryParameter("PPL0", m3PPL0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPL1.HasValue)
				request.WithQueryParameter("PPL1", m3PPL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPL2.HasValue)
				request.WithQueryParameter("PPL2", m3PPL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPDC.HasValue)
				request.WithQueryParameter("CPDC", m3CPDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COCD.HasValue)
				request.WithQueryParameter("COCD", m3COCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVGR))
				request.WithQueryParameter("EVGR", m3EVGR.Trim());
			if (m3VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3VAMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3LAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRTI))
				request.WithQueryParameter("GRTI", m3GRTI.Trim());
			if (m3MOLL.HasValue)
				request.WithQueryParameter("MOLL", m3MOLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DICM))
				request.WithQueryParameter("DICM", m3DICM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3STCW.HasValue)
				request.WithQueryParameter("STCW", m3STCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3RJCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3QUCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWC.HasValue)
				request.WithQueryParameter("CAWC", m3CAWC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CPUN))
				request.WithQueryParameter("CPUN", m3CPUN.Trim());
			if (m3COFA.HasValue)
				request.WithQueryParameter("COFA", m3COFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALTS.HasValue)
				request.WithQueryParameter("ALTS", m3ALTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CpyItmTrpInf
		/// Description Copy Item Transport Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CITN">Default item (Required)</param>
		/// <param name="m3UNNN">UN number</param>
		/// <param name="m3NNNN">NA number</param>
		/// <param name="m3CASN">CAS number</param>
		/// <param name="m3ECNM">EU number</param>
		/// <param name="m3EINM">EINECS number</param>
		/// <param name="m3ATOM">Atomic number</param>
		/// <param name="m3CEAN">CEA number</param>
		/// <param name="m3NAIC">NAICS code</param>
		/// <param name="m3ITEQ">Item equipment profile</param>
		/// <param name="m3CMMC">Freight commodity code</param>
		/// <param name="m3HAZM">Hazardous material</param>
		/// <param name="m3CMCL">Commodity class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyItmTrpInf(
			string m3ITNO, 
			string m3CITN, 
			int? m3UNNN = null, 
			string m3NNNN = null, 
			string m3CASN = null, 
			string m3ECNM = null, 
			string m3EINM = null, 
			string m3ATOM = null, 
			string m3CEAN = null, 
			int? m3NAIC = null, 
			string m3ITEQ = null, 
			string m3CMMC = null, 
			int? m3HAZM = null, 
			string m3CMCL = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyItmTrpInf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CITN))
				throw new ArgumentNullException(nameof(m3CITN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CITN", m3CITN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3UNNN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NNNN))
				request.WithQueryParameter("NNNN", m3NNNN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CASN))
				request.WithQueryParameter("CASN", m3CASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECNM))
				request.WithQueryParameter("ECNM", m3ECNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EINM))
				request.WithQueryParameter("EINM", m3EINM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATOM))
				request.WithQueryParameter("ATOM", m3ATOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CEAN))
				request.WithQueryParameter("CEAN", m3CEAN.Trim());
			if (m3NAIC.HasValue)
				request.WithQueryParameter("NAIC", m3NAIC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITEQ))
				request.WithQueryParameter("ITEQ", m3ITEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMMC))
				request.WithQueryParameter("CMMC", m3CMMC.Trim());
			if (m3HAZM.HasValue)
				request.WithQueryParameter("HAZM", m3HAZM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CMCL))
				request.WithQueryParameter("CMCL", m3CMCL.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CpyItmViaItmTyp
		/// Description Copy Item Via ItemType
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CITN">Copy Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3ITNE">Extended item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CpyItmViaItmTypResponse></returns>
		/// <exception cref="M3Exception<CpyItmViaItmTypResponse>"></exception>
		public async Task<M3Response<CpyItmViaItmTypResponse>> CpyItmViaItmTyp(
			string m3CITN, 
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3ITNE = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyItmViaItmTyp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CITN))
				throw new ArgumentNullException(nameof(m3CITN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CITN", m3CITN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNE))
				request.WithQueryParameter("ITNE", m3ITNE.Trim());

			// Execute the request
			var result = await Execute<CpyItmViaItmTypResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CpyItmWhs
		/// Description Copy Item Warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CWHL">Copy Warehouse (Required)</param>
		/// <param name="m3CITN">Copy Item Number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STQT">On-hand balance approved</param>
		/// <param name="m3QUQT">On-hand balance for inspection</param>
		/// <param name="m3RJQT">Rejected on-hand balance</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3AVAL">Allocatable on-hand balance</param>
		/// <param name="m3PLQT">Picking list quantity - basic U/M</param>
		/// <param name="m3COMG">Container management</param>
		/// <param name="m3ALMT">Allocation method</param>
		/// <param name="m3STMT">Storage method</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3STTX">Note</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3REQT">Reserved quantity</param>
		/// <param name="m3RLQT">Reserved quantity to backorder</param>
		/// <param name="m3REQP">Reserved quantity - planned orders</param>
		/// <param name="m3IDDT">Last receipt date</param>
		/// <param name="m3ODDT">Last issue date</param>
		/// <param name="m3INDT">Latest physical inventory date</param>
		/// <param name="m3PRDC">Priority date selection</param>
		/// <param name="m3INCD">Physical inventory cycle</param>
		/// <param name="m3NUIN">Number of records for physical inventory</param>
		/// <param name="m3USYE">Annual usage</param>
		/// <param name="m3AVST">Average on-hand balance</param>
		/// <param name="m3DILE">Projected on-hand at end of lead time</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3WHTY">Warehouse type</param>
		/// <param name="m3WHSY">Warehouse subtype</param>
		/// <param name="m3INSC">Statistics storage group</param>
		/// <param name="m3DIGR">Distribution group</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3NUS7">Number of balance IDs</param>
		/// <param name="m3TOMU">Issue multiple</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3MABC">ABC class - manual</param>
		/// <param name="m3ABCD">ABC class - volume</param>
		/// <param name="m3ABCM">ABC method  - volume</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3ABFM">ABC method - frequency</param>
		/// <param name="m3ACOC">ABC class - contribution</param>
		/// <param name="m3ACOM">ABC method - contribution</param>
		/// <param name="m3PRIF">Priority value</param>
		/// <param name="m3SODY">Run-out time</param>
		/// <param name="m3REOP">Reorder point</param>
		/// <param name="m3OPOM">Reorder point method</param>
		/// <param name="m3SSQT">Safety stock</param>
		/// <param name="m3SSMT">Safety stock method</param>
		/// <param name="m3MSSQ">Manual safety stock</param>
		/// <param name="m3SSDA">Safety stock unit</param>
		/// <param name="m3SCGR">Service level</param>
		/// <param name="m3MXST">Maximum stock</param>
		/// <param name="m3MXSM">Maximum stock method</param>
		/// <param name="m3MXPC">Maximum stock percentage</param>
		/// <param name="m3EOQT">Order quantity</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3EQDA">Economical order quantity days</param>
		/// <param name="m3YEQT">Annual demand</param>
		/// <param name="m3YEQM">Annual demand method</param>
		/// <param name="m3LOQT">Minimum order quantity</param>
		/// <param name="m3MOQT">Maximum order quantity</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3SUWH">Supplying warehouse</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3PRCD">Forecast method</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3LYQT">Fixed annual demand</param>
		/// <param name="m3LRYE">Fixed acquisition requirement</param>
		/// <param name="m3PFTM">Planning time fence</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3LEA2">Inspection lead time</param>
		/// <param name="m3LEA3">Transportation lead time</param>
		/// <param name="m3LEAT">Lead time</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3SVEI">Multiple supply</param>
		/// <param name="m3LEVL">Lowest level</param>
		/// <param name="m3LEVD">Lowest level DO</param>
		/// <param name="m3PLHZ">Planning horizon</param>
		/// <param name="m3DMFN">Demand time fence</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3SATD">Safety time</param>
		/// <param name="m3ALQC">Quantity controlled allocation</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3SHCC">Distribution/supplier calendar check</param>
		/// <param name="m3ZCAC">Zero mark</param>
		/// <param name="m3INSL">Inspection location</param>
		/// <param name="m3NCCA">Net change calculation active</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DDEX">Time phased safety stock exists</param>
		/// <param name="m3STRL">History storage method</param>
		/// <param name="m3PLIC">Picking list information control</param>
		/// <param name="m3PPMC">Pending planning method change</param>
		/// <param name="m3MPCD">Calculation date - material planning</param>
		/// <param name="m3MPCT">Calculation time - material planning</param>
		/// <param name="m3DCSS">Time phased safety stock</param>
		/// <param name="m3RPOP">Responsible - PO proposal</param>
		/// <param name="m3BCOS">Standard cost - warehouse</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3DPLO">Default packing location</param>
		/// <param name="m3DDLO">Default docking location</param>
		/// <param name="m3SPLC">Delivery split rule</param>
		/// <param name="m3ALS1">Allocate non-approved balance ID</param>
		/// <param name="m3POOT">Point of time table</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3MNUN">Main unit of calculation</param>
		/// <param name="m3GRTS">Distribution group technology</param>
		/// <param name="m3SLDY">Shelf life</param>
		/// <param name="m3REDY">Reinspection time</param>
		/// <param name="m3SAEL">Sales time</param>
		/// <param name="m3CPCD">CTP policy</param>
		/// <param name="m3LEAQ">Quarantine lead-time</param>
		/// <param name="m3SCHT">Scheduled re-classification allowed</param>
		/// <param name="m3STCW">Catch weight approved on hand balance</param>
		/// <param name="m3RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3IPLA">Inventory planned</param>
		/// <param name="m3BBTM">Best before time</param>
		/// <param name="m3FSSQ">Frozen safety stock</param>
		/// <param name="m3SSRE">SS reason code</param>
		/// <param name="m3ISEG">Inventory segment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyItmWhs(
			string m3WHLO, 
			string m3ITNO, 
			string m3CWHL, 
			string m3CITN, 
			int? m3CONO = null, 
			decimal? m3STQT = null, 
			decimal? m3QUQT = null, 
			decimal? m3RJQT = null, 
			decimal? m3ALQT = null, 
			decimal? m3AVAL = null, 
			decimal? m3PLQT = null, 
			int? m3COMG = null, 
			int? m3ALMT = null, 
			int? m3STMT = null, 
			int? m3SPMT = null, 
			string m3STTX = null, 
			decimal? m3ORQT = null, 
			decimal? m3REQT = null, 
			decimal? m3RLQT = null, 
			decimal? m3REQP = null, 
			DateTime? m3IDDT = null, 
			DateTime? m3ODDT = null, 
			DateTime? m3INDT = null, 
			int? m3PRDC = null, 
			string m3INCD = null, 
			int? m3NUIN = null, 
			decimal? m3USYE = null, 
			decimal? m3AVST = null, 
			decimal? m3DILE = null, 
			string m3RESP = null, 
			string m3BUYE = null, 
			string m3SUNO = null, 
			string m3WHTY = null, 
			string m3WHSY = null, 
			int? m3INSC = null, 
			string m3DIGR = null, 
			string m3WHSL = null, 
			string m3SLTP = null, 
			int? m3NUS7 = null, 
			decimal? m3TOMU = null, 
			string m3WHLT = null, 
			string m3PISE = null, 
			string m3PLCD = null, 
			string m3MABC = null, 
			string m3ABCD = null, 
			int? m3ABCM = null, 
			string m3ABFC = null, 
			int? m3ABFM = null, 
			string m3ACOC = null, 
			int? m3ACOM = null, 
			int? m3PRIF = null, 
			int? m3SODY = null, 
			decimal? m3REOP = null, 
			int? m3OPOM = null, 
			decimal? m3SSQT = null, 
			int? m3SSMT = null, 
			decimal? m3MSSQ = null, 
			int? m3SSDA = null, 
			int? m3SCGR = null, 
			decimal? m3MXST = null, 
			int? m3MXSM = null, 
			int? m3MXPC = null, 
			decimal? m3EOQT = null, 
			int? m3EOQM = null, 
			int? m3EQDA = null, 
			decimal? m3YEQT = null, 
			int? m3YEQM = null, 
			decimal? m3LOQT = null, 
			decimal? m3MOQT = null, 
			int? m3PUIT = null, 
			string m3SUWH = null, 
			int? m3DPID = null, 
			string m3PRCD = null, 
			string m3FCCM = null, 
			decimal? m3LYQT = null, 
			decimal? m3LRYE = null, 
			int? m3PFTM = null, 
			int? m3LEA1 = null, 
			int? m3LEA2 = null, 
			int? m3LEA3 = null, 
			int? m3LEAT = null, 
			decimal? m3UNMU = null, 
			int? m3SVEI = null, 
			int? m3LEVL = null, 
			int? m3LEVD = null, 
			int? m3PLHZ = null, 
			int? m3DMFN = null, 
			string m3ORTY = null, 
			int? m3CONC = null, 
			int? m3SATD = null, 
			int? m3ALQC = null, 
			int? m3OPLC = null, 
			int? m3MSCH = null, 
			int? m3SHCC = null, 
			int? m3ZCAC = null, 
			string m3INSL = null, 
			int? m3NCCA = null, 
			string m3FACI = null, 
			string m3DIVI = null, 
			int? m3DDEX = null, 
			int? m3STRL = null, 
			int? m3PLIC = null, 
			int? m3PPMC = null, 
			DateTime? m3MPCD = null, 
			int? m3MPCT = null, 
			int? m3DCSS = null, 
			int? m3RPOP = null, 
			decimal? m3BCOS = null, 
			decimal? m3TXID = null, 
			decimal? m3DTID = null, 
			string m3DPLO = null, 
			string m3DDLO = null, 
			string m3SPLC = null, 
			int? m3ALS1 = null, 
			string m3POOT = null, 
			string m3STAT = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			string m3MNUN = null, 
			string m3GRTS = null, 
			int? m3SLDY = null, 
			int? m3REDY = null, 
			int? m3SAEL = null, 
			string m3CPCD = null, 
			int? m3LEAQ = null, 
			int? m3SCHT = null, 
			decimal? m3STCW = null, 
			decimal? m3RJCW = null, 
			decimal? m3QUCW = null, 
			string m3IPLA = null, 
			int? m3BBTM = null, 
			int? m3FSSQ = null, 
			string m3SSRE = null, 
			string m3ISEG = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CWHL))
				throw new ArgumentNullException(nameof(m3CWHL));
			if (string.IsNullOrWhiteSpace(m3CITN))
				throw new ArgumentNullException(nameof(m3CITN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CWHL", m3CWHL.Trim())
				.WithQueryParameter("CITN", m3CITN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STQT.HasValue)
				request.WithQueryParameter("STQT", m3STQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUQT.HasValue)
				request.WithQueryParameter("QUQT", m3QUQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RJQT.HasValue)
				request.WithQueryParameter("RJQT", m3RJQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVAL.HasValue)
				request.WithQueryParameter("AVAL", m3AVAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLQT.HasValue)
				request.WithQueryParameter("PLQT", m3PLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COMG.HasValue)
				request.WithQueryParameter("COMG", m3COMG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALMT.HasValue)
				request.WithQueryParameter("ALMT", m3ALMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STMT.HasValue)
				request.WithQueryParameter("STMT", m3STMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STTX))
				request.WithQueryParameter("STTX", m3STTX.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQT.HasValue)
				request.WithQueryParameter("REQT", m3REQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLQT.HasValue)
				request.WithQueryParameter("RLQT", m3RLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQP.HasValue)
				request.WithQueryParameter("REQP", m3REQP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDDT.HasValue)
				request.WithQueryParameter("IDDT", m3IDDT.Value.ToM3String());
			if (m3ODDT.HasValue)
				request.WithQueryParameter("ODDT", m3ODDT.Value.ToM3String());
			if (m3INDT.HasValue)
				request.WithQueryParameter("INDT", m3INDT.Value.ToM3String());
			if (m3PRDC.HasValue)
				request.WithQueryParameter("PRDC", m3PRDC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INCD))
				request.WithQueryParameter("INCD", m3INCD.Trim());
			if (m3NUIN.HasValue)
				request.WithQueryParameter("NUIN", m3NUIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3USYE.HasValue)
				request.WithQueryParameter("USYE", m3USYE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVST.HasValue)
				request.WithQueryParameter("AVST", m3AVST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DILE.HasValue)
				request.WithQueryParameter("DILE", m3DILE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHTY))
				request.WithQueryParameter("WHTY", m3WHTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSY))
				request.WithQueryParameter("WHSY", m3WHSY.Trim());
			if (m3INSC.HasValue)
				request.WithQueryParameter("INSC", m3INSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIGR))
				request.WithQueryParameter("DIGR", m3DIGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (m3NUS7.HasValue)
				request.WithQueryParameter("NUS7", m3NUS7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOMU.HasValue)
				request.WithQueryParameter("TOMU", m3TOMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLCD))
				request.WithQueryParameter("PLCD", m3PLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MABC))
				request.WithQueryParameter("MABC", m3MABC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (m3ABCM.HasValue)
				request.WithQueryParameter("ABCM", m3ABCM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ABFC))
				request.WithQueryParameter("ABFC", m3ABFC.Trim());
			if (m3ABFM.HasValue)
				request.WithQueryParameter("ABFM", m3ABFM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACOC))
				request.WithQueryParameter("ACOC", m3ACOC.Trim());
			if (m3ACOM.HasValue)
				request.WithQueryParameter("ACOM", m3ACOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRIF.HasValue)
				request.WithQueryParameter("PRIF", m3PRIF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SODY.HasValue)
				request.WithQueryParameter("SODY", m3SODY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REOP.HasValue)
				request.WithQueryParameter("REOP", m3REOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3OPOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3SSQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3SSMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3MSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3SSDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3SCGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXST.HasValue)
				request.WithQueryParameter("MXST", m3MXST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXSM.HasValue)
				request.WithQueryParameter("MXSM", m3MXSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3MXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQT.HasValue)
				request.WithQueryParameter("EOQT", m3EOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3EQDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3YEQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEQM.HasValue)
				request.WithQueryParameter("YEQM", m3YEQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3MOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3PUIT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUWH))
				request.WithQueryParameter("SUWH", m3SUWH.Trim());
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRCD))
				request.WithQueryParameter("PRCD", m3PRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3LYQT.HasValue)
				request.WithQueryParameter("LYQT", m3LYQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LRYE.HasValue)
				request.WithQueryParameter("LRYE", m3LRYE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFTM.HasValue)
				request.WithQueryParameter("PFTM", m3PFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3LEA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA2.HasValue)
				request.WithQueryParameter("LEA2", m3LEA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA3.HasValue)
				request.WithQueryParameter("LEA3", m3LEA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEAT.HasValue)
				request.WithQueryParameter("LEAT", m3LEAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SVEI.HasValue)
				request.WithQueryParameter("SVEI", m3SVEI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3LEVL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEVD.HasValue)
				request.WithQueryParameter("LEVD", m3LEVD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3PLHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DMFN.HasValue)
				request.WithQueryParameter("DMFN", m3DMFN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SATD.HasValue)
				request.WithQueryParameter("SATD", m3SATD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQC.HasValue)
				request.WithQueryParameter("ALQC", m3ALQC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3OPLC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3MSCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHCC.HasValue)
				request.WithQueryParameter("SHCC", m3SHCC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZCAC.HasValue)
				request.WithQueryParameter("ZCAC", m3ZCAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INSL))
				request.WithQueryParameter("INSL", m3INSL.Trim());
			if (m3NCCA.HasValue)
				request.WithQueryParameter("NCCA", m3NCCA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3DDEX.HasValue)
				request.WithQueryParameter("DDEX", m3DDEX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRL.HasValue)
				request.WithQueryParameter("STRL", m3STRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLIC.HasValue)
				request.WithQueryParameter("PLIC", m3PLIC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPMC.HasValue)
				request.WithQueryParameter("PPMC", m3PPMC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MPCD.HasValue)
				request.WithQueryParameter("MPCD", m3MPCD.Value.ToM3String());
			if (m3MPCT.HasValue)
				request.WithQueryParameter("MPCT", m3MPCT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCSS.HasValue)
				request.WithQueryParameter("DCSS", m3DCSS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPOP.HasValue)
				request.WithQueryParameter("RPOP", m3RPOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCOS.HasValue)
				request.WithQueryParameter("BCOS", m3BCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DPLO))
				request.WithQueryParameter("DPLO", m3DPLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DDLO))
				request.WithQueryParameter("DDLO", m3DDLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLC))
				request.WithQueryParameter("SPLC", m3SPLC.Trim());
			if (m3ALS1.HasValue)
				request.WithQueryParameter("ALS1", m3ALS1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POOT))
				request.WithQueryParameter("POOT", m3POOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MNUN))
				request.WithQueryParameter("MNUN", m3MNUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTS))
				request.WithQueryParameter("GRTS", m3GRTS.Trim());
			if (m3SLDY.HasValue)
				request.WithQueryParameter("SLDY", m3SLDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REDY.HasValue)
				request.WithQueryParameter("REDY", m3REDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAEL.HasValue)
				request.WithQueryParameter("SAEL", m3SAEL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CPCD))
				request.WithQueryParameter("CPCD", m3CPCD.Trim());
			if (m3LEAQ.HasValue)
				request.WithQueryParameter("LEAQ", m3LEAQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHT.HasValue)
				request.WithQueryParameter("SCHT", m3SCHT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STCW.HasValue)
				request.WithQueryParameter("STCW", m3STCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3RJCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3QUCW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IPLA))
				request.WithQueryParameter("IPLA", m3IPLA.Trim());
			if (m3BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3BBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3FSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSRE))
				request.WithQueryParameter("SSRE", m3SSRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISEG))
				request.WithQueryParameter("ISEG", m3ISEG.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name DltItm
		/// Description Delete Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItm(
			string m3ITNO, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltItm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name DltItmFac
		/// Description Delete Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItmFac(
			string m3FACI, 
			string m3ITNO, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name DltItmTrplnf
		/// Description Delete Item Transport Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItmTrplnf(
			string m3ITNO, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltItmTrplnf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name DltItmWhs
		/// Description Delete Item Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItmWhs(
			string m3WHLO, 
			string m3ITNO, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name Get
		/// Description Get item basic data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3ITNO, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetAggWhsGrp
		/// Description Get Aggregated Warehouse Group Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAggWhsGrpResponse></returns>
		/// <exception cref="M3Exception<GetAggWhsGrpResponse>"></exception>
		public async Task<M3Response<GetAggWhsGrpResponse>> GetAggWhsGrp(
			int? m3CONO = null, 
			string m3WHGR = null, 
			string m3ITNO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAggWhsGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<GetAggWhsGrpResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmBasic
		/// Description Get Item Basic Data
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmBasicResponse></returns>
		/// <exception cref="M3Exception<GetItmBasicResponse>"></exception>
		public async Task<M3Response<GetItmBasicResponse>> GetItmBasic(
			string m3ITNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetItmBasicResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmCost
		/// Description GetItmCost
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3ATNB">Attribute number lot</param>
		/// <param name="m3CANB">Cost attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmCostResponse></returns>
		/// <exception cref="M3Exception<GetItmCostResponse>"></exception>
		public async Task<M3Response<GetItmCostResponse>> GetItmCost(
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			decimal? m3ATNR = null, 
			decimal? m3ATNB = null, 
			decimal? m3CANB = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmCost",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CANB.HasValue)
				request.WithQueryParameter("CANB", m3CANB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetItmCostResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmFac
		/// Description Get Item Facility
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmFacResponse></returns>
		/// <exception cref="M3Exception<GetItmFacResponse>"></exception>
		public async Task<M3Response<GetItmFacResponse>> GetItmFac(
			string m3FACI, 
			string m3ITNO, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetItmFacResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmMeas
		/// Description Get Item Measurement Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmMeasResponse></returns>
		/// <exception cref="M3Exception<GetItmMeasResponse>"></exception>
		public async Task<M3Response<GetItmMeasResponse>> GetItmMeas(
			string m3ITNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmMeas",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetItmMeasResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmPrice
		/// Description Get Item Price Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmPriceResponse></returns>
		/// <exception cref="M3Exception<GetItmPriceResponse>"></exception>
		public async Task<M3Response<GetItmPriceResponse>> GetItmPrice(
			string m3ITNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetItmPriceResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmTech
		/// Description Get Item Technical Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmTechResponse></returns>
		/// <exception cref="M3Exception<GetItmTechResponse>"></exception>
		public async Task<M3Response<GetItmTechResponse>> GetItmTech(
			string m3ITNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmTech",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetItmTechResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmTrpFrelnf
		/// Description Get Item Transport Information fields A001-A040
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmTrpFrelnfResponse></returns>
		/// <exception cref="M3Exception<GetItmTrpFrelnfResponse>"></exception>
		public async Task<M3Response<GetItmTrpFrelnfResponse>> GetItmTrpFrelnf(
			string m3ITNO, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmTrpFrelnf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<GetItmTrpFrelnfResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmTrplnf
		/// Description Get Item Transport Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmTrplnfResponse></returns>
		/// <exception cref="M3Exception<GetItmTrplnfResponse>"></exception>
		public async Task<M3Response<GetItmTrplnfResponse>> GetItmTrplnf(
			string m3ITNO, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmTrplnf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<GetItmTrplnfResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmWhsBal
		/// Description Get Item Warehouse Balance Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmWhsBalResponse></returns>
		/// <exception cref="M3Exception<GetItmWhsBalResponse>"></exception>
		public async Task<M3Response<GetItmWhsBalResponse>> GetItmWhsBal(
			string m3WHLO, 
			string m3ITNO, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmWhsBal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetItmWhsBalResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmWhsBasic
		/// Description Get Item Warehouse Basic Data
		/// Version Release: 5eaA
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmWhsBasicResponse></returns>
		/// <exception cref="M3Exception<GetItmWhsBasicResponse>"></exception>
		public async Task<M3Response<GetItmWhsBasicResponse>> GetItmWhsBasic(
			string m3WHLO, 
			string m3ITNO, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmWhsBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetItmWhsBasicResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetSumWhsBal
		/// Description Get Summarized Item Warehouse Balance Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3POPN">Alias number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSumWhsBalResponse></returns>
		/// <exception cref="M3Exception<GetSumWhsBalResponse>"></exception>
		public async Task<M3Response<GetSumWhsBalResponse>> GetSumWhsBal(
			string m3WHLO, 
			string m3POPN, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSumWhsBal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3POPN))
				throw new ArgumentNullException(nameof(m3POPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("POPN", m3POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSumWhsBalResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstAUMTime
		/// Description List new/changed Alternate Unit of Measure Items
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAUMTimeResponse></returns>
		/// <exception cref="M3Exception<LstAUMTimeResponse>"></exception>
		public async Task<M3Response<LstAUMTimeResponse>> LstAUMTime(
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAUMTime",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAUMTimeResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstAggWhsGrp
		/// Description Lst Aggretgated Warehouse Group  Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAggWhsGrpResponse></returns>
		/// <exception cref="M3Exception<LstAggWhsGrpResponse>"></exception>
		public async Task<M3Response<LstAggWhsGrpResponse>> LstAggWhsGrp(
			int? m3CONO = null, 
			string m3WHGR = null, 
			string m3ITNO = null, 
			string m3APIP = null, 
			int? m3CRTM = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAggWhsGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAggWhsGrpResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstCustStatNo
		/// Description List Customs statistical number ,CSNO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustStatNoResponse></returns>
		/// <exception cref="M3Exception<LstCustStatNoResponse>"></exception>
		public async Task<M3Response<LstCustStatNoResponse>> LstCustStatNo(
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustStatNo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstCustStatNoResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstDistTechGrp
		/// Description List Distribution group technology
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRTS">From Distribution group technology</param>
		/// <param name="m3TOTS">To Distribution group technology</param>
		/// <param name="m3LMTS">Last imprt´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDistTechGrpResponse></returns>
		/// <exception cref="M3Exception<LstDistTechGrpResponse>"></exception>
		public async Task<M3Response<LstDistTechGrpResponse>> LstDistTechGrp(
			int? m3CONO = null, 
			string m3FRTS = null, 
			string m3TOTS = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDistTechGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRTS))
				request.WithQueryParameter("FRTS", m3FRTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOTS))
				request.WithQueryParameter("TOTS", m3TOTS.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDistTechGrpResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstFacByItem
		/// Description List Facility By Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFacByItemResponse></returns>
		/// <exception cref="M3Exception<LstFacByItemResponse>"></exception>
		public async Task<M3Response<LstFacByItemResponse>> LstFacByItem(
			string m3ITNO, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFacByItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstFacByItemResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstGrpTechClass
		/// Description List Group technology class
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRTC">From Group technology class</param>
		/// <param name="m3TOTC">To Group technology class</param>
		/// <param name="m3LMTS">Last imprt´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstGrpTechClassResponse></returns>
		/// <exception cref="M3Exception<LstGrpTechClassResponse>"></exception>
		public async Task<M3Response<LstGrpTechClassResponse>> LstGrpTechClass(
			int? m3CONO = null, 
			string m3FRTC = null, 
			string m3TOTC = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstGrpTechClass",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRTC))
				request.WithQueryParameter("FRTC", m3FRTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOTC))
				request.WithQueryParameter("TOTC", m3TOTC.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstGrpTechClassResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmAltUnitMs
		/// Description List Item Alternate Unit of Measurement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FITN">From - Item number (Required)</param>
		/// <param name="m3TITN">To - Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FAUT">From - Alternate U/M type</param>
		/// <param name="m3TAUT">To - Alternate U/M type</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3LGUN">Logistics U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmAltUnitMsResponse></returns>
		/// <exception cref="M3Exception<LstItmAltUnitMsResponse>"></exception>
		public async Task<M3Response<LstItmAltUnitMsResponse>> LstItmAltUnitMs(
			string m3FITN, 
			string m3TITN, 
			int? m3CONO = null, 
			int? m3FAUT = null, 
			int? m3TAUT = null, 
			string m3LNCD = null, 
			int? m3LGUN = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmAltUnitMs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FITN))
				throw new ArgumentNullException(nameof(m3FITN));
			if (string.IsNullOrWhiteSpace(m3TITN))
				throw new ArgumentNullException(nameof(m3TITN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FITN", m3FITN.Trim())
				.WithQueryParameter("TITN", m3TITN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FAUT.HasValue)
				request.WithQueryParameter("FAUT", m3FAUT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAUT.HasValue)
				request.WithQueryParameter("TAUT", m3TAUT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3LGUN.HasValue)
				request.WithQueryParameter("LGUN", m3LGUN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstItmAltUnitMsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmByChgDate
		/// Description List Item Basic Data by Change date
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FLMD">From change date</param>
		/// <param name="m3TLMD">To change date</param>
		/// <param name="m3CSDS">Changed since</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmByChgDateResponse></returns>
		/// <exception cref="M3Exception<LstItmByChgDateResponse>"></exception>
		public async Task<M3Response<LstItmByChgDateResponse>> LstItmByChgDate(
			int? m3CONO = null, 
			DateTime? m3FLMD = null, 
			DateTime? m3TLMD = null, 
			int? m3CSDS = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmByChgDate",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLMD.HasValue)
				request.WithQueryParameter("FLMD", m3FLMD.Value.ToM3String());
			if (m3TLMD.HasValue)
				request.WithQueryParameter("TLMD", m3TLMD.Value.ToM3String());
			if (m3CSDS.HasValue)
				request.WithQueryParameter("CSDS", m3CSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmByChgDateResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmByItm
		/// Description List Item Basic Data by Item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3FSTY">From Style number</param>
		/// <param name="m3TSTY">To Style number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmByItmResponse></returns>
		/// <exception cref="M3Exception<LstItmByItmResponse>"></exception>
		public async Task<M3Response<LstItmByItmResponse>> LstItmByItm(
			string m3ITNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? m3CHCD = null, 
			string m3FSTY = null, 
			string m3TSTY = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmByItm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSTY))
				request.WithQueryParameter("FSTY", m3FSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTY))
				request.WithQueryParameter("TSTY", m3TSTY.Trim());

			// Execute the request
			var result = await Execute<LstItmByItmResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmByItmARP
		/// Description List Item Basic Data by Item ARP
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FRIT">Item number (Required)</param>
		/// <param name="m3CHCD">Configuration code (Required)</param>
		/// <param name="m3TOIT">Item number</param>
		/// <param name="m3NORM">Yes/no</param>
		/// <param name="m3FRST">Status</param>
		/// <param name="m3TOST">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmByItmARPResponse></returns>
		/// <exception cref="M3Exception<LstItmByItmARPResponse>"></exception>
		public async Task<M3Response<LstItmByItmARPResponse>> LstItmByItmARP(
			string m3FRIT, 
			int m3CHCD, 
			string m3TOIT = null, 
			int? m3NORM = null, 
			string m3FRST = null, 
			string m3TOST = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmByItmARP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FRIT))
				throw new ArgumentNullException(nameof(m3FRIT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FRIT", m3FRIT.Trim())
				.WithQueryParameter("CHCD", m3CHCD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TOIT))
				request.WithQueryParameter("TOIT", m3TOIT.Trim());
			if (m3NORM.HasValue)
				request.WithQueryParameter("NORM", m3NORM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRST))
				request.WithQueryParameter("FRST", m3FRST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOST))
				request.WithQueryParameter("TOST", m3TOST.Trim());

			// Execute the request
			var result = await Execute<LstItmByItmARPResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmByItmGr
		/// Description List Item Basic Data by Item Group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITGR">Item group (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmByItmGrResponse></returns>
		/// <exception cref="M3Exception<LstItmByItmGrResponse>"></exception>
		public async Task<M3Response<LstItmByItmGrResponse>> LstItmByItmGr(
			string m3ITGR, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmByItmGr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITGR))
				throw new ArgumentNullException(nameof(m3ITGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITGR", m3ITGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmByItmGrResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmByProdGr
		/// Description List Item Basic Data by Product Group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITCL">Product group (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmByProdGrResponse></returns>
		/// <exception cref="M3Exception<LstItmByProdGrResponse>"></exception>
		public async Task<M3Response<LstItmByProdGrResponse>> LstItmByProdGr(
			string m3ITCL, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmByProdGr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITCL))
				throw new ArgumentNullException(nameof(m3ITCL));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITCL", m3ITCL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmByProdGrResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmDescLang
		/// Description List Item Description per Language
		/// Version Release: 14x
		/// </summary>
		/// <param name="m3FITN">From Item number</param>
		/// <param name="m3TITN">To Item number</param>
		/// <param name="m3FLNC">From Language</param>
		/// <param name="m3TLNC">To Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmDescLangResponse></returns>
		/// <exception cref="M3Exception<LstItmDescLangResponse>"></exception>
		public async Task<M3Response<LstItmDescLangResponse>> LstItmDescLang(
			string m3FITN = null, 
			string m3TITN = null, 
			string m3FLNC = null, 
			string m3TLNC = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmDescLang",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FITN))
				request.WithQueryParameter("FITN", m3FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITN))
				request.WithQueryParameter("TITN", m3TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLNC))
				request.WithQueryParameter("FLNC", m3FLNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLNC))
				request.WithQueryParameter("TLNC", m3TLNC.Trim());

			// Execute the request
			var result = await Execute<LstItmDescLangResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmFac
		/// Description List Item Facility
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmFacResponse></returns>
		/// <exception cref="M3Exception<LstItmFacResponse>"></exception>
		public async Task<M3Response<LstItmFacResponse>> LstItmFac(
			string m3FACI, 
			string m3ITNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmFacResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmFacTime
		/// Description List Items per Facility with timestamp
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmFacTimeResponse></returns>
		/// <exception cref="M3Exception<LstItmFacTimeResponse>"></exception>
		public async Task<M3Response<LstItmFacTimeResponse>> LstItmFacTime(
			string m3FACI = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmFacTime",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstItmFacTimeResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmFreeFld1
		/// Description List Item free field 1
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FCF1">From Item free field 1</param>
		/// <param name="m3TCF1">To Item free field 1</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmFreeFld1Response></returns>
		/// <exception cref="M3Exception<LstItmFreeFld1Response>"></exception>
		public async Task<M3Response<LstItmFreeFld1Response>> LstItmFreeFld1(
			int? m3CONO = null, 
			string m3FCF1 = null, 
			string m3TCF1 = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmFreeFld1",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCF1))
				request.WithQueryParameter("FCF1", m3FCF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCF1))
				request.WithQueryParameter("TCF1", m3TCF1.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstItmFreeFld1Response>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmFreeFld3
		/// Description List Item free field 3
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FCF3">From Item free field 3</param>
		/// <param name="m3TCF3">To Item free field 3</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmFreeFld3Response></returns>
		/// <exception cref="M3Exception<LstItmFreeFld3Response>"></exception>
		public async Task<M3Response<LstItmFreeFld3Response>> LstItmFreeFld3(
			int? m3CONO = null, 
			string m3FCF3 = null, 
			string m3TCF3 = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmFreeFld3",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCF3))
				request.WithQueryParameter("FCF3", m3FCF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCF3))
				request.WithQueryParameter("TCF3", m3TCF3.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstItmFreeFld3Response>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmFreeFld4
		/// Description List Item free field 4
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FCF4">From Item free field 4</param>
		/// <param name="m3TCF4">To Item free field 4</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmFreeFld4Response></returns>
		/// <exception cref="M3Exception<LstItmFreeFld4Response>"></exception>
		public async Task<M3Response<LstItmFreeFld4Response>> LstItmFreeFld4(
			int? m3CONO = null, 
			string m3FCF4 = null, 
			string m3TCF4 = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmFreeFld4",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCF4))
				request.WithQueryParameter("FCF4", m3FCF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCF4))
				request.WithQueryParameter("TCF4", m3TCF4.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstItmFreeFld4Response>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmGroups
		/// Description List Item Groups
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmGroupsResponse></returns>
		/// <exception cref="M3Exception<LstItmGroupsResponse>"></exception>
		public async Task<M3Response<LstItmGroupsResponse>> LstItmGroups(
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmGroups",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmGroupsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmPrice
		/// Description List Item Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmPriceResponse></returns>
		/// <exception cref="M3Exception<LstItmPriceResponse>"></exception>
		public async Task<M3Response<LstItmPriceResponse>> LstItmPrice(
			string m3ITNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmPriceResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmWhsByItm
		/// Description List Item Warehouse By Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmWhsByItmResponse></returns>
		/// <exception cref="M3Exception<LstItmWhsByItmResponse>"></exception>
		public async Task<M3Response<LstItmWhsByItmResponse>> LstItmWhsByItm(
			int? m3CONO = null, 
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmWhsByItm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmWhsByItmResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmWhsByRel
		/// Description List Item Warehouse By Relation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3RPTY">Replacement type</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmWhsByRelResponse></returns>
		/// <exception cref="M3Exception<LstItmWhsByRelResponse>"></exception>
		public async Task<M3Response<LstItmWhsByRelResponse>> LstItmWhsByRel(
			int? m3CONO = null, 
			string m3ITNO = null, 
			int? m3RPTY = null, 
			string m3WHLO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmWhsByRel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3RPTY.HasValue)
				request.WithQueryParameter("RPTY", m3RPTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmWhsByRelResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmWhsByWhgr
		/// Description LstItmWhsByWhgr
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3WHGR">Warehouse group (Required)</param>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="m3INZO">Include zero</param>
		/// <param name="m3ITT1">Item type</param>
		/// <param name="m3ITT2">Item type</param>
		/// <param name="m3ITT3">Item type</param>
		/// <param name="m3ITT4">Item type</param>
		/// <param name="m3ITT5">Item type</param>
		/// <param name="m3ITT6">Item type</param>
		/// <param name="m3ITT7">Item type</param>
		/// <param name="m3ITT8">Item type</param>
		/// <param name="m3ITT9">Item type</param>
		/// <param name="m3ITT0">Item type</param>
		/// <param name="m3SUN1">Supplier</param>
		/// <param name="m3SUN2">Supplier</param>
		/// <param name="m3SUN3">Supplier</param>
		/// <param name="m3SUN4">Supplier</param>
		/// <param name="m3SUN5">Supplier</param>
		/// <param name="m3SUN6">Supplier</param>
		/// <param name="m3SUN7">Supplier</param>
		/// <param name="m3SUN8">Supplier</param>
		/// <param name="m3SUN9">Supplier</param>
		/// <param name="m3SUN0">Supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmWhsByWhgrResponse></returns>
		/// <exception cref="M3Exception<LstItmWhsByWhgrResponse>"></exception>
		public async Task<M3Response<LstItmWhsByWhgrResponse>> LstItmWhsByWhgr(
			string m3WHGR, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			int? m3INZO = null, 
			string m3ITT1 = null, 
			string m3ITT2 = null, 
			string m3ITT3 = null, 
			string m3ITT4 = null, 
			string m3ITT5 = null, 
			string m3ITT6 = null, 
			string m3ITT7 = null, 
			string m3ITT8 = null, 
			string m3ITT9 = null, 
			string m3ITT0 = null, 
			string m3SUN1 = null, 
			string m3SUN2 = null, 
			string m3SUN3 = null, 
			string m3SUN4 = null, 
			string m3SUN5 = null, 
			string m3SUN6 = null, 
			string m3SUN7 = null, 
			string m3SUN8 = null, 
			string m3SUN9 = null, 
			string m3SUN0 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmWhsByWhgr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHGR))
				throw new ArgumentNullException(nameof(m3WHGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3INZO.HasValue)
				request.WithQueryParameter("INZO", m3INZO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITT1))
				request.WithQueryParameter("ITT1", m3ITT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITT2))
				request.WithQueryParameter("ITT2", m3ITT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITT3))
				request.WithQueryParameter("ITT3", m3ITT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITT4))
				request.WithQueryParameter("ITT4", m3ITT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITT5))
				request.WithQueryParameter("ITT5", m3ITT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITT6))
				request.WithQueryParameter("ITT6", m3ITT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITT7))
				request.WithQueryParameter("ITT7", m3ITT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITT8))
				request.WithQueryParameter("ITT8", m3ITT8.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITT9))
				request.WithQueryParameter("ITT9", m3ITT9.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITT0))
				request.WithQueryParameter("ITT0", m3ITT0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUN1))
				request.WithQueryParameter("SUN1", m3SUN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUN2))
				request.WithQueryParameter("SUN2", m3SUN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUN3))
				request.WithQueryParameter("SUN3", m3SUN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUN4))
				request.WithQueryParameter("SUN4", m3SUN4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUN5))
				request.WithQueryParameter("SUN5", m3SUN5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUN6))
				request.WithQueryParameter("SUN6", m3SUN6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUN7))
				request.WithQueryParameter("SUN7", m3SUN7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUN8))
				request.WithQueryParameter("SUN8", m3SUN8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUN9))
				request.WithQueryParameter("SUN9", m3SUN9.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUN0))
				request.WithQueryParameter("SUN0", m3SUN0.Trim());

			// Execute the request
			var result = await Execute<LstItmWhsByWhgrResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmWhsByWhs
		/// Description List Item Warehouse By Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmWhsByWhsResponse></returns>
		/// <exception cref="M3Exception<LstItmWhsByWhsResponse>"></exception>
		public async Task<M3Response<LstItmWhsByWhsResponse>> LstItmWhsByWhs(
			int? m3CONO = null, 
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmWhsByWhs",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmWhsByWhsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstProdGroups
		/// Description List Product Groups
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProdGroupsResponse></returns>
		/// <exception cref="M3Exception<LstProdGroupsResponse>"></exception>
		public async Task<M3Response<LstProdGroupsResponse>> LstProdGroups(
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstProdGroups",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstProdGroupsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstStyle
		/// Description List Style
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleResponse></returns>
		/// <exception cref="M3Exception<LstStyleResponse>"></exception>
		public async Task<M3Response<LstStyleResponse>> LstStyle(
			string m3STYN, 
			string m3ITNO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStyle",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstStyleResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstSumWhsBal
		/// Description List Summarized Item Warehouse Balance Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3POPN">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3INVF">Filter For Non Zero Inventory</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSumWhsBalResponse></returns>
		/// <exception cref="M3Exception<LstSumWhsBalResponse>"></exception>
		public async Task<M3Response<LstSumWhsBalResponse>> LstSumWhsBal(
			string m3WHLO, 
			string m3POPN, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			int? m3INVF = null, 
			int? m3CHCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSumWhsBal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3POPN))
				throw new ArgumentNullException(nameof(m3POPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("POPN", m3POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3INVF.HasValue)
				request.WithQueryParameter("INVF", m3INVF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSumWhsBalResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name PrtItemLabel
		/// Description Print Item Label
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3DEV0">Printer</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrtItemLabel(
			string m3ITNO = null, 
			string m3LNCD = null, 
			string m3DEV0 = null, 
			int? m3COPY = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrtItemLabel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEV0))
				request.WithQueryParameter("DEV0", m3DEV0.Trim());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SearchItem
		/// Description Search for an item via LES.
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchItemResponse></returns>
		/// <exception cref="M3Exception<SearchItemResponse>"></exception>
		public async Task<M3Response<SearchItemResponse>> SearchItem(
			string m3SQRY, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchItemResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SearchItemWhs
		/// Description SearchItemWhs
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchItemWhsResponse></returns>
		/// <exception cref="M3Exception<SearchItemWhsResponse>"></exception>
		public async Task<M3Response<SearchItemWhsResponse>> SearchItemWhs(
			string m3SQRY, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchItemWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchItemWhsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItem
		/// Description Retrieve basic information about an item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRIT">From Item Number</param>
		/// <param name="m3TOIT">To Item Number</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="m3LMTS">Last import timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItemResponse></returns>
		/// <exception cref="M3Exception<SelItemResponse>"></exception>
		public async Task<M3Response<SelItemResponse>> SelItem(
			int? m3CONO = null, 
			string m3FRIT = null, 
			string m3TOIT = null, 
			DateTime? m3LMDT = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRIT))
				request.WithQueryParameter("FRIT", m3FRIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOIT))
				request.WithQueryParameter("TOIT", m3TOIT.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelItemResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItemGroup
		/// Description Select Item Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRIT">From Item Type</param>
		/// <param name="m3TOIT">To Item Type</param>
		/// <param name="m3LMTS">Last import timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItemGroupResponse></returns>
		/// <exception cref="M3Exception<SelItemGroupResponse>"></exception>
		public async Task<M3Response<SelItemGroupResponse>> SelItemGroup(
			int? m3CONO = null, 
			string m3FRIT = null, 
			string m3TOIT = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelItemGroup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRIT))
				request.WithQueryParameter("FRIT", m3FRIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOIT))
				request.WithQueryParameter("TOIT", m3TOIT.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelItemGroupResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItemType
		/// Description Select Item Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRIT">From Item Type</param>
		/// <param name="m3TOIT">To Item Type</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="m3LMTS">Last import timestamp</param>
		/// <param name="m3FRST">From Status</param>
		/// <param name="m3TOST">To Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItemTypeResponse></returns>
		/// <exception cref="M3Exception<SelItemTypeResponse>"></exception>
		public async Task<M3Response<SelItemTypeResponse>> SelItemType(
			int? m3CONO = null, 
			string m3FRIT = null, 
			string m3TOIT = null, 
			DateTime? m3LMDT = null, 
			decimal? m3LMTS = null, 
			string m3FRST = null, 
			string m3TOST = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelItemType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRIT))
				request.WithQueryParameter("FRIT", m3FRIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOIT))
				request.WithQueryParameter("TOIT", m3TOIT.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRST))
				request.WithQueryParameter("FRST", m3FRST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOST))
				request.WithQueryParameter("TOST", m3TOST.Trim());

			// Execute the request
			var result = await Execute<SelItemTypeResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItemWhs
		/// Description Retrieve basic information for item warehouse interface
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3TWHL">To warehouse</param>
		/// <param name="m3FRIT">From Item Number</param>
		/// <param name="m3TOIT">To Item Number</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="m3LMTS">Last import timestamp</param>
		/// <param name="m3SESO">Seasonal item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItemWhsResponse></returns>
		/// <exception cref="M3Exception<SelItemWhsResponse>"></exception>
		public async Task<M3Response<SelItemWhsResponse>> SelItemWhs(
			int? m3CONO = null, 
			string m3FWHL = null, 
			string m3TWHL = null, 
			string m3FRIT = null, 
			string m3TOIT = null, 
			DateTime? m3LMDT = null, 
			decimal? m3LMTS = null, 
			int? m3SESO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelItemWhs",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRIT))
				request.WithQueryParameter("FRIT", m3FRIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOIT))
				request.WithQueryParameter("TOIT", m3TOIT.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SESO.HasValue)
				request.WithQueryParameter("SESO", m3SESO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelItemWhsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItmMercia
		/// Description Retrieve basic information about an item for Mercia
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRIT">From Item Number</param>
		/// <param name="m3TOIT">To Item Number</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItmMerciaResponse></returns>
		/// <exception cref="M3Exception<SelItmMerciaResponse>"></exception>
		public async Task<M3Response<SelItmMerciaResponse>> SelItmMercia(
			int? m3CONO = null, 
			string m3FRIT = null, 
			string m3TOIT = null, 
			DateTime? m3LMDT = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelItmMercia",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRIT))
				request.WithQueryParameter("FRIT", m3FRIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOIT))
				request.WithQueryParameter("TOIT", m3TOIT.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<SelItmMerciaResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItmWhsMercia
		/// Description Select Item - Warehouse data for Mercia
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItmWhsMerciaResponse></returns>
		/// <exception cref="M3Exception<SelItmWhsMerciaResponse>"></exception>
		public async Task<M3Response<SelItmWhsMerciaResponse>> SelItmWhsMercia(
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3WHLO = null, 
			DateTime? m3LMDT = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelItmWhsMercia",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<SelItmWhsMerciaResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelProdGroup
		/// Description Select Prod Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRPG">From Product group</param>
		/// <param name="m3TOPG">To Product group</param>
		/// <param name="m3LMTS">Last import timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelProdGroupResponse></returns>
		/// <exception cref="M3Exception<SelProdGroupResponse>"></exception>
		public async Task<M3Response<SelProdGroupResponse>> SelProdGroup(
			int? m3CONO = null, 
			string m3FRPG = null, 
			string m3TOPG = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelProdGroup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRPG))
				request.WithQueryParameter("FRPG", m3FRPG.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOPG))
				request.WithQueryParameter("TOPG", m3TOPG.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelProdGroupResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SndInvDtaMercia
		/// Description Update inventory data from Mercia
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3REOP">Reorder point</param>
		/// <param name="m3OPOM">Reorder point method</param>
		/// <param name="m3SSQT">Safety stock</param>
		/// <param name="m3SSMT">Safety stock method</param>
		/// <param name="m3SSDA">Safety stock unit</param>
		/// <param name="m3FSSQ">Frozen safety stock</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInvDtaMercia(
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3WHLO = null, 
			decimal? m3REOP = null, 
			int? m3OPOM = null, 
			decimal? m3SSQT = null, 
			int? m3SSMT = null, 
			int? m3SSDA = null, 
			int? m3FSSQ = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndInvDtaMercia",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3REOP.HasValue)
				request.WithQueryParameter("REOP", m3REOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3OPOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3SSQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3SSMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3SSDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3FSSQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SndItmDesc
		/// Description Send Item Description to OTRSMS
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndItmDesc(
			int? m3CONO = null, 
			DateTime? m3LMDT = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndItmDesc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmBasic
		/// Description Update Item Basic
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3BUAR">Business area</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3TPCD">Item category</param>
		/// <param name="m3MABU">Make/buy code</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3BACD">Lot numbering method</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3BYPR">By/co-product code</param>
		/// <param name="m3WAPC">Normal waste percentage</param>
		/// <param name="m3QACD">Inspection code</param>
		/// <param name="m3EPCD">Yield calculation</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3ACTI">Active or catch weight item</param>
		/// <param name="m3HIE1">Hierachy level 1</param>
		/// <param name="m3HIE2">Hierachy level 2</param>
		/// <param name="m3HIE3">Hierachy level 3</param>
		/// <param name="m3HIE4">Hierachy level 4</param>
		/// <param name="m3HIE5">Hierachy level 5</param>
		/// <param name="m3GRP1">Search group 1</param>
		/// <param name="m3GRP2">Search group 2</param>
		/// <param name="m3GRP3">Search group 3</param>
		/// <param name="m3GRP4">Search group 4</param>
		/// <param name="m3GRP5">Search group 5</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3ECMA">ECO managed</param>
		/// <param name="m3PRGP">Procurement group</param>
		/// <param name="m3INDI">Lot control method</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3ALUC">Alternate U/M in use</param>
		/// <param name="m3IEAA">Item exists as alias identity</param>
		/// <param name="m3EXPD">Expiration date method</param>
		/// <param name="m3GRMT">Goods receiving method</param>
		/// <param name="m3HAZI">Danger indicator</param>
		/// <param name="m3SALE">Sales item</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="m3ATMN">Attribute managed</param>
		/// <param name="m3TPLI">Template item number</param>
		/// <param name="m3FCU1">Estimated consumption free capacity unit</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3IACP">Attribute-controlled item</param>
		/// <param name="m3HDPR">Main product</param>
		/// <param name="m3AAD0">Extended QA used</param>
		/// <param name="m3AAD1">Generate txt from text template</param>
		/// <param name="m3CHCL">Charge calculation</param>
		/// <param name="m3ITRC">Individual item tracing</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3GRTI">Group technology class</param>
		/// <param name="m3GRTS">Distribution group technology</param>
		/// <param name="m3ETRF">External instruction</param>
		/// <param name="m3CAWP">Catch weight mode</param>
		/// <param name="m3CWUN">Catch weight unit of measure</param>
		/// <param name="m3CPUN">Standard cost price unit of measure</param>
		/// <param name="m3DSP1">Update item-warehouse</param>
		/// <param name="m3EVGR">Environment group</param>
		/// <param name="m3ILEN">Length</param>
		/// <param name="m3IWID">Width</param>
		/// <param name="m3IHEI">Height</param>
		/// <param name="m3ITRU">Included in territorial roll-up</param>
		/// <param name="m3TECR">Core terms</param>
		/// <param name="m3EXCA">Exchangeable</param>
		/// <param name="m3ACCG">Acceptance group</param>
		/// <param name="m3CCCM">Costing model - core charge</param>
		/// <param name="m3CCI1">Core charge item number</param>
		/// <param name="m3CRI1">Core remain item number</param>
		/// <param name="m3HVMT">Harvest Method</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3ITNE">Extended item number</param>
		/// <param name="m3SPGV">Specific gravity</param>
		/// <param name="m3AUTC">Issue message</param>
		/// <param name="m3RIDE">Reference identity</param>
		/// <param name="m3RIDC">Reference identity code</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3SAFC">Suppliers ABC code</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3PDLN">Product line</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3ITRF">Internal instruction</param>
		/// <param name="m3SUME">Sublot method</param>
		/// <param name="m3SUMP">Sublot policy</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmBasic(
			string m3ITNO, 
			int? m3CONO = null, 
			string m3STAT = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3DWNO = null, 
			string m3RESP = null, 
			string m3UNMS = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3BUAR = null, 
			string m3ITTY = null, 
			int? m3TPCD = null, 
			int? m3MABU = null, 
			int? m3CHCD = null, 
			int? m3STCD = null, 
			int? m3BACD = null, 
			decimal? m3VOL3 = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			int? m3BYPR = null, 
			int? m3WAPC = null, 
			int? m3QACD = null, 
			int? m3EPCD = null, 
			int? m3POCY = null, 
			int? m3ACTI = null, 
			string m3HIE1 = null, 
			string m3HIE2 = null, 
			string m3HIE3 = null, 
			string m3HIE4 = null, 
			string m3HIE5 = null, 
			string m3GRP1 = null, 
			string m3GRP2 = null, 
			string m3GRP3 = null, 
			string m3GRP4 = null, 
			string m3GRP5 = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			decimal? m3TXID = null, 
			int? m3ECMA = null, 
			string m3PRGP = null, 
			int? m3INDI = null, 
			string m3PUUN = null, 
			int? m3ALUC = null, 
			int? m3IEAA = null, 
			int? m3EXPD = null, 
			string m3GRMT = null, 
			int? m3HAZI = null, 
			int? m3SALE = null, 
			string m3TAXC = null, 
			string m3ATMO = null, 
			int? m3ATMN = null, 
			string m3TPLI = null, 
			decimal? m3FCU1 = null, 
			string m3ALUN = null, 
			int? m3IACP = null, 
			string m3HDPR = null, 
			int? m3AAD0 = null, 
			int? m3AAD1 = null, 
			int? m3CHCL = null, 
			int? m3ITRC = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			string m3ECVE = null, 
			string m3GRTI = null, 
			string m3GRTS = null, 
			string m3ETRF = null, 
			int? m3CAWP = null, 
			string m3CWUN = null, 
			string m3CPUN = null, 
			int? m3DSP1 = null, 
			string m3EVGR = null, 
			int? m3ILEN = null, 
			int? m3IWID = null, 
			int? m3IHEI = null, 
			int? m3ITRU = null, 
			string m3TECR = null, 
			int? m3EXCA = null, 
			string m3ACCG = null, 
			string m3CCCM = null, 
			string m3CCI1 = null, 
			string m3CRI1 = null, 
			int? m3HVMT = null, 
			string m3ACRF = null, 
			string m3ITNE = null, 
			decimal? m3SPGV = null, 
			int? m3AUTC = null, 
			string m3RIDE = null, 
			int? m3RIDC = null, 
			int? m3RNRI = null, 
			string m3SAFC = null, 
			int? m3RMSG = null, 
			string m3PDLN = null, 
			string m3CPGR = null, 
			string m3ITRF = null, 
			int? m3SUME = null, 
			string m3SUMP = null, 
			string m3QMGP = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItmBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUAR))
				request.WithQueryParameter("BUAR", m3BUAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (m3TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3TPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MABU.HasValue)
				request.WithQueryParameter("MABU", m3MABU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACD.HasValue)
				request.WithQueryParameter("BACD", m3BACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3BYPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3WAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QACD.HasValue)
				request.WithQueryParameter("QACD", m3QACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EPCD.HasValue)
				request.WithQueryParameter("EPCD", m3EPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3ACTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HIE1))
				request.WithQueryParameter("HIE1", m3HIE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE2))
				request.WithQueryParameter("HIE2", m3HIE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE3))
				request.WithQueryParameter("HIE3", m3HIE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE4))
				request.WithQueryParameter("HIE4", m3HIE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3HIE5))
				request.WithQueryParameter("HIE5", m3HIE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP1))
				request.WithQueryParameter("GRP1", m3GRP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP2))
				request.WithQueryParameter("GRP2", m3GRP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP3))
				request.WithQueryParameter("GRP3", m3GRP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP4))
				request.WithQueryParameter("GRP4", m3GRP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP5))
				request.WithQueryParameter("GRP5", m3GRP5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI1))
				request.WithQueryParameter("CFI1", m3CFI1.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI4))
				request.WithQueryParameter("CFI4", m3CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI5))
				request.WithQueryParameter("CFI5", m3CFI5.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3ECMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRGP))
				request.WithQueryParameter("PRGP", m3PRGP.Trim());
			if (m3INDI.HasValue)
				request.WithQueryParameter("INDI", m3INDI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (m3ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3ALUC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IEAA.HasValue)
				request.WithQueryParameter("IEAA", m3IEAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3EXPD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (m3HAZI.HasValue)
				request.WithQueryParameter("HAZI", m3HAZI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SALE.HasValue)
				request.WithQueryParameter("SALE", m3SALE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());
			if (m3ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3ATMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TPLI))
				request.WithQueryParameter("TPLI", m3TPLI.Trim());
			if (m3FCU1.HasValue)
				request.WithQueryParameter("FCU1", m3FCU1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3IACP.HasValue)
				request.WithQueryParameter("IACP", m3IACP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HDPR))
				request.WithQueryParameter("HDPR", m3HDPR.Trim());
			if (m3AAD0.HasValue)
				request.WithQueryParameter("AAD0", m3AAD0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AAD1.HasValue)
				request.WithQueryParameter("AAD1", m3AAD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHCL.HasValue)
				request.WithQueryParameter("CHCL", m3CHCL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITRC.HasValue)
				request.WithQueryParameter("ITRC", m3ITRC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTI))
				request.WithQueryParameter("GRTI", m3GRTI.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTS))
				request.WithQueryParameter("GRTS", m3GRTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETRF))
				request.WithQueryParameter("ETRF", m3ETRF.Trim());
			if (m3CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3CAWP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CWUN))
				request.WithQueryParameter("CWUN", m3CWUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPUN))
				request.WithQueryParameter("CPUN", m3CPUN.Trim());
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVGR))
				request.WithQueryParameter("EVGR", m3EVGR.Trim());
			if (m3ILEN.HasValue)
				request.WithQueryParameter("ILEN", m3ILEN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IWID.HasValue)
				request.WithQueryParameter("IWID", m3IWID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IHEI.HasValue)
				request.WithQueryParameter("IHEI", m3IHEI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3ITRU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECR))
				request.WithQueryParameter("TECR", m3TECR.Trim());
			if (m3EXCA.HasValue)
				request.WithQueryParameter("EXCA", m3EXCA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACCG))
				request.WithQueryParameter("ACCG", m3ACCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCCM))
				request.WithQueryParameter("CCCM", m3CCCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCI1))
				request.WithQueryParameter("CCI1", m3CCI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRI1))
				request.WithQueryParameter("CRI1", m3CRI1.Trim());
			if (m3HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3HVMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNE))
				request.WithQueryParameter("ITNE", m3ITNE.Trim());
			if (m3SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3SPGV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUTC.HasValue)
				request.WithQueryParameter("AUTC", m3AUTC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDE))
				request.WithQueryParameter("RIDE", m3RIDE.Trim());
			if (m3RIDC.HasValue)
				request.WithQueryParameter("RIDC", m3RIDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SAFC))
				request.WithQueryParameter("SAFC", m3SAFC.Trim());
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PDLN))
				request.WithQueryParameter("PDLN", m3PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITRF))
				request.WithQueryParameter("ITRF", m3ITRF.Trim());
			if (m3SUME.HasValue)
				request.WithQueryParameter("SUME", m3SUME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUMP))
				request.WithQueryParameter("SUMP", m3SUMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmFac
		/// Description Update Item Facility
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LEA4">Administrative lead time</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3SPFA">Conversion factor supplementary U/M</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3APPR">Average cost</param>
		/// <param name="m3UCOS">Cost price</param>
		/// <param name="m3SOCO">Ordering cost</param>
		/// <param name="m3EXPC">Yield percentage</param>
		/// <param name="m3BQTY">Batch quantity</param>
		/// <param name="m3BQTM">Batch quantity method</param>
		/// <param name="m3LLCM">Lowest level - BoM</param>
		/// <param name="m3DLET">MO lead time method</param>
		/// <param name="m3DLEF">Dynamic lead time fence - MO</param>
		/// <param name="m3DIDY">Flow order planning</param>
		/// <param name="m3DIDF">Flow order fence</param>
		/// <param name="m3PRRA">Production rate</param>
		/// <param name="m3TRHC">Throughput rate of capacity/day</param>
		/// <param name="m3MARC">MO reservations</param>
		/// <param name="m3JITF">Orderless production</param>
		/// <param name="m3REWH">Main warehouse</param>
		/// <param name="m3OPFQ">Optimal on-hand balance - facility</param>
		/// <param name="m3FANO">On-hand balance - facility</param>
		/// <param name="m3FANQ">On-hand balance for inspection -facility</param>
		/// <param name="m3FANR">Rejected on-hand balance - facility</param>
		/// <param name="m3FATM">On-hand balance method - facility</param>
		/// <param name="m3WCLN">Production line</param>
		/// <param name="m3EDEC">Method for expiry date excess control</param>
		/// <param name="m3AUGE">Automatic creation of MO</param>
		/// <param name="m3ECCC">Consumption code - trade stat (TST)</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3CPRI">Customs procedure - import</param>
		/// <param name="m3CPRE">Customs procedure - export</param>
		/// <param name="m3WSCA">Costing model - purchasing</param>
		/// <param name="m3PRCM">Costing model - product costing</param>
		/// <param name="m3PLAP">Planning process</param>
		/// <param name="m3PLUP">Push process</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3CPL0">Calculate price for line type 0</param>
		/// <param name="m3CPL1">Calculate price for line type 1</param>
		/// <param name="m3CPL2">Calculate price for line type 2</param>
		/// <param name="m3PPL0">Preliminary price for line type 0</param>
		/// <param name="m3PPL1">Preliminary price for line type 1</param>
		/// <param name="m3PPL2">Preliminary price for line type 2</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3CPDC">Costing decimal places</param>
		/// <param name="m3COCD">Item cost quantity</param>
		/// <param name="m3EVGR">Environment group</param>
		/// <param name="m3VAMT">Inventory accounting method</param>
		/// <param name="m3LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3GRTI">Group technology class</param>
		/// <param name="m3MOLL">MO leadtime limit</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3DICM">Costing model - distribution</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3STCW">Catch weight approved on hand balance</param>
		/// <param name="m3RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3CAWC">Catch weight cost</param>
		/// <param name="m3CPUN">Standard cost price unit of measure</param>
		/// <param name="m3COFA">Conversion factor</param>
		/// <param name="m3ALTS">Alternate structures</param>
		/// <param name="m3ATTC">Average costing per attribute</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmFac(
			string m3FACI, 
			string m3ITNO, 
			int? m3CONO = null, 
			int? m3LEA4 = null, 
			string m3CSNO = null, 
			decimal? m3SPFA = null, 
			string m3ORCO = null, 
			decimal? m3APPR = null, 
			decimal? m3UCOS = null, 
			decimal? m3SOCO = null, 
			int? m3EXPC = null, 
			decimal? m3BQTY = null, 
			int? m3BQTM = null, 
			int? m3LLCM = null, 
			int? m3DLET = null, 
			int? m3DLEF = null, 
			int? m3DIDY = null, 
			int? m3DIDF = null, 
			int? m3PRRA = null, 
			int? m3TRHC = null, 
			int? m3MARC = null, 
			int? m3JITF = null, 
			string m3REWH = null, 
			decimal? m3OPFQ = null, 
			decimal? m3FANO = null, 
			decimal? m3FANQ = null, 
			decimal? m3FANR = null, 
			int? m3FATM = null, 
			string m3WCLN = null, 
			string m3EDEC = null, 
			int? m3AUGE = null, 
			string m3ECCC = null, 
			string m3ECAR = null, 
			string m3CPRI = null, 
			string m3CPRE = null, 
			string m3WSCA = null, 
			string m3PRCM = null, 
			string m3PLAP = null, 
			string m3PLUP = null, 
			string m3SCMO = null, 
			int? m3CPL0 = null, 
			int? m3CPL1 = null, 
			int? m3CPL2 = null, 
			int? m3PPL0 = null, 
			int? m3PPL1 = null, 
			int? m3PPL2 = null, 
			decimal? m3TXID = null, 
			decimal? m3DTID = null, 
			int? m3CPDC = null, 
			int? m3COCD = null, 
			string m3EVGR = null, 
			int? m3VAMT = null, 
			int? m3LAMA = null, 
			string m3GRTI = null, 
			int? m3MOLL = null, 
			int? m3CRTM = null, 
			string m3DICM = null, 
			string m3ACRF = null, 
			decimal? m3STCW = null, 
			decimal? m3RJCW = null, 
			decimal? m3QUCW = null, 
			int? m3CAWC = null, 
			string m3CPUN = null, 
			decimal? m3COFA = null, 
			int? m3ALTS = null, 
			int? m3ATTC = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3LEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (m3SPFA.HasValue)
				request.WithQueryParameter("SPFA", m3SPFA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3APPR.HasValue)
				request.WithQueryParameter("APPR", m3APPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOCO.HasValue)
				request.WithQueryParameter("SOCO", m3SOCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3EXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BQTY.HasValue)
				request.WithQueryParameter("BQTY", m3BQTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BQTM.HasValue)
				request.WithQueryParameter("BQTM", m3BQTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LLCM.HasValue)
				request.WithQueryParameter("LLCM", m3LLCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLET.HasValue)
				request.WithQueryParameter("DLET", m3DLET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLEF.HasValue)
				request.WithQueryParameter("DLEF", m3DLEF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIDY.HasValue)
				request.WithQueryParameter("DIDY", m3DIDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIDF.HasValue)
				request.WithQueryParameter("DIDF", m3DIDF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRRA.HasValue)
				request.WithQueryParameter("PRRA", m3PRRA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRHC.HasValue)
				request.WithQueryParameter("TRHC", m3TRHC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MARC.HasValue)
				request.WithQueryParameter("MARC", m3MARC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JITF.HasValue)
				request.WithQueryParameter("JITF", m3JITF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REWH))
				request.WithQueryParameter("REWH", m3REWH.Trim());
			if (m3OPFQ.HasValue)
				request.WithQueryParameter("OPFQ", m3OPFQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FANO.HasValue)
				request.WithQueryParameter("FANO", m3FANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FANQ.HasValue)
				request.WithQueryParameter("FANQ", m3FANQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FANR.HasValue)
				request.WithQueryParameter("FANR", m3FANR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FATM.HasValue)
				request.WithQueryParameter("FATM", m3FATM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WCLN))
				request.WithQueryParameter("WCLN", m3WCLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDEC))
				request.WithQueryParameter("EDEC", m3EDEC.Trim());
			if (m3AUGE.HasValue)
				request.WithQueryParameter("AUGE", m3AUGE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECCC))
				request.WithQueryParameter("ECCC", m3ECCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPRI))
				request.WithQueryParameter("CPRI", m3CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPRE))
				request.WithQueryParameter("CPRE", m3CPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRCM))
				request.WithQueryParameter("PRCM", m3PRCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLAP))
				request.WithQueryParameter("PLAP", m3PLAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLUP))
				request.WithQueryParameter("PLUP", m3PLUP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (m3CPL0.HasValue)
				request.WithQueryParameter("CPL0", m3CPL0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPL1.HasValue)
				request.WithQueryParameter("CPL1", m3CPL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPL2.HasValue)
				request.WithQueryParameter("CPL2", m3CPL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPL0.HasValue)
				request.WithQueryParameter("PPL0", m3PPL0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPL1.HasValue)
				request.WithQueryParameter("PPL1", m3PPL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPL2.HasValue)
				request.WithQueryParameter("PPL2", m3PPL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPDC.HasValue)
				request.WithQueryParameter("CPDC", m3CPDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COCD.HasValue)
				request.WithQueryParameter("COCD", m3COCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVGR))
				request.WithQueryParameter("EVGR", m3EVGR.Trim());
			if (m3VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3VAMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3LAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRTI))
				request.WithQueryParameter("GRTI", m3GRTI.Trim());
			if (m3MOLL.HasValue)
				request.WithQueryParameter("MOLL", m3MOLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DICM))
				request.WithQueryParameter("DICM", m3DICM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3STCW.HasValue)
				request.WithQueryParameter("STCW", m3STCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3RJCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3QUCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWC.HasValue)
				request.WithQueryParameter("CAWC", m3CAWC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CPUN))
				request.WithQueryParameter("CPUN", m3CPUN.Trim());
			if (m3COFA.HasValue)
				request.WithQueryParameter("COFA", m3COFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALTS.HasValue)
				request.WithQueryParameter("ALTS", m3ALTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATTC.HasValue)
				request.WithQueryParameter("ATTC", m3ATTC.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmMeas
		/// Description Update Item Measurement Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3UNNN">UN number</param>
		/// <param name="m3UNPA">UN pack code</param>
		/// <param name="m3HAC1">Danger class 1</param>
		/// <param name="m3HAC2">Danger class 2</param>
		/// <param name="m3HAC3">Danger class 3</param>
		/// <param name="m3DIM1">Measurement 1</param>
		/// <param name="m3DIM2">Measurement 2</param>
		/// <param name="m3DIM3">Measurement 3</param>
		/// <param name="m3SPE1">Specification 1</param>
		/// <param name="m3SPE2">Specification 2</param>
		/// <param name="m3SPE3">Specification 3</param>
		/// <param name="m3SPE4">Specification 4</param>
		/// <param name="m3SPE5">Specification 5</param>
		/// <param name="m3CETY">Lot restricted release</param>
		/// <param name="m3STCN">Storage requirements</param>
		/// <param name="m3SPAC">Storage packaging</param>
		/// <param name="m3TRPA">Transportation packaging</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3SMFI">Single manufacturer</param>
		/// <param name="m3TANK">Bulk item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmMeas(
			string m3ITNO, 
			int? m3CONO = null, 
			int? m3UNNN = null, 
			string m3UNPA = null, 
			string m3HAC1 = null, 
			string m3HAC2 = null, 
			string m3HAC3 = null, 
			string m3DIM1 = null, 
			string m3DIM2 = null, 
			string m3DIM3 = null, 
			string m3SPE1 = null, 
			string m3SPE2 = null, 
			string m3SPE3 = null, 
			string m3SPE4 = null, 
			string m3SPE5 = null, 
			string m3CETY = null, 
			string m3STCN = null, 
			string m3SPAC = null, 
			string m3TRPA = null, 
			string m3PROD = null, 
			int? m3SMFI = null, 
			int? m3TANK = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItmMeas",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3UNNN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNPA))
				request.WithQueryParameter("UNPA", m3UNPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAC1))
				request.WithQueryParameter("HAC1", m3HAC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAC2))
				request.WithQueryParameter("HAC2", m3HAC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAC3))
				request.WithQueryParameter("HAC3", m3HAC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIM1))
				request.WithQueryParameter("DIM1", m3DIM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIM2))
				request.WithQueryParameter("DIM2", m3DIM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIM3))
				request.WithQueryParameter("DIM3", m3DIM3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPE1))
				request.WithQueryParameter("SPE1", m3SPE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPE2))
				request.WithQueryParameter("SPE2", m3SPE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPE3))
				request.WithQueryParameter("SPE3", m3SPE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPE4))
				request.WithQueryParameter("SPE4", m3SPE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPE5))
				request.WithQueryParameter("SPE5", m3SPE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CETY))
				request.WithQueryParameter("CETY", m3CETY.Trim());
			if (!string.IsNullOrWhiteSpace(m3STCN))
				request.WithQueryParameter("STCN", m3STCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPAC))
				request.WithQueryParameter("SPAC", m3SPAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRPA))
				request.WithQueryParameter("TRPA", m3TRPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (m3SMFI.HasValue)
				request.WithQueryParameter("SMFI", m3SMFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TANK.HasValue)
				request.WithQueryParameter("TANK", m3TANK.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmPrice
		/// Description Update Item Price Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ECCC">Consumption code - trade stat (TST)</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3CUCS">Currency - sales price</param>
		/// <param name="m3DIGI">Discount group - item</param>
		/// <param name="m3BGRP">Bonus group</param>
		/// <param name="m3PRVG">Commission group</param>
		/// <param name="m3FRE3">Statistics identity 3 item</param>
		/// <param name="m3FRE4">Statistics identity 4 item</param>
		/// <param name="m3OTDI">Order total discount generating</param>
		/// <param name="m3BOGR">Bonus generating</param>
		/// <param name="m3PRGR">Commission generating</param>
		/// <param name="m3ACHK">Assortment check</param>
		/// <param name="m3BPEY">Update buying pattern</param>
		/// <param name="m3SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmPrice(
			string m3ITNO, 
			int? m3CONO = null, 
			string m3ECCC = null, 
			string m3SUNO = null, 
			decimal? m3PUPR = null, 
			int? m3PUCD = null, 
			string m3CUCD = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			string m3CUCS = null, 
			string m3DIGI = null, 
			string m3BGRP = null, 
			string m3PRVG = null, 
			string m3FRE3 = null, 
			string m3FRE4 = null, 
			int? m3OTDI = null, 
			int? m3BOGR = null, 
			int? m3PRGR = null, 
			int? m3ACHK = null, 
			int? m3BPEY = null, 
			int? m3SPUC = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItmPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECCC))
				request.WithQueryParameter("ECCC", m3ECCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCS))
				request.WithQueryParameter("CUCS", m3CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIGI))
				request.WithQueryParameter("DIGI", m3DIGI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BGRP))
				request.WithQueryParameter("BGRP", m3BGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRVG))
				request.WithQueryParameter("PRVG", m3PRVG.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE3))
				request.WithQueryParameter("FRE3", m3FRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE4))
				request.WithQueryParameter("FRE4", m3FRE4.Trim());
			if (m3OTDI.HasValue)
				request.WithQueryParameter("OTDI", m3OTDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BOGR.HasValue)
				request.WithQueryParameter("BOGR", m3BOGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRGR.HasValue)
				request.WithQueryParameter("PRGR", m3PRGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACHK.HasValue)
				request.WithQueryParameter("ACHK", m3ACHK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BPEY.HasValue)
				request.WithQueryParameter("BPEY", m3BPEY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3SPUC.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmTech
		/// Description Update Item Technical Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ARPA">Repair supplier</param>
		/// <param name="m3ARPR">Repair planner</param>
		/// <param name="m3AMPT">Repair time</param>
		/// <param name="m3AWDY">Repair warranty - days</param>
		/// <param name="m3NPTO">Tool quantity</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3MES2">Meter 2</param>
		/// <param name="m3MES3">Meter 3</param>
		/// <param name="m3MES4">Meter 4</param>
		/// <param name="m3MVA1">Meter value 1</param>
		/// <param name="m3MVA2">Meter value 2</param>
		/// <param name="m3MVA3">Meter value 3</param>
		/// <param name="m3MVA4">Meter value 4</param>
		/// <param name="m3PEQ1">Quantity or time</param>
		/// <param name="m3PEQ2">Quantity or time</param>
		/// <param name="m3PEQ3">Quantity or time</param>
		/// <param name="m3PEQ4">Quantity or time</param>
		/// <param name="m3PET1">Trigger type</param>
		/// <param name="m3PET2">Trigger type</param>
		/// <param name="m3PET3">Trigger type</param>
		/// <param name="m3PET4">Trigger type</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3MAPL">Planner - maintenance</param>
		/// <param name="m3TOHI">Tool history</param>
		/// <param name="m3TORE">Tool allocation</param>
		/// <param name="m3FEBA">Tool reporting</param>
		/// <param name="m3MAPN">Maintenance planning</param>
		/// <param name="m3STCS">Downtime cost</param>
		/// <param name="m3NESA">Next shop action type</param>
		/// <param name="m3NSUF">Next service</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3PLMZ">Planning horizon</param>
		/// <param name="m3CCO1">Calculation constant 1</param>
		/// <param name="m3CCO2">Calculation constant 2</param>
		/// <param name="m3CCO3">Calculation constant 3</param>
		/// <param name="m3TBSR">Time between scheduled shop visits</param>
		/// <param name="m3MBSR">Meter - scheduled shop visits</param>
		/// <param name="m3TBUR">Unscheduled removal rate</param>
		/// <param name="m3MBUR">Meter - unscheduled removal rate</param>
		/// <param name="m3TBFR">Time between failure</param>
		/// <param name="m3MBFR">Meter - failure</param>
		/// <param name="m3AESC">Criticality class</param>
		/// <param name="m3AES2">Extended-range twin-engine operations</param>
		/// <param name="m3AMOR">Maintenance/overhaul/repair class</param>
		/// <param name="m3FUNC">Function area</param>
		/// <param name="m3STNC">Standard numbering system</param>
		/// <param name="m3DIRR">Dimensional removal rate</param>
		/// <param name="m3MDIR">Meter - dimensioning removal rate</param>
		/// <param name="m3SCGR">Service level</param>
		/// <param name="m3ARR1">Removal class</param>
		/// <param name="m3AEQY">Extra quantity</param>
		/// <param name="m3LEAI">Internal lead time</param>
		/// <param name="m3WAL1">Warranty limit 1</param>
		/// <param name="m3WAL2">Warranty limit 2</param>
		/// <param name="m3WAL3">Warranty limit 3</param>
		/// <param name="m3WAL4">Warranty limit 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmTech(
			string m3ITNO, 
			int? m3CONO = null, 
			string m3ARPA = null, 
			string m3ARPR = null, 
			int? m3AMPT = null, 
			int? m3AWDY = null, 
			int? m3NPTO = null, 
			string m3MES1 = null, 
			string m3MES2 = null, 
			string m3MES3 = null, 
			string m3MES4 = null, 
			decimal? m3MVA1 = null, 
			decimal? m3MVA2 = null, 
			decimal? m3MVA3 = null, 
			decimal? m3MVA4 = null, 
			int? m3PEQ1 = null, 
			int? m3PEQ2 = null, 
			int? m3PEQ3 = null, 
			int? m3PEQ4 = null, 
			int? m3PET1 = null, 
			int? m3PET2 = null, 
			int? m3PET3 = null, 
			int? m3PET4 = null, 
			string m3MPGM = null, 
			string m3ORTY = null, 
			string m3PLCD = null, 
			string m3MAPL = null, 
			int? m3TOHI = null, 
			int? m3TORE = null, 
			int? m3FEBA = null, 
			int? m3MAPN = null, 
			decimal? m3STCS = null, 
			string m3NESA = null, 
			string m3NSUF = null, 
			string m3FCCM = null, 
			int? m3DPID = null, 
			int? m3CONC = null, 
			int? m3PLMZ = null, 
			int? m3CCO1 = null, 
			int? m3CCO2 = null, 
			int? m3CCO3 = null, 
			decimal? m3TBSR = null, 
			string m3MBSR = null, 
			decimal? m3TBUR = null, 
			string m3MBUR = null, 
			decimal? m3TBFR = null, 
			string m3MBFR = null, 
			int? m3AESC = null, 
			int? m3AES2 = null, 
			int? m3AMOR = null, 
			string m3FUNC = null, 
			string m3STNC = null, 
			decimal? m3DIRR = null, 
			string m3MDIR = null, 
			int? m3SCGR = null, 
			int? m3ARR1 = null, 
			decimal? m3AEQY = null, 
			int? m3LEAI = null, 
			decimal? m3WAL1 = null, 
			decimal? m3WAL2 = null, 
			decimal? m3WAL3 = null, 
			decimal? m3WAL4 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItmTech",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ARPA))
				request.WithQueryParameter("ARPA", m3ARPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARPR))
				request.WithQueryParameter("ARPR", m3ARPR.Trim());
			if (m3AMPT.HasValue)
				request.WithQueryParameter("AMPT", m3AMPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AWDY.HasValue)
				request.WithQueryParameter("AWDY", m3AWDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NPTO.HasValue)
				request.WithQueryParameter("NPTO", m3NPTO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES2))
				request.WithQueryParameter("MES2", m3MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES3))
				request.WithQueryParameter("MES3", m3MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES4))
				request.WithQueryParameter("MES4", m3MES4.Trim());
			if (m3MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3MVA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3MVA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3MVA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3MVA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ1.HasValue)
				request.WithQueryParameter("PEQ1", m3PEQ1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ2.HasValue)
				request.WithQueryParameter("PEQ2", m3PEQ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ3.HasValue)
				request.WithQueryParameter("PEQ3", m3PEQ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ4.HasValue)
				request.WithQueryParameter("PEQ4", m3PEQ4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET1.HasValue)
				request.WithQueryParameter("PET1", m3PET1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET2.HasValue)
				request.WithQueryParameter("PET2", m3PET2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET3.HasValue)
				request.WithQueryParameter("PET3", m3PET3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET4.HasValue)
				request.WithQueryParameter("PET4", m3PET4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLCD))
				request.WithQueryParameter("PLCD", m3PLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAPL))
				request.WithQueryParameter("MAPL", m3MAPL.Trim());
			if (m3TOHI.HasValue)
				request.WithQueryParameter("TOHI", m3TOHI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TORE.HasValue)
				request.WithQueryParameter("TORE", m3TORE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FEBA.HasValue)
				request.WithQueryParameter("FEBA", m3FEBA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAPN.HasValue)
				request.WithQueryParameter("MAPN", m3MAPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STCS.HasValue)
				request.WithQueryParameter("STCS", m3STCS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NESA))
				request.WithQueryParameter("NESA", m3NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUF))
				request.WithQueryParameter("NSUF", m3NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3PLMZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CCO1.HasValue)
				request.WithQueryParameter("CCO1", m3CCO1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CCO2.HasValue)
				request.WithQueryParameter("CCO2", m3CCO2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CCO3.HasValue)
				request.WithQueryParameter("CCO3", m3CCO3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TBSR.HasValue)
				request.WithQueryParameter("TBSR", m3TBSR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MBSR))
				request.WithQueryParameter("MBSR", m3MBSR.Trim());
			if (m3TBUR.HasValue)
				request.WithQueryParameter("TBUR", m3TBUR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MBUR))
				request.WithQueryParameter("MBUR", m3MBUR.Trim());
			if (m3TBFR.HasValue)
				request.WithQueryParameter("TBFR", m3TBFR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MBFR))
				request.WithQueryParameter("MBFR", m3MBFR.Trim());
			if (m3AESC.HasValue)
				request.WithQueryParameter("AESC", m3AESC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AES2.HasValue)
				request.WithQueryParameter("AES2", m3AES2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMOR.HasValue)
				request.WithQueryParameter("AMOR", m3AMOR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FUNC))
				request.WithQueryParameter("FUNC", m3FUNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3STNC))
				request.WithQueryParameter("STNC", m3STNC.Trim());
			if (m3DIRR.HasValue)
				request.WithQueryParameter("DIRR", m3DIRR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MDIR))
				request.WithQueryParameter("MDIR", m3MDIR.Trim());
			if (m3SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3SCGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARR1.HasValue)
				request.WithQueryParameter("ARR1", m3ARR1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AEQY.HasValue)
				request.WithQueryParameter("AEQY", m3AEQY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEAI.HasValue)
				request.WithQueryParameter("LEAI", m3LEAI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3WAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3WAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3WAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3WAL4.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmTrpFrelnf
		/// Description Update Item Transport Information , fields A001-A040
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3A001">Alpha field 30 positions</param>
		/// <param name="m3A002">Alpha field 30 positions</param>
		/// <param name="m3A003">Alpha field 30 positions</param>
		/// <param name="m3A004">Alpha field 30 positions</param>
		/// <param name="m3A005">Alpha field 30 positions</param>
		/// <param name="m3A006">Alpha field 30 positions</param>
		/// <param name="m3A007">Alpha field 30 positions</param>
		/// <param name="m3A008">Alpha field 30 positions</param>
		/// <param name="m3A009">Alpha field 30 positions</param>
		/// <param name="m3A010">Alpha field 30 positions</param>
		/// <param name="m3A021">Alpha field 1 positions</param>
		/// <param name="m3A022">Alpha field 1 positions</param>
		/// <param name="m3A023">Alpha field 1 positions</param>
		/// <param name="m3A024">Alpha field 1 positions</param>
		/// <param name="m3A025">Alpha field 1 positions</param>
		/// <param name="m3A026">Alpha field 5 positions</param>
		/// <param name="m3A027">Alpha field 5 positions</param>
		/// <param name="m3A028">Alpha field 5 positions</param>
		/// <param name="m3A029">Alpha field 5 positions</param>
		/// <param name="m3A030">Alpha field 5 positions</param>
		/// <param name="m3A031">Alpha field 10 positions</param>
		/// <param name="m3A032">Alpha field 10 positions</param>
		/// <param name="m3A033">Alpha field 10 positions</param>
		/// <param name="m3A034">Alpha field 10 positions</param>
		/// <param name="m3A035">Alpha field 10 positions</param>
		/// <param name="m3A036">Alpha field 15 positions</param>
		/// <param name="m3A037">Alpha field 15 positions</param>
		/// <param name="m3A038">Alpha field 15 positions</param>
		/// <param name="m3A039">Alpha field 15 positions</param>
		/// <param name="m3A040">Alpha field 15 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmTrpFrelnf(
			string m3ITNO, 
			string m3A001 = null, 
			string m3A002 = null, 
			string m3A003 = null, 
			string m3A004 = null, 
			string m3A005 = null, 
			string m3A006 = null, 
			string m3A007 = null, 
			string m3A008 = null, 
			string m3A009 = null, 
			string m3A010 = null, 
			string m3A021 = null, 
			string m3A022 = null, 
			string m3A023 = null, 
			string m3A024 = null, 
			string m3A025 = null, 
			string m3A026 = null, 
			string m3A027 = null, 
			string m3A028 = null, 
			string m3A029 = null, 
			string m3A030 = null, 
			string m3A031 = null, 
			string m3A032 = null, 
			string m3A033 = null, 
			string m3A034 = null, 
			string m3A035 = null, 
			string m3A036 = null, 
			string m3A037 = null, 
			string m3A038 = null, 
			string m3A039 = null, 
			string m3A040 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItmTrpFrelnf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3A001))
				request.WithQueryParameter("A001", m3A001.Trim());
			if (!string.IsNullOrWhiteSpace(m3A002))
				request.WithQueryParameter("A002", m3A002.Trim());
			if (!string.IsNullOrWhiteSpace(m3A003))
				request.WithQueryParameter("A003", m3A003.Trim());
			if (!string.IsNullOrWhiteSpace(m3A004))
				request.WithQueryParameter("A004", m3A004.Trim());
			if (!string.IsNullOrWhiteSpace(m3A005))
				request.WithQueryParameter("A005", m3A005.Trim());
			if (!string.IsNullOrWhiteSpace(m3A006))
				request.WithQueryParameter("A006", m3A006.Trim());
			if (!string.IsNullOrWhiteSpace(m3A007))
				request.WithQueryParameter("A007", m3A007.Trim());
			if (!string.IsNullOrWhiteSpace(m3A008))
				request.WithQueryParameter("A008", m3A008.Trim());
			if (!string.IsNullOrWhiteSpace(m3A009))
				request.WithQueryParameter("A009", m3A009.Trim());
			if (!string.IsNullOrWhiteSpace(m3A010))
				request.WithQueryParameter("A010", m3A010.Trim());
			if (!string.IsNullOrWhiteSpace(m3A021))
				request.WithQueryParameter("A021", m3A021.Trim());
			if (!string.IsNullOrWhiteSpace(m3A022))
				request.WithQueryParameter("A022", m3A022.Trim());
			if (!string.IsNullOrWhiteSpace(m3A023))
				request.WithQueryParameter("A023", m3A023.Trim());
			if (!string.IsNullOrWhiteSpace(m3A024))
				request.WithQueryParameter("A024", m3A024.Trim());
			if (!string.IsNullOrWhiteSpace(m3A025))
				request.WithQueryParameter("A025", m3A025.Trim());
			if (!string.IsNullOrWhiteSpace(m3A026))
				request.WithQueryParameter("A026", m3A026.Trim());
			if (!string.IsNullOrWhiteSpace(m3A027))
				request.WithQueryParameter("A027", m3A027.Trim());
			if (!string.IsNullOrWhiteSpace(m3A028))
				request.WithQueryParameter("A028", m3A028.Trim());
			if (!string.IsNullOrWhiteSpace(m3A029))
				request.WithQueryParameter("A029", m3A029.Trim());
			if (!string.IsNullOrWhiteSpace(m3A030))
				request.WithQueryParameter("A030", m3A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3A031))
				request.WithQueryParameter("A031", m3A031.Trim());
			if (!string.IsNullOrWhiteSpace(m3A032))
				request.WithQueryParameter("A032", m3A032.Trim());
			if (!string.IsNullOrWhiteSpace(m3A033))
				request.WithQueryParameter("A033", m3A033.Trim());
			if (!string.IsNullOrWhiteSpace(m3A034))
				request.WithQueryParameter("A034", m3A034.Trim());
			if (!string.IsNullOrWhiteSpace(m3A035))
				request.WithQueryParameter("A035", m3A035.Trim());
			if (!string.IsNullOrWhiteSpace(m3A036))
				request.WithQueryParameter("A036", m3A036.Trim());
			if (!string.IsNullOrWhiteSpace(m3A037))
				request.WithQueryParameter("A037", m3A037.Trim());
			if (!string.IsNullOrWhiteSpace(m3A038))
				request.WithQueryParameter("A038", m3A038.Trim());
			if (!string.IsNullOrWhiteSpace(m3A039))
				request.WithQueryParameter("A039", m3A039.Trim());
			if (!string.IsNullOrWhiteSpace(m3A040))
				request.WithQueryParameter("A040", m3A040.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmTrplnf
		/// Description Update Item Transport Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3UNNN">UN number</param>
		/// <param name="m3NNNN">NA number</param>
		/// <param name="m3CASN">CAS number</param>
		/// <param name="m3ECNM">EU number</param>
		/// <param name="m3EINM">EINECS number</param>
		/// <param name="m3ATOM">Atomic number</param>
		/// <param name="m3CEAN">CEA number</param>
		/// <param name="m3NAIC">NAICS code</param>
		/// <param name="m3ITEQ">Item equipment profile</param>
		/// <param name="m3CMMC">Freight commodity code</param>
		/// <param name="m3HAZM">Hazardous material</param>
		/// <param name="m3CMCL">Commodity class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmTrplnf(
			string m3ITNO, 
			int? m3UNNN = null, 
			string m3NNNN = null, 
			string m3CASN = null, 
			string m3ECNM = null, 
			string m3EINM = null, 
			string m3ATOM = null, 
			string m3CEAN = null, 
			int? m3NAIC = null, 
			string m3ITEQ = null, 
			string m3CMMC = null, 
			int? m3HAZM = null, 
			string m3CMCL = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItmTrplnf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3UNNN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NNNN))
				request.WithQueryParameter("NNNN", m3NNNN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CASN))
				request.WithQueryParameter("CASN", m3CASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECNM))
				request.WithQueryParameter("ECNM", m3ECNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EINM))
				request.WithQueryParameter("EINM", m3EINM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATOM))
				request.WithQueryParameter("ATOM", m3ATOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CEAN))
				request.WithQueryParameter("CEAN", m3CEAN.Trim());
			if (m3NAIC.HasValue)
				request.WithQueryParameter("NAIC", m3NAIC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITEQ))
				request.WithQueryParameter("ITEQ", m3ITEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMMC))
				request.WithQueryParameter("CMMC", m3CMMC.Trim());
			if (m3HAZM.HasValue)
				request.WithQueryParameter("HAZM", m3HAZM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CMCL))
				request.WithQueryParameter("CMCL", m3CMCL.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmWhs
		/// Description Update Item Warehouse
		/// Version Release: 5ea8
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STQT">On-hand balance approved</param>
		/// <param name="m3QUQT">On-hand balance for inspection</param>
		/// <param name="m3RJQT">Rejected on-hand balance</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3AVAL">Allocatable on-hand balance</param>
		/// <param name="m3PLQT">Picking list quantity - basic U/M</param>
		/// <param name="m3COMG">Container management</param>
		/// <param name="m3ALMT">Allocation method</param>
		/// <param name="m3STMT">Storage method</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3STTX">Note</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3REQT">Reserved quantity</param>
		/// <param name="m3RLQT">Reserved quantity to backorder</param>
		/// <param name="m3REQP">Reserved quantity - planned orders</param>
		/// <param name="m3IDDT">Last receipt date</param>
		/// <param name="m3ODDT">Last issue date</param>
		/// <param name="m3INDT">Latest physical inventory date</param>
		/// <param name="m3PRDC">Priority date selection</param>
		/// <param name="m3INCD">Physical inventory cycle</param>
		/// <param name="m3NUIN">Number of records for physical inventory</param>
		/// <param name="m3USYE">Annual usage</param>
		/// <param name="m3AVST">Average on-hand balance</param>
		/// <param name="m3DILE">Projected on-hand at end of lead time</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3WHTY">Warehouse type</param>
		/// <param name="m3WHSY">Warehouse subtype</param>
		/// <param name="m3INSC">Statistics storage group</param>
		/// <param name="m3DIGR">Distribution group</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3NUS7">Number of balance IDs</param>
		/// <param name="m3TOMU">Issue multiple</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3MABC">ABC class - manual</param>
		/// <param name="m3ABCD">ABC class - volume</param>
		/// <param name="m3ABCM">ABC method  - volume</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3ABFM">ABC method - frequency</param>
		/// <param name="m3ACOC">ABC class - contribution</param>
		/// <param name="m3ACOM">ABC method - contribution</param>
		/// <param name="m3PRIF">Priority value</param>
		/// <param name="m3SODY">Run-out time</param>
		/// <param name="m3REOP">Reorder point</param>
		/// <param name="m3OPOM">Reorder point method</param>
		/// <param name="m3SSQT">Safety stock</param>
		/// <param name="m3SSMT">Safety stock method</param>
		/// <param name="m3MSSQ">Manual safety stock</param>
		/// <param name="m3SSDA">Safety stock unit</param>
		/// <param name="m3SCGR">Service level</param>
		/// <param name="m3MXST">Maximum stock</param>
		/// <param name="m3MXSM">Maximum stock method</param>
		/// <param name="m3MXPC">Maximum stock percentage</param>
		/// <param name="m3EOQT">Order quantity</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3EQDA">Economical order quantity days</param>
		/// <param name="m3YEQT">Annual demand</param>
		/// <param name="m3YEQM">Annual demand method</param>
		/// <param name="m3LOQT">Minimum order quantity</param>
		/// <param name="m3MOQT">Maximum order quantity</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3SUWH">Supplying warehouse</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3PRCD">Forecast method</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3LYQT">Fixed annual demand</param>
		/// <param name="m3LRYE">Fixed acquisition requirement</param>
		/// <param name="m3PFTM">Planning time fence</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3LEA2">Inspection lead time</param>
		/// <param name="m3LEA3">Transportation lead time</param>
		/// <param name="m3LEAT">Lead time</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3SVEI">Multiple supply</param>
		/// <param name="m3LEVL">Lowest level</param>
		/// <param name="m3LEVD">Lowest level DO</param>
		/// <param name="m3PLHZ">Planning horizon</param>
		/// <param name="m3DMFN">Demand time fence</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3SATD">Safety time</param>
		/// <param name="m3ALQC">Quantity controlled allocation</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3SHCC">Distribution/supplier calendar check</param>
		/// <param name="m3ZCAC">Zero mark</param>
		/// <param name="m3INSL">Inspection location</param>
		/// <param name="m3NCCA">Net change calculation active</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DDEX">Time phased safety stock exists</param>
		/// <param name="m3STRL">History storage method</param>
		/// <param name="m3PLIC">Picking list information control</param>
		/// <param name="m3PPMC">Pending planning method change</param>
		/// <param name="m3MPCD">Calculation date - material planning</param>
		/// <param name="m3MPCT">Calculation time - material planning</param>
		/// <param name="m3DCSS">Time phased safety stock</param>
		/// <param name="m3RPOP">Responsible - PO proposal</param>
		/// <param name="m3BCOS">Standard cost - warehouse</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3DPLO">Default packing location</param>
		/// <param name="m3DDLO">Default docking location</param>
		/// <param name="m3SPLC">Delivery split rule</param>
		/// <param name="m3ALS1">Allocate non-approved balance ID</param>
		/// <param name="m3POOT">Point of time table</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3MNUN">Main unit of calculation</param>
		/// <param name="m3GRTS">Distribution group technology</param>
		/// <param name="m3SLDY">Shelf life</param>
		/// <param name="m3REDY">Reinspection time</param>
		/// <param name="m3SAEL">Sales time</param>
		/// <param name="m3CPCD">CTP policy</param>
		/// <param name="m3LEAQ">Quarantine lead-time</param>
		/// <param name="m3SCHT">Scheduled re-classification allowed</param>
		/// <param name="m3STCW">Catch weight approved on hand balance</param>
		/// <param name="m3RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3CWCP">Alternate U/M</param>
		/// <param name="m3CPUN">Standard cost price unit of measure</param>
		/// <param name="m3IPLA">Inventory planned</param>
		/// <param name="m3BBTM">Best before time</param>
		/// <param name="m3FSSQ">Frozen safety stock</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3SSRE">SS reason code</param>
		/// <param name="m3ISEG">Inventory segment</param>
		/// <param name="m3SALM">Secondary allocation method</param>
		/// <param name="m3SCPO">Supply chain policy</param>
		/// <param name="m3AGDY">Aging days</param>
		/// <param name="m3AGHO">Aging hours</param>
		/// <param name="m3AGMI">Aging minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmWhs(
			string m3WHLO, 
			string m3ITNO, 
			int? m3CONO = null, 
			decimal? m3STQT = null, 
			decimal? m3QUQT = null, 
			decimal? m3RJQT = null, 
			decimal? m3ALQT = null, 
			decimal? m3AVAL = null, 
			decimal? m3PLQT = null, 
			int? m3COMG = null, 
			int? m3ALMT = null, 
			int? m3STMT = null, 
			int? m3SPMT = null, 
			string m3STTX = null, 
			decimal? m3ORQT = null, 
			decimal? m3REQT = null, 
			decimal? m3RLQT = null, 
			decimal? m3REQP = null, 
			DateTime? m3IDDT = null, 
			DateTime? m3ODDT = null, 
			DateTime? m3INDT = null, 
			int? m3PRDC = null, 
			string m3INCD = null, 
			int? m3NUIN = null, 
			decimal? m3USYE = null, 
			decimal? m3AVST = null, 
			decimal? m3DILE = null, 
			string m3RESP = null, 
			string m3BUYE = null, 
			string m3SUNO = null, 
			string m3WHTY = null, 
			string m3WHSY = null, 
			int? m3INSC = null, 
			string m3DIGR = null, 
			string m3WHSL = null, 
			string m3SLTP = null, 
			int? m3NUS7 = null, 
			decimal? m3TOMU = null, 
			string m3WHLT = null, 
			string m3PISE = null, 
			string m3PLCD = null, 
			string m3MABC = null, 
			string m3ABCD = null, 
			int? m3ABCM = null, 
			string m3ABFC = null, 
			int? m3ABFM = null, 
			string m3ACOC = null, 
			int? m3ACOM = null, 
			int? m3PRIF = null, 
			int? m3SODY = null, 
			decimal? m3REOP = null, 
			int? m3OPOM = null, 
			decimal? m3SSQT = null, 
			int? m3SSMT = null, 
			decimal? m3MSSQ = null, 
			int? m3SSDA = null, 
			int? m3SCGR = null, 
			decimal? m3MXST = null, 
			int? m3MXSM = null, 
			int? m3MXPC = null, 
			decimal? m3EOQT = null, 
			int? m3EOQM = null, 
			int? m3EQDA = null, 
			decimal? m3YEQT = null, 
			int? m3YEQM = null, 
			decimal? m3LOQT = null, 
			decimal? m3MOQT = null, 
			int? m3PUIT = null, 
			string m3SUWH = null, 
			int? m3DPID = null, 
			string m3PRCD = null, 
			string m3FCCM = null, 
			decimal? m3LYQT = null, 
			decimal? m3LRYE = null, 
			int? m3PFTM = null, 
			int? m3LEA1 = null, 
			int? m3LEA2 = null, 
			int? m3LEA3 = null, 
			int? m3LEAT = null, 
			decimal? m3UNMU = null, 
			int? m3SVEI = null, 
			int? m3LEVL = null, 
			int? m3LEVD = null, 
			int? m3PLHZ = null, 
			int? m3DMFN = null, 
			string m3ORTY = null, 
			int? m3CONC = null, 
			int? m3SATD = null, 
			int? m3ALQC = null, 
			int? m3OPLC = null, 
			int? m3MSCH = null, 
			int? m3SHCC = null, 
			int? m3ZCAC = null, 
			string m3INSL = null, 
			int? m3NCCA = null, 
			string m3FACI = null, 
			string m3DIVI = null, 
			int? m3DDEX = null, 
			int? m3STRL = null, 
			int? m3PLIC = null, 
			int? m3PPMC = null, 
			DateTime? m3MPCD = null, 
			int? m3MPCT = null, 
			int? m3DCSS = null, 
			int? m3RPOP = null, 
			decimal? m3BCOS = null, 
			decimal? m3TXID = null, 
			decimal? m3DTID = null, 
			string m3DPLO = null, 
			string m3DDLO = null, 
			string m3SPLC = null, 
			int? m3ALS1 = null, 
			string m3POOT = null, 
			string m3STAT = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			string m3MNUN = null, 
			string m3GRTS = null, 
			int? m3SLDY = null, 
			int? m3REDY = null, 
			int? m3SAEL = null, 
			string m3CPCD = null, 
			int? m3LEAQ = null, 
			int? m3SCHT = null, 
			decimal? m3STCW = null, 
			decimal? m3RJCW = null, 
			decimal? m3QUCW = null, 
			string m3CWCP = null, 
			string m3CPUN = null, 
			string m3IPLA = null, 
			int? m3BBTM = null, 
			int? m3FSSQ = null, 
			int? m3RNRI = null, 
			int? m3RMSG = null, 
			string m3SSRE = null, 
			string m3ISEG = null, 
			int? m3SALM = null, 
			string m3SCPO = null, 
			int? m3AGDY = null, 
			int? m3AGHO = null, 
			int? m3AGMI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STQT.HasValue)
				request.WithQueryParameter("STQT", m3STQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUQT.HasValue)
				request.WithQueryParameter("QUQT", m3QUQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RJQT.HasValue)
				request.WithQueryParameter("RJQT", m3RJQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVAL.HasValue)
				request.WithQueryParameter("AVAL", m3AVAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLQT.HasValue)
				request.WithQueryParameter("PLQT", m3PLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COMG.HasValue)
				request.WithQueryParameter("COMG", m3COMG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALMT.HasValue)
				request.WithQueryParameter("ALMT", m3ALMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STMT.HasValue)
				request.WithQueryParameter("STMT", m3STMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STTX))
				request.WithQueryParameter("STTX", m3STTX.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQT.HasValue)
				request.WithQueryParameter("REQT", m3REQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLQT.HasValue)
				request.WithQueryParameter("RLQT", m3RLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQP.HasValue)
				request.WithQueryParameter("REQP", m3REQP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDDT.HasValue)
				request.WithQueryParameter("IDDT", m3IDDT.Value.ToM3String());
			if (m3ODDT.HasValue)
				request.WithQueryParameter("ODDT", m3ODDT.Value.ToM3String());
			if (m3INDT.HasValue)
				request.WithQueryParameter("INDT", m3INDT.Value.ToM3String());
			if (m3PRDC.HasValue)
				request.WithQueryParameter("PRDC", m3PRDC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INCD))
				request.WithQueryParameter("INCD", m3INCD.Trim());
			if (m3NUIN.HasValue)
				request.WithQueryParameter("NUIN", m3NUIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3USYE.HasValue)
				request.WithQueryParameter("USYE", m3USYE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVST.HasValue)
				request.WithQueryParameter("AVST", m3AVST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DILE.HasValue)
				request.WithQueryParameter("DILE", m3DILE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHTY))
				request.WithQueryParameter("WHTY", m3WHTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSY))
				request.WithQueryParameter("WHSY", m3WHSY.Trim());
			if (m3INSC.HasValue)
				request.WithQueryParameter("INSC", m3INSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIGR))
				request.WithQueryParameter("DIGR", m3DIGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (m3NUS7.HasValue)
				request.WithQueryParameter("NUS7", m3NUS7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOMU.HasValue)
				request.WithQueryParameter("TOMU", m3TOMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLCD))
				request.WithQueryParameter("PLCD", m3PLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MABC))
				request.WithQueryParameter("MABC", m3MABC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (m3ABCM.HasValue)
				request.WithQueryParameter("ABCM", m3ABCM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ABFC))
				request.WithQueryParameter("ABFC", m3ABFC.Trim());
			if (m3ABFM.HasValue)
				request.WithQueryParameter("ABFM", m3ABFM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACOC))
				request.WithQueryParameter("ACOC", m3ACOC.Trim());
			if (m3ACOM.HasValue)
				request.WithQueryParameter("ACOM", m3ACOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRIF.HasValue)
				request.WithQueryParameter("PRIF", m3PRIF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SODY.HasValue)
				request.WithQueryParameter("SODY", m3SODY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REOP.HasValue)
				request.WithQueryParameter("REOP", m3REOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3OPOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3SSQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3SSMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3MSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3SSDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3SCGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXST.HasValue)
				request.WithQueryParameter("MXST", m3MXST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXSM.HasValue)
				request.WithQueryParameter("MXSM", m3MXSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3MXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQT.HasValue)
				request.WithQueryParameter("EOQT", m3EOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3EQDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3YEQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEQM.HasValue)
				request.WithQueryParameter("YEQM", m3YEQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3MOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3PUIT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUWH))
				request.WithQueryParameter("SUWH", m3SUWH.Trim());
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRCD))
				request.WithQueryParameter("PRCD", m3PRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3LYQT.HasValue)
				request.WithQueryParameter("LYQT", m3LYQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LRYE.HasValue)
				request.WithQueryParameter("LRYE", m3LRYE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFTM.HasValue)
				request.WithQueryParameter("PFTM", m3PFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3LEA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA2.HasValue)
				request.WithQueryParameter("LEA2", m3LEA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA3.HasValue)
				request.WithQueryParameter("LEA3", m3LEA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEAT.HasValue)
				request.WithQueryParameter("LEAT", m3LEAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SVEI.HasValue)
				request.WithQueryParameter("SVEI", m3SVEI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3LEVL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEVD.HasValue)
				request.WithQueryParameter("LEVD", m3LEVD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3PLHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DMFN.HasValue)
				request.WithQueryParameter("DMFN", m3DMFN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SATD.HasValue)
				request.WithQueryParameter("SATD", m3SATD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQC.HasValue)
				request.WithQueryParameter("ALQC", m3ALQC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3OPLC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3MSCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHCC.HasValue)
				request.WithQueryParameter("SHCC", m3SHCC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZCAC.HasValue)
				request.WithQueryParameter("ZCAC", m3ZCAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INSL))
				request.WithQueryParameter("INSL", m3INSL.Trim());
			if (m3NCCA.HasValue)
				request.WithQueryParameter("NCCA", m3NCCA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3DDEX.HasValue)
				request.WithQueryParameter("DDEX", m3DDEX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRL.HasValue)
				request.WithQueryParameter("STRL", m3STRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLIC.HasValue)
				request.WithQueryParameter("PLIC", m3PLIC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPMC.HasValue)
				request.WithQueryParameter("PPMC", m3PPMC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MPCD.HasValue)
				request.WithQueryParameter("MPCD", m3MPCD.Value.ToM3String());
			if (m3MPCT.HasValue)
				request.WithQueryParameter("MPCT", m3MPCT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCSS.HasValue)
				request.WithQueryParameter("DCSS", m3DCSS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPOP.HasValue)
				request.WithQueryParameter("RPOP", m3RPOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCOS.HasValue)
				request.WithQueryParameter("BCOS", m3BCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DPLO))
				request.WithQueryParameter("DPLO", m3DPLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DDLO))
				request.WithQueryParameter("DDLO", m3DDLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLC))
				request.WithQueryParameter("SPLC", m3SPLC.Trim());
			if (m3ALS1.HasValue)
				request.WithQueryParameter("ALS1", m3ALS1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POOT))
				request.WithQueryParameter("POOT", m3POOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MNUN))
				request.WithQueryParameter("MNUN", m3MNUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTS))
				request.WithQueryParameter("GRTS", m3GRTS.Trim());
			if (m3SLDY.HasValue)
				request.WithQueryParameter("SLDY", m3SLDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REDY.HasValue)
				request.WithQueryParameter("REDY", m3REDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAEL.HasValue)
				request.WithQueryParameter("SAEL", m3SAEL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CPCD))
				request.WithQueryParameter("CPCD", m3CPCD.Trim());
			if (m3LEAQ.HasValue)
				request.WithQueryParameter("LEAQ", m3LEAQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHT.HasValue)
				request.WithQueryParameter("SCHT", m3SCHT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STCW.HasValue)
				request.WithQueryParameter("STCW", m3STCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3RJCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3QUCW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CWCP))
				request.WithQueryParameter("CWCP", m3CWCP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPUN))
				request.WithQueryParameter("CPUN", m3CPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3IPLA))
				request.WithQueryParameter("IPLA", m3IPLA.Trim());
			if (m3BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3BBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3FSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSRE))
				request.WithQueryParameter("SSRE", m3SSRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISEG))
				request.WithQueryParameter("ISEG", m3ISEG.Trim());
			if (m3SALM.HasValue)
				request.WithQueryParameter("SALM", m3SALM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPO))
				request.WithQueryParameter("SCPO", m3SCPO.Trim());
			if (m3AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3AGDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3AGHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3AGMI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}
	}
}
// EOF
