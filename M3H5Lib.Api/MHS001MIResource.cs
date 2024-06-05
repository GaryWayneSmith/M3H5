/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3BUAR">Business area</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3MABU">Make/buy code</param>
		/// <param name="m3PRGP">Procurement group</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3INDI">Lot control method</param>
		/// <param name="m3BACD">Lot numbering method</param>
		/// <param name="m3ALUC">Alternate U/M in use</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3EXPD">Expiration date method</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3ACTI">Active or catch weight item</param>
		/// <param name="m3EVGR">Environment group</param>
		/// <param name="m3SALE">Sales item</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3CUCS">Currency - sales price</param>
		/// <param name="m3WHTA">Warehouse table</param>
		/// <param name="m3DIGI">Discount group - item</param>
		/// <param name="m3SECH">Season control</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3HIE1">Hierarchy level 1</param>
		/// <param name="m3HIE2">Hierarchy level 2</param>
		/// <param name="m3HIE3">Hierarchy level 3</param>
		/// <param name="m3HIE4">Hierarchy level 4</param>
		/// <param name="m3HIE5">Hierarchy level 5</param>
		/// <param name="m3GRP1">Search group 1</param>
		/// <param name="m3GRP2">Search group 2</param>
		/// <param name="m3GRP3">Search group 3</param>
		/// <param name="m3GRP4">Search group 4</param>
		/// <param name="m3GRP5">Search group 5</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3SPE1">Specification 1</param>
		/// <param name="m3SPE2">Specification 2</param>
		/// <param name="m3SPE3">Specification 3</param>
		/// <param name="m3SPE4">Specification 4</param>
		/// <param name="m3SPE5">Specification 5</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3SAFC">Suppliers ABC code</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3ACMC">Compatibility code</param>
		/// <param name="m3ATMN">Attribute managed</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="m3ITRU">Included in territorial roll-up</param>
		/// <param name="m3HVMT">Harvest Method</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3NESA">Next shop action type</param>
		/// <param name="m3NSUF">Next service</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3TANK">Tank</param>
		/// <param name="m3SPGV">Specific gravity</param>
		/// <param name="m3ILEN">Length</param>
		/// <param name="m3IWID">Width</param>
		/// <param name="m3IHEI">Height</param>
		/// <param name="m3RUID">Ruleset ID</param>
		/// <param name="m3PDLN">Product line</param>
		/// <param name="m3ITNE">Extended item number</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3SUME">Sublot method</param>
		/// <param name="m3CAWP">Location-based catch weight</param>
		/// <param name="m3SUMP">Sublot policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddIntItmMstResponse></returns>
		/// <exception cref="M3Exception<AddIntItmMstResponse>"></exception>
		public async Task<M3Response<AddIntItmMstResponse>> AddIntItmMst(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3PMSN = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3DWNO = null, 
			string m3STAT = null, 
			string m3ITTY = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3BUAR = null, 
			int? m3STCD = null, 
			string m3UNMS = null, 
			string m3RESP = null, 
			int? m3MABU = null, 
			string m3PRGP = null, 
			string m3ACRF = null, 
			int? m3INDI = null, 
			int? m3BACD = null, 
			int? m3ALUC = null, 
			int? m3DCCD = null, 
			int? m3EXPD = null, 
			decimal? m3GRWE = null, 
			decimal? m3NEWE = null, 
			decimal? m3VOL3 = null, 
			int? m3ACTI = null, 
			string m3EVGR = null, 
			int? m3SALE = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			decimal? m3PUPR = null, 
			int? m3PUCD = null, 
			string m3CUCD = null, 
			string m3SUNO = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			string m3CUCS = null, 
			string m3WHTA = null, 
			string m3DIGI = null, 
			int? m3SECH = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? m3CHCD = null, 
			decimal? m3TXID = null, 
			int? m3SPUC = null, 
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
			string m3ECVE = null, 
			string m3SPE1 = null, 
			string m3SPE2 = null, 
			string m3SPE3 = null, 
			string m3SPE4 = null, 
			string m3SPE5 = null, 
			int? m3RNRI = null, 
			string m3SAFC = null, 
			int? m3RMSG = null, 
			string m3MOTP = null, 
			string m3ACMC = null, 
			int? m3ATMN = null, 
			string m3ATMO = null, 
			int? m3ITRU = null, 
			int? m3HVMT = null, 
			string m3ITAB = null, 
			string m3NESA = null, 
			string m3NSUF = null, 
			string m3ORTY = null, 
			int? m3TANK = null, 
			decimal? m3SPGV = null, 
			int? m3ILEN = null, 
			int? m3IWID = null, 
			int? m3IHEI = null, 
			string m3RUID = null, 
			string m3PDLN = null, 
			string m3ITNE = null, 
			string m3CPGR = null, 
			int? m3SUME = null, 
			int? m3CAWP = null, 
			string m3SUMP = null, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUAR))
				request.WithQueryParameter("BUAR", m3BUAR.Trim());
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3MABU.HasValue)
				request.WithQueryParameter("MABU", m3MABU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRGP))
				request.WithQueryParameter("PRGP", m3PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3INDI.HasValue)
				request.WithQueryParameter("INDI", m3INDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACD.HasValue)
				request.WithQueryParameter("BACD", m3BACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3ALUC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3EXPD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3ACTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVGR))
				request.WithQueryParameter("EVGR", m3EVGR.Trim());
			if (m3SALE.HasValue)
				request.WithQueryParameter("SALE", m3SALE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCS))
				request.WithQueryParameter("CUCS", m3CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHTA))
				request.WithQueryParameter("WHTA", m3WHTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIGI))
				request.WithQueryParameter("DIGI", m3DIGI.Trim());
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3SPUC.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
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
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SAFC))
				request.WithQueryParameter("SAFC", m3SAFC.Trim());
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACMC))
				request.WithQueryParameter("ACMC", m3ACMC.Trim());
			if (m3ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3ATMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());
			if (m3ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3ITRU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3HVMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (!string.IsNullOrWhiteSpace(m3NESA))
				request.WithQueryParameter("NESA", m3NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUF))
				request.WithQueryParameter("NSUF", m3NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (m3TANK.HasValue)
				request.WithQueryParameter("TANK", m3TANK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3SPGV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ILEN.HasValue)
				request.WithQueryParameter("ILEN", m3ILEN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IWID.HasValue)
				request.WithQueryParameter("IWID", m3IWID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IHEI.HasValue)
				request.WithQueryParameter("IHEI", m3IHEI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RUID))
				request.WithQueryParameter("RUID", m3RUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PDLN))
				request.WithQueryParameter("PDLN", m3PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNE))
				request.WithQueryParameter("ITNE", m3ITNE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (m3SUME.HasValue)
				request.WithQueryParameter("SUME", m3SUME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3CAWP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUMP))
				request.WithQueryParameter("SUMP", m3SUMP.Trim());

			// Execute the request
			var result = await Execute<AddIntItmMstResponse>(
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
		/// Name ChgIntItmMst
		/// Description Change interface item
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3BUAR">Business area</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3MABU">Make/buy code</param>
		/// <param name="m3PRGP">Procurement group</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3INDI">Lot control method</param>
		/// <param name="m3BACD">Lot numbering method</param>
		/// <param name="m3ALUC">Alternate U/M in use</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3EXPD">Expiration date method</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3ACTI">Active or catch weight item</param>
		/// <param name="m3EVGR">Environment group</param>
		/// <param name="m3SALE">Sales item</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3CUCS">Currency - sales price</param>
		/// <param name="m3WHTA">Warehouse table</param>
		/// <param name="m3DIGI">Discount group - item</param>
		/// <param name="m3SECH">Season control</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3HIE1">Hierarchy level 1</param>
		/// <param name="m3HIE2">Hierarchy level 2</param>
		/// <param name="m3HIE3">Hierarchy level 3</param>
		/// <param name="m3HIE4">Hierarchy level 4</param>
		/// <param name="m3HIE5">Hierarchy level 5</param>
		/// <param name="m3GRP1">Search group 1</param>
		/// <param name="m3GRP2">Search group 2</param>
		/// <param name="m3GRP3">Search group 3</param>
		/// <param name="m3GRP4">Search group 4</param>
		/// <param name="m3GRP5">Search group 5</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3SPE1">Specification 1</param>
		/// <param name="m3SPE2">Specification 2</param>
		/// <param name="m3SPE3">Specification 3</param>
		/// <param name="m3SPE4">Specification 4</param>
		/// <param name="m3SPE5">Specification 5</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ACFL">Add/change flag</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3SAFC">Suppliers ABC code</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3ATMN">Attribute managed</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="m3ITRU">Included in territorial roll-up</param>
		/// <param name="m3HVMT">Harvest Method</param>
		/// <param name="m3NESA">Next shop action type</param>
		/// <param name="m3NSUF">Next service</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3TANK">Tank</param>
		/// <param name="m3SPGV">Specific gravity</param>
		/// <param name="m3ILEN">Length</param>
		/// <param name="m3IWID">Width</param>
		/// <param name="m3IHEI">Height</param>
		/// <param name="m3RUID">Ruleset ID</param>
		/// <param name="m3PDLN">Product line</param>
		/// <param name="m3ITNE">Extended item number</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3SUME">Sublot method</param>
		/// <param name="m3CAWP">Location-based catch weight</param>
		/// <param name="m3SUMP">Sublot policy</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmMst(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3PMSN = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3DWNO = null, 
			string m3STAT = null, 
			string m3ITTY = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3BUAR = null, 
			int? m3STCD = null, 
			string m3UNMS = null, 
			string m3RESP = null, 
			int? m3MABU = null, 
			string m3PRGP = null, 
			string m3ACRF = null, 
			int? m3INDI = null, 
			int? m3BACD = null, 
			int? m3ALUC = null, 
			int? m3DCCD = null, 
			int? m3EXPD = null, 
			decimal? m3GRWE = null, 
			decimal? m3NEWE = null, 
			decimal? m3VOL3 = null, 
			int? m3ACTI = null, 
			string m3EVGR = null, 
			int? m3SALE = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			decimal? m3PUPR = null, 
			int? m3PUCD = null, 
			string m3CUCD = null, 
			string m3SUNO = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			string m3CUCS = null, 
			string m3WHTA = null, 
			string m3DIGI = null, 
			int? m3SECH = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? m3CHCD = null, 
			decimal? m3TXID = null, 
			int? m3SPUC = null, 
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
			DateTime? m3STDT = null, 
			int? m3STIM = null, 
			string m3ECVE = null, 
			string m3SPE1 = null, 
			string m3SPE2 = null, 
			string m3SPE3 = null, 
			string m3SPE4 = null, 
			string m3SPE5 = null, 
			int? m3ITFL = null, 
			int? m3ACFL = null, 
			int? m3RNRI = null, 
			string m3SAFC = null, 
			int? m3RMSG = null, 
			string m3ITAB = null, 
			int? m3ATMN = null, 
			string m3ATMO = null, 
			int? m3ITRU = null, 
			int? m3HVMT = null, 
			string m3NESA = null, 
			string m3NSUF = null, 
			string m3ORTY = null, 
			int? m3TANK = null, 
			decimal? m3SPGV = null, 
			int? m3ILEN = null, 
			int? m3IWID = null, 
			int? m3IHEI = null, 
			string m3RUID = null, 
			string m3PDLN = null, 
			string m3ITNE = null, 
			string m3CPGR = null, 
			int? m3SUME = null, 
			int? m3CAWP = null, 
			string m3SUMP = null, 
			string m3MOTP = null, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUAR))
				request.WithQueryParameter("BUAR", m3BUAR.Trim());
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3MABU.HasValue)
				request.WithQueryParameter("MABU", m3MABU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRGP))
				request.WithQueryParameter("PRGP", m3PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3INDI.HasValue)
				request.WithQueryParameter("INDI", m3INDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACD.HasValue)
				request.WithQueryParameter("BACD", m3BACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3ALUC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3EXPD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3ACTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVGR))
				request.WithQueryParameter("EVGR", m3EVGR.Trim());
			if (m3SALE.HasValue)
				request.WithQueryParameter("SALE", m3SALE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCS))
				request.WithQueryParameter("CUCS", m3CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHTA))
				request.WithQueryParameter("WHTA", m3WHTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIGI))
				request.WithQueryParameter("DIGI", m3DIGI.Trim());
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3SPUC.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
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
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3ACFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SAFC))
				request.WithQueryParameter("SAFC", m3SAFC.Trim());
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (m3ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3ATMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());
			if (m3ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3ITRU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3HVMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NESA))
				request.WithQueryParameter("NESA", m3NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUF))
				request.WithQueryParameter("NSUF", m3NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (m3TANK.HasValue)
				request.WithQueryParameter("TANK", m3TANK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3SPGV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ILEN.HasValue)
				request.WithQueryParameter("ILEN", m3ILEN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IWID.HasValue)
				request.WithQueryParameter("IWID", m3IWID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IHEI.HasValue)
				request.WithQueryParameter("IHEI", m3IHEI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RUID))
				request.WithQueryParameter("RUID", m3RUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PDLN))
				request.WithQueryParameter("PDLN", m3PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNE))
				request.WithQueryParameter("ITNE", m3ITNE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (m3SUME.HasValue)
				request.WithQueryParameter("SUME", m3SUME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3CAWP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUMP))
				request.WithQueryParameter("SUMP", m3SUMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());

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
		/// Name CpyIntItmMst
		/// Description Copy interface item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3TE0P">Partner (Required)</param>
		/// <param name="m3TE06">Message type (Required)</param>
		/// <param name="m3TFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmMst(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3TE0P, 
			string m3TE06, 
			string m3TFIN, 
			string m3PRMD = null, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3TE0P))
				throw new ArgumentNullException(nameof(m3TE0P));
			if (string.IsNullOrWhiteSpace(m3TE06))
				throw new ArgumentNullException(nameof(m3TE06));
			if (string.IsNullOrWhiteSpace(m3TFIN))
				throw new ArgumentNullException(nameof(m3TFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("TE0P", m3TE0P.Trim())
				.WithQueryParameter("TE06", m3TE06.Trim())
				.WithQueryParameter("TFIN", m3TFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());

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
		/// Name DelIntItmMst
		/// Description Delete interface item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmMst(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

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
		/// Name GetIntItmMst
		/// Description Get interface item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmMstResponse></returns>
		/// <exception cref="M3Exception<GetIntItmMstResponse>"></exception>
		public async Task<M3Response<GetIntItmMstResponse>> GetIntItmMst(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Execute the request
			var result = await Execute<GetIntItmMstResponse>(
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
		/// Name LstIntItmMst
		/// Description List interface item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3IFIN">Interface item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmMstResponse></returns>
		/// <exception cref="M3Exception<LstIntItmMstResponse>"></exception>
		public async Task<M3Response<LstIntItmMstResponse>> LstIntItmMst(
			string m3E0PA = null, 
			string m3E065 = null, 
			string m3IFIN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIN))
				request.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Execute the request
			var result = await Execute<LstIntItmMstResponse>(
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
		/// Name LstIntItmViaItm
		/// Description List Interface item via item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmViaItmResponse></returns>
		/// <exception cref="M3Exception<LstIntItmViaItmResponse>"></exception>
		public async Task<M3Response<LstIntItmViaItmResponse>> LstIntItmViaItm(
			string m3ITNO, 
			string m3E0PA = null, 
			string m3E065 = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());

			// Execute the request
			var result = await Execute<LstIntItmViaItmResponse>(
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
		/// Name LstIntItmViaTme
		/// Description List interface item via time
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3IFIN">Interface item number</param>
		/// <param name="m3STAI">Status</param>
		/// <param name="m3STOT">Lowest status child table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmViaTmeResponse></returns>
		/// <exception cref="M3Exception<LstIntItmViaTmeResponse>"></exception>
		public async Task<M3Response<LstIntItmViaTmeResponse>> LstIntItmViaTme(
			decimal? m3LMTS = null, 
			string m3E0PA = null, 
			string m3E065 = null, 
			string m3IFIN = null, 
			string m3STAI = null, 
			string m3STOT = null, 
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
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIN))
				request.WithQueryParameter("IFIN", m3IFIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAI))
				request.WithQueryParameter("STAI", m3STAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STOT))
				request.WithQueryParameter("STOT", m3STOT.Trim());

			// Execute the request
			var result = await Execute<LstIntItmViaTmeResponse>(
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
		/// Name SearchItemImp
		/// Description SearchItemImp
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchItemImpResponse></returns>
		/// <exception cref="M3Exception<SearchItemImpResponse>"></exception>
		public async Task<M3Response<SearchItemImpResponse>> SearchItemImp(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchItemImp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchItemImpResponse>(
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
		/// Name SndAddIntItmMst
		/// Description Send Add interface item master
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3BUAR">Business area</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3MABU">Make/buy code</param>
		/// <param name="m3PRGP">Procurement group</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3INDI">Lot control method</param>
		/// <param name="m3BACD">Lot numbering method</param>
		/// <param name="m3ALUC">Alternate U/M in use</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3EXPD">Expiration date method</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3ACTI">Active or catch weight item</param>
		/// <param name="m3EVGR">Environment group</param>
		/// <param name="m3SALE">Sales item</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3CUCS">Currency - sales price</param>
		/// <param name="m3WHTA">Warehouse table</param>
		/// <param name="m3DIGI">Discount group - item</param>
		/// <param name="m3SECH">Season control</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3HIE1">Hierarchy level 1</param>
		/// <param name="m3HIE2">Hierarchy level 2</param>
		/// <param name="m3HIE3">Hierarchy level 3</param>
		/// <param name="m3HIE4">Hierarchy level 4</param>
		/// <param name="m3HIE5">Hierarchy level 5</param>
		/// <param name="m3GRP1">Search group 1</param>
		/// <param name="m3GRP2">Search group 2</param>
		/// <param name="m3GRP3">Search group 3</param>
		/// <param name="m3GRP4">Search group 4</param>
		/// <param name="m3GRP5">Search group 5</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3SPE1">Specification 1</param>
		/// <param name="m3SPE2">Specification 2</param>
		/// <param name="m3SPE3">Specification 3</param>
		/// <param name="m3SPE4">Specification 4</param>
		/// <param name="m3SPE5">Specification 5</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3SAFC">Suppliers ABC code</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3ACMC">Compatibility code</param>
		/// <param name="m3ATMN">Attribute managed</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="m3ITRU">Included in territorial roll-up</param>
		/// <param name="m3HVMT">Harvest Method</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3NESA">Next shop action type</param>
		/// <param name="m3NSUF">Next service</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3TANK">Tank</param>
		/// <param name="m3SPGV">Specific gravity</param>
		/// <param name="m3RUID">Ruleset ID</param>
		/// <param name="m3PDLN">Product line</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3SUME">Sublot method</param>
		/// <param name="m3CAWP">Location-based catch weight</param>
		/// <param name="m3SUMP">Sublot policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmMst(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3PMSN = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3DWNO = null, 
			string m3STAT = null, 
			string m3ITTY = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3BUAR = null, 
			int? m3STCD = null, 
			string m3UNMS = null, 
			string m3RESP = null, 
			int? m3MABU = null, 
			string m3PRGP = null, 
			string m3ACRF = null, 
			int? m3INDI = null, 
			int? m3BACD = null, 
			int? m3ALUC = null, 
			int? m3DCCD = null, 
			int? m3EXPD = null, 
			decimal? m3GRWE = null, 
			decimal? m3NEWE = null, 
			decimal? m3VOL3 = null, 
			int? m3ACTI = null, 
			string m3EVGR = null, 
			int? m3SALE = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			decimal? m3PUPR = null, 
			int? m3PUCD = null, 
			string m3CUCD = null, 
			string m3SUNO = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			string m3CUCS = null, 
			string m3WHTA = null, 
			string m3DIGI = null, 
			int? m3SECH = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? m3CHCD = null, 
			decimal? m3TXID = null, 
			int? m3SPUC = null, 
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
			string m3ECVE = null, 
			string m3SPE1 = null, 
			string m3SPE2 = null, 
			string m3SPE3 = null, 
			string m3SPE4 = null, 
			string m3SPE5 = null, 
			int? m3RNRI = null, 
			string m3SAFC = null, 
			int? m3RMSG = null, 
			string m3MOTP = null, 
			string m3ACMC = null, 
			int? m3ATMN = null, 
			string m3ATMO = null, 
			int? m3ITRU = null, 
			int? m3HVMT = null, 
			string m3ITAB = null, 
			string m3NESA = null, 
			string m3NSUF = null, 
			string m3ORTY = null, 
			int? m3TANK = null, 
			decimal? m3SPGV = null, 
			string m3RUID = null, 
			string m3PDLN = null, 
			string m3CPGR = null, 
			int? m3SUME = null, 
			int? m3CAWP = null, 
			string m3SUMP = null, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUAR))
				request.WithQueryParameter("BUAR", m3BUAR.Trim());
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3MABU.HasValue)
				request.WithQueryParameter("MABU", m3MABU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRGP))
				request.WithQueryParameter("PRGP", m3PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3INDI.HasValue)
				request.WithQueryParameter("INDI", m3INDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACD.HasValue)
				request.WithQueryParameter("BACD", m3BACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3ALUC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3EXPD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3ACTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVGR))
				request.WithQueryParameter("EVGR", m3EVGR.Trim());
			if (m3SALE.HasValue)
				request.WithQueryParameter("SALE", m3SALE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCS))
				request.WithQueryParameter("CUCS", m3CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHTA))
				request.WithQueryParameter("WHTA", m3WHTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIGI))
				request.WithQueryParameter("DIGI", m3DIGI.Trim());
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3SPUC.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
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
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SAFC))
				request.WithQueryParameter("SAFC", m3SAFC.Trim());
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACMC))
				request.WithQueryParameter("ACMC", m3ACMC.Trim());
			if (m3ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3ATMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());
			if (m3ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3ITRU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3HVMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (!string.IsNullOrWhiteSpace(m3NESA))
				request.WithQueryParameter("NESA", m3NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUF))
				request.WithQueryParameter("NSUF", m3NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (m3TANK.HasValue)
				request.WithQueryParameter("TANK", m3TANK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3SPGV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RUID))
				request.WithQueryParameter("RUID", m3RUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PDLN))
				request.WithQueryParameter("PDLN", m3PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (m3SUME.HasValue)
				request.WithQueryParameter("SUME", m3SUME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3CAWP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUMP))
				request.WithQueryParameter("SUMP", m3SUMP.Trim());

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
		/// Name SndChgIntItmMst
		/// Description SendChange interface item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3BUAR">Business area</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3MABU">Make/buy code</param>
		/// <param name="m3PRGP">Procurement group</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3INDI">Lot control method</param>
		/// <param name="m3BACD">Lot numbering method</param>
		/// <param name="m3ALUC">Alternate U/M in use</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3EXPD">Expiration date method</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3ACTI">Active or catch weight item</param>
		/// <param name="m3EVGR">Environment group</param>
		/// <param name="m3SALE">Sales item</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3CUCS">Currency - sales price</param>
		/// <param name="m3WHTA">Warehouse table</param>
		/// <param name="m3DIGI">Discount group - item</param>
		/// <param name="m3SECH">Season control</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3HIE1">Hierarchy level 1</param>
		/// <param name="m3HIE2">Hierarchy level 2</param>
		/// <param name="m3HIE3">Hierarchy level 3</param>
		/// <param name="m3HIE4">Hierarchy level 4</param>
		/// <param name="m3HIE5">Hierarchy level 5</param>
		/// <param name="m3GRP1">Search group 1</param>
		/// <param name="m3GRP2">Search group 2</param>
		/// <param name="m3GRP3">Search group 3</param>
		/// <param name="m3GRP4">Search group 4</param>
		/// <param name="m3GRP5">Search group 5</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3SPE1">Specification 1</param>
		/// <param name="m3SPE2">Specification 2</param>
		/// <param name="m3SPE3">Specification 3</param>
		/// <param name="m3SPE4">Specification 4</param>
		/// <param name="m3SPE5">Specification 5</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ACFL">Add/change flag</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3SAFC">Suppliers ABC code</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3ATMN">Attribute managed</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="m3ITRU">Included in territorial roll-up</param>
		/// <param name="m3HVMT">Harvest Method</param>
		/// <param name="m3NESA">Next shop action type</param>
		/// <param name="m3NSUF">Next service</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3TANK">Tank</param>
		/// <param name="m3SPGV">Specific gravity</param>
		/// <param name="m3RUID">Ruleset ID</param>
		/// <param name="m3PDLN">Product line</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3SUME">Sublot method</param>
		/// <param name="m3CAWP">Location-based catch weight</param>
		/// <param name="m3SUMP">Sublot policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmMst(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3PMSN = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3DWNO = null, 
			string m3STAT = null, 
			string m3ITTY = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3BUAR = null, 
			int? m3STCD = null, 
			string m3UNMS = null, 
			string m3RESP = null, 
			int? m3MABU = null, 
			string m3PRGP = null, 
			string m3ACRF = null, 
			int? m3INDI = null, 
			int? m3BACD = null, 
			int? m3ALUC = null, 
			int? m3DCCD = null, 
			int? m3EXPD = null, 
			decimal? m3GRWE = null, 
			decimal? m3NEWE = null, 
			decimal? m3VOL3 = null, 
			int? m3ACTI = null, 
			string m3EVGR = null, 
			int? m3SALE = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			decimal? m3PUPR = null, 
			int? m3PUCD = null, 
			string m3CUCD = null, 
			string m3SUNO = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			string m3CUCS = null, 
			string m3WHTA = null, 
			string m3DIGI = null, 
			int? m3SECH = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? m3CHCD = null, 
			decimal? m3TXID = null, 
			int? m3SPUC = null, 
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
			DateTime? m3STDT = null, 
			int? m3STIM = null, 
			string m3ECVE = null, 
			string m3SPE1 = null, 
			string m3SPE2 = null, 
			string m3SPE3 = null, 
			string m3SPE4 = null, 
			string m3SPE5 = null, 
			int? m3ITFL = null, 
			int? m3ACFL = null, 
			int? m3RNRI = null, 
			string m3SAFC = null, 
			int? m3RMSG = null, 
			string m3ITAB = null, 
			int? m3ATMN = null, 
			string m3ATMO = null, 
			int? m3ITRU = null, 
			int? m3HVMT = null, 
			string m3NESA = null, 
			string m3NSUF = null, 
			string m3ORTY = null, 
			int? m3TANK = null, 
			decimal? m3SPGV = null, 
			string m3RUID = null, 
			string m3PDLN = null, 
			string m3CPGR = null, 
			int? m3SUME = null, 
			int? m3CAWP = null, 
			string m3SUMP = null, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUAR))
				request.WithQueryParameter("BUAR", m3BUAR.Trim());
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3MABU.HasValue)
				request.WithQueryParameter("MABU", m3MABU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRGP))
				request.WithQueryParameter("PRGP", m3PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3INDI.HasValue)
				request.WithQueryParameter("INDI", m3INDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACD.HasValue)
				request.WithQueryParameter("BACD", m3BACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALUC.HasValue)
				request.WithQueryParameter("ALUC", m3ALUC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPD.HasValue)
				request.WithQueryParameter("EXPD", m3EXPD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTI.HasValue)
				request.WithQueryParameter("ACTI", m3ACTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVGR))
				request.WithQueryParameter("EVGR", m3EVGR.Trim());
			if (m3SALE.HasValue)
				request.WithQueryParameter("SALE", m3SALE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCS))
				request.WithQueryParameter("CUCS", m3CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHTA))
				request.WithQueryParameter("WHTA", m3WHTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIGI))
				request.WithQueryParameter("DIGI", m3DIGI.Trim());
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3SPUC.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
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
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3ACFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SAFC))
				request.WithQueryParameter("SAFC", m3SAFC.Trim());
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (m3ATMN.HasValue)
				request.WithQueryParameter("ATMN", m3ATMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());
			if (m3ITRU.HasValue)
				request.WithQueryParameter("ITRU", m3ITRU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3HVMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NESA))
				request.WithQueryParameter("NESA", m3NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUF))
				request.WithQueryParameter("NSUF", m3NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (m3TANK.HasValue)
				request.WithQueryParameter("TANK", m3TANK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3SPGV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RUID))
				request.WithQueryParameter("RUID", m3RUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PDLN))
				request.WithQueryParameter("PDLN", m3PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (m3SUME.HasValue)
				request.WithQueryParameter("SUME", m3SUME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3CAWP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUMP))
				request.WithQueryParameter("SUMP", m3SUMP.Trim());

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
