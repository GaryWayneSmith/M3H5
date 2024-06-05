/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPostalCode
		/// Description Add postal code
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3PONO">Postal code (Required)</param>
		/// <param name="m3CITY">City (Required)</param>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPostalCode(
			string m3PONO, 
			string m3CITY, 
			string m3CSCD, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPostalCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PONO))
				throw new ArgumentNullException(nameof(m3PONO));
			if (string.IsNullOrWhiteSpace(m3CITY))
				throw new ArgumentNullException(nameof(m3CITY));
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PONO", m3PONO.Trim())
				.WithQueryParameter("CITY", m3CITY.Trim())
				.WithQueryParameter("CSCD", m3CSCD.Trim());

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
		/// Name DelPostalCode
		/// Description Delete postal code
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3PONO">Postal code (Required)</param>
		/// <param name="m3CITY">City (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPostalCode(
			string m3CSCD, 
			string m3PONO, 
			string m3CITY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelPostalCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));
			if (string.IsNullOrWhiteSpace(m3PONO))
				throw new ArgumentNullException(nameof(m3PONO));
			if (string.IsNullOrWhiteSpace(m3CITY))
				throw new ArgumentNullException(nameof(m3CITY));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("PONO", m3PONO.Trim())
				.WithQueryParameter("CITY", m3CITY.Trim());

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
		/// Name LstCityByCode
		/// Description List city by postal code
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3PONO">Postal code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCityByCodeResponse></returns>
		/// <exception cref="M3Exception<LstCityByCodeResponse>"></exception>
		public async Task<M3Response<LstCityByCodeResponse>> LstCityByCode(
			string m3CSCD, 
			string m3PONO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCityByCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));
			if (string.IsNullOrWhiteSpace(m3PONO))
				throw new ArgumentNullException(nameof(m3PONO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("PONO", m3PONO.Trim());

			// Execute the request
			var result = await Execute<LstCityByCodeResponse>(
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
		/// Name LstPostalCodes
		/// Description List postal codes
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3CITY">City</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPostalCodesResponse></returns>
		/// <exception cref="M3Exception<LstPostalCodesResponse>"></exception>
		public async Task<M3Response<LstPostalCodesResponse>> LstPostalCodes(
			string m3CSCD = null, 
			string m3PONO = null, 
			string m3CITY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPostalCodes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CITY))
				request.WithQueryParameter("CITY", m3CITY.Trim());

			// Execute the request
			var result = await Execute<LstPostalCodesResponse>(
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
