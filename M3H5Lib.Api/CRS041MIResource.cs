/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS041MI;
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
	/// Name: CRS041MI
	/// Component Name: AdditionalCountryCode
	/// Description: Additional country code
	/// Version Release: 14.x
	///</summary>
	public partial class CRS041MIResource : M3BaseResourceEndpoint
	{
		public CRS041MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS041MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAddCountry
		/// Description Add additional country code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_ADCC">Additional country code (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddCountry(
			string m3_BSCD, 
			string m3_CSCD, 
			string m3_ADCC, 
			string m3_TX40, 
			string m3_TX15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAddCountry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_ADCC))
				throw new ArgumentNullException("m3_ADCC");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("ADCC", m3_ADCC.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());

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
		/// Name DltAddCountry
		/// Description Delete additional country code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_ADCC">Additional country code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAddCountry(
			string m3_BSCD, 
			string m3_CSCD, 
			string m3_ADCC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAddCountry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_ADCC))
				throw new ArgumentNullException("m3_ADCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("ADCC", m3_ADCC.Trim());

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
		/// Name GetAddCountry
		/// Description Get additional country code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_ADCC">Additional country code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddCountryResponse></returns>
		/// <exception cref="M3Exception<GetAddCountryResponse>"></exception>
		public async Task<M3Response<GetAddCountryResponse>> GetAddCountry(
			string m3_BSCD, 
			string m3_CSCD, 
			string m3_ADCC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddCountry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_ADCC))
				throw new ArgumentNullException("m3_ADCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("ADCC", m3_ADCC.Trim());

			// Execute the request
			var result = await Execute<GetAddCountryResponse>(
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
		/// Name LstAddCountry
		/// Description List additional cpuntry code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddCountryResponse></returns>
		/// <exception cref="M3Exception<LstAddCountryResponse>"></exception>
		public async Task<M3Response<LstAddCountryResponse>> LstAddCountry(
			string m3_BSCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAddCountry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim());

			// Execute the request
			var result = await Execute<LstAddCountryResponse>(
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
		/// Name UpdAddCountry
		/// Description Update additional country code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_ADCC">Additional country code (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAddCountry(
			string m3_BSCD, 
			string m3_CSCD, 
			string m3_ADCC, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAddCountry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_ADCC))
				throw new ArgumentNullException("m3_ADCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("ADCC", m3_ADCC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());

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
