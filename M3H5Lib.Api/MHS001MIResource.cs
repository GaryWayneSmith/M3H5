/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS001MI;
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
	/// Name: MHS001MI
	/// Component Name: Interface Item Master
	/// Description: Api: Interface Item Master
	/// Version Release: 5ea3
	///</summary>
	public partial class MHS001MIResource : M3BaseResourceEndpoint
	{
		public MHS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItmMst
		/// Description Add interface item master
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_BUAR">Business area</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_MABU">Make/buy code</param>
		/// <param name="m3_PRGP">Procurement group</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_INDI">Lot control method</param>
		/// <param name="m3_BACD">Lot numbering method</param>
		/// <param name="m3_ALUC">Alternate U/M in use</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_EXPD">Expiration date method</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_ACTI">Active or catch weight item</param>
		/// <param name="m3_EVGR">Environment group</param>
		/// <param name="m3_SALE">Sales item</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_CUCS">Currency - sales price</param>
		/// <param name="m3_WHTA">Warehouse table</param>
		/// <param name="m3_DIGI">Discount group - item</param>
		/// <param name="m3_SECH">Season control</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3_HIE1">Hierarchy level 1</param>
		/// <param name="m3_HIE2">Hierarchy level 2</param>
		/// <param name="m3_HIE3">Hierarchy level 3</param>
		/// <param name="m3_HIE4">Hierarchy level 4</param>
		/// <param name="m3_HIE5">Hierarchy level 5</param>
		/// <param name="m3_GRP1">Search group 1</param>
		/// <param name="m3_GRP2">Search group 2</param>
		/// <param name="m3_GRP3">Search group 3</param>
		/// <param name="m3_GRP4">Search group 4</param>
		/// <param name="m3_GRP5">Search group 5</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_SPE1">Specification 1</param>
		/// <param name="m3_SPE2">Specification 2</param>
		/// <param name="m3_SPE3">Specification 3</param>
		/// <param name="m3_SPE4">Specification 4</param>
		/// <param name="m3_SPE5">Specification 5</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_SAFC">Suppliers ABC code</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_ACMC">Compatibility code</param>
		/// <param name="m3_ATMN">Attribute managed</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="m3_ITRU">Included in territorial roll-up</param>
		/// <param name="m3_HVMT">Harvest Method</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_NESA">Next shop action type</param>
		/// <param name="m3_NSUF">Next service</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_TANK">Tank</param>
		/// <param name="m3_SPGV">Specific gravity</param>
		/// <param name="m3_ILEN">Length</param>
		/// <param name="m3_IWID">Width</param>
		/// <param name="m3_IHEI">Height</param>
		/// <param name="m3_RUID">Ruleset ID</param>
		/// <param name="m3_PDLN">Product line</param>
		/// <param name="m3_ITNE">Extended item number</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_SUME">Sublot method</param>
		/// <param name="m3_CAWP">Location-based catch weight</param>
		/// <param name="m3_SUMP">Sublot policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddIntItmMstResponse></returns>
		/// <exception cref="M3Exception<AddIntItmMstResponse>"></exception>
		public async Task<M3Response<AddIntItmMstResponse>> AddIntItmMst(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_PMSN = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_DWNO = null, 
			string m3_STAT = null, 
			string m3_ITTY = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_BUAR = null, 
			int? m3_STCD = null, 
			string m3_UNMS = null, 
			string m3_RESP = null, 
			int? m3_MABU = null, 
			string m3_PRGP = null, 
			string m3_ACRF = null, 
			int? m3_INDI = null, 
			int? m3_BACD = null, 
			int? m3_ALUC = null, 
			int? m3_DCCD = null, 
			int? m3_EXPD = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_VOL3 = null, 
			int? m3_ACTI = null, 
			string m3_EVGR = null, 
			int? m3_SALE = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			string m3_CUCD = null, 
			string m3_SUNO = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			string m3_CUCS = null, 
			string m3_WHTA = null, 
			string m3_DIGI = null, 
			int? m3_SECH = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			int? m3_CHCD = null, 
			decimal? m3_TXID = null, 
			int? m3_SPUC = null, 
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
			string m3_ECVE = null, 
			string m3_SPE1 = null, 
			string m3_SPE2 = null, 
			string m3_SPE3 = null, 
			string m3_SPE4 = null, 
			string m3_SPE5 = null, 
			int? m3_RNRI = null, 
			string m3_SAFC = null, 
			int? m3_RMSG = null, 
			string m3_MOTP = null, 
			string m3_ACMC = null, 
			int? m3_ATMN = null, 
			string m3_ATMO = null, 
			int? m3_ITRU = null, 
			int? m3_HVMT = null, 
			string m3_ITAB = null, 
			string m3_NESA = null, 
			string m3_NSUF = null, 
			string m3_ORTY = null, 
			int? m3_TANK = null, 
			decimal? m3_SPGV = null, 
			int? m3_ILEN = null, 
			int? m3_IWID = null, 
			int? m3_IHEI = null, 
			string m3_RUID = null, 
			string m3_PDLN = null, 
			string m3_ITNE = null, 
			string m3_CPGR = null, 
			int? m3_SUME = null, 
			int? m3_CAWP = null, 
			string m3_SUMP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIntItmMst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUAR))
				request.WithQueryParameter("BUAR", m3_BUAR.Trim());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_MABU.HasValue)
				request.WithQueryParameter("MABU", m3_MABU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRGP))
				request.WithQueryParameter("PRGP", m3_PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_INDI.HasValue)
				request.WithQueryParameter("INDI", m3_INDI.Value.ToString());
			if (m3_BACD.HasValue)
				request.WithQueryParameter("BACD", m3_BACD.Value.ToString());
			if (m3_ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3_ALUC.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3_EXPD.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3_ACTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVGR))
				request.WithQueryParameter("EVGR", m3_EVGR.Trim());
			if (m3_SALE.HasValue)
				request.WithQueryParameter("SALE", m3_SALE.Value.ToString());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCS))
				request.WithQueryParameter("CUCS", m3_CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHTA))
				request.WithQueryParameter("WHTA", m3_WHTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIGI))
				request.WithQueryParameter("DIGI", m3_DIGI.Trim());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
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
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3_SPUC.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
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
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SAFC))
				request.WithQueryParameter("SAFC", m3_SAFC.Trim());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACMC))
				request.WithQueryParameter("ACMC", m3_ACMC.Trim());
			if (m3_ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3_ATMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());
			if (m3_ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3_ITRU.Value.ToString());
			if (m3_HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3_HVMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NESA))
				request.WithQueryParameter("NESA", m3_NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUF))
				request.WithQueryParameter("NSUF", m3_NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (m3_TANK.HasValue)
				request.WithQueryParameter("TANK", m3_TANK.Value.ToString());
			if (m3_SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3_SPGV.Value.ToString());
			if (m3_ILEN.HasValue)
				request.WithQueryParameter("ILEN", m3_ILEN.Value.ToString());
			if (m3_IWID.HasValue)
				request.WithQueryParameter("IWID", m3_IWID.Value.ToString());
			if (m3_IHEI.HasValue)
				request.WithQueryParameter("IHEI", m3_IHEI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RUID))
				request.WithQueryParameter("RUID", m3_RUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PDLN))
				request.WithQueryParameter("PDLN", m3_PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNE))
				request.WithQueryParameter("ITNE", m3_ITNE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (m3_SUME.HasValue)
				request.WithQueryParameter("SUME", m3_SUME.Value.ToString());
			if (m3_CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3_CAWP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUMP))
				request.WithQueryParameter("SUMP", m3_SUMP.Trim());

			// Execute the request
			var result = await Execute<AddIntItmMstResponse>(
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
		/// Name ChgIntItmMst
		/// Description Change interface item
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_BUAR">Business area</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_MABU">Make/buy code</param>
		/// <param name="m3_PRGP">Procurement group</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_INDI">Lot control method</param>
		/// <param name="m3_BACD">Lot numbering method</param>
		/// <param name="m3_ALUC">Alternate U/M in use</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_EXPD">Expiration date method</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_ACTI">Active or catch weight item</param>
		/// <param name="m3_EVGR">Environment group</param>
		/// <param name="m3_SALE">Sales item</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_CUCS">Currency - sales price</param>
		/// <param name="m3_WHTA">Warehouse table</param>
		/// <param name="m3_DIGI">Discount group - item</param>
		/// <param name="m3_SECH">Season control</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3_HIE1">Hierarchy level 1</param>
		/// <param name="m3_HIE2">Hierarchy level 2</param>
		/// <param name="m3_HIE3">Hierarchy level 3</param>
		/// <param name="m3_HIE4">Hierarchy level 4</param>
		/// <param name="m3_HIE5">Hierarchy level 5</param>
		/// <param name="m3_GRP1">Search group 1</param>
		/// <param name="m3_GRP2">Search group 2</param>
		/// <param name="m3_GRP3">Search group 3</param>
		/// <param name="m3_GRP4">Search group 4</param>
		/// <param name="m3_GRP5">Search group 5</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_SPE1">Specification 1</param>
		/// <param name="m3_SPE2">Specification 2</param>
		/// <param name="m3_SPE3">Specification 3</param>
		/// <param name="m3_SPE4">Specification 4</param>
		/// <param name="m3_SPE5">Specification 5</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_SAFC">Suppliers ABC code</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_ATMN">Attribute managed</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="m3_ITRU">Included in territorial roll-up</param>
		/// <param name="m3_HVMT">Harvest Method</param>
		/// <param name="m3_NESA">Next shop action type</param>
		/// <param name="m3_NSUF">Next service</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_TANK">Tank</param>
		/// <param name="m3_SPGV">Specific gravity</param>
		/// <param name="m3_ILEN">Length</param>
		/// <param name="m3_IWID">Width</param>
		/// <param name="m3_IHEI">Height</param>
		/// <param name="m3_RUID">Ruleset ID</param>
		/// <param name="m3_PDLN">Product line</param>
		/// <param name="m3_ITNE">Extended item number</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_SUME">Sublot method</param>
		/// <param name="m3_CAWP">Location-based catch weight</param>
		/// <param name="m3_SUMP">Sublot policy</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmMst(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_PMSN = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_DWNO = null, 
			string m3_STAT = null, 
			string m3_ITTY = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_BUAR = null, 
			int? m3_STCD = null, 
			string m3_UNMS = null, 
			string m3_RESP = null, 
			int? m3_MABU = null, 
			string m3_PRGP = null, 
			string m3_ACRF = null, 
			int? m3_INDI = null, 
			int? m3_BACD = null, 
			int? m3_ALUC = null, 
			int? m3_DCCD = null, 
			int? m3_EXPD = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_VOL3 = null, 
			int? m3_ACTI = null, 
			string m3_EVGR = null, 
			int? m3_SALE = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			string m3_CUCD = null, 
			string m3_SUNO = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			string m3_CUCS = null, 
			string m3_WHTA = null, 
			string m3_DIGI = null, 
			int? m3_SECH = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			int? m3_CHCD = null, 
			decimal? m3_TXID = null, 
			int? m3_SPUC = null, 
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
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			string m3_ECVE = null, 
			string m3_SPE1 = null, 
			string m3_SPE2 = null, 
			string m3_SPE3 = null, 
			string m3_SPE4 = null, 
			string m3_SPE5 = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			int? m3_RNRI = null, 
			string m3_SAFC = null, 
			int? m3_RMSG = null, 
			string m3_ITAB = null, 
			int? m3_ATMN = null, 
			string m3_ATMO = null, 
			int? m3_ITRU = null, 
			int? m3_HVMT = null, 
			string m3_NESA = null, 
			string m3_NSUF = null, 
			string m3_ORTY = null, 
			int? m3_TANK = null, 
			decimal? m3_SPGV = null, 
			int? m3_ILEN = null, 
			int? m3_IWID = null, 
			int? m3_IHEI = null, 
			string m3_RUID = null, 
			string m3_PDLN = null, 
			string m3_ITNE = null, 
			string m3_CPGR = null, 
			int? m3_SUME = null, 
			int? m3_CAWP = null, 
			string m3_SUMP = null, 
			string m3_MOTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgIntItmMst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUAR))
				request.WithQueryParameter("BUAR", m3_BUAR.Trim());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_MABU.HasValue)
				request.WithQueryParameter("MABU", m3_MABU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRGP))
				request.WithQueryParameter("PRGP", m3_PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_INDI.HasValue)
				request.WithQueryParameter("INDI", m3_INDI.Value.ToString());
			if (m3_BACD.HasValue)
				request.WithQueryParameter("BACD", m3_BACD.Value.ToString());
			if (m3_ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3_ALUC.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3_EXPD.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3_ACTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVGR))
				request.WithQueryParameter("EVGR", m3_EVGR.Trim());
			if (m3_SALE.HasValue)
				request.WithQueryParameter("SALE", m3_SALE.Value.ToString());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCS))
				request.WithQueryParameter("CUCS", m3_CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHTA))
				request.WithQueryParameter("WHTA", m3_WHTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIGI))
				request.WithQueryParameter("DIGI", m3_DIGI.Trim());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
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
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3_SPUC.Value.ToString());
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
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
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
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SAFC))
				request.WithQueryParameter("SAFC", m3_SAFC.Trim());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (m3_ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3_ATMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());
			if (m3_ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3_ITRU.Value.ToString());
			if (m3_HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3_HVMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NESA))
				request.WithQueryParameter("NESA", m3_NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUF))
				request.WithQueryParameter("NSUF", m3_NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (m3_TANK.HasValue)
				request.WithQueryParameter("TANK", m3_TANK.Value.ToString());
			if (m3_SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3_SPGV.Value.ToString());
			if (m3_ILEN.HasValue)
				request.WithQueryParameter("ILEN", m3_ILEN.Value.ToString());
			if (m3_IWID.HasValue)
				request.WithQueryParameter("IWID", m3_IWID.Value.ToString());
			if (m3_IHEI.HasValue)
				request.WithQueryParameter("IHEI", m3_IHEI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RUID))
				request.WithQueryParameter("RUID", m3_RUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PDLN))
				request.WithQueryParameter("PDLN", m3_PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNE))
				request.WithQueryParameter("ITNE", m3_ITNE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (m3_SUME.HasValue)
				request.WithQueryParameter("SUME", m3_SUME.Value.ToString());
			if (m3_CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3_CAWP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUMP))
				request.WithQueryParameter("SUMP", m3_SUMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());

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
		/// Name CpyIntItmMst
		/// Description Copy interface item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_TE0P">Partner (Required)</param>
		/// <param name="m3_TE06">Message type (Required)</param>
		/// <param name="m3_TFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmMst(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_TE0P, 
			string m3_TE06, 
			string m3_TFIN, 
			string m3_PRMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyIntItmMst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_TE0P))
				throw new ArgumentNullException("m3_TE0P");
			if (string.IsNullOrWhiteSpace(m3_TE06))
				throw new ArgumentNullException("m3_TE06");
			if (string.IsNullOrWhiteSpace(m3_TFIN))
				throw new ArgumentNullException("m3_TFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("TE0P", m3_TE0P.Trim())
				.WithQueryParameter("TE06", m3_TE06.Trim())
				.WithQueryParameter("TFIN", m3_TFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());

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
		/// Name DelIntItmMst
		/// Description Delete interface item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmMst(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelIntItmMst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

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
		/// Name GetIntItmMst
		/// Description Get interface item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmMstResponse></returns>
		/// <exception cref="M3Exception<GetIntItmMstResponse>"></exception>
		public async Task<M3Response<GetIntItmMstResponse>> GetIntItmMst(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIntItmMst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Execute the request
			var result = await Execute<GetIntItmMstResponse>(
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
		/// Name LstIntItmMst
		/// Description List interface item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_IFIN">Interface item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmMstResponse></returns>
		/// <exception cref="M3Exception<LstIntItmMstResponse>"></exception>
		public async Task<M3Response<LstIntItmMstResponse>> LstIntItmMst(
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_IFIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntItmMst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIN))
				request.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Execute the request
			var result = await Execute<LstIntItmMstResponse>(
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
		/// Name LstIntItmViaItm
		/// Description List Interface item via item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmViaItmResponse></returns>
		/// <exception cref="M3Exception<LstIntItmViaItmResponse>"></exception>
		public async Task<M3Response<LstIntItmViaItmResponse>> LstIntItmViaItm(
			string m3_ITNO, 
			string m3_E0PA = null, 
			string m3_E065 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntItmViaItm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());

			// Execute the request
			var result = await Execute<LstIntItmViaItmResponse>(
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
		/// Name LstIntItmViaTme
		/// Description List interface item via time
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_IFIN">Interface item number</param>
		/// <param name="m3_STAI">Status</param>
		/// <param name="m3_STOT">Lowest status child table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmViaTmeResponse></returns>
		/// <exception cref="M3Exception<LstIntItmViaTmeResponse>"></exception>
		public async Task<M3Response<LstIntItmViaTmeResponse>> LstIntItmViaTme(
			decimal? m3_LMTS = null, 
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_IFIN = null, 
			string m3_STAI = null, 
			string m3_STOT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntItmViaTme",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIN))
				request.WithQueryParameter("IFIN", m3_IFIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAI))
				request.WithQueryParameter("STAI", m3_STAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STOT))
				request.WithQueryParameter("STOT", m3_STOT.Trim());

			// Execute the request
			var result = await Execute<LstIntItmViaTmeResponse>(
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
		/// Name SearchItemImp
		/// Description SearchItemImp
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchItemImpResponse></returns>
		/// <exception cref="M3Exception<SearchItemImpResponse>"></exception>
		public async Task<M3Response<SearchItemImpResponse>> SearchItemImp(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchItemImp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchItemImpResponse>(
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
		/// Name SndAddIntItmMst
		/// Description Send Add interface item master
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_BUAR">Business area</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_MABU">Make/buy code</param>
		/// <param name="m3_PRGP">Procurement group</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_INDI">Lot control method</param>
		/// <param name="m3_BACD">Lot numbering method</param>
		/// <param name="m3_ALUC">Alternate U/M in use</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_EXPD">Expiration date method</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_ACTI">Active or catch weight item</param>
		/// <param name="m3_EVGR">Environment group</param>
		/// <param name="m3_SALE">Sales item</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_CUCS">Currency - sales price</param>
		/// <param name="m3_WHTA">Warehouse table</param>
		/// <param name="m3_DIGI">Discount group - item</param>
		/// <param name="m3_SECH">Season control</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3_HIE1">Hierarchy level 1</param>
		/// <param name="m3_HIE2">Hierarchy level 2</param>
		/// <param name="m3_HIE3">Hierarchy level 3</param>
		/// <param name="m3_HIE4">Hierarchy level 4</param>
		/// <param name="m3_HIE5">Hierarchy level 5</param>
		/// <param name="m3_GRP1">Search group 1</param>
		/// <param name="m3_GRP2">Search group 2</param>
		/// <param name="m3_GRP3">Search group 3</param>
		/// <param name="m3_GRP4">Search group 4</param>
		/// <param name="m3_GRP5">Search group 5</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_SPE1">Specification 1</param>
		/// <param name="m3_SPE2">Specification 2</param>
		/// <param name="m3_SPE3">Specification 3</param>
		/// <param name="m3_SPE4">Specification 4</param>
		/// <param name="m3_SPE5">Specification 5</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_SAFC">Suppliers ABC code</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_ACMC">Compatibility code</param>
		/// <param name="m3_ATMN">Attribute managed</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="m3_ITRU">Included in territorial roll-up</param>
		/// <param name="m3_HVMT">Harvest Method</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_NESA">Next shop action type</param>
		/// <param name="m3_NSUF">Next service</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_TANK">Tank</param>
		/// <param name="m3_SPGV">Specific gravity</param>
		/// <param name="m3_RUID">Ruleset ID</param>
		/// <param name="m3_PDLN">Product line</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_SUME">Sublot method</param>
		/// <param name="m3_CAWP">Location-based catch weight</param>
		/// <param name="m3_SUMP">Sublot policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmMst(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_PMSN = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_DWNO = null, 
			string m3_STAT = null, 
			string m3_ITTY = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_BUAR = null, 
			int? m3_STCD = null, 
			string m3_UNMS = null, 
			string m3_RESP = null, 
			int? m3_MABU = null, 
			string m3_PRGP = null, 
			string m3_ACRF = null, 
			int? m3_INDI = null, 
			int? m3_BACD = null, 
			int? m3_ALUC = null, 
			int? m3_DCCD = null, 
			int? m3_EXPD = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_VOL3 = null, 
			int? m3_ACTI = null, 
			string m3_EVGR = null, 
			int? m3_SALE = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			string m3_CUCD = null, 
			string m3_SUNO = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			string m3_CUCS = null, 
			string m3_WHTA = null, 
			string m3_DIGI = null, 
			int? m3_SECH = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			int? m3_CHCD = null, 
			decimal? m3_TXID = null, 
			int? m3_SPUC = null, 
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
			string m3_ECVE = null, 
			string m3_SPE1 = null, 
			string m3_SPE2 = null, 
			string m3_SPE3 = null, 
			string m3_SPE4 = null, 
			string m3_SPE5 = null, 
			int? m3_RNRI = null, 
			string m3_SAFC = null, 
			int? m3_RMSG = null, 
			string m3_MOTP = null, 
			string m3_ACMC = null, 
			int? m3_ATMN = null, 
			string m3_ATMO = null, 
			int? m3_ITRU = null, 
			int? m3_HVMT = null, 
			string m3_ITAB = null, 
			string m3_NESA = null, 
			string m3_NSUF = null, 
			string m3_ORTY = null, 
			int? m3_TANK = null, 
			decimal? m3_SPGV = null, 
			string m3_RUID = null, 
			string m3_PDLN = null, 
			string m3_CPGR = null, 
			int? m3_SUME = null, 
			int? m3_CAWP = null, 
			string m3_SUMP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAddIntItmMst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUAR))
				request.WithQueryParameter("BUAR", m3_BUAR.Trim());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_MABU.HasValue)
				request.WithQueryParameter("MABU", m3_MABU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRGP))
				request.WithQueryParameter("PRGP", m3_PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_INDI.HasValue)
				request.WithQueryParameter("INDI", m3_INDI.Value.ToString());
			if (m3_BACD.HasValue)
				request.WithQueryParameter("BACD", m3_BACD.Value.ToString());
			if (m3_ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3_ALUC.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3_EXPD.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3_ACTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVGR))
				request.WithQueryParameter("EVGR", m3_EVGR.Trim());
			if (m3_SALE.HasValue)
				request.WithQueryParameter("SALE", m3_SALE.Value.ToString());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCS))
				request.WithQueryParameter("CUCS", m3_CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHTA))
				request.WithQueryParameter("WHTA", m3_WHTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIGI))
				request.WithQueryParameter("DIGI", m3_DIGI.Trim());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
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
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3_SPUC.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
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
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SAFC))
				request.WithQueryParameter("SAFC", m3_SAFC.Trim());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACMC))
				request.WithQueryParameter("ACMC", m3_ACMC.Trim());
			if (m3_ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3_ATMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());
			if (m3_ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3_ITRU.Value.ToString());
			if (m3_HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3_HVMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NESA))
				request.WithQueryParameter("NESA", m3_NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUF))
				request.WithQueryParameter("NSUF", m3_NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (m3_TANK.HasValue)
				request.WithQueryParameter("TANK", m3_TANK.Value.ToString());
			if (m3_SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3_SPGV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RUID))
				request.WithQueryParameter("RUID", m3_RUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PDLN))
				request.WithQueryParameter("PDLN", m3_PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (m3_SUME.HasValue)
				request.WithQueryParameter("SUME", m3_SUME.Value.ToString());
			if (m3_CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3_CAWP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUMP))
				request.WithQueryParameter("SUMP", m3_SUMP.Trim());

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
		/// Name SndChgIntItmMst
		/// Description SendChange interface item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_BUAR">Business area</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_MABU">Make/buy code</param>
		/// <param name="m3_PRGP">Procurement group</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_INDI">Lot control method</param>
		/// <param name="m3_BACD">Lot numbering method</param>
		/// <param name="m3_ALUC">Alternate U/M in use</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_EXPD">Expiration date method</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_ACTI">Active or catch weight item</param>
		/// <param name="m3_EVGR">Environment group</param>
		/// <param name="m3_SALE">Sales item</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_CUCS">Currency - sales price</param>
		/// <param name="m3_WHTA">Warehouse table</param>
		/// <param name="m3_DIGI">Discount group - item</param>
		/// <param name="m3_SECH">Season control</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3_HIE1">Hierarchy level 1</param>
		/// <param name="m3_HIE2">Hierarchy level 2</param>
		/// <param name="m3_HIE3">Hierarchy level 3</param>
		/// <param name="m3_HIE4">Hierarchy level 4</param>
		/// <param name="m3_HIE5">Hierarchy level 5</param>
		/// <param name="m3_GRP1">Search group 1</param>
		/// <param name="m3_GRP2">Search group 2</param>
		/// <param name="m3_GRP3">Search group 3</param>
		/// <param name="m3_GRP4">Search group 4</param>
		/// <param name="m3_GRP5">Search group 5</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_SPE1">Specification 1</param>
		/// <param name="m3_SPE2">Specification 2</param>
		/// <param name="m3_SPE3">Specification 3</param>
		/// <param name="m3_SPE4">Specification 4</param>
		/// <param name="m3_SPE5">Specification 5</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_SAFC">Suppliers ABC code</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_ATMN">Attribute managed</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="m3_ITRU">Included in territorial roll-up</param>
		/// <param name="m3_HVMT">Harvest Method</param>
		/// <param name="m3_NESA">Next shop action type</param>
		/// <param name="m3_NSUF">Next service</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_TANK">Tank</param>
		/// <param name="m3_SPGV">Specific gravity</param>
		/// <param name="m3_RUID">Ruleset ID</param>
		/// <param name="m3_PDLN">Product line</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_SUME">Sublot method</param>
		/// <param name="m3_CAWP">Location-based catch weight</param>
		/// <param name="m3_SUMP">Sublot policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmMst(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_PMSN = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_DWNO = null, 
			string m3_STAT = null, 
			string m3_ITTY = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_BUAR = null, 
			int? m3_STCD = null, 
			string m3_UNMS = null, 
			string m3_RESP = null, 
			int? m3_MABU = null, 
			string m3_PRGP = null, 
			string m3_ACRF = null, 
			int? m3_INDI = null, 
			int? m3_BACD = null, 
			int? m3_ALUC = null, 
			int? m3_DCCD = null, 
			int? m3_EXPD = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_VOL3 = null, 
			int? m3_ACTI = null, 
			string m3_EVGR = null, 
			int? m3_SALE = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			string m3_CUCD = null, 
			string m3_SUNO = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			string m3_CUCS = null, 
			string m3_WHTA = null, 
			string m3_DIGI = null, 
			int? m3_SECH = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			int? m3_CHCD = null, 
			decimal? m3_TXID = null, 
			int? m3_SPUC = null, 
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
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			string m3_ECVE = null, 
			string m3_SPE1 = null, 
			string m3_SPE2 = null, 
			string m3_SPE3 = null, 
			string m3_SPE4 = null, 
			string m3_SPE5 = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			int? m3_RNRI = null, 
			string m3_SAFC = null, 
			int? m3_RMSG = null, 
			string m3_ITAB = null, 
			int? m3_ATMN = null, 
			string m3_ATMO = null, 
			int? m3_ITRU = null, 
			int? m3_HVMT = null, 
			string m3_NESA = null, 
			string m3_NSUF = null, 
			string m3_ORTY = null, 
			int? m3_TANK = null, 
			decimal? m3_SPGV = null, 
			string m3_RUID = null, 
			string m3_PDLN = null, 
			string m3_CPGR = null, 
			int? m3_SUME = null, 
			int? m3_CAWP = null, 
			string m3_SUMP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndChgIntItmMst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUAR))
				request.WithQueryParameter("BUAR", m3_BUAR.Trim());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_MABU.HasValue)
				request.WithQueryParameter("MABU", m3_MABU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRGP))
				request.WithQueryParameter("PRGP", m3_PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_INDI.HasValue)
				request.WithQueryParameter("INDI", m3_INDI.Value.ToString());
			if (m3_BACD.HasValue)
				request.WithQueryParameter("BACD", m3_BACD.Value.ToString());
			if (m3_ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3_ALUC.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3_EXPD.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3_ACTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVGR))
				request.WithQueryParameter("EVGR", m3_EVGR.Trim());
			if (m3_SALE.HasValue)
				request.WithQueryParameter("SALE", m3_SALE.Value.ToString());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCS))
				request.WithQueryParameter("CUCS", m3_CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHTA))
				request.WithQueryParameter("WHTA", m3_WHTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIGI))
				request.WithQueryParameter("DIGI", m3_DIGI.Trim());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
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
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3_SPUC.Value.ToString());
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
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
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
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SAFC))
				request.WithQueryParameter("SAFC", m3_SAFC.Trim());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (m3_ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3_ATMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());
			if (m3_ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3_ITRU.Value.ToString());
			if (m3_HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3_HVMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NESA))
				request.WithQueryParameter("NESA", m3_NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUF))
				request.WithQueryParameter("NSUF", m3_NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (m3_TANK.HasValue)
				request.WithQueryParameter("TANK", m3_TANK.Value.ToString());
			if (m3_SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3_SPGV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RUID))
				request.WithQueryParameter("RUID", m3_RUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PDLN))
				request.WithQueryParameter("PDLN", m3_PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (m3_SUME.HasValue)
				request.WithQueryParameter("SUME", m3_SUME.Value.ToString());
			if (m3_CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3_CAWP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUMP))
				request.WithQueryParameter("SUMP", m3_SUMP.Trim());

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
