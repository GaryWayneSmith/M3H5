/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS045MI;
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
	/// Name: CRS045MI
	/// Component Name: Country
	/// Description: Country interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS045MIResource : M3BaseResourceEndpoint
	{
		public CRS045MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS045MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetBasicData
		/// Description Retrieve country information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3_CSCD, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3_CSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name LstByCode
		/// Description List country information by country code
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCodeResponse></returns>
		/// <exception cref="M3Exception<LstByCodeResponse>"></exception>
		public async Task<M3Response<LstByCodeResponse>> LstByCode(
			int? m3_CONO = null, 
			string m3_CSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByCode",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());

			// Execute the request
			var result = await Execute<LstByCodeResponse>(
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
		/// Name LstCountry
		/// Description List country information by country code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRCD">From Country code</param>
		/// <param name="m3_TOCD">To Country code</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCountryResponse></returns>
		/// <exception cref="M3Exception<LstCountryResponse>"></exception>
		public async Task<M3Response<LstCountryResponse>> LstCountry(
			int? m3_CONO = null, 
			string m3_FRCD = null, 
			string m3_TOCD = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCountry",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRCD))
				request.WithQueryParameter("FRCD", m3_FRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCD))
				request.WithQueryParameter("TOCD", m3_TOCD.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstCountryResponse>(
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
		/// Name LstCountryArea
		/// Description List country information by country code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCountryAreaResponse></returns>
		/// <exception cref="M3Exception<LstCountryAreaResponse>"></exception>
		public async Task<M3Response<LstCountryAreaResponse>> LstCountryArea(
			int? m3_CONO = null, 
			string m3_CSCD = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCountryArea",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstCountryAreaResponse>(
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
