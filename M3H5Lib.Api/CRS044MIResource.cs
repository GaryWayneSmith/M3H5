/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS044MI;
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
	/// Name: CRS044MI
	/// Component Name: Postal codes
	/// Description: Postal codes interface
	/// Version Release: 15.x
	///</summary>
	public partial class CRS044MIResource : M3BaseResourceEndpoint
	{
		public CRS044MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS044MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPostalCode
		/// Description Add postal code
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_PONO">Postal code (Required)</param>
		/// <param name="m3_CITY">City (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPostalCode(
			string m3_PONO, 
			string m3_CITY, 
			string m3_CSCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPostalCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PONO))
				throw new ArgumentNullException("m3_PONO");
			if (string.IsNullOrWhiteSpace(m3_CITY))
				throw new ArgumentNullException("m3_CITY");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PONO", m3_PONO.Trim())
				.WithQueryParameter("CITY", m3_CITY.Trim())
				.WithQueryParameter("CSCD", m3_CSCD.Trim());

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
		/// Name DelPostalCode
		/// Description Delete postal code
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_PONO">Postal code (Required)</param>
		/// <param name="m3_CITY">City (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPostalCode(
			string m3_CSCD, 
			string m3_PONO, 
			string m3_CITY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPostalCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_PONO))
				throw new ArgumentNullException("m3_PONO");
			if (string.IsNullOrWhiteSpace(m3_CITY))
				throw new ArgumentNullException("m3_CITY");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("PONO", m3_PONO.Trim())
				.WithQueryParameter("CITY", m3_CITY.Trim());

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
		/// Name LstCityByCode
		/// Description List city by postal code
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_PONO">Postal code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCityByCodeResponse></returns>
		/// <exception cref="M3Exception<LstCityByCodeResponse>"></exception>
		public async Task<M3Response<LstCityByCodeResponse>> LstCityByCode(
			string m3_CSCD, 
			string m3_PONO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCityByCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_PONO))
				throw new ArgumentNullException("m3_PONO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("PONO", m3_PONO.Trim());

			// Execute the request
			var result = await Execute<LstCityByCodeResponse>(
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
		/// Name LstPostalCodes
		/// Description List postal codes
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_CITY">City</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPostalCodesResponse></returns>
		/// <exception cref="M3Exception<LstPostalCodesResponse>"></exception>
		public async Task<M3Response<LstPostalCodesResponse>> LstPostalCodes(
			string m3_CSCD = null, 
			string m3_PONO = null, 
			string m3_CITY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPostalCodes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CITY))
				request.WithQueryParameter("CITY", m3_CITY.Trim());

			// Execute the request
			var result = await Execute<LstPostalCodesResponse>(
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
