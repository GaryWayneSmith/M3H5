/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTaxRate
		/// Description Add a Geographical code - Tax rate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3GEOC">Geographical code (Required)</param>
		/// <param name="m3TAXT">Tax type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TAA1">Limit amount 1</param>
		/// <param name="m3TAR1">Tax rate 1</param>
		/// <param name="m3TAD1">Limit type</param>
		/// <param name="m3TXT1">Tax type</param>
		/// <param name="m3TAA2">Limit amount 2</param>
		/// <param name="m3TAR2">Tax rate 2</param>
		/// <param name="m3TAD2">Limit type</param>
		/// <param name="m3TXT2">Tax type</param>
		/// <param name="m3TAA3">Limit amount 3</param>
		/// <param name="m3TAR3">Tax rate 3</param>
		/// <param name="m3TAD3">Limit type</param>
		/// <param name="m3TXT3">Tax type</param>
		/// <param name="m3TAA4">Limit amount 4</param>
		/// <param name="m3TAR4">Tax rate 4</param>
		/// <param name="m3TAD4">Limit type</param>
		/// <param name="m3TXT4">Tax type</param>
		/// <param name="m3TAA5">Limit amount 5</param>
		/// <param name="m3TAR5">Tax rate 5</param>
		/// <param name="m3TAD5">Limit type</param>
		/// <param name="m3TXT5">Tax type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTaxRate(
			int m3GEOC, 
			int m3TAXT, 
			DateTime m3FRDT, 
			string m3STAT = null, 
			decimal? m3TAA1 = null, 
			int? m3TAR1 = null, 
			int? m3TAD1 = null, 
			int? m3TXT1 = null, 
			decimal? m3TAA2 = null, 
			int? m3TAR2 = null, 
			int? m3TAD2 = null, 
			int? m3TXT2 = null, 
			decimal? m3TAA3 = null, 
			int? m3TAR3 = null, 
			int? m3TAD3 = null, 
			int? m3TXT3 = null, 
			decimal? m3TAA4 = null, 
			int? m3TAR4 = null, 
			int? m3TAD4 = null, 
			int? m3TXT4 = null, 
			decimal? m3TAA5 = null, 
			int? m3TAR5 = null, 
			int? m3TAD5 = null, 
			int? m3TXT5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddTaxRate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3GEOC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TAXT", m3TAXT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TAA1.HasValue)
				request.WithQueryParameter("TAA1", m3TAA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAR1.HasValue)
				request.WithQueryParameter("TAR1", m3TAR1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAD1.HasValue)
				request.WithQueryParameter("TAD1", m3TAD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3TXT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAA2.HasValue)
				request.WithQueryParameter("TAA2", m3TAA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAR2.HasValue)
				request.WithQueryParameter("TAR2", m3TAR2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAD2.HasValue)
				request.WithQueryParameter("TAD2", m3TAD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3TXT2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAA3.HasValue)
				request.WithQueryParameter("TAA3", m3TAA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAR3.HasValue)
				request.WithQueryParameter("TAR3", m3TAR3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAD3.HasValue)
				request.WithQueryParameter("TAD3", m3TAD3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT3.HasValue)
				request.WithQueryParameter("TXT3", m3TXT3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAA4.HasValue)
				request.WithQueryParameter("TAA4", m3TAA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAR4.HasValue)
				request.WithQueryParameter("TAR4", m3TAR4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAD4.HasValue)
				request.WithQueryParameter("TAD4", m3TAD4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT4.HasValue)
				request.WithQueryParameter("TXT4", m3TXT4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAA5.HasValue)
				request.WithQueryParameter("TAA5", m3TAA5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAR5.HasValue)
				request.WithQueryParameter("TAR5", m3TAR5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAD5.HasValue)
				request.WithQueryParameter("TAD5", m3TAD5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT5.HasValue)
				request.WithQueryParameter("TXT5", m3TXT5.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltTaxRate
		/// Description Delete a geographical code - Tax rate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3GEOC">Geographical code (Required)</param>
		/// <param name="m3TAXT">Tax type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTaxRate(
			int m3GEOC, 
			int m3TAXT, 
			DateTime m3FRDT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltTaxRate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3GEOC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TAXT", m3TAXT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

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
		/// Name GetTaxRate
		/// Description Get data for a Geographical code - Tax rate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3GEOC">Geographical code (Required)</param>
		/// <param name="m3TAXT">Tax type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxRateResponse></returns>
		/// <exception cref="M3Exception<GetTaxRateResponse>"></exception>
		public async Task<M3Response<GetTaxRateResponse>> GetTaxRate(
			int m3GEOC, 
			int m3TAXT, 
			DateTime m3FRDT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetTaxRate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3GEOC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TAXT", m3TAXT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Execute the request
			var result = await Execute<GetTaxRateResponse>(
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
		/// Name LstTaxRates
		/// Description List data for Geographical codes - Tax rates
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TAXT">Tax type</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxRatesResponse></returns>
		/// <exception cref="M3Exception<LstTaxRatesResponse>"></exception>
		public async Task<M3Response<LstTaxRatesResponse>> LstTaxRates(
			int? m3GEOC = null, 
			int? m3TAXT = null, 
			DateTime? m3FRDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTaxRates",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAXT.HasValue)
				request.WithQueryParameter("TAXT", m3TAXT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstTaxRatesResponse>(
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
		/// Name UpdTaxRate
		/// Description Update data for a Geographical code Tax rate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3GEOC">Geographical code (Required)</param>
		/// <param name="m3TAXT">Tax type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TAA1">Limit amount 1</param>
		/// <param name="m3TAR1">Tax rate 1</param>
		/// <param name="m3TAD1">Limit type</param>
		/// <param name="m3TXT1">Tax type</param>
		/// <param name="m3TAA2">Limit amount 2</param>
		/// <param name="m3TAR2">Tax rate 2</param>
		/// <param name="m3TAD2">Limit type</param>
		/// <param name="m3TXT2">Tax type</param>
		/// <param name="m3TAA3">Limit amount 3</param>
		/// <param name="m3TAR3">Tax rate 3</param>
		/// <param name="m3TAD3">Limit type</param>
		/// <param name="m3TXT3">Tax type</param>
		/// <param name="m3TAA4">Limit amount 4</param>
		/// <param name="m3TAR4">Tax rate 4</param>
		/// <param name="m3TAD4">Limit type</param>
		/// <param name="m3TXT4">Tax type</param>
		/// <param name="m3TAA5">Limit amount 5</param>
		/// <param name="m3TAR5">Tax rate 5</param>
		/// <param name="m3TAD5">Limit type</param>
		/// <param name="m3TXT5">Tax type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTaxRate(
			int m3GEOC, 
			int m3TAXT, 
			DateTime m3FRDT, 
			string m3STAT = null, 
			decimal? m3TAA1 = null, 
			int? m3TAR1 = null, 
			int? m3TAD1 = null, 
			int? m3TXT1 = null, 
			decimal? m3TAA2 = null, 
			int? m3TAR2 = null, 
			int? m3TAD2 = null, 
			int? m3TXT2 = null, 
			decimal? m3TAA3 = null, 
			int? m3TAR3 = null, 
			int? m3TAD3 = null, 
			int? m3TXT3 = null, 
			decimal? m3TAA4 = null, 
			int? m3TAR4 = null, 
			int? m3TAD4 = null, 
			int? m3TXT4 = null, 
			decimal? m3TAA5 = null, 
			int? m3TAR5 = null, 
			int? m3TAD5 = null, 
			int? m3TXT5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdTaxRate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3GEOC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TAXT", m3TAXT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TAA1.HasValue)
				request.WithQueryParameter("TAA1", m3TAA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAR1.HasValue)
				request.WithQueryParameter("TAR1", m3TAR1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAD1.HasValue)
				request.WithQueryParameter("TAD1", m3TAD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3TXT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAA2.HasValue)
				request.WithQueryParameter("TAA2", m3TAA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAR2.HasValue)
				request.WithQueryParameter("TAR2", m3TAR2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAD2.HasValue)
				request.WithQueryParameter("TAD2", m3TAD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3TXT2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAA3.HasValue)
				request.WithQueryParameter("TAA3", m3TAA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAR3.HasValue)
				request.WithQueryParameter("TAR3", m3TAR3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAD3.HasValue)
				request.WithQueryParameter("TAD3", m3TAD3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT3.HasValue)
				request.WithQueryParameter("TXT3", m3TXT3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAA4.HasValue)
				request.WithQueryParameter("TAA4", m3TAA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAR4.HasValue)
				request.WithQueryParameter("TAR4", m3TAR4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAD4.HasValue)
				request.WithQueryParameter("TAD4", m3TAD4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT4.HasValue)
				request.WithQueryParameter("TXT4", m3TXT4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAA5.HasValue)
				request.WithQueryParameter("TAA5", m3TAA5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAR5.HasValue)
				request.WithQueryParameter("TAR5", m3TAR5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TAD5.HasValue)
				request.WithQueryParameter("TAD5", m3TAD5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT5.HasValue)
				request.WithQueryParameter("TXT5", m3TXT5.Value.ToString(CultureInfo.CurrentCulture));

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
