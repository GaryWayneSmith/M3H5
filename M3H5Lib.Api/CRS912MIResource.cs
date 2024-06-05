/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSeason
		/// Description Add a new season
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3SEA1">Season (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3LVDT">Valid to (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3FOED">First order date</param>
		/// <param name="m3LOED">Last order entry date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSeason(
			string m3SEA1, 
			string m3TX40, 
			DateTime m3STDT, 
			DateTime m3LVDT, 
			string m3STAT, 
			string m3TX15 = null, 
			DateTime? m3FOED = null, 
			DateTime? m3LOED = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSeason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SEA1))
				throw new ArgumentNullException(nameof(m3SEA1));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("SEA1", m3SEA1.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("LVDT", m3LVDT.ToM3String())
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3FOED.HasValue)
				request.WithQueryParameter("FOED", m3FOED.Value.ToM3String());
			if (m3LOED.HasValue)
				request.WithQueryParameter("LOED", m3LOED.Value.ToM3String());

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
		/// Name DelSeason
		/// Description Delete a season
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3SEA1">Season (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSeason(
			string m3SEA1, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelSeason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SEA1))
				throw new ArgumentNullException(nameof(m3SEA1));

			// Set mandatory parameters
			request
				.WithQueryParameter("SEA1", m3SEA1.Trim());

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
		/// Name GetSeason
		/// Description Get details of a season
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3SEA1">Season (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSeasonResponse></returns>
		/// <exception cref="M3Exception<GetSeasonResponse>"></exception>
		public async Task<M3Response<GetSeasonResponse>> GetSeason(
			string m3SEA1, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSeason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SEA1))
				throw new ArgumentNullException(nameof(m3SEA1));

			// Set mandatory parameters
			request
				.WithQueryParameter("SEA1", m3SEA1.Trim());

			// Execute the request
			var result = await Execute<GetSeasonResponse>(
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
		/// Name LstSeason
		/// Description List seasons
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3SEA1">Season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSeasonResponse></returns>
		/// <exception cref="M3Exception<LstSeasonResponse>"></exception>
		public async Task<M3Response<LstSeasonResponse>> LstSeason(
			string m3SEA1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSeason",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SEA1))
				request.WithQueryParameter("SEA1", m3SEA1.Trim());

			// Execute the request
			var result = await Execute<LstSeasonResponse>(
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
		/// Name UpdSeason
		/// Description Update details of a season
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3SEA1">Season (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3FOED">First order date</param>
		/// <param name="m3LOED">Last order entry date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSeason(
			string m3SEA1, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			DateTime? m3STDT = null, 
			DateTime? m3LVDT = null, 
			string m3STAT = null, 
			DateTime? m3FOED = null, 
			DateTime? m3LOED = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSeason",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SEA1))
				throw new ArgumentNullException(nameof(m3SEA1));

			// Set mandatory parameters
			request
				.WithQueryParameter("SEA1", m3SEA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3FOED.HasValue)
				request.WithQueryParameter("FOED", m3FOED.Value.ToM3String());
			if (m3LOED.HasValue)
				request.WithQueryParameter("LOED", m3LOED.Value.ToM3String());

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
