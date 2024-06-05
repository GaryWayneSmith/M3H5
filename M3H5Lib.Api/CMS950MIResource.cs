/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS950MI;
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
	/// Name: CMS950MI
	/// Component Name: Migration program
	/// Description: Db Update Manager
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS950MIResource : M3BaseResourceEndpoint
	{
		public CMS950MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS950MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DltProgram
		/// Description Delete a program
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltProgram(
			string m3_PGNM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim());

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
		/// Name GenPrograms
		/// Description Generate Programs
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FRVE">From version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> GenPrograms(
			int m3_FRVE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GenPrograms",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("FRVE", m3_FRVE.ToString());

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
		/// Name GetProgram
		/// Description Get data for a program
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetProgramResponse></returns>
		/// <exception cref="M3Exception<GetProgramResponse>"></exception>
		public async Task<M3Response<GetProgramResponse>> GetProgram(
			string m3_PGNM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim());

			// Execute the request
			var result = await Execute<GetProgramResponse>(
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
		/// Name LstPrograms
		/// Description LstPrograms
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_BEVE">Version</param>
		/// <param name="m3_SYCO">System component</param>
		/// <param name="m3_MIST">Migration status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProgramsResponse></returns>
		/// <exception cref="M3Exception<LstProgramsResponse>"></exception>
		public async Task<M3Response<LstProgramsResponse>> LstPrograms(
			int? m3_BEVE = null, 
			string m3_SYCO = null, 
			string m3_MIST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPrograms",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_BEVE.HasValue)
				request.WithQueryParameter("BEVE", m3_BEVE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SYCO))
				request.WithQueryParameter("SYCO", m3_SYCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MIST))
				request.WithQueryParameter("MIST", m3_MIST.Trim());

			// Execute the request
			var result = await Execute<LstProgramsResponse>(
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
		/// Name RunAllPrograms
		/// Description Run all programs in a business engine version
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_BEVE">Business engine version (Required)</param>
		/// <param name="m3_SYNC">Synchronous execution</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RunAllPrograms(
			int m3_BEVE, 
			int? m3_SYNC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RunAllPrograms",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("BEVE", m3_BEVE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SYNC.HasValue)
				request.WithQueryParameter("SYNC", m3_SYNC.Value.ToString());

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
		/// Name RunProgram
		/// Description Run a program
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RunProgram(
			string m3_PGNM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RunProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim());

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
		/// Name SetStatus
		/// Description SetStatus
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CRMIST">Current Migration status (Required)</param>
		/// <param name="m3_NWMIST">New Migration status (Required)</param>
		/// <param name="m3_BEVE">Version</param>
		/// <param name="m3_SYCO">System component</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetStatus(
			string m3_CRMIST, 
			string m3_NWMIST, 
			int? m3_BEVE = null, 
			string m3_SYCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CRMIST))
				throw new ArgumentNullException("m3_CRMIST");
			if (string.IsNullOrWhiteSpace(m3_NWMIST))
				throw new ArgumentNullException("m3_NWMIST");

			// Set mandatory parameters
			request
				.WithQueryParameter("CRMIST", m3_CRMIST.Trim())
				.WithQueryParameter("NWMIST", m3_NWMIST.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_BEVE.HasValue)
				request.WithQueryParameter("BEVE", m3_BEVE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SYCO))
				request.WithQueryParameter("SYCO", m3_SYCO.Trim());

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
		/// Name UpdProgram
		/// Description Update data for a program
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_SQCE">Sequence number</param>
		/// <param name="m3_MIST">Migration status</param>
		/// <param name="m3_MLOG">Migration log</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdProgram(
			string m3_PGNM, 
			int? m3_SQCE = null, 
			string m3_MIST = null, 
			int? m3_MLOG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SQCE.HasValue)
				request.WithQueryParameter("SQCE", m3_SQCE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MIST))
				request.WithQueryParameter("MIST", m3_MIST.Trim());
			if (m3_MLOG.HasValue)
				request.WithQueryParameter("MLOG", m3_MLOG.Value.ToString());

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
