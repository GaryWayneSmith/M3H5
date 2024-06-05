/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3SUNO">Supplier number</param>
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
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3CPCD">CTP policy</param>
		/// <param name="m3MXSM">Maximum stock method</param>
		/// <param name="m3ABCD">ABC class - volume</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3ACOC">ABC class - contribution</param>
		/// <param name="m3MABC">ABC class - manual</param>
		/// <param name="m3ABCM">ABC method  - volume</param>
		/// <param name="m3ABFM">ABC method - frequency</param>
		/// <param name="m3ACOM">ABC method - contribution</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3OPOM">Reorder point method</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3EQDA">Economical order quantity days</param>
		/// <param name="m3MXPC">Maximum stock percentage</param>
		/// <param name="m3LOQT">Minimum order quantity</param>
		/// <param name="m3MOQT">Maximum order quantity</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3AGDY">Aging days</param>
		/// <param name="m3COMG">Container management</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3SSDA">Safety stock unit</param>
		/// <param name="m3MSSQ">Manual safety stock</param>
		/// <param name="m3SSMT">Safety stock method</param>
		/// <param name="m3SCPO">Supply chain policy</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DIGR">Distribution group</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3YEQT">Annual demand</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3SCRQ">Scan required</param>
		/// <param name="m3AGHO">Aging hours</param>
		/// <param name="m3AGMI">Aging minutes</param>
		/// <param name="m3BBTM">Best before time</param>
		/// <param name="m3FSSQ">Frozen safety stock</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3SSRE">SS reason code</param>
		/// <param name="m3ISEG">Inventory segment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIntItmWhs(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3IFIN, 
			string m3PRMD = null, 
			int? m3PUIT = null, 
			int? m3OPLC = null, 
			int? m3MSCH = null, 
			int? m3DPID = null, 
			string m3PLCD = null, 
			int? m3LEA1 = null, 
			string m3STAT = null, 
			string m3ORTY = null, 
			string m3SUNO = null, 
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
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3CPCD = null, 
			int? m3MXSM = null, 
			string m3ABCD = null, 
			string m3ABFC = null, 
			string m3ACOC = null, 
			string m3MABC = null, 
			int? m3ABCM = null, 
			int? m3ABFM = null, 
			int? m3ACOM = null, 
			string m3BUYE = null, 
			int? m3OPOM = null, 
			int? m3EOQM = null, 
			int? m3EQDA = null, 
			int? m3MXPC = null, 
			decimal? m3LOQT = null, 
			decimal? m3MOQT = null, 
			int? m3ITFL = null, 
			int? m3AGDY = null, 
			int? m3COMG = null, 
			string m3SLTP = null, 
			int? m3SSDA = null, 
			decimal? m3MSSQ = null, 
			int? m3SSMT = null, 
			string m3SCPO = null, 
			decimal? m3UNMU = null, 
			string m3RESP = null, 
			string m3DIGR = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			decimal? m3YEQT = null, 
			int? m3RNRI = null, 
			int? m3RMSG = null, 
			int? m3SCRQ = null, 
			int? m3AGHO = null, 
			int? m3AGMI = null, 
			int? m3BBTM = null, 
			int? m3FSSQ = null, 
			int? m3CONC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
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
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (m3OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3OPOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3EQDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3MXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3MOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3AGDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COMG.HasValue)
				request.WithQueryParameter("COMG", m3COMG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (m3SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3SSDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3MSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3SSMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPO))
				request.WithQueryParameter("SCPO", m3SCPO.Trim());
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIGR))
				request.WithQueryParameter("DIGR", m3DIGR.Trim());
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3YEQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCRQ.HasValue)
				request.WithQueryParameter("SCRQ", m3SCRQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3AGHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3AGMI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3BBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3FSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name ChgIntItmWhs
		/// Description Change Interface Item Warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3SUNO">Supplier number</param>
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
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3CPCD">CTP policy</param>
		/// <param name="m3MXSM">Maximum stock method</param>
		/// <param name="m3ABCD">ABC class - volume</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3ACOC">ABC class - contribution</param>
		/// <param name="m3MABC">ABC class - manual</param>
		/// <param name="m3ABCM">ABC method  - volume</param>
		/// <param name="m3ABFM">ABC method - frequency</param>
		/// <param name="m3ACOM">ABC method - contribution</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="m3OPOM">Reorder point method</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3EQDA">Economical order quantity days</param>
		/// <param name="m3MXPC">Maximum stock percentage</param>
		/// <param name="m3LOQT">Minimum order quantity</param>
		/// <param name="m3MOQT">Maximum order quantity</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ACFL">Add/change flag</param>
		/// <param name="m3AGDY">Aging days</param>
		/// <param name="m3COMG">Container management</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3SSDA">Safety stock unit</param>
		/// <param name="m3MSSQ">Manual safety stock</param>
		/// <param name="m3SSMT">Safety stock method</param>
		/// <param name="m3SCPO">Supply chain policy</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DIGR">Distribution group</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3YEQT">Annual demand</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3SCRQ">Scan required</param>
		/// <param name="m3AGHO">Aging hours</param>
		/// <param name="m3AGMI">Aging minutes</param>
		/// <param name="m3BBTM">Best before time</param>
		/// <param name="m3FSSQ">Frozen safety stock</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3SSRE">SS reason code</param>
		/// <param name="m3ISEG">Inventory segment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmWhs(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3IFIN, 
			string m3PRMD = null, 
			int? m3PUIT = null, 
			int? m3OPLC = null, 
			int? m3MSCH = null, 
			int? m3DPID = null, 
			string m3PLCD = null, 
			int? m3LEA1 = null, 
			string m3STAT = null, 
			string m3ORTY = null, 
			string m3SUNO = null, 
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
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3CPCD = null, 
			int? m3MXSM = null, 
			string m3ABCD = null, 
			string m3ABFC = null, 
			string m3ACOC = null, 
			string m3MABC = null, 
			int? m3ABCM = null, 
			int? m3ABFM = null, 
			int? m3ACOM = null, 
			string m3BUYE = null, 
			DateTime? m3STDT = null, 
			int? m3STIM = null, 
			int? m3OPOM = null, 
			int? m3EOQM = null, 
			int? m3EQDA = null, 
			int? m3MXPC = null, 
			decimal? m3LOQT = null, 
			decimal? m3MOQT = null, 
			int? m3ITFL = null, 
			int? m3ACFL = null, 
			int? m3AGDY = null, 
			int? m3COMG = null, 
			string m3SLTP = null, 
			int? m3SSDA = null, 
			decimal? m3MSSQ = null, 
			int? m3SSMT = null, 
			string m3SCPO = null, 
			decimal? m3UNMU = null, 
			string m3RESP = null, 
			string m3DIGR = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			decimal? m3YEQT = null, 
			int? m3RNRI = null, 
			int? m3RMSG = null, 
			string m3ITAB = null, 
			int? m3SCRQ = null, 
			int? m3AGHO = null, 
			int? m3AGMI = null, 
			int? m3BBTM = null, 
			int? m3FSSQ = null, 
			int? m3CONC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
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
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3OPOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3EQDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3MXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3MOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3ACFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3AGDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COMG.HasValue)
				request.WithQueryParameter("COMG", m3COMG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (m3SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3SSDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3MSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3SSMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPO))
				request.WithQueryParameter("SCPO", m3SCPO.Trim());
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIGR))
				request.WithQueryParameter("DIGR", m3DIGR.Trim());
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3YEQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (m3SCRQ.HasValue)
				request.WithQueryParameter("SCRQ", m3SCRQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3AGHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3AGMI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3BBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3FSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name CpyIntItmWhs
		/// Description Copy Interface Item Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3TE0P">Partner (Required)</param>
		/// <param name="m3TE06">Message type (Required)</param>
		/// <param name="m3TWHL">Warehouse (Required)</param>
		/// <param name="m3TFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmWhs(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3IFIN, 
			string m3TE0P, 
			string m3TE06, 
			string m3TWHL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3TE0P))
				throw new ArgumentNullException(nameof(m3TE0P));
			if (string.IsNullOrWhiteSpace(m3TE06))
				throw new ArgumentNullException(nameof(m3TE06));
			if (string.IsNullOrWhiteSpace(m3TWHL))
				throw new ArgumentNullException(nameof(m3TWHL));
			if (string.IsNullOrWhiteSpace(m3TFIN))
				throw new ArgumentNullException(nameof(m3TFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("TE0P", m3TE0P.Trim())
				.WithQueryParameter("TE06", m3TE06.Trim())
				.WithQueryParameter("TWHL", m3TWHL.Trim())
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
		/// Name DelIntItmWhs
		/// Description Delete Inteface Item Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmWhs(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
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
		/// Name GetIntItmWhs
		/// Description Get Interface Item Warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmWhsResponse></returns>
		/// <exception cref="M3Exception<GetIntItmWhsResponse>"></exception>
		public async Task<M3Response<GetIntItmWhsResponse>> GetIntItmWhs(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Execute the request
			var result = await Execute<GetIntItmWhsResponse>(
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
		/// Name LstIntItmWhs
		/// Description List Inteface Item Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3IFIN">Interface item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmWhsResponse></returns>
		/// <exception cref="M3Exception<LstIntItmWhsResponse>"></exception>
		public async Task<M3Response<LstIntItmWhsResponse>> LstIntItmWhs(
			string m3E0PA = null, 
			string m3E065 = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntItmWhs",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIN))
				request.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Execute the request
			var result = await Execute<LstIntItmWhsResponse>(
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
		/// Name SndAddIntItmWhs
		/// Description Send Add Interface item warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3SUNO">Supplier number</param>
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
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3CPCD">CTP policy</param>
		/// <param name="m3MXSM">Maximum stock method</param>
		/// <param name="m3ABCD">ABC class - volume</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3ACOC">ABC class - contribution</param>
		/// <param name="m3MABC">ABC class - manual</param>
		/// <param name="m3ABCM">ABC method  - volume</param>
		/// <param name="m3ABFM">ABC method - frequency</param>
		/// <param name="m3ACOM">ABC method - contribution</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3OPOM">Reorder point method</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3EQDA">Economical order quantity days</param>
		/// <param name="m3MXPC">Maximum stock percentage</param>
		/// <param name="m3LOQT">Minimum order quantity</param>
		/// <param name="m3MOQT">Maximum order quantity</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3AGDY">Aging days</param>
		/// <param name="m3COMG">Container management</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3SSDA">Safety stock unit</param>
		/// <param name="m3MSSQ">Manual safety stock</param>
		/// <param name="m3SSMT">Safety stock method</param>
		/// <param name="m3SCPO">Supply chain policy</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DIGR">Distribution group</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3YEQT">Annual demand</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3SCRQ">Scan required</param>
		/// <param name="m3AGHO">Aging hours</param>
		/// <param name="m3AGMI">Aging minutes</param>
		/// <param name="m3BBTM">Best before time</param>
		/// <param name="m3FSSQ">Frozen safety stock</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3ISEG">Inventory segment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmWhs(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3IFIN, 
			string m3PRMD = null, 
			int? m3PUIT = null, 
			int? m3OPLC = null, 
			int? m3MSCH = null, 
			int? m3DPID = null, 
			string m3PLCD = null, 
			int? m3LEA1 = null, 
			string m3STAT = null, 
			string m3ORTY = null, 
			string m3SUNO = null, 
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
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3CPCD = null, 
			int? m3MXSM = null, 
			string m3ABCD = null, 
			string m3ABFC = null, 
			string m3ACOC = null, 
			string m3MABC = null, 
			int? m3ABCM = null, 
			int? m3ABFM = null, 
			int? m3ACOM = null, 
			string m3BUYE = null, 
			int? m3OPOM = null, 
			int? m3EOQM = null, 
			int? m3EQDA = null, 
			int? m3MXPC = null, 
			decimal? m3LOQT = null, 
			decimal? m3MOQT = null, 
			int? m3ITFL = null, 
			int? m3AGDY = null, 
			int? m3COMG = null, 
			string m3SLTP = null, 
			int? m3SSDA = null, 
			decimal? m3MSSQ = null, 
			int? m3SSMT = null, 
			string m3SCPO = null, 
			decimal? m3UNMU = null, 
			string m3RESP = null, 
			string m3DIGR = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			decimal? m3YEQT = null, 
			int? m3RNRI = null, 
			int? m3RMSG = null, 
			int? m3SCRQ = null, 
			int? m3AGHO = null, 
			int? m3AGMI = null, 
			int? m3BBTM = null, 
			int? m3FSSQ = null, 
			int? m3CONC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAddIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
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
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (m3OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3OPOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3EQDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3MXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3MOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3AGDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COMG.HasValue)
				request.WithQueryParameter("COMG", m3COMG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (m3SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3SSDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3MSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3SSMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPO))
				request.WithQueryParameter("SCPO", m3SCPO.Trim());
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIGR))
				request.WithQueryParameter("DIGR", m3DIGR.Trim());
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3YEQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCRQ.HasValue)
				request.WithQueryParameter("SCRQ", m3SCRQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3AGHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3AGMI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3BBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3FSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name SndChgIntItmWhs
		/// Description Send Change Interface Item Warehouse
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3SUNO">Supplier number</param>
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
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3CPCD">CTP policy</param>
		/// <param name="m3MXSM">Maximum stock method</param>
		/// <param name="m3ABCD">ABC class - volume</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3ACOC">ABC class - contribution</param>
		/// <param name="m3MABC">ABC class - manual</param>
		/// <param name="m3ABCM">ABC method  - volume</param>
		/// <param name="m3ABFM">ABC method - frequency</param>
		/// <param name="m3ACOM">ABC method - contribution</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="m3OPOM">Reorder point method</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3EQDA">Economical order quantity days</param>
		/// <param name="m3MXPC">Maximum stock percentage</param>
		/// <param name="m3LOQT">Minimum order quantity</param>
		/// <param name="m3MOQT">Maximum order quantity</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ACFL">Add/change flag</param>
		/// <param name="m3AGDY">Aging days</param>
		/// <param name="m3COMG">Container management</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3SSDA">Safety stock unit</param>
		/// <param name="m3MSSQ">Manual safety stock</param>
		/// <param name="m3SSMT">Safety stock method</param>
		/// <param name="m3SCPO">Supply chain policy</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DIGR">Distribution group</param>
		/// <param name="m3VTCP">VAT code - purchase</param>
		/// <param name="m3VTCS">VAT code - sales</param>
		/// <param name="m3YEQT">Annual demand</param>
		/// <param name="m3RNRI">Returnable / non returnable indicator</param>
		/// <param name="m3RMSG">Returnable message</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3SCRQ">Scan required</param>
		/// <param name="m3AGHO">Aging hours</param>
		/// <param name="m3AGMI">Aging minutes</param>
		/// <param name="m3BBTM">Best before time</param>
		/// <param name="m3FSSQ">Frozen safety stock</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3ISEG">Inventory segment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmWhs(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3IFIN, 
			string m3PRMD = null, 
			int? m3PUIT = null, 
			int? m3OPLC = null, 
			int? m3MSCH = null, 
			int? m3DPID = null, 
			string m3PLCD = null, 
			int? m3LEA1 = null, 
			string m3STAT = null, 
			string m3ORTY = null, 
			string m3SUNO = null, 
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
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3CPCD = null, 
			int? m3MXSM = null, 
			string m3ABCD = null, 
			string m3ABFC = null, 
			string m3ACOC = null, 
			string m3MABC = null, 
			int? m3ABCM = null, 
			int? m3ABFM = null, 
			int? m3ACOM = null, 
			string m3BUYE = null, 
			DateTime? m3STDT = null, 
			int? m3STIM = null, 
			int? m3OPOM = null, 
			int? m3EOQM = null, 
			int? m3EQDA = null, 
			int? m3MXPC = null, 
			decimal? m3LOQT = null, 
			decimal? m3MOQT = null, 
			int? m3ITFL = null, 
			int? m3ACFL = null, 
			int? m3AGDY = null, 
			int? m3COMG = null, 
			string m3SLTP = null, 
			int? m3SSDA = null, 
			decimal? m3MSSQ = null, 
			int? m3SSMT = null, 
			string m3SCPO = null, 
			decimal? m3UNMU = null, 
			string m3RESP = null, 
			string m3DIGR = null, 
			int? m3VTCP = null, 
			int? m3VTCS = null, 
			decimal? m3YEQT = null, 
			int? m3RNRI = null, 
			int? m3RMSG = null, 
			string m3ITAB = null, 
			int? m3SCRQ = null, 
			int? m3AGHO = null, 
			int? m3AGMI = null, 
			int? m3BBTM = null, 
			int? m3FSSQ = null, 
			int? m3CONC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndChgIntItmWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
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
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3OPOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQDA.HasValue)
				request.WithQueryParameter("EQDA", m3EQDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXPC.HasValue)
				request.WithQueryParameter("MXPC", m3MXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOQT.HasValue)
				request.WithQueryParameter("MOQT", m3MOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3ACFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGDY.HasValue)
				request.WithQueryParameter("AGDY", m3AGDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COMG.HasValue)
				request.WithQueryParameter("COMG", m3COMG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (m3SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3SSDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSSQ.HasValue)
				request.WithQueryParameter("MSSQ", m3MSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3SSMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPO))
				request.WithQueryParameter("SCPO", m3SCPO.Trim());
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIGR))
				request.WithQueryParameter("DIGR", m3DIGR.Trim());
			if (m3VTCP.HasValue)
				request.WithQueryParameter("VTCP", m3VTCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCS.HasValue)
				request.WithQueryParameter("VTCS", m3VTCS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEQT.HasValue)
				request.WithQueryParameter("YEQT", m3YEQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRI.HasValue)
				request.WithQueryParameter("RNRI", m3RNRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RMSG.HasValue)
				request.WithQueryParameter("RMSG", m3RMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (m3SCRQ.HasValue)
				request.WithQueryParameter("SCRQ", m3SCRQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGHO.HasValue)
				request.WithQueryParameter("AGHO", m3AGHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGMI.HasValue)
				request.WithQueryParameter("AGMI", m3AGMI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BBTM.HasValue)
				request.WithQueryParameter("BBTM", m3BBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSSQ.HasValue)
				request.WithQueryParameter("FSSQ", m3FSSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
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
	}
}
// EOF
