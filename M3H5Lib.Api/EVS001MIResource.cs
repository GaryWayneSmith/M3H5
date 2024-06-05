/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.EVS001MI;
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
	/// Name: EVS001MI
	/// Component Name: EnvironmentInterface
	/// Description: Api: Environment
	/// Version Release: 5ea2
	///</summary>
	public partial class EVS001MIResource : M3BaseResourceEndpoint
	{
		public EVS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "EVS001MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetBEVersion
		/// Description Get the version of Business Engine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBEVersionResponse></returns>
		/// <exception cref="M3Exception<GetBEVersionResponse>"></exception>
		public async Task<M3Response<GetBEVersionResponse>> GetBEVersion(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBEVersion",
			};

			// Execute the request
			var result = await Execute<GetBEVersionResponse>(
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
		/// Name GetBJobStatus
		/// Description Get Batch Job Status
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3BJNO">Job number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBJobStatusResponse></returns>
		/// <exception cref="M3Exception<GetBJobStatusResponse>"></exception>
		public async Task<M3Response<GetBJobStatusResponse>> GetBJobStatus(
			string m3BJNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBJobStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BJNO))
				throw new ArgumentNullException(nameof(m3BJNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BJNO", m3BJNO.Trim());

			// Execute the request
			var result = await Execute<GetBJobStatusResponse>(
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
		/// Name GetFieldInfo
		/// Description Info for a specific table and field
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3FLNA">Field name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldInfoResponse></returns>
		/// <exception cref="M3Exception<GetFieldInfoResponse>"></exception>
		public async Task<M3Response<GetFieldInfoResponse>> GetFieldInfo(
			string m3FILE, 
			string m3FLNA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFieldInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLNA))
				throw new ArgumentNullException(nameof(m3FLNA));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLNA", m3FLNA.Trim());

			// Execute the request
			var result = await Execute<GetFieldInfoResponse>(
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
		/// Name GetLogFile
		/// Description Initiation transaction for retrieving a log file as a Blob.
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FILE">Name of log file (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> GetLogFile(
			string m3FILE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLogFile",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

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
		/// Name LstCallStack
		/// Description List a jobs current call stack
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3UUID">Program UUID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCallStackResponse></returns>
		/// <exception cref="M3Exception<LstCallStackResponse>"></exception>
		public async Task<M3Response<LstCallStackResponse>> LstCallStack(
			string m3UUID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCallStack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3UUID))
				throw new ArgumentNullException(nameof(m3UUID));

			// Set mandatory parameters
			request
				.WithQueryParameter("UUID", m3UUID.Trim());

			// Execute the request
			var result = await Execute<LstCallStackResponse>(
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
		/// Name LstConcepts
		/// Description List all available concepts for logging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConceptsResponse></returns>
		/// <exception cref="M3Exception<LstConceptsResponse>"></exception>
		public async Task<M3Response<LstConceptsResponse>> LstConcepts(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstConcepts",
			};

			// Execute the request
			var result = await Execute<LstConceptsResponse>(
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
		/// Name LstFieldInfo
		/// Description Retrieve field info for a table
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldInfoResponse></returns>
		/// <exception cref="M3Exception<LstFieldInfoResponse>"></exception>
		public async Task<M3Response<LstFieldInfoResponse>> LstFieldInfo(
			string m3FILE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFieldInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<LstFieldInfoResponse>(
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
		/// Name LstFixLevels
		/// Description List all fixes
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFixLevelsResponse></returns>
		/// <exception cref="M3Exception<LstFixLevelsResponse>"></exception>
		public async Task<M3Response<LstFixLevelsResponse>> LstFixLevels(
			string m3PGNM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFixLevels",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim());

			// Execute the request
			var result = await Execute<LstFixLevelsResponse>(
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
		/// Name LstLFFields
		/// Description List logical file fields
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3INDX">File index number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLFFieldsResponse></returns>
		/// <exception cref="M3Exception<LstLFFieldsResponse>"></exception>
		public async Task<M3Response<LstLFFieldsResponse>> LstLFFields(
			string m3FILE, 
			string m3INDX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLFFields",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3INDX))
				throw new ArgumentNullException(nameof(m3INDX));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("INDX", m3INDX.Trim());

			// Execute the request
			var result = await Execute<LstLFFieldsResponse>(
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
		/// Name LstLogFiles
		/// Description Directory listing of available log files
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRFX">Optional prefix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLogFilesResponse></returns>
		/// <exception cref="M3Exception<LstLogFilesResponse>"></exception>
		public async Task<M3Response<LstLogFilesResponse>> LstLogFiles(
			string m3PRFX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLogFiles",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFX))
				request.WithQueryParameter("PRFX", m3PRFX.Trim());

			// Execute the request
			var result = await Execute<LstLogFilesResponse>(
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
		/// Name LstLogicalFiles
		/// Description LstLogicalFiles
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">Physical file name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLogicalFilesResponse></returns>
		/// <exception cref="M3Exception<LstLogicalFilesResponse>"></exception>
		public async Task<M3Response<LstLogicalFilesResponse>> LstLogicalFiles(
			string m3FILE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLogicalFiles",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<LstLogicalFilesResponse>(
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
		/// Name LstTables
		/// Description List physical files
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTablesResponse></returns>
		/// <exception cref="M3Exception<LstTablesResponse>"></exception>
		public async Task<M3Response<LstTablesResponse>> LstTables(
			string m3FILE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTables",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<LstTablesResponse>(
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
		/// Name LstTraceUsers
		/// Description List users currently having active traces
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTraceUsersResponse></returns>
		/// <exception cref="M3Exception<LstTraceUsersResponse>"></exception>
		public async Task<M3Response<LstTraceUsersResponse>> LstTraceUsers(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTraceUsers",
			};

			// Execute the request
			var result = await Execute<LstTraceUsersResponse>(
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
		/// Name LstUserJobs
		/// Description List current user jobs
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUserJobsResponse></returns>
		/// <exception cref="M3Exception<LstUserJobsResponse>"></exception>
		public async Task<M3Response<LstUserJobsResponse>> LstUserJobs(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstUserJobs",
			};

			// Execute the request
			var result = await Execute<LstUserJobsResponse>(
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
		/// Name LstVariables
		/// Description List a programs variables
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3UUID">Program UUID (Required)</param>
		/// <param name="m3JSID">Job Stack ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVariablesResponse></returns>
		/// <exception cref="M3Exception<LstVariablesResponse>"></exception>
		public async Task<M3Response<LstVariablesResponse>> LstVariables(
			string m3UUID, 
			decimal m3JSID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstVariables",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3UUID))
				throw new ArgumentNullException(nameof(m3UUID));

			// Set mandatory parameters
			request
				.WithQueryParameter("UUID", m3UUID.Trim())
				.WithQueryParameter("JSID", m3JSID.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstVariablesResponse>(
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
		/// Name RtvLogFile
		/// Description Retrieve a log file as a list function
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FILE">Name of log file (Required)</param>
		/// <param name="m3LINE">Line number from where to begin listing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvLogFileResponse></returns>
		/// <exception cref="M3Exception<RtvLogFileResponse>"></exception>
		public async Task<M3Response<RtvLogFileResponse>> RtvLogFile(
			string m3FILE, 
			int? m3LINE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RtvLogFile",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LINE.HasValue)
				request.WithQueryParameter("LINE", m3LINE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<RtvLogFileResponse>(
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
		/// Name StartConceptLog
		/// Description Starts concept for specific job
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3UUID">Job UUID (Required)</param>
		/// <param name="m3CONC">Concept name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StartConceptLogResponse></returns>
		/// <exception cref="M3Exception<StartConceptLogResponse>"></exception>
		public async Task<M3Response<StartConceptLogResponse>> StartConceptLog(
			string m3UUID, 
			string m3CONC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartConceptLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3UUID))
				throw new ArgumentNullException(nameof(m3UUID));
			if (string.IsNullOrWhiteSpace(m3CONC))
				throw new ArgumentNullException(nameof(m3CONC));

			// Set mandatory parameters
			request
				.WithQueryParameter("UUID", m3UUID.Trim())
				.WithQueryParameter("CONC", m3CONC.Trim());

			// Execute the request
			var result = await Execute<StartConceptLogResponse>(
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
		/// Name StartDynaTrace
		/// Description Starts dynamic tracing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3UUID">Job UUID (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3EQMT">Equals match (Required)</param>
		/// <param name="m3CHKF">Check after flag (Required)</param>
		/// <param name="m3MATC">Match variable</param>
		/// <param name="m3MTVL">Match value</param>
		/// <param name="m3DISP">Display variable</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StartDynaTraceResponse></returns>
		/// <exception cref="M3Exception<StartDynaTraceResponse>"></exception>
		public async Task<M3Response<StartDynaTraceResponse>> StartDynaTrace(
			string m3UUID, 
			string m3STAT, 
			int m3EQMT, 
			int m3CHKF, 
			string m3MATC = null, 
			string m3MTVL = null, 
			string m3DISP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartDynaTrace",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3UUID))
				throw new ArgumentNullException(nameof(m3UUID));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("UUID", m3UUID.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("EQMT", m3EQMT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CHKF", m3CHKF.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MATC))
				request.WithQueryParameter("MATC", m3MATC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTVL))
				request.WithQueryParameter("MTVL", m3MTVL.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISP))
				request.WithQueryParameter("DISP", m3DISP.Trim());

			// Execute the request
			var result = await Execute<StartDynaTraceResponse>(
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
		/// Name StartFineTrace
		/// Description Starts trace for specific job and current user.
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3UUID">Job UUID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StartFineTraceResponse></returns>
		/// <exception cref="M3Exception<StartFineTraceResponse>"></exception>
		public async Task<M3Response<StartFineTraceResponse>> StartFineTrace(
			string m3UUID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartFineTrace",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3UUID))
				throw new ArgumentNullException(nameof(m3UUID));

			// Set mandatory parameters
			request
				.WithQueryParameter("UUID", m3UUID.Trim());

			// Execute the request
			var result = await Execute<StartFineTraceResponse>(
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
		/// Name StartTraceUser
		/// Description Start trace for specified user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartTraceUser(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartTraceUser",
			};

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
		/// Name StopConceptLog
		/// Description Stop concept for specific job
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3UUID">Job UUID (Required)</param>
		/// <param name="m3CONC">Concept name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StopConceptLogResponse></returns>
		/// <exception cref="M3Exception<StopConceptLogResponse>"></exception>
		public async Task<M3Response<StopConceptLogResponse>> StopConceptLog(
			string m3UUID, 
			string m3CONC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopConceptLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3UUID))
				throw new ArgumentNullException(nameof(m3UUID));
			if (string.IsNullOrWhiteSpace(m3CONC))
				throw new ArgumentNullException(nameof(m3CONC));

			// Set mandatory parameters
			request
				.WithQueryParameter("UUID", m3UUID.Trim())
				.WithQueryParameter("CONC", m3CONC.Trim());

			// Execute the request
			var result = await Execute<StopConceptLogResponse>(
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
		/// Name StopDynaTrace
		/// Description Stop dynamic trace for specific job
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3UUID">Job UUID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StopDynaTraceResponse></returns>
		/// <exception cref="M3Exception<StopDynaTraceResponse>"></exception>
		public async Task<M3Response<StopDynaTraceResponse>> StopDynaTrace(
			string m3UUID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopDynaTrace",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3UUID))
				throw new ArgumentNullException(nameof(m3UUID));

			// Set mandatory parameters
			request
				.WithQueryParameter("UUID", m3UUID.Trim());

			// Execute the request
			var result = await Execute<StopDynaTraceResponse>(
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
		/// Name StopFineTrace
		/// Description Stop trace for specific job and current user.
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3UUID">Job UUID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StopFineTraceResponse></returns>
		/// <exception cref="M3Exception<StopFineTraceResponse>"></exception>
		public async Task<M3Response<StopFineTraceResponse>> StopFineTrace(
			string m3UUID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopFineTrace",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3UUID))
				throw new ArgumentNullException(nameof(m3UUID));

			// Set mandatory parameters
			request
				.WithQueryParameter("UUID", m3UUID.Trim());

			// Execute the request
			var result = await Execute<StopFineTraceResponse>(
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
		/// Name StopTraceUser
		/// Description Stop user trace
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopTraceUser(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopTraceUser",
			};

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
