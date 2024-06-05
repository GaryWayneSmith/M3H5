/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS025MI;
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
	/// Name: CRS025MI
	/// Component Name: Api: Item Group Interface
	/// Description: Item Group interface
	/// Version Release: 14.x
	///</summary>
	public partial class CRS025MIResource : M3BaseResourceEndpoint
	{
		public CRS025MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS025MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItemGroup
		/// Description Add Item Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITGR">Item group (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_SECU">Seasonal curve</param>
		/// <param name="m3_TECU">Trend curve</param>
		/// <param name="m3_TCWP">Tolerance catch weight percent</param>
		/// <param name="m3_TCWQ">Tolerance catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItemGroup(
			string m3_ITGR, 
			string m3_TX40, 
			string m3_TX15 = null, 
			int? m3_SECU = null, 
			int? m3_TECU = null, 
			int? m3_TCWP = null, 
			decimal? m3_TCWQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItemGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITGR))
				throw new ArgumentNullException("m3_ITGR");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITGR", m3_ITGR.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_SECU.HasValue)
				request.WithQueryParameter("SECU", m3_SECU.Value.ToString());
			if (m3_TECU.HasValue)
				request.WithQueryParameter("TECU", m3_TECU.Value.ToString());
			if (m3_TCWP.HasValue)
				request.WithQueryParameter("TCWP", m3_TCWP.Value.ToString());
			if (m3_TCWQ.HasValue)
				request.WithQueryParameter("TCWQ", m3_TCWQ.Value.ToString());

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
		/// Name DelItemGroup
		/// Description Delete Item Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITGR">Item group (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItemGroup(
			string m3_ITGR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelItemGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITGR))
				throw new ArgumentNullException("m3_ITGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITGR", m3_ITGR.Trim());

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
		/// Name GetItemGroup
		/// Description Get Item Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITGR">Item group (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemGroupResponse></returns>
		/// <exception cref="M3Exception<GetItemGroupResponse>"></exception>
		public async Task<M3Response<GetItemGroupResponse>> GetItemGroup(
			string m3_ITGR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItemGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITGR))
				throw new ArgumentNullException("m3_ITGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITGR", m3_ITGR.Trim());

			// Execute the request
			var result = await Execute<GetItemGroupResponse>(
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
		/// Name LstItemGroup
		/// Description List Item  Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemGroupResponse></returns>
		/// <exception cref="M3Exception<LstItemGroupResponse>"></exception>
		public async Task<M3Response<LstItemGroupResponse>> LstItemGroup(
			string m3_ITGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemGroup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());

			// Execute the request
			var result = await Execute<LstItemGroupResponse>(
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
		/// Name UpdItemGroup
		/// Description Update Item Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITGR">Item group (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_SECU">Seasonal curve</param>
		/// <param name="m3_TECU">Trend curve</param>
		/// <param name="m3_TCWP">Tolerance catch weight percent</param>
		/// <param name="m3_TCWQ">Tolerance catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItemGroup(
			string m3_ITGR, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_SECU = null, 
			int? m3_TECU = null, 
			int? m3_TCWP = null, 
			decimal? m3_TCWQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItemGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITGR))
				throw new ArgumentNullException("m3_ITGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITGR", m3_ITGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_SECU.HasValue)
				request.WithQueryParameter("SECU", m3_SECU.Value.ToString());
			if (m3_TECU.HasValue)
				request.WithQueryParameter("TECU", m3_TECU.Value.ToString());
			if (m3_TCWP.HasValue)
				request.WithQueryParameter("TCWP", m3_TCWP.Value.ToString());
			if (m3_TCWQ.HasValue)
				request.WithQueryParameter("TCWQ", m3_TCWQ.Value.ToString());

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
