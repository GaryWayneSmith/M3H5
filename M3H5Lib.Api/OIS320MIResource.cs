/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.OIS320MI;
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
	/// Name: OIS320MI
	/// Component Name: PriceDiscount
	/// Description: Price and discount inquiry interface
	/// Version Release: 5ea2
	///</summary>
	public partial class OIS320MIResource : M3BaseResourceEndpoint
	{
		public OIS320MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS320MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPriceLine
		/// Description Get item price for a orderline
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse location</param>
		/// <param name="m3ORDT">Order date</param>
		/// <param name="m3ORQA">Ordered quantity</param>
		/// <param name="m3ALUN">Alternate unit of measurement</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ORTP">Order type</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3CFXX">Old CFIN</param>
		/// <param name="m3CAMA">Calculate markups</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3PLTB">Price list table</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3ATV6">Attribute value - display field 6</param>
		/// <param name="m3ATV7">Attribute value - display field 7</param>
		/// <param name="m3ATV8">Attribute value - display field 8</param>
		/// <param name="m3ATV9">Attribute value - display field 9</param>
		/// <param name="m3ATV0">Attribute value - display field 10</param>
		/// <param name="m3CHL1">Business chain - level 1</param>
		/// <param name="m3CHL2">Business chain - level 2</param>
		/// <param name="m3CHL3">Business chain - level 3</param>
		/// <param name="m3CHL4">Business chain - level 4</param>
		/// <param name="m3SPUN">Sales price unit of measure</param>
		/// <param name="m3PRMS">Price origin sequence</param>
		/// <param name="m3PISQ">Price in Sales Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPriceLineResponse></returns>
		/// <exception cref="M3Exception<GetPriceLineResponse>"></exception>
		public async Task<M3Response<GetPriceLineResponse>> GetPriceLine(
			string m3CUNO, 
			string m3ITNO, 
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			DateTime? m3ORDT = null, 
			decimal? m3ORQA = null, 
			string m3ALUN = null, 
			string m3CUCD = null, 
			string m3ORTP = null, 
			string m3PRRF = null, 
			string m3DISY = null, 
			DateTime? m3DWDT = null, 
			int? m3CFXX = null, 
			int? m3CAMA = null, 
			decimal? m3ATNR = null, 
			string m3PLTB = null, 
			long? m3CFIN = null, 
			string m3ATV6 = null, 
			string m3ATV7 = null, 
			string m3ATV8 = null, 
			string m3ATV9 = null, 
			string m3ATV0 = null, 
			string m3CHL1 = null, 
			string m3CHL2 = null, 
			string m3CHL3 = null, 
			string m3CHL4 = null, 
			string m3SPUN = null, 
			string m3PRMS = null, 
			int? m3PISQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPriceLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3ORDT.Value.ToM3String());
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (m3CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3CFXX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAMA.HasValue)
				request.WithQueryParameter("CAMA", m3CAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLTB))
				request.WithQueryParameter("PLTB", m3PLTB.Trim());
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATV6))
				request.WithQueryParameter("ATV6", m3ATV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATV7))
				request.WithQueryParameter("ATV7", m3ATV7.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATV8))
				request.WithQueryParameter("ATV8", m3ATV8.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATV9))
				request.WithQueryParameter("ATV9", m3ATV9.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATV0))
				request.WithQueryParameter("ATV0", m3ATV0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL1))
				request.WithQueryParameter("CHL1", m3CHL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL2))
				request.WithQueryParameter("CHL2", m3CHL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL3))
				request.WithQueryParameter("CHL3", m3CHL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL4))
				request.WithQueryParameter("CHL4", m3CHL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRMS))
				request.WithQueryParameter("PRMS", m3PRMS.Trim());
			if (m3PISQ.HasValue)
				request.WithQueryParameter("PISQ", m3PISQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPriceLineResponse>(
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
		/// Name LstDiscModels
		/// Description List discount models
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDiscModelsResponse></returns>
		/// <exception cref="M3Exception<LstDiscModelsResponse>"></exception>
		public async Task<M3Response<LstDiscModelsResponse>> LstDiscModels(
			int? m3CONO = null, 
			string m3DISY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDiscModels",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());

			// Execute the request
			var result = await Execute<LstDiscModelsResponse>(
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
		/// Name LstDiscNumbers
		/// Description List discount model numbers
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DISY">Discount model (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDiscNumbersResponse></returns>
		/// <exception cref="M3Exception<LstDiscNumbersResponse>"></exception>
		public async Task<M3Response<LstDiscNumbersResponse>> LstDiscNumbers(
			string m3DISY, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDiscNumbers",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DISY))
				throw new ArgumentNullException(nameof(m3DISY));

			// Set mandatory parameters
			request
				.WithQueryParameter("DISY", m3DISY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDiscNumbersResponse>(
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
		/// Name LstListPrices
		/// Description List price list details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRRF">Pricelist</param>
		/// <param name="m3CUCD">Currency code</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstListPricesResponse></returns>
		/// <exception cref="M3Exception<LstListPricesResponse>"></exception>
		public async Task<M3Response<LstListPricesResponse>> LstListPrices(
			int? m3CONO = null, 
			string m3PRRF = null, 
			string m3CUCD = null, 
			string m3CUNO = null, 
			DateTime? m3FVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstListPrices",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstListPricesResponse>(
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
		/// Name LstNewPrices
		/// Description List new and changed prices
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNewPricesResponse></returns>
		/// <exception cref="M3Exception<LstNewPricesResponse>"></exception>
		public async Task<M3Response<LstNewPricesResponse>> LstNewPrices(
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNewPrices",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstNewPricesResponse>(
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
		/// Name LstPricelists
		/// Description List pricelists
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRRF">Pricelist</param>
		/// <param name="m3CUCD">Currency code</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPricelistsResponse></returns>
		/// <exception cref="M3Exception<LstPricelistsResponse>"></exception>
		public async Task<M3Response<LstPricelistsResponse>> LstPricelists(
			int? m3CONO = null, 
			string m3PRRF = null, 
			string m3CUCD = null, 
			string m3CUNO = null, 
			DateTime? m3FVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPricelists",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPricelistsResponse>(
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
		/// Name LstPrices
		/// Description List all found prices
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SPDT">Sales price date</param>
		/// <param name="m3OREP">Only relevant prices</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPricesResponse></returns>
		/// <exception cref="M3Exception<LstPricesResponse>"></exception>
		public async Task<M3Response<LstPricesResponse>> LstPrices(
			string m3CUNO, 
			string m3ITNO, 
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3ORTP = null, 
			string m3CUCD = null, 
			string m3WHLO = null, 
			DateTime? m3SPDT = null, 
			int? m3OREP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPrices",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3SPDT.HasValue)
				request.WithQueryParameter("SPDT", m3SPDT.Value.ToM3String());
			if (m3OREP.HasValue)
				request.WithQueryParameter("OREP", m3OREP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPricesResponse>(
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
		/// Name LstScaleLines
		/// Description List scale lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DISY">Discount model (Required)</param>
		/// <param name="m3DIPO">Discount number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3PREX">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstScaleLinesResponse></returns>
		/// <exception cref="M3Exception<LstScaleLinesResponse>"></exception>
		public async Task<M3Response<LstScaleLinesResponse>> LstScaleLines(
			string m3DISY, 
			int m3DIPO, 
			int? m3CONO = null, 
			DateTime? m3FVDT = null, 
			string m3PREX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstScaleLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DISY))
				throw new ArgumentNullException(nameof(m3DISY));

			// Set mandatory parameters
			request
				.WithQueryParameter("DISY", m3DISY.Trim())
				.WithQueryParameter("DIPO", m3DIPO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PREX))
				request.WithQueryParameter("PREX", m3PREX.Trim());

			// Execute the request
			var result = await Execute<LstScaleLinesResponse>(
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
