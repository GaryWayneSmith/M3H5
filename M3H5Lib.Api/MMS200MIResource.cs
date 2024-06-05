/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ITDS">Name (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_UNMS">Basic unit of measure (Required)</param>
		/// <param name="m3_ITTY">Item type (Required)</param>
		/// <param name="m3_MABU">Make/buy code (Required)</param>
		/// <param name="m3_PRVG">Commission group (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_BUAR">Business area</param>
		/// <param name="m3_TPCD">Item category</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_BACD">Lot numbering method</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_BYPR">By/co-product code</param>
		/// <param name="m3_WAPC">Normal waste percentage</param>
		/// <param name="m3_QACD">Inspection code</param>
		/// <param name="m3_EPCD">Yield calculation</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_ACTI">Active or catch weight item</param>
		/// <param name="m3_HIE1">Hierachy level 1</param>
		/// <param name="m3_HIE2">Hierachy level 2</param>
		/// <param name="m3_HIE3">Hierachy level 3</param>
		/// <param name="m3_HIE4">Hierachy level 4</param>
		/// <param name="m3_HIE5">Hierachy level 5</param>
		/// <param name="m3_GRP1">Search group 1</param>
		/// <param name="m3_GRP2">Search group 2</param>
		/// <param name="m3_GRP3">Search group 3</param>
		/// <param name="m3_GRP4">Search group 4</param>
		/// <param name="m3_GRP5">Search group 5</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ECMA">ECO managed</param>
		/// <param name="m3_PRGP">Procurement group</param>
		/// <param name="m3_INDI">Lot control method</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_ALUC">Alternate U/M in use</param>
		/// <param name="m3_IEAA">Item exists as alias identity</param>
		/// <param name="m3_EXPD">Expiration date method</param>
		/// <param name="m3_GRMT">Goods receiving method</param>
		/// <param name="m3_HAZI">Danger indicator</param>
		/// <param name="m3_SALE">Sales item</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="m3_ATMN">Attribute managed</param>
		/// <param name="m3_TPLI">Template item number</param>
		/// <param name="m3_FCU1">Estimated consumption free capacity unit</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_IACP">Attribute-controlled item</param>
		/// <param name="m3_HDPR">Main product</param>
		/// <param name="m3_AAD0">Extended QA used</param>
		/// <param name="m3_AAD1">Generate txt from text template</param>
		/// <param name="m3_CHCL">Charge calculation</param>
		/// <param name="m3_ITRC">Individual item tracing</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_GRTI">Group technology class</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_PDCC">Number of price decimal places</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_EVGR">Envirenment group</param>
		/// <param name="m3_GRTS">Distribution group technology</param>
		/// <param name="m3_ETRF">External instruction</param>
		/// <param name="m3_CAWP">Catch weight mode</param>
		/// <param name="m3_CWUN">Catch weight unit of measure</param>
		/// <param name="m3_CPUN">Standard cost price unit of measure</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_ACMC">Compatibility code</param>
		/// <param name="m3_ITRU">Included in territorial roll-up</param>
		/// <param name="m3_TECR">Core terms</param>
		/// <param name="m3_EXCA">Exchangeable</param>
		/// <param name="m3_ACCG">Acceptance group</param>
		/// <param name="m3_CCCM">Costing model - core charge</param>
		/// <param name="m3_CCI1">Core charge item number</param>
		/// <param name="m3_CRI1">Core remain item number</param>
		/// <param name="m3_HVMT">Harvest Method</param>
		/// <param name="m3_ITNE">Extended item number</param>
		/// <param name="m3_SPGV">Specific gravity</param>
		/// <param name="m3_AUTC">Issue message</param>
		/// <param name="m3_RIDE">Reference identity</param>
		/// <param name="m3_RIDC">Reference identity code</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_SAFC">Suppliers ABC code</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_PDLN">Product line</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_SUME">Sublot method</param>
		/// <param name="m3_SUMP">Sublot policy</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmBasic(
			string m3_STAT, 
			string m3_ITNO, 
			string m3_ITDS, 
			string m3_RESP, 
			string m3_UNMS, 
			string m3_ITTY, 
			int m3_MABU, 
			string m3_PRVG, 
			int? m3_CONO = null, 
			string m3_FUDS = null, 
			string m3_DWNO = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_BUAR = null, 
			int? m3_TPCD = null, 
			int? m3_CHCD = null, 
			int? m3_STCD = null, 
			int? m3_BACD = null, 
			decimal? m3_VOL3 = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			int? m3_BYPR = null, 
			int? m3_WAPC = null, 
			int? m3_QACD = null, 
			int? m3_EPCD = null, 
			int? m3_POCY = null, 
			int? m3_ACTI = null, 
			string m3_HIE1 = null, 
			string m3_HIE2 = null, 
			string m3_HIE3 = null, 
			string m3_HIE4 = null, 
			string m3_HIE5 = null, 
			string m3_GRP1 = null, 
			string m3_GRP2 = null, 
			string m3_GRP3 = null, 
			string m3_GRP4 = null, 
			string m3_GRP5 = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			decimal? m3_TXID = null, 
			int? m3_ECMA = null, 
			string m3_PRGP = null, 
			int? m3_INDI = null, 
			string m3_PUUN = null, 
			int? m3_ALUC = null, 
			int? m3_IEAA = null, 
			int? m3_EXPD = null, 
			string m3_GRMT = null, 
			int? m3_HAZI = null, 
			int? m3_SALE = null, 
			string m3_TAXC = null, 
			string m3_ATMO = null, 
			int? m3_ATMN = null, 
			string m3_TPLI = null, 
			decimal? m3_FCU1 = null, 
			string m3_ALUN = null, 
			int? m3_IACP = null, 
			string m3_HDPR = null, 
			int? m3_AAD0 = null, 
			int? m3_AAD1 = null, 
			int? m3_CHCL = null, 
			int? m3_ITRC = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			string m3_ECVE = null, 
			string m3_GRTI = null, 
			int? m3_DCCD = null, 
			int? m3_PDCC = null, 
			string m3_ACRF = null, 
			string m3_EVGR = null, 
			string m3_GRTS = null, 
			string m3_ETRF = null, 
			int? m3_CAWP = null, 
			string m3_CWUN = null, 
			string m3_CPUN = null, 
			string m3_MOTP = null, 
			string m3_ACMC = null, 
			int? m3_ITRU = null, 
			string m3_TECR = null, 
			int? m3_EXCA = null, 
			string m3_ACCG = null, 
			string m3_CCCM = null, 
			string m3_CCI1 = null, 
			string m3_CRI1 = null, 
			int? m3_HVMT = null, 
			string m3_ITNE = null, 
			decimal? m3_SPGV = null, 
			int? m3_AUTC = null, 
			string m3_RIDE = null, 
			int? m3_RIDC = null, 
			int? m3_RNRI = null, 
			string m3_SAFC = null, 
			int? m3_RMSG = null, 
			string m3_PDLN = null, 
			string m3_CPGR = null, 
			int? m3_SUME = null, 
			string m3_SUMP = null, 
			string m3_QMGP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_ITDS))
				throw new ArgumentNullException("m3_ITDS");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_UNMS))
				throw new ArgumentNullException("m3_UNMS");
			if (string.IsNullOrWhiteSpace(m3_ITTY))
				throw new ArgumentNullException("m3_ITTY");
			if (string.IsNullOrWhiteSpace(m3_PRVG))
				throw new ArgumentNullException("m3_PRVG");

			// Set mandatory parameters
			request
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ITDS", m3_ITDS.Trim())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("UNMS", m3_UNMS.Trim())
				.WithQueryParameter("ITTY", m3_ITTY.Trim())
				.WithQueryParameter("MABU", m3_MABU.ToString())
				.WithQueryParameter("PRVG", m3_PRVG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUAR))
				request.WithQueryParameter("BUAR", m3_BUAR.Trim());
			if (m3_TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3_TPCD.Value.ToString());
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (m3_BACD.HasValue)
				request.WithQueryParameter("BACD", m3_BACD.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3_BYPR.Value.ToString());
			if (m3_WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3_WAPC.Value.ToString());
			if (m3_QACD.HasValue)
				request.WithQueryParameter("QACD", m3_QACD.Value.ToString());
			if (m3_EPCD.HasValue)
				request.WithQueryParameter("EPCD", m3_EPCD.Value.ToString());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3_ACTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_HIE1))
				request.WithQueryParameter("HIE1", m3_HIE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE2))
				request.WithQueryParameter("HIE2", m3_HIE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE3))
				request.WithQueryParameter("HIE3", m3_HIE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE4))
				request.WithQueryParameter("HIE4", m3_HIE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE5))
				request.WithQueryParameter("HIE5", m3_HIE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP1))
				request.WithQueryParameter("GRP1", m3_GRP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP2))
				request.WithQueryParameter("GRP2", m3_GRP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP3))
				request.WithQueryParameter("GRP3", m3_GRP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP4))
				request.WithQueryParameter("GRP4", m3_GRP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP5))
				request.WithQueryParameter("GRP5", m3_GRP5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3_ECMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRGP))
				request.WithQueryParameter("PRGP", m3_PRGP.Trim());
			if (m3_INDI.HasValue)
				request.WithQueryParameter("INDI", m3_INDI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (m3_ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3_ALUC.Value.ToString());
			if (m3_IEAA.HasValue)
				request.WithQueryParameter("IEAA", m3_IEAA.Value.ToString());
			if (m3_EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3_EXPD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (m3_HAZI.HasValue)
				request.WithQueryParameter("HAZI", m3_HAZI.Value.ToString());
			if (m3_SALE.HasValue)
				request.WithQueryParameter("SALE", m3_SALE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());
			if (m3_ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3_ATMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TPLI))
				request.WithQueryParameter("TPLI", m3_TPLI.Trim());
			if (m3_FCU1.HasValue)
				request.WithQueryParameter("FCU1", m3_FCU1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_IACP.HasValue)
				request.WithQueryParameter("IACP", m3_IACP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_HDPR))
				request.WithQueryParameter("HDPR", m3_HDPR.Trim());
			if (m3_AAD0.HasValue)
				request.WithQueryParameter("AAD0", m3_AAD0.Value.ToString());
			if (m3_AAD1.HasValue)
				request.WithQueryParameter("AAD1", m3_AAD1.Value.ToString());
			if (m3_CHCL.HasValue)
				request.WithQueryParameter("CHCL", m3_CHCL.Value.ToString());
			if (m3_ITRC.HasValue)
				request.WithQueryParameter("ITRC", m3_ITRC.Value.ToString());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTI))
				request.WithQueryParameter("GRTI", m3_GRTI.Trim());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_PDCC.HasValue)
				request.WithQueryParameter("PDCC", m3_PDCC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVGR))
				request.WithQueryParameter("EVGR", m3_EVGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTS))
				request.WithQueryParameter("GRTS", m3_GRTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETRF))
				request.WithQueryParameter("ETRF", m3_ETRF.Trim());
			if (m3_CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3_CAWP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CWUN))
				request.WithQueryParameter("CWUN", m3_CWUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPUN))
				request.WithQueryParameter("CPUN", m3_CPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACMC))
				request.WithQueryParameter("ACMC", m3_ACMC.Trim());
			if (m3_ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3_ITRU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECR))
				request.WithQueryParameter("TECR", m3_TECR.Trim());
			if (m3_EXCA.HasValue)
				request.WithQueryParameter("EXCA", m3_EXCA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACCG))
				request.WithQueryParameter("ACCG", m3_ACCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCCM))
				request.WithQueryParameter("CCCM", m3_CCCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCI1))
				request.WithQueryParameter("CCI1", m3_CCI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRI1))
				request.WithQueryParameter("CRI1", m3_CRI1.Trim());
			if (m3_HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3_HVMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNE))
				request.WithQueryParameter("ITNE", m3_ITNE.Trim());
			if (m3_SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3_SPGV.Value.ToString());
			if (m3_AUTC.HasValue)
				request.WithQueryParameter("AUTC", m3_AUTC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDE))
				request.WithQueryParameter("RIDE", m3_RIDE.Trim());
			if (m3_RIDC.HasValue)
				request.WithQueryParameter("RIDC", m3_RIDC.Value.ToString());
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SAFC))
				request.WithQueryParameter("SAFC", m3_SAFC.Trim());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PDLN))
				request.WithQueryParameter("PDLN", m3_PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (m3_SUME.HasValue)
				request.WithQueryParameter("SUME", m3_SUME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUMP))
				request.WithQueryParameter("SUMP", m3_SUMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name AddItmFac
		/// Description Add Item Facility
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LEA4">Administrative lead time</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_SPFA">Conversion factor supplementary U/M</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_APPR">Average cost</param>
		/// <param name="m3_UCOS">Cost price</param>
		/// <param name="m3_SOCO">Ordering cost</param>
		/// <param name="m3_EXPC">Yield percentage</param>
		/// <param name="m3_BQTY">Batch quantity</param>
		/// <param name="m3_BQTM">Batch quantity method</param>
		/// <param name="m3_LLCM">Lowest level - BoM</param>
		/// <param name="m3_DLET">MO lead time method</param>
		/// <param name="m3_DLEF">Dynamic lead time fence - MO</param>
		/// <param name="m3_DIDY">Flow order planning</param>
		/// <param name="m3_DIDF">Flow order fence</param>
		/// <param name="m3_PRRA">Production rate</param>
		/// <param name="m3_TRHC">Throughput rate of capacity/day</param>
		/// <param name="m3_MARC">MO reservations</param>
		/// <param name="m3_JITF">Orderless production</param>
		/// <param name="m3_REWH">Main warehouse</param>
		/// <param name="m3_OPFQ">Optimal on-hand balance - facility</param>
		/// <param name="m3_FANO">On-hand balance - facility</param>
		/// <param name="m3_FANQ">On-hand balance for inspection -facility</param>
		/// <param name="m3_FANR">Rejected on-hand balance - facility</param>
		/// <param name="m3_FATM">On-hand balance method - facility</param>
		/// <param name="m3_WCLN">Production line</param>
		/// <param name="m3_EDEC">Method for expiry date excess control</param>
		/// <param name="m3_AUGE">Automatic creation of MO</param>
		/// <param name="m3_ECCC">Consumption code - trade stat (TST)</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_CPRI">Customs procedure - import</param>
		/// <param name="m3_CPRE">Customs procedure - export</param>
		/// <param name="m3_WSCA">Costing model - purchasing</param>
		/// <param name="m3_PRCM">Costing model - product costing</param>
		/// <param name="m3_PLAP">Planning process</param>
		/// <param name="m3_PLUP">Push process</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_CPL0">Calculate price for line type 0</param>
		/// <param name="m3_CPL1">Calculate price for line type 1</param>
		/// <param name="m3_CPL2">Calculate price for line type 2</param>
		/// <param name="m3_PPL0">Preliminary price for line type 0</param>
		/// <param name="m3_PPL1">Preliminary price for line type 1</param>
		/// <param name="m3_PPL2">Preliminary price for line type 2</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_CPDC">Costing decimal places</param>
		/// <param name="m3_COCD">Item cost quantity</param>
		/// <param name="m3_EVGR">Environment group</param>
		/// <param name="m3_VAMT">Inventory accounting method</param>
		/// <param name="m3_LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3_GRTI">Group technology class</param>
		/// <param name="m3_MOLL">MO leadtime limit</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_DICM">Costing model - distribution</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_STCW">Catch weight approved on hand balance</param>
		/// <param name="m3_RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3_QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3_CAWC">Catch weight cost</param>
		/// <param name="m3_CPUN">Standard cost price unit of measure</param>
		/// <param name="m3_COFA">Conversion factor</param>
		/// <param name="m3_ALTS">Alternate structures</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmFac(
			string m3_FACI, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			int? m3_LEA4 = null, 
			string m3_CSNO = null, 
			decimal? m3_SPFA = null, 
			string m3_ORCO = null, 
			decimal? m3_APPR = null, 
			decimal? m3_UCOS = null, 
			decimal? m3_SOCO = null, 
			int? m3_EXPC = null, 
			decimal? m3_BQTY = null, 
			int? m3_BQTM = null, 
			int? m3_LLCM = null, 
			int? m3_DLET = null, 
			int? m3_DLEF = null, 
			int? m3_DIDY = null, 
			int? m3_DIDF = null, 
			int? m3_PRRA = null, 
			int? m3_TRHC = null, 
			int? m3_MARC = null, 
			int? m3_JITF = null, 
			string m3_REWH = null, 
			decimal? m3_OPFQ = null, 
			decimal? m3_FANO = null, 
			decimal? m3_FANQ = null, 
			decimal? m3_FANR = null, 
			int? m3_FATM = null, 
			string m3_WCLN = null, 
			string m3_EDEC = null, 
			int? m3_AUGE = null, 
			string m3_ECCC = null, 
			string m3_ECAR = null, 
			string m3_CPRI = null, 
			string m3_CPRE = null, 
			string m3_WSCA = null, 
			string m3_PRCM = null, 
			string m3_PLAP = null, 
			string m3_PLUP = null, 
			string m3_SCMO = null, 
			int? m3_CPL0 = null, 
			int? m3_CPL1 = null, 
			int? m3_CPL2 = null, 
			int? m3_PPL0 = null, 
			int? m3_PPL1 = null, 
			int? m3_PPL2 = null, 
			decimal? m3_TXID = null, 
			decimal? m3_DTID = null, 
			int? m3_CPDC = null, 
			int? m3_COCD = null, 
			string m3_EVGR = null, 
			int? m3_VAMT = null, 
			int? m3_LAMA = null, 
			string m3_GRTI = null, 
			int? m3_MOLL = null, 
			int? m3_CRTM = null, 
			string m3_DICM = null, 
			string m3_ACRF = null, 
			decimal? m3_STCW = null, 
			decimal? m3_RJCW = null, 
			decimal? m3_QUCW = null, 
			int? m3_CAWC = null, 
			string m3_CPUN = null, 
			decimal? m3_COFA = null, 
			int? m3_ALTS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3_LEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (m3_SPFA.HasValue)
				request.WithQueryParameter("SPFA", m3_SPFA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_APPR.HasValue)
				request.WithQueryParameter("APPR", m3_APPR.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
			if (m3_SOCO.HasValue)
				request.WithQueryParameter("SOCO", m3_SOCO.Value.ToString());
			if (m3_EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3_EXPC.Value.ToString());
			if (m3_BQTY.HasValue)
				request.WithQueryParameter("BQTY", m3_BQTY.Value.ToString());
			if (m3_BQTM.HasValue)
				request.WithQueryParameter("BQTM", m3_BQTM.Value.ToString());
			if (m3_LLCM.HasValue)
				request.WithQueryParameter("LLCM", m3_LLCM.Value.ToString());
			if (m3_DLET.HasValue)
				request.WithQueryParameter("DLET", m3_DLET.Value.ToString());
			if (m3_DLEF.HasValue)
				request.WithQueryParameter("DLEF", m3_DLEF.Value.ToString());
			if (m3_DIDY.HasValue)
				request.WithQueryParameter("DIDY", m3_DIDY.Value.ToString());
			if (m3_DIDF.HasValue)
				request.WithQueryParameter("DIDF", m3_DIDF.Value.ToString());
			if (m3_PRRA.HasValue)
				request.WithQueryParameter("PRRA", m3_PRRA.Value.ToString());
			if (m3_TRHC.HasValue)
				request.WithQueryParameter("TRHC", m3_TRHC.Value.ToString());
			if (m3_MARC.HasValue)
				request.WithQueryParameter("MARC", m3_MARC.Value.ToString());
			if (m3_JITF.HasValue)
				request.WithQueryParameter("JITF", m3_JITF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REWH))
				request.WithQueryParameter("REWH", m3_REWH.Trim());
			if (m3_OPFQ.HasValue)
				request.WithQueryParameter("OPFQ", m3_OPFQ.Value.ToString());
			if (m3_FANO.HasValue)
				request.WithQueryParameter("FANO", m3_FANO.Value.ToString());
			if (m3_FANQ.HasValue)
				request.WithQueryParameter("FANQ", m3_FANQ.Value.ToString());
			if (m3_FANR.HasValue)
				request.WithQueryParameter("FANR", m3_FANR.Value.ToString());
			if (m3_FATM.HasValue)
				request.WithQueryParameter("FATM", m3_FATM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WCLN))
				request.WithQueryParameter("WCLN", m3_WCLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDEC))
				request.WithQueryParameter("EDEC", m3_EDEC.Trim());
			if (m3_AUGE.HasValue)
				request.WithQueryParameter("AUGE", m3_AUGE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECCC))
				request.WithQueryParameter("ECCC", m3_ECCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPRI))
				request.WithQueryParameter("CPRI", m3_CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPRE))
				request.WithQueryParameter("CPRE", m3_CPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRCM))
				request.WithQueryParameter("PRCM", m3_PRCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLAP))
				request.WithQueryParameter("PLAP", m3_PLAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLUP))
				request.WithQueryParameter("PLUP", m3_PLUP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (m3_CPL0.HasValue)
				request.WithQueryParameter("CPL0", m3_CPL0.Value.ToString());
			if (m3_CPL1.HasValue)
				request.WithQueryParameter("CPL1", m3_CPL1.Value.ToString());
			if (m3_CPL2.HasValue)
				request.WithQueryParameter("CPL2", m3_CPL2.Value.ToString());
			if (m3_PPL0.HasValue)
				request.WithQueryParameter("PPL0", m3_PPL0.Value.ToString());
			if (m3_PPL1.HasValue)
				request.WithQueryParameter("PPL1", m3_PPL1.Value.ToString());
			if (m3_PPL2.HasValue)
				request.WithQueryParameter("PPL2", m3_PPL2.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_CPDC.HasValue)
				request.WithQueryParameter("CPDC", m3_CPDC.Value.ToString());
			if (m3_COCD.HasValue)
				request.WithQueryParameter("COCD", m3_COCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVGR))
				request.WithQueryParameter("EVGR", m3_EVGR.Trim());
			if (m3_VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3_VAMT.Value.ToString());
			if (m3_LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3_LAMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRTI))
				request.WithQueryParameter("GRTI", m3_GRTI.Trim());
			if (m3_MOLL.HasValue)
				request.WithQueryParameter("MOLL", m3_MOLL.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DICM))
				request.WithQueryParameter("DICM", m3_DICM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_STCW.HasValue)
				request.WithQueryParameter("STCW", m3_STCW.Value.ToString());
			if (m3_RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3_RJCW.Value.ToString());
			if (m3_QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3_QUCW.Value.ToString());
			if (m3_CAWC.HasValue)
				request.WithQueryParameter("CAWC", m3_CAWC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CPUN))
				request.WithQueryParameter("CPUN", m3_CPUN.Trim());
			if (m3_COFA.HasValue)
				request.WithQueryParameter("COFA", m3_COFA.Value.ToString());
			if (m3_ALTS.HasValue)
				request.WithQueryParameter("ALTS", m3_ALTS.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name AddItmTrpFrelnf
		/// Description Add Item Transport Information , fields A001-A040
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_A001">Alpha field 30 positions</param>
		/// <param name="m3_A002">Alpha field 30 positions</param>
		/// <param name="m3_A003">Alpha field 30 positions</param>
		/// <param name="m3_A004">Alpha field 30 positions</param>
		/// <param name="m3_A005">Alpha field 30 positions</param>
		/// <param name="m3_A006">Alpha field 30 positions</param>
		/// <param name="m3_A007">Alpha field 30 positions</param>
		/// <param name="m3_A008">Alpha field 30 positions</param>
		/// <param name="m3_A009">Alpha field 30 positions</param>
		/// <param name="m3_A010">Alpha field 30 positions</param>
		/// <param name="m3_A021">Alpha field 1 positions</param>
		/// <param name="m3_A022">Alpha field 1 positions</param>
		/// <param name="m3_A023">Alpha field 1 positions</param>
		/// <param name="m3_A024">Alpha field 1 positions</param>
		/// <param name="m3_A025">Alpha field 1 positions</param>
		/// <param name="m3_A026">Alpha field 5 positions</param>
		/// <param name="m3_A027">Alpha field 5 positions</param>
		/// <param name="m3_A028">Alpha field 5 positions</param>
		/// <param name="m3_A029">Alpha field 5 positions</param>
		/// <param name="m3_A030">Alpha field 5 positions</param>
		/// <param name="m3_A031">Alpha field 10 positions</param>
		/// <param name="m3_A032">Alpha field 10 positions</param>
		/// <param name="m3_A033">Alpha field 10 positions</param>
		/// <param name="m3_A034">Alpha field 10 positions</param>
		/// <param name="m3_A035">Alpha field 10 positions</param>
		/// <param name="m3_A036">Alpha field 15 positions</param>
		/// <param name="m3_A037">Alpha field 15 positions</param>
		/// <param name="m3_A038">Alpha field 15 positions</param>
		/// <param name="m3_A039">Alpha field 15 positions</param>
		/// <param name="m3_A040">Alpha field 15 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmTrpFrelnf(
			string m3_ITNO, 
			string m3_A001 = null, 
			string m3_A002 = null, 
			string m3_A003 = null, 
			string m3_A004 = null, 
			string m3_A005 = null, 
			string m3_A006 = null, 
			string m3_A007 = null, 
			string m3_A008 = null, 
			string m3_A009 = null, 
			string m3_A010 = null, 
			string m3_A021 = null, 
			string m3_A022 = null, 
			string m3_A023 = null, 
			string m3_A024 = null, 
			string m3_A025 = null, 
			string m3_A026 = null, 
			string m3_A027 = null, 
			string m3_A028 = null, 
			string m3_A029 = null, 
			string m3_A030 = null, 
			string m3_A031 = null, 
			string m3_A032 = null, 
			string m3_A033 = null, 
			string m3_A034 = null, 
			string m3_A035 = null, 
			string m3_A036 = null, 
			string m3_A037 = null, 
			string m3_A038 = null, 
			string m3_A039 = null, 
			string m3_A040 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_A001))
				request.WithQueryParameter("A001", m3_A001.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A002))
				request.WithQueryParameter("A002", m3_A002.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A003))
				request.WithQueryParameter("A003", m3_A003.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A004))
				request.WithQueryParameter("A004", m3_A004.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A005))
				request.WithQueryParameter("A005", m3_A005.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A006))
				request.WithQueryParameter("A006", m3_A006.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A007))
				request.WithQueryParameter("A007", m3_A007.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A008))
				request.WithQueryParameter("A008", m3_A008.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A009))
				request.WithQueryParameter("A009", m3_A009.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A010))
				request.WithQueryParameter("A010", m3_A010.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A021))
				request.WithQueryParameter("A021", m3_A021.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A022))
				request.WithQueryParameter("A022", m3_A022.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A023))
				request.WithQueryParameter("A023", m3_A023.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A024))
				request.WithQueryParameter("A024", m3_A024.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A025))
				request.WithQueryParameter("A025", m3_A025.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A026))
				request.WithQueryParameter("A026", m3_A026.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A027))
				request.WithQueryParameter("A027", m3_A027.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A028))
				request.WithQueryParameter("A028", m3_A028.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A029))
				request.WithQueryParameter("A029", m3_A029.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A030))
				request.WithQueryParameter("A030", m3_A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A031))
				request.WithQueryParameter("A031", m3_A031.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A032))
				request.WithQueryParameter("A032", m3_A032.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A033))
				request.WithQueryParameter("A033", m3_A033.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A034))
				request.WithQueryParameter("A034", m3_A034.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A035))
				request.WithQueryParameter("A035", m3_A035.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A036))
				request.WithQueryParameter("A036", m3_A036.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A037))
				request.WithQueryParameter("A037", m3_A037.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A038))
				request.WithQueryParameter("A038", m3_A038.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A039))
				request.WithQueryParameter("A039", m3_A039.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A040))
				request.WithQueryParameter("A040", m3_A040.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name AddItmTrplnf
		/// Description Add Item Transport Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_UNNN">UN number</param>
		/// <param name="m3_NNNN">NA number</param>
		/// <param name="m3_CASN">CAS number</param>
		/// <param name="m3_ECNM">EU number</param>
		/// <param name="m3_EINM">EINECS number</param>
		/// <param name="m3_ATOM">Atomic number</param>
		/// <param name="m3_CEAN">CEA number</param>
		/// <param name="m3_NAIC">NAICS code</param>
		/// <param name="m3_ITEQ">Item equipment profile</param>
		/// <param name="m3_CMMC">Freight commodity code</param>
		/// <param name="m3_HAZM">Hazardous material</param>
		/// <param name="m3_CMCL">Commodity class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmTrplnf(
			string m3_ITNO, 
			int? m3_UNNN = null, 
			string m3_NNNN = null, 
			string m3_CASN = null, 
			string m3_ECNM = null, 
			string m3_EINM = null, 
			string m3_ATOM = null, 
			string m3_CEAN = null, 
			int? m3_NAIC = null, 
			string m3_ITEQ = null, 
			string m3_CMMC = null, 
			int? m3_HAZM = null, 
			string m3_CMCL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3_UNNN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NNNN))
				request.WithQueryParameter("NNNN", m3_NNNN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CASN))
				request.WithQueryParameter("CASN", m3_CASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECNM))
				request.WithQueryParameter("ECNM", m3_ECNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EINM))
				request.WithQueryParameter("EINM", m3_EINM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATOM))
				request.WithQueryParameter("ATOM", m3_ATOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CEAN))
				request.WithQueryParameter("CEAN", m3_CEAN.Trim());
			if (m3_NAIC.HasValue)
				request.WithQueryParameter("NAIC", m3_NAIC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITEQ))
				request.WithQueryParameter("ITEQ", m3_ITEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMMC))
				request.WithQueryParameter("CMMC", m3_CMMC.Trim());
			if (m3_HAZM.HasValue)
				request.WithQueryParameter("HAZM", m3_HAZM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CMCL))
				request.WithQueryParameter("CMCL", m3_CMCL.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name AddItmViaItmTyp
		/// Description Add Item Via Item Type
		/// Version Release: 5ea8
		/// </summary>
		/// <param name="m3_ITTY">Item type (Required)</param>
		/// <param name="m3_ITDS">Name (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_ITNE">Extended item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddItmViaItmTypResponse></returns>
		/// <exception cref="M3Exception<AddItmViaItmTypResponse>"></exception>
		public async Task<M3Response<AddItmViaItmTypResponse>> AddItmViaItmTyp(
			string m3_ITTY, 
			string m3_ITDS, 
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_FUDS = null, 
			string m3_ITNE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITTY))
				throw new ArgumentNullException("m3_ITTY");
			if (string.IsNullOrWhiteSpace(m3_ITDS))
				throw new ArgumentNullException("m3_ITDS");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITTY", m3_ITTY.Trim())
				.WithQueryParameter("ITDS", m3_ITDS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNE))
				request.WithQueryParameter("ITNE", m3_ITNE.Trim());

			// Execute the request
			var result = await Execute<AddItmViaItmTypResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name AddItmWhs
		/// Description Add Item Warehouse
		/// Version Release: 5ea8
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ALMT">Allocation method (Required)</param>
		/// <param name="m3_STMT">Storage method (Required)</param>
		/// <param name="m3_SPMT">Issue method (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_PLCD">Planning policy (Required)</param>
		/// <param name="m3_ABCD">ABC class - volume (Required)</param>
		/// <param name="m3_ABFC">ABC class - frequency (Required)</param>
		/// <param name="m3_ACOC">ABC class - contribution (Required)</param>
		/// <param name="m3_PUIT">Acquisition code (Required)</param>
		/// <param name="m3_ORTY">Order type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_STRL">History storage method (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_CPCD">CTP policy (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STQT">On-hand balance approved</param>
		/// <param name="m3_QUQT">On-hand balance for inspection</param>
		/// <param name="m3_RJQT">Rejected on-hand balance</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3_AVAL">Allocatable on-hand balance</param>
		/// <param name="m3_PLQT">Picking list quantity - basic U/M</param>
		/// <param name="m3_COMG">Container management</param>
		/// <param name="m3_STTX">Note</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_REQT">Reserved quantity</param>
		/// <param name="m3_RLQT">Reserved quantity to backorder</param>
		/// <param name="m3_REQP">Reserved quantity - planned orders</param>
		/// <param name="m3_IDDT">Last receipt date</param>
		/// <param name="m3_ODDT">Last issue date</param>
		/// <param name="m3_INDT">Latest physical inventory date</param>
		/// <param name="m3_PRDC">Priority date selection</param>
		/// <param name="m3_INCD">Physical inventory cycle</param>
		/// <param name="m3_NUIN">Number of records for physical inventory</param>
		/// <param name="m3_USYE">Annual usage</param>
		/// <param name="m3_AVST">Average on-hand balance</param>
		/// <param name="m3_DILE">Projected on-hand at end of lead time</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_WHTY">Warehouse type</param>
		/// <param name="m3_WHSY">Warehouse subtype</param>
		/// <param name="m3_INSC">Statistics storage group</param>
		/// <param name="m3_DIGR">Distribution group</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_NUS7">Number of balance IDs</param>
		/// <param name="m3_TOMU">Issue multiple</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="m3_MABC">ABC class - manual</param>
		/// <param name="m3_ABCM">ABC method  - volume</param>
		/// <param name="m3_ABFM">ABC method - frequency</param>
		/// <param name="m3_ACOM">ABC method - contribution</param>
		/// <param name="m3_PRIF">Priority value</param>
		/// <param name="m3_SODY">Run-out time</param>
		/// <param name="m3_REOP">Reorder point</param>
		/// <param name="m3_OPOM">Reorder point method</param>
		/// <param name="m3_SSQT">Safety stock</param>
		/// <param name="m3_SSMT">Safety stock method</param>
		/// <param name="m3_MSSQ">Manual safety stock</param>
		/// <param name="m3_SSDA">Safety stock unit</param>
		/// <param name="m3_SCGR">Service level</param>
		/// <param name="m3_MXST">Maximum stock</param>
		/// <param name="m3_MXSM">Maximum stock method</param>
		/// <param name="m3_MXPC">Maximum stock percentage</param>
		/// <param name="m3_EOQT">Order quantity</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_EQDA">Economical order quantity days</param>
		/// <param name="m3_YEQT">Annual demand</param>
		/// <param name="m3_YEQM">Annual demand method</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_MOQT">Maximum order quantity</param>
		/// <param name="m3_SUWH">Supplying warehouse</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_PRCD">Forecast method</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_LYQT">Fixed annual demand</param>
		/// <param name="m3_LRYE">Fixed acquisition requirement</param>
		/// <param name="m3_PFTM">Planning time fence</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_LEA2">Inspection lead time</param>
		/// <param name="m3_LEA3">Transportation lead time</param>
		/// <param name="m3_LEAT">Lead time</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_SVEI">Multiple supply</param>
		/// <param name="m3_LEVL">Lowest level</param>
		/// <param name="m3_LEVD">Lowest level DO</param>
		/// <param name="m3_PLHZ">Planning horizon</param>
		/// <param name="m3_DMFN">Demand time fence</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_SATD">Safety time</param>
		/// <param name="m3_ALQC">Quantity controlled allocation</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_SHCC">Distribution/supplier calendar check</param>
		/// <param name="m3_ZCAC">Zero mark</param>
		/// <param name="m3_INSL">Inspection location</param>
		/// <param name="m3_NCCA">Net change calculation active</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DDEX">Time phased safety stock exists</param>
		/// <param name="m3_PLIC">Picking list information control</param>
		/// <param name="m3_PPMC">Pending planning method change</param>
		/// <param name="m3_MPCD">Calculation date - material planning</param>
		/// <param name="m3_MPCT">Calculation time - material planning</param>
		/// <param name="m3_DCSS">Time phased safety stock</param>
		/// <param name="m3_RPOP">Responsible - planned purchase order</param>
		/// <param name="m3_BCOS">Standard cost - warehouse</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_DPLO">Default pack location</param>
		/// <param name="m3_DDLO">Default docking location</param>
		/// <param name="m3_SPLC">Delivery split rule</param>
		/// <param name="m3_ALS1">Allocate non-approved balance ID</param>
		/// <param name="m3_POOT">Point of time table</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_MNUN">Main unit of calculation</param>
		/// <param name="m3_GRTS">Distribution group technology</param>
		/// <param name="m3_SLDY">Shelf life</param>
		/// <param name="m3_REDY">Reinspection time</param>
		/// <param name="m3_SAEL">Sales time</param>
		/// <param name="m3_LEAQ">Quarantine lead time</param>
		/// <param name="m3_SCHT">Scheduled reclassification allowed</param>
		/// <param name="m3_STCW">Catch weight approved on hand balance</param>
		/// <param name="m3_RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3_QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3_IPLA">Inventory planned</param>
		/// <param name="m3_BBTM">Best before time</param>
		/// <param name="m3_FSSQ">Frozen safety stock</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_SSRE">SS reason code</param>
		/// <param name="m3_ISEG">Inventory segment</param>
		/// <param name="m3_SALM">Secondary allocation method</param>
		/// <param name="m3_SCPO">Supply chain policy</param>
		/// <param name="m3_AGDY">Aging days</param>
		/// <param name="m3_AGHO">Aging hours</param>
		/// <param name="m3_AGMI">Aging minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmWhs(
			string m3_WHLO, 
			string m3_ITNO, 
			int m3_ALMT, 
			int m3_STMT, 
			int m3_SPMT, 
			string m3_RESP, 
			string m3_PLCD, 
			string m3_ABCD, 
			string m3_ABFC, 
			string m3_ACOC, 
			int m3_PUIT, 
			string m3_ORTY, 
			string m3_FACI, 
			int m3_STRL, 
			string m3_STAT, 
			string m3_CPCD, 
			int? m3_CONO = null, 
			decimal? m3_STQT = null, 
			decimal? m3_QUQT = null, 
			decimal? m3_RJQT = null, 
			decimal? m3_ALQT = null, 
			decimal? m3_AVAL = null, 
			decimal? m3_PLQT = null, 
			int? m3_COMG = null, 
			string m3_STTX = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_REQT = null, 
			decimal? m3_RLQT = null, 
			decimal? m3_REQP = null, 
			DateTime? m3_IDDT = null, 
			DateTime? m3_ODDT = null, 
			DateTime? m3_INDT = null, 
			int? m3_PRDC = null, 
			string m3_INCD = null, 
			int? m3_NUIN = null, 
			decimal? m3_USYE = null, 
			decimal? m3_AVST = null, 
			decimal? m3_DILE = null, 
			string m3_BUYE = null, 
			string m3_SUNO = null, 
			string m3_WHTY = null, 
			string m3_WHSY = null, 
			int? m3_INSC = null, 
			string m3_DIGR = null, 
			string m3_WHSL = null, 
			string m3_SLTP = null, 
			int? m3_NUS7 = null, 
			decimal? m3_TOMU = null, 
			string m3_WHLT = null, 
			string m3_PISE = null, 
			string m3_MABC = null, 
			int? m3_ABCM = null, 
			int? m3_ABFM = null, 
			int? m3_ACOM = null, 
			int? m3_PRIF = null, 
			int? m3_SODY = null, 
			decimal? m3_REOP = null, 
			int? m3_OPOM = null, 
			decimal? m3_SSQT = null, 
			int? m3_SSMT = null, 
			decimal? m3_MSSQ = null, 
			int? m3_SSDA = null, 
			int? m3_SCGR = null, 
			decimal? m3_MXST = null, 
			int? m3_MXSM = null, 
			int? m3_MXPC = null, 
			decimal? m3_EOQT = null, 
			int? m3_EOQM = null, 
			int? m3_EQDA = null, 
			decimal? m3_YEQT = null, 
			int? m3_YEQM = null, 
			decimal? m3_LOQT = null, 
			decimal? m3_MOQT = null, 
			string m3_SUWH = null, 
			int? m3_DPID = null, 
			string m3_PRCD = null, 
			string m3_FCCM = null, 
			decimal? m3_LYQT = null, 
			decimal? m3_LRYE = null, 
			int? m3_PFTM = null, 
			int? m3_LEA1 = null, 
			int? m3_LEA2 = null, 
			int? m3_LEA3 = null, 
			int? m3_LEAT = null, 
			decimal? m3_UNMU = null, 
			int? m3_SVEI = null, 
			int? m3_LEVL = null, 
			int? m3_LEVD = null, 
			int? m3_PLHZ = null, 
			int? m3_DMFN = null, 
			int? m3_CONC = null, 
			int? m3_SATD = null, 
			int? m3_ALQC = null, 
			int? m3_OPLC = null, 
			int? m3_MSCH = null, 
			int? m3_SHCC = null, 
			int? m3_ZCAC = null, 
			string m3_INSL = null, 
			int? m3_NCCA = null, 
			string m3_DIVI = null, 
			int? m3_DDEX = null, 
			int? m3_PLIC = null, 
			int? m3_PPMC = null, 
			DateTime? m3_MPCD = null, 
			int? m3_MPCT = null, 
			int? m3_DCSS = null, 
			int? m3_RPOP = null, 
			decimal? m3_BCOS = null, 
			decimal? m3_TXID = null, 
			decimal? m3_DTID = null, 
			string m3_DPLO = null, 
			string m3_DDLO = null, 
			string m3_SPLC = null, 
			int? m3_ALS1 = null, 
			string m3_POOT = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			string m3_MNUN = null, 
			string m3_GRTS = null, 
			int? m3_SLDY = null, 
			int? m3_REDY = null, 
			int? m3_SAEL = null, 
			int? m3_LEAQ = null, 
			int? m3_SCHT = null, 
			decimal? m3_STCW = null, 
			decimal? m3_RJCW = null, 
			decimal? m3_QUCW = null, 
			string m3_IPLA = null, 
			int? m3_BBTM = null, 
			int? m3_FSSQ = null, 
			int? m3_RNRI = null, 
			int? m3_RMSG = null, 
			string m3_SSRE = null, 
			string m3_ISEG = null, 
			int? m3_SALM = null, 
			string m3_SCPO = null, 
			int? m3_AGDY = null, 
			int? m3_AGHO = null, 
			int? m3_AGMI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_PLCD))
				throw new ArgumentNullException("m3_PLCD");
			if (string.IsNullOrWhiteSpace(m3_ABCD))
				throw new ArgumentNullException("m3_ABCD");
			if (string.IsNullOrWhiteSpace(m3_ABFC))
				throw new ArgumentNullException("m3_ABFC");
			if (string.IsNullOrWhiteSpace(m3_ACOC))
				throw new ArgumentNullException("m3_ACOC");
			if (string.IsNullOrWhiteSpace(m3_ORTY))
				throw new ArgumentNullException("m3_ORTY");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");
			if (string.IsNullOrWhiteSpace(m3_CPCD))
				throw new ArgumentNullException("m3_CPCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ALMT", m3_ALMT.ToString())
				.WithQueryParameter("STMT", m3_STMT.ToString())
				.WithQueryParameter("SPMT", m3_SPMT.ToString())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("PLCD", m3_PLCD.Trim())
				.WithQueryParameter("ABCD", m3_ABCD.Trim())
				.WithQueryParameter("ABFC", m3_ABFC.Trim())
				.WithQueryParameter("ACOC", m3_ACOC.Trim())
				.WithQueryParameter("PUIT", m3_PUIT.ToString())
				.WithQueryParameter("ORTY", m3_ORTY.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("STRL", m3_STRL.ToString())
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("CPCD", m3_CPCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STQT.HasValue)
				request.WithQueryParameter("STQT", m3_STQT.Value.ToString());
			if (m3_QUQT.HasValue)
				request.WithQueryParameter("QUQT", m3_QUQT.Value.ToString());
			if (m3_RJQT.HasValue)
				request.WithQueryParameter("RJQT", m3_RJQT.Value.ToString());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());
			if (m3_AVAL.HasValue)
				request.WithQueryParameter("AVAL", m3_AVAL.Value.ToString());
			if (m3_PLQT.HasValue)
				request.WithQueryParameter("PLQT", m3_PLQT.Value.ToString());
			if (m3_COMG.HasValue)
				request.WithQueryParameter("COMG", m3_COMG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STTX))
				request.WithQueryParameter("STTX", m3_STTX.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_REQT.HasValue)
				request.WithQueryParameter("REQT", m3_REQT.Value.ToString());
			if (m3_RLQT.HasValue)
				request.WithQueryParameter("RLQT", m3_RLQT.Value.ToString());
			if (m3_REQP.HasValue)
				request.WithQueryParameter("REQP", m3_REQP.Value.ToString());
			if (m3_IDDT.HasValue)
				request.WithQueryParameter("IDDT", m3_IDDT.Value.ToM3String());
			if (m3_ODDT.HasValue)
				request.WithQueryParameter("ODDT", m3_ODDT.Value.ToM3String());
			if (m3_INDT.HasValue)
				request.WithQueryParameter("INDT", m3_INDT.Value.ToM3String());
			if (m3_PRDC.HasValue)
				request.WithQueryParameter("PRDC", m3_PRDC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INCD))
				request.WithQueryParameter("INCD", m3_INCD.Trim());
			if (m3_NUIN.HasValue)
				request.WithQueryParameter("NUIN", m3_NUIN.Value.ToString());
			if (m3_USYE.HasValue)
				request.WithQueryParameter("USYE", m3_USYE.Value.ToString());
			if (m3_AVST.HasValue)
				request.WithQueryParameter("AVST", m3_AVST.Value.ToString());
			if (m3_DILE.HasValue)
				request.WithQueryParameter("DILE", m3_DILE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHTY))
				request.WithQueryParameter("WHTY", m3_WHTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSY))
				request.WithQueryParameter("WHSY", m3_WHSY.Trim());
			if (m3_INSC.HasValue)
				request.WithQueryParameter("INSC", m3_INSC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIGR))
				request.WithQueryParameter("DIGR", m3_DIGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (m3_NUS7.HasValue)
				request.WithQueryParameter("NUS7", m3_NUS7.Value.ToString());
			if (m3_TOMU.HasValue)
				request.WithQueryParameter("TOMU", m3_TOMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MABC))
				request.WithQueryParameter("MABC", m3_MABC.Trim());
			if (m3_ABCM.HasValue)
				request.WithQueryParameter("ABCM", m3_ABCM.Value.ToString());
			if (m3_ABFM.HasValue)
				request.WithQueryParameter("ABFM", m3_ABFM.Value.ToString());
			if (m3_ACOM.HasValue)
				request.WithQueryParameter("ACOM", m3_ACOM.Value.ToString());
			if (m3_PRIF.HasValue)
				request.WithQueryParameter("PRIF", m3_PRIF.Value.ToString());
			if (m3_SODY.HasValue)
				request.WithQueryParameter("SODY", m3_SODY.Value.ToString());
			if (m3_REOP.HasValue)
				request.WithQueryParameter("REOP", m3_REOP.Value.ToString());
			if (m3_OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3_OPOM.Value.ToString());
			if (m3_SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3_SSQT.Value.ToString());
			if (m3_SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3_SSMT.Value.ToString());
			if (m3_MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3_MSSQ.Value.ToString());
			if (m3_SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3_SSDA.Value.ToString());
			if (m3_SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3_SCGR.Value.ToString());
			if (m3_MXST.HasValue)
				request.WithQueryParameter("MXST", m3_MXST.Value.ToString());
			if (m3_MXSM.HasValue)
				request.WithQueryParameter("MXSM", m3_MXSM.Value.ToString());
			if (m3_MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3_MXPC.Value.ToString());
			if (m3_EOQT.HasValue)
				request.WithQueryParameter("EOQT", m3_EOQT.Value.ToString());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3_EQDA.Value.ToString());
			if (m3_YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3_YEQT.Value.ToString());
			if (m3_YEQM.HasValue)
				request.WithQueryParameter("YEQM", m3_YEQM.Value.ToString());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3_MOQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUWH))
				request.WithQueryParameter("SUWH", m3_SUWH.Trim());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRCD))
				request.WithQueryParameter("PRCD", m3_PRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_LYQT.HasValue)
				request.WithQueryParameter("LYQT", m3_LYQT.Value.ToString());
			if (m3_LRYE.HasValue)
				request.WithQueryParameter("LRYE", m3_LRYE.Value.ToString());
			if (m3_PFTM.HasValue)
				request.WithQueryParameter("PFTM", m3_PFTM.Value.ToString());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (m3_LEA2.HasValue)
				request.WithQueryParameter("LEA2", m3_LEA2.Value.ToString());
			if (m3_LEA3.HasValue)
				request.WithQueryParameter("LEA3", m3_LEA3.Value.ToString());
			if (m3_LEAT.HasValue)
				request.WithQueryParameter("LEAT", m3_LEAT.Value.ToString());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (m3_SVEI.HasValue)
				request.WithQueryParameter("SVEI", m3_SVEI.Value.ToString());
			if (m3_LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3_LEVL.Value.ToString());
			if (m3_LEVD.HasValue)
				request.WithQueryParameter("LEVD", m3_LEVD.Value.ToString());
			if (m3_PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3_PLHZ.Value.ToString());
			if (m3_DMFN.HasValue)
				request.WithQueryParameter("DMFN", m3_DMFN.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (m3_SATD.HasValue)
				request.WithQueryParameter("SATD", m3_SATD.Value.ToString());
			if (m3_ALQC.HasValue)
				request.WithQueryParameter("ALQC", m3_ALQC.Value.ToString());
			if (m3_OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3_OPLC.Value.ToString());
			if (m3_MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3_MSCH.Value.ToString());
			if (m3_SHCC.HasValue)
				request.WithQueryParameter("SHCC", m3_SHCC.Value.ToString());
			if (m3_ZCAC.HasValue)
				request.WithQueryParameter("ZCAC", m3_ZCAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INSL))
				request.WithQueryParameter("INSL", m3_INSL.Trim());
			if (m3_NCCA.HasValue)
				request.WithQueryParameter("NCCA", m3_NCCA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_DDEX.HasValue)
				request.WithQueryParameter("DDEX", m3_DDEX.Value.ToString());
			if (m3_PLIC.HasValue)
				request.WithQueryParameter("PLIC", m3_PLIC.Value.ToString());
			if (m3_PPMC.HasValue)
				request.WithQueryParameter("PPMC", m3_PPMC.Value.ToString());
			if (m3_MPCD.HasValue)
				request.WithQueryParameter("MPCD", m3_MPCD.Value.ToM3String());
			if (m3_MPCT.HasValue)
				request.WithQueryParameter("MPCT", m3_MPCT.Value.ToString());
			if (m3_DCSS.HasValue)
				request.WithQueryParameter("DCSS", m3_DCSS.Value.ToString());
			if (m3_RPOP.HasValue)
				request.WithQueryParameter("RPOP", m3_RPOP.Value.ToString());
			if (m3_BCOS.HasValue)
				request.WithQueryParameter("BCOS", m3_BCOS.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DPLO))
				request.WithQueryParameter("DPLO", m3_DPLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DDLO))
				request.WithQueryParameter("DDLO", m3_DDLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLC))
				request.WithQueryParameter("SPLC", m3_SPLC.Trim());
			if (m3_ALS1.HasValue)
				request.WithQueryParameter("ALS1", m3_ALS1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POOT))
				request.WithQueryParameter("POOT", m3_POOT.Trim());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MNUN))
				request.WithQueryParameter("MNUN", m3_MNUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTS))
				request.WithQueryParameter("GRTS", m3_GRTS.Trim());
			if (m3_SLDY.HasValue)
				request.WithQueryParameter("SLDY", m3_SLDY.Value.ToString());
			if (m3_REDY.HasValue)
				request.WithQueryParameter("REDY", m3_REDY.Value.ToString());
			if (m3_SAEL.HasValue)
				request.WithQueryParameter("SAEL", m3_SAEL.Value.ToString());
			if (m3_LEAQ.HasValue)
				request.WithQueryParameter("LEAQ", m3_LEAQ.Value.ToString());
			if (m3_SCHT.HasValue)
				request.WithQueryParameter("SCHT", m3_SCHT.Value.ToString());
			if (m3_STCW.HasValue)
				request.WithQueryParameter("STCW", m3_STCW.Value.ToString());
			if (m3_RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3_RJCW.Value.ToString());
			if (m3_QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3_QUCW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IPLA))
				request.WithQueryParameter("IPLA", m3_IPLA.Trim());
			if (m3_BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3_BBTM.Value.ToString());
			if (m3_FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3_FSSQ.Value.ToString());
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSRE))
				request.WithQueryParameter("SSRE", m3_SSRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISEG))
				request.WithQueryParameter("ISEG", m3_ISEG.Trim());
			if (m3_SALM.HasValue)
				request.WithQueryParameter("SALM", m3_SALM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPO))
				request.WithQueryParameter("SCPO", m3_SCPO.Trim());
			if (m3_AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3_AGDY.Value.ToString());
			if (m3_AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3_AGHO.Value.ToString());
			if (m3_AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3_AGMI.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CpyItmBasic
		/// Description Copy Item Basic
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CITN">Copy Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_BUAR">Business area</param>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_CITT">Copy Item type</param>
		/// <param name="m3_TPCD">Item category</param>
		/// <param name="m3_MABU">Make/buy code</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_BACD">Lot numbering method</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_BYPR">By/co-product code</param>
		/// <param name="m3_WAPC">Normal waste percentage</param>
		/// <param name="m3_QACD">Inspection code</param>
		/// <param name="m3_EPCD">Yield calculation</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_ACTI">Active or catch weight item</param>
		/// <param name="m3_HIE1">Hierachy level 1</param>
		/// <param name="m3_HIE2">Hierachy level 2</param>
		/// <param name="m3_HIE3">Hierachy level 3</param>
		/// <param name="m3_HIE4">Hierachy level 4</param>
		/// <param name="m3_HIE5">Hierachy level 5</param>
		/// <param name="m3_GRP1">Search group 1</param>
		/// <param name="m3_GRP2">Search group 2</param>
		/// <param name="m3_GRP3">Search group 3</param>
		/// <param name="m3_GRP4">Search group 4</param>
		/// <param name="m3_GRP5">Search group 5</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ECMA">ECO managed</param>
		/// <param name="m3_PRGP">Procurement group</param>
		/// <param name="m3_INDI">Lot control method</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_ALUC">Alternate U/M in use</param>
		/// <param name="m3_IEAA">Item exists as alias identity</param>
		/// <param name="m3_EXPD">Expiration date method</param>
		/// <param name="m3_GRMT">Goods receiving method</param>
		/// <param name="m3_HAZI">Danger indicator</param>
		/// <param name="m3_SALE">Sales item</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="m3_ATMN">Attribute managed</param>
		/// <param name="m3_TPLI">Template item number</param>
		/// <param name="m3_FCU1">Estimated consumption free capacity unit</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_IACP">Attribute-controlled item</param>
		/// <param name="m3_HDPR">Main product</param>
		/// <param name="m3_AAD0">Extended QA used</param>
		/// <param name="m3_AAD1">Generate txt from text template</param>
		/// <param name="m3_CHCL">Charge calculation</param>
		/// <param name="m3_ITRC">Individual item tracing</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_EVGR">Envirenment group</param>
		/// <param name="m3_GRTS">Distribution group technology</param>
		/// <param name="m3_ETRF">External instruction</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_GRTI">Group Technology Class</param>
		/// <param name="m3_CAWP">Catch weight mode</param>
		/// <param name="m3_CWUN">Catch weight unit of measure</param>
		/// <param name="m3_CPUN">Standard cost price unit of measure</param>
		/// <param name="m3_ITRU">Included in territorial roll-up</param>
		/// <param name="m3_TECR">Core terms</param>
		/// <param name="m3_EXCA">Exchangeable</param>
		/// <param name="m3_ACCG">Acceptance group</param>
		/// <param name="m3_CCCM">Costing model - core charge</param>
		/// <param name="m3_CCI1">Core charge item number</param>
		/// <param name="m3_CRI1">Core remain item number</param>
		/// <param name="m3_HVMT">Harvest Method</param>
		/// <param name="m3_ITNE">Extended item number</param>
		/// <param name="m3_SPGV">Specific gravity</param>
		/// <param name="m3_PDLN">Product line</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_SUME">Sublot method</param>
		/// <param name="m3_SUMP">Sublot policy</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CpyItmBasicResponse></returns>
		/// <exception cref="M3Exception<CpyItmBasicResponse>"></exception>
		public async Task<M3Response<CpyItmBasicResponse>> CpyItmBasic(
			string m3_STAT, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_CITN = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_DWNO = null, 
			string m3_RESP = null, 
			string m3_UNMS = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_BUAR = null, 
			string m3_ITTY = null, 
			string m3_CITT = null, 
			int? m3_TPCD = null, 
			int? m3_MABU = null, 
			int? m3_CHCD = null, 
			int? m3_STCD = null, 
			int? m3_BACD = null, 
			decimal? m3_VOL3 = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			string m3_PPUN = null, 
			int? m3_BYPR = null, 
			int? m3_WAPC = null, 
			int? m3_QACD = null, 
			int? m3_EPCD = null, 
			int? m3_POCY = null, 
			int? m3_ACTI = null, 
			string m3_HIE1 = null, 
			string m3_HIE2 = null, 
			string m3_HIE3 = null, 
			string m3_HIE4 = null, 
			string m3_HIE5 = null, 
			string m3_GRP1 = null, 
			string m3_GRP2 = null, 
			string m3_GRP3 = null, 
			string m3_GRP4 = null, 
			string m3_GRP5 = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI5 = null, 
			string m3_CFI4 = null, 
			decimal? m3_TXID = null, 
			int? m3_ECMA = null, 
			string m3_PRGP = null, 
			int? m3_INDI = null, 
			string m3_PUUN = null, 
			int? m3_ALUC = null, 
			int? m3_IEAA = null, 
			int? m3_EXPD = null, 
			string m3_GRMT = null, 
			int? m3_HAZI = null, 
			int? m3_SALE = null, 
			string m3_TAXC = null, 
			string m3_ATMO = null, 
			int? m3_ATMN = null, 
			string m3_TPLI = null, 
			decimal? m3_FCU1 = null, 
			string m3_ALUN = null, 
			int? m3_IACP = null, 
			string m3_HDPR = null, 
			int? m3_AAD0 = null, 
			int? m3_AAD1 = null, 
			int? m3_CHCL = null, 
			int? m3_ITRC = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			string m3_EVGR = null, 
			string m3_GRTS = null, 
			string m3_ETRF = null, 
			string m3_ECVE = null, 
			string m3_GRTI = null, 
			int? m3_CAWP = null, 
			string m3_CWUN = null, 
			string m3_CPUN = null, 
			int? m3_ITRU = null, 
			string m3_TECR = null, 
			int? m3_EXCA = null, 
			string m3_ACCG = null, 
			string m3_CCCM = null, 
			string m3_CCI1 = null, 
			string m3_CRI1 = null, 
			int? m3_HVMT = null, 
			string m3_ITNE = null, 
			decimal? m3_SPGV = null, 
			string m3_PDLN = null, 
			string m3_CPGR = null, 
			int? m3_SUME = null, 
			string m3_SUMP = null, 
			string m3_QMGP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CITN))
				request.WithQueryParameter("CITN", m3_CITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUAR))
				request.WithQueryParameter("BUAR", m3_BUAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CITT))
				request.WithQueryParameter("CITT", m3_CITT.Trim());
			if (m3_TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3_TPCD.Value.ToString());
			if (m3_MABU.HasValue)
				request.WithQueryParameter("MABU", m3_MABU.Value.ToString());
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (m3_BACD.HasValue)
				request.WithQueryParameter("BACD", m3_BACD.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (m3_BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3_BYPR.Value.ToString());
			if (m3_WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3_WAPC.Value.ToString());
			if (m3_QACD.HasValue)
				request.WithQueryParameter("QACD", m3_QACD.Value.ToString());
			if (m3_EPCD.HasValue)
				request.WithQueryParameter("EPCD", m3_EPCD.Value.ToString());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3_ACTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_HIE1))
				request.WithQueryParameter("HIE1", m3_HIE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE2))
				request.WithQueryParameter("HIE2", m3_HIE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE3))
				request.WithQueryParameter("HIE3", m3_HIE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE4))
				request.WithQueryParameter("HIE4", m3_HIE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE5))
				request.WithQueryParameter("HIE5", m3_HIE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP1))
				request.WithQueryParameter("GRP1", m3_GRP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP2))
				request.WithQueryParameter("GRP2", m3_GRP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP3))
				request.WithQueryParameter("GRP3", m3_GRP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP4))
				request.WithQueryParameter("GRP4", m3_GRP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP5))
				request.WithQueryParameter("GRP5", m3_GRP5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3_ECMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRGP))
				request.WithQueryParameter("PRGP", m3_PRGP.Trim());
			if (m3_INDI.HasValue)
				request.WithQueryParameter("INDI", m3_INDI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (m3_ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3_ALUC.Value.ToString());
			if (m3_IEAA.HasValue)
				request.WithQueryParameter("IEAA", m3_IEAA.Value.ToString());
			if (m3_EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3_EXPD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (m3_HAZI.HasValue)
				request.WithQueryParameter("HAZI", m3_HAZI.Value.ToString());
			if (m3_SALE.HasValue)
				request.WithQueryParameter("SALE", m3_SALE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());
			if (m3_ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3_ATMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TPLI))
				request.WithQueryParameter("TPLI", m3_TPLI.Trim());
			if (m3_FCU1.HasValue)
				request.WithQueryParameter("FCU1", m3_FCU1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_IACP.HasValue)
				request.WithQueryParameter("IACP", m3_IACP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_HDPR))
				request.WithQueryParameter("HDPR", m3_HDPR.Trim());
			if (m3_AAD0.HasValue)
				request.WithQueryParameter("AAD0", m3_AAD0.Value.ToString());
			if (m3_AAD1.HasValue)
				request.WithQueryParameter("AAD1", m3_AAD1.Value.ToString());
			if (m3_CHCL.HasValue)
				request.WithQueryParameter("CHCL", m3_CHCL.Value.ToString());
			if (m3_ITRC.HasValue)
				request.WithQueryParameter("ITRC", m3_ITRC.Value.ToString());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVGR))
				request.WithQueryParameter("EVGR", m3_EVGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTS))
				request.WithQueryParameter("GRTS", m3_GRTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETRF))
				request.WithQueryParameter("ETRF", m3_ETRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTI))
				request.WithQueryParameter("GRTI", m3_GRTI.Trim());
			if (m3_CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3_CAWP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CWUN))
				request.WithQueryParameter("CWUN", m3_CWUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPUN))
				request.WithQueryParameter("CPUN", m3_CPUN.Trim());
			if (m3_ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3_ITRU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECR))
				request.WithQueryParameter("TECR", m3_TECR.Trim());
			if (m3_EXCA.HasValue)
				request.WithQueryParameter("EXCA", m3_EXCA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACCG))
				request.WithQueryParameter("ACCG", m3_ACCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCCM))
				request.WithQueryParameter("CCCM", m3_CCCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCI1))
				request.WithQueryParameter("CCI1", m3_CCI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRI1))
				request.WithQueryParameter("CRI1", m3_CRI1.Trim());
			if (m3_HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3_HVMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNE))
				request.WithQueryParameter("ITNE", m3_ITNE.Trim());
			if (m3_SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3_SPGV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PDLN))
				request.WithQueryParameter("PDLN", m3_PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (m3_SUME.HasValue)
				request.WithQueryParameter("SUME", m3_SUME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUMP))
				request.WithQueryParameter("SUMP", m3_SUMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());

			// Execute the request
			var result = await Execute<CpyItmBasicResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CpyItmFac
		/// Description Copy Item Facility
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CFAC">Copy Facility (Required)</param>
		/// <param name="m3_CITN">Copy Item Number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LEA4">Administrative lead time</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_SPFA">Conversion factor supplementary U/M</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_APPR">Average cost</param>
		/// <param name="m3_UCOS">Cost price</param>
		/// <param name="m3_SOCO">Ordering cost</param>
		/// <param name="m3_EXPC">Yield percentage</param>
		/// <param name="m3_BQTY">Batch quantity</param>
		/// <param name="m3_BQTM">Batch quantity method</param>
		/// <param name="m3_LLCM">Lowest level - BoM</param>
		/// <param name="m3_DLET">MO lead time method</param>
		/// <param name="m3_DLEF">Dynamic lead time fence - MO</param>
		/// <param name="m3_DIDY">Flow order planning</param>
		/// <param name="m3_DIDF">Flow order fence</param>
		/// <param name="m3_PRRA">Production rate</param>
		/// <param name="m3_TRHC">Throughput rate of capacity/day</param>
		/// <param name="m3_MARC">MO reservations</param>
		/// <param name="m3_JITF">Orderless production</param>
		/// <param name="m3_REWH">Main warehouse</param>
		/// <param name="m3_OPFQ">Optimal on-hand balance - facility</param>
		/// <param name="m3_FANO">On-hand balance - facility</param>
		/// <param name="m3_FANQ">On-hand balance for inspection -facility</param>
		/// <param name="m3_FANR">Rejected on-hand balance - facility</param>
		/// <param name="m3_FATM">On-hand balance method - facility</param>
		/// <param name="m3_WCLN">Production line</param>
		/// <param name="m3_EDEC">Method for expiry date excess control</param>
		/// <param name="m3_AUGE">Automatic creation of MO</param>
		/// <param name="m3_ECCC">Consumption code - trade stat (TST)</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_CPRI">Customs procedure - import</param>
		/// <param name="m3_CPRE">Customs procedure - export</param>
		/// <param name="m3_WSCA">Costing model - purchasing</param>
		/// <param name="m3_PRCM">Costing model - product costing</param>
		/// <param name="m3_PLAP">Planning process</param>
		/// <param name="m3_PLUP">Push process</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_CPL0">Calculate price for line type 0</param>
		/// <param name="m3_CPL1">Calculate price for line type 1</param>
		/// <param name="m3_CPL2">Calculate price for line type 2</param>
		/// <param name="m3_PPL0">Preliminary price for line type 0</param>
		/// <param name="m3_PPL1">Preliminary price for line type 1</param>
		/// <param name="m3_PPL2">Preliminary price for line type 2</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_CPDC">Costing decimal places</param>
		/// <param name="m3_COCD">Item cost quantity</param>
		/// <param name="m3_EVGR">Environment group</param>
		/// <param name="m3_VAMT">Inventory accounting method</param>
		/// <param name="m3_LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3_GRTI">Group technology class</param>
		/// <param name="m3_MOLL">MO leadtime limit</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_DICM">Costing model - distribution</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_STCW">Catch weight approved on hand balance</param>
		/// <param name="m3_RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3_QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3_CAWC">Catch weight cost</param>
		/// <param name="m3_CPUN">Standard cost price unit of measure</param>
		/// <param name="m3_COFA">Conversion factor</param>
		/// <param name="m3_ALTS">Alternate structures</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyItmFac(
			string m3_FACI, 
			string m3_ITNO, 
			string m3_CFAC, 
			string m3_CITN, 
			int? m3_CONO = null, 
			int? m3_LEA4 = null, 
			string m3_CSNO = null, 
			decimal? m3_SPFA = null, 
			string m3_ORCO = null, 
			decimal? m3_APPR = null, 
			decimal? m3_UCOS = null, 
			decimal? m3_SOCO = null, 
			int? m3_EXPC = null, 
			decimal? m3_BQTY = null, 
			int? m3_BQTM = null, 
			int? m3_LLCM = null, 
			int? m3_DLET = null, 
			int? m3_DLEF = null, 
			int? m3_DIDY = null, 
			int? m3_DIDF = null, 
			int? m3_PRRA = null, 
			int? m3_TRHC = null, 
			int? m3_MARC = null, 
			int? m3_JITF = null, 
			string m3_REWH = null, 
			decimal? m3_OPFQ = null, 
			decimal? m3_FANO = null, 
			decimal? m3_FANQ = null, 
			decimal? m3_FANR = null, 
			int? m3_FATM = null, 
			string m3_WCLN = null, 
			string m3_EDEC = null, 
			int? m3_AUGE = null, 
			string m3_ECCC = null, 
			string m3_ECAR = null, 
			string m3_CPRI = null, 
			string m3_CPRE = null, 
			string m3_WSCA = null, 
			string m3_PRCM = null, 
			string m3_PLAP = null, 
			string m3_PLUP = null, 
			string m3_SCMO = null, 
			int? m3_CPL0 = null, 
			int? m3_CPL1 = null, 
			int? m3_CPL2 = null, 
			int? m3_PPL0 = null, 
			int? m3_PPL1 = null, 
			int? m3_PPL2 = null, 
			decimal? m3_TXID = null, 
			decimal? m3_DTID = null, 
			int? m3_CPDC = null, 
			int? m3_COCD = null, 
			string m3_EVGR = null, 
			int? m3_VAMT = null, 
			int? m3_LAMA = null, 
			string m3_GRTI = null, 
			int? m3_MOLL = null, 
			int? m3_CRTM = null, 
			string m3_DICM = null, 
			string m3_ACRF = null, 
			decimal? m3_STCW = null, 
			decimal? m3_RJCW = null, 
			decimal? m3_QUCW = null, 
			int? m3_CAWC = null, 
			string m3_CPUN = null, 
			decimal? m3_COFA = null, 
			int? m3_ALTS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CFAC))
				throw new ArgumentNullException("m3_CFAC");
			if (string.IsNullOrWhiteSpace(m3_CITN))
				throw new ArgumentNullException("m3_CITN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CFAC", m3_CFAC.Trim())
				.WithQueryParameter("CITN", m3_CITN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3_LEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (m3_SPFA.HasValue)
				request.WithQueryParameter("SPFA", m3_SPFA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_APPR.HasValue)
				request.WithQueryParameter("APPR", m3_APPR.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
			if (m3_SOCO.HasValue)
				request.WithQueryParameter("SOCO", m3_SOCO.Value.ToString());
			if (m3_EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3_EXPC.Value.ToString());
			if (m3_BQTY.HasValue)
				request.WithQueryParameter("BQTY", m3_BQTY.Value.ToString());
			if (m3_BQTM.HasValue)
				request.WithQueryParameter("BQTM", m3_BQTM.Value.ToString());
			if (m3_LLCM.HasValue)
				request.WithQueryParameter("LLCM", m3_LLCM.Value.ToString());
			if (m3_DLET.HasValue)
				request.WithQueryParameter("DLET", m3_DLET.Value.ToString());
			if (m3_DLEF.HasValue)
				request.WithQueryParameter("DLEF", m3_DLEF.Value.ToString());
			if (m3_DIDY.HasValue)
				request.WithQueryParameter("DIDY", m3_DIDY.Value.ToString());
			if (m3_DIDF.HasValue)
				request.WithQueryParameter("DIDF", m3_DIDF.Value.ToString());
			if (m3_PRRA.HasValue)
				request.WithQueryParameter("PRRA", m3_PRRA.Value.ToString());
			if (m3_TRHC.HasValue)
				request.WithQueryParameter("TRHC", m3_TRHC.Value.ToString());
			if (m3_MARC.HasValue)
				request.WithQueryParameter("MARC", m3_MARC.Value.ToString());
			if (m3_JITF.HasValue)
				request.WithQueryParameter("JITF", m3_JITF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REWH))
				request.WithQueryParameter("REWH", m3_REWH.Trim());
			if (m3_OPFQ.HasValue)
				request.WithQueryParameter("OPFQ", m3_OPFQ.Value.ToString());
			if (m3_FANO.HasValue)
				request.WithQueryParameter("FANO", m3_FANO.Value.ToString());
			if (m3_FANQ.HasValue)
				request.WithQueryParameter("FANQ", m3_FANQ.Value.ToString());
			if (m3_FANR.HasValue)
				request.WithQueryParameter("FANR", m3_FANR.Value.ToString());
			if (m3_FATM.HasValue)
				request.WithQueryParameter("FATM", m3_FATM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WCLN))
				request.WithQueryParameter("WCLN", m3_WCLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDEC))
				request.WithQueryParameter("EDEC", m3_EDEC.Trim());
			if (m3_AUGE.HasValue)
				request.WithQueryParameter("AUGE", m3_AUGE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECCC))
				request.WithQueryParameter("ECCC", m3_ECCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPRI))
				request.WithQueryParameter("CPRI", m3_CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPRE))
				request.WithQueryParameter("CPRE", m3_CPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRCM))
				request.WithQueryParameter("PRCM", m3_PRCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLAP))
				request.WithQueryParameter("PLAP", m3_PLAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLUP))
				request.WithQueryParameter("PLUP", m3_PLUP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (m3_CPL0.HasValue)
				request.WithQueryParameter("CPL0", m3_CPL0.Value.ToString());
			if (m3_CPL1.HasValue)
				request.WithQueryParameter("CPL1", m3_CPL1.Value.ToString());
			if (m3_CPL2.HasValue)
				request.WithQueryParameter("CPL2", m3_CPL2.Value.ToString());
			if (m3_PPL0.HasValue)
				request.WithQueryParameter("PPL0", m3_PPL0.Value.ToString());
			if (m3_PPL1.HasValue)
				request.WithQueryParameter("PPL1", m3_PPL1.Value.ToString());
			if (m3_PPL2.HasValue)
				request.WithQueryParameter("PPL2", m3_PPL2.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_CPDC.HasValue)
				request.WithQueryParameter("CPDC", m3_CPDC.Value.ToString());
			if (m3_COCD.HasValue)
				request.WithQueryParameter("COCD", m3_COCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVGR))
				request.WithQueryParameter("EVGR", m3_EVGR.Trim());
			if (m3_VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3_VAMT.Value.ToString());
			if (m3_LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3_LAMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRTI))
				request.WithQueryParameter("GRTI", m3_GRTI.Trim());
			if (m3_MOLL.HasValue)
				request.WithQueryParameter("MOLL", m3_MOLL.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DICM))
				request.WithQueryParameter("DICM", m3_DICM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_STCW.HasValue)
				request.WithQueryParameter("STCW", m3_STCW.Value.ToString());
			if (m3_RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3_RJCW.Value.ToString());
			if (m3_QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3_QUCW.Value.ToString());
			if (m3_CAWC.HasValue)
				request.WithQueryParameter("CAWC", m3_CAWC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CPUN))
				request.WithQueryParameter("CPUN", m3_CPUN.Trim());
			if (m3_COFA.HasValue)
				request.WithQueryParameter("COFA", m3_COFA.Value.ToString());
			if (m3_ALTS.HasValue)
				request.WithQueryParameter("ALTS", m3_ALTS.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CpyItmTrpInf
		/// Description Copy Item Transport Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CITN">Default item (Required)</param>
		/// <param name="m3_UNNN">UN number</param>
		/// <param name="m3_NNNN">NA number</param>
		/// <param name="m3_CASN">CAS number</param>
		/// <param name="m3_ECNM">EU number</param>
		/// <param name="m3_EINM">EINECS number</param>
		/// <param name="m3_ATOM">Atomic number</param>
		/// <param name="m3_CEAN">CEA number</param>
		/// <param name="m3_NAIC">NAICS code</param>
		/// <param name="m3_ITEQ">Item equipment profile</param>
		/// <param name="m3_CMMC">Freight commodity code</param>
		/// <param name="m3_HAZM">Hazardous material</param>
		/// <param name="m3_CMCL">Commodity class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyItmTrpInf(
			string m3_ITNO, 
			string m3_CITN, 
			int? m3_UNNN = null, 
			string m3_NNNN = null, 
			string m3_CASN = null, 
			string m3_ECNM = null, 
			string m3_EINM = null, 
			string m3_ATOM = null, 
			string m3_CEAN = null, 
			int? m3_NAIC = null, 
			string m3_ITEQ = null, 
			string m3_CMMC = null, 
			int? m3_HAZM = null, 
			string m3_CMCL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CITN))
				throw new ArgumentNullException("m3_CITN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CITN", m3_CITN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3_UNNN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NNNN))
				request.WithQueryParameter("NNNN", m3_NNNN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CASN))
				request.WithQueryParameter("CASN", m3_CASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECNM))
				request.WithQueryParameter("ECNM", m3_ECNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EINM))
				request.WithQueryParameter("EINM", m3_EINM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATOM))
				request.WithQueryParameter("ATOM", m3_ATOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CEAN))
				request.WithQueryParameter("CEAN", m3_CEAN.Trim());
			if (m3_NAIC.HasValue)
				request.WithQueryParameter("NAIC", m3_NAIC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITEQ))
				request.WithQueryParameter("ITEQ", m3_ITEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMMC))
				request.WithQueryParameter("CMMC", m3_CMMC.Trim());
			if (m3_HAZM.HasValue)
				request.WithQueryParameter("HAZM", m3_HAZM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CMCL))
				request.WithQueryParameter("CMCL", m3_CMCL.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CpyItmViaItmTyp
		/// Description Copy Item Via ItemType
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CITN">Copy Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_ITNE">Extended item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CpyItmViaItmTypResponse></returns>
		/// <exception cref="M3Exception<CpyItmViaItmTypResponse>"></exception>
		public async Task<M3Response<CpyItmViaItmTypResponse>> CpyItmViaItmTyp(
			string m3_CITN, 
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_ITNE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CITN))
				throw new ArgumentNullException("m3_CITN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CITN", m3_CITN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNE))
				request.WithQueryParameter("ITNE", m3_ITNE.Trim());

			// Execute the request
			var result = await Execute<CpyItmViaItmTypResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CpyItmWhs
		/// Description Copy Item Warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CWHL">Copy Warehouse (Required)</param>
		/// <param name="m3_CITN">Copy Item Number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STQT">On-hand balance approved</param>
		/// <param name="m3_QUQT">On-hand balance for inspection</param>
		/// <param name="m3_RJQT">Rejected on-hand balance</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3_AVAL">Allocatable on-hand balance</param>
		/// <param name="m3_PLQT">Picking list quantity - basic U/M</param>
		/// <param name="m3_COMG">Container management</param>
		/// <param name="m3_ALMT">Allocation method</param>
		/// <param name="m3_STMT">Storage method</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_STTX">Note</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_REQT">Reserved quantity</param>
		/// <param name="m3_RLQT">Reserved quantity to backorder</param>
		/// <param name="m3_REQP">Reserved quantity - planned orders</param>
		/// <param name="m3_IDDT">Last receipt date</param>
		/// <param name="m3_ODDT">Last issue date</param>
		/// <param name="m3_INDT">Latest physical inventory date</param>
		/// <param name="m3_PRDC">Priority date selection</param>
		/// <param name="m3_INCD">Physical inventory cycle</param>
		/// <param name="m3_NUIN">Number of records for physical inventory</param>
		/// <param name="m3_USYE">Annual usage</param>
		/// <param name="m3_AVST">Average on-hand balance</param>
		/// <param name="m3_DILE">Projected on-hand at end of lead time</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_WHTY">Warehouse type</param>
		/// <param name="m3_WHSY">Warehouse subtype</param>
		/// <param name="m3_INSC">Statistics storage group</param>
		/// <param name="m3_DIGR">Distribution group</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_NUS7">Number of balance IDs</param>
		/// <param name="m3_TOMU">Issue multiple</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_MABC">ABC class - manual</param>
		/// <param name="m3_ABCD">ABC class - volume</param>
		/// <param name="m3_ABCM">ABC method  - volume</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_ABFM">ABC method - frequency</param>
		/// <param name="m3_ACOC">ABC class - contribution</param>
		/// <param name="m3_ACOM">ABC method - contribution</param>
		/// <param name="m3_PRIF">Priority value</param>
		/// <param name="m3_SODY">Run-out time</param>
		/// <param name="m3_REOP">Reorder point</param>
		/// <param name="m3_OPOM">Reorder point method</param>
		/// <param name="m3_SSQT">Safety stock</param>
		/// <param name="m3_SSMT">Safety stock method</param>
		/// <param name="m3_MSSQ">Manual safety stock</param>
		/// <param name="m3_SSDA">Safety stock unit</param>
		/// <param name="m3_SCGR">Service level</param>
		/// <param name="m3_MXST">Maximum stock</param>
		/// <param name="m3_MXSM">Maximum stock method</param>
		/// <param name="m3_MXPC">Maximum stock percentage</param>
		/// <param name="m3_EOQT">Order quantity</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_EQDA">Economical order quantity days</param>
		/// <param name="m3_YEQT">Annual demand</param>
		/// <param name="m3_YEQM">Annual demand method</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_MOQT">Maximum order quantity</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_SUWH">Supplying warehouse</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_PRCD">Forecast method</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_LYQT">Fixed annual demand</param>
		/// <param name="m3_LRYE">Fixed acquisition requirement</param>
		/// <param name="m3_PFTM">Planning time fence</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_LEA2">Inspection lead time</param>
		/// <param name="m3_LEA3">Transportation lead time</param>
		/// <param name="m3_LEAT">Lead time</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_SVEI">Multiple supply</param>
		/// <param name="m3_LEVL">Lowest level</param>
		/// <param name="m3_LEVD">Lowest level DO</param>
		/// <param name="m3_PLHZ">Planning horizon</param>
		/// <param name="m3_DMFN">Demand time fence</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_SATD">Safety time</param>
		/// <param name="m3_ALQC">Quantity controlled allocation</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_SHCC">Distribution/supplier calendar check</param>
		/// <param name="m3_ZCAC">Zero mark</param>
		/// <param name="m3_INSL">Inspection location</param>
		/// <param name="m3_NCCA">Net change calculation active</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DDEX">Time phased safety stock exists</param>
		/// <param name="m3_STRL">History storage method</param>
		/// <param name="m3_PLIC">Picking list information control</param>
		/// <param name="m3_PPMC">Pending planning method change</param>
		/// <param name="m3_MPCD">Calculation date - material planning</param>
		/// <param name="m3_MPCT">Calculation time - material planning</param>
		/// <param name="m3_DCSS">Time phased safety stock</param>
		/// <param name="m3_RPOP">Responsible - PO proposal</param>
		/// <param name="m3_BCOS">Standard cost - warehouse</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_DPLO">Default packing location</param>
		/// <param name="m3_DDLO">Default docking location</param>
		/// <param name="m3_SPLC">Delivery split rule</param>
		/// <param name="m3_ALS1">Allocate non-approved balance ID</param>
		/// <param name="m3_POOT">Point of time table</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_MNUN">Main unit of calculation</param>
		/// <param name="m3_GRTS">Distribution group technology</param>
		/// <param name="m3_SLDY">Shelf life</param>
		/// <param name="m3_REDY">Reinspection time</param>
		/// <param name="m3_SAEL">Sales time</param>
		/// <param name="m3_CPCD">CTP policy</param>
		/// <param name="m3_LEAQ">Quarantine lead-time</param>
		/// <param name="m3_SCHT">Scheduled re-classification allowed</param>
		/// <param name="m3_STCW">Catch weight approved on hand balance</param>
		/// <param name="m3_RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3_QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3_IPLA">Inventory planned</param>
		/// <param name="m3_BBTM">Best before time</param>
		/// <param name="m3_FSSQ">Frozen safety stock</param>
		/// <param name="m3_SSRE">SS reason code</param>
		/// <param name="m3_ISEG">Inventory segment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyItmWhs(
			string m3_WHLO, 
			string m3_ITNO, 
			string m3_CWHL, 
			string m3_CITN, 
			int? m3_CONO = null, 
			decimal? m3_STQT = null, 
			decimal? m3_QUQT = null, 
			decimal? m3_RJQT = null, 
			decimal? m3_ALQT = null, 
			decimal? m3_AVAL = null, 
			decimal? m3_PLQT = null, 
			int? m3_COMG = null, 
			int? m3_ALMT = null, 
			int? m3_STMT = null, 
			int? m3_SPMT = null, 
			string m3_STTX = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_REQT = null, 
			decimal? m3_RLQT = null, 
			decimal? m3_REQP = null, 
			DateTime? m3_IDDT = null, 
			DateTime? m3_ODDT = null, 
			DateTime? m3_INDT = null, 
			int? m3_PRDC = null, 
			string m3_INCD = null, 
			int? m3_NUIN = null, 
			decimal? m3_USYE = null, 
			decimal? m3_AVST = null, 
			decimal? m3_DILE = null, 
			string m3_RESP = null, 
			string m3_BUYE = null, 
			string m3_SUNO = null, 
			string m3_WHTY = null, 
			string m3_WHSY = null, 
			int? m3_INSC = null, 
			string m3_DIGR = null, 
			string m3_WHSL = null, 
			string m3_SLTP = null, 
			int? m3_NUS7 = null, 
			decimal? m3_TOMU = null, 
			string m3_WHLT = null, 
			string m3_PISE = null, 
			string m3_PLCD = null, 
			string m3_MABC = null, 
			string m3_ABCD = null, 
			int? m3_ABCM = null, 
			string m3_ABFC = null, 
			int? m3_ABFM = null, 
			string m3_ACOC = null, 
			int? m3_ACOM = null, 
			int? m3_PRIF = null, 
			int? m3_SODY = null, 
			decimal? m3_REOP = null, 
			int? m3_OPOM = null, 
			decimal? m3_SSQT = null, 
			int? m3_SSMT = null, 
			decimal? m3_MSSQ = null, 
			int? m3_SSDA = null, 
			int? m3_SCGR = null, 
			decimal? m3_MXST = null, 
			int? m3_MXSM = null, 
			int? m3_MXPC = null, 
			decimal? m3_EOQT = null, 
			int? m3_EOQM = null, 
			int? m3_EQDA = null, 
			decimal? m3_YEQT = null, 
			int? m3_YEQM = null, 
			decimal? m3_LOQT = null, 
			decimal? m3_MOQT = null, 
			int? m3_PUIT = null, 
			string m3_SUWH = null, 
			int? m3_DPID = null, 
			string m3_PRCD = null, 
			string m3_FCCM = null, 
			decimal? m3_LYQT = null, 
			decimal? m3_LRYE = null, 
			int? m3_PFTM = null, 
			int? m3_LEA1 = null, 
			int? m3_LEA2 = null, 
			int? m3_LEA3 = null, 
			int? m3_LEAT = null, 
			decimal? m3_UNMU = null, 
			int? m3_SVEI = null, 
			int? m3_LEVL = null, 
			int? m3_LEVD = null, 
			int? m3_PLHZ = null, 
			int? m3_DMFN = null, 
			string m3_ORTY = null, 
			int? m3_CONC = null, 
			int? m3_SATD = null, 
			int? m3_ALQC = null, 
			int? m3_OPLC = null, 
			int? m3_MSCH = null, 
			int? m3_SHCC = null, 
			int? m3_ZCAC = null, 
			string m3_INSL = null, 
			int? m3_NCCA = null, 
			string m3_FACI = null, 
			string m3_DIVI = null, 
			int? m3_DDEX = null, 
			int? m3_STRL = null, 
			int? m3_PLIC = null, 
			int? m3_PPMC = null, 
			DateTime? m3_MPCD = null, 
			int? m3_MPCT = null, 
			int? m3_DCSS = null, 
			int? m3_RPOP = null, 
			decimal? m3_BCOS = null, 
			decimal? m3_TXID = null, 
			decimal? m3_DTID = null, 
			string m3_DPLO = null, 
			string m3_DDLO = null, 
			string m3_SPLC = null, 
			int? m3_ALS1 = null, 
			string m3_POOT = null, 
			string m3_STAT = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			string m3_MNUN = null, 
			string m3_GRTS = null, 
			int? m3_SLDY = null, 
			int? m3_REDY = null, 
			int? m3_SAEL = null, 
			string m3_CPCD = null, 
			int? m3_LEAQ = null, 
			int? m3_SCHT = null, 
			decimal? m3_STCW = null, 
			decimal? m3_RJCW = null, 
			decimal? m3_QUCW = null, 
			string m3_IPLA = null, 
			int? m3_BBTM = null, 
			int? m3_FSSQ = null, 
			string m3_SSRE = null, 
			string m3_ISEG = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CWHL))
				throw new ArgumentNullException("m3_CWHL");
			if (string.IsNullOrWhiteSpace(m3_CITN))
				throw new ArgumentNullException("m3_CITN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CWHL", m3_CWHL.Trim())
				.WithQueryParameter("CITN", m3_CITN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STQT.HasValue)
				request.WithQueryParameter("STQT", m3_STQT.Value.ToString());
			if (m3_QUQT.HasValue)
				request.WithQueryParameter("QUQT", m3_QUQT.Value.ToString());
			if (m3_RJQT.HasValue)
				request.WithQueryParameter("RJQT", m3_RJQT.Value.ToString());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());
			if (m3_AVAL.HasValue)
				request.WithQueryParameter("AVAL", m3_AVAL.Value.ToString());
			if (m3_PLQT.HasValue)
				request.WithQueryParameter("PLQT", m3_PLQT.Value.ToString());
			if (m3_COMG.HasValue)
				request.WithQueryParameter("COMG", m3_COMG.Value.ToString());
			if (m3_ALMT.HasValue)
				request.WithQueryParameter("ALMT", m3_ALMT.Value.ToString());
			if (m3_STMT.HasValue)
				request.WithQueryParameter("STMT", m3_STMT.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STTX))
				request.WithQueryParameter("STTX", m3_STTX.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_REQT.HasValue)
				request.WithQueryParameter("REQT", m3_REQT.Value.ToString());
			if (m3_RLQT.HasValue)
				request.WithQueryParameter("RLQT", m3_RLQT.Value.ToString());
			if (m3_REQP.HasValue)
				request.WithQueryParameter("REQP", m3_REQP.Value.ToString());
			if (m3_IDDT.HasValue)
				request.WithQueryParameter("IDDT", m3_IDDT.Value.ToM3String());
			if (m3_ODDT.HasValue)
				request.WithQueryParameter("ODDT", m3_ODDT.Value.ToM3String());
			if (m3_INDT.HasValue)
				request.WithQueryParameter("INDT", m3_INDT.Value.ToM3String());
			if (m3_PRDC.HasValue)
				request.WithQueryParameter("PRDC", m3_PRDC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INCD))
				request.WithQueryParameter("INCD", m3_INCD.Trim());
			if (m3_NUIN.HasValue)
				request.WithQueryParameter("NUIN", m3_NUIN.Value.ToString());
			if (m3_USYE.HasValue)
				request.WithQueryParameter("USYE", m3_USYE.Value.ToString());
			if (m3_AVST.HasValue)
				request.WithQueryParameter("AVST", m3_AVST.Value.ToString());
			if (m3_DILE.HasValue)
				request.WithQueryParameter("DILE", m3_DILE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHTY))
				request.WithQueryParameter("WHTY", m3_WHTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSY))
				request.WithQueryParameter("WHSY", m3_WHSY.Trim());
			if (m3_INSC.HasValue)
				request.WithQueryParameter("INSC", m3_INSC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIGR))
				request.WithQueryParameter("DIGR", m3_DIGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (m3_NUS7.HasValue)
				request.WithQueryParameter("NUS7", m3_NUS7.Value.ToString());
			if (m3_TOMU.HasValue)
				request.WithQueryParameter("TOMU", m3_TOMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLCD))
				request.WithQueryParameter("PLCD", m3_PLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MABC))
				request.WithQueryParameter("MABC", m3_MABC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (m3_ABCM.HasValue)
				request.WithQueryParameter("ABCM", m3_ABCM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ABFC))
				request.WithQueryParameter("ABFC", m3_ABFC.Trim());
			if (m3_ABFM.HasValue)
				request.WithQueryParameter("ABFM", m3_ABFM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACOC))
				request.WithQueryParameter("ACOC", m3_ACOC.Trim());
			if (m3_ACOM.HasValue)
				request.WithQueryParameter("ACOM", m3_ACOM.Value.ToString());
			if (m3_PRIF.HasValue)
				request.WithQueryParameter("PRIF", m3_PRIF.Value.ToString());
			if (m3_SODY.HasValue)
				request.WithQueryParameter("SODY", m3_SODY.Value.ToString());
			if (m3_REOP.HasValue)
				request.WithQueryParameter("REOP", m3_REOP.Value.ToString());
			if (m3_OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3_OPOM.Value.ToString());
			if (m3_SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3_SSQT.Value.ToString());
			if (m3_SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3_SSMT.Value.ToString());
			if (m3_MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3_MSSQ.Value.ToString());
			if (m3_SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3_SSDA.Value.ToString());
			if (m3_SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3_SCGR.Value.ToString());
			if (m3_MXST.HasValue)
				request.WithQueryParameter("MXST", m3_MXST.Value.ToString());
			if (m3_MXSM.HasValue)
				request.WithQueryParameter("MXSM", m3_MXSM.Value.ToString());
			if (m3_MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3_MXPC.Value.ToString());
			if (m3_EOQT.HasValue)
				request.WithQueryParameter("EOQT", m3_EOQT.Value.ToString());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3_EQDA.Value.ToString());
			if (m3_YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3_YEQT.Value.ToString());
			if (m3_YEQM.HasValue)
				request.WithQueryParameter("YEQM", m3_YEQM.Value.ToString());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3_MOQT.Value.ToString());
			if (m3_PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3_PUIT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUWH))
				request.WithQueryParameter("SUWH", m3_SUWH.Trim());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRCD))
				request.WithQueryParameter("PRCD", m3_PRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_LYQT.HasValue)
				request.WithQueryParameter("LYQT", m3_LYQT.Value.ToString());
			if (m3_LRYE.HasValue)
				request.WithQueryParameter("LRYE", m3_LRYE.Value.ToString());
			if (m3_PFTM.HasValue)
				request.WithQueryParameter("PFTM", m3_PFTM.Value.ToString());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (m3_LEA2.HasValue)
				request.WithQueryParameter("LEA2", m3_LEA2.Value.ToString());
			if (m3_LEA3.HasValue)
				request.WithQueryParameter("LEA3", m3_LEA3.Value.ToString());
			if (m3_LEAT.HasValue)
				request.WithQueryParameter("LEAT", m3_LEAT.Value.ToString());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (m3_SVEI.HasValue)
				request.WithQueryParameter("SVEI", m3_SVEI.Value.ToString());
			if (m3_LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3_LEVL.Value.ToString());
			if (m3_LEVD.HasValue)
				request.WithQueryParameter("LEVD", m3_LEVD.Value.ToString());
			if (m3_PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3_PLHZ.Value.ToString());
			if (m3_DMFN.HasValue)
				request.WithQueryParameter("DMFN", m3_DMFN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (m3_SATD.HasValue)
				request.WithQueryParameter("SATD", m3_SATD.Value.ToString());
			if (m3_ALQC.HasValue)
				request.WithQueryParameter("ALQC", m3_ALQC.Value.ToString());
			if (m3_OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3_OPLC.Value.ToString());
			if (m3_MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3_MSCH.Value.ToString());
			if (m3_SHCC.HasValue)
				request.WithQueryParameter("SHCC", m3_SHCC.Value.ToString());
			if (m3_ZCAC.HasValue)
				request.WithQueryParameter("ZCAC", m3_ZCAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INSL))
				request.WithQueryParameter("INSL", m3_INSL.Trim());
			if (m3_NCCA.HasValue)
				request.WithQueryParameter("NCCA", m3_NCCA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_DDEX.HasValue)
				request.WithQueryParameter("DDEX", m3_DDEX.Value.ToString());
			if (m3_STRL.HasValue)
				request.WithQueryParameter("STRL", m3_STRL.Value.ToString());
			if (m3_PLIC.HasValue)
				request.WithQueryParameter("PLIC", m3_PLIC.Value.ToString());
			if (m3_PPMC.HasValue)
				request.WithQueryParameter("PPMC", m3_PPMC.Value.ToString());
			if (m3_MPCD.HasValue)
				request.WithQueryParameter("MPCD", m3_MPCD.Value.ToM3String());
			if (m3_MPCT.HasValue)
				request.WithQueryParameter("MPCT", m3_MPCT.Value.ToString());
			if (m3_DCSS.HasValue)
				request.WithQueryParameter("DCSS", m3_DCSS.Value.ToString());
			if (m3_RPOP.HasValue)
				request.WithQueryParameter("RPOP", m3_RPOP.Value.ToString());
			if (m3_BCOS.HasValue)
				request.WithQueryParameter("BCOS", m3_BCOS.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DPLO))
				request.WithQueryParameter("DPLO", m3_DPLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DDLO))
				request.WithQueryParameter("DDLO", m3_DDLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLC))
				request.WithQueryParameter("SPLC", m3_SPLC.Trim());
			if (m3_ALS1.HasValue)
				request.WithQueryParameter("ALS1", m3_ALS1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POOT))
				request.WithQueryParameter("POOT", m3_POOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MNUN))
				request.WithQueryParameter("MNUN", m3_MNUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTS))
				request.WithQueryParameter("GRTS", m3_GRTS.Trim());
			if (m3_SLDY.HasValue)
				request.WithQueryParameter("SLDY", m3_SLDY.Value.ToString());
			if (m3_REDY.HasValue)
				request.WithQueryParameter("REDY", m3_REDY.Value.ToString());
			if (m3_SAEL.HasValue)
				request.WithQueryParameter("SAEL", m3_SAEL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CPCD))
				request.WithQueryParameter("CPCD", m3_CPCD.Trim());
			if (m3_LEAQ.HasValue)
				request.WithQueryParameter("LEAQ", m3_LEAQ.Value.ToString());
			if (m3_SCHT.HasValue)
				request.WithQueryParameter("SCHT", m3_SCHT.Value.ToString());
			if (m3_STCW.HasValue)
				request.WithQueryParameter("STCW", m3_STCW.Value.ToString());
			if (m3_RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3_RJCW.Value.ToString());
			if (m3_QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3_QUCW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IPLA))
				request.WithQueryParameter("IPLA", m3_IPLA.Trim());
			if (m3_BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3_BBTM.Value.ToString());
			if (m3_FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3_FSSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSRE))
				request.WithQueryParameter("SSRE", m3_SSRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISEG))
				request.WithQueryParameter("ISEG", m3_ISEG.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name DltItm
		/// Description Delete Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItm(
			string m3_ITNO, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name DltItmFac
		/// Description Delete Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItmFac(
			string m3_FACI, 
			string m3_ITNO, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name DltItmTrplnf
		/// Description Delete Item Transport Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItmTrplnf(
			string m3_ITNO, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name DltItmWhs
		/// Description Delete Item Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItmWhs(
			string m3_WHLO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name Get
		/// Description Get item basic data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_ITNO, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetAggWhsGrp
		/// Description Get Aggregated Warehouse Group Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAggWhsGrpResponse></returns>
		/// <exception cref="M3Exception<GetAggWhsGrpResponse>"></exception>
		public async Task<M3Response<GetAggWhsGrpResponse>> GetAggWhsGrp(
			int? m3_CONO = null, 
			string m3_WHGR = null, 
			string m3_ITNO = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<GetAggWhsGrpResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmBasic
		/// Description Get Item Basic Data
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmBasicResponse></returns>
		/// <exception cref="M3Exception<GetItmBasicResponse>"></exception>
		public async Task<M3Response<GetItmBasicResponse>> GetItmBasic(
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetItmBasicResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmCost
		/// Description GetItmCost
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_ATNB">Attribute number lot</param>
		/// <param name="m3_CANB">Cost attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmCostResponse></returns>
		/// <exception cref="M3Exception<GetItmCostResponse>"></exception>
		public async Task<M3Response<GetItmCostResponse>> GetItmCost(
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			decimal? m3_ATNR = null, 
			decimal? m3_ATNB = null, 
			decimal? m3_CANB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (m3_CANB.HasValue)
				request.WithQueryParameter("CANB", m3_CANB.Value.ToString());

			// Execute the request
			var result = await Execute<GetItmCostResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmFac
		/// Description Get Item Facility
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmFacResponse></returns>
		/// <exception cref="M3Exception<GetItmFacResponse>"></exception>
		public async Task<M3Response<GetItmFacResponse>> GetItmFac(
			string m3_FACI, 
			string m3_ITNO, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetItmFacResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmMeas
		/// Description Get Item Measurement Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmMeasResponse></returns>
		/// <exception cref="M3Exception<GetItmMeasResponse>"></exception>
		public async Task<M3Response<GetItmMeasResponse>> GetItmMeas(
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetItmMeasResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmPrice
		/// Description Get Item Price Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmPriceResponse></returns>
		/// <exception cref="M3Exception<GetItmPriceResponse>"></exception>
		public async Task<M3Response<GetItmPriceResponse>> GetItmPrice(
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetItmPriceResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmTech
		/// Description Get Item Technical Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmTechResponse></returns>
		/// <exception cref="M3Exception<GetItmTechResponse>"></exception>
		public async Task<M3Response<GetItmTechResponse>> GetItmTech(
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetItmTechResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmTrpFrelnf
		/// Description Get Item Transport Information fields A001-A040
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmTrpFrelnfResponse></returns>
		/// <exception cref="M3Exception<GetItmTrpFrelnfResponse>"></exception>
		public async Task<M3Response<GetItmTrpFrelnfResponse>> GetItmTrpFrelnf(
			string m3_ITNO, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<GetItmTrpFrelnfResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmTrplnf
		/// Description Get Item Transport Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmTrplnfResponse></returns>
		/// <exception cref="M3Exception<GetItmTrplnfResponse>"></exception>
		public async Task<M3Response<GetItmTrplnfResponse>> GetItmTrplnf(
			string m3_ITNO, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<GetItmTrplnfResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmWhsBal
		/// Description Get Item Warehouse Balance Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmWhsBalResponse></returns>
		/// <exception cref="M3Exception<GetItmWhsBalResponse>"></exception>
		public async Task<M3Response<GetItmWhsBalResponse>> GetItmWhsBal(
			string m3_WHLO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetItmWhsBalResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetItmWhsBasic
		/// Description Get Item Warehouse Basic Data
		/// Version Release: 5eaA
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmWhsBasicResponse></returns>
		/// <exception cref="M3Exception<GetItmWhsBasicResponse>"></exception>
		public async Task<M3Response<GetItmWhsBasicResponse>> GetItmWhsBasic(
			string m3_WHLO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetItmWhsBasicResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name GetSumWhsBal
		/// Description Get Summarized Item Warehouse Balance Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSumWhsBalResponse></returns>
		/// <exception cref="M3Exception<GetSumWhsBalResponse>"></exception>
		public async Task<M3Response<GetSumWhsBalResponse>> GetSumWhsBal(
			string m3_WHLO, 
			string m3_POPN, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetSumWhsBalResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstAUMTime
		/// Description List new/changed Alternate Unit of Measure Items
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAUMTimeResponse></returns>
		/// <exception cref="M3Exception<LstAUMTimeResponse>"></exception>
		public async Task<M3Response<LstAUMTimeResponse>> LstAUMTime(
			decimal? m3_LMTS = null, 
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
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstAUMTimeResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstAggWhsGrp
		/// Description Lst Aggretgated Warehouse Group  Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAggWhsGrpResponse></returns>
		/// <exception cref="M3Exception<LstAggWhsGrpResponse>"></exception>
		public async Task<M3Response<LstAggWhsGrpResponse>> LstAggWhsGrp(
			int? m3_CONO = null, 
			string m3_WHGR = null, 
			string m3_ITNO = null, 
			string m3_APIP = null, 
			int? m3_CRTM = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());

			// Execute the request
			var result = await Execute<LstAggWhsGrpResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstCustStatNo
		/// Description List Customs statistical number ,CSNO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustStatNoResponse></returns>
		/// <exception cref="M3Exception<LstCustStatNoResponse>"></exception>
		public async Task<M3Response<LstCustStatNoResponse>> LstCustStatNo(
			int? m3_CONO = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstCustStatNoResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstDistTechGrp
		/// Description List Distribution group technology
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRTS">From Distribution group technology</param>
		/// <param name="m3_TOTS">To Distribution group technology</param>
		/// <param name="m3_LMTS">Last imprt´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDistTechGrpResponse></returns>
		/// <exception cref="M3Exception<LstDistTechGrpResponse>"></exception>
		public async Task<M3Response<LstDistTechGrpResponse>> LstDistTechGrp(
			int? m3_CONO = null, 
			string m3_FRTS = null, 
			string m3_TOTS = null, 
			decimal? m3_LMTS = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRTS))
				request.WithQueryParameter("FRTS", m3_FRTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOTS))
				request.WithQueryParameter("TOTS", m3_TOTS.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstDistTechGrpResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstFacByItem
		/// Description List Facility By Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFacByItemResponse></returns>
		/// <exception cref="M3Exception<LstFacByItemResponse>"></exception>
		public async Task<M3Response<LstFacByItemResponse>> LstFacByItem(
			string m3_ITNO, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstFacByItemResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstGrpTechClass
		/// Description List Group technology class
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRTC">From Group technology class</param>
		/// <param name="m3_TOTC">To Group technology class</param>
		/// <param name="m3_LMTS">Last imprt´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstGrpTechClassResponse></returns>
		/// <exception cref="M3Exception<LstGrpTechClassResponse>"></exception>
		public async Task<M3Response<LstGrpTechClassResponse>> LstGrpTechClass(
			int? m3_CONO = null, 
			string m3_FRTC = null, 
			string m3_TOTC = null, 
			decimal? m3_LMTS = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRTC))
				request.WithQueryParameter("FRTC", m3_FRTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOTC))
				request.WithQueryParameter("TOTC", m3_TOTC.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstGrpTechClassResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmAltUnitMs
		/// Description List Item Alternate Unit of Measurement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FITN">From - Item number (Required)</param>
		/// <param name="m3_TITN">To - Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FAUT">From - Alternate U/M type</param>
		/// <param name="m3_TAUT">To - Alternate U/M type</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_LGUN">Logistics U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmAltUnitMsResponse></returns>
		/// <exception cref="M3Exception<LstItmAltUnitMsResponse>"></exception>
		public async Task<M3Response<LstItmAltUnitMsResponse>> LstItmAltUnitMs(
			string m3_FITN, 
			string m3_TITN, 
			int? m3_CONO = null, 
			int? m3_FAUT = null, 
			int? m3_TAUT = null, 
			string m3_LNCD = null, 
			int? m3_LGUN = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FITN))
				throw new ArgumentNullException("m3_FITN");
			if (string.IsNullOrWhiteSpace(m3_TITN))
				throw new ArgumentNullException("m3_TITN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FITN", m3_FITN.Trim())
				.WithQueryParameter("TITN", m3_TITN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FAUT.HasValue)
				request.WithQueryParameter("FAUT", m3_FAUT.Value.ToString());
			if (m3_TAUT.HasValue)
				request.WithQueryParameter("TAUT", m3_TAUT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_LGUN.HasValue)
				request.WithQueryParameter("LGUN", m3_LGUN.Value.ToString());

			// Execute the request
			var result = await Execute<LstItmAltUnitMsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmByChgDate
		/// Description List Item Basic Data by Change date
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FLMD">From change date</param>
		/// <param name="m3_TLMD">To change date</param>
		/// <param name="m3_CSDS">Changed since</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmByChgDateResponse></returns>
		/// <exception cref="M3Exception<LstItmByChgDateResponse>"></exception>
		public async Task<M3Response<LstItmByChgDateResponse>> LstItmByChgDate(
			int? m3_CONO = null, 
			DateTime? m3_FLMD = null, 
			DateTime? m3_TLMD = null, 
			int? m3_CSDS = null, 
			string m3_LNCD = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FLMD.HasValue)
				request.WithQueryParameter("FLMD", m3_FLMD.Value.ToM3String());
			if (m3_TLMD.HasValue)
				request.WithQueryParameter("TLMD", m3_TLMD.Value.ToM3String());
			if (m3_CSDS.HasValue)
				request.WithQueryParameter("CSDS", m3_CSDS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmByChgDateResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmByItm
		/// Description List Item Basic Data by Item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_FSTY">From Style number</param>
		/// <param name="m3_TSTY">To Style number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmByItmResponse></returns>
		/// <exception cref="M3Exception<LstItmByItmResponse>"></exception>
		public async Task<M3Response<LstItmByItmResponse>> LstItmByItm(
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			int? m3_CHCD = null, 
			string m3_FSTY = null, 
			string m3_TSTY = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FSTY))
				request.WithQueryParameter("FSTY", m3_FSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTY))
				request.WithQueryParameter("TSTY", m3_TSTY.Trim());

			// Execute the request
			var result = await Execute<LstItmByItmResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmByItmARP
		/// Description List Item Basic Data by Item ARP
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FRIT">Item number (Required)</param>
		/// <param name="m3_CHCD">Configuration code (Required)</param>
		/// <param name="m3_TOIT">Item number</param>
		/// <param name="m3_NORM">Yes/no</param>
		/// <param name="m3_FRST">Status</param>
		/// <param name="m3_TOST">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmByItmARPResponse></returns>
		/// <exception cref="M3Exception<LstItmByItmARPResponse>"></exception>
		public async Task<M3Response<LstItmByItmARPResponse>> LstItmByItmARP(
			string m3_FRIT, 
			int m3_CHCD, 
			string m3_TOIT = null, 
			int? m3_NORM = null, 
			string m3_FRST = null, 
			string m3_TOST = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FRIT))
				throw new ArgumentNullException("m3_FRIT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FRIT", m3_FRIT.Trim())
				.WithQueryParameter("CHCD", m3_CHCD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TOIT))
				request.WithQueryParameter("TOIT", m3_TOIT.Trim());
			if (m3_NORM.HasValue)
				request.WithQueryParameter("NORM", m3_NORM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRST))
				request.WithQueryParameter("FRST", m3_FRST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOST))
				request.WithQueryParameter("TOST", m3_TOST.Trim());

			// Execute the request
			var result = await Execute<LstItmByItmARPResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmByItmGr
		/// Description List Item Basic Data by Item Group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITGR">Item group (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmByItmGrResponse></returns>
		/// <exception cref="M3Exception<LstItmByItmGrResponse>"></exception>
		public async Task<M3Response<LstItmByItmGrResponse>> LstItmByItmGr(
			string m3_ITGR, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITGR))
				throw new ArgumentNullException("m3_ITGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITGR", m3_ITGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmByItmGrResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmByProdGr
		/// Description List Item Basic Data by Product Group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITCL">Product group (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmByProdGrResponse></returns>
		/// <exception cref="M3Exception<LstItmByProdGrResponse>"></exception>
		public async Task<M3Response<LstItmByProdGrResponse>> LstItmByProdGr(
			string m3_ITCL, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITCL))
				throw new ArgumentNullException("m3_ITCL");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITCL", m3_ITCL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmByProdGrResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmDescLang
		/// Description List Item Description per Language
		/// Version Release: 14x
		/// </summary>
		/// <param name="m3_FITN">From Item number</param>
		/// <param name="m3_TITN">To Item number</param>
		/// <param name="m3_FLNC">From Language</param>
		/// <param name="m3_TLNC">To Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmDescLangResponse></returns>
		/// <exception cref="M3Exception<LstItmDescLangResponse>"></exception>
		public async Task<M3Response<LstItmDescLangResponse>> LstItmDescLang(
			string m3_FITN = null, 
			string m3_TITN = null, 
			string m3_FLNC = null, 
			string m3_TLNC = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FITN))
				request.WithQueryParameter("FITN", m3_FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITN))
				request.WithQueryParameter("TITN", m3_TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLNC))
				request.WithQueryParameter("FLNC", m3_FLNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLNC))
				request.WithQueryParameter("TLNC", m3_TLNC.Trim());

			// Execute the request
			var result = await Execute<LstItmDescLangResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmFac
		/// Description List Item Facility
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmFacResponse></returns>
		/// <exception cref="M3Exception<LstItmFacResponse>"></exception>
		public async Task<M3Response<LstItmFacResponse>> LstItmFac(
			string m3_FACI, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmFacResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmFacTime
		/// Description List Items per Facility with timestamp
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmFacTimeResponse></returns>
		/// <exception cref="M3Exception<LstItmFacTimeResponse>"></exception>
		public async Task<M3Response<LstItmFacTimeResponse>> LstItmFacTime(
			string m3_FACI = null, 
			decimal? m3_LMTS = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstItmFacTimeResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmFreeFld1
		/// Description List Item free field 1
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FCF1">From Item free field 1</param>
		/// <param name="m3_TCF1">To Item free field 1</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmFreeFld1Response></returns>
		/// <exception cref="M3Exception<LstItmFreeFld1Response>"></exception>
		public async Task<M3Response<LstItmFreeFld1Response>> LstItmFreeFld1(
			int? m3_CONO = null, 
			string m3_FCF1 = null, 
			string m3_TCF1 = null, 
			decimal? m3_LMTS = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCF1))
				request.WithQueryParameter("FCF1", m3_FCF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCF1))
				request.WithQueryParameter("TCF1", m3_TCF1.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstItmFreeFld1Response>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmFreeFld3
		/// Description List Item free field 3
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FCF3">From Item free field 3</param>
		/// <param name="m3_TCF3">To Item free field 3</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmFreeFld3Response></returns>
		/// <exception cref="M3Exception<LstItmFreeFld3Response>"></exception>
		public async Task<M3Response<LstItmFreeFld3Response>> LstItmFreeFld3(
			int? m3_CONO = null, 
			string m3_FCF3 = null, 
			string m3_TCF3 = null, 
			decimal? m3_LMTS = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCF3))
				request.WithQueryParameter("FCF3", m3_FCF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCF3))
				request.WithQueryParameter("TCF3", m3_TCF3.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstItmFreeFld3Response>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmFreeFld4
		/// Description List Item free field 4
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FCF4">From Item free field 4</param>
		/// <param name="m3_TCF4">To Item free field 4</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmFreeFld4Response></returns>
		/// <exception cref="M3Exception<LstItmFreeFld4Response>"></exception>
		public async Task<M3Response<LstItmFreeFld4Response>> LstItmFreeFld4(
			int? m3_CONO = null, 
			string m3_FCF4 = null, 
			string m3_TCF4 = null, 
			decimal? m3_LMTS = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCF4))
				request.WithQueryParameter("FCF4", m3_FCF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCF4))
				request.WithQueryParameter("TCF4", m3_TCF4.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstItmFreeFld4Response>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmGroups
		/// Description List Item Groups
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmGroupsResponse></returns>
		/// <exception cref="M3Exception<LstItmGroupsResponse>"></exception>
		public async Task<M3Response<LstItmGroupsResponse>> LstItmGroups(
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmGroupsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmPrice
		/// Description List Item Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmPriceResponse></returns>
		/// <exception cref="M3Exception<LstItmPriceResponse>"></exception>
		public async Task<M3Response<LstItmPriceResponse>> LstItmPrice(
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmPriceResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmWhsByItm
		/// Description List Item Warehouse By Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmWhsByItmResponse></returns>
		/// <exception cref="M3Exception<LstItmWhsByItmResponse>"></exception>
		public async Task<M3Response<LstItmWhsByItmResponse>> LstItmWhsByItm(
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_LNCD = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmWhsByItmResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmWhsByRel
		/// Description List Item Warehouse By Relation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_RPTY">Replacement type</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmWhsByRelResponse></returns>
		/// <exception cref="M3Exception<LstItmWhsByRelResponse>"></exception>
		public async Task<M3Response<LstItmWhsByRelResponse>> LstItmWhsByRel(
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			int? m3_RPTY = null, 
			string m3_WHLO = null, 
			string m3_LNCD = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_RPTY.HasValue)
				request.WithQueryParameter("RPTY", m3_RPTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmWhsByRelResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmWhsByWhgr
		/// Description LstItmWhsByWhgr
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_WHGR">Warehouse group (Required)</param>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="m3_INZO">Include zero</param>
		/// <param name="m3_ITT1">Item type</param>
		/// <param name="m3_ITT2">Item type</param>
		/// <param name="m3_ITT3">Item type</param>
		/// <param name="m3_ITT4">Item type</param>
		/// <param name="m3_ITT5">Item type</param>
		/// <param name="m3_ITT6">Item type</param>
		/// <param name="m3_ITT7">Item type</param>
		/// <param name="m3_ITT8">Item type</param>
		/// <param name="m3_ITT9">Item type</param>
		/// <param name="m3_ITT0">Item type</param>
		/// <param name="m3_SUN1">Supplier</param>
		/// <param name="m3_SUN2">Supplier</param>
		/// <param name="m3_SUN3">Supplier</param>
		/// <param name="m3_SUN4">Supplier</param>
		/// <param name="m3_SUN5">Supplier</param>
		/// <param name="m3_SUN6">Supplier</param>
		/// <param name="m3_SUN7">Supplier</param>
		/// <param name="m3_SUN8">Supplier</param>
		/// <param name="m3_SUN9">Supplier</param>
		/// <param name="m3_SUN0">Supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmWhsByWhgrResponse></returns>
		/// <exception cref="M3Exception<LstItmWhsByWhgrResponse>"></exception>
		public async Task<M3Response<LstItmWhsByWhgrResponse>> LstItmWhsByWhgr(
			string m3_WHGR, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			int? m3_INZO = null, 
			string m3_ITT1 = null, 
			string m3_ITT2 = null, 
			string m3_ITT3 = null, 
			string m3_ITT4 = null, 
			string m3_ITT5 = null, 
			string m3_ITT6 = null, 
			string m3_ITT7 = null, 
			string m3_ITT8 = null, 
			string m3_ITT9 = null, 
			string m3_ITT0 = null, 
			string m3_SUN1 = null, 
			string m3_SUN2 = null, 
			string m3_SUN3 = null, 
			string m3_SUN4 = null, 
			string m3_SUN5 = null, 
			string m3_SUN6 = null, 
			string m3_SUN7 = null, 
			string m3_SUN8 = null, 
			string m3_SUN9 = null, 
			string m3_SUN0 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHGR))
				throw new ArgumentNullException("m3_WHGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_INZO.HasValue)
				request.WithQueryParameter("INZO", m3_INZO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITT1))
				request.WithQueryParameter("ITT1", m3_ITT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITT2))
				request.WithQueryParameter("ITT2", m3_ITT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITT3))
				request.WithQueryParameter("ITT3", m3_ITT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITT4))
				request.WithQueryParameter("ITT4", m3_ITT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITT5))
				request.WithQueryParameter("ITT5", m3_ITT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITT6))
				request.WithQueryParameter("ITT6", m3_ITT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITT7))
				request.WithQueryParameter("ITT7", m3_ITT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITT8))
				request.WithQueryParameter("ITT8", m3_ITT8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITT9))
				request.WithQueryParameter("ITT9", m3_ITT9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITT0))
				request.WithQueryParameter("ITT0", m3_ITT0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUN1))
				request.WithQueryParameter("SUN1", m3_SUN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUN2))
				request.WithQueryParameter("SUN2", m3_SUN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUN3))
				request.WithQueryParameter("SUN3", m3_SUN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUN4))
				request.WithQueryParameter("SUN4", m3_SUN4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUN5))
				request.WithQueryParameter("SUN5", m3_SUN5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUN6))
				request.WithQueryParameter("SUN6", m3_SUN6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUN7))
				request.WithQueryParameter("SUN7", m3_SUN7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUN8))
				request.WithQueryParameter("SUN8", m3_SUN8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUN9))
				request.WithQueryParameter("SUN9", m3_SUN9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUN0))
				request.WithQueryParameter("SUN0", m3_SUN0.Trim());

			// Execute the request
			var result = await Execute<LstItmWhsByWhgrResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstItmWhsByWhs
		/// Description List Item Warehouse By Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmWhsByWhsResponse></returns>
		/// <exception cref="M3Exception<LstItmWhsByWhsResponse>"></exception>
		public async Task<M3Response<LstItmWhsByWhsResponse>> LstItmWhsByWhs(
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_LNCD = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstItmWhsByWhsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstProdGroups
		/// Description List Product Groups
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProdGroupsResponse></returns>
		/// <exception cref="M3Exception<LstProdGroupsResponse>"></exception>
		public async Task<M3Response<LstProdGroupsResponse>> LstProdGroups(
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstProdGroupsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstStyle
		/// Description List Style
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleResponse></returns>
		/// <exception cref="M3Exception<LstStyleResponse>"></exception>
		public async Task<M3Response<LstStyleResponse>> LstStyle(
			string m3_STYN, 
			string m3_ITNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstStyleResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstSumWhsBal
		/// Description List Summarized Item Warehouse Balance Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_POPN">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_INVF">Filter For Non Zero Inventory</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSumWhsBalResponse></returns>
		/// <exception cref="M3Exception<LstSumWhsBalResponse>"></exception>
		public async Task<M3Response<LstSumWhsBalResponse>> LstSumWhsBal(
			string m3_WHLO, 
			string m3_POPN, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			int? m3_INVF = null, 
			int? m3_CHCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_INVF.HasValue)
				request.WithQueryParameter("INVF", m3_INVF.Value.ToString());
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());

			// Execute the request
			var result = await Execute<LstSumWhsBalResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name PrtItemLabel
		/// Description Print Item Label
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_DEV0">Printer</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrtItemLabel(
			string m3_ITNO = null, 
			string m3_LNCD = null, 
			string m3_DEV0 = null, 
			int? m3_COPY = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEV0))
				request.WithQueryParameter("DEV0", m3_DEV0.Trim());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SearchItem
		/// Description Search for an item via LES.
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchItemResponse></returns>
		/// <exception cref="M3Exception<SearchItemResponse>"></exception>
		public async Task<M3Response<SearchItemResponse>> SearchItem(
			string m3_SQRY, 
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
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchItemResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SearchItemWhs
		/// Description SearchItemWhs
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchItemWhsResponse></returns>
		/// <exception cref="M3Exception<SearchItemWhsResponse>"></exception>
		public async Task<M3Response<SearchItemWhsResponse>> SearchItemWhs(
			string m3_SQRY, 
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
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchItemWhsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItem
		/// Description Retrieve basic information about an item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRIT">From Item Number</param>
		/// <param name="m3_TOIT">To Item Number</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="m3_LMTS">Last import timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItemResponse></returns>
		/// <exception cref="M3Exception<SelItemResponse>"></exception>
		public async Task<M3Response<SelItemResponse>> SelItem(
			int? m3_CONO = null, 
			string m3_FRIT = null, 
			string m3_TOIT = null, 
			DateTime? m3_LMDT = null, 
			decimal? m3_LMTS = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRIT))
				request.WithQueryParameter("FRIT", m3_FRIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOIT))
				request.WithQueryParameter("TOIT", m3_TOIT.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<SelItemResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItemGroup
		/// Description Select Item Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRIT">From Item Type</param>
		/// <param name="m3_TOIT">To Item Type</param>
		/// <param name="m3_LMTS">Last import timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItemGroupResponse></returns>
		/// <exception cref="M3Exception<SelItemGroupResponse>"></exception>
		public async Task<M3Response<SelItemGroupResponse>> SelItemGroup(
			int? m3_CONO = null, 
			string m3_FRIT = null, 
			string m3_TOIT = null, 
			decimal? m3_LMTS = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRIT))
				request.WithQueryParameter("FRIT", m3_FRIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOIT))
				request.WithQueryParameter("TOIT", m3_TOIT.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<SelItemGroupResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItemType
		/// Description Select Item Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRIT">From Item Type</param>
		/// <param name="m3_TOIT">To Item Type</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="m3_LMTS">Last import timestamp</param>
		/// <param name="m3_FRST">From Status</param>
		/// <param name="m3_TOST">To Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItemTypeResponse></returns>
		/// <exception cref="M3Exception<SelItemTypeResponse>"></exception>
		public async Task<M3Response<SelItemTypeResponse>> SelItemType(
			int? m3_CONO = null, 
			string m3_FRIT = null, 
			string m3_TOIT = null, 
			DateTime? m3_LMDT = null, 
			decimal? m3_LMTS = null, 
			string m3_FRST = null, 
			string m3_TOST = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRIT))
				request.WithQueryParameter("FRIT", m3_FRIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOIT))
				request.WithQueryParameter("TOIT", m3_TOIT.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRST))
				request.WithQueryParameter("FRST", m3_FRST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOST))
				request.WithQueryParameter("TOST", m3_TOST.Trim());

			// Execute the request
			var result = await Execute<SelItemTypeResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItemWhs
		/// Description Retrieve basic information for item warehouse interface
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FWHL">From warehouse</param>
		/// <param name="m3_TWHL">To warehouse</param>
		/// <param name="m3_FRIT">From Item Number</param>
		/// <param name="m3_TOIT">To Item Number</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="m3_LMTS">Last import timestamp</param>
		/// <param name="m3_SESO">Seasonal item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItemWhsResponse></returns>
		/// <exception cref="M3Exception<SelItemWhsResponse>"></exception>
		public async Task<M3Response<SelItemWhsResponse>> SelItemWhs(
			int? m3_CONO = null, 
			string m3_FWHL = null, 
			string m3_TWHL = null, 
			string m3_FRIT = null, 
			string m3_TOIT = null, 
			DateTime? m3_LMDT = null, 
			decimal? m3_LMTS = null, 
			int? m3_SESO = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRIT))
				request.WithQueryParameter("FRIT", m3_FRIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOIT))
				request.WithQueryParameter("TOIT", m3_TOIT.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());
			if (m3_SESO.HasValue)
				request.WithQueryParameter("SESO", m3_SESO.Value.ToString());

			// Execute the request
			var result = await Execute<SelItemWhsResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItmMercia
		/// Description Retrieve basic information about an item for Mercia
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRIT">From Item Number</param>
		/// <param name="m3_TOIT">To Item Number</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItmMerciaResponse></returns>
		/// <exception cref="M3Exception<SelItmMerciaResponse>"></exception>
		public async Task<M3Response<SelItmMerciaResponse>> SelItmMercia(
			int? m3_CONO = null, 
			string m3_FRIT = null, 
			string m3_TOIT = null, 
			DateTime? m3_LMDT = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRIT))
				request.WithQueryParameter("FRIT", m3_FRIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOIT))
				request.WithQueryParameter("TOIT", m3_TOIT.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<SelItmMerciaResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelItmWhsMercia
		/// Description Select Item - Warehouse data for Mercia
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItmWhsMerciaResponse></returns>
		/// <exception cref="M3Exception<SelItmWhsMerciaResponse>"></exception>
		public async Task<M3Response<SelItmWhsMerciaResponse>> SelItmWhsMercia(
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_WHLO = null, 
			DateTime? m3_LMDT = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<SelItmWhsMerciaResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SelProdGroup
		/// Description Select Prod Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRPG">From Product group</param>
		/// <param name="m3_TOPG">To Product group</param>
		/// <param name="m3_LMTS">Last import timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelProdGroupResponse></returns>
		/// <exception cref="M3Exception<SelProdGroupResponse>"></exception>
		public async Task<M3Response<SelProdGroupResponse>> SelProdGroup(
			int? m3_CONO = null, 
			string m3_FRPG = null, 
			string m3_TOPG = null, 
			decimal? m3_LMTS = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRPG))
				request.WithQueryParameter("FRPG", m3_FRPG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOPG))
				request.WithQueryParameter("TOPG", m3_TOPG.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<SelProdGroupResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SndInvDtaMercia
		/// Description Update inventory data from Mercia
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_REOP">Reorder point</param>
		/// <param name="m3_OPOM">Reorder point method</param>
		/// <param name="m3_SSQT">Safety stock</param>
		/// <param name="m3_SSMT">Safety stock method</param>
		/// <param name="m3_SSDA">Safety stock unit</param>
		/// <param name="m3_FSSQ">Frozen safety stock</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInvDtaMercia(
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_WHLO = null, 
			decimal? m3_REOP = null, 
			int? m3_OPOM = null, 
			decimal? m3_SSQT = null, 
			int? m3_SSMT = null, 
			int? m3_SSDA = null, 
			int? m3_FSSQ = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_REOP.HasValue)
				request.WithQueryParameter("REOP", m3_REOP.Value.ToString());
			if (m3_OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3_OPOM.Value.ToString());
			if (m3_SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3_SSQT.Value.ToString());
			if (m3_SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3_SSMT.Value.ToString());
			if (m3_SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3_SSDA.Value.ToString());
			if (m3_FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3_FSSQ.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name SndItmDesc
		/// Description Send Item Description to OTRSMS
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndItmDesc(
			int? m3_CONO = null, 
			DateTime? m3_LMDT = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmBasic
		/// Description Update Item Basic
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_BUAR">Business area</param>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_TPCD">Item category</param>
		/// <param name="m3_MABU">Make/buy code</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_BACD">Lot numbering method</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_BYPR">By/co-product code</param>
		/// <param name="m3_WAPC">Normal waste percentage</param>
		/// <param name="m3_QACD">Inspection code</param>
		/// <param name="m3_EPCD">Yield calculation</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_ACTI">Active or catch weight item</param>
		/// <param name="m3_HIE1">Hierachy level 1</param>
		/// <param name="m3_HIE2">Hierachy level 2</param>
		/// <param name="m3_HIE3">Hierachy level 3</param>
		/// <param name="m3_HIE4">Hierachy level 4</param>
		/// <param name="m3_HIE5">Hierachy level 5</param>
		/// <param name="m3_GRP1">Search group 1</param>
		/// <param name="m3_GRP2">Search group 2</param>
		/// <param name="m3_GRP3">Search group 3</param>
		/// <param name="m3_GRP4">Search group 4</param>
		/// <param name="m3_GRP5">Search group 5</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ECMA">ECO managed</param>
		/// <param name="m3_PRGP">Procurement group</param>
		/// <param name="m3_INDI">Lot control method</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_ALUC">Alternate U/M in use</param>
		/// <param name="m3_IEAA">Item exists as alias identity</param>
		/// <param name="m3_EXPD">Expiration date method</param>
		/// <param name="m3_GRMT">Goods receiving method</param>
		/// <param name="m3_HAZI">Danger indicator</param>
		/// <param name="m3_SALE">Sales item</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="m3_ATMN">Attribute managed</param>
		/// <param name="m3_TPLI">Template item number</param>
		/// <param name="m3_FCU1">Estimated consumption free capacity unit</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_IACP">Attribute-controlled item</param>
		/// <param name="m3_HDPR">Main product</param>
		/// <param name="m3_AAD0">Extended QA used</param>
		/// <param name="m3_AAD1">Generate txt from text template</param>
		/// <param name="m3_CHCL">Charge calculation</param>
		/// <param name="m3_ITRC">Individual item tracing</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_GRTI">Group technology class</param>
		/// <param name="m3_GRTS">Distribution group technology</param>
		/// <param name="m3_ETRF">External instruction</param>
		/// <param name="m3_CAWP">Catch weight mode</param>
		/// <param name="m3_CWUN">Catch weight unit of measure</param>
		/// <param name="m3_CPUN">Standard cost price unit of measure</param>
		/// <param name="m3_DSP1">Update item-warehouse</param>
		/// <param name="m3_EVGR">Environment group</param>
		/// <param name="m3_ILEN">Length</param>
		/// <param name="m3_IWID">Width</param>
		/// <param name="m3_IHEI">Height</param>
		/// <param name="m3_ITRU">Included in territorial roll-up</param>
		/// <param name="m3_TECR">Core terms</param>
		/// <param name="m3_EXCA">Exchangeable</param>
		/// <param name="m3_ACCG">Acceptance group</param>
		/// <param name="m3_CCCM">Costing model - core charge</param>
		/// <param name="m3_CCI1">Core charge item number</param>
		/// <param name="m3_CRI1">Core remain item number</param>
		/// <param name="m3_HVMT">Harvest Method</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_ITNE">Extended item number</param>
		/// <param name="m3_SPGV">Specific gravity</param>
		/// <param name="m3_AUTC">Issue message</param>
		/// <param name="m3_RIDE">Reference identity</param>
		/// <param name="m3_RIDC">Reference identity code</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_SAFC">Suppliers ABC code</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_PDLN">Product line</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_ITRF">Internal instruction</param>
		/// <param name="m3_SUME">Sublot method</param>
		/// <param name="m3_SUMP">Sublot policy</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmBasic(
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_STAT = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_DWNO = null, 
			string m3_RESP = null, 
			string m3_UNMS = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_BUAR = null, 
			string m3_ITTY = null, 
			int? m3_TPCD = null, 
			int? m3_MABU = null, 
			int? m3_CHCD = null, 
			int? m3_STCD = null, 
			int? m3_BACD = null, 
			decimal? m3_VOL3 = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			int? m3_BYPR = null, 
			int? m3_WAPC = null, 
			int? m3_QACD = null, 
			int? m3_EPCD = null, 
			int? m3_POCY = null, 
			int? m3_ACTI = null, 
			string m3_HIE1 = null, 
			string m3_HIE2 = null, 
			string m3_HIE3 = null, 
			string m3_HIE4 = null, 
			string m3_HIE5 = null, 
			string m3_GRP1 = null, 
			string m3_GRP2 = null, 
			string m3_GRP3 = null, 
			string m3_GRP4 = null, 
			string m3_GRP5 = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			decimal? m3_TXID = null, 
			int? m3_ECMA = null, 
			string m3_PRGP = null, 
			int? m3_INDI = null, 
			string m3_PUUN = null, 
			int? m3_ALUC = null, 
			int? m3_IEAA = null, 
			int? m3_EXPD = null, 
			string m3_GRMT = null, 
			int? m3_HAZI = null, 
			int? m3_SALE = null, 
			string m3_TAXC = null, 
			string m3_ATMO = null, 
			int? m3_ATMN = null, 
			string m3_TPLI = null, 
			decimal? m3_FCU1 = null, 
			string m3_ALUN = null, 
			int? m3_IACP = null, 
			string m3_HDPR = null, 
			int? m3_AAD0 = null, 
			int? m3_AAD1 = null, 
			int? m3_CHCL = null, 
			int? m3_ITRC = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			string m3_ECVE = null, 
			string m3_GRTI = null, 
			string m3_GRTS = null, 
			string m3_ETRF = null, 
			int? m3_CAWP = null, 
			string m3_CWUN = null, 
			string m3_CPUN = null, 
			int? m3_DSP1 = null, 
			string m3_EVGR = null, 
			int? m3_ILEN = null, 
			int? m3_IWID = null, 
			int? m3_IHEI = null, 
			int? m3_ITRU = null, 
			string m3_TECR = null, 
			int? m3_EXCA = null, 
			string m3_ACCG = null, 
			string m3_CCCM = null, 
			string m3_CCI1 = null, 
			string m3_CRI1 = null, 
			int? m3_HVMT = null, 
			string m3_ACRF = null, 
			string m3_ITNE = null, 
			decimal? m3_SPGV = null, 
			int? m3_AUTC = null, 
			string m3_RIDE = null, 
			int? m3_RIDC = null, 
			int? m3_RNRI = null, 
			string m3_SAFC = null, 
			int? m3_RMSG = null, 
			string m3_PDLN = null, 
			string m3_CPGR = null, 
			string m3_ITRF = null, 
			int? m3_SUME = null, 
			string m3_SUMP = null, 
			string m3_QMGP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUAR))
				request.WithQueryParameter("BUAR", m3_BUAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (m3_TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3_TPCD.Value.ToString());
			if (m3_MABU.HasValue)
				request.WithQueryParameter("MABU", m3_MABU.Value.ToString());
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (m3_BACD.HasValue)
				request.WithQueryParameter("BACD", m3_BACD.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3_BYPR.Value.ToString());
			if (m3_WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3_WAPC.Value.ToString());
			if (m3_QACD.HasValue)
				request.WithQueryParameter("QACD", m3_QACD.Value.ToString());
			if (m3_EPCD.HasValue)
				request.WithQueryParameter("EPCD", m3_EPCD.Value.ToString());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3_ACTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_HIE1))
				request.WithQueryParameter("HIE1", m3_HIE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE2))
				request.WithQueryParameter("HIE2", m3_HIE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE3))
				request.WithQueryParameter("HIE3", m3_HIE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE4))
				request.WithQueryParameter("HIE4", m3_HIE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HIE5))
				request.WithQueryParameter("HIE5", m3_HIE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP1))
				request.WithQueryParameter("GRP1", m3_GRP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP2))
				request.WithQueryParameter("GRP2", m3_GRP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP3))
				request.WithQueryParameter("GRP3", m3_GRP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP4))
				request.WithQueryParameter("GRP4", m3_GRP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRP5))
				request.WithQueryParameter("GRP5", m3_GRP5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3_ECMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRGP))
				request.WithQueryParameter("PRGP", m3_PRGP.Trim());
			if (m3_INDI.HasValue)
				request.WithQueryParameter("INDI", m3_INDI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (m3_ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3_ALUC.Value.ToString());
			if (m3_IEAA.HasValue)
				request.WithQueryParameter("IEAA", m3_IEAA.Value.ToString());
			if (m3_EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3_EXPD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (m3_HAZI.HasValue)
				request.WithQueryParameter("HAZI", m3_HAZI.Value.ToString());
			if (m3_SALE.HasValue)
				request.WithQueryParameter("SALE", m3_SALE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());
			if (m3_ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3_ATMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TPLI))
				request.WithQueryParameter("TPLI", m3_TPLI.Trim());
			if (m3_FCU1.HasValue)
				request.WithQueryParameter("FCU1", m3_FCU1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_IACP.HasValue)
				request.WithQueryParameter("IACP", m3_IACP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_HDPR))
				request.WithQueryParameter("HDPR", m3_HDPR.Trim());
			if (m3_AAD0.HasValue)
				request.WithQueryParameter("AAD0", m3_AAD0.Value.ToString());
			if (m3_AAD1.HasValue)
				request.WithQueryParameter("AAD1", m3_AAD1.Value.ToString());
			if (m3_CHCL.HasValue)
				request.WithQueryParameter("CHCL", m3_CHCL.Value.ToString());
			if (m3_ITRC.HasValue)
				request.WithQueryParameter("ITRC", m3_ITRC.Value.ToString());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTI))
				request.WithQueryParameter("GRTI", m3_GRTI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTS))
				request.WithQueryParameter("GRTS", m3_GRTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETRF))
				request.WithQueryParameter("ETRF", m3_ETRF.Trim());
			if (m3_CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3_CAWP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CWUN))
				request.WithQueryParameter("CWUN", m3_CWUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPUN))
				request.WithQueryParameter("CPUN", m3_CPUN.Trim());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVGR))
				request.WithQueryParameter("EVGR", m3_EVGR.Trim());
			if (m3_ILEN.HasValue)
				request.WithQueryParameter("ILEN", m3_ILEN.Value.ToString());
			if (m3_IWID.HasValue)
				request.WithQueryParameter("IWID", m3_IWID.Value.ToString());
			if (m3_IHEI.HasValue)
				request.WithQueryParameter("IHEI", m3_IHEI.Value.ToString());
			if (m3_ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3_ITRU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECR))
				request.WithQueryParameter("TECR", m3_TECR.Trim());
			if (m3_EXCA.HasValue)
				request.WithQueryParameter("EXCA", m3_EXCA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACCG))
				request.WithQueryParameter("ACCG", m3_ACCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCCM))
				request.WithQueryParameter("CCCM", m3_CCCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCI1))
				request.WithQueryParameter("CCI1", m3_CCI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRI1))
				request.WithQueryParameter("CRI1", m3_CRI1.Trim());
			if (m3_HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3_HVMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNE))
				request.WithQueryParameter("ITNE", m3_ITNE.Trim());
			if (m3_SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3_SPGV.Value.ToString());
			if (m3_AUTC.HasValue)
				request.WithQueryParameter("AUTC", m3_AUTC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDE))
				request.WithQueryParameter("RIDE", m3_RIDE.Trim());
			if (m3_RIDC.HasValue)
				request.WithQueryParameter("RIDC", m3_RIDC.Value.ToString());
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SAFC))
				request.WithQueryParameter("SAFC", m3_SAFC.Trim());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PDLN))
				request.WithQueryParameter("PDLN", m3_PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITRF))
				request.WithQueryParameter("ITRF", m3_ITRF.Trim());
			if (m3_SUME.HasValue)
				request.WithQueryParameter("SUME", m3_SUME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUMP))
				request.WithQueryParameter("SUMP", m3_SUMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmFac
		/// Description Update Item Facility
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LEA4">Administrative lead time</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_SPFA">Conversion factor supplementary U/M</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_APPR">Average cost</param>
		/// <param name="m3_UCOS">Cost price</param>
		/// <param name="m3_SOCO">Ordering cost</param>
		/// <param name="m3_EXPC">Yield percentage</param>
		/// <param name="m3_BQTY">Batch quantity</param>
		/// <param name="m3_BQTM">Batch quantity method</param>
		/// <param name="m3_LLCM">Lowest level - BoM</param>
		/// <param name="m3_DLET">MO lead time method</param>
		/// <param name="m3_DLEF">Dynamic lead time fence - MO</param>
		/// <param name="m3_DIDY">Flow order planning</param>
		/// <param name="m3_DIDF">Flow order fence</param>
		/// <param name="m3_PRRA">Production rate</param>
		/// <param name="m3_TRHC">Throughput rate of capacity/day</param>
		/// <param name="m3_MARC">MO reservations</param>
		/// <param name="m3_JITF">Orderless production</param>
		/// <param name="m3_REWH">Main warehouse</param>
		/// <param name="m3_OPFQ">Optimal on-hand balance - facility</param>
		/// <param name="m3_FANO">On-hand balance - facility</param>
		/// <param name="m3_FANQ">On-hand balance for inspection -facility</param>
		/// <param name="m3_FANR">Rejected on-hand balance - facility</param>
		/// <param name="m3_FATM">On-hand balance method - facility</param>
		/// <param name="m3_WCLN">Production line</param>
		/// <param name="m3_EDEC">Method for expiry date excess control</param>
		/// <param name="m3_AUGE">Automatic creation of MO</param>
		/// <param name="m3_ECCC">Consumption code - trade stat (TST)</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_CPRI">Customs procedure - import</param>
		/// <param name="m3_CPRE">Customs procedure - export</param>
		/// <param name="m3_WSCA">Costing model - purchasing</param>
		/// <param name="m3_PRCM">Costing model - product costing</param>
		/// <param name="m3_PLAP">Planning process</param>
		/// <param name="m3_PLUP">Push process</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_CPL0">Calculate price for line type 0</param>
		/// <param name="m3_CPL1">Calculate price for line type 1</param>
		/// <param name="m3_CPL2">Calculate price for line type 2</param>
		/// <param name="m3_PPL0">Preliminary price for line type 0</param>
		/// <param name="m3_PPL1">Preliminary price for line type 1</param>
		/// <param name="m3_PPL2">Preliminary price for line type 2</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_CPDC">Costing decimal places</param>
		/// <param name="m3_COCD">Item cost quantity</param>
		/// <param name="m3_EVGR">Environment group</param>
		/// <param name="m3_VAMT">Inventory accounting method</param>
		/// <param name="m3_LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3_GRTI">Group technology class</param>
		/// <param name="m3_MOLL">MO leadtime limit</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_DICM">Costing model - distribution</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_STCW">Catch weight approved on hand balance</param>
		/// <param name="m3_RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3_QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3_CAWC">Catch weight cost</param>
		/// <param name="m3_CPUN">Standard cost price unit of measure</param>
		/// <param name="m3_COFA">Conversion factor</param>
		/// <param name="m3_ALTS">Alternate structures</param>
		/// <param name="m3_ATTC">Average costing per attribute</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmFac(
			string m3_FACI, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			int? m3_LEA4 = null, 
			string m3_CSNO = null, 
			decimal? m3_SPFA = null, 
			string m3_ORCO = null, 
			decimal? m3_APPR = null, 
			decimal? m3_UCOS = null, 
			decimal? m3_SOCO = null, 
			int? m3_EXPC = null, 
			decimal? m3_BQTY = null, 
			int? m3_BQTM = null, 
			int? m3_LLCM = null, 
			int? m3_DLET = null, 
			int? m3_DLEF = null, 
			int? m3_DIDY = null, 
			int? m3_DIDF = null, 
			int? m3_PRRA = null, 
			int? m3_TRHC = null, 
			int? m3_MARC = null, 
			int? m3_JITF = null, 
			string m3_REWH = null, 
			decimal? m3_OPFQ = null, 
			decimal? m3_FANO = null, 
			decimal? m3_FANQ = null, 
			decimal? m3_FANR = null, 
			int? m3_FATM = null, 
			string m3_WCLN = null, 
			string m3_EDEC = null, 
			int? m3_AUGE = null, 
			string m3_ECCC = null, 
			string m3_ECAR = null, 
			string m3_CPRI = null, 
			string m3_CPRE = null, 
			string m3_WSCA = null, 
			string m3_PRCM = null, 
			string m3_PLAP = null, 
			string m3_PLUP = null, 
			string m3_SCMO = null, 
			int? m3_CPL0 = null, 
			int? m3_CPL1 = null, 
			int? m3_CPL2 = null, 
			int? m3_PPL0 = null, 
			int? m3_PPL1 = null, 
			int? m3_PPL2 = null, 
			decimal? m3_TXID = null, 
			decimal? m3_DTID = null, 
			int? m3_CPDC = null, 
			int? m3_COCD = null, 
			string m3_EVGR = null, 
			int? m3_VAMT = null, 
			int? m3_LAMA = null, 
			string m3_GRTI = null, 
			int? m3_MOLL = null, 
			int? m3_CRTM = null, 
			string m3_DICM = null, 
			string m3_ACRF = null, 
			decimal? m3_STCW = null, 
			decimal? m3_RJCW = null, 
			decimal? m3_QUCW = null, 
			int? m3_CAWC = null, 
			string m3_CPUN = null, 
			decimal? m3_COFA = null, 
			int? m3_ALTS = null, 
			int? m3_ATTC = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3_LEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (m3_SPFA.HasValue)
				request.WithQueryParameter("SPFA", m3_SPFA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_APPR.HasValue)
				request.WithQueryParameter("APPR", m3_APPR.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
			if (m3_SOCO.HasValue)
				request.WithQueryParameter("SOCO", m3_SOCO.Value.ToString());
			if (m3_EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3_EXPC.Value.ToString());
			if (m3_BQTY.HasValue)
				request.WithQueryParameter("BQTY", m3_BQTY.Value.ToString());
			if (m3_BQTM.HasValue)
				request.WithQueryParameter("BQTM", m3_BQTM.Value.ToString());
			if (m3_LLCM.HasValue)
				request.WithQueryParameter("LLCM", m3_LLCM.Value.ToString());
			if (m3_DLET.HasValue)
				request.WithQueryParameter("DLET", m3_DLET.Value.ToString());
			if (m3_DLEF.HasValue)
				request.WithQueryParameter("DLEF", m3_DLEF.Value.ToString());
			if (m3_DIDY.HasValue)
				request.WithQueryParameter("DIDY", m3_DIDY.Value.ToString());
			if (m3_DIDF.HasValue)
				request.WithQueryParameter("DIDF", m3_DIDF.Value.ToString());
			if (m3_PRRA.HasValue)
				request.WithQueryParameter("PRRA", m3_PRRA.Value.ToString());
			if (m3_TRHC.HasValue)
				request.WithQueryParameter("TRHC", m3_TRHC.Value.ToString());
			if (m3_MARC.HasValue)
				request.WithQueryParameter("MARC", m3_MARC.Value.ToString());
			if (m3_JITF.HasValue)
				request.WithQueryParameter("JITF", m3_JITF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REWH))
				request.WithQueryParameter("REWH", m3_REWH.Trim());
			if (m3_OPFQ.HasValue)
				request.WithQueryParameter("OPFQ", m3_OPFQ.Value.ToString());
			if (m3_FANO.HasValue)
				request.WithQueryParameter("FANO", m3_FANO.Value.ToString());
			if (m3_FANQ.HasValue)
				request.WithQueryParameter("FANQ", m3_FANQ.Value.ToString());
			if (m3_FANR.HasValue)
				request.WithQueryParameter("FANR", m3_FANR.Value.ToString());
			if (m3_FATM.HasValue)
				request.WithQueryParameter("FATM", m3_FATM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WCLN))
				request.WithQueryParameter("WCLN", m3_WCLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDEC))
				request.WithQueryParameter("EDEC", m3_EDEC.Trim());
			if (m3_AUGE.HasValue)
				request.WithQueryParameter("AUGE", m3_AUGE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECCC))
				request.WithQueryParameter("ECCC", m3_ECCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPRI))
				request.WithQueryParameter("CPRI", m3_CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPRE))
				request.WithQueryParameter("CPRE", m3_CPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRCM))
				request.WithQueryParameter("PRCM", m3_PRCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLAP))
				request.WithQueryParameter("PLAP", m3_PLAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLUP))
				request.WithQueryParameter("PLUP", m3_PLUP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (m3_CPL0.HasValue)
				request.WithQueryParameter("CPL0", m3_CPL0.Value.ToString());
			if (m3_CPL1.HasValue)
				request.WithQueryParameter("CPL1", m3_CPL1.Value.ToString());
			if (m3_CPL2.HasValue)
				request.WithQueryParameter("CPL2", m3_CPL2.Value.ToString());
			if (m3_PPL0.HasValue)
				request.WithQueryParameter("PPL0", m3_PPL0.Value.ToString());
			if (m3_PPL1.HasValue)
				request.WithQueryParameter("PPL1", m3_PPL1.Value.ToString());
			if (m3_PPL2.HasValue)
				request.WithQueryParameter("PPL2", m3_PPL2.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_CPDC.HasValue)
				request.WithQueryParameter("CPDC", m3_CPDC.Value.ToString());
			if (m3_COCD.HasValue)
				request.WithQueryParameter("COCD", m3_COCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVGR))
				request.WithQueryParameter("EVGR", m3_EVGR.Trim());
			if (m3_VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3_VAMT.Value.ToString());
			if (m3_LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3_LAMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRTI))
				request.WithQueryParameter("GRTI", m3_GRTI.Trim());
			if (m3_MOLL.HasValue)
				request.WithQueryParameter("MOLL", m3_MOLL.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DICM))
				request.WithQueryParameter("DICM", m3_DICM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_STCW.HasValue)
				request.WithQueryParameter("STCW", m3_STCW.Value.ToString());
			if (m3_RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3_RJCW.Value.ToString());
			if (m3_QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3_QUCW.Value.ToString());
			if (m3_CAWC.HasValue)
				request.WithQueryParameter("CAWC", m3_CAWC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CPUN))
				request.WithQueryParameter("CPUN", m3_CPUN.Trim());
			if (m3_COFA.HasValue)
				request.WithQueryParameter("COFA", m3_COFA.Value.ToString());
			if (m3_ALTS.HasValue)
				request.WithQueryParameter("ALTS", m3_ALTS.Value.ToString());
			if (m3_ATTC.HasValue)
				request.WithQueryParameter("ATTC", m3_ATTC.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmMeas
		/// Description Update Item Measurement Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_UNNN">UN number</param>
		/// <param name="m3_UNPA">UN pack code</param>
		/// <param name="m3_HAC1">Danger class 1</param>
		/// <param name="m3_HAC2">Danger class 2</param>
		/// <param name="m3_HAC3">Danger class 3</param>
		/// <param name="m3_DIM1">Measurement 1</param>
		/// <param name="m3_DIM2">Measurement 2</param>
		/// <param name="m3_DIM3">Measurement 3</param>
		/// <param name="m3_SPE1">Specification 1</param>
		/// <param name="m3_SPE2">Specification 2</param>
		/// <param name="m3_SPE3">Specification 3</param>
		/// <param name="m3_SPE4">Specification 4</param>
		/// <param name="m3_SPE5">Specification 5</param>
		/// <param name="m3_CETY">Lot restricted release</param>
		/// <param name="m3_STCN">Storage requirements</param>
		/// <param name="m3_SPAC">Storage packaging</param>
		/// <param name="m3_TRPA">Transportation packaging</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_SMFI">Single manufacturer</param>
		/// <param name="m3_TANK">Bulk item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmMeas(
			string m3_ITNO, 
			int? m3_CONO = null, 
			int? m3_UNNN = null, 
			string m3_UNPA = null, 
			string m3_HAC1 = null, 
			string m3_HAC2 = null, 
			string m3_HAC3 = null, 
			string m3_DIM1 = null, 
			string m3_DIM2 = null, 
			string m3_DIM3 = null, 
			string m3_SPE1 = null, 
			string m3_SPE2 = null, 
			string m3_SPE3 = null, 
			string m3_SPE4 = null, 
			string m3_SPE5 = null, 
			string m3_CETY = null, 
			string m3_STCN = null, 
			string m3_SPAC = null, 
			string m3_TRPA = null, 
			string m3_PROD = null, 
			int? m3_SMFI = null, 
			int? m3_TANK = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3_UNNN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNPA))
				request.WithQueryParameter("UNPA", m3_UNPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAC1))
				request.WithQueryParameter("HAC1", m3_HAC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAC2))
				request.WithQueryParameter("HAC2", m3_HAC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAC3))
				request.WithQueryParameter("HAC3", m3_HAC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIM1))
				request.WithQueryParameter("DIM1", m3_DIM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIM2))
				request.WithQueryParameter("DIM2", m3_DIM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIM3))
				request.WithQueryParameter("DIM3", m3_DIM3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPE1))
				request.WithQueryParameter("SPE1", m3_SPE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPE2))
				request.WithQueryParameter("SPE2", m3_SPE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPE3))
				request.WithQueryParameter("SPE3", m3_SPE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPE4))
				request.WithQueryParameter("SPE4", m3_SPE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPE5))
				request.WithQueryParameter("SPE5", m3_SPE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CETY))
				request.WithQueryParameter("CETY", m3_CETY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STCN))
				request.WithQueryParameter("STCN", m3_STCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPAC))
				request.WithQueryParameter("SPAC", m3_SPAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRPA))
				request.WithQueryParameter("TRPA", m3_TRPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (m3_SMFI.HasValue)
				request.WithQueryParameter("SMFI", m3_SMFI.Value.ToString());
			if (m3_TANK.HasValue)
				request.WithQueryParameter("TANK", m3_TANK.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmPrice
		/// Description Update Item Price Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ECCC">Consumption code - trade stat (TST)</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_CUCS">Currency - sales price</param>
		/// <param name="m3_DIGI">Discount group - item</param>
		/// <param name="m3_BGRP">Bonus group</param>
		/// <param name="m3_PRVG">Commission group</param>
		/// <param name="m3_FRE3">Statistics identity 3 item</param>
		/// <param name="m3_FRE4">Statistics identity 4 item</param>
		/// <param name="m3_OTDI">Order total discount generating</param>
		/// <param name="m3_BOGR">Bonus generating</param>
		/// <param name="m3_PRGR">Commission generating</param>
		/// <param name="m3_ACHK">Assortment check</param>
		/// <param name="m3_BPEY">Update buying pattern</param>
		/// <param name="m3_SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmPrice(
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_ECCC = null, 
			string m3_SUNO = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			string m3_CUCD = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			string m3_CUCS = null, 
			string m3_DIGI = null, 
			string m3_BGRP = null, 
			string m3_PRVG = null, 
			string m3_FRE3 = null, 
			string m3_FRE4 = null, 
			int? m3_OTDI = null, 
			int? m3_BOGR = null, 
			int? m3_PRGR = null, 
			int? m3_ACHK = null, 
			int? m3_BPEY = null, 
			int? m3_SPUC = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECCC))
				request.WithQueryParameter("ECCC", m3_ECCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCS))
				request.WithQueryParameter("CUCS", m3_CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIGI))
				request.WithQueryParameter("DIGI", m3_DIGI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BGRP))
				request.WithQueryParameter("BGRP", m3_BGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRVG))
				request.WithQueryParameter("PRVG", m3_PRVG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE3))
				request.WithQueryParameter("FRE3", m3_FRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE4))
				request.WithQueryParameter("FRE4", m3_FRE4.Trim());
			if (m3_OTDI.HasValue)
				request.WithQueryParameter("OTDI", m3_OTDI.Value.ToString());
			if (m3_BOGR.HasValue)
				request.WithQueryParameter("BOGR", m3_BOGR.Value.ToString());
			if (m3_PRGR.HasValue)
				request.WithQueryParameter("PRGR", m3_PRGR.Value.ToString());
			if (m3_ACHK.HasValue)
				request.WithQueryParameter("ACHK", m3_ACHK.Value.ToString());
			if (m3_BPEY.HasValue)
				request.WithQueryParameter("BPEY", m3_BPEY.Value.ToString());
			if (m3_SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3_SPUC.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmTech
		/// Description Update Item Technical Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ARPA">Repair supplier</param>
		/// <param name="m3_ARPR">Repair planner</param>
		/// <param name="m3_AMPT">Repair time</param>
		/// <param name="m3_AWDY">Repair warranty - days</param>
		/// <param name="m3_NPTO">Tool quantity</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_MES2">Meter 2</param>
		/// <param name="m3_MES3">Meter 3</param>
		/// <param name="m3_MES4">Meter 4</param>
		/// <param name="m3_MVA1">Meter value 1</param>
		/// <param name="m3_MVA2">Meter value 2</param>
		/// <param name="m3_MVA3">Meter value 3</param>
		/// <param name="m3_MVA4">Meter value 4</param>
		/// <param name="m3_PEQ1">Quantity or time</param>
		/// <param name="m3_PEQ2">Quantity or time</param>
		/// <param name="m3_PEQ3">Quantity or time</param>
		/// <param name="m3_PEQ4">Quantity or time</param>
		/// <param name="m3_PET1">Trigger type</param>
		/// <param name="m3_PET2">Trigger type</param>
		/// <param name="m3_PET3">Trigger type</param>
		/// <param name="m3_PET4">Trigger type</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_MAPL">Planner - maintenance</param>
		/// <param name="m3_TOHI">Tool history</param>
		/// <param name="m3_TORE">Tool allocation</param>
		/// <param name="m3_FEBA">Tool reporting</param>
		/// <param name="m3_MAPN">Maintenance planning</param>
		/// <param name="m3_STCS">Downtime cost</param>
		/// <param name="m3_NESA">Next shop action type</param>
		/// <param name="m3_NSUF">Next service</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_PLMZ">Planning horizon</param>
		/// <param name="m3_CCO1">Calculation constant 1</param>
		/// <param name="m3_CCO2">Calculation constant 2</param>
		/// <param name="m3_CCO3">Calculation constant 3</param>
		/// <param name="m3_TBSR">Time between scheduled shop visits</param>
		/// <param name="m3_MBSR">Meter - scheduled shop visits</param>
		/// <param name="m3_TBUR">Unscheduled removal rate</param>
		/// <param name="m3_MBUR">Meter - unscheduled removal rate</param>
		/// <param name="m3_TBFR">Time between failure</param>
		/// <param name="m3_MBFR">Meter - failure</param>
		/// <param name="m3_AESC">Criticality class</param>
		/// <param name="m3_AES2">Extended-range twin-engine operations</param>
		/// <param name="m3_AMOR">Maintenance/overhaul/repair class</param>
		/// <param name="m3_FUNC">Function area</param>
		/// <param name="m3_STNC">Standard numbering system</param>
		/// <param name="m3_DIRR">Dimensional removal rate</param>
		/// <param name="m3_MDIR">Meter - dimensioning removal rate</param>
		/// <param name="m3_SCGR">Service level</param>
		/// <param name="m3_ARR1">Removal class</param>
		/// <param name="m3_AEQY">Extra quantity</param>
		/// <param name="m3_LEAI">Internal lead time</param>
		/// <param name="m3_WAL1">Warranty limit 1</param>
		/// <param name="m3_WAL2">Warranty limit 2</param>
		/// <param name="m3_WAL3">Warranty limit 3</param>
		/// <param name="m3_WAL4">Warranty limit 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmTech(
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_ARPA = null, 
			string m3_ARPR = null, 
			int? m3_AMPT = null, 
			int? m3_AWDY = null, 
			int? m3_NPTO = null, 
			string m3_MES1 = null, 
			string m3_MES2 = null, 
			string m3_MES3 = null, 
			string m3_MES4 = null, 
			decimal? m3_MVA1 = null, 
			decimal? m3_MVA2 = null, 
			decimal? m3_MVA3 = null, 
			decimal? m3_MVA4 = null, 
			int? m3_PEQ1 = null, 
			int? m3_PEQ2 = null, 
			int? m3_PEQ3 = null, 
			int? m3_PEQ4 = null, 
			int? m3_PET1 = null, 
			int? m3_PET2 = null, 
			int? m3_PET3 = null, 
			int? m3_PET4 = null, 
			string m3_MPGM = null, 
			string m3_ORTY = null, 
			string m3_PLCD = null, 
			string m3_MAPL = null, 
			int? m3_TOHI = null, 
			int? m3_TORE = null, 
			int? m3_FEBA = null, 
			int? m3_MAPN = null, 
			decimal? m3_STCS = null, 
			string m3_NESA = null, 
			string m3_NSUF = null, 
			string m3_FCCM = null, 
			int? m3_DPID = null, 
			int? m3_CONC = null, 
			int? m3_PLMZ = null, 
			int? m3_CCO1 = null, 
			int? m3_CCO2 = null, 
			int? m3_CCO3 = null, 
			decimal? m3_TBSR = null, 
			string m3_MBSR = null, 
			decimal? m3_TBUR = null, 
			string m3_MBUR = null, 
			decimal? m3_TBFR = null, 
			string m3_MBFR = null, 
			int? m3_AESC = null, 
			int? m3_AES2 = null, 
			int? m3_AMOR = null, 
			string m3_FUNC = null, 
			string m3_STNC = null, 
			decimal? m3_DIRR = null, 
			string m3_MDIR = null, 
			int? m3_SCGR = null, 
			int? m3_ARR1 = null, 
			decimal? m3_AEQY = null, 
			int? m3_LEAI = null, 
			decimal? m3_WAL1 = null, 
			decimal? m3_WAL2 = null, 
			decimal? m3_WAL3 = null, 
			decimal? m3_WAL4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ARPA))
				request.WithQueryParameter("ARPA", m3_ARPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARPR))
				request.WithQueryParameter("ARPR", m3_ARPR.Trim());
			if (m3_AMPT.HasValue)
				request.WithQueryParameter("AMPT", m3_AMPT.Value.ToString());
			if (m3_AWDY.HasValue)
				request.WithQueryParameter("AWDY", m3_AWDY.Value.ToString());
			if (m3_NPTO.HasValue)
				request.WithQueryParameter("NPTO", m3_NPTO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES2))
				request.WithQueryParameter("MES2", m3_MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES3))
				request.WithQueryParameter("MES3", m3_MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES4))
				request.WithQueryParameter("MES4", m3_MES4.Trim());
			if (m3_MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3_MVA1.Value.ToString());
			if (m3_MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3_MVA2.Value.ToString());
			if (m3_MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3_MVA3.Value.ToString());
			if (m3_MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3_MVA4.Value.ToString());
			if (m3_PEQ1.HasValue)
				request.WithQueryParameter("PEQ1", m3_PEQ1.Value.ToString());
			if (m3_PEQ2.HasValue)
				request.WithQueryParameter("PEQ2", m3_PEQ2.Value.ToString());
			if (m3_PEQ3.HasValue)
				request.WithQueryParameter("PEQ3", m3_PEQ3.Value.ToString());
			if (m3_PEQ4.HasValue)
				request.WithQueryParameter("PEQ4", m3_PEQ4.Value.ToString());
			if (m3_PET1.HasValue)
				request.WithQueryParameter("PET1", m3_PET1.Value.ToString());
			if (m3_PET2.HasValue)
				request.WithQueryParameter("PET2", m3_PET2.Value.ToString());
			if (m3_PET3.HasValue)
				request.WithQueryParameter("PET3", m3_PET3.Value.ToString());
			if (m3_PET4.HasValue)
				request.WithQueryParameter("PET4", m3_PET4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLCD))
				request.WithQueryParameter("PLCD", m3_PLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAPL))
				request.WithQueryParameter("MAPL", m3_MAPL.Trim());
			if (m3_TOHI.HasValue)
				request.WithQueryParameter("TOHI", m3_TOHI.Value.ToString());
			if (m3_TORE.HasValue)
				request.WithQueryParameter("TORE", m3_TORE.Value.ToString());
			if (m3_FEBA.HasValue)
				request.WithQueryParameter("FEBA", m3_FEBA.Value.ToString());
			if (m3_MAPN.HasValue)
				request.WithQueryParameter("MAPN", m3_MAPN.Value.ToString());
			if (m3_STCS.HasValue)
				request.WithQueryParameter("STCS", m3_STCS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NESA))
				request.WithQueryParameter("NESA", m3_NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUF))
				request.WithQueryParameter("NSUF", m3_NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (m3_PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3_PLMZ.Value.ToString());
			if (m3_CCO1.HasValue)
				request.WithQueryParameter("CCO1", m3_CCO1.Value.ToString());
			if (m3_CCO2.HasValue)
				request.WithQueryParameter("CCO2", m3_CCO2.Value.ToString());
			if (m3_CCO3.HasValue)
				request.WithQueryParameter("CCO3", m3_CCO3.Value.ToString());
			if (m3_TBSR.HasValue)
				request.WithQueryParameter("TBSR", m3_TBSR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MBSR))
				request.WithQueryParameter("MBSR", m3_MBSR.Trim());
			if (m3_TBUR.HasValue)
				request.WithQueryParameter("TBUR", m3_TBUR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MBUR))
				request.WithQueryParameter("MBUR", m3_MBUR.Trim());
			if (m3_TBFR.HasValue)
				request.WithQueryParameter("TBFR", m3_TBFR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MBFR))
				request.WithQueryParameter("MBFR", m3_MBFR.Trim());
			if (m3_AESC.HasValue)
				request.WithQueryParameter("AESC", m3_AESC.Value.ToString());
			if (m3_AES2.HasValue)
				request.WithQueryParameter("AES2", m3_AES2.Value.ToString());
			if (m3_AMOR.HasValue)
				request.WithQueryParameter("AMOR", m3_AMOR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FUNC))
				request.WithQueryParameter("FUNC", m3_FUNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STNC))
				request.WithQueryParameter("STNC", m3_STNC.Trim());
			if (m3_DIRR.HasValue)
				request.WithQueryParameter("DIRR", m3_DIRR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MDIR))
				request.WithQueryParameter("MDIR", m3_MDIR.Trim());
			if (m3_SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3_SCGR.Value.ToString());
			if (m3_ARR1.HasValue)
				request.WithQueryParameter("ARR1", m3_ARR1.Value.ToString());
			if (m3_AEQY.HasValue)
				request.WithQueryParameter("AEQY", m3_AEQY.Value.ToString());
			if (m3_LEAI.HasValue)
				request.WithQueryParameter("LEAI", m3_LEAI.Value.ToString());
			if (m3_WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3_WAL1.Value.ToString());
			if (m3_WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3_WAL2.Value.ToString());
			if (m3_WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3_WAL3.Value.ToString());
			if (m3_WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3_WAL4.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmTrpFrelnf
		/// Description Update Item Transport Information , fields A001-A040
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_A001">Alpha field 30 positions</param>
		/// <param name="m3_A002">Alpha field 30 positions</param>
		/// <param name="m3_A003">Alpha field 30 positions</param>
		/// <param name="m3_A004">Alpha field 30 positions</param>
		/// <param name="m3_A005">Alpha field 30 positions</param>
		/// <param name="m3_A006">Alpha field 30 positions</param>
		/// <param name="m3_A007">Alpha field 30 positions</param>
		/// <param name="m3_A008">Alpha field 30 positions</param>
		/// <param name="m3_A009">Alpha field 30 positions</param>
		/// <param name="m3_A010">Alpha field 30 positions</param>
		/// <param name="m3_A021">Alpha field 1 positions</param>
		/// <param name="m3_A022">Alpha field 1 positions</param>
		/// <param name="m3_A023">Alpha field 1 positions</param>
		/// <param name="m3_A024">Alpha field 1 positions</param>
		/// <param name="m3_A025">Alpha field 1 positions</param>
		/// <param name="m3_A026">Alpha field 5 positions</param>
		/// <param name="m3_A027">Alpha field 5 positions</param>
		/// <param name="m3_A028">Alpha field 5 positions</param>
		/// <param name="m3_A029">Alpha field 5 positions</param>
		/// <param name="m3_A030">Alpha field 5 positions</param>
		/// <param name="m3_A031">Alpha field 10 positions</param>
		/// <param name="m3_A032">Alpha field 10 positions</param>
		/// <param name="m3_A033">Alpha field 10 positions</param>
		/// <param name="m3_A034">Alpha field 10 positions</param>
		/// <param name="m3_A035">Alpha field 10 positions</param>
		/// <param name="m3_A036">Alpha field 15 positions</param>
		/// <param name="m3_A037">Alpha field 15 positions</param>
		/// <param name="m3_A038">Alpha field 15 positions</param>
		/// <param name="m3_A039">Alpha field 15 positions</param>
		/// <param name="m3_A040">Alpha field 15 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmTrpFrelnf(
			string m3_ITNO, 
			string m3_A001 = null, 
			string m3_A002 = null, 
			string m3_A003 = null, 
			string m3_A004 = null, 
			string m3_A005 = null, 
			string m3_A006 = null, 
			string m3_A007 = null, 
			string m3_A008 = null, 
			string m3_A009 = null, 
			string m3_A010 = null, 
			string m3_A021 = null, 
			string m3_A022 = null, 
			string m3_A023 = null, 
			string m3_A024 = null, 
			string m3_A025 = null, 
			string m3_A026 = null, 
			string m3_A027 = null, 
			string m3_A028 = null, 
			string m3_A029 = null, 
			string m3_A030 = null, 
			string m3_A031 = null, 
			string m3_A032 = null, 
			string m3_A033 = null, 
			string m3_A034 = null, 
			string m3_A035 = null, 
			string m3_A036 = null, 
			string m3_A037 = null, 
			string m3_A038 = null, 
			string m3_A039 = null, 
			string m3_A040 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_A001))
				request.WithQueryParameter("A001", m3_A001.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A002))
				request.WithQueryParameter("A002", m3_A002.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A003))
				request.WithQueryParameter("A003", m3_A003.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A004))
				request.WithQueryParameter("A004", m3_A004.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A005))
				request.WithQueryParameter("A005", m3_A005.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A006))
				request.WithQueryParameter("A006", m3_A006.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A007))
				request.WithQueryParameter("A007", m3_A007.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A008))
				request.WithQueryParameter("A008", m3_A008.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A009))
				request.WithQueryParameter("A009", m3_A009.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A010))
				request.WithQueryParameter("A010", m3_A010.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A021))
				request.WithQueryParameter("A021", m3_A021.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A022))
				request.WithQueryParameter("A022", m3_A022.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A023))
				request.WithQueryParameter("A023", m3_A023.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A024))
				request.WithQueryParameter("A024", m3_A024.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A025))
				request.WithQueryParameter("A025", m3_A025.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A026))
				request.WithQueryParameter("A026", m3_A026.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A027))
				request.WithQueryParameter("A027", m3_A027.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A028))
				request.WithQueryParameter("A028", m3_A028.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A029))
				request.WithQueryParameter("A029", m3_A029.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A030))
				request.WithQueryParameter("A030", m3_A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A031))
				request.WithQueryParameter("A031", m3_A031.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A032))
				request.WithQueryParameter("A032", m3_A032.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A033))
				request.WithQueryParameter("A033", m3_A033.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A034))
				request.WithQueryParameter("A034", m3_A034.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A035))
				request.WithQueryParameter("A035", m3_A035.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A036))
				request.WithQueryParameter("A036", m3_A036.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A037))
				request.WithQueryParameter("A037", m3_A037.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A038))
				request.WithQueryParameter("A038", m3_A038.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A039))
				request.WithQueryParameter("A039", m3_A039.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A040))
				request.WithQueryParameter("A040", m3_A040.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmTrplnf
		/// Description Update Item Transport Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_UNNN">UN number</param>
		/// <param name="m3_NNNN">NA number</param>
		/// <param name="m3_CASN">CAS number</param>
		/// <param name="m3_ECNM">EU number</param>
		/// <param name="m3_EINM">EINECS number</param>
		/// <param name="m3_ATOM">Atomic number</param>
		/// <param name="m3_CEAN">CEA number</param>
		/// <param name="m3_NAIC">NAICS code</param>
		/// <param name="m3_ITEQ">Item equipment profile</param>
		/// <param name="m3_CMMC">Freight commodity code</param>
		/// <param name="m3_HAZM">Hazardous material</param>
		/// <param name="m3_CMCL">Commodity class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmTrplnf(
			string m3_ITNO, 
			int? m3_UNNN = null, 
			string m3_NNNN = null, 
			string m3_CASN = null, 
			string m3_ECNM = null, 
			string m3_EINM = null, 
			string m3_ATOM = null, 
			string m3_CEAN = null, 
			int? m3_NAIC = null, 
			string m3_ITEQ = null, 
			string m3_CMMC = null, 
			int? m3_HAZM = null, 
			string m3_CMCL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3_UNNN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NNNN))
				request.WithQueryParameter("NNNN", m3_NNNN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CASN))
				request.WithQueryParameter("CASN", m3_CASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECNM))
				request.WithQueryParameter("ECNM", m3_ECNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EINM))
				request.WithQueryParameter("EINM", m3_EINM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATOM))
				request.WithQueryParameter("ATOM", m3_ATOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CEAN))
				request.WithQueryParameter("CEAN", m3_CEAN.Trim());
			if (m3_NAIC.HasValue)
				request.WithQueryParameter("NAIC", m3_NAIC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITEQ))
				request.WithQueryParameter("ITEQ", m3_ITEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMMC))
				request.WithQueryParameter("CMMC", m3_CMMC.Trim());
			if (m3_HAZM.HasValue)
				request.WithQueryParameter("HAZM", m3_HAZM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CMCL))
				request.WithQueryParameter("CMCL", m3_CMCL.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name UpdItmWhs
		/// Description Update Item Warehouse
		/// Version Release: 5ea8
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STQT">On-hand balance approved</param>
		/// <param name="m3_QUQT">On-hand balance for inspection</param>
		/// <param name="m3_RJQT">Rejected on-hand balance</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3_AVAL">Allocatable on-hand balance</param>
		/// <param name="m3_PLQT">Picking list quantity - basic U/M</param>
		/// <param name="m3_COMG">Container management</param>
		/// <param name="m3_ALMT">Allocation method</param>
		/// <param name="m3_STMT">Storage method</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_STTX">Note</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_REQT">Reserved quantity</param>
		/// <param name="m3_RLQT">Reserved quantity to backorder</param>
		/// <param name="m3_REQP">Reserved quantity - planned orders</param>
		/// <param name="m3_IDDT">Last receipt date</param>
		/// <param name="m3_ODDT">Last issue date</param>
		/// <param name="m3_INDT">Latest physical inventory date</param>
		/// <param name="m3_PRDC">Priority date selection</param>
		/// <param name="m3_INCD">Physical inventory cycle</param>
		/// <param name="m3_NUIN">Number of records for physical inventory</param>
		/// <param name="m3_USYE">Annual usage</param>
		/// <param name="m3_AVST">Average on-hand balance</param>
		/// <param name="m3_DILE">Projected on-hand at end of lead time</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_WHTY">Warehouse type</param>
		/// <param name="m3_WHSY">Warehouse subtype</param>
		/// <param name="m3_INSC">Statistics storage group</param>
		/// <param name="m3_DIGR">Distribution group</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_NUS7">Number of balance IDs</param>
		/// <param name="m3_TOMU">Issue multiple</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_MABC">ABC class - manual</param>
		/// <param name="m3_ABCD">ABC class - volume</param>
		/// <param name="m3_ABCM">ABC method  - volume</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_ABFM">ABC method - frequency</param>
		/// <param name="m3_ACOC">ABC class - contribution</param>
		/// <param name="m3_ACOM">ABC method - contribution</param>
		/// <param name="m3_PRIF">Priority value</param>
		/// <param name="m3_SODY">Run-out time</param>
		/// <param name="m3_REOP">Reorder point</param>
		/// <param name="m3_OPOM">Reorder point method</param>
		/// <param name="m3_SSQT">Safety stock</param>
		/// <param name="m3_SSMT">Safety stock method</param>
		/// <param name="m3_MSSQ">Manual safety stock</param>
		/// <param name="m3_SSDA">Safety stock unit</param>
		/// <param name="m3_SCGR">Service level</param>
		/// <param name="m3_MXST">Maximum stock</param>
		/// <param name="m3_MXSM">Maximum stock method</param>
		/// <param name="m3_MXPC">Maximum stock percentage</param>
		/// <param name="m3_EOQT">Order quantity</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_EQDA">Economical order quantity days</param>
		/// <param name="m3_YEQT">Annual demand</param>
		/// <param name="m3_YEQM">Annual demand method</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_MOQT">Maximum order quantity</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_SUWH">Supplying warehouse</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_PRCD">Forecast method</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_LYQT">Fixed annual demand</param>
		/// <param name="m3_LRYE">Fixed acquisition requirement</param>
		/// <param name="m3_PFTM">Planning time fence</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_LEA2">Inspection lead time</param>
		/// <param name="m3_LEA3">Transportation lead time</param>
		/// <param name="m3_LEAT">Lead time</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_SVEI">Multiple supply</param>
		/// <param name="m3_LEVL">Lowest level</param>
		/// <param name="m3_LEVD">Lowest level DO</param>
		/// <param name="m3_PLHZ">Planning horizon</param>
		/// <param name="m3_DMFN">Demand time fence</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_SATD">Safety time</param>
		/// <param name="m3_ALQC">Quantity controlled allocation</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_SHCC">Distribution/supplier calendar check</param>
		/// <param name="m3_ZCAC">Zero mark</param>
		/// <param name="m3_INSL">Inspection location</param>
		/// <param name="m3_NCCA">Net change calculation active</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DDEX">Time phased safety stock exists</param>
		/// <param name="m3_STRL">History storage method</param>
		/// <param name="m3_PLIC">Picking list information control</param>
		/// <param name="m3_PPMC">Pending planning method change</param>
		/// <param name="m3_MPCD">Calculation date - material planning</param>
		/// <param name="m3_MPCT">Calculation time - material planning</param>
		/// <param name="m3_DCSS">Time phased safety stock</param>
		/// <param name="m3_RPOP">Responsible - PO proposal</param>
		/// <param name="m3_BCOS">Standard cost - warehouse</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_DPLO">Default packing location</param>
		/// <param name="m3_DDLO">Default docking location</param>
		/// <param name="m3_SPLC">Delivery split rule</param>
		/// <param name="m3_ALS1">Allocate non-approved balance ID</param>
		/// <param name="m3_POOT">Point of time table</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_MNUN">Main unit of calculation</param>
		/// <param name="m3_GRTS">Distribution group technology</param>
		/// <param name="m3_SLDY">Shelf life</param>
		/// <param name="m3_REDY">Reinspection time</param>
		/// <param name="m3_SAEL">Sales time</param>
		/// <param name="m3_CPCD">CTP policy</param>
		/// <param name="m3_LEAQ">Quarantine lead-time</param>
		/// <param name="m3_SCHT">Scheduled re-classification allowed</param>
		/// <param name="m3_STCW">Catch weight approved on hand balance</param>
		/// <param name="m3_RJCW">Catch weight rejected on hand balance</param>
		/// <param name="m3_QUCW">Catch weight for inspection on hand bal</param>
		/// <param name="m3_CWCP">Alternate U/M</param>
		/// <param name="m3_CPUN">Standard cost price unit of measure</param>
		/// <param name="m3_IPLA">Inventory planned</param>
		/// <param name="m3_BBTM">Best before time</param>
		/// <param name="m3_FSSQ">Frozen safety stock</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_SSRE">SS reason code</param>
		/// <param name="m3_ISEG">Inventory segment</param>
		/// <param name="m3_SALM">Secondary allocation method</param>
		/// <param name="m3_SCPO">Supply chain policy</param>
		/// <param name="m3_AGDY">Aging days</param>
		/// <param name="m3_AGHO">Aging hours</param>
		/// <param name="m3_AGMI">Aging minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmWhs(
			string m3_WHLO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			decimal? m3_STQT = null, 
			decimal? m3_QUQT = null, 
			decimal? m3_RJQT = null, 
			decimal? m3_ALQT = null, 
			decimal? m3_AVAL = null, 
			decimal? m3_PLQT = null, 
			int? m3_COMG = null, 
			int? m3_ALMT = null, 
			int? m3_STMT = null, 
			int? m3_SPMT = null, 
			string m3_STTX = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_REQT = null, 
			decimal? m3_RLQT = null, 
			decimal? m3_REQP = null, 
			DateTime? m3_IDDT = null, 
			DateTime? m3_ODDT = null, 
			DateTime? m3_INDT = null, 
			int? m3_PRDC = null, 
			string m3_INCD = null, 
			int? m3_NUIN = null, 
			decimal? m3_USYE = null, 
			decimal? m3_AVST = null, 
			decimal? m3_DILE = null, 
			string m3_RESP = null, 
			string m3_BUYE = null, 
			string m3_SUNO = null, 
			string m3_WHTY = null, 
			string m3_WHSY = null, 
			int? m3_INSC = null, 
			string m3_DIGR = null, 
			string m3_WHSL = null, 
			string m3_SLTP = null, 
			int? m3_NUS7 = null, 
			decimal? m3_TOMU = null, 
			string m3_WHLT = null, 
			string m3_PISE = null, 
			string m3_PLCD = null, 
			string m3_MABC = null, 
			string m3_ABCD = null, 
			int? m3_ABCM = null, 
			string m3_ABFC = null, 
			int? m3_ABFM = null, 
			string m3_ACOC = null, 
			int? m3_ACOM = null, 
			int? m3_PRIF = null, 
			int? m3_SODY = null, 
			decimal? m3_REOP = null, 
			int? m3_OPOM = null, 
			decimal? m3_SSQT = null, 
			int? m3_SSMT = null, 
			decimal? m3_MSSQ = null, 
			int? m3_SSDA = null, 
			int? m3_SCGR = null, 
			decimal? m3_MXST = null, 
			int? m3_MXSM = null, 
			int? m3_MXPC = null, 
			decimal? m3_EOQT = null, 
			int? m3_EOQM = null, 
			int? m3_EQDA = null, 
			decimal? m3_YEQT = null, 
			int? m3_YEQM = null, 
			decimal? m3_LOQT = null, 
			decimal? m3_MOQT = null, 
			int? m3_PUIT = null, 
			string m3_SUWH = null, 
			int? m3_DPID = null, 
			string m3_PRCD = null, 
			string m3_FCCM = null, 
			decimal? m3_LYQT = null, 
			decimal? m3_LRYE = null, 
			int? m3_PFTM = null, 
			int? m3_LEA1 = null, 
			int? m3_LEA2 = null, 
			int? m3_LEA3 = null, 
			int? m3_LEAT = null, 
			decimal? m3_UNMU = null, 
			int? m3_SVEI = null, 
			int? m3_LEVL = null, 
			int? m3_LEVD = null, 
			int? m3_PLHZ = null, 
			int? m3_DMFN = null, 
			string m3_ORTY = null, 
			int? m3_CONC = null, 
			int? m3_SATD = null, 
			int? m3_ALQC = null, 
			int? m3_OPLC = null, 
			int? m3_MSCH = null, 
			int? m3_SHCC = null, 
			int? m3_ZCAC = null, 
			string m3_INSL = null, 
			int? m3_NCCA = null, 
			string m3_FACI = null, 
			string m3_DIVI = null, 
			int? m3_DDEX = null, 
			int? m3_STRL = null, 
			int? m3_PLIC = null, 
			int? m3_PPMC = null, 
			DateTime? m3_MPCD = null, 
			int? m3_MPCT = null, 
			int? m3_DCSS = null, 
			int? m3_RPOP = null, 
			decimal? m3_BCOS = null, 
			decimal? m3_TXID = null, 
			decimal? m3_DTID = null, 
			string m3_DPLO = null, 
			string m3_DDLO = null, 
			string m3_SPLC = null, 
			int? m3_ALS1 = null, 
			string m3_POOT = null, 
			string m3_STAT = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			string m3_MNUN = null, 
			string m3_GRTS = null, 
			int? m3_SLDY = null, 
			int? m3_REDY = null, 
			int? m3_SAEL = null, 
			string m3_CPCD = null, 
			int? m3_LEAQ = null, 
			int? m3_SCHT = null, 
			decimal? m3_STCW = null, 
			decimal? m3_RJCW = null, 
			decimal? m3_QUCW = null, 
			string m3_CWCP = null, 
			string m3_CPUN = null, 
			string m3_IPLA = null, 
			int? m3_BBTM = null, 
			int? m3_FSSQ = null, 
			int? m3_RNRI = null, 
			int? m3_RMSG = null, 
			string m3_SSRE = null, 
			string m3_ISEG = null, 
			int? m3_SALM = null, 
			string m3_SCPO = null, 
			int? m3_AGDY = null, 
			int? m3_AGHO = null, 
			int? m3_AGMI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STQT.HasValue)
				request.WithQueryParameter("STQT", m3_STQT.Value.ToString());
			if (m3_QUQT.HasValue)
				request.WithQueryParameter("QUQT", m3_QUQT.Value.ToString());
			if (m3_RJQT.HasValue)
				request.WithQueryParameter("RJQT", m3_RJQT.Value.ToString());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());
			if (m3_AVAL.HasValue)
				request.WithQueryParameter("AVAL", m3_AVAL.Value.ToString());
			if (m3_PLQT.HasValue)
				request.WithQueryParameter("PLQT", m3_PLQT.Value.ToString());
			if (m3_COMG.HasValue)
				request.WithQueryParameter("COMG", m3_COMG.Value.ToString());
			if (m3_ALMT.HasValue)
				request.WithQueryParameter("ALMT", m3_ALMT.Value.ToString());
			if (m3_STMT.HasValue)
				request.WithQueryParameter("STMT", m3_STMT.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STTX))
				request.WithQueryParameter("STTX", m3_STTX.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_REQT.HasValue)
				request.WithQueryParameter("REQT", m3_REQT.Value.ToString());
			if (m3_RLQT.HasValue)
				request.WithQueryParameter("RLQT", m3_RLQT.Value.ToString());
			if (m3_REQP.HasValue)
				request.WithQueryParameter("REQP", m3_REQP.Value.ToString());
			if (m3_IDDT.HasValue)
				request.WithQueryParameter("IDDT", m3_IDDT.Value.ToM3String());
			if (m3_ODDT.HasValue)
				request.WithQueryParameter("ODDT", m3_ODDT.Value.ToM3String());
			if (m3_INDT.HasValue)
				request.WithQueryParameter("INDT", m3_INDT.Value.ToM3String());
			if (m3_PRDC.HasValue)
				request.WithQueryParameter("PRDC", m3_PRDC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INCD))
				request.WithQueryParameter("INCD", m3_INCD.Trim());
			if (m3_NUIN.HasValue)
				request.WithQueryParameter("NUIN", m3_NUIN.Value.ToString());
			if (m3_USYE.HasValue)
				request.WithQueryParameter("USYE", m3_USYE.Value.ToString());
			if (m3_AVST.HasValue)
				request.WithQueryParameter("AVST", m3_AVST.Value.ToString());
			if (m3_DILE.HasValue)
				request.WithQueryParameter("DILE", m3_DILE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHTY))
				request.WithQueryParameter("WHTY", m3_WHTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSY))
				request.WithQueryParameter("WHSY", m3_WHSY.Trim());
			if (m3_INSC.HasValue)
				request.WithQueryParameter("INSC", m3_INSC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIGR))
				request.WithQueryParameter("DIGR", m3_DIGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (m3_NUS7.HasValue)
				request.WithQueryParameter("NUS7", m3_NUS7.Value.ToString());
			if (m3_TOMU.HasValue)
				request.WithQueryParameter("TOMU", m3_TOMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLCD))
				request.WithQueryParameter("PLCD", m3_PLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MABC))
				request.WithQueryParameter("MABC", m3_MABC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (m3_ABCM.HasValue)
				request.WithQueryParameter("ABCM", m3_ABCM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ABFC))
				request.WithQueryParameter("ABFC", m3_ABFC.Trim());
			if (m3_ABFM.HasValue)
				request.WithQueryParameter("ABFM", m3_ABFM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACOC))
				request.WithQueryParameter("ACOC", m3_ACOC.Trim());
			if (m3_ACOM.HasValue)
				request.WithQueryParameter("ACOM", m3_ACOM.Value.ToString());
			if (m3_PRIF.HasValue)
				request.WithQueryParameter("PRIF", m3_PRIF.Value.ToString());
			if (m3_SODY.HasValue)
				request.WithQueryParameter("SODY", m3_SODY.Value.ToString());
			if (m3_REOP.HasValue)
				request.WithQueryParameter("REOP", m3_REOP.Value.ToString());
			if (m3_OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3_OPOM.Value.ToString());
			if (m3_SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3_SSQT.Value.ToString());
			if (m3_SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3_SSMT.Value.ToString());
			if (m3_MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3_MSSQ.Value.ToString());
			if (m3_SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3_SSDA.Value.ToString());
			if (m3_SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3_SCGR.Value.ToString());
			if (m3_MXST.HasValue)
				request.WithQueryParameter("MXST", m3_MXST.Value.ToString());
			if (m3_MXSM.HasValue)
				request.WithQueryParameter("MXSM", m3_MXSM.Value.ToString());
			if (m3_MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3_MXPC.Value.ToString());
			if (m3_EOQT.HasValue)
				request.WithQueryParameter("EOQT", m3_EOQT.Value.ToString());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3_EQDA.Value.ToString());
			if (m3_YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3_YEQT.Value.ToString());
			if (m3_YEQM.HasValue)
				request.WithQueryParameter("YEQM", m3_YEQM.Value.ToString());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3_MOQT.Value.ToString());
			if (m3_PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3_PUIT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUWH))
				request.WithQueryParameter("SUWH", m3_SUWH.Trim());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRCD))
				request.WithQueryParameter("PRCD", m3_PRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_LYQT.HasValue)
				request.WithQueryParameter("LYQT", m3_LYQT.Value.ToString());
			if (m3_LRYE.HasValue)
				request.WithQueryParameter("LRYE", m3_LRYE.Value.ToString());
			if (m3_PFTM.HasValue)
				request.WithQueryParameter("PFTM", m3_PFTM.Value.ToString());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (m3_LEA2.HasValue)
				request.WithQueryParameter("LEA2", m3_LEA2.Value.ToString());
			if (m3_LEA3.HasValue)
				request.WithQueryParameter("LEA3", m3_LEA3.Value.ToString());
			if (m3_LEAT.HasValue)
				request.WithQueryParameter("LEAT", m3_LEAT.Value.ToString());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (m3_SVEI.HasValue)
				request.WithQueryParameter("SVEI", m3_SVEI.Value.ToString());
			if (m3_LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3_LEVL.Value.ToString());
			if (m3_LEVD.HasValue)
				request.WithQueryParameter("LEVD", m3_LEVD.Value.ToString());
			if (m3_PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3_PLHZ.Value.ToString());
			if (m3_DMFN.HasValue)
				request.WithQueryParameter("DMFN", m3_DMFN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (m3_SATD.HasValue)
				request.WithQueryParameter("SATD", m3_SATD.Value.ToString());
			if (m3_ALQC.HasValue)
				request.WithQueryParameter("ALQC", m3_ALQC.Value.ToString());
			if (m3_OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3_OPLC.Value.ToString());
			if (m3_MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3_MSCH.Value.ToString());
			if (m3_SHCC.HasValue)
				request.WithQueryParameter("SHCC", m3_SHCC.Value.ToString());
			if (m3_ZCAC.HasValue)
				request.WithQueryParameter("ZCAC", m3_ZCAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INSL))
				request.WithQueryParameter("INSL", m3_INSL.Trim());
			if (m3_NCCA.HasValue)
				request.WithQueryParameter("NCCA", m3_NCCA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_DDEX.HasValue)
				request.WithQueryParameter("DDEX", m3_DDEX.Value.ToString());
			if (m3_STRL.HasValue)
				request.WithQueryParameter("STRL", m3_STRL.Value.ToString());
			if (m3_PLIC.HasValue)
				request.WithQueryParameter("PLIC", m3_PLIC.Value.ToString());
			if (m3_PPMC.HasValue)
				request.WithQueryParameter("PPMC", m3_PPMC.Value.ToString());
			if (m3_MPCD.HasValue)
				request.WithQueryParameter("MPCD", m3_MPCD.Value.ToM3String());
			if (m3_MPCT.HasValue)
				request.WithQueryParameter("MPCT", m3_MPCT.Value.ToString());
			if (m3_DCSS.HasValue)
				request.WithQueryParameter("DCSS", m3_DCSS.Value.ToString());
			if (m3_RPOP.HasValue)
				request.WithQueryParameter("RPOP", m3_RPOP.Value.ToString());
			if (m3_BCOS.HasValue)
				request.WithQueryParameter("BCOS", m3_BCOS.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DPLO))
				request.WithQueryParameter("DPLO", m3_DPLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DDLO))
				request.WithQueryParameter("DDLO", m3_DDLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLC))
				request.WithQueryParameter("SPLC", m3_SPLC.Trim());
			if (m3_ALS1.HasValue)
				request.WithQueryParameter("ALS1", m3_ALS1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POOT))
				request.WithQueryParameter("POOT", m3_POOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MNUN))
				request.WithQueryParameter("MNUN", m3_MNUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTS))
				request.WithQueryParameter("GRTS", m3_GRTS.Trim());
			if (m3_SLDY.HasValue)
				request.WithQueryParameter("SLDY", m3_SLDY.Value.ToString());
			if (m3_REDY.HasValue)
				request.WithQueryParameter("REDY", m3_REDY.Value.ToString());
			if (m3_SAEL.HasValue)
				request.WithQueryParameter("SAEL", m3_SAEL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CPCD))
				request.WithQueryParameter("CPCD", m3_CPCD.Trim());
			if (m3_LEAQ.HasValue)
				request.WithQueryParameter("LEAQ", m3_LEAQ.Value.ToString());
			if (m3_SCHT.HasValue)
				request.WithQueryParameter("SCHT", m3_SCHT.Value.ToString());
			if (m3_STCW.HasValue)
				request.WithQueryParameter("STCW", m3_STCW.Value.ToString());
			if (m3_RJCW.HasValue)
				request.WithQueryParameter("RJCW", m3_RJCW.Value.ToString());
			if (m3_QUCW.HasValue)
				request.WithQueryParameter("QUCW", m3_QUCW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CWCP))
				request.WithQueryParameter("CWCP", m3_CWCP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPUN))
				request.WithQueryParameter("CPUN", m3_CPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IPLA))
				request.WithQueryParameter("IPLA", m3_IPLA.Trim());
			if (m3_BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3_BBTM.Value.ToString());
			if (m3_FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3_FSSQ.Value.ToString());
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSRE))
				request.WithQueryParameter("SSRE", m3_SSRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISEG))
				request.WithQueryParameter("ISEG", m3_ISEG.Trim());
			if (m3_SALM.HasValue)
				request.WithQueryParameter("SALM", m3_SALM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPO))
				request.WithQueryParameter("SCPO", m3_SCPO.Trim());
			if (m3_AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3_AGDY.Value.ToString());
			if (m3_AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3_AGHO.Value.ToString());
			if (m3_AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3_AGMI.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}
	}
}
// EOF
