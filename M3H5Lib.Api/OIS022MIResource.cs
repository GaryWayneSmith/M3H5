/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCostModelLin
		/// Description Add Sales Costing Model Lin
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3SCMO">Costing model - sales price (Required)</param>
		/// <param name="m3SCET">Element type - sales price costing (Required)</param>
		/// <param name="m3CDSE">Sequence number - costing element (Required)</param>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3SCSU">Subtotal</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCostModelLin(
			string m3SCMO, 
			int m3SCET, 
			int m3CDSE, 
			string m3SCEL, 
			string m3SCSU = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCostModelLin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCMO))
				throw new ArgumentNullException(nameof(m3SCMO));
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCMO", m3SCMO.Trim())
				.WithQueryParameter("SCET", m3SCET.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CDSE", m3CDSE.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SCEL", m3SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SCSU))
				request.WithQueryParameter("SCSU", m3SCSU.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddCostingModel
		/// Description Add Sales Costing Model
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3CABA">Calculation base</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCostingModel(
			int? m3CONO = null, 
			string m3SCMO = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3CABA = null, 
			decimal? m3TXID = null, 
			string m3ACGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCostingModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3CABA.HasValue)
				request.WithQueryParameter("CABA", m3CABA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());

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
		/// Name DltCostModelLin
		/// Description Delete Sales Costing Model Line
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3SCET">Element type - sales price costing</param>
		/// <param name="m3CDSE">Sequence number - costing element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCostModelLin(
			int? m3CONO = null, 
			string m3SCMO = null, 
			int? m3SCET = null, 
			int? m3CDSE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltCostModelLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (m3SCET.HasValue)
				request.WithQueryParameter("SCET", m3SCET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3CDSE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltCostingModel
		/// Description Delete Sales Costing Model
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCostingModel(
			int? m3CONO = null, 
			string m3SCMO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltCostingModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());

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
		/// Name GetCostModelLin
		/// Description Get Sales Costing Model Line
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3SCET">Element type - sales price costing</param>
		/// <param name="m3CDSE">Sequence number - costing element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCostModelLinResponse></returns>
		/// <exception cref="M3Exception<GetCostModelLinResponse>"></exception>
		public async Task<M3Response<GetCostModelLinResponse>> GetCostModelLin(
			int? m3CONO = null, 
			string m3SCMO = null, 
			int? m3SCET = null, 
			int? m3CDSE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCostModelLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (m3SCET.HasValue)
				request.WithQueryParameter("SCET", m3SCET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3CDSE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetCostModelLinResponse>(
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
		/// Name GetCostingModel
		/// Description Get Sales Costing Model
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCostingModelResponse></returns>
		/// <exception cref="M3Exception<GetCostingModelResponse>"></exception>
		public async Task<M3Response<GetCostingModelResponse>> GetCostingModel(
			int? m3CONO = null, 
			string m3SCMO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCostingModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());

			// Execute the request
			var result = await Execute<GetCostingModelResponse>(
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
		/// Name LstCostModelLin
		/// Description List Sales Costing Model Line
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3SCET">Element type - sales price costing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCostModelLinResponse></returns>
		/// <exception cref="M3Exception<LstCostModelLinResponse>"></exception>
		public async Task<M3Response<LstCostModelLinResponse>> LstCostModelLin(
			int? m3CONO = null, 
			string m3SCMO = null, 
			int? m3SCET = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCostModelLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (m3SCET.HasValue)
				request.WithQueryParameter("SCET", m3SCET.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstCostModelLinResponse>(
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
		/// Name LstCostingModel
		/// Description List Sales Costing Model
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCostingModelResponse></returns>
		/// <exception cref="M3Exception<LstCostingModelResponse>"></exception>
		public async Task<M3Response<LstCostingModelResponse>> LstCostingModel(
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCostingModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstCostingModelResponse>(
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
		/// Name LstModelRange
		/// Description To list a range of Sales Costing Models
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FCMO">Costing model - sales price (from)</param>
		/// <param name="m3TCMO">Costing model - sales price (to)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelRangeResponse></returns>
		/// <exception cref="M3Exception<LstModelRangeResponse>"></exception>
		public async Task<M3Response<LstModelRangeResponse>> LstModelRange(
			int? m3CONO = null, 
			string m3FCMO = null, 
			string m3TCMO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstModelRange",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCMO))
				request.WithQueryParameter("FCMO", m3FCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCMO))
				request.WithQueryParameter("TCMO", m3TCMO.Trim());

			// Execute the request
			var result = await Execute<LstModelRangeResponse>(
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
		/// Name UpdCostModelLin
		/// Description Update Sales Costing Model Line
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3SCET">Element type - sales price costing</param>
		/// <param name="m3CDSE">Sequence number - costing element</param>
		/// <param name="m3SCEL">Element - sales price costing</param>
		/// <param name="m3SCSU">Subtotal</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCostModelLin(
			int? m3CONO = null, 
			string m3SCMO = null, 
			int? m3SCET = null, 
			int? m3CDSE = null, 
			string m3SCEL = null, 
			string m3SCSU = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdCostModelLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (m3SCET.HasValue)
				request.WithQueryParameter("SCET", m3SCET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3CDSE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCEL))
				request.WithQueryParameter("SCEL", m3SCEL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCSU))
				request.WithQueryParameter("SCSU", m3SCSU.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdCostingModel
		/// Description Update Sales Costing Model
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3CABA">Calculation base</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCostingModel(
			int? m3CONO = null, 
			string m3SCMO = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3CABA = null, 
			decimal? m3TXID = null, 
			string m3ACGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdCostingModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3CABA.HasValue)
				request.WithQueryParameter("CABA", m3CABA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());

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
