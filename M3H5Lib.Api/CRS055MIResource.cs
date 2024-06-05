/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS055MI;
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
	/// Name: CRS055MI
	/// Component Name: Currency
	/// Description: Currency interface
	/// Version Release: 5ea2
	///</summary>
	public partial class CRS055MIResource : M3BaseResourceEndpoint
	{
		public CRS055MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS055MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRate
		/// Description AddRate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CRTP">Exchange rate type (Required)</param>
		/// <param name="m3_CUTD">Rate date (Required)</param>
		/// <param name="m3_ARAT">Exchange rate (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddRateResponse></returns>
		/// <exception cref="M3Exception<AddRateResponse>"></exception>
		public async Task<M3Response<AddRateResponse>> AddRate(
			string m3_CUCD, 
			int m3_CRTP, 
			DateTime m3_CUTD, 
			decimal m3_ARAT, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("CRTP", m3_CRTP.ToString())
				.WithQueryParameter("CUTD", m3_CUTD.ToM3String())
				.WithQueryParameter("ARAT", m3_ARAT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<AddRateResponse>(
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
		/// Name GetBasicData
		/// Description Get Basic Data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3_CUCD, 
			string m3_DIVI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name LstRatesPerType
		/// Description Lists currency rates per rate type
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CRTP">Exchange rate type (Required)</param>
		/// <param name="m3_CUTD">Rate date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRatesPerTypeResponse></returns>
		/// <exception cref="M3Exception<LstRatesPerTypeResponse>"></exception>
		public async Task<M3Response<LstRatesPerTypeResponse>> LstRatesPerType(
			string m3_CUCD, 
			int m3_CRTP, 
			DateTime? m3_CUTD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRatesPerType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("CRTP", m3_CRTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CUTD.HasValue)
				request.WithQueryParameter("CUTD", m3_CUTD.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstRatesPerTypeResponse>(
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
		/// Name LstRtPerPeriod
		/// Description Lists currency rates per period
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CRTP">Exchange rate type (Required)</param>
		/// <param name="m3_FPER">From period (Required)</param>
		/// <param name="m3_TPER">To period (Required)</param>
		/// <param name="m3_DAYN">Day number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRtPerPeriodResponse></returns>
		/// <exception cref="M3Exception<LstRtPerPeriodResponse>"></exception>
		public async Task<M3Response<LstRtPerPeriodResponse>> LstRtPerPeriod(
			string m3_CUCD, 
			int m3_CRTP, 
			int m3_FPER, 
			int m3_TPER, 
			int m3_DAYN, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRtPerPeriod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("CRTP", m3_CRTP.ToString())
				.WithQueryParameter("FPER", m3_FPER.ToString())
				.WithQueryParameter("TPER", m3_TPER.ToString())
				.WithQueryParameter("DAYN", m3_DAYN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstRtPerPeriodResponse>(
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
		/// Name SelExchangeRate
		/// Description Select Currencies
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CRTP">Exchange rate type (Required)</param>
		/// <param name="m3_CUTD">Rate date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRDI">From division</param>
		/// <param name="m3_TODI">To division</param>
		/// <param name="m3_FCUR">From Currency</param>
		/// <param name="m3_TCUR">To Currency</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelExchangeRateResponse></returns>
		/// <exception cref="M3Exception<SelExchangeRateResponse>"></exception>
		public async Task<M3Response<SelExchangeRateResponse>> SelExchangeRate(
			int m3_CRTP, 
			DateTime m3_CUTD, 
			int? m3_CONO = null, 
			string m3_FRDI = null, 
			string m3_TODI = null, 
			string m3_FCUR = null, 
			string m3_TCUR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelExchangeRate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CRTP", m3_CRTP.ToString())
				.WithQueryParameter("CUTD", m3_CUTD.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRDI))
				request.WithQueryParameter("FRDI", m3_FRDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TODI))
				request.WithQueryParameter("TODI", m3_TODI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCUR))
				request.WithQueryParameter("FCUR", m3_FCUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCUR))
				request.WithQueryParameter("TCUR", m3_TCUR.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<SelExchangeRateResponse>(
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
