/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS138MI;
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
	/// Name: CRS138MI
	/// Component Name: Geographical code - Tax rate
	/// Description: Api: Geographical code-Tax rate
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS138MIResource : M3BaseResourceEndpoint
	{
		public CRS138MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS138MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTaxRate
		/// Description Add a Geographical code - Tax rate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_GEOC">Geographical code (Required)</param>
		/// <param name="m3_TAXT">Tax type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TAA1">Limit amount 1</param>
		/// <param name="m3_TAR1">Tax rate 1</param>
		/// <param name="m3_TAD1">Limit type</param>
		/// <param name="m3_TXT1">Tax type</param>
		/// <param name="m3_TAA2">Limit amount 2</param>
		/// <param name="m3_TAR2">Tax rate 2</param>
		/// <param name="m3_TAD2">Limit type</param>
		/// <param name="m3_TXT2">Tax type</param>
		/// <param name="m3_TAA3">Limit amount 3</param>
		/// <param name="m3_TAR3">Tax rate 3</param>
		/// <param name="m3_TAD3">Limit type</param>
		/// <param name="m3_TXT3">Tax type</param>
		/// <param name="m3_TAA4">Limit amount 4</param>
		/// <param name="m3_TAR4">Tax rate 4</param>
		/// <param name="m3_TAD4">Limit type</param>
		/// <param name="m3_TXT4">Tax type</param>
		/// <param name="m3_TAA5">Limit amount 5</param>
		/// <param name="m3_TAR5">Tax rate 5</param>
		/// <param name="m3_TAD5">Limit type</param>
		/// <param name="m3_TXT5">Tax type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTaxRate(
			int m3_GEOC, 
			int m3_TAXT, 
			DateTime m3_FRDT, 
			string m3_STAT = null, 
			decimal? m3_TAA1 = null, 
			int? m3_TAR1 = null, 
			int? m3_TAD1 = null, 
			int? m3_TXT1 = null, 
			decimal? m3_TAA2 = null, 
			int? m3_TAR2 = null, 
			int? m3_TAD2 = null, 
			int? m3_TXT2 = null, 
			decimal? m3_TAA3 = null, 
			int? m3_TAR3 = null, 
			int? m3_TAD3 = null, 
			int? m3_TXT3 = null, 
			decimal? m3_TAA4 = null, 
			int? m3_TAR4 = null, 
			int? m3_TAD4 = null, 
			int? m3_TXT4 = null, 
			decimal? m3_TAA5 = null, 
			int? m3_TAR5 = null, 
			int? m3_TAD5 = null, 
			int? m3_TXT5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTaxRate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3_GEOC.ToString())
				.WithQueryParameter("TAXT", m3_TAXT.ToString())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_TAA1.HasValue)
				request.WithQueryParameter("TAA1", m3_TAA1.Value.ToString());
			if (m3_TAR1.HasValue)
				request.WithQueryParameter("TAR1", m3_TAR1.Value.ToString());
			if (m3_TAD1.HasValue)
				request.WithQueryParameter("TAD1", m3_TAD1.Value.ToString());
			if (m3_TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3_TXT1.Value.ToString());
			if (m3_TAA2.HasValue)
				request.WithQueryParameter("TAA2", m3_TAA2.Value.ToString());
			if (m3_TAR2.HasValue)
				request.WithQueryParameter("TAR2", m3_TAR2.Value.ToString());
			if (m3_TAD2.HasValue)
				request.WithQueryParameter("TAD2", m3_TAD2.Value.ToString());
			if (m3_TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3_TXT2.Value.ToString());
			if (m3_TAA3.HasValue)
				request.WithQueryParameter("TAA3", m3_TAA3.Value.ToString());
			if (m3_TAR3.HasValue)
				request.WithQueryParameter("TAR3", m3_TAR3.Value.ToString());
			if (m3_TAD3.HasValue)
				request.WithQueryParameter("TAD3", m3_TAD3.Value.ToString());
			if (m3_TXT3.HasValue)
				request.WithQueryParameter("TXT3", m3_TXT3.Value.ToString());
			if (m3_TAA4.HasValue)
				request.WithQueryParameter("TAA4", m3_TAA4.Value.ToString());
			if (m3_TAR4.HasValue)
				request.WithQueryParameter("TAR4", m3_TAR4.Value.ToString());
			if (m3_TAD4.HasValue)
				request.WithQueryParameter("TAD4", m3_TAD4.Value.ToString());
			if (m3_TXT4.HasValue)
				request.WithQueryParameter("TXT4", m3_TXT4.Value.ToString());
			if (m3_TAA5.HasValue)
				request.WithQueryParameter("TAA5", m3_TAA5.Value.ToString());
			if (m3_TAR5.HasValue)
				request.WithQueryParameter("TAR5", m3_TAR5.Value.ToString());
			if (m3_TAD5.HasValue)
				request.WithQueryParameter("TAD5", m3_TAD5.Value.ToString());
			if (m3_TXT5.HasValue)
				request.WithQueryParameter("TXT5", m3_TXT5.Value.ToString());

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
		/// Name DltTaxRate
		/// Description Delete a geographical code - Tax rate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_GEOC">Geographical code (Required)</param>
		/// <param name="m3_TAXT">Tax type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTaxRate(
			int m3_GEOC, 
			int m3_TAXT, 
			DateTime m3_FRDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltTaxRate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3_GEOC.ToString())
				.WithQueryParameter("TAXT", m3_TAXT.ToString())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

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
		/// Name GetTaxRate
		/// Description Get data for a Geographical code - Tax rate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_GEOC">Geographical code (Required)</param>
		/// <param name="m3_TAXT">Tax type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxRateResponse></returns>
		/// <exception cref="M3Exception<GetTaxRateResponse>"></exception>
		public async Task<M3Response<GetTaxRateResponse>> GetTaxRate(
			int m3_GEOC, 
			int m3_TAXT, 
			DateTime m3_FRDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxRate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3_GEOC.ToString())
				.WithQueryParameter("TAXT", m3_TAXT.ToString())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Execute the request
			var result = await Execute<GetTaxRateResponse>(
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
		/// Name LstTaxRates
		/// Description List data for Geographical codes - Tax rates
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TAXT">Tax type</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxRatesResponse></returns>
		/// <exception cref="M3Exception<LstTaxRatesResponse>"></exception>
		public async Task<M3Response<LstTaxRatesResponse>> LstTaxRates(
			int? m3_GEOC = null, 
			int? m3_TAXT = null, 
			DateTime? m3_FRDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTaxRates",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (m3_TAXT.HasValue)
				request.WithQueryParameter("TAXT", m3_TAXT.Value.ToString());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstTaxRatesResponse>(
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
		/// Name UpdTaxRate
		/// Description Update data for a Geographical code Tax rate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_GEOC">Geographical code (Required)</param>
		/// <param name="m3_TAXT">Tax type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TAA1">Limit amount 1</param>
		/// <param name="m3_TAR1">Tax rate 1</param>
		/// <param name="m3_TAD1">Limit type</param>
		/// <param name="m3_TXT1">Tax type</param>
		/// <param name="m3_TAA2">Limit amount 2</param>
		/// <param name="m3_TAR2">Tax rate 2</param>
		/// <param name="m3_TAD2">Limit type</param>
		/// <param name="m3_TXT2">Tax type</param>
		/// <param name="m3_TAA3">Limit amount 3</param>
		/// <param name="m3_TAR3">Tax rate 3</param>
		/// <param name="m3_TAD3">Limit type</param>
		/// <param name="m3_TXT3">Tax type</param>
		/// <param name="m3_TAA4">Limit amount 4</param>
		/// <param name="m3_TAR4">Tax rate 4</param>
		/// <param name="m3_TAD4">Limit type</param>
		/// <param name="m3_TXT4">Tax type</param>
		/// <param name="m3_TAA5">Limit amount 5</param>
		/// <param name="m3_TAR5">Tax rate 5</param>
		/// <param name="m3_TAD5">Limit type</param>
		/// <param name="m3_TXT5">Tax type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTaxRate(
			int m3_GEOC, 
			int m3_TAXT, 
			DateTime m3_FRDT, 
			string m3_STAT = null, 
			decimal? m3_TAA1 = null, 
			int? m3_TAR1 = null, 
			int? m3_TAD1 = null, 
			int? m3_TXT1 = null, 
			decimal? m3_TAA2 = null, 
			int? m3_TAR2 = null, 
			int? m3_TAD2 = null, 
			int? m3_TXT2 = null, 
			decimal? m3_TAA3 = null, 
			int? m3_TAR3 = null, 
			int? m3_TAD3 = null, 
			int? m3_TXT3 = null, 
			decimal? m3_TAA4 = null, 
			int? m3_TAR4 = null, 
			int? m3_TAD4 = null, 
			int? m3_TXT4 = null, 
			decimal? m3_TAA5 = null, 
			int? m3_TAR5 = null, 
			int? m3_TAD5 = null, 
			int? m3_TXT5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTaxRate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3_GEOC.ToString())
				.WithQueryParameter("TAXT", m3_TAXT.ToString())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_TAA1.HasValue)
				request.WithQueryParameter("TAA1", m3_TAA1.Value.ToString());
			if (m3_TAR1.HasValue)
				request.WithQueryParameter("TAR1", m3_TAR1.Value.ToString());
			if (m3_TAD1.HasValue)
				request.WithQueryParameter("TAD1", m3_TAD1.Value.ToString());
			if (m3_TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3_TXT1.Value.ToString());
			if (m3_TAA2.HasValue)
				request.WithQueryParameter("TAA2", m3_TAA2.Value.ToString());
			if (m3_TAR2.HasValue)
				request.WithQueryParameter("TAR2", m3_TAR2.Value.ToString());
			if (m3_TAD2.HasValue)
				request.WithQueryParameter("TAD2", m3_TAD2.Value.ToString());
			if (m3_TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3_TXT2.Value.ToString());
			if (m3_TAA3.HasValue)
				request.WithQueryParameter("TAA3", m3_TAA3.Value.ToString());
			if (m3_TAR3.HasValue)
				request.WithQueryParameter("TAR3", m3_TAR3.Value.ToString());
			if (m3_TAD3.HasValue)
				request.WithQueryParameter("TAD3", m3_TAD3.Value.ToString());
			if (m3_TXT3.HasValue)
				request.WithQueryParameter("TXT3", m3_TXT3.Value.ToString());
			if (m3_TAA4.HasValue)
				request.WithQueryParameter("TAA4", m3_TAA4.Value.ToString());
			if (m3_TAR4.HasValue)
				request.WithQueryParameter("TAR4", m3_TAR4.Value.ToString());
			if (m3_TAD4.HasValue)
				request.WithQueryParameter("TAD4", m3_TAD4.Value.ToString());
			if (m3_TXT4.HasValue)
				request.WithQueryParameter("TXT4", m3_TXT4.Value.ToString());
			if (m3_TAA5.HasValue)
				request.WithQueryParameter("TAA5", m3_TAA5.Value.ToString());
			if (m3_TAR5.HasValue)
				request.WithQueryParameter("TAR5", m3_TAR5.Value.ToString());
			if (m3_TAD5.HasValue)
				request.WithQueryParameter("TAD5", m3_TAD5.Value.ToString());
			if (m3_TXT5.HasValue)
				request.WithQueryParameter("TXT5", m3_TXT5.Value.ToString());

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
