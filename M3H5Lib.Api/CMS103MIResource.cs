/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS103MI;
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
	/// Name: CMS103MI
	/// Component Name: Fin Reason
	/// Description: Finance reason code
	/// Version Release: 5ea1
	///</summary>
	public partial class CMS103MIResource : M3BaseResourceEndpoint
	{
		public CMS103MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS103MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFinReason
		/// Description Add Finance reason
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FRSC">Finance Reason Code (Required)</param>
		/// <param name="m3_RTPF">Reason type (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFinReason(
			string m3_FRSC, 
			int m3_RTPF, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFinReason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FRSC))
				throw new ArgumentNullException("m3_FRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FRSC", m3_FRSC.Trim())
				.WithQueryParameter("RTPF", m3_RTPF.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());

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
		/// Name AddFinRsnText
		/// Description AddFinRsnText
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FRSC">Finance reason code (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_PARM">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFinRsnText(
			string m3_FRSC, 
			string m3_LNCD = null, 
			string m3_TXVR = null, 
			string m3_PARM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFinRsnText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FRSC))
				throw new ArgumentNullException("m3_FRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FRSC", m3_FRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PARM))
				request.WithQueryParameter("PARM", m3_PARM.Trim());

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
		/// Name DltFinReason
		/// Description Delete Finance reason
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FRSC">Finance Reason Code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFinReason(
			string m3_FRSC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltFinReason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FRSC))
				throw new ArgumentNullException("m3_FRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FRSC", m3_FRSC.Trim());

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
		/// Name GetFinReason
		/// Description Get Finance reason
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FRSC">Finance Reason Code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFinReasonResponse></returns>
		/// <exception cref="M3Exception<GetFinReasonResponse>"></exception>
		public async Task<M3Response<GetFinReasonResponse>> GetFinReason(
			string m3_FRSC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFinReason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FRSC))
				throw new ArgumentNullException("m3_FRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FRSC", m3_FRSC.Trim());

			// Execute the request
			var result = await Execute<GetFinReasonResponse>(
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
		/// Name GetFinRsnText
		/// Description GetFinRsnText
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FRSC">Finance reason code (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TYTX">Type of text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFinRsnTextResponse></returns>
		/// <exception cref="M3Exception<GetFinRsnTextResponse>"></exception>
		public async Task<M3Response<GetFinRsnTextResponse>> GetFinRsnText(
			string m3_FRSC, 
			string m3_LNCD = null, 
			string m3_TYTX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFinRsnText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FRSC))
				throw new ArgumentNullException("m3_FRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FRSC", m3_FRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TYTX))
				request.WithQueryParameter("TYTX", m3_TYTX.Trim());

			// Execute the request
			var result = await Execute<GetFinRsnTextResponse>(
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
		/// Name LstFinReason
		/// Description List finance reason
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FRSC">Finance Reason Code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFinReasonResponse></returns>
		/// <exception cref="M3Exception<LstFinReasonResponse>"></exception>
		public async Task<M3Response<LstFinReasonResponse>> LstFinReason(
			string m3_FRSC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFinReason",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FRSC))
				request.WithQueryParameter("FRSC", m3_FRSC.Trim());

			// Execute the request
			var result = await Execute<LstFinReasonResponse>(
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
		/// Name UpdFinReason
		/// Description Upd finance reason
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FRSC">Finance Reason Code</param>
		/// <param name="m3_RTPF">Reason type</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdFinReason(
			string m3_FRSC = null, 
			int? m3_RTPF = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdFinReason",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FRSC))
				request.WithQueryParameter("FRSC", m3_FRSC.Trim());
			if (m3_RTPF.HasValue)
				request.WithQueryParameter("RTPF", m3_RTPF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());

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
