/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRate
		/// Description AddRate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CRTP">Exchange rate type (Required)</param>
		/// <param name="m3CUTD">Rate date (Required)</param>
		/// <param name="m3ARAT">Exchange rate (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddRateResponse></returns>
		/// <exception cref="M3Exception<AddRateResponse>"></exception>
		public async Task<M3Response<AddRateResponse>> AddRate(
			string m3CUCD, 
			int m3CRTP, 
			DateTime m3CUTD, 
			decimal m3ARAT, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddRate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("CRTP", m3CRTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUTD", m3CUTD.ToM3String())
				.WithQueryParameter("ARAT", m3ARAT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<AddRateResponse>(
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
		/// Name GetBasicData
		/// Description Get Basic Data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3CUCD, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name LstRatesPerType
		/// Description Lists currency rates per rate type
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CRTP">Exchange rate type (Required)</param>
		/// <param name="m3CUTD">Rate date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRatesPerTypeResponse></returns>
		/// <exception cref="M3Exception<LstRatesPerTypeResponse>"></exception>
		public async Task<M3Response<LstRatesPerTypeResponse>> LstRatesPerType(
			string m3CUCD, 
			int m3CRTP, 
			DateTime? m3CUTD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRatesPerType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("CRTP", m3CRTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CUTD.HasValue)
				request.WithQueryParameter("CUTD", m3CUTD.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstRatesPerTypeResponse>(
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
		/// Name LstRtPerPeriod
		/// Description Lists currency rates per period
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CRTP">Exchange rate type (Required)</param>
		/// <param name="m3FPER">From period (Required)</param>
		/// <param name="m3TPER">To period (Required)</param>
		/// <param name="m3DAYN">Day number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRtPerPeriodResponse></returns>
		/// <exception cref="M3Exception<LstRtPerPeriodResponse>"></exception>
		public async Task<M3Response<LstRtPerPeriodResponse>> LstRtPerPeriod(
			string m3CUCD, 
			int m3CRTP, 
			int m3FPER, 
			int m3TPER, 
			int m3DAYN, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRtPerPeriod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("CRTP", m3CRTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FPER", m3FPER.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPER", m3TPER.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DAYN", m3DAYN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstRtPerPeriodResponse>(
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
		/// Name SelExchangeRate
		/// Description Select Currencies
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CRTP">Exchange rate type (Required)</param>
		/// <param name="m3CUTD">Rate date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRDI">From division</param>
		/// <param name="m3TODI">To division</param>
		/// <param name="m3FCUR">From Currency</param>
		/// <param name="m3TCUR">To Currency</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelExchangeRateResponse></returns>
		/// <exception cref="M3Exception<SelExchangeRateResponse>"></exception>
		public async Task<M3Response<SelExchangeRateResponse>> SelExchangeRate(
			int m3CRTP, 
			DateTime m3CUTD, 
			int? m3CONO = null, 
			string m3FRDI = null, 
			string m3TODI = null, 
			string m3FCUR = null, 
			string m3TCUR = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelExchangeRate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CRTP", m3CRTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUTD", m3CUTD.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRDI))
				request.WithQueryParameter("FRDI", m3FRDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TODI))
				request.WithQueryParameter("TODI", m3TODI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCUR))
				request.WithQueryParameter("FCUR", m3FCUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCUR))
				request.WithQueryParameter("TCUR", m3TCUR.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelExchangeRateResponse>(
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
