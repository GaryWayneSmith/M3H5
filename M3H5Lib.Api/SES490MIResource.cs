/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetErrorLog
		/// Description GetErrorLog
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ESID">Esign number (Required)</param>
		/// <param name="m3SQNU">Sequence number (Required)</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetErrorLogResponse></returns>
		/// <exception cref="M3Exception<GetErrorLogResponse>"></exception>
		public async Task<M3Response<GetErrorLogResponse>> GetErrorLog(
			string m3ESID, 
			int m3SQNU, 
			string m3FLDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetErrorLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ESID))
				throw new ArgumentNullException(nameof(m3ESID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ESID", m3ESID.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<GetErrorLogResponse>(
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
		/// Name LstErrorLogs
		/// Description LstErrorLogs
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ESID">Esign number</param>
		/// <param name="m3SQNU">Sequence number</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrorLogsResponse></returns>
		/// <exception cref="M3Exception<LstErrorLogsResponse>"></exception>
		public async Task<M3Response<LstErrorLogsResponse>> LstErrorLogs(
			string m3ESID = null, 
			int? m3SQNU = null, 
			string m3FLDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstErrorLogs",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ESID))
				request.WithQueryParameter("ESID", m3ESID.Trim());
			if (m3SQNU.HasValue)
				request.WithQueryParameter("SQNU", m3SQNU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<LstErrorLogsResponse>(
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
