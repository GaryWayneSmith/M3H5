/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DltProgram
		/// Description Delete a program
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltProgram(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim());

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
		/// Name GenPrograms
		/// Description Generate Programs
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FRVE">From version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> GenPrograms(
			int m3FRVE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GenPrograms",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("FRVE", m3FRVE.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetProgram
		/// Description Get data for a program
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetProgramResponse></returns>
		/// <exception cref="M3Exception<GetProgramResponse>"></exception>
		public async Task<M3Response<GetProgramResponse>> GetProgram(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim());

			// Execute the request
			var result = await Execute<GetProgramResponse>(
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
		/// Name LstPrograms
		/// Description LstPrograms
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3BEVE">Version</param>
		/// <param name="m3SYCO">System component</param>
		/// <param name="m3MIST">Migration status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProgramsResponse></returns>
		/// <exception cref="M3Exception<LstProgramsResponse>"></exception>
		public async Task<M3Response<LstProgramsResponse>> LstPrograms(
			int? m3BEVE = null, 
			string m3SYCO = null, 
			string m3MIST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPrograms",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3BEVE.HasValue)
				request.WithQueryParameter("BEVE", m3BEVE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SYCO))
				request.WithQueryParameter("SYCO", m3SYCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MIST))
				request.WithQueryParameter("MIST", m3MIST.Trim());

			// Execute the request
			var result = await Execute<LstProgramsResponse>(
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
		/// Name RunAllPrograms
		/// Description Run all programs in a business engine version
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3BEVE">Business engine version (Required)</param>
		/// <param name="m3SYNC">Synchronous execution</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RunAllPrograms(
			int m3BEVE, 
			int? m3SYNC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RunAllPrograms",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("BEVE", m3BEVE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3SYNC.HasValue)
				request.WithQueryParameter("SYNC", m3SYNC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name RunProgram
		/// Description Run a program
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RunProgram(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RunProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim());

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
		/// Name SetStatus
		/// Description SetStatus
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CRMIST">Current Migration status (Required)</param>
		/// <param name="m3NWMIST">New Migration status (Required)</param>
		/// <param name="m3BEVE">Version</param>
		/// <param name="m3SYCO">System component</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetStatus(
			string m3CRMIST, 
			string m3NWMIST, 
			int? m3BEVE = null, 
			string m3SYCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CRMIST))
				throw new ArgumentNullException(nameof(m3CRMIST));
			if (string.IsNullOrWhiteSpace(m3NWMIST))
				throw new ArgumentNullException(nameof(m3NWMIST));

			// Set mandatory parameters
			request
				.WithQueryParameter("CRMIST", m3CRMIST.Trim())
				.WithQueryParameter("NWMIST", m3NWMIST.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3BEVE.HasValue)
				request.WithQueryParameter("BEVE", m3BEVE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SYCO))
				request.WithQueryParameter("SYCO", m3SYCO.Trim());

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
		/// Name UpdProgram
		/// Description Update data for a program
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3SQCE">Sequence number</param>
		/// <param name="m3MIST">Migration status</param>
		/// <param name="m3MLOG">Migration log</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdProgram(
			string m3PGNM, 
			int? m3SQCE = null, 
			string m3MIST = null, 
			int? m3MLOG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3SQCE.HasValue)
				request.WithQueryParameter("SQCE", m3SQCE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MIST))
				request.WithQueryParameter("MIST", m3MIST.Trim());
			if (m3MLOG.HasValue)
				request.WithQueryParameter("MLOG", m3MLOG.Value.ToString(CultureInfo.CurrentCulture));

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
