/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SHS010MI;
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
	/// Name: SHS010MI
	/// Component Name: Job
	/// Description: Job scheduler
	/// Version Release: 5ea0
	///</summary>
	public partial class SHS010MIResource : M3BaseResourceEndpoint
	{
		public SHS010MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SHS010MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DltExternalJob
		/// Description Delete external job
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_JSEI">Job scheduler external id</param>
		/// <param name="m3_BJNO">Job number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltExternalJob(
			string m3_JSEI = null, 
			string m3_BJNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltExternalJob",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_JSEI))
				request.WithQueryParameter("JSEI", m3_JSEI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BJNO))
				request.WithQueryParameter("BJNO", m3_BJNO.Trim());

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
		/// Name ExecuteJob
		/// Description Execute external job
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_JSEI">Job scheduler external id (Required)</param>
		/// <param name="m3_RAGI">Run again</param>
		/// <param name="m3_SGDT">Schedule date</param>
		/// <param name="m3_SGTM">Schedule time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ExecuteJobResponse></returns>
		/// <exception cref="M3Exception<ExecuteJobResponse>"></exception>
		public async Task<M3Response<ExecuteJobResponse>> ExecuteJob(
			string m3_JSEI, 
			int? m3_RAGI = null, 
			DateTime? m3_SGDT = null, 
			int? m3_SGTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ExecuteJob",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_JSEI))
				throw new ArgumentNullException("m3_JSEI");

			// Set mandatory parameters
			request
				.WithQueryParameter("JSEI", m3_JSEI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RAGI.HasValue)
				request.WithQueryParameter("RAGI", m3_RAGI.Value.ToString());
			if (m3_SGDT.HasValue)
				request.WithQueryParameter("SGDT", m3_SGDT.Value.ToM3String());
			if (m3_SGTM.HasValue)
				request.WithQueryParameter("SGTM", m3_SGTM.Value.ToString());

			// Execute the request
			var result = await Execute<ExecuteJobResponse>(
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
		/// Name GetExternalJob
		/// Description Get external job information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_JSEI">Job scheduler external id</param>
		/// <param name="m3_BJNO">Job number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetExternalJobResponse></returns>
		/// <exception cref="M3Exception<GetExternalJobResponse>"></exception>
		public async Task<M3Response<GetExternalJobResponse>> GetExternalJob(
			string m3_JSEI = null, 
			string m3_BJNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetExternalJob",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_JSEI))
				request.WithQueryParameter("JSEI", m3_JSEI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BJNO))
				request.WithQueryParameter("BJNO", m3_BJNO.Trim());

			// Execute the request
			var result = await Execute<GetExternalJobResponse>(
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
		/// Name LstExtJobs
		/// Description List External Jobs
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program name</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExtJobsResponse></returns>
		/// <exception cref="M3Exception<LstExtJobsResponse>"></exception>
		public async Task<M3Response<LstExtJobsResponse>> LstExtJobs(
			string m3_PGNM = null, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExtJobs",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<LstExtJobsResponse>(
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
