/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse location</param>
		/// <param name="m3_ORDT">Order date</param>
		/// <param name="m3_ORQA">Ordered quantity</param>
		/// <param name="m3_ALUN">Alternate unit of measurement</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ORTP">Order type</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_CFXX">Old CFIN</param>
		/// <param name="m3_CAMA">Calculate markups</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_PLTB">Price list table</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_ATV6">Attribute value - display field 6</param>
		/// <param name="m3_ATV7">Attribute value - display field 7</param>
		/// <param name="m3_ATV8">Attribute value - display field 8</param>
		/// <param name="m3_ATV9">Attribute value - display field 9</param>
		/// <param name="m3_ATV0">Attribute value - display field 10</param>
		/// <param name="m3_CHL1">Business chain - level 1</param>
		/// <param name="m3_CHL2">Business chain - level 2</param>
		/// <param name="m3_CHL3">Business chain - level 3</param>
		/// <param name="m3_CHL4">Business chain - level 4</param>
		/// <param name="m3_SPUN">Sales price unit of measure</param>
		/// <param name="m3_PRMS">Price origin sequence</param>
		/// <param name="m3_PISQ">Price in Sales Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPriceLineResponse></returns>
		/// <exception cref="M3Exception<GetPriceLineResponse>"></exception>
		public async Task<M3Response<GetPriceLineResponse>> GetPriceLine(
			string m3_CUNO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			DateTime? m3_ORDT = null, 
			decimal? m3_ORQA = null, 
			string m3_ALUN = null, 
			string m3_CUCD = null, 
			string m3_ORTP = null, 
			string m3_PRRF = null, 
			string m3_DISY = null, 
			DateTime? m3_DWDT = null, 
			int? m3_CFXX = null, 
			int? m3_CAMA = null, 
			decimal? m3_ATNR = null, 
			string m3_PLTB = null, 
			long? m3_CFIN = null, 
			string m3_ATV6 = null, 
			string m3_ATV7 = null, 
			string m3_ATV8 = null, 
			string m3_ATV9 = null, 
			string m3_ATV0 = null, 
			string m3_CHL1 = null, 
			string m3_CHL2 = null, 
			string m3_CHL3 = null, 
			string m3_CHL4 = null, 
			string m3_SPUN = null, 
			string m3_PRMS = null, 
			int? m3_PISQ = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3_ORDT.Value.ToM3String());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (m3_CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3_CFXX.Value.ToString());
			if (m3_CAMA.HasValue)
				request.WithQueryParameter("CAMA", m3_CAMA.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLTB))
				request.WithQueryParameter("PLTB", m3_PLTB.Trim());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATV6))
				request.WithQueryParameter("ATV6", m3_ATV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATV7))
				request.WithQueryParameter("ATV7", m3_ATV7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATV8))
				request.WithQueryParameter("ATV8", m3_ATV8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATV9))
				request.WithQueryParameter("ATV9", m3_ATV9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATV0))
				request.WithQueryParameter("ATV0", m3_ATV0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL1))
				request.WithQueryParameter("CHL1", m3_CHL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL2))
				request.WithQueryParameter("CHL2", m3_CHL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL3))
				request.WithQueryParameter("CHL3", m3_CHL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL4))
				request.WithQueryParameter("CHL4", m3_CHL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRMS))
				request.WithQueryParameter("PRMS", m3_PRMS.Trim());
			if (m3_PISQ.HasValue)
				request.WithQueryParameter("PISQ", m3_PISQ.Value.ToString());

			// Execute the request
			var result = await Execute<GetPriceLineResponse>(
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
		/// Name LstDiscModels
		/// Description List discount models
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDiscModelsResponse></returns>
		/// <exception cref="M3Exception<LstDiscModelsResponse>"></exception>
		public async Task<M3Response<LstDiscModelsResponse>> LstDiscModels(
			int? m3_CONO = null, 
			string m3_DISY = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());

			// Execute the request
			var result = await Execute<LstDiscModelsResponse>(
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
		/// Name LstDiscNumbers
		/// Description List discount model numbers
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DISY">Discount model (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDiscNumbersResponse></returns>
		/// <exception cref="M3Exception<LstDiscNumbersResponse>"></exception>
		public async Task<M3Response<LstDiscNumbersResponse>> LstDiscNumbers(
			string m3_DISY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDiscNumbers",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DISY))
				throw new ArgumentNullException("m3_DISY");

			// Set mandatory parameters
			request
				.WithQueryParameter("DISY", m3_DISY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstDiscNumbersResponse>(
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
		/// Name LstListPrices
		/// Description List price list details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRRF">Pricelist</param>
		/// <param name="m3_CUCD">Currency code</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstListPricesResponse></returns>
		/// <exception cref="M3Exception<LstListPricesResponse>"></exception>
		public async Task<M3Response<LstListPricesResponse>> LstListPrices(
			int? m3_CONO = null, 
			string m3_PRRF = null, 
			string m3_CUCD = null, 
			string m3_CUNO = null, 
			DateTime? m3_FVDT = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstListPricesResponse>(
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
		/// Name LstNewPrices
		/// Description List new and changed prices
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNewPricesResponse></returns>
		/// <exception cref="M3Exception<LstNewPricesResponse>"></exception>
		public async Task<M3Response<LstNewPricesResponse>> LstNewPrices(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNewPrices",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstNewPricesResponse>(
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
		/// Name LstPricelists
		/// Description List pricelists
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRRF">Pricelist</param>
		/// <param name="m3_CUCD">Currency code</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPricelistsResponse></returns>
		/// <exception cref="M3Exception<LstPricelistsResponse>"></exception>
		public async Task<M3Response<LstPricelistsResponse>> LstPricelists(
			int? m3_CONO = null, 
			string m3_PRRF = null, 
			string m3_CUCD = null, 
			string m3_CUNO = null, 
			DateTime? m3_FVDT = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPricelistsResponse>(
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
		/// Name LstPrices
		/// Description List all found prices
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SPDT">Sales price date</param>
		/// <param name="m3_OREP">Only relevant prices</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPricesResponse></returns>
		/// <exception cref="M3Exception<LstPricesResponse>"></exception>
		public async Task<M3Response<LstPricesResponse>> LstPrices(
			string m3_CUNO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_ORTP = null, 
			string m3_CUCD = null, 
			string m3_WHLO = null, 
			DateTime? m3_SPDT = null, 
			int? m3_OREP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_SPDT.HasValue)
				request.WithQueryParameter("SPDT", m3_SPDT.Value.ToM3String());
			if (m3_OREP.HasValue)
				request.WithQueryParameter("OREP", m3_OREP.Value.ToString());

			// Execute the request
			var result = await Execute<LstPricesResponse>(
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
		/// Name LstScaleLines
		/// Description List scale lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DISY">Discount model (Required)</param>
		/// <param name="m3_DIPO">Discount number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstScaleLinesResponse></returns>
		/// <exception cref="M3Exception<LstScaleLinesResponse>"></exception>
		public async Task<M3Response<LstScaleLinesResponse>> LstScaleLines(
			string m3_DISY, 
			int m3_DIPO, 
			int? m3_CONO = null, 
			DateTime? m3_FVDT = null, 
			string m3_PREX = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DISY))
				throw new ArgumentNullException("m3_DISY");

			// Set mandatory parameters
			request
				.WithQueryParameter("DISY", m3_DISY.Trim())
				.WithQueryParameter("DIPO", m3_DIPO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());

			// Execute the request
			var result = await Execute<LstScaleLinesResponse>(
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
