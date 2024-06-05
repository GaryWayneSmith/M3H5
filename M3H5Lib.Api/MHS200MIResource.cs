/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS200MI;
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
	/// Name: MHS200MI
	/// Component Name: Interface Item
	/// Description: Api: Interface Item
	/// Version Release: 5ea0
	///</summary>
	public partial class MHS200MIResource : M3BaseResourceEndpoint
	{
		public MHS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItm
		/// Description Add Interface Item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_MSGD">Message</param>
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
		/// <param name="m3_DIGI">Discount group - item</param>
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
		/// <param name="m3_SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3_WHTA">Warehouse table</param>
		/// <param name="m3_SECH">Season control</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_BSTA">Status</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_BSUN">Supplier number</param>
		/// <param name="m3_SUWH">Supplying warehouse</param>
		/// <param name="m3_SSQT">Safety stock</param>
		/// <param name="m3_REOP">Reorder point</param>
		/// <param name="m3_EOQT">Order quantity</param>
		/// <param name="m3_MXST">Maximum stock</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_STMT">Storage method</param>
		/// <param name="m3_ALMT">Allocation method</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_SLDY">Shelf life</param>
		/// <param name="m3_REDY">Reinspection time</param>
		/// <param name="m3_SAEL">Sales time</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_CPCD">CTP policy</param>
		/// <param name="m3_MXSM">Maximum stock method</param>
		/// <param name="m3_ABCD">ABC class - volume</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_ACOC">ABC class - contribution</param>
		/// <param name="m3_MABC">ABC class - manual</param>
		/// <param name="m3_ABCM">ABC method  - volume</param>
		/// <param name="m3_ABFM">ABC method - frequency</param>
		/// <param name="m3_ACOM">ABC method - contribution</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_LEA4">Administrative lead time</param>
		/// <param name="m3_REWH">Main warehouse</param>
		/// <param name="m3_VAMT">Inventory accounting method</param>
		/// <param name="m3_FATM">On-hand balance method - facility</param>
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
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_ACMC">Compatibility code</param>
		/// <param name="m3_HVMT">Harvest Method</param>
		/// <param name="m3_BBTM">Best before time</param>
		/// <param name="m3_SPGV">Specific gravity</param>
		/// <param name="m3_PDLN">Product line</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_RUID">Ruleset ID</param>
		/// <param name="m3_PNYN">Classification per season</param>
		/// <param name="m3_CAWP">Location-based catch weight</param>
		/// <param name="m3_SUME">Sublot controlled</param>
		/// <param name="m3_SUMP">Sublot policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddIntItmResponse></returns>
		/// <exception cref="M3Exception<AddIntItmResponse>"></exception>
		public async Task<M3Response<AddIntItmResponse>> AddIntItm(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_PMSN = null, 
			string m3_MSID = null, 
			string m3_MSGD = null, 
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
			string m3_DIGI = null, 
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
			int? m3_SPUC = null, 
			string m3_WHTA = null, 
			int? m3_SECH = null, 
			string m3_WHLO = null, 
			int? m3_PUIT = null, 
			int? m3_OPLC = null, 
			int? m3_MSCH = null, 
			int? m3_DPID = null, 
			string m3_PLCD = null, 
			int? m3_LEA1 = null, 
			string m3_BSTA = null, 
			string m3_ORTY = null, 
			string m3_BSUN = null, 
			string m3_SUWH = null, 
			decimal? m3_SSQT = null, 
			decimal? m3_REOP = null, 
			decimal? m3_EOQT = null, 
			decimal? m3_MXST = null, 
			string m3_WHSL = null, 
			int? m3_STMT = null, 
			int? m3_ALMT = null, 
			int? m3_SPMT = null, 
			int? m3_SLDY = null, 
			int? m3_REDY = null, 
			int? m3_SAEL = null, 
			string m3_BUYE = null, 
			string m3_CPCD = null, 
			int? m3_MXSM = null, 
			string m3_ABCD = null, 
			string m3_ABFC = null, 
			string m3_ACOC = null, 
			string m3_MABC = null, 
			int? m3_ABCM = null, 
			int? m3_ABFM = null, 
			int? m3_ACOM = null, 
			string m3_FACI = null, 
			string m3_CSNO = null, 
			string m3_ORCO = null, 
			int? m3_LEA4 = null, 
			string m3_REWH = null, 
			int? m3_VAMT = null, 
			int? m3_FATM = null, 
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
			string m3_MOTP = null, 
			string m3_ACMC = null, 
			int? m3_HVMT = null, 
			int? m3_BBTM = null, 
			decimal? m3_SPGV = null, 
			string m3_PDLN = null, 
			string m3_CPGR = null, 
			string m3_RUID = null, 
			int? m3_PNYN = null, 
			int? m3_CAWP = null, 
			int? m3_SUME = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIntItm",
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
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGD))
				request.WithQueryParameter("MSGD", m3_MSGD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_DIGI))
				request.WithQueryParameter("DIGI", m3_DIGI.Trim());
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
			if (m3_SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3_SPUC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHTA))
				request.WithQueryParameter("WHTA", m3_WHTA.Trim());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3_PUIT.Value.ToString());
			if (m3_OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3_OPLC.Value.ToString());
			if (m3_MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3_MSCH.Value.ToString());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLCD))
				request.WithQueryParameter("PLCD", m3_PLCD.Trim());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BSTA))
				request.WithQueryParameter("BSTA", m3_BSTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BSUN))
				request.WithQueryParameter("BSUN", m3_BSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUWH))
				request.WithQueryParameter("SUWH", m3_SUWH.Trim());
			if (m3_SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3_SSQT.Value.ToString());
			if (m3_REOP.HasValue)
				request.WithQueryParameter("REOP", m3_REOP.Value.ToString());
			if (m3_EOQT.HasValue)
				request.WithQueryParameter("EOQT", m3_EOQT.Value.ToString());
			if (m3_MXST.HasValue)
				request.WithQueryParameter("MXST", m3_MXST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_STMT.HasValue)
				request.WithQueryParameter("STMT", m3_STMT.Value.ToString());
			if (m3_ALMT.HasValue)
				request.WithQueryParameter("ALMT", m3_ALMT.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (m3_SLDY.HasValue)
				request.WithQueryParameter("SLDY", m3_SLDY.Value.ToString());
			if (m3_REDY.HasValue)
				request.WithQueryParameter("REDY", m3_REDY.Value.ToString());
			if (m3_SAEL.HasValue)
				request.WithQueryParameter("SAEL", m3_SAEL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPCD))
				request.WithQueryParameter("CPCD", m3_CPCD.Trim());
			if (m3_MXSM.HasValue)
				request.WithQueryParameter("MXSM", m3_MXSM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABFC))
				request.WithQueryParameter("ABFC", m3_ABFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACOC))
				request.WithQueryParameter("ACOC", m3_ACOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MABC))
				request.WithQueryParameter("MABC", m3_MABC.Trim());
			if (m3_ABCM.HasValue)
				request.WithQueryParameter("ABCM", m3_ABCM.Value.ToString());
			if (m3_ABFM.HasValue)
				request.WithQueryParameter("ABFM", m3_ABFM.Value.ToString());
			if (m3_ACOM.HasValue)
				request.WithQueryParameter("ACOM", m3_ACOM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3_LEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REWH))
				request.WithQueryParameter("REWH", m3_REWH.Trim());
			if (m3_VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3_VAMT.Value.ToString());
			if (m3_FATM.HasValue)
				request.WithQueryParameter("FATM", m3_FATM.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACMC))
				request.WithQueryParameter("ACMC", m3_ACMC.Trim());
			if (m3_HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3_HVMT.Value.ToString());
			if (m3_BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3_BBTM.Value.ToString());
			if (m3_SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3_SPGV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PDLN))
				request.WithQueryParameter("PDLN", m3_PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RUID))
				request.WithQueryParameter("RUID", m3_RUID.Trim());
			if (m3_PNYN.HasValue)
				request.WithQueryParameter("PNYN", m3_PNYN.Value.ToString());
			if (m3_CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3_CAWP.Value.ToString());
			if (m3_SUME.HasValue)
				request.WithQueryParameter("SUME", m3_SUME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUMP))
				request.WithQueryParameter("SUMP", m3_SUMP.Trim());

			// Execute the request
			var result = await Execute<AddIntItmResponse>(
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
		/// Name AddIntSku
		/// Description Add Interface SKU
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_ISTY">Style number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_OPTZ">Option</param>
		/// <param name="m3_OPTX">Option</param>
		/// <param name="m3_OPTY">Option</param>
		/// <param name="m3_SECH">Season control</param>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="m3_NSTY">Interface style number</param>
		/// <param name="m3_PRNA">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddIntSkuResponse></returns>
		/// <exception cref="M3Exception<AddIntSkuResponse>"></exception>
		public async Task<M3Response<AddIntSkuResponse>> AddIntSku(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_ISTY = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_ITTY = null, 
			string m3_OPTZ = null, 
			string m3_OPTX = null, 
			string m3_OPTY = null, 
			int? m3_SECH = null, 
			string m3_SEA1 = null, 
			string m3_NSTY = null, 
			string m3_PRNA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIntSku",
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
			if (!string.IsNullOrWhiteSpace(m3_ISTY))
				request.WithQueryParameter("ISTY", m3_ISTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTZ))
				request.WithQueryParameter("OPTZ", m3_OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTX))
				request.WithQueryParameter("OPTX", m3_OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTY))
				request.WithQueryParameter("OPTY", m3_OPTY.Trim());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSTY))
				request.WithQueryParameter("NSTY", m3_NSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNA))
				request.WithQueryParameter("PRNA", m3_PRNA.Trim());

			// Execute the request
			var result = await Execute<AddIntSkuResponse>(
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
		/// Name ChgIntStyle
		/// Description Change Interface Style
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_FM01">User-defined field heading 1 - style</param>
		/// <param name="m3_FM02">User-defined field heading 2 - style</param>
		/// <param name="m3_FM03">User-defined field heading 3 - style</param>
		/// <param name="m3_FM04">User-defined field heading 4 - style</param>
		/// <param name="m3_FM05">User-defined field heading 5 - style</param>
		/// <param name="m3_FM06">User-defined field heading 6 - style</param>
		/// <param name="m3_FM07">User-defined field heading 7 - style</param>
		/// <param name="m3_FM08">User-defined field heading 8 - style</param>
		/// <param name="m3_FM09">User-defined field heading 9 - style</param>
		/// <param name="m3_FM10">User-defined field heading 10 - style</param>
		/// <param name="m3_FM11">User-defined field heading 11 - style</param>
		/// <param name="m3_FM12">User-defined field heading 12 - style</param>
		/// <param name="m3_FM13">User-defined field heading 13 - style</param>
		/// <param name="m3_FM14">User-defined field heading 14 - style</param>
		/// <param name="m3_FM15">User-defined field heading 15 - style</param>
		/// <param name="m3_FM16">User-defined field heading 16 - style</param>
		/// <param name="m3_FM17">User-defined field heading 17 - style</param>
		/// <param name="m3_FM18">User-defined field heading 18 - style</param>
		/// <param name="m3_FM19">User-defined field heading 19 - style</param>
		/// <param name="m3_FM20">User-defined field heading 20 - style</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntStyle(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_FM01 = null, 
			string m3_FM02 = null, 
			string m3_FM03 = null, 
			string m3_FM04 = null, 
			string m3_FM05 = null, 
			string m3_FM06 = null, 
			string m3_FM07 = null, 
			string m3_FM08 = null, 
			string m3_FM09 = null, 
			string m3_FM10 = null, 
			string m3_FM11 = null, 
			string m3_FM12 = null, 
			string m3_FM13 = null, 
			string m3_FM14 = null, 
			string m3_FM15 = null, 
			string m3_FM16 = null, 
			string m3_FM17 = null, 
			string m3_FM18 = null, 
			string m3_FM19 = null, 
			string m3_FM20 = null, 
			int? m3_ITFL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgIntStyle",
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
			if (!string.IsNullOrWhiteSpace(m3_FM01))
				request.WithQueryParameter("FM01", m3_FM01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM02))
				request.WithQueryParameter("FM02", m3_FM02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM03))
				request.WithQueryParameter("FM03", m3_FM03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM04))
				request.WithQueryParameter("FM04", m3_FM04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM05))
				request.WithQueryParameter("FM05", m3_FM05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM06))
				request.WithQueryParameter("FM06", m3_FM06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM07))
				request.WithQueryParameter("FM07", m3_FM07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM08))
				request.WithQueryParameter("FM08", m3_FM08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM09))
				request.WithQueryParameter("FM09", m3_FM09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM10))
				request.WithQueryParameter("FM10", m3_FM10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM11))
				request.WithQueryParameter("FM11", m3_FM11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM12))
				request.WithQueryParameter("FM12", m3_FM12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM13))
				request.WithQueryParameter("FM13", m3_FM13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM14))
				request.WithQueryParameter("FM14", m3_FM14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM15))
				request.WithQueryParameter("FM15", m3_FM15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM16))
				request.WithQueryParameter("FM16", m3_FM16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM17))
				request.WithQueryParameter("FM17", m3_FM17.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM18))
				request.WithQueryParameter("FM18", m3_FM18.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM19))
				request.WithQueryParameter("FM19", m3_FM19.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM20))
				request.WithQueryParameter("FM20", m3_FM20.Trim());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());

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
		/// Name GetIntStyle
		/// Description Get interface item style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_IFIN">Interface item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntStyleResponse></returns>
		/// <exception cref="M3Exception<GetIntStyleResponse>"></exception>
		public async Task<M3Response<GetIntStyleResponse>> GetIntStyle(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIntStyle",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIN))
				request.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Execute the request
			var result = await Execute<GetIntStyleResponse>(
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
		/// Name ImpIntItm
		/// Description Import Interface Item
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
		/// <returns>M3Response<ImpIntItmResponse></returns>
		/// <exception cref="M3Exception<ImpIntItmResponse>"></exception>
		public async Task<M3Response<ImpIntItmResponse>> ImpIntItm(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ImpIntItm",
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
			var result = await Execute<ImpIntItmResponse>(
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
		/// Name ImpIntItmWhs
		/// Description Import Interface Item on specific warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ImpIntItmWhsResponse></returns>
		/// <exception cref="M3Exception<ImpIntItmWhsResponse>"></exception>
		public async Task<M3Response<ImpIntItmWhsResponse>> ImpIntItmWhs(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ImpIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<ImpIntItmWhsResponse>(
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
		/// Name LstIntStyle
		/// Description List Interface item style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_IFIN">Interface item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntStyleResponse></returns>
		/// <exception cref="M3Exception<LstIntStyleResponse>"></exception>
		public async Task<M3Response<LstIntStyleResponse>> LstIntStyle(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntStyle",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIN))
				request.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Execute the request
			var result = await Execute<LstIntStyleResponse>(
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
		/// Name SndAddIntItm
		/// Description Send Add Interface Item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_MSGD">Message</param>
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
		/// <param name="m3_DIGI">Discount group - item</param>
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
		/// <param name="m3_SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3_WHTA">Warehouse table</param>
		/// <param name="m3_SECH">Season control</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_BSTA">Status</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_BSUN">Supplier number</param>
		/// <param name="m3_SUWH">Supplying warehouse</param>
		/// <param name="m3_SSQT">Safety stock</param>
		/// <param name="m3_REOP">Reorder point</param>
		/// <param name="m3_EOQT">Order quantity</param>
		/// <param name="m3_MXST">Maximum stock</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_STMT">Storage method</param>
		/// <param name="m3_ALMT">Allocation method</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_SLDY">Shelf life</param>
		/// <param name="m3_REDY">Reinspection time</param>
		/// <param name="m3_SAEL">Sales time</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_CPCD">CTP policy</param>
		/// <param name="m3_MXSM">Maximum stock method</param>
		/// <param name="m3_ABCD">ABC class - volume</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_ACOC">ABC class - contribution</param>
		/// <param name="m3_MABC">ABC class - manual</param>
		/// <param name="m3_ABCM">ABC method  - volume</param>
		/// <param name="m3_ABFM">ABC method - frequency</param>
		/// <param name="m3_ACOM">ABC method - contribution</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_LEA4">Administrative lead time</param>
		/// <param name="m3_REWH">Main warehouse</param>
		/// <param name="m3_VAMT">Inventory accounting method</param>
		/// <param name="m3_FATM">On-hand balance method - facility</param>
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
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_ACMC">Compatibility code</param>
		/// <param name="m3_HVMT">Harvest Method</param>
		/// <param name="m3_BBTM">Best before time</param>
		/// <param name="m3_SPGV">Specific gravity</param>
		/// <param name="m3_PDLN">Product line</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_RUID">Ruleset ID</param>
		/// <param name="m3_PNYN">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItm(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_PMSN = null, 
			string m3_MSID = null, 
			string m3_MSGD = null, 
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
			string m3_DIGI = null, 
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
			int? m3_SPUC = null, 
			string m3_WHTA = null, 
			int? m3_SECH = null, 
			string m3_WHLO = null, 
			int? m3_PUIT = null, 
			int? m3_OPLC = null, 
			int? m3_MSCH = null, 
			int? m3_DPID = null, 
			string m3_PLCD = null, 
			int? m3_LEA1 = null, 
			string m3_BSTA = null, 
			string m3_ORTY = null, 
			string m3_BSUN = null, 
			string m3_SUWH = null, 
			decimal? m3_SSQT = null, 
			decimal? m3_REOP = null, 
			decimal? m3_EOQT = null, 
			decimal? m3_MXST = null, 
			string m3_WHSL = null, 
			int? m3_STMT = null, 
			int? m3_ALMT = null, 
			int? m3_SPMT = null, 
			int? m3_SLDY = null, 
			int? m3_REDY = null, 
			int? m3_SAEL = null, 
			string m3_BUYE = null, 
			string m3_CPCD = null, 
			int? m3_MXSM = null, 
			string m3_ABCD = null, 
			string m3_ABFC = null, 
			string m3_ACOC = null, 
			string m3_MABC = null, 
			int? m3_ABCM = null, 
			int? m3_ABFM = null, 
			int? m3_ACOM = null, 
			string m3_FACI = null, 
			string m3_CSNO = null, 
			string m3_ORCO = null, 
			int? m3_LEA4 = null, 
			string m3_REWH = null, 
			int? m3_VAMT = null, 
			int? m3_FATM = null, 
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
			string m3_MOTP = null, 
			string m3_ACMC = null, 
			int? m3_HVMT = null, 
			int? m3_BBTM = null, 
			decimal? m3_SPGV = null, 
			string m3_PDLN = null, 
			string m3_CPGR = null, 
			string m3_RUID = null, 
			int? m3_PNYN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAddIntItm",
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
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGD))
				request.WithQueryParameter("MSGD", m3_MSGD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_DIGI))
				request.WithQueryParameter("DIGI", m3_DIGI.Trim());
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
			if (m3_SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3_SPUC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHTA))
				request.WithQueryParameter("WHTA", m3_WHTA.Trim());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3_PUIT.Value.ToString());
			if (m3_OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3_OPLC.Value.ToString());
			if (m3_MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3_MSCH.Value.ToString());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLCD))
				request.WithQueryParameter("PLCD", m3_PLCD.Trim());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BSTA))
				request.WithQueryParameter("BSTA", m3_BSTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BSUN))
				request.WithQueryParameter("BSUN", m3_BSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUWH))
				request.WithQueryParameter("SUWH", m3_SUWH.Trim());
			if (m3_SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3_SSQT.Value.ToString());
			if (m3_REOP.HasValue)
				request.WithQueryParameter("REOP", m3_REOP.Value.ToString());
			if (m3_EOQT.HasValue)
				request.WithQueryParameter("EOQT", m3_EOQT.Value.ToString());
			if (m3_MXST.HasValue)
				request.WithQueryParameter("MXST", m3_MXST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_STMT.HasValue)
				request.WithQueryParameter("STMT", m3_STMT.Value.ToString());
			if (m3_ALMT.HasValue)
				request.WithQueryParameter("ALMT", m3_ALMT.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (m3_SLDY.HasValue)
				request.WithQueryParameter("SLDY", m3_SLDY.Value.ToString());
			if (m3_REDY.HasValue)
				request.WithQueryParameter("REDY", m3_REDY.Value.ToString());
			if (m3_SAEL.HasValue)
				request.WithQueryParameter("SAEL", m3_SAEL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPCD))
				request.WithQueryParameter("CPCD", m3_CPCD.Trim());
			if (m3_MXSM.HasValue)
				request.WithQueryParameter("MXSM", m3_MXSM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABFC))
				request.WithQueryParameter("ABFC", m3_ABFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACOC))
				request.WithQueryParameter("ACOC", m3_ACOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MABC))
				request.WithQueryParameter("MABC", m3_MABC.Trim());
			if (m3_ABCM.HasValue)
				request.WithQueryParameter("ABCM", m3_ABCM.Value.ToString());
			if (m3_ABFM.HasValue)
				request.WithQueryParameter("ABFM", m3_ABFM.Value.ToString());
			if (m3_ACOM.HasValue)
				request.WithQueryParameter("ACOM", m3_ACOM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3_LEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REWH))
				request.WithQueryParameter("REWH", m3_REWH.Trim());
			if (m3_VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3_VAMT.Value.ToString());
			if (m3_FATM.HasValue)
				request.WithQueryParameter("FATM", m3_FATM.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACMC))
				request.WithQueryParameter("ACMC", m3_ACMC.Trim());
			if (m3_HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3_HVMT.Value.ToString());
			if (m3_BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3_BBTM.Value.ToString());
			if (m3_SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3_SPGV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PDLN))
				request.WithQueryParameter("PDLN", m3_PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RUID))
				request.WithQueryParameter("RUID", m3_RUID.Trim());
			if (m3_PNYN.HasValue)
				request.WithQueryParameter("PNYN", m3_PNYN.Value.ToString());

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
		/// Name SndAddIntSku
		/// Description Send Add Interface Sku
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_ISTY">Style number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_OPTZ">Option</param>
		/// <param name="m3_OPTX">Option</param>
		/// <param name="m3_OPTY">Option</param>
		/// <param name="m3_SECH">Season control</param>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="m3_PRNA">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntSku(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_ISTY = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_ITTY = null, 
			string m3_OPTZ = null, 
			string m3_OPTX = null, 
			string m3_OPTY = null, 
			int? m3_SECH = null, 
			string m3_SEA1 = null, 
			string m3_PRNA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAddIntSku",
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
			if (!string.IsNullOrWhiteSpace(m3_ISTY))
				request.WithQueryParameter("ISTY", m3_ISTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTZ))
				request.WithQueryParameter("OPTZ", m3_OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTX))
				request.WithQueryParameter("OPTX", m3_OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTY))
				request.WithQueryParameter("OPTY", m3_OPTY.Trim());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNA))
				request.WithQueryParameter("PRNA", m3_PRNA.Trim());

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
		/// Name SndChgIntStyle
		/// Description Send Change interface style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_FM01">User-defined field heading 1 - style</param>
		/// <param name="m3_FM02">User-defined field heading 2 - style</param>
		/// <param name="m3_FM03">User-defined field heading 3 - style</param>
		/// <param name="m3_FM04">User-defined field heading 4 - style</param>
		/// <param name="m3_FM05">User-defined field heading 5 - style</param>
		/// <param name="m3_FM06">User-defined field heading 6 - style</param>
		/// <param name="m3_FM07">User-defined field heading 7 - style</param>
		/// <param name="m3_FM08">User-defined field heading 8 - style</param>
		/// <param name="m3_FM09">User-defined field heading 9 - style</param>
		/// <param name="m3_FM10">User-defined field heading 10 - style</param>
		/// <param name="m3_FM11">User-defined field heading 11 - style</param>
		/// <param name="m3_FM12">User-defined field heading 12 - style</param>
		/// <param name="m3_FM13">User-defined field heading 13 - style</param>
		/// <param name="m3_FM14">User-defined field heading 14 - style</param>
		/// <param name="m3_FM15">User-defined field heading 15 - style</param>
		/// <param name="m3_FM16">User-defined field heading 16 - style</param>
		/// <param name="m3_FM17">User-defined field heading 17 - style</param>
		/// <param name="m3_FM18">User-defined field heading 18 - style</param>
		/// <param name="m3_FM19">User-defined field heading 19 - style</param>
		/// <param name="m3_FM20">User-defined field heading 20 - style</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntStyle(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_FM01 = null, 
			string m3_FM02 = null, 
			string m3_FM03 = null, 
			string m3_FM04 = null, 
			string m3_FM05 = null, 
			string m3_FM06 = null, 
			string m3_FM07 = null, 
			string m3_FM08 = null, 
			string m3_FM09 = null, 
			string m3_FM10 = null, 
			string m3_FM11 = null, 
			string m3_FM12 = null, 
			string m3_FM13 = null, 
			string m3_FM14 = null, 
			string m3_FM15 = null, 
			string m3_FM16 = null, 
			string m3_FM17 = null, 
			string m3_FM18 = null, 
			string m3_FM19 = null, 
			string m3_FM20 = null, 
			int? m3_ITFL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndChgIntStyle",
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
			if (!string.IsNullOrWhiteSpace(m3_FM01))
				request.WithQueryParameter("FM01", m3_FM01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM02))
				request.WithQueryParameter("FM02", m3_FM02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM03))
				request.WithQueryParameter("FM03", m3_FM03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM04))
				request.WithQueryParameter("FM04", m3_FM04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM05))
				request.WithQueryParameter("FM05", m3_FM05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM06))
				request.WithQueryParameter("FM06", m3_FM06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM07))
				request.WithQueryParameter("FM07", m3_FM07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM08))
				request.WithQueryParameter("FM08", m3_FM08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM09))
				request.WithQueryParameter("FM09", m3_FM09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM10))
				request.WithQueryParameter("FM10", m3_FM10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM11))
				request.WithQueryParameter("FM11", m3_FM11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM12))
				request.WithQueryParameter("FM12", m3_FM12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM13))
				request.WithQueryParameter("FM13", m3_FM13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM14))
				request.WithQueryParameter("FM14", m3_FM14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM15))
				request.WithQueryParameter("FM15", m3_FM15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM16))
				request.WithQueryParameter("FM16", m3_FM16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM17))
				request.WithQueryParameter("FM17", m3_FM17.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM18))
				request.WithQueryParameter("FM18", m3_FM18.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM19))
				request.WithQueryParameter("FM19", m3_FM19.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM20))
				request.WithQueryParameter("FM20", m3_FM20.Trim());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());

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
		/// Name SndImpIntItm
		/// Description Send Import Interface Item
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
		public async Task<M3Response<M3Record>> SndImpIntItm(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndImpIntItm",
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
		/// Name SndValIntItm
		/// Description Send Validate Interface Item
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
		public async Task<M3Response<M3Record>> SndValIntItm(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndValIntItm",
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
		/// Name ValIntItm
		/// Description Validate Interface item
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
		/// <returns>M3Response<ValIntItmResponse></returns>
		/// <exception cref="M3Exception<ValIntItmResponse>"></exception>
		public async Task<M3Response<ValIntItmResponse>> ValIntItm(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ValIntItm",
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
			var result = await Execute<ValIntItmResponse>(
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
