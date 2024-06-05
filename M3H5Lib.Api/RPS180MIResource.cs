/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.RPS180MI;
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
	/// Name: RPS180MI
	/// Component Name: Planning template
	/// Description: Api: Planning template
	/// Version Release: 5e90
	///</summary>
	public partial class RPS180MIResource : M3BaseResourceEndpoint
	{
		public RPS180MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS180MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPLT
		/// Description Add planning template
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLNT">Planning template (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_CONO">Company (NO FUNCTION)</param>
		/// <param name="m3_GMSG">Generate messages</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_SCPO">Supply chain policy</param>
		/// <param name="m3_IPLA">Inventory planned</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PRCD">Forecast method</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_SVEI">Multiple supply</param>
		/// <param name="m3_SSMT">Safety stock method</param>
		/// <param name="m3_SSDA">Safety stock unit</param>
		/// <param name="m3_SCGR">Service level</param>
		/// <param name="m3_OPOM">Reorder point method</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_SALE">Sales item</param>
		/// <param name="m3_CLDM">Clear demand</param>
		/// <param name="m3_CLOR">Clear order quantities</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPLTResponse></returns>
		/// <exception cref="M3Exception<AddPLTResponse>"></exception>
		public async Task<M3Response<AddPLTResponse>> AddPLT(
			string m3_PLNT, 
			string m3_TX40, 
			int? m3_CONO = null, 
			int? m3_GMSG = null, 
			int? m3_PUIT = null, 
			int? m3_DPID = null, 
			int? m3_OPLC = null, 
			string m3_PLCD = null, 
			int? m3_MSCH = null, 
			string m3_SCPO = null, 
			string m3_IPLA = null, 
			string m3_STAT = null, 
			int? m3_CONC = null, 
			string m3_ORTY = null, 
			string m3_PRCD = null, 
			string m3_FCCM = null, 
			int? m3_SVEI = null, 
			int? m3_SSMT = null, 
			int? m3_SSDA = null, 
			int? m3_SCGR = null, 
			int? m3_OPOM = null, 
			int? m3_EOQM = null, 
			int? m3_SALE = null, 
			int? m3_CLDM = null, 
			int? m3_CLOR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PLNT))
				throw new ArgumentNullException("m3_PLNT");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLNT", m3_PLNT.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_GMSG.HasValue)
				request.WithQueryParameter("GMSG", m3_GMSG.Value.ToString());
			if (m3_PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3_PUIT.Value.ToString());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (m3_OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3_OPLC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLCD))
				request.WithQueryParameter("PLCD", m3_PLCD.Trim());
			if (m3_MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3_MSCH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPO))
				request.WithQueryParameter("SCPO", m3_SCPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IPLA))
				request.WithQueryParameter("IPLA", m3_IPLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRCD))
				request.WithQueryParameter("PRCD", m3_PRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_SVEI.HasValue)
				request.WithQueryParameter("SVEI", m3_SVEI.Value.ToString());
			if (m3_SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3_SSMT.Value.ToString());
			if (m3_SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3_SSDA.Value.ToString());
			if (m3_SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3_SCGR.Value.ToString());
			if (m3_OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3_OPOM.Value.ToString());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_SALE.HasValue)
				request.WithQueryParameter("SALE", m3_SALE.Value.ToString());
			if (m3_CLDM.HasValue)
				request.WithQueryParameter("CLDM", m3_CLDM.Value.ToString());
			if (m3_CLOR.HasValue)
				request.WithQueryParameter("CLOR", m3_CLOR.Value.ToString());

			// Execute the request
			var result = await Execute<AddPLTResponse>(
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
		/// Name ChangePLT
		/// Description Edit planning template
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLNT">Planning template (Required)</param>
		/// <param name="m3_CONO">Company (NO FUNCTION)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_GMSG">Generate messages</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_OPLC">Planning method</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_MSCH">Master scheduled</param>
		/// <param name="m3_SCPO">Supply chain policy</param>
		/// <param name="m3_IPLA">Inventory planned</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PRCD">Forecast method</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_SVEI">Multiple supply</param>
		/// <param name="m3_SSMT">Safety stock method</param>
		/// <param name="m3_SSDA">Safety stock unit</param>
		/// <param name="m3_SCGR">Service level</param>
		/// <param name="m3_OPOM">Reorder point method</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_SALE">Sales item</param>
		/// <param name="m3_CLDM">Clear demand</param>
		/// <param name="m3_CLOR">Clear order quantities</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangePLT(
			string m3_PLNT, 
			int? m3_CONO = null, 
			string m3_TX40 = null, 
			int? m3_GMSG = null, 
			int? m3_PUIT = null, 
			int? m3_DPID = null, 
			int? m3_OPLC = null, 
			string m3_PLCD = null, 
			int? m3_MSCH = null, 
			string m3_SCPO = null, 
			string m3_IPLA = null, 
			string m3_STAT = null, 
			int? m3_CONC = null, 
			string m3_ORTY = null, 
			string m3_PRCD = null, 
			string m3_FCCM = null, 
			int? m3_SVEI = null, 
			int? m3_SSMT = null, 
			int? m3_SSDA = null, 
			int? m3_SCGR = null, 
			int? m3_OPOM = null, 
			int? m3_EOQM = null, 
			int? m3_SALE = null, 
			int? m3_CLDM = null, 
			int? m3_CLOR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChangePLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PLNT))
				throw new ArgumentNullException("m3_PLNT");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLNT", m3_PLNT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_GMSG.HasValue)
				request.WithQueryParameter("GMSG", m3_GMSG.Value.ToString());
			if (m3_PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3_PUIT.Value.ToString());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (m3_OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3_OPLC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLCD))
				request.WithQueryParameter("PLCD", m3_PLCD.Trim());
			if (m3_MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3_MSCH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPO))
				request.WithQueryParameter("SCPO", m3_SCPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IPLA))
				request.WithQueryParameter("IPLA", m3_IPLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRCD))
				request.WithQueryParameter("PRCD", m3_PRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_SVEI.HasValue)
				request.WithQueryParameter("SVEI", m3_SVEI.Value.ToString());
			if (m3_SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3_SSMT.Value.ToString());
			if (m3_SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3_SSDA.Value.ToString());
			if (m3_SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3_SCGR.Value.ToString());
			if (m3_OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3_OPOM.Value.ToString());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_SALE.HasValue)
				request.WithQueryParameter("SALE", m3_SALE.Value.ToString());
			if (m3_CLDM.HasValue)
				request.WithQueryParameter("CLDM", m3_CLDM.Value.ToString());
			if (m3_CLOR.HasValue)
				request.WithQueryParameter("CLOR", m3_CLOR.Value.ToString());

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
		/// Name CopyPLT
		/// Description Copy planning template
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FRPL">Planning template (Required)</param>
		/// <param name="m3_TOPL">Planning template (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CopyPLT(
			string m3_FRPL, 
			string m3_TOPL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CopyPLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FRPL))
				throw new ArgumentNullException("m3_FRPL");
			if (string.IsNullOrWhiteSpace(m3_TOPL))
				throw new ArgumentNullException("m3_TOPL");

			// Set mandatory parameters
			request
				.WithQueryParameter("FRPL", m3_FRPL.Trim())
				.WithQueryParameter("TOPL", m3_TOPL.Trim());

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
		/// Name DeletePLT
		/// Description Delete planning template
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLNT">Planning template (Required)</param>
		/// <param name="m3_CONO">Company (NO FUNCTION)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeletePLT(
			string m3_PLNT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeletePLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PLNT))
				throw new ArgumentNullException("m3_PLNT");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLNT", m3_PLNT.Trim());

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
		/// Name ListPLT
		/// Description List planning templates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLNT">Planning template (Required)</param>
		/// <param name="m3_CONO">Company (NO FUNCTION)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListPLTResponse></returns>
		/// <exception cref="M3Exception<ListPLTResponse>"></exception>
		public async Task<M3Response<ListPLTResponse>> ListPLT(
			string m3_PLNT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListPLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PLNT))
				throw new ArgumentNullException("m3_PLNT");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLNT", m3_PLNT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<ListPLTResponse>(
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
