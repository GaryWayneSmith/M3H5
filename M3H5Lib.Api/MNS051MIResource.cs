/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MNS051MI;
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
	/// Name: MNS051MI
	/// Component Name: Manage Subsystem job
	/// Description: Manage Subsystem job
	/// Version Release: 5ea0
	///</summary>
	public partial class MNS051MIResource : M3BaseResourceEndpoint
	{
		public MNS051MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS051MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Adds a subsystem job
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SBSD">New field description (Required)</param>
		/// <param name="m3_JOB">Job (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_PGM">Program name</param>
		/// <param name="m3_DLY">Delay auto job</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_DFCO">Company</param>
		/// <param name="m3_DFDI">Division</param>
		/// <param name="m3_LANC">System language</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_SBSD, 
			string m3_JOB, 
			string m3_STAT = null, 
			string m3_TX40 = null, 
			string m3_PGM = null, 
			int? m3_DLY = null, 
			string m3_FILE = null, 
			int? m3_DFCO = null, 
			string m3_DFDI = null, 
			string m3_LANC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBSD))
				throw new ArgumentNullException("m3_SBSD");
			if (string.IsNullOrWhiteSpace(m3_JOB))
				throw new ArgumentNullException("m3_JOB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBSD", m3_SBSD.Trim())
				.WithQueryParameter("JOB", m3_JOB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PGM))
				request.WithQueryParameter("PGM", m3_PGM.Trim());
			if (m3_DLY.HasValue)
				request.WithQueryParameter("DLY", m3_DLY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (m3_DFCO.HasValue)
				request.WithQueryParameter("DFCO", m3_DFCO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DFDI))
				request.WithQueryParameter("DFDI", m3_DFDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LANC))
				request.WithQueryParameter("LANC", m3_LANC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

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
		/// Name AddNewInstance
		/// Description AddNewInstance
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SBSD">Subsystem description (Required)</param>
		/// <param name="m3_JOB">Job (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddNewInstance(
			string m3_SBSD, 
			string m3_JOB, 
			int m3_SQNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddNewInstance",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBSD))
				throw new ArgumentNullException("m3_SBSD");
			if (string.IsNullOrWhiteSpace(m3_JOB))
				throw new ArgumentNullException("m3_JOB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBSD", m3_SBSD.Trim())
				.WithQueryParameter("JOB", m3_JOB.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

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
		/// Name CrtStandard
		/// Description CrtStandard
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CrtStandard(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtStandard",
			};

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
		/// Name Dlt
		/// Description Deletes a subsystem job
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SBSD">Subsystem description (Required)</param>
		/// <param name="m3_JOB">Job (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_SBSD, 
			string m3_JOB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBSD))
				throw new ArgumentNullException("m3_SBSD");
			if (string.IsNullOrWhiteSpace(m3_JOB))
				throw new ArgumentNullException("m3_JOB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBSD", m3_SBSD.Trim())
				.WithQueryParameter("JOB", m3_JOB.Trim());

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
		/// Name EndAll
		/// Description EndAll
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> EndAll(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/EndAll",
			};

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
		/// Name EndJob
		/// Description EndJob
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_JOB">Job (Required)</param>
		/// <param name="m3_SBSD">Subsystem description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> EndJob(
			string m3_JOB, 
			string m3_SBSD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/EndJob",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_JOB))
				throw new ArgumentNullException("m3_JOB");

			// Set mandatory parameters
			request
				.WithQueryParameter("JOB", m3_JOB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SBSD))
				request.WithQueryParameter("SBSD", m3_SBSD.Trim());

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
		/// Name Get
		/// Description Gets data for a subsystem job
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SBSD">Subsystem description (Required)</param>
		/// <param name="m3_JOB">Job (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_SBSD, 
			string m3_JOB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBSD))
				throw new ArgumentNullException("m3_SBSD");
			if (string.IsNullOrWhiteSpace(m3_JOB))
				throw new ArgumentNullException("m3_JOB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBSD", m3_SBSD.Trim())
				.WithQueryParameter("JOB", m3_JOB.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetJobQueue
		/// Description Gets data for a subsystem job queue
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SBSD">Subsystem description (Required)</param>
		/// <param name="m3_JOB">Job (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetJobQueueResponse></returns>
		/// <exception cref="M3Exception<GetJobQueueResponse>"></exception>
		public async Task<M3Response<GetJobQueueResponse>> GetJobQueue(
			string m3_SBSD, 
			string m3_JOB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetJobQueue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBSD))
				throw new ArgumentNullException("m3_SBSD");
			if (string.IsNullOrWhiteSpace(m3_JOB))
				throw new ArgumentNullException("m3_JOB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBSD", m3_SBSD.Trim())
				.WithQueryParameter("JOB", m3_JOB.Trim());

			// Execute the request
			var result = await Execute<GetJobQueueResponse>(
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
		/// Name Lst
		/// Description List data for subsystem job
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SBSD">Subsystem description (Required)</param>
		/// <param name="m3_JOB">Job</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_SBSD, 
			string m3_JOB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBSD))
				throw new ArgumentNullException("m3_SBSD");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBSD", m3_SBSD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_JOB))
				request.WithQueryParameter("JOB", m3_JOB.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name LstActJob
		/// Description List data for an active subsystem job
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SBSD">Subsystem description (Required)</param>
		/// <param name="m3_JOB">Job</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstActJobResponse></returns>
		/// <exception cref="M3Exception<LstActJobResponse>"></exception>
		public async Task<M3Response<LstActJobResponse>> LstActJob(
			string m3_SBSD, 
			string m3_JOB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstActJob",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBSD))
				throw new ArgumentNullException("m3_SBSD");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBSD", m3_SBSD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_JOB))
				request.WithQueryParameter("JOB", m3_JOB.Trim());

			// Execute the request
			var result = await Execute<LstActJobResponse>(
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
		/// Name LstJobQueues
		/// Description List job queues
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SBSD">Subsystem description (Required)</param>
		/// <param name="m3_JOB">Job</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstJobQueuesResponse></returns>
		/// <exception cref="M3Exception<LstJobQueuesResponse>"></exception>
		public async Task<M3Response<LstJobQueuesResponse>> LstJobQueues(
			string m3_SBSD, 
			string m3_JOB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstJobQueues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBSD))
				throw new ArgumentNullException("m3_SBSD");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBSD", m3_SBSD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_JOB))
				request.WithQueryParameter("JOB", m3_JOB.Trim());

			// Execute the request
			var result = await Execute<LstJobQueuesResponse>(
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
		/// Name LstNoneActJob
		/// Description List data for a none active subsystem job
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SBSD">Subsystem description (Required)</param>
		/// <param name="m3_JOB">Job</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNoneActJobResponse></returns>
		/// <exception cref="M3Exception<LstNoneActJobResponse>"></exception>
		public async Task<M3Response<LstNoneActJobResponse>> LstNoneActJob(
			string m3_SBSD, 
			string m3_JOB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNoneActJob",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBSD))
				throw new ArgumentNullException("m3_SBSD");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBSD", m3_SBSD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_JOB))
				request.WithQueryParameter("JOB", m3_JOB.Trim());

			// Execute the request
			var result = await Execute<LstNoneActJobResponse>(
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
		/// Name StartAll
		/// Description StartAll
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartAll(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartAll",
			};

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
		/// Name StartJob
		/// Description StartJob
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_JOB">Job (Required)</param>
		/// <param name="m3_SBSD">Subsystem description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartJob(
			string m3_JOB, 
			string m3_SBSD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartJob",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_JOB))
				throw new ArgumentNullException("m3_JOB");

			// Set mandatory parameters
			request
				.WithQueryParameter("JOB", m3_JOB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SBSD))
				request.WithQueryParameter("SBSD", m3_SBSD.Trim());

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
		/// Name Upd
		/// Description Update data for a subsystem job
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SBSD">Subsystem description (Required)</param>
		/// <param name="m3_JOB">Job (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PGM">Program name</param>
		/// <param name="m3_DLY">Delay auto job</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_DFCO">Company</param>
		/// <param name="m3_DFDI">Division</param>
		/// <param name="m3_LANC">System language</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_SBSD, 
			string m3_JOB, 
			string m3_TX40 = null, 
			string m3_STAT = null, 
			string m3_PGM = null, 
			int? m3_DLY = null, 
			string m3_FILE = null, 
			int? m3_DFCO = null, 
			string m3_DFDI = null, 
			string m3_LANC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBSD))
				throw new ArgumentNullException("m3_SBSD");
			if (string.IsNullOrWhiteSpace(m3_JOB))
				throw new ArgumentNullException("m3_JOB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBSD", m3_SBSD.Trim())
				.WithQueryParameter("JOB", m3_JOB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PGM))
				request.WithQueryParameter("PGM", m3_PGM.Trim());
			if (m3_DLY.HasValue)
				request.WithQueryParameter("DLY", m3_DLY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (m3_DFCO.HasValue)
				request.WithQueryParameter("DFCO", m3_DFCO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DFDI))
				request.WithQueryParameter("DFDI", m3_DFDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LANC))
				request.WithQueryParameter("LANC", m3_LANC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

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
