/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItm
		/// Description Add Interface Item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3MSGD">Message</param>
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
		/// <param name="m3DIGI">Discount group - item</param>
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
		/// <param name="m3SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3WHTA">Warehouse table</param>
		/// <param name="m3SECH">Season control</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3BSTA">Status</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3BSUN">Supplier number</param>
		/// <param name="m3SUWH">Supplying warehouse</param>
		/// <param name="m3SSQT">Safety stock</param>
		/// <param name="m3REOP">Reorder point</param>
		/// <param name="m3EOQT">Order quantity</param>
		/// <param name="m3MXST">Maximum stock</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3STMT">Storage method</param>
		/// <param name="m3ALMT">Allocation method</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3SLDY">Shelf life</param>
		/// <param name="m3REDY">Reinspection time</param>
		/// <param name="m3SAEL">Sales time</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3CPCD">CTP policy</param>
		/// <param name="m3MXSM">Maximum stock method</param>
		/// <param name="m3ABCD">ABC class - volume</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3ACOC">ABC class - contribution</param>
		/// <param name="m3MABC">ABC class - manual</param>
		/// <param name="m3ABCM">ABC method  - volume</param>
		/// <param name="m3ABFM">ABC method - frequency</param>
		/// <param name="m3ACOM">ABC method - contribution</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3LEA4">Administrative lead time</param>
		/// <param name="m3REWH">Main warehouse</param>
		/// <param name="m3VAMT">Inventory accounting method</param>
		/// <param name="m3FATM">On-hand balance method - facility</param>
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
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3ACMC">Compatibility code</param>
		/// <param name="m3HVMT">Harvest Method</param>
		/// <param name="m3BBTM">Best before time</param>
		/// <param name="m3SPGV">Specific gravity</param>
		/// <param name="m3PDLN">Product line</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3RUID">Ruleset ID</param>
		/// <param name="m3PNYN">Classification per season</param>
		/// <param name="m3CAWP">Location-based catch weight</param>
		/// <param name="m3SUME">Sublot controlled</param>
		/// <param name="m3SUMP">Sublot policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddIntItmResponse></returns>
		/// <exception cref="M3Exception<AddIntItmResponse>"></exception>
		public async Task<M3Response<AddIntItmResponse>> AddIntItm(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3PMSN = null, 
			string m3MSID = null, 
			string m3MSGD = null, 
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
			string m3DIGI = null, 
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
			int? m3SPUC = null, 
			string m3WHTA = null, 
			int? m3SECH = null, 
			string m3WHLO = null, 
			int? m3PUIT = null, 
			int? m3OPLC = null, 
			int? m3MSCH = null, 
			int? m3DPID = null, 
			string m3PLCD = null, 
			int? m3LEA1 = null, 
			string m3BSTA = null, 
			string m3ORTY = null, 
			string m3BSUN = null, 
			string m3SUWH = null, 
			decimal? m3SSQT = null, 
			decimal? m3REOP = null, 
			decimal? m3EOQT = null, 
			decimal? m3MXST = null, 
			string m3WHSL = null, 
			int? m3STMT = null, 
			int? m3ALMT = null, 
			int? m3SPMT = null, 
			int? m3SLDY = null, 
			int? m3REDY = null, 
			int? m3SAEL = null, 
			string m3BUYE = null, 
			string m3CPCD = null, 
			int? m3MXSM = null, 
			string m3ABCD = null, 
			string m3ABFC = null, 
			string m3ACOC = null, 
			string m3MABC = null, 
			int? m3ABCM = null, 
			int? m3ABFM = null, 
			int? m3ACOM = null, 
			string m3FACI = null, 
			string m3CSNO = null, 
			string m3ORCO = null, 
			int? m3LEA4 = null, 
			string m3REWH = null, 
			int? m3VAMT = null, 
			int? m3FATM = null, 
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
			string m3MOTP = null, 
			string m3ACMC = null, 
			int? m3HVMT = null, 
			int? m3BBTM = null, 
			decimal? m3SPGV = null, 
			string m3PDLN = null, 
			string m3CPGR = null, 
			string m3RUID = null, 
			int? m3PNYN = null, 
			int? m3CAWP = null, 
			int? m3SUME = null, 
			string m3SUMP = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddIntItm",
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
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGD))
				request.WithQueryParameter("MSGD", m3MSGD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3DIGI))
				request.WithQueryParameter("DIGI", m3DIGI.Trim());
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
			if (m3SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3SPUC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHTA))
				request.WithQueryParameter("WHTA", m3WHTA.Trim());
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3PUIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3OPLC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3MSCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLCD))
				request.WithQueryParameter("PLCD", m3PLCD.Trim());
			if (m3LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3LEA1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BSTA))
				request.WithQueryParameter("BSTA", m3BSTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3BSUN))
				request.WithQueryParameter("BSUN", m3BSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUWH))
				request.WithQueryParameter("SUWH", m3SUWH.Trim());
			if (m3SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3SSQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REOP.HasValue)
				request.WithQueryParameter("REOP", m3REOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQT.HasValue)
				request.WithQueryParameter("EOQT", m3EOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXST.HasValue)
				request.WithQueryParameter("MXST", m3MXST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3STMT.HasValue)
				request.WithQueryParameter("STMT", m3STMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALMT.HasValue)
				request.WithQueryParameter("ALMT", m3ALMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SLDY.HasValue)
				request.WithQueryParameter("SLDY", m3SLDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REDY.HasValue)
				request.WithQueryParameter("REDY", m3REDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAEL.HasValue)
				request.WithQueryParameter("SAEL", m3SAEL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPCD))
				request.WithQueryParameter("CPCD", m3CPCD.Trim());
			if (m3MXSM.HasValue)
				request.WithQueryParameter("MXSM", m3MXSM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABFC))
				request.WithQueryParameter("ABFC", m3ABFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACOC))
				request.WithQueryParameter("ACOC", m3ACOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MABC))
				request.WithQueryParameter("MABC", m3MABC.Trim());
			if (m3ABCM.HasValue)
				request.WithQueryParameter("ABCM", m3ABCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABFM.HasValue)
				request.WithQueryParameter("ABFM", m3ABFM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACOM.HasValue)
				request.WithQueryParameter("ACOM", m3ACOM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3LEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REWH))
				request.WithQueryParameter("REWH", m3REWH.Trim());
			if (m3VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3VAMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FATM.HasValue)
				request.WithQueryParameter("FATM", m3FATM.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACMC))
				request.WithQueryParameter("ACMC", m3ACMC.Trim());
			if (m3HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3HVMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3BBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3SPGV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PDLN))
				request.WithQueryParameter("PDLN", m3PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RUID))
				request.WithQueryParameter("RUID", m3RUID.Trim());
			if (m3PNYN.HasValue)
				request.WithQueryParameter("PNYN", m3PNYN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWP.HasValue)
				request.WithQueryParameter("CAWP", m3CAWP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUME.HasValue)
				request.WithQueryParameter("SUME", m3SUME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUMP))
				request.WithQueryParameter("SUMP", m3SUMP.Trim());

			// Execute the request
			var result = await Execute<AddIntItmResponse>(
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
		/// Name AddIntSku
		/// Description Add Interface SKU
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3ISTY">Style number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3OPTZ">Option</param>
		/// <param name="m3OPTX">Option</param>
		/// <param name="m3OPTY">Option</param>
		/// <param name="m3SECH">Season control</param>
		/// <param name="m3SEA1">Season</param>
		/// <param name="m3NSTY">Interface style number</param>
		/// <param name="m3PRNA">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddIntSkuResponse></returns>
		/// <exception cref="M3Exception<AddIntSkuResponse>"></exception>
		public async Task<M3Response<AddIntSkuResponse>> AddIntSku(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3ISTY = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3ITTY = null, 
			string m3OPTZ = null, 
			string m3OPTX = null, 
			string m3OPTY = null, 
			int? m3SECH = null, 
			string m3SEA1 = null, 
			string m3NSTY = null, 
			string m3PRNA = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddIntSku",
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
			if (!string.IsNullOrWhiteSpace(m3ISTY))
				request.WithQueryParameter("ISTY", m3ISTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTZ))
				request.WithQueryParameter("OPTZ", m3OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTX))
				request.WithQueryParameter("OPTX", m3OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTY))
				request.WithQueryParameter("OPTY", m3OPTY.Trim());
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SEA1))
				request.WithQueryParameter("SEA1", m3SEA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSTY))
				request.WithQueryParameter("NSTY", m3NSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNA))
				request.WithQueryParameter("PRNA", m3PRNA.Trim());

			// Execute the request
			var result = await Execute<AddIntSkuResponse>(
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
		/// Name ChgIntStyle
		/// Description Change Interface Style
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3FM01">User-defined field heading 1 - style</param>
		/// <param name="m3FM02">User-defined field heading 2 - style</param>
		/// <param name="m3FM03">User-defined field heading 3 - style</param>
		/// <param name="m3FM04">User-defined field heading 4 - style</param>
		/// <param name="m3FM05">User-defined field heading 5 - style</param>
		/// <param name="m3FM06">User-defined field heading 6 - style</param>
		/// <param name="m3FM07">User-defined field heading 7 - style</param>
		/// <param name="m3FM08">User-defined field heading 8 - style</param>
		/// <param name="m3FM09">User-defined field heading 9 - style</param>
		/// <param name="m3FM10">User-defined field heading 10 - style</param>
		/// <param name="m3FM11">User-defined field heading 11 - style</param>
		/// <param name="m3FM12">User-defined field heading 12 - style</param>
		/// <param name="m3FM13">User-defined field heading 13 - style</param>
		/// <param name="m3FM14">User-defined field heading 14 - style</param>
		/// <param name="m3FM15">User-defined field heading 15 - style</param>
		/// <param name="m3FM16">User-defined field heading 16 - style</param>
		/// <param name="m3FM17">User-defined field heading 17 - style</param>
		/// <param name="m3FM18">User-defined field heading 18 - style</param>
		/// <param name="m3FM19">User-defined field heading 19 - style</param>
		/// <param name="m3FM20">User-defined field heading 20 - style</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntStyle(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3FM01 = null, 
			string m3FM02 = null, 
			string m3FM03 = null, 
			string m3FM04 = null, 
			string m3FM05 = null, 
			string m3FM06 = null, 
			string m3FM07 = null, 
			string m3FM08 = null, 
			string m3FM09 = null, 
			string m3FM10 = null, 
			string m3FM11 = null, 
			string m3FM12 = null, 
			string m3FM13 = null, 
			string m3FM14 = null, 
			string m3FM15 = null, 
			string m3FM16 = null, 
			string m3FM17 = null, 
			string m3FM18 = null, 
			string m3FM19 = null, 
			string m3FM20 = null, 
			int? m3ITFL = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgIntStyle",
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
			if (!string.IsNullOrWhiteSpace(m3FM01))
				request.WithQueryParameter("FM01", m3FM01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM02))
				request.WithQueryParameter("FM02", m3FM02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM03))
				request.WithQueryParameter("FM03", m3FM03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM04))
				request.WithQueryParameter("FM04", m3FM04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM05))
				request.WithQueryParameter("FM05", m3FM05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM06))
				request.WithQueryParameter("FM06", m3FM06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM07))
				request.WithQueryParameter("FM07", m3FM07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM08))
				request.WithQueryParameter("FM08", m3FM08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM09))
				request.WithQueryParameter("FM09", m3FM09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM10))
				request.WithQueryParameter("FM10", m3FM10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM11))
				request.WithQueryParameter("FM11", m3FM11.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM12))
				request.WithQueryParameter("FM12", m3FM12.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM13))
				request.WithQueryParameter("FM13", m3FM13.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM14))
				request.WithQueryParameter("FM14", m3FM14.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM15))
				request.WithQueryParameter("FM15", m3FM15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM16))
				request.WithQueryParameter("FM16", m3FM16.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM17))
				request.WithQueryParameter("FM17", m3FM17.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM18))
				request.WithQueryParameter("FM18", m3FM18.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM19))
				request.WithQueryParameter("FM19", m3FM19.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM20))
				request.WithQueryParameter("FM20", m3FM20.Trim());
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetIntStyle
		/// Description Get interface item style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3IFIN">Interface item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntStyleResponse></returns>
		/// <exception cref="M3Exception<GetIntStyleResponse>"></exception>
		public async Task<M3Response<GetIntStyleResponse>> GetIntStyle(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetIntStyle",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIN))
				request.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Execute the request
			var result = await Execute<GetIntStyleResponse>(
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
		/// Name ImpIntItm
		/// Description Import Interface Item
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
		/// <returns>M3Response<ImpIntItmResponse></returns>
		/// <exception cref="M3Exception<ImpIntItmResponse>"></exception>
		public async Task<M3Response<ImpIntItmResponse>> ImpIntItm(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ImpIntItm",
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
			var result = await Execute<ImpIntItmResponse>(
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
		/// Name ImpIntItmWhs
		/// Description Import Interface Item on specific warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ImpIntItmWhsResponse></returns>
		/// <exception cref="M3Exception<ImpIntItmWhsResponse>"></exception>
		public async Task<M3Response<ImpIntItmWhsResponse>> ImpIntItmWhs(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3WHLO, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ImpIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<ImpIntItmWhsResponse>(
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
		/// Name LstIntStyle
		/// Description List Interface item style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3IFIN">Interface item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntStyleResponse></returns>
		/// <exception cref="M3Exception<LstIntStyleResponse>"></exception>
		public async Task<M3Response<LstIntStyleResponse>> LstIntStyle(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstIntStyle",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIN))
				request.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Execute the request
			var result = await Execute<LstIntStyleResponse>(
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
		/// Name SndAddIntItm
		/// Description Send Add Interface Item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3MSGD">Message</param>
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
		/// <param name="m3DIGI">Discount group - item</param>
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
		/// <param name="m3SPUC">Fixed or dynamic sales price U/M</param>
		/// <param name="m3WHTA">Warehouse table</param>
		/// <param name="m3SECH">Season control</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3BSTA">Status</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3BSUN">Supplier number</param>
		/// <param name="m3SUWH">Supplying warehouse</param>
		/// <param name="m3SSQT">Safety stock</param>
		/// <param name="m3REOP">Reorder point</param>
		/// <param name="m3EOQT">Order quantity</param>
		/// <param name="m3MXST">Maximum stock</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3STMT">Storage method</param>
		/// <param name="m3ALMT">Allocation method</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3SLDY">Shelf life</param>
		/// <param name="m3REDY">Reinspection time</param>
		/// <param name="m3SAEL">Sales time</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3CPCD">CTP policy</param>
		/// <param name="m3MXSM">Maximum stock method</param>
		/// <param name="m3ABCD">ABC class - volume</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3ACOC">ABC class - contribution</param>
		/// <param name="m3MABC">ABC class - manual</param>
		/// <param name="m3ABCM">ABC method  - volume</param>
		/// <param name="m3ABFM">ABC method - frequency</param>
		/// <param name="m3ACOM">ABC method - contribution</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3LEA4">Administrative lead time</param>
		/// <param name="m3REWH">Main warehouse</param>
		/// <param name="m3VAMT">Inventory accounting method</param>
		/// <param name="m3FATM">On-hand balance method - facility</param>
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
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3ACMC">Compatibility code</param>
		/// <param name="m3HVMT">Harvest Method</param>
		/// <param name="m3BBTM">Best before time</param>
		/// <param name="m3SPGV">Specific gravity</param>
		/// <param name="m3PDLN">Product line</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3RUID">Ruleset ID</param>
		/// <param name="m3PNYN">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItm(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3PMSN = null, 
			string m3MSID = null, 
			string m3MSGD = null, 
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
			string m3DIGI = null, 
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
			int? m3SPUC = null, 
			string m3WHTA = null, 
			int? m3SECH = null, 
			string m3WHLO = null, 
			int? m3PUIT = null, 
			int? m3OPLC = null, 
			int? m3MSCH = null, 
			int? m3DPID = null, 
			string m3PLCD = null, 
			int? m3LEA1 = null, 
			string m3BSTA = null, 
			string m3ORTY = null, 
			string m3BSUN = null, 
			string m3SUWH = null, 
			decimal? m3SSQT = null, 
			decimal? m3REOP = null, 
			decimal? m3EOQT = null, 
			decimal? m3MXST = null, 
			string m3WHSL = null, 
			int? m3STMT = null, 
			int? m3ALMT = null, 
			int? m3SPMT = null, 
			int? m3SLDY = null, 
			int? m3REDY = null, 
			int? m3SAEL = null, 
			string m3BUYE = null, 
			string m3CPCD = null, 
			int? m3MXSM = null, 
			string m3ABCD = null, 
			string m3ABFC = null, 
			string m3ACOC = null, 
			string m3MABC = null, 
			int? m3ABCM = null, 
			int? m3ABFM = null, 
			int? m3ACOM = null, 
			string m3FACI = null, 
			string m3CSNO = null, 
			string m3ORCO = null, 
			int? m3LEA4 = null, 
			string m3REWH = null, 
			int? m3VAMT = null, 
			int? m3FATM = null, 
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
			string m3MOTP = null, 
			string m3ACMC = null, 
			int? m3HVMT = null, 
			int? m3BBTM = null, 
			decimal? m3SPGV = null, 
			string m3PDLN = null, 
			string m3CPGR = null, 
			string m3RUID = null, 
			int? m3PNYN = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndAddIntItm",
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
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGD))
				request.WithQueryParameter("MSGD", m3MSGD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3DIGI))
				request.WithQueryParameter("DIGI", m3DIGI.Trim());
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
			if (m3SPUC.HasValue)
				request.WithQueryParameter("SPUC", m3SPUC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHTA))
				request.WithQueryParameter("WHTA", m3WHTA.Trim());
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3PUIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3OPLC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3MSCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLCD))
				request.WithQueryParameter("PLCD", m3PLCD.Trim());
			if (m3LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3LEA1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BSTA))
				request.WithQueryParameter("BSTA", m3BSTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3BSUN))
				request.WithQueryParameter("BSUN", m3BSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUWH))
				request.WithQueryParameter("SUWH", m3SUWH.Trim());
			if (m3SSQT.HasValue)
				request.WithQueryParameter("SSQT", m3SSQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REOP.HasValue)
				request.WithQueryParameter("REOP", m3REOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQT.HasValue)
				request.WithQueryParameter("EOQT", m3EOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXST.HasValue)
				request.WithQueryParameter("MXST", m3MXST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3STMT.HasValue)
				request.WithQueryParameter("STMT", m3STMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALMT.HasValue)
				request.WithQueryParameter("ALMT", m3ALMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SLDY.HasValue)
				request.WithQueryParameter("SLDY", m3SLDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REDY.HasValue)
				request.WithQueryParameter("REDY", m3REDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAEL.HasValue)
				request.WithQueryParameter("SAEL", m3SAEL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPCD))
				request.WithQueryParameter("CPCD", m3CPCD.Trim());
			if (m3MXSM.HasValue)
				request.WithQueryParameter("MXSM", m3MXSM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABFC))
				request.WithQueryParameter("ABFC", m3ABFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACOC))
				request.WithQueryParameter("ACOC", m3ACOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MABC))
				request.WithQueryParameter("MABC", m3MABC.Trim());
			if (m3ABCM.HasValue)
				request.WithQueryParameter("ABCM", m3ABCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABFM.HasValue)
				request.WithQueryParameter("ABFM", m3ABFM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACOM.HasValue)
				request.WithQueryParameter("ACOM", m3ACOM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3LEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REWH))
				request.WithQueryParameter("REWH", m3REWH.Trim());
			if (m3VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3VAMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FATM.HasValue)
				request.WithQueryParameter("FATM", m3FATM.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACMC))
				request.WithQueryParameter("ACMC", m3ACMC.Trim());
			if (m3HVMT.HasValue)
				request.WithQueryParameter("HVMT", m3HVMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3BBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPGV.HasValue)
				request.WithQueryParameter("SPGV", m3SPGV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PDLN))
				request.WithQueryParameter("PDLN", m3PDLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RUID))
				request.WithQueryParameter("RUID", m3RUID.Trim());
			if (m3PNYN.HasValue)
				request.WithQueryParameter("PNYN", m3PNYN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndAddIntSku
		/// Description Send Add Interface Sku
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3ISTY">Style number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3OPTZ">Option</param>
		/// <param name="m3OPTX">Option</param>
		/// <param name="m3OPTY">Option</param>
		/// <param name="m3SECH">Season control</param>
		/// <param name="m3SEA1">Season</param>
		/// <param name="m3PRNA">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntSku(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3ISTY = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3ITTY = null, 
			string m3OPTZ = null, 
			string m3OPTX = null, 
			string m3OPTY = null, 
			int? m3SECH = null, 
			string m3SEA1 = null, 
			string m3PRNA = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndAddIntSku",
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
			if (!string.IsNullOrWhiteSpace(m3ISTY))
				request.WithQueryParameter("ISTY", m3ISTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTZ))
				request.WithQueryParameter("OPTZ", m3OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTX))
				request.WithQueryParameter("OPTX", m3OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTY))
				request.WithQueryParameter("OPTY", m3OPTY.Trim());
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SEA1))
				request.WithQueryParameter("SEA1", m3SEA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNA))
				request.WithQueryParameter("PRNA", m3PRNA.Trim());

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
		/// Name SndChgIntStyle
		/// Description Send Change interface style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3FM01">User-defined field heading 1 - style</param>
		/// <param name="m3FM02">User-defined field heading 2 - style</param>
		/// <param name="m3FM03">User-defined field heading 3 - style</param>
		/// <param name="m3FM04">User-defined field heading 4 - style</param>
		/// <param name="m3FM05">User-defined field heading 5 - style</param>
		/// <param name="m3FM06">User-defined field heading 6 - style</param>
		/// <param name="m3FM07">User-defined field heading 7 - style</param>
		/// <param name="m3FM08">User-defined field heading 8 - style</param>
		/// <param name="m3FM09">User-defined field heading 9 - style</param>
		/// <param name="m3FM10">User-defined field heading 10 - style</param>
		/// <param name="m3FM11">User-defined field heading 11 - style</param>
		/// <param name="m3FM12">User-defined field heading 12 - style</param>
		/// <param name="m3FM13">User-defined field heading 13 - style</param>
		/// <param name="m3FM14">User-defined field heading 14 - style</param>
		/// <param name="m3FM15">User-defined field heading 15 - style</param>
		/// <param name="m3FM16">User-defined field heading 16 - style</param>
		/// <param name="m3FM17">User-defined field heading 17 - style</param>
		/// <param name="m3FM18">User-defined field heading 18 - style</param>
		/// <param name="m3FM19">User-defined field heading 19 - style</param>
		/// <param name="m3FM20">User-defined field heading 20 - style</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntStyle(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3FM01 = null, 
			string m3FM02 = null, 
			string m3FM03 = null, 
			string m3FM04 = null, 
			string m3FM05 = null, 
			string m3FM06 = null, 
			string m3FM07 = null, 
			string m3FM08 = null, 
			string m3FM09 = null, 
			string m3FM10 = null, 
			string m3FM11 = null, 
			string m3FM12 = null, 
			string m3FM13 = null, 
			string m3FM14 = null, 
			string m3FM15 = null, 
			string m3FM16 = null, 
			string m3FM17 = null, 
			string m3FM18 = null, 
			string m3FM19 = null, 
			string m3FM20 = null, 
			int? m3ITFL = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndChgIntStyle",
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
			if (!string.IsNullOrWhiteSpace(m3FM01))
				request.WithQueryParameter("FM01", m3FM01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM02))
				request.WithQueryParameter("FM02", m3FM02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM03))
				request.WithQueryParameter("FM03", m3FM03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM04))
				request.WithQueryParameter("FM04", m3FM04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM05))
				request.WithQueryParameter("FM05", m3FM05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM06))
				request.WithQueryParameter("FM06", m3FM06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM07))
				request.WithQueryParameter("FM07", m3FM07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM08))
				request.WithQueryParameter("FM08", m3FM08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM09))
				request.WithQueryParameter("FM09", m3FM09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM10))
				request.WithQueryParameter("FM10", m3FM10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM11))
				request.WithQueryParameter("FM11", m3FM11.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM12))
				request.WithQueryParameter("FM12", m3FM12.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM13))
				request.WithQueryParameter("FM13", m3FM13.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM14))
				request.WithQueryParameter("FM14", m3FM14.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM15))
				request.WithQueryParameter("FM15", m3FM15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM16))
				request.WithQueryParameter("FM16", m3FM16.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM17))
				request.WithQueryParameter("FM17", m3FM17.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM18))
				request.WithQueryParameter("FM18", m3FM18.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM19))
				request.WithQueryParameter("FM19", m3FM19.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM20))
				request.WithQueryParameter("FM20", m3FM20.Trim());
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndImpIntItm
		/// Description Send Import Interface Item
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
		public async Task<M3Response<M3Record>> SndImpIntItm(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndImpIntItm",
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
		/// Name SndValIntItm
		/// Description Send Validate Interface Item
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
		public async Task<M3Response<M3Record>> SndValIntItm(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndValIntItm",
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
		/// Name ValIntItm
		/// Description Validate Interface item
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
		/// <returns>M3Response<ValIntItmResponse></returns>
		/// <exception cref="M3Exception<ValIntItmResponse>"></exception>
		public async Task<M3Response<ValIntItmResponse>> ValIntItm(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ValIntItm",
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
			var result = await Execute<ValIntItmResponse>(
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
