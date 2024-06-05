/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SES490MI;
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
	/// Name: SES490MI
	/// Component Name: eSign Error Log
	/// Description: eSign Error Log Interface
	/// Version Release: 5ea0
	///</summary>
	public partial class SES490MIResource : M3BaseResourceEndpoint
	{
		public SES490MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SES490MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetErrorLog
		/// Description GetErrorLog
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ESID">Esign number (Required)</param>
		/// <param name="m3_SQNU">Sequence number (Required)</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetErrorLogResponse></returns>
		/// <exception cref="M3Exception<GetErrorLogResponse>"></exception>
		public async Task<M3Response<GetErrorLogResponse>> GetErrorLog(
			string m3_ESID, 
			int m3_SQNU, 
			string m3_FLDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetErrorLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ESID))
				throw new ArgumentNullException("m3_ESID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ESID", m3_ESID.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Execute the request
			var result = await Execute<GetErrorLogResponse>(
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
		/// Name LstErrorLogs
		/// Description LstErrorLogs
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ESID">Esign number</param>
		/// <param name="m3_SQNU">Sequence number</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrorLogsResponse></returns>
		/// <exception cref="M3Exception<LstErrorLogsResponse>"></exception>
		public async Task<M3Response<LstErrorLogsResponse>> LstErrorLogs(
			string m3_ESID = null, 
			int? m3_SQNU = null, 
			string m3_FLDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstErrorLogs",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ESID))
				request.WithQueryParameter("ESID", m3_ESID.Trim());
			if (m3_SQNU.HasValue)
				request.WithQueryParameter("SQNU", m3_SQNU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Execute the request
			var result = await Execute<LstErrorLogsResponse>(
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
