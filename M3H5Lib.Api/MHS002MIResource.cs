/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS002MI;
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
	/// Name: MHS002MI
	/// Component Name: Interface Item/Warehouse
	/// Description: Api: Interface Item/Warehouse
	/// Version Release: 5ea0
	///</summary>
	public partial class MHS002MIResource : M3BaseResourceEndpoint
	{
		public MHS002MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS002MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItmWhs
		/// Description Add Interface item warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_SUNO">Supplier number</param>
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
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_CPCD">CTP policy</param>
		/// <param name="m3_MXSM">Maximum stock method</param>
		/// <param name="m3_ABCD">ABC class - volume</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_ACOC">ABC class - contribution</param>
		/// <param name="m3_MABC">ABC class - manual</param>
		/// <param name="m3_ABCM">ABC method  - volume</param>
		/// <param name="m3_ABFM">ABC method - frequency</param>
		/// <param name="m3_ACOM">ABC method - contribution</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_OPOM">Reorder point method</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_EQDA">Economical order quantity days</param>
		/// <param name="m3_MXPC">Maximum stock percentage</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_MOQT">Maximum order quantity</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_AGDY">Aging days</param>
		/// <param name="m3_COMG">Container management</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_SSDA">Safety stock unit</param>
		/// <param name="m3_MSSQ">Manual safety stock</param>
		/// <param name="m3_SSMT">Safety stock method</param>
		/// <param name="m3_SCPO">Supply chain policy</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DIGR">Distribution group</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_YEQT">Annual demand</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_SCRQ">Scan required</param>
		/// <param name="m3_AGHO">Aging hours</param>
		/// <param name="m3_AGMI">Aging minutes</param>
		/// <param name="m3_BBTM">Best before time</param>
		/// <param name="m3_FSSQ">Frozen safety stock</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_SSRE">SS reason code</param>
		/// <param name="m3_ISEG">Inventory segment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIntItmWhs(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			int? m3_PUIT = null, 
			int? m3_OPLC = null, 
			int? m3_MSCH = null, 
			int? m3_DPID = null, 
			string m3_PLCD = null, 
			int? m3_LEA1 = null, 
			string m3_STAT = null, 
			string m3_ORTY = null, 
			string m3_SUNO = null, 
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
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_CPCD = null, 
			int? m3_MXSM = null, 
			string m3_ABCD = null, 
			string m3_ABFC = null, 
			string m3_ACOC = null, 
			string m3_MABC = null, 
			int? m3_ABCM = null, 
			int? m3_ABFM = null, 
			int? m3_ACOM = null, 
			string m3_BUYE = null, 
			int? m3_OPOM = null, 
			int? m3_EOQM = null, 
			int? m3_EQDA = null, 
			int? m3_MXPC = null, 
			decimal? m3_LOQT = null, 
			decimal? m3_MOQT = null, 
			int? m3_ITFL = null, 
			int? m3_AGDY = null, 
			int? m3_COMG = null, 
			string m3_SLTP = null, 
			int? m3_SSDA = null, 
			decimal? m3_MSSQ = null, 
			int? m3_SSMT = null, 
			string m3_SCPO = null, 
			decimal? m3_UNMU = null, 
			string m3_RESP = null, 
			string m3_DIGR = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			decimal? m3_YEQT = null, 
			int? m3_RNRI = null, 
			int? m3_RMSG = null, 
			int? m3_SCRQ = null, 
			int? m3_AGHO = null, 
			int? m3_AGMI = null, 
			int? m3_BBTM = null, 
			int? m3_FSSQ = null, 
			int? m3_CONC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
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
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (m3_OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3_OPOM.Value.ToString());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3_EQDA.Value.ToString());
			if (m3_MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3_MXPC.Value.ToString());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3_MOQT.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3_AGDY.Value.ToString());
			if (m3_COMG.HasValue)
				request.WithQueryParameter("COMG", m3_COMG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (m3_SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3_SSDA.Value.ToString());
			if (m3_MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3_MSSQ.Value.ToString());
			if (m3_SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3_SSMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPO))
				request.WithQueryParameter("SCPO", m3_SCPO.Trim());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIGR))
				request.WithQueryParameter("DIGR", m3_DIGR.Trim());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (m3_YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3_YEQT.Value.ToString());
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (m3_SCRQ.HasValue)
				request.WithQueryParameter("SCRQ", m3_SCRQ.Value.ToString());
			if (m3_AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3_AGHO.Value.ToString());
			if (m3_AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3_AGMI.Value.ToString());
			if (m3_BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3_BBTM.Value.ToString());
			if (m3_FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3_FSSQ.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
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
		/// Name ChgIntItmWhs
		/// Description Change Interface Item Warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_SUNO">Supplier number</param>
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
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_CPCD">CTP policy</param>
		/// <param name="m3_MXSM">Maximum stock method</param>
		/// <param name="m3_ABCD">ABC class - volume</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_ACOC">ABC class - contribution</param>
		/// <param name="m3_MABC">ABC class - manual</param>
		/// <param name="m3_ABCM">ABC method  - volume</param>
		/// <param name="m3_ABFM">ABC method - frequency</param>
		/// <param name="m3_ACOM">ABC method - contribution</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_OPOM">Reorder point method</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_EQDA">Economical order quantity days</param>
		/// <param name="m3_MXPC">Maximum stock percentage</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_MOQT">Maximum order quantity</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_AGDY">Aging days</param>
		/// <param name="m3_COMG">Container management</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_SSDA">Safety stock unit</param>
		/// <param name="m3_MSSQ">Manual safety stock</param>
		/// <param name="m3_SSMT">Safety stock method</param>
		/// <param name="m3_SCPO">Supply chain policy</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DIGR">Distribution group</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_YEQT">Annual demand</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_SCRQ">Scan required</param>
		/// <param name="m3_AGHO">Aging hours</param>
		/// <param name="m3_AGMI">Aging minutes</param>
		/// <param name="m3_BBTM">Best before time</param>
		/// <param name="m3_FSSQ">Frozen safety stock</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_SSRE">SS reason code</param>
		/// <param name="m3_ISEG">Inventory segment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmWhs(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			int? m3_PUIT = null, 
			int? m3_OPLC = null, 
			int? m3_MSCH = null, 
			int? m3_DPID = null, 
			string m3_PLCD = null, 
			int? m3_LEA1 = null, 
			string m3_STAT = null, 
			string m3_ORTY = null, 
			string m3_SUNO = null, 
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
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_CPCD = null, 
			int? m3_MXSM = null, 
			string m3_ABCD = null, 
			string m3_ABFC = null, 
			string m3_ACOC = null, 
			string m3_MABC = null, 
			int? m3_ABCM = null, 
			int? m3_ABFM = null, 
			int? m3_ACOM = null, 
			string m3_BUYE = null, 
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			int? m3_OPOM = null, 
			int? m3_EOQM = null, 
			int? m3_EQDA = null, 
			int? m3_MXPC = null, 
			decimal? m3_LOQT = null, 
			decimal? m3_MOQT = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			int? m3_AGDY = null, 
			int? m3_COMG = null, 
			string m3_SLTP = null, 
			int? m3_SSDA = null, 
			decimal? m3_MSSQ = null, 
			int? m3_SSMT = null, 
			string m3_SCPO = null, 
			decimal? m3_UNMU = null, 
			string m3_RESP = null, 
			string m3_DIGR = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			decimal? m3_YEQT = null, 
			int? m3_RNRI = null, 
			int? m3_RMSG = null, 
			string m3_ITAB = null, 
			int? m3_SCRQ = null, 
			int? m3_AGHO = null, 
			int? m3_AGMI = null, 
			int? m3_BBTM = null, 
			int? m3_FSSQ = null, 
			int? m3_CONC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
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
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (m3_OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3_OPOM.Value.ToString());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3_EQDA.Value.ToString());
			if (m3_MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3_MXPC.Value.ToString());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3_MOQT.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (m3_AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3_AGDY.Value.ToString());
			if (m3_COMG.HasValue)
				request.WithQueryParameter("COMG", m3_COMG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (m3_SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3_SSDA.Value.ToString());
			if (m3_MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3_MSSQ.Value.ToString());
			if (m3_SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3_SSMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPO))
				request.WithQueryParameter("SCPO", m3_SCPO.Trim());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIGR))
				request.WithQueryParameter("DIGR", m3_DIGR.Trim());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (m3_YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3_YEQT.Value.ToString());
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (m3_SCRQ.HasValue)
				request.WithQueryParameter("SCRQ", m3_SCRQ.Value.ToString());
			if (m3_AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3_AGHO.Value.ToString());
			if (m3_AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3_AGMI.Value.ToString());
			if (m3_BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3_BBTM.Value.ToString());
			if (m3_FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3_FSSQ.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
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
		/// Name CpyIntItmWhs
		/// Description Copy Interface Item Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_TE0P">Partner (Required)</param>
		/// <param name="m3_TE06">Message type (Required)</param>
		/// <param name="m3_TWHL">Warehouse (Required)</param>
		/// <param name="m3_TFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmWhs(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_IFIN, 
			string m3_TE0P, 
			string m3_TE06, 
			string m3_TWHL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_TE0P))
				throw new ArgumentNullException("m3_TE0P");
			if (string.IsNullOrWhiteSpace(m3_TE06))
				throw new ArgumentNullException("m3_TE06");
			if (string.IsNullOrWhiteSpace(m3_TWHL))
				throw new ArgumentNullException("m3_TWHL");
			if (string.IsNullOrWhiteSpace(m3_TFIN))
				throw new ArgumentNullException("m3_TFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("TE0P", m3_TE0P.Trim())
				.WithQueryParameter("TE06", m3_TE06.Trim())
				.WithQueryParameter("TWHL", m3_TWHL.Trim())
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
		/// Name DelIntItmWhs
		/// Description Delete Inteface Item Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmWhs(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
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
		/// Name GetIntItmWhs
		/// Description Get Interface Item Warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmWhsResponse></returns>
		/// <exception cref="M3Exception<GetIntItmWhsResponse>"></exception>
		public async Task<M3Response<GetIntItmWhsResponse>> GetIntItmWhs(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Execute the request
			var result = await Execute<GetIntItmWhsResponse>(
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
		/// Name LstIntItmWhs
		/// Description List Inteface Item Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_IFIN">Interface item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmWhsResponse></returns>
		/// <exception cref="M3Exception<LstIntItmWhsResponse>"></exception>
		public async Task<M3Response<LstIntItmWhsResponse>> LstIntItmWhs(
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntItmWhs",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIN))
				request.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Execute the request
			var result = await Execute<LstIntItmWhsResponse>(
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
		/// Name SndAddIntItmWhs
		/// Description Send Add Interface item warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_SUNO">Supplier number</param>
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
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_CPCD">CTP policy</param>
		/// <param name="m3_MXSM">Maximum stock method</param>
		/// <param name="m3_ABCD">ABC class - volume</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_ACOC">ABC class - contribution</param>
		/// <param name="m3_MABC">ABC class - manual</param>
		/// <param name="m3_ABCM">ABC method  - volume</param>
		/// <param name="m3_ABFM">ABC method - frequency</param>
		/// <param name="m3_ACOM">ABC method - contribution</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_OPOM">Reorder point method</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_EQDA">Economical order quantity days</param>
		/// <param name="m3_MXPC">Maximum stock percentage</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_MOQT">Maximum order quantity</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_AGDY">Aging days</param>
		/// <param name="m3_COMG">Container management</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_SSDA">Safety stock unit</param>
		/// <param name="m3_MSSQ">Manual safety stock</param>
		/// <param name="m3_SSMT">Safety stock method</param>
		/// <param name="m3_SCPO">Supply chain policy</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DIGR">Distribution group</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_YEQT">Annual demand</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_SCRQ">Scan required</param>
		/// <param name="m3_AGHO">Aging hours</param>
		/// <param name="m3_AGMI">Aging minutes</param>
		/// <param name="m3_BBTM">Best before time</param>
		/// <param name="m3_FSSQ">Frozen safety stock</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_ISEG">Inventory segment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmWhs(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			int? m3_PUIT = null, 
			int? m3_OPLC = null, 
			int? m3_MSCH = null, 
			int? m3_DPID = null, 
			string m3_PLCD = null, 
			int? m3_LEA1 = null, 
			string m3_STAT = null, 
			string m3_ORTY = null, 
			string m3_SUNO = null, 
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
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_CPCD = null, 
			int? m3_MXSM = null, 
			string m3_ABCD = null, 
			string m3_ABFC = null, 
			string m3_ACOC = null, 
			string m3_MABC = null, 
			int? m3_ABCM = null, 
			int? m3_ABFM = null, 
			int? m3_ACOM = null, 
			string m3_BUYE = null, 
			int? m3_OPOM = null, 
			int? m3_EOQM = null, 
			int? m3_EQDA = null, 
			int? m3_MXPC = null, 
			decimal? m3_LOQT = null, 
			decimal? m3_MOQT = null, 
			int? m3_ITFL = null, 
			int? m3_AGDY = null, 
			int? m3_COMG = null, 
			string m3_SLTP = null, 
			int? m3_SSDA = null, 
			decimal? m3_MSSQ = null, 
			int? m3_SSMT = null, 
			string m3_SCPO = null, 
			decimal? m3_UNMU = null, 
			string m3_RESP = null, 
			string m3_DIGR = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			decimal? m3_YEQT = null, 
			int? m3_RNRI = null, 
			int? m3_RMSG = null, 
			int? m3_SCRQ = null, 
			int? m3_AGHO = null, 
			int? m3_AGMI = null, 
			int? m3_BBTM = null, 
			int? m3_FSSQ = null, 
			int? m3_CONC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAddIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
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
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (m3_OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3_OPOM.Value.ToString());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3_EQDA.Value.ToString());
			if (m3_MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3_MXPC.Value.ToString());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3_MOQT.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3_AGDY.Value.ToString());
			if (m3_COMG.HasValue)
				request.WithQueryParameter("COMG", m3_COMG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (m3_SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3_SSDA.Value.ToString());
			if (m3_MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3_MSSQ.Value.ToString());
			if (m3_SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3_SSMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPO))
				request.WithQueryParameter("SCPO", m3_SCPO.Trim());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIGR))
				request.WithQueryParameter("DIGR", m3_DIGR.Trim());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (m3_YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3_YEQT.Value.ToString());
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (m3_SCRQ.HasValue)
				request.WithQueryParameter("SCRQ", m3_SCRQ.Value.ToString());
			if (m3_AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3_AGHO.Value.ToString());
			if (m3_AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3_AGMI.Value.ToString());
			if (m3_BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3_BBTM.Value.ToString());
			if (m3_FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3_FSSQ.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
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
		/// Name SndChgIntItmWhs
		/// Description Send Change Interface Item Warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_SUNO">Supplier number</param>
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
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_CPCD">CTP policy</param>
		/// <param name="m3_MXSM">Maximum stock method</param>
		/// <param name="m3_ABCD">ABC class - volume</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_ACOC">ABC class - contribution</param>
		/// <param name="m3_MABC">ABC class - manual</param>
		/// <param name="m3_ABCM">ABC method  - volume</param>
		/// <param name="m3_ABFM">ABC method - frequency</param>
		/// <param name="m3_ACOM">ABC method - contribution</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_OPOM">Reorder point method</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_EQDA">Economical order quantity days</param>
		/// <param name="m3_MXPC">Maximum stock percentage</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_MOQT">Maximum order quantity</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_AGDY">Aging days</param>
		/// <param name="m3_COMG">Container management</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_SSDA">Safety stock unit</param>
		/// <param name="m3_MSSQ">Manual safety stock</param>
		/// <param name="m3_SSMT">Safety stock method</param>
		/// <param name="m3_SCPO">Supply chain policy</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DIGR">Distribution group</param>
		/// <param name="m3_VTCP">VAT code - purchase</param>
		/// <param name="m3_VTCS">VAT code - sales</param>
		/// <param name="m3_YEQT">Annual demand</param>
		/// <param name="m3_RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3_RMSG">Returnable message</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_SCRQ">Scan required</param>
		/// <param name="m3_AGHO">Aging hours</param>
		/// <param name="m3_AGMI">Aging minutes</param>
		/// <param name="m3_BBTM">Best before time</param>
		/// <param name="m3_FSSQ">Frozen safety stock</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_ISEG">Inventory segment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmWhs(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			int? m3_PUIT = null, 
			int? m3_OPLC = null, 
			int? m3_MSCH = null, 
			int? m3_DPID = null, 
			string m3_PLCD = null, 
			int? m3_LEA1 = null, 
			string m3_STAT = null, 
			string m3_ORTY = null, 
			string m3_SUNO = null, 
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
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_CPCD = null, 
			int? m3_MXSM = null, 
			string m3_ABCD = null, 
			string m3_ABFC = null, 
			string m3_ACOC = null, 
			string m3_MABC = null, 
			int? m3_ABCM = null, 
			int? m3_ABFM = null, 
			int? m3_ACOM = null, 
			string m3_BUYE = null, 
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			int? m3_OPOM = null, 
			int? m3_EOQM = null, 
			int? m3_EQDA = null, 
			int? m3_MXPC = null, 
			decimal? m3_LOQT = null, 
			decimal? m3_MOQT = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			int? m3_AGDY = null, 
			int? m3_COMG = null, 
			string m3_SLTP = null, 
			int? m3_SSDA = null, 
			decimal? m3_MSSQ = null, 
			int? m3_SSMT = null, 
			string m3_SCPO = null, 
			decimal? m3_UNMU = null, 
			string m3_RESP = null, 
			string m3_DIGR = null, 
			int? m3_VTCP = null, 
			int? m3_VTCS = null, 
			decimal? m3_YEQT = null, 
			int? m3_RNRI = null, 
			int? m3_RMSG = null, 
			string m3_ITAB = null, 
			int? m3_SCRQ = null, 
			int? m3_AGHO = null, 
			int? m3_AGMI = null, 
			int? m3_BBTM = null, 
			int? m3_FSSQ = null, 
			int? m3_CONC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndChgIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
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
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (m3_OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3_OPOM.Value.ToString());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3_EQDA.Value.ToString());
			if (m3_MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3_MXPC.Value.ToString());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3_MOQT.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (m3_AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3_AGDY.Value.ToString());
			if (m3_COMG.HasValue)
				request.WithQueryParameter("COMG", m3_COMG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (m3_SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3_SSDA.Value.ToString());
			if (m3_MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3_MSSQ.Value.ToString());
			if (m3_SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3_SSMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPO))
				request.WithQueryParameter("SCPO", m3_SCPO.Trim());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIGR))
				request.WithQueryParameter("DIGR", m3_DIGR.Trim());
			if (m3_VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3_VTCP.Value.ToString());
			if (m3_VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3_VTCS.Value.ToString());
			if (m3_YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3_YEQT.Value.ToString());
			if (m3_RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3_RNRI.Value.ToString());
			if (m3_RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3_RMSG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (m3_SCRQ.HasValue)
				request.WithQueryParameter("SCRQ", m3_SCRQ.Value.ToString());
			if (m3_AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3_AGHO.Value.ToString());
			if (m3_AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3_AGMI.Value.ToString());
			if (m3_BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3_BBTM.Value.ToString());
			if (m3_FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3_FSSQ.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
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
	}
}
// EOF
