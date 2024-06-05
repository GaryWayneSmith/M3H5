/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS912MI;
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
	/// Name: CRS912MI
	/// Component Name: Season
	/// Description: Season
	/// Version Release: 13.1
	///</summary>
	public partial class CRS912MIResource : M3BaseResourceEndpoint
	{
		public CRS912MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS912MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSeason
		/// Description Add a new season
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_SEA1">Season (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_LVDT">Valid to (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_FOED">First order date</param>
		/// <param name="m3_LOED">Last order entry date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSeason(
			string m3_SEA1, 
			string m3_TX40, 
			DateTime m3_STDT, 
			DateTime m3_LVDT, 
			string m3_STAT, 
			string m3_TX15 = null, 
			DateTime? m3_FOED = null, 
			DateTime? m3_LOED = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSeason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SEA1))
				throw new ArgumentNullException("m3_SEA1");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("SEA1", m3_SEA1.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("LVDT", m3_LVDT.ToM3String())
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_FOED.HasValue)
				request.WithQueryParameter("FOED", m3_FOED.Value.ToM3String());
			if (m3_LOED.HasValue)
				request.WithQueryParameter("LOED", m3_LOED.Value.ToM3String());

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
		/// Name DelSeason
		/// Description Delete a season
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_SEA1">Season (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSeason(
			string m3_SEA1, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelSeason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SEA1))
				throw new ArgumentNullException("m3_SEA1");

			// Set mandatory parameters
			request
				.WithQueryParameter("SEA1", m3_SEA1.Trim());

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
		/// Name GetSeason
		/// Description Get details of a season
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_SEA1">Season (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSeasonResponse></returns>
		/// <exception cref="M3Exception<GetSeasonResponse>"></exception>
		public async Task<M3Response<GetSeasonResponse>> GetSeason(
			string m3_SEA1, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSeason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SEA1))
				throw new ArgumentNullException("m3_SEA1");

			// Set mandatory parameters
			request
				.WithQueryParameter("SEA1", m3_SEA1.Trim());

			// Execute the request
			var result = await Execute<GetSeasonResponse>(
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
		/// Name LstSeason
		/// Description List seasons
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSeasonResponse></returns>
		/// <exception cref="M3Exception<LstSeasonResponse>"></exception>
		public async Task<M3Response<LstSeasonResponse>> LstSeason(
			string m3_SEA1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSeason",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());

			// Execute the request
			var result = await Execute<LstSeasonResponse>(
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
		/// Name UpdSeason
		/// Description Update details of a season
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_SEA1">Season (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_FOED">First order date</param>
		/// <param name="m3_LOED">Last order entry date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSeason(
			string m3_SEA1, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_STAT = null, 
			DateTime? m3_FOED = null, 
			DateTime? m3_LOED = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSeason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SEA1))
				throw new ArgumentNullException("m3_SEA1");

			// Set mandatory parameters
			request
				.WithQueryParameter("SEA1", m3_SEA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_FOED.HasValue)
				request.WithQueryParameter("FOED", m3_FOED.Value.ToM3String());
			if (m3_LOED.HasValue)
				request.WithQueryParameter("LOED", m3_LOED.Value.ToM3String());

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
