/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS175MI;
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
	/// Name: CRS175MI
	/// Component Name: CrossAppBasicData
	/// Description: Cross application basic data interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS175MIResource : M3BaseResourceEndpoint
	{
		public CRS175MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS175MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetGeneralCode
		/// Description Get a record from general code in system table
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STCO">Constant value (Required)</param>
		/// <param name="m3_STKY">Key value (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_LNC2">Language description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetGeneralCodeResponse></returns>
		/// <exception cref="M3Exception<GetGeneralCodeResponse>"></exception>
		public async Task<M3Response<GetGeneralCodeResponse>> GetGeneralCode(
			string m3_STCO, 
			string m3_STKY, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_LNCD = null, 
			string m3_LNC2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetGeneralCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STCO))
				throw new ArgumentNullException("m3_STCO");
			if (string.IsNullOrWhiteSpace(m3_STKY))
				throw new ArgumentNullException("m3_STKY");

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3_STCO.Trim())
				.WithQueryParameter("STKY", m3_STKY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNC2))
				request.WithQueryParameter("LNC2", m3_LNC2.Trim());

			// Execute the request
			var result = await Execute<GetGeneralCodeResponse>(
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
		/// Name GetGeneralParm
		/// Description Get a record from system table CSYPAR
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_STCO">Constant value (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetGeneralParmResponse></returns>
		/// <exception cref="M3Exception<GetGeneralParmResponse>"></exception>
		public async Task<M3Response<GetGeneralParmResponse>> GetGeneralParm(
			string m3_STCO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetGeneralParm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STCO))
				throw new ArgumentNullException("m3_STCO");

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3_STCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetGeneralParmResponse>(
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
		/// Name GetItemFreeFlds
		/// Description Get free field for item (CRS703)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemFreeFldsResponse></returns>
		/// <exception cref="M3Exception<GetItemFreeFldsResponse>"></exception>
		public async Task<M3Response<GetItemFreeFldsResponse>> GetItemFreeFlds(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItemFreeFlds",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetItemFreeFldsResponse>(
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
		/// Name GetSetTradeStat
		/// Description Get settings trade statistics
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSetTradeStatResponse></returns>
		/// <exception cref="M3Exception<GetSetTradeStatResponse>"></exception>
		public async Task<M3Response<GetSetTradeStatResponse>> GetSetTradeStat(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSetTradeStat",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetSetTradeStatResponse>(
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
		/// Name LstCodesByLng
		/// Description List language specific name per code
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_STCO">Constant value</param>
		/// <param name="m3_STKY">Key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCodesByLngResponse></returns>
		/// <exception cref="M3Exception<LstCodesByLngResponse>"></exception>
		public async Task<M3Response<LstCodesByLngResponse>> LstCodesByLng(
			string m3_DIVI = null, 
			string m3_STCO = null, 
			string m3_STKY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCodesByLng",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STCO))
				request.WithQueryParameter("STCO", m3_STCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STKY))
				request.WithQueryParameter("STKY", m3_STKY.Trim());

			// Execute the request
			var result = await Execute<LstCodesByLngResponse>(
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
		/// Name LstCurrRates
		/// Description List currency rates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CRTP">Currency rate type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCurrRatesResponse></returns>
		/// <exception cref="M3Exception<LstCurrRatesResponse>"></exception>
		public async Task<M3Response<LstCurrRatesResponse>> LstCurrRates(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_CRTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCurrRates",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());

			// Execute the request
			var result = await Execute<LstCurrRatesResponse>(
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
		/// Name LstCurrRatesBas
		/// Description List currency rates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCurrRatesBasResponse></returns>
		/// <exception cref="M3Exception<LstCurrRatesBasResponse>"></exception>
		public async Task<M3Response<LstCurrRatesBasResponse>> LstCurrRatesBas(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCurrRatesBas",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstCurrRatesBasResponse>(
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
		/// Name LstGeneralCode
		/// Description List values from general code in system table
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STCO">Constant value (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_LNC2">Language description</param>
		/// <param name="m3_STKY">Key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstGeneralCodeResponse></returns>
		/// <exception cref="M3Exception<LstGeneralCodeResponse>"></exception>
		public async Task<M3Response<LstGeneralCodeResponse>> LstGeneralCode(
			string m3_STCO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_LNCD = null, 
			string m3_LNC2 = null, 
			string m3_STKY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstGeneralCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STCO))
				throw new ArgumentNullException("m3_STCO");

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3_STCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNC2))
				request.WithQueryParameter("LNC2", m3_LNC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STKY))
				request.WithQueryParameter("STKY", m3_STKY.Trim());

			// Execute the request
			var result = await Execute<LstGeneralCodeResponse>(
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
		/// Name LstGeneralName
		/// Description List the general name data from the system tables file
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STCO">Constant value</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_LNC2">Language description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_BLLA">Blank language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstGeneralNameResponse></returns>
		/// <exception cref="M3Exception<LstGeneralNameResponse>"></exception>
		public async Task<M3Response<LstGeneralNameResponse>> LstGeneralName(
			string m3_STCO = null, 
			string m3_LNCD = null, 
			string m3_LNC2 = null, 
			string m3_TX15 = null, 
			int? m3_BLLA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstGeneralName",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STCO))
				request.WithQueryParameter("STCO", m3_STCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNC2))
				request.WithQueryParameter("LNC2", m3_LNC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_BLLA.HasValue)
				request.WithQueryParameter("BLLA", m3_BLLA.Value.ToString());

			// Execute the request
			var result = await Execute<LstGeneralNameResponse>(
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
		/// Name LstGeneralParm
		/// Description List records in system table CSYPAR
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_STCO">Constant value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstGeneralParmResponse></returns>
		/// <exception cref="M3Exception<LstGeneralParmResponse>"></exception>
		public async Task<M3Response<LstGeneralParmResponse>> LstGeneralParm(
			string m3_DIVI = null, 
			string m3_STCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstGeneralParm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STCO))
				request.WithQueryParameter("STCO", m3_STCO.Trim());

			// Execute the request
			var result = await Execute<LstGeneralParmResponse>(
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
		/// Name LstVatPercent
		/// Description List VAT code percentages
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVatPercentResponse></returns>
		/// <exception cref="M3Exception<LstVatPercentResponse>"></exception>
		public async Task<M3Response<LstVatPercentResponse>> LstVatPercent(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_VTCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstVatPercent",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());

			// Execute the request
			var result = await Execute<LstVatPercentResponse>(
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
		/// Name UpdSlsPersonPIN
		/// Description Change Sales Person PIN
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_PWMT">Old PIN code</param>
		/// <param name="m3_PWM1">New PIN code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdSlsPersonPINResponse></returns>
		/// <exception cref="M3Exception<UpdSlsPersonPINResponse>"></exception>
		public async Task<M3Response<UpdSlsPersonPINResponse>> UpdSlsPersonPIN(
			int? m3_CONO = null, 
			string m3_SMCD = null, 
			string m3_PWMT = null, 
			string m3_PWM1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSlsPersonPIN",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PWMT))
				request.WithQueryParameter("PWMT", m3_PWMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PWM1))
				request.WithQueryParameter("PWM1", m3_PWM1.Trim());

			// Execute the request
			var result = await Execute<UpdSlsPersonPINResponse>(
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
