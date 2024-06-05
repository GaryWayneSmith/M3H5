/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS022MI;
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
	/// Name: OIS022MI
	/// Component Name: SalesCosting
	/// Description: Api: Sales Costing Model
	/// Version Release: 
	///</summary>
	public partial class OIS022MIResource : M3BaseResourceEndpoint
	{
		public OIS022MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS022MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCostModelLin
		/// Description Add Sales Costing Model Lin
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_SCMO">Costing model - sales price (Required)</param>
		/// <param name="m3_SCET">Element type - sales price costing (Required)</param>
		/// <param name="m3_CDSE">Sequence number - costing element (Required)</param>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_SCSU">Subtotal</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCostModelLin(
			string m3_SCMO, 
			int m3_SCET, 
			int m3_CDSE, 
			string m3_SCEL, 
			string m3_SCSU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCostModelLin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SCMO))
				throw new ArgumentNullException("m3_SCMO");
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCMO", m3_SCMO.Trim())
				.WithQueryParameter("SCET", m3_SCET.ToString())
				.WithQueryParameter("CDSE", m3_CDSE.ToString())
				.WithQueryParameter("SCEL", m3_SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SCSU))
				request.WithQueryParameter("SCSU", m3_SCSU.Trim());
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
		/// Name AddCostingModel
		/// Description Add Sales Costing Model
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_CABA">Calculation base</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCostingModel(
			int? m3_CONO = null, 
			string m3_SCMO = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_CABA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCostingModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_CABA.HasValue)
				request.WithQueryParameter("CABA", m3_CABA.Value.ToString());
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
		/// Name DltCostModelLin
		/// Description Delete Sales Costing Model Line
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_SCET">Element type - sales price costing</param>
		/// <param name="m3_CDSE">Sequence number - costing element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCostModelLin(
			int? m3_CONO = null, 
			string m3_SCMO = null, 
			int? m3_SCET = null, 
			int? m3_CDSE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCostModelLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (m3_SCET.HasValue)
				request.WithQueryParameter("SCET", m3_SCET.Value.ToString());
			if (m3_CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3_CDSE.Value.ToString());

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
		/// Name DltCostingModel
		/// Description Delete Sales Costing Model
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCostingModel(
			int? m3_CONO = null, 
			string m3_SCMO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCostingModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());

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
		/// Name GetCostModelLin
		/// Description Get Sales Costing Model Line
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_SCET">Element type - sales price costing</param>
		/// <param name="m3_CDSE">Sequence number - costing element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCostModelLinResponse></returns>
		/// <exception cref="M3Exception<GetCostModelLinResponse>"></exception>
		public async Task<M3Response<GetCostModelLinResponse>> GetCostModelLin(
			int? m3_CONO = null, 
			string m3_SCMO = null, 
			int? m3_SCET = null, 
			int? m3_CDSE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCostModelLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (m3_SCET.HasValue)
				request.WithQueryParameter("SCET", m3_SCET.Value.ToString());
			if (m3_CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3_CDSE.Value.ToString());

			// Execute the request
			var result = await Execute<GetCostModelLinResponse>(
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
		/// Name GetCostingModel
		/// Description Get Sales Costing Model
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCostingModelResponse></returns>
		/// <exception cref="M3Exception<GetCostingModelResponse>"></exception>
		public async Task<M3Response<GetCostingModelResponse>> GetCostingModel(
			int? m3_CONO = null, 
			string m3_SCMO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCostingModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());

			// Execute the request
			var result = await Execute<GetCostingModelResponse>(
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
		/// Name LstCostModelLin
		/// Description List Sales Costing Model Line
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_SCET">Element type - sales price costing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCostModelLinResponse></returns>
		/// <exception cref="M3Exception<LstCostModelLinResponse>"></exception>
		public async Task<M3Response<LstCostModelLinResponse>> LstCostModelLin(
			int? m3_CONO = null, 
			string m3_SCMO = null, 
			int? m3_SCET = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCostModelLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (m3_SCET.HasValue)
				request.WithQueryParameter("SCET", m3_SCET.Value.ToString());

			// Execute the request
			var result = await Execute<LstCostModelLinResponse>(
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
		/// Name LstCostingModel
		/// Description List Sales Costing Model
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCostingModelResponse></returns>
		/// <exception cref="M3Exception<LstCostingModelResponse>"></exception>
		public async Task<M3Response<LstCostingModelResponse>> LstCostingModel(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCostingModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstCostingModelResponse>(
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
		/// Description To list a range of Sales Costing Models
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FCMO">Costing model - sales price (from)</param>
		/// <param name="m3_TCMO">Costing model - sales price (to)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelRangeResponse></returns>
		/// <exception cref="M3Exception<LstModelRangeResponse>"></exception>
		public async Task<M3Response<LstModelRangeResponse>> LstModelRange(
			int? m3_CONO = null, 
			string m3_FCMO = null, 
			string m3_TCMO = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCMO))
				request.WithQueryParameter("FCMO", m3_FCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCMO))
				request.WithQueryParameter("TCMO", m3_TCMO.Trim());

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
		/// Name UpdCostModelLin
		/// Description Update Sales Costing Model Line
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_SCET">Element type - sales price costing</param>
		/// <param name="m3_CDSE">Sequence number - costing element</param>
		/// <param name="m3_SCEL">Element - sales price costing</param>
		/// <param name="m3_SCSU">Subtotal</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCostModelLin(
			int? m3_CONO = null, 
			string m3_SCMO = null, 
			int? m3_SCET = null, 
			int? m3_CDSE = null, 
			string m3_SCEL = null, 
			string m3_SCSU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCostModelLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (m3_SCET.HasValue)
				request.WithQueryParameter("SCET", m3_SCET.Value.ToString());
			if (m3_CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3_CDSE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCEL))
				request.WithQueryParameter("SCEL", m3_SCEL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCSU))
				request.WithQueryParameter("SCSU", m3_SCSU.Trim());
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
		/// Name UpdCostingModel
		/// Description Update Sales Costing Model
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_CABA">Calculation base</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCostingModel(
			int? m3_CONO = null, 
			string m3_SCMO = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_CABA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCostingModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_CABA.HasValue)
				request.WithQueryParameter("CABA", m3_CABA.Value.ToString());
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
	}
}
// EOF
