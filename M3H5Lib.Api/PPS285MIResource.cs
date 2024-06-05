/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS285MI;
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
	/// Name: PPS285MI
	/// Component Name: Purchase Costing
	/// Description: Purchase Costing Model and Elements
	/// Version Release: 5e90
	///</summary>
	public partial class PPS285MIResource : M3BaseResourceEndpoint
	{
		public PPS285MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS285MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddModel
		/// Description Create Purchase Costing Model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WSCA">Costing model - purchasing (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_PCMT">Costing model type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddModel(
			string m3_WSCA, 
			string m3_TX40, 
			int m3_PCMT, 
			int? m3_CONO = null, 
			string m3_TX15 = null, 
			decimal? m3_TXID = null, 
			string m3_ACGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WSCA))
				throw new ArgumentNullException("m3_WSCA");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("WSCA", m3_WSCA.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("PCMT", m3_PCMT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());

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
		/// Name AddModelElement
		/// Description Create Purchase Costing Model Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WSCA">Costing model - purchasing (Required)</param>
		/// <param name="m3_CDSE">Sequence number - costing element (Required)</param>
		/// <param name="m3_CEID">Purchase costing element (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddModelElement(
			string m3_WSCA, 
			int m3_CDSE, 
			string m3_CEID, 
			int? m3_CONO = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddModelElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WSCA))
				throw new ArgumentNullException("m3_WSCA");
			if (string.IsNullOrWhiteSpace(m3_CEID))
				throw new ArgumentNullException("m3_CEID");

			// Set mandatory parameters
			request
				.WithQueryParameter("WSCA", m3_WSCA.Trim())
				.WithQueryParameter("CDSE", m3_CDSE.ToString())
				.WithQueryParameter("CEID", m3_CEID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name DltModel
		/// Description Delete Purchase Costing Model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WSCA">Costing model - purchasing (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltModel(
			string m3_WSCA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WSCA))
				throw new ArgumentNullException("m3_WSCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("WSCA", m3_WSCA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name DltModelElement
		/// Description Delete Certaion Purchase Costing Model Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WSCA">Costing model - purchasing (Required)</param>
		/// <param name="m3_CDSE">Sequence number - costing element (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltModelElement(
			string m3_WSCA, 
			int m3_CDSE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltModelElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WSCA))
				throw new ArgumentNullException("m3_WSCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("WSCA", m3_WSCA.Trim())
				.WithQueryParameter("CDSE", m3_CDSE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name GetModel
		/// Description Get Certain Purchase Costong Model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WSCA">Costing model - purchasing (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetModelResponse></returns>
		/// <exception cref="M3Exception<GetModelResponse>"></exception>
		public async Task<M3Response<GetModelResponse>> GetModel(
			string m3_WSCA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WSCA))
				throw new ArgumentNullException("m3_WSCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("WSCA", m3_WSCA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetModelResponse>(
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
		/// Name GetModelElement
		/// Description Get Certain Purchase Costing Model Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WSCA">Costing model - purchasing (Required)</param>
		/// <param name="m3_CDSE">Sequence number - costing element (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetModelElementResponse></returns>
		/// <exception cref="M3Exception<GetModelElementResponse>"></exception>
		public async Task<M3Response<GetModelElementResponse>> GetModelElement(
			string m3_WSCA, 
			int m3_CDSE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetModelElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WSCA))
				throw new ArgumentNullException("m3_WSCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("WSCA", m3_WSCA.Trim())
				.WithQueryParameter("CDSE", m3_CDSE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetModelElementResponse>(
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
		/// Name LstCodeByText
		/// Description List Code By Text
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCodeByTextResponse></returns>
		/// <exception cref="M3Exception<LstCodeByTextResponse>"></exception>
		public async Task<M3Response<LstCodeByTextResponse>> LstCodeByText(
			string m3_TX40, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCodeByText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Execute the request
			var result = await Execute<LstCodeByTextResponse>(
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
		/// Name LstElemByText
		/// Description List Element ByText
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_TX15">Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElemByTextResponse></returns>
		/// <exception cref="M3Exception<LstElemByTextResponse>"></exception>
		public async Task<M3Response<LstElemByTextResponse>> LstElemByText(
			string m3_TX15, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstElemByText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TX15))
				throw new ArgumentNullException("m3_TX15");

			// Set mandatory parameters
			request
				.WithQueryParameter("TX15", m3_TX15.Trim());

			// Execute the request
			var result = await Execute<LstElemByTextResponse>(
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
		/// Name LstModel
		/// Description List Purchase Costing Models
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelResponse></returns>
		/// <exception cref="M3Exception<LstModelResponse>"></exception>
		public async Task<M3Response<LstModelResponse>> LstModel(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstModelResponse>(
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
		/// Name LstModelElement
		/// Description List Purchase Costing Model Elements
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WSCA">Costing model - purchasing (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelElementResponse></returns>
		/// <exception cref="M3Exception<LstModelElementResponse>"></exception>
		public async Task<M3Response<LstModelElementResponse>> LstModelElement(
			string m3_WSCA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstModelElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WSCA))
				throw new ArgumentNullException("m3_WSCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("WSCA", m3_WSCA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstModelElementResponse>(
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
		/// Name LstModelRange
		/// Description List a range of Purchase Costing Models
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FSCA">Costing model - purchase (from)</param>
		/// <param name="m3_TSCA">Costing model - purchase (to)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelRangeResponse></returns>
		/// <exception cref="M3Exception<LstModelRangeResponse>"></exception>
		public async Task<M3Response<LstModelRangeResponse>> LstModelRange(
			string m3_CONO = null, 
			string m3_FSCA = null, 
			string m3_TSCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstModelRange",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CONO))
				request.WithQueryParameter("CONO", m3_CONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSCA))
				request.WithQueryParameter("FSCA", m3_FSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSCA))
				request.WithQueryParameter("TSCA", m3_TSCA.Trim());

			// Execute the request
			var result = await Execute<LstModelRangeResponse>(
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
		/// Name UpdModel
		/// Description Update Purchase Costing Model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WSCA">Costing model - purchasing (Required)</param>
		/// <param name="m3_PCMT">Costing model type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdModel(
			string m3_WSCA, 
			int m3_PCMT, 
			int? m3_CONO = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			decimal? m3_TXID = null, 
			string m3_ACGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WSCA))
				throw new ArgumentNullException("m3_WSCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("WSCA", m3_WSCA.Trim())
				.WithQueryParameter("PCMT", m3_PCMT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());

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
		/// Name UpdModelElement
		/// Description Update Certain Purchase Costing Model Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WSCA">Costing model - purchasing (Required)</param>
		/// <param name="m3_CDSE">Sequence number - costing element (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CEID">Purchase costing element</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdModelElement(
			string m3_WSCA, 
			int m3_CDSE, 
			int? m3_CONO = null, 
			string m3_CEID = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdModelElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WSCA))
				throw new ArgumentNullException("m3_WSCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("WSCA", m3_WSCA.Trim())
				.WithQueryParameter("CDSE", m3_CDSE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CEID))
				request.WithQueryParameter("CEID", m3_CEID.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
